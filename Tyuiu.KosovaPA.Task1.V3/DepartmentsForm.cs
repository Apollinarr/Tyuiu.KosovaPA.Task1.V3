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
        List<Teacher> teachers = new List<Teacher>();
        List<Department> departments = new List<Department>();
        public DepartmentsForm(List<Teacher> teachers, List<Department> departments)
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            this.departments = departments;
            this.teachers = teachers;
        }

        private void DepartmentsForm_Load(object sender, EventArgs e)
        {
            materialButtonAddDepartmnet_KPA.Enabled = false;
            materialButtonEdit_KPA.Enabled = false;
            materialButtonDelete_KPA.Enabled = false;

            foreach (var item in departments)
            {
                dataGridViewDepartmnets_KPA.Rows.Add(item.ToString().Split(' '));
            }

            materialLabelDepCount_KPA.Text = "Количество: " + departments.Count();
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
            materialComboBoxTeachers_KPA.Items.Clear();

            if (dataGridViewDepartmnets_KPA.CurrentRow.Index == dataGridViewDepartmnets_KPA.Rows.Count - 1)
            {
                materialButtonAddDepartmnet_KPA.Enabled = true;
                materialButtonEdit_KPA.Enabled = false;
                materialButtonDelete_KPA.Enabled = false;

                ClearAllFields();

                foreach (var t in teachers)
                {
                    if (t.Department is null)
                    {
                        materialComboBoxTeachers_KPA.Items.Add(t.Name);
                    }
                }
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
                    foreach (var t in teachers)
                    {
                        if (t.Department.Name == dataGridViewDepartmnets_KPA.CurrentRow.Cells[1].Value.ToString())
                        {
                            materialComboBoxTeachers_KPA.Items.Add(t.Name);
                        }
                    }
                    materialComboBoxTeachers_KPA.SelectedIndex = materialComboBoxTeachers_KPA.Items.IndexOf(dataGridViewDepartmnets_KPA.CurrentRow.Cells[1].Value.ToString());
                }
                else
                {
                    foreach (var t in teachers)
                    {
                        if (t.Department is not null && t.Department.Name == dataGridViewDepartmnets_KPA.CurrentRow.Cells[1].Value.ToString())
                        {
                            materialComboBoxTeachers_KPA.Items.Add(t.Name);
                        }
                    }
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
