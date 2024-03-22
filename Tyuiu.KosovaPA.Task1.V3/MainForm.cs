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
        public MainForm()
        {
            InitializeComponent();
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

        }
    }
}
