using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
                foreach (var dep in departments)
                {
                    materialComboBoxDepartment_KPI.Items.Add(dep.Name);
                }
            }

            if (!File.Exists("Teachers.csv"))
            {
                using (FileStream fs = File.Create("Teachers.csv"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("");
                }
            }

            if (!File.Exists("Subjects.csv"))
            {
                using (FileStream fs = File.Create("Subjects.csv"))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("");
                }
            }
        }

        private void кафедрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form departmnetForm = new DepartmentsForm();
            departmnetForm.ShowDialog();

            departments.Clear();
            UpdateDepartmentsList();
            materialComboBoxDepartment_KPI.Items.Clear();
            foreach (var dep in departments)
            {
                materialComboBoxDepartment_KPI.Items.Add(dep.Name);
            }
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
        }

        private void преподавателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form teachersForm = new TeachersForm();
            teachersForm.ShowDialog();
            teachers.Clear();
            UpdateTeachersList();
        }
    }
}
