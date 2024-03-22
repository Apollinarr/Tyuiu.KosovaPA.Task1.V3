using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.KosovaPA.Task1.V3
{
    public partial class SubjectsForm : MaterialForm
    {
        List<Subject> subjects = new List<Subject>();
        public SubjectsForm()
        {
            InitializeComponent();
        }

        private void SubjectsForm_Load(object sender, EventArgs e)
        {
            materialButtonAddSubject_KPA.Enabled = false;
            materialButtonEditSubject_KPA.Enabled = false;
            materialButtonDeleteSubject_KPA.Enabled = false;
            materialComboBoxIsExamSubject_KPA.SelectedIndex = -1;

            List<string[]> lines = File.ReadAllLines("Subjects.csv", Encoding.GetEncoding(1251)).Select(d => d.Split(' ')).ToList();
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

                dataGridViewSubjects_KPA.Rows.Add(subject.ToString().Split(' '));
            }

            materialLabelCount_KPA.Text = "Количество" + subjects.Count;
        }

        private void materialButtonAddSubject_KPA_Click(object sender, EventArgs e)
        {
            if (CheckCode() && CheckName() && CheckHours() && CheckIsExam())
            {
                try
                {
                    bool isExam;
                    if (materialComboBoxIsExamSubject_KPA.SelectedIndex == 0)
                    {
                        isExam = true;
                    }
                    else
                    {
                        isExam = false;
                    }
                    Subject subject = new Subject(Convert.ToInt32(materialTextBoxCodeSubject_KPA.Text),
                        materialTextBoxNameSubject_KPA.Text, Convert.ToInt32(materialTextBoxHoursSubject_KPA.Text), isExam);

                    subjects.Add(subject);

                    using (var streamWriter = new StreamWriter(@"Subjects.csv", true, Encoding.GetEncoding(1251)))
                    {
                        streamWriter.WriteLine(subject.ToString());
                    }

                    dataGridViewSubjects_KPA.Rows.Add(subject.ToString().Split(' '));

                    materialLabelCount_KPA.Text = "Количество: " + subjects.Count;

                    ClearAllFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridViewSubjects_KPA_Click(object sender, EventArgs e)
        {
            if (dataGridViewSubjects_KPA.CurrentRow.Index == dataGridViewSubjects_KPA.Rows.Count - 1)
            {
                materialButtonAddSubject_KPA.Enabled = true;
                materialButtonEditSubject_KPA.Enabled = false;
                materialButtonDeleteSubject_KPA.Enabled = false;

                ClearAllFields();
            }
            else
            {
                materialButtonAddSubject_KPA.Enabled = false;
                materialButtonEditSubject_KPA.Enabled = true;
                materialButtonDeleteSubject_KPA.Enabled = true;

                materialTextBoxCodeSubject_KPA.Text = dataGridViewSubjects_KPA.CurrentRow.Cells[0].Value.ToString();
                materialTextBoxNameSubject_KPA.Text = dataGridViewSubjects_KPA.CurrentRow.Cells[1].Value.ToString();
                materialTextBoxHoursSubject_KPA.Text = dataGridViewSubjects_KPA.CurrentRow.Cells[2].Value.ToString();
                if (dataGridViewSubjects_KPA.CurrentRow.Cells[3].Value.ToString() == "Экзамен")
                {
                    materialComboBoxIsExamSubject_KPA.SelectedIndex = 0;
                }
                else
                {
                    materialComboBoxIsExamSubject_KPA.SelectedIndex = 1;
                }
            }
        }

        private void ClearAllFields()
        {
            materialTextBoxCodeSubject_KPA.Clear();
            materialTextBoxHoursSubject_KPA.Clear();
            materialTextBoxNameSubject_KPA.Clear();
            materialComboBoxIsExamSubject_KPA.SelectedIndex = -1;
        }

        private bool CheckCode() => materialTextBoxCodeSubject_KPA.TextLength > 0;

        private bool CheckName() => materialTextBoxNameSubject_KPA.TextLength > 0;

        private bool CheckHours() => materialTextBoxHoursSubject_KPA.TextLength > 0;

        private bool CheckIsExam() => materialComboBoxIsExamSubject_KPA.SelectedIndex != -1;

        private void materialTextBoxCodeSubject_KPA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void materialTextBoxNameSubject_KPA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void materialTextBoxHoursSubject_KPA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
