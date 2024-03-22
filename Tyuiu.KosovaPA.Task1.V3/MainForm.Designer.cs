namespace Tyuiu.KosovaPA.Task1.V3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            кафедрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            предметыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            преподавателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            графикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            materialComboBoxDepartment_KPI = new MaterialSkin.Controls.MaterialComboBox();
            materialTextBoxDepartmentCode_KPA = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxDepartmentName_KPA = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxHeadTecher_KPA = new MaterialSkin.Controls.MaterialTextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnClassroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { оПрограммеToolStripMenuItem, кафедрыToolStripMenuItem, предметыToolStripMenuItem, преподавателиToolStripMenuItem, графикToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(3, 80);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1157, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // кафедрыToolStripMenuItem
            // 
            кафедрыToolStripMenuItem.Name = "кафедрыToolStripMenuItem";
            кафедрыToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            кафедрыToolStripMenuItem.Text = "Кафедры";
            кафедрыToolStripMenuItem.Click += кафедрыToolStripMenuItem_Click;
            // 
            // предметыToolStripMenuItem
            // 
            предметыToolStripMenuItem.Name = "предметыToolStripMenuItem";
            предметыToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            предметыToolStripMenuItem.Text = "Предметы";
            предметыToolStripMenuItem.Click += предметыToolStripMenuItem_Click;
            // 
            // преподавателиToolStripMenuItem
            // 
            преподавателиToolStripMenuItem.Name = "преподавателиToolStripMenuItem";
            преподавателиToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            преподавателиToolStripMenuItem.Text = "Преподаватели";
            // 
            // графикToolStripMenuItem
            // 
            графикToolStripMenuItem.Name = "графикToolStripMenuItem";
            графикToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            графикToolStripMenuItem.Text = "График";
            // 
            // materialComboBoxDepartment_KPI
            // 
            materialComboBoxDepartment_KPI.AutoResize = false;
            materialComboBoxDepartment_KPI.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            materialComboBoxDepartment_KPI.Depth = 0;
            materialComboBoxDepartment_KPI.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            materialComboBoxDepartment_KPI.DropDownHeight = 174;
            materialComboBoxDepartment_KPI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            materialComboBoxDepartment_KPI.DropDownWidth = 121;
            materialComboBoxDepartment_KPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            materialComboBoxDepartment_KPI.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            materialComboBoxDepartment_KPI.FormattingEnabled = true;
            materialComboBoxDepartment_KPI.IntegralHeight = false;
            materialComboBoxDepartment_KPI.ItemHeight = 43;
            materialComboBoxDepartment_KPI.Location = new System.Drawing.Point(68, 134);
            materialComboBoxDepartment_KPI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            materialComboBoxDepartment_KPI.MaxDropDownItems = 4;
            materialComboBoxDepartment_KPI.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxDepartment_KPI.Name = "materialComboBoxDepartment_KPI";
            materialComboBoxDepartment_KPI.Size = new System.Drawing.Size(151, 49);
            materialComboBoxDepartment_KPI.StartIndex = 0;
            materialComboBoxDepartment_KPI.TabIndex = 1;
            // 
            // materialTextBoxDepartmentCode_KPA
            // 
            materialTextBoxDepartmentCode_KPA.AnimateReadOnly = false;
            materialTextBoxDepartmentCode_KPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialTextBoxDepartmentCode_KPA.Depth = 0;
            materialTextBoxDepartmentCode_KPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTextBoxDepartmentCode_KPA.LeadingIcon = null;
            materialTextBoxDepartmentCode_KPA.Location = new System.Drawing.Point(68, 338);
            materialTextBoxDepartmentCode_KPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            materialTextBoxDepartmentCode_KPA.MaxLength = 50;
            materialTextBoxDepartmentCode_KPA.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxDepartmentCode_KPA.Multiline = false;
            materialTextBoxDepartmentCode_KPA.Name = "materialTextBoxDepartmentCode_KPA";
            materialTextBoxDepartmentCode_KPA.Size = new System.Drawing.Size(151, 50);
            materialTextBoxDepartmentCode_KPA.TabIndex = 2;
            materialTextBoxDepartmentCode_KPA.Text = "";
            materialTextBoxDepartmentCode_KPA.TrailingIcon = null;
            // 
            // materialTextBoxDepartmentName_KPA
            // 
            materialTextBoxDepartmentName_KPA.AnimateReadOnly = false;
            materialTextBoxDepartmentName_KPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialTextBoxDepartmentName_KPA.Depth = 0;
            materialTextBoxDepartmentName_KPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTextBoxDepartmentName_KPA.LeadingIcon = null;
            materialTextBoxDepartmentName_KPA.Location = new System.Drawing.Point(68, 454);
            materialTextBoxDepartmentName_KPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            materialTextBoxDepartmentName_KPA.MaxLength = 50;
            materialTextBoxDepartmentName_KPA.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxDepartmentName_KPA.Multiline = false;
            materialTextBoxDepartmentName_KPA.Name = "materialTextBoxDepartmentName_KPA";
            materialTextBoxDepartmentName_KPA.Size = new System.Drawing.Size(151, 50);
            materialTextBoxDepartmentName_KPA.TabIndex = 3;
            materialTextBoxDepartmentName_KPA.Text = "";
            materialTextBoxDepartmentName_KPA.TrailingIcon = null;
            // 
            // materialTextBoxHeadTecher_KPA
            // 
            materialTextBoxHeadTecher_KPA.AnimateReadOnly = false;
            materialTextBoxHeadTecher_KPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialTextBoxHeadTecher_KPA.Depth = 0;
            materialTextBoxHeadTecher_KPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTextBoxHeadTecher_KPA.LeadingIcon = null;
            materialTextBoxHeadTecher_KPA.Location = new System.Drawing.Point(68, 582);
            materialTextBoxHeadTecher_KPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            materialTextBoxHeadTecher_KPA.MaxLength = 50;
            materialTextBoxHeadTecher_KPA.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxHeadTecher_KPA.Multiline = false;
            materialTextBoxHeadTecher_KPA.Name = "materialTextBoxHeadTecher_KPA";
            materialTextBoxHeadTecher_KPA.Size = new System.Drawing.Size(151, 50);
            materialTextBoxHeadTecher_KPA.TabIndex = 4;
            materialTextBoxHeadTecher_KPA.Text = "";
            materialTextBoxHeadTecher_KPA.TrailingIcon = null;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColumnName, ColumnClassroom, ColumnPosition, ColumnSubject });
            dataGridView1.Location = new System.Drawing.Point(278, 134);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(735, 432);
            dataGridView1.TabIndex = 5;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Имя";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.Width = 125;
            // 
            // ColumnClassroom
            // 
            ColumnClassroom.HeaderText = "Аудитория";
            ColumnClassroom.MinimumWidth = 6;
            ColumnClassroom.Name = "ColumnClassroom";
            ColumnClassroom.Width = 125;
            // 
            // ColumnPosition
            // 
            ColumnPosition.HeaderText = "Должность";
            ColumnPosition.MinimumWidth = 6;
            ColumnPosition.Name = "ColumnPosition";
            ColumnPosition.Width = 125;
            // 
            // ColumnSubject
            // 
            ColumnSubject.HeaderText = "Предмет";
            ColumnSubject.MinimumWidth = 6;
            ColumnSubject.Name = "ColumnSubject";
            ColumnSubject.Width = 125;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1163, 749);
            Controls.Add(dataGridView1);
            Controls.Add(materialTextBoxHeadTecher_KPA);
            Controls.Add(materialTextBoxDepartmentName_KPA);
            Controls.Add(materialTextBoxDepartmentCode_KPA);
            Controls.Add(materialComboBoxDepartment_KPI);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "MainForm";
            Padding = new System.Windows.Forms.Padding(3, 80, 3, 4);
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кафедрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметыToolStripMenuItem;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxDepartment_KPI;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxDepartmentCode_KPA;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxDepartmentName_KPA;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxHeadTecher_KPA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.ToolStripMenuItem преподавателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикToolStripMenuItem;
    }
}

