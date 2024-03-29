using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KosovaPA.Task1.V3
{
    public partial class MainForm : MaterialForm
    {
        List<Department> departments = new List<Department>();
        List<Teacher> teachers = new List<Teacher>();
        List<Subject> subjects = new List<Subject>();
        public MainForm()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("Subjects.csv"))
            {
                using (FileStream fs = File.Create("Subjects.csv"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("");
                }
            }
            else
            {
                UpdateSubjectsList();
            }

            if (!File.Exists("Departments.csv"))
            {
                using (FileStream fs = File.Create("Departments.csv"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("");
                }
            }
            else
            {
                UpdateDepartmentsList();
            }

            if (!File.Exists("Teachers.csv"))
            {
                using (FileStream fs = File.Create("Teachers.csv"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("");
                }
            }
            else
            {
                UpdateTeachersList();
            }
        }

        private void кафедрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form departmnetForm = new DepartmentsForm(teachers, departments);
            departmnetForm.ShowDialog();

            departments.Clear();
            UpdateDepartmentsList();
            dataGridViewTeachers_KPA.Rows.Clear();
            materialTextBoxDepartmentCode_KPA.Clear();
            materialTextBoxDepartmentName_KPA.Clear();
            materialTextBoxHeadTecher_KPA.Clear();
        }

        private void UpdateDepartmentsList()
        {
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
            }
            materialComboBoxDepartment_KPI.Items.Clear();
            foreach (var dep in departments)
            {
                materialComboBoxDepartment_KPI.Items.Add(dep.Name);
            }
        }

        private void UpdateSubjectsList()
        {
            List<string[]> lines = File.ReadAllLines("Subjects.csv", Encoding.GetEncoding(1251)).Select(s => s.Split(' ')).ToList();
            foreach (var line in lines)
            {
                bool isExam;
                if (line[3] == "Экзамен")
                {
                    isExam = true;
                }
                else
                {
                    isExam = false;
                }
                Subject subject = new Subject(Convert.ToInt32(line[0]), line[1], Convert.ToInt32(line[2]), isExam);
                subjects.Add(subject);
            }
        }

        private void UpdateTeachersList()
        {
            List<string[]> lines = File.ReadAllLines("Teachers.csv", Encoding.GetEncoding(1251)).Select(t => t.Split(' ')).ToList();
            foreach (var line in lines)
            {
                if (line[2] == "-")
                {
                    if (line[3] == "-")
                    {
                        Teacher teacher = new Teacher(line[0], line[1], null, null, Convert.ToInt32(line[4]));
                        teachers.Add(teacher);
                    }
                    else
                    {
                        foreach (var dep in departments)
                        {
                            if (dep.Name == line[3])
                            {
                                Teacher teacher = new Teacher(line[0], line[1], null, dep, Convert.ToInt32(line[4]));
                                teachers.Add(teacher);
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
                        if (sub.Name == line[2])
                        {
                            subject = sub;
                            break;
                        }
                    }
                    if (line[3] == "-")
                    {
                        Teacher teacher = new Teacher(line[0], line[1], subject, null, Convert.ToInt32(line[4]));
                        teachers.Add(teacher);
                    }
                    else
                    {
                        foreach (var dep in departments)
                        {
                            if (dep.Name == line[3])
                            {
                                Teacher teacher = new Teacher(line[0], line[1], subject, dep, Convert.ToInt32(line[4]));
                                teachers.Add(teacher);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void предметыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form subjectsForm = new SubjectsForm();
            subjectsForm.ShowDialog();
            subjects.Clear();
            UpdateSubjectsList();
            dataGridViewTeachers_KPA.Rows.Clear();
            materialTextBoxDepartmentCode_KPA.Clear();
            materialTextBoxDepartmentName_KPA.Clear();
            materialTextBoxHeadTecher_KPA.Clear();
        }

        private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form teachersForm = new TeachersForm(teachers, departments, subjects);
            teachersForm.ShowDialog();
            teachers.Clear();
            UpdateTeachersList();
            dataGridViewTeachers_KPA.Rows.Clear();
            materialTextBoxDepartmentCode_KPA.Clear();
            materialTextBoxDepartmentName_KPA.Clear();
            materialTextBoxHeadTecher_KPA.Clear();
        }

        private void materialComboBoxDepartment_KPI_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewTeachers_KPA.Rows.Clear();
            List<Teacher> depTeachers = new List<Teacher>();
            foreach (var item in teachers)
            {
                if (item.Department is not null && item.Department.Name == materialComboBoxDepartment_KPI.SelectedItem.ToString())
                {
                    depTeachers.Add(item);
                    //dataGridViewTeachers_KPA.Rows.Add(item.Name.ToString(), item.Classroom.ToString(), item.Position.ToString(), item.Subject.Name.ToString());
                }
            }
            Sort(depTeachers);
            foreach (var item in depTeachers)
            {
                dataGridViewTeachers_KPA.Rows.Add(item.Name.ToString(), item.Classroom.ToString(), item.Position.ToString(), item.Subject.Name.ToString());
            }

            foreach (var item in departments)
            {
                if (item.Name == materialComboBoxDepartment_KPI.SelectedItem.ToString())
                {
                    materialTextBoxDepartmentCode_KPA.Text = item.Code.ToString();
                    materialTextBoxDepartmentName_KPA.Text = item.Name.ToString();
                    if (item.HeadTeacher is not null)
                    {
                        materialTextBoxHeadTecher_KPA.Text = item.HeadTeacher.Name.ToString();
                    }
                    else
                    {
                        materialTextBoxHeadTecher_KPA.Text = "-";
                    }
                }
            }
        }

        private void Sort(List<Teacher> depTeachers)
        {
            for (int i = 1; i < depTeachers.Count; i++)
            {
                for (int j = 0; j < depTeachers.Count - 1; j++)
                {
                    if (depTeachers[j].Classroom > depTeachers[j + 1].Classroom)
                    {
                        Teacher temp = depTeachers[j];
                        depTeachers[j] = depTeachers[j + 1];
                        depTeachers[j + 1] = temp;
                    }
                }
            }
        }
    }
}
