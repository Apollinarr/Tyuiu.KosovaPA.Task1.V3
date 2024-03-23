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

        private void предметыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form subjectsForm = new SubjectsForm();
            subjectsForm.ShowDialog();
        }
    }
}
