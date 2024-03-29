using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tyuiu.KosovaPA.Task1.V3
{
    public partial class TeachersForm : MaterialForm
    {
        List<Teacher> teachers = new List<Teacher>();
        List<Department> departments = new List<Department>();
        List<Subject> subjects = new List<Subject>();
        public TeachersForm(List<Teacher> teachers, List<Department> departments, List<Subject> subjects)
        {
            InitializeComponent();
            this.departments = departments;
            this.subjects = subjects;
            this.teachers = teachers;
        }

        private void TeachersForm_Load(object sender, EventArgs e)
        {
            materialButtonAddTeacher_KPA.Enabled = false;
            materialButtonEditTeacher_KPA.Enabled = false;
            materialButtonDeleteTeacher_KPA.Enabled = false;

            foreach (var item in teachers)
            {
                dataGridViewTeachers_KPA.Rows.Add(item.ToString().Split(' '));
            }
            materialLabelCountTeachers_KPA.Text = "Количество: " + teachers.Count;

            foreach (var item in subjects)
            {
                materialComboBoxTeacherSubject_KPA.Items.Add(item.Name);
            }
            foreach (var item in departments)
            {
                materialComboBoxTeacherDepartment_KPA.Items.Add(item.Name);
            }
        }

        private void materialButtonAddTeacher_KPA_Click(object sender, EventArgs e)
        {
            if (CheckName() && CheckPosition() && CheckClassroom())
            {
                try
                {
                    if (materialComboBoxTeacherSubject_KPA.SelectedIndex == -1)
                    {
                        if (materialComboBoxTeacherDepartment_KPA.SelectedIndex == -1)
                        {
                            Teacher teacher = new Teacher(materialTextBoxTeacherName_KPA.Text, materialTextBoxTeacherPosition_KPA.Text,
                                null, null, Convert.ToInt32(materialTextBoxTeacherClassroom_KPA.Text));
                            teachers.Add(teacher);
                            using (var streamWriter = new StreamWriter(@"Teachers.csv", true, Encoding.GetEncoding(1251)))
                            {
                                streamWriter.WriteLine(teacher.ToString());
                            }
                            dataGridViewTeachers_KPA.Rows.Add(teacher.ToString().Split(' '));
                        }
                        else
                        {
                            foreach (var dep in departments)
                            {
                                if (dep.Name == materialComboBoxTeacherDepartment_KPA.SelectedValue)
                                {
                                    Teacher teacher = new Teacher(materialTextBoxTeacherName_KPA.Text, materialTextBoxTeacherPosition_KPA.Text,
                                        null, dep, Convert.ToInt32(materialTextBoxTeacherClassroom_KPA.Text));
                                    teachers.Add(teacher);
                                    using (var streamWriter = new StreamWriter(@"Teachers.csv", true, Encoding.GetEncoding(1251)))
                                    {
                                        streamWriter.WriteLine(teacher.ToString());
                                    }
                                    dataGridViewTeachers_KPA.Rows.Add(teacher.ToString().Split(' '));
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        Subject subject = null;
                        foreach (var sub in subjects)
                        {
                            if (sub.Name == materialComboBoxTeacherSubject_KPA.SelectedItem)
                            {
                                subject = sub;
                                break;
                            }
                        }
                        if (materialComboBoxTeacherDepartment_KPA.SelectedIndex == -1)
                        {
                            Teacher teacher = new Teacher(materialTextBoxTeacherName_KPA.Text, materialTextBoxTeacherPosition_KPA.Text,
                                subject, null, Convert.ToInt32(materialTextBoxTeacherClassroom_KPA.Text));
                            teachers.Add(teacher);
                            using (var streamWriter = new StreamWriter(@"Teachers.csv", true, Encoding.GetEncoding(1251)))
                            {
                                streamWriter.WriteLine(teacher.ToString());
                            }
                            dataGridViewTeachers_KPA.Rows.Add(teacher.ToString().Split(' '));
                        }
                        else
                        {
                            foreach (var dep in departments)
                            {
                                if (dep.Name == materialComboBoxTeacherDepartment_KPA.SelectedItem)
                                {
                                    Teacher teacher = new Teacher(materialTextBoxTeacherName_KPA.Text, materialTextBoxTeacherPosition_KPA.Text,
                                        subject, dep, Convert.ToInt32(materialTextBoxTeacherClassroom_KPA.Text));
                                    teachers.Add(teacher);
                                    using (var streamWriter = new StreamWriter(@"Teachers.csv", true, Encoding.GetEncoding(1251)))
                                    {
                                        streamWriter.WriteLine(teacher.ToString());
                                    }
                                    dataGridViewTeachers_KPA.Rows.Add(teacher.ToString().Split(' '));
                                    break;
                                }
                            }
                        }
                    }
                    ClearAllFields();
                    materialLabelCountTeachers_KPA.Text = "Количество: " + teachers.Count();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void materialTextBoxTeacherName_KPA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void materialTextBoxTeacherPosition_KPA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void materialTextBoxTeacherClassroom_KPA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool CheckName() => materialTextBoxTeacherName_KPA.TextLength > 0;

        private bool CheckPosition() => materialTextBoxTeacherPosition_KPA.TextLength > 0;

        private bool CheckClassroom() => materialTextBoxTeacherClassroom_KPA.TextLength > 0;

        private void dataGridViewTeachers_KPA_Click(object sender, EventArgs e)
        {
            if (dataGridViewTeachers_KPA.CurrentRow.Index == dataGridViewTeachers_KPA.Rows.Count - 1)
            {
                materialButtonAddTeacher_KPA.Enabled = true;
                materialButtonEditTeacher_KPA.Enabled = false;
                materialButtonDeleteTeacher_KPA.Enabled = false;

                ClearAllFields();
            }
            else
            {
                materialButtonAddTeacher_KPA.Enabled = false;
                materialButtonEditTeacher_KPA.Enabled = true;
                materialButtonDeleteTeacher_KPA.Enabled = true;

                materialTextBoxTeacherName_KPA.Text = dataGridViewTeachers_KPA.CurrentRow.Cells[0].Value.ToString();
                materialTextBoxTeacherPosition_KPA.Text = dataGridViewTeachers_KPA.CurrentRow.Cells[1].Value.ToString();
                if (dataGridViewTeachers_KPA.CurrentRow.Cells[2].Value.ToString() != "-")
                {
                    materialComboBoxTeacherSubject_KPA.SelectedIndex = materialComboBoxTeacherSubject_KPA.Items.IndexOf(dataGridViewTeachers_KPA.CurrentRow.Cells[2].Value.ToString());
                }
                else
                {
                    materialComboBoxTeacherSubject_KPA.SelectedIndex = -1;
                }
                if (dataGridViewTeachers_KPA.CurrentRow.Cells[3].Value.ToString() != "-")
                {
                    materialComboBoxTeacherDepartment_KPA.SelectedIndex = materialComboBoxTeacherDepartment_KPA.Items.IndexOf(dataGridViewTeachers_KPA.CurrentRow.Cells[3].Value.ToString());
                }
                else
                {
                    materialComboBoxTeacherDepartment_KPA.SelectedIndex = -1;
                }
                materialTextBoxTeacherClassroom_KPA.Text = dataGridViewTeachers_KPA.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void ClearAllFields()
        {
            materialTextBoxTeacherName_KPA.Clear();
            materialTextBoxTeacherPosition_KPA.Clear();
            materialComboBoxTeacherSubject_KPA.SelectedIndex = -1;
            materialComboBoxTeacherDepartment_KPA.SelectedIndex = -1;
            materialTextBoxTeacherClassroom_KPA.Clear();
        }

        private void materialButtonEditTeacher_KPA_Click(object sender, EventArgs e)
        {
            if (CheckName() && CheckPosition() && CheckClassroom())
            {
                try
                {
                    Teacher teacher = new Teacher(dataGridViewTeachers_KPA.CurrentRow.Cells[0].Value.ToString(),
                        dataGridViewTeachers_KPA.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(dataGridViewTeachers_KPA.CurrentRow.Cells[4].Value));
                    if (dataGridViewTeachers_KPA.CurrentRow.Cells[2].Value.ToString() != "-")
                    {
                        foreach (var sub in subjects)
                        {
                            if (sub.Name == dataGridViewTeachers_KPA.CurrentRow.Cells[2].Value.ToString())
                            {
                                teacher.AppointSubject(sub);
                                break;
                            }
                        }
                    }
                    if (dataGridViewTeachers_KPA.CurrentRow.Cells[3].Value.ToString() != "-")
                    {
                        foreach (var dep in departments)
                        {
                            if (dep.Name == dataGridViewTeachers_KPA.CurrentRow.Cells[3].Value.ToString())
                            {
                                teacher.AppointDepartment(dep);
                                break;
                            }
                        }
                    }

                    teachers.Remove(teacher);

                    Teacher newTeacher = new Teacher(materialTextBoxTeacherName_KPA.Text, materialTextBoxTeacherPosition_KPA.Text, Convert.ToInt32(materialTextBoxTeacherClassroom_KPA.Text));

                    if (materialComboBoxTeacherSubject_KPA.SelectedIndex != -1)
                    {
                        foreach (var sub in subjects)
                        {
                            if (sub.Name == materialComboBoxTeacherSubject_KPA.SelectedItem)
                            {
                                newTeacher.AppointSubject(sub);
                                break;
                            }
                        }
                    }
                    if (materialComboBoxTeacherDepartment_KPA.SelectedIndex != -1)
                    {
                        foreach (var dep in departments)
                        {
                            if (dep.Name == materialComboBoxTeacherDepartment_KPA.SelectedItem)
                            {
                                newTeacher.AppointDepartment(dep);
                                break;
                            }
                        }
                    }
                    teachers.Add(newTeacher);
                    using (var streamWriter = new StreamWriter(@"Teachers.csv", false, Encoding.GetEncoding(1251)))
                    {
                        foreach (var t in teachers)
                        {
                            streamWriter.WriteLine(t.ToString());
                        }
                    }
                    dataGridViewTeachers_KPA.CurrentRow.Cells[0].Value = materialTextBoxTeacherName_KPA.Text;
                    dataGridViewTeachers_KPA.CurrentRow.Cells[1].Value = materialTextBoxTeacherPosition_KPA.Text;
                    if (newTeacher.Subject is null)
                    {
                        dataGridViewTeachers_KPA.CurrentRow.Cells[2].Value = "-";
                    }
                    else
                    {
                        dataGridViewTeachers_KPA.CurrentRow.Cells[2].Value = newTeacher.Subject.Name;
                    }
                    if (newTeacher.Department is null)
                    {
                        dataGridViewTeachers_KPA.CurrentRow.Cells[3].Value = "-";
                    }
                    else
                    {
                        dataGridViewTeachers_KPA.CurrentRow.Cells[3].Value = newTeacher.Department.Name;
                    }
                    dataGridViewTeachers_KPA.CurrentRow.Cells[4].Value = materialTextBoxTeacherClassroom_KPA.Text;
                    ClearAllFields();
                    materialButtonEditTeacher_KPA.Enabled = false;
                    materialButtonDeleteTeacher_KPA.Enabled = false;
                    materialLabelCountTeachers_KPA.Text = "Количество: " + teachers.Count();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void materialButtonDeleteTeacher_KPA_Click(object sender, EventArgs e)
        {
            if (CheckName() && CheckPosition() && CheckClassroom())
            {
                try
                {
                    Teacher teacher = new Teacher(dataGridViewTeachers_KPA.CurrentRow.Cells[0].Value.ToString(),
                        dataGridViewTeachers_KPA.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(dataGridViewTeachers_KPA.CurrentRow.Cells[4].Value));
                    if (dataGridViewTeachers_KPA.CurrentRow.Cells[2].Value.ToString() != "-")
                    {
                        foreach (var sub in subjects)
                        {
                            if (sub.Name == dataGridViewTeachers_KPA.CurrentRow.Cells[2].Value.ToString())
                            {
                                teacher.AppointSubject(sub);
                                break;
                            }
                        }
                    }
                    if (dataGridViewTeachers_KPA.CurrentRow.Cells[3].Value.ToString() != "-")
                    {
                        foreach (var dep in departments)
                        {
                            if (dep.Name == dataGridViewTeachers_KPA.CurrentRow.Cells[3].Value.ToString())
                            {
                                teacher.AppointDepartment(dep);
                                break;
                            }
                        }
                    }

                    teachers.Remove(teacher);
                    using (var streamWriter = new StreamWriter(@"Teachers.csv", false, Encoding.GetEncoding(1251)))
                    {
                        foreach (var t in teachers)
                        {
                            streamWriter.WriteLine(t.ToString());
                        }
                    }
                    dataGridViewTeachers_KPA.Rows.RemoveAt(dataGridViewTeachers_KPA.CurrentRow.Index);
                    ClearAllFields();
                    materialButtonEditTeacher_KPA.Enabled = false;
                    materialButtonDeleteTeacher_KPA.Enabled = false;
                    materialLabelCountTeachers_KPA.Text = "Количество: " + teachers.Count();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
