namespace Tyuiu.KosovaPA.Task1.V3
{
    partial class GraphForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chartTeachers_KPA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chartTeachers_KPA).BeginInit();
            SuspendLayout();
            // 
            // chartTeachers_KPA
            // 
            chartTeachers_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartTeachers_KPA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartTeachers_KPA.Legends.Add(legend1);
            chartTeachers_KPA.Location = new System.Drawing.Point(100, 113);
            chartTeachers_KPA.Name = "chartTeachers_KPA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Кафедры";
            chartTeachers_KPA.Series.Add(series1);
            chartTeachers_KPA.Size = new System.Drawing.Size(661, 375);
            chartTeachers_KPA.TabIndex = 0;
            chartTeachers_KPA.Text = "chart1";
            title1.Name = "Преподаватели по кафедрам";
            title1.Text = "Преподаватели по кафедрам";
            chartTeachers_KPA.Titles.Add(title1);
            // 
            // GraphForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(913, 577);
            Controls.Add(chartTeachers_KPA);
            MaximizeBox = false;
            Name = "GraphForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Кафедры";
            Load += GraphForm_Load;
            ((System.ComponentModel.ISupportInitialize)chartTeachers_KPA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTeachers_KPA;
    }
}