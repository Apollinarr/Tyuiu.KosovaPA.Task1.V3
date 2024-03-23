using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KosovaPA.Task1.V3
{
    public partial class DepartmentsForm : MaterialForm
    {
        List<Teacher> teachers;
        List<Department> departments = new List<Department>();
        public DepartmentsForm()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            materialButtonAddDepartmnet_KPA.Enabled = false;
            materialButtonEdit_KPA.Enabled = false;
            materialButtonDelete_KPA.Enabled = false;

            List<string[]> lines = File.ReadAllLines("Departments.csv", Encoding.GetEncoding(1251)).Select(d => d.Split(' ')).ToList();
            foreach (var line in lines)
            {
                if (line[2] == "-")
                {
                    Department departmnet = new Department(Convert.ToInt32(line[0]), line[1]);
                    departments.Add(departmnet);
                }
                else
                {
                    foreach (var teacher in teachers)
                    {
                        if (teacher.Name == line[2])
                        {
                            Department departmnet = new Department(Convert.ToInt32(line[0]), line[1], teacher);
                            departments.Add(departmnet);
                        }
                    }
                }
                dataGridViewDepartmnets_KPA.Rows.Add(line[0], line[1], line[2]);
            }

            materialLabelDepCount_KPA.Text = "Количество: " + departments.Count();
            teachers = new List<Teacher>();
        }

        private void materialButtonAddDepartmnet_KPA_Click(object sender, EventArgs e)
        {
            if (CheckCode() && CheckName() && CheckHeadTeacher())
            {
                try
                {
                    Department department = new Department(Convert.ToInt32(materialTextBoxCodeDepartment_KPA.Text), materialTextBoxDepartmentName_KPA.Text);
                    if (materialComboBoxTeachers_KPA.SelectedIndex != -1)
                    {
                        foreach (var teacher in teachers)
                        {
                            if (teacher.Name == materialComboBoxTeachers_KPA.SelectedItem.ToString())
                            {
                                department.AppointHeadTeacher(teacher);
                                break;
                            }
                        }
                    }
                    departments.Add(department);

                    using (var streamWriter = new StreamWriter(@"Departments.csv", true, Encoding.GetEncoding(1251)))
                    {
                        streamWriter.WriteLine(department.ToString());
                    }

                    dataGridViewDepartmnets_KPA.Rows.Add(department.ToString().Split(' '));

                    ClearAllFields();

                    materialLabelDepCount_KPA.Text = "Количество: " + departments.Count();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool CheckCode() => materialTextBoxCodeDepartment_KPA.TextLength > 0;

        private bool CheckName() => materialTextBoxDepartmentName_KPA.TextLength > 0;

        private bool CheckHeadTeacher()
        {
            return true;
        }

        private void materialTextBoxDepartmentName_KPA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void materialTextBoxCodeDepartment_KPA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridViewDepartmnets_KPA_Click(object sender, EventArgs e)
        {
            if (dataGridViewDepartmnets_KPA.CurrentRow.Index == dataGridViewDepartmnets_KPA.Rows.Count - 1)
            {
                materialButtonAddDepartmnet_KPA.Enabled = true;
                materialButtonEdit_KPA.Enabled = false;
                materialButtonDelete_KPA.Enabled = false;

                ClearAllFields();
            }
            else
            {
                materialButtonAddDepartmnet_KPA.Enabled = false;
                materialButtonEdit_KPA.Enabled = true;
                materialButtonDelete_KPA.Enabled = true;

                materialTextBoxCodeDepartment_KPA.Text = dataGridViewDepartmnets_KPA.CurrentRow.Cells[0].Value.ToString();
                materialTextBoxDepartmentName_KPA.Text = dataGridViewDepartmnets_KPA.CurrentRow.Cells[1].Value.ToString();
                if (dataGridViewDepartmnets_KPA.CurrentRow.Cells[2].Value.ToString() != "-")
                {
                    materialComboBoxTeachers_KPA.Items.Add(dataGridViewDepartmnets_KPA.CurrentRow.Cells[2].Value.ToString());
                }
                else
                {
                    materialComboBoxTeachers_KPA.SelectedIndex = -1;
                }
            }
        }

        private void ClearAllFields()
        {
            materialTextBoxCodeDepartment_KPA.Clear();
            materialTextBoxDepartmentName_KPA.Clear();
            materialComboBoxTeachers_KPA.SelectedIndex = -1;
        }

        private void materialButtonEdit_KPA_Click(object sender, EventArgs e)
        {
            if (CheckCode() && CheckName() && CheckHeadTeacher())
            {
                try
                {
                    Department department = new Department(Convert.ToInt32(dataGridViewDepartmnets_KPA.CurrentRow.Cells[0].Value), dataGridViewDepartmnets_KPA.CurrentRow.Cells[1].Value.ToString());
                    if (dataGridViewDepartmnets_KPA.CurrentRow.Cells[2].Value.ToString() != "-")
                    {
                        foreach (var teacher in teachers)
                        {
                            if (teacher.Name == dataGridViewDepartmnets_KPA.CurrentRow.Cells[2].Value.ToString())
                            {
                                department.AppointHeadTeacher(teacher);
                                break;
                            }
                        }
                    }

                    for (int i = 0; i < departments.Count; i++)
                    {
                        if (departments[i].CompareTo(department))
                        {
                            departments.RemoveAt(i);
                            break;
                        }
                    }

                    Department newDepartment = new Department(Convert.ToInt32(materialTextBoxCodeDepartment_KPA.Text), materialTextBoxDepartmentName_KPA.Text);
                    if (materialComboBoxTeachers_KPA.SelectedIndex != -1)
                    {
                        foreach (var teacher in teachers)
                        {
                            if (teacher.Name == materialComboBoxTeachers_KPA.SelectedItem.ToString())
                            {
                                newDepartment.AppointHeadTeacher(teacher);
                                break;
                            }
                        }
                    }
                    departments.Add(newDepartment);

                    using (var streamWriter = new StreamWriter(@"Departments.csv", false, Encoding.GetEncoding(1251)))
                    {
                        foreach (var dep in departments)
                        {
                            streamWriter.WriteLine(dep.ToString());
                        }
                    }

                    dataGridViewDepartmnets_KPA.CurrentRow.Cells[0].Value = materialTextBoxCodeDepartment_KPA.Text;
                    dataGridViewDepartmnets_KPA.CurrentRow.Cells[1].Value = materialTextBoxDepartmentName_KPA.Text;

                    if (newDepartment.HeadTeacher is null)
                    {
                        dataGridViewDepartmnets_KPA.CurrentRow.Cells[2].Value = "-";

                    }
                    else
                    {
                        dataGridViewDepartmnets_KPA.CurrentRow.Cells[2].Value = newDepartment.HeadTeacher.Name.ToString();
                    }

                    ClearAllFields();

                    materialButtonEdit_KPA.Enabled = false;
                    materialButtonDelete_KPA.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void materialButtonDelete_KPA_Click(object sender, EventArgs e)
        {
            try
            {
                Department department = new Department(Convert.ToInt32(dataGridViewDepartmnets_KPA.CurrentRow.Cells[0].Value), dataGridViewDepartmnets_KPA.CurrentRow.Cells[1].Value.ToString());
                if (dataGridViewDepartmnets_KPA.CurrentRow.Cells[2].Value.ToString() != "-")
                {
                    foreach (var teacher in teachers)
                    {
                        if (teacher.Name == dataGridViewDepartmnets_KPA.CurrentRow.Cells[2].Value.ToString())
                        {
                            department.AppointHeadTeacher(teacher);
                            break;
                        }
                    }
                }

                for (int i = 0; i < departments.Count; i++)
                {
                    if (departments[i].CompareTo(department))
                    {
                        departments.RemoveAt(i);
                        break;
                    }
                }

                dataGridViewDepartmnets_KPA.Rows.RemoveAt(dataGridViewDepartmnets_KPA.CurrentRow.Index);

                using (var streamWriter = new StreamWriter(@"Departments.csv", false, Encoding.GetEncoding(1251)))
                {
                    foreach (var dep in departments)
                    {
                        streamWriter.WriteLine(dep.ToString());
                    }
                }

                ClearAllFields();

                materialLabelDepCount_KPA.Text = "Количество: " + departments.Count();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
