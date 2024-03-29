using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
//using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.KosovaPA.Task1.V3
{
    public partial class GraphForm : MaterialForm
    {
        List<Teacher> teachers = new List<Teacher>();
        List<Department> departments = new List<Department>();
        public GraphForm(List<Department> departments, List<Teacher> teachers)
        {
            InitializeComponent();
            this.teachers = teachers;
            this.departments = departments;
        }

        private void GraphForm_Load(object sender, EventArgs e)
        {
            int countDepartments = -1;
            int start = 0;
            int end = departments.Count - 1;
            foreach (var dep in departments)
            {
                CustomLabel label = new CustomLabel(start, end, dep.Name.ToString(), 0, LabelMarkStyle.None);
                chartTeachers_KPA.ChartAreas[0].AxisX.CustomLabels.Add(label);
                start++;
                end++;
                countDepartments++;
                int countTeachers = 0;
                foreach (var teach in teachers)
                {
                    if (teach.Department is not null && teach.Department == dep)
                    {
                        countTeachers++;
                    }
                }
                chartTeachers_KPA.Series[0].Points.AddXY(countDepartments + 1, countTeachers);
            }
            
        }
    }
}
