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
            dataGridViewTeachers_KPA = new System.Windows.Forms.DataGridView();
            ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnClassroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            materialLabelDepartment_KPA = new MaterialSkin.Controls.MaterialLabel();
            materialLabelCode_KPA = new MaterialSkin.Controls.MaterialLabel();
            materialLabelDepartmentName_KPA = new MaterialSkin.Controls.MaterialLabel();
            materialLabelHeadTeacher_KPA = new MaterialSkin.Controls.MaterialLabel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers_KPA).BeginInit();
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
            оПрограммеToolStripMenuItem.Click += оПрограммеToolStripMenuItem_Click;
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
            преподавателиToolStripMenuItem.Click += преподавателиToolStripMenuItem_Click;
            // 
            // графикToolStripMenuItem
            // 
            графикToolStripMenuItem.Name = "графикToolStripMenuItem";
            графикToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            графикToolStripMenuItem.Text = "График";
            графикToolStripMenuItem.Click += графикToolStripMenuItem_Click;
            // 
            // materialComboBoxDepartment_KPI
            // 
            materialComboBoxDepartment_KPI.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
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
            materialComboBoxDepartment_KPI.Location = new System.Drawing.Point(197, 134);
            materialComboBoxDepartment_KPI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            materialComboBoxDepartment_KPI.MaxDropDownItems = 4;
            materialComboBoxDepartment_KPI.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxDepartment_KPI.Name = "materialComboBoxDepartment_KPI";
            materialComboBoxDepartment_KPI.Size = new System.Drawing.Size(240, 49);
            materialComboBoxDepartment_KPI.StartIndex = 0;
            materialComboBoxDepartment_KPI.TabIndex = 1;
            materialComboBoxDepartment_KPI.SelectedIndexChanged += materialComboBoxDepartment_KPI_SelectedIndexChanged;
            // 
            // materialTextBoxDepartmentCode_KPA
            // 
            materialTextBoxDepartmentCode_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            materialTextBoxDepartmentCode_KPA.AnimateReadOnly = false;
            materialTextBoxDepartmentCode_KPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialTextBoxDepartmentCode_KPA.Depth = 0;
            materialTextBoxDepartmentCode_KPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTextBoxDepartmentCode_KPA.LeadingIcon = null;
            materialTextBoxDepartmentCode_KPA.Location = new System.Drawing.Point(197, 338);
            materialTextBoxDepartmentCode_KPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            materialTextBoxDepartmentCode_KPA.MaxLength = 50;
            materialTextBoxDepartmentCode_KPA.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxDepartmentCode_KPA.Multiline = false;
            materialTextBoxDepartmentCode_KPA.Name = "materialTextBoxDepartmentCode_KPA";
            materialTextBoxDepartmentCode_KPA.Size = new System.Drawing.Size(240, 50);
            materialTextBoxDepartmentCode_KPA.TabIndex = 2;
            materialTextBoxDepartmentCode_KPA.Text = "";
            materialTextBoxDepartmentCode_KPA.TrailingIcon = null;
            // 
            // materialTextBoxDepartmentName_KPA
            // 
            materialTextBoxDepartmentName_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            materialTextBoxDepartmentName_KPA.AnimateReadOnly = false;
            materialTextBoxDepartmentName_KPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialTextBoxDepartmentName_KPA.Depth = 0;
            materialTextBoxDepartmentName_KPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTextBoxDepartmentName_KPA.LeadingIcon = null;
            materialTextBoxDepartmentName_KPA.Location = new System.Drawing.Point(197, 454);
            materialTextBoxDepartmentName_KPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            materialTextBoxDepartmentName_KPA.MaxLength = 50;
            materialTextBoxDepartmentName_KPA.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxDepartmentName_KPA.Multiline = false;
            materialTextBoxDepartmentName_KPA.Name = "materialTextBoxDepartmentName_KPA";
            materialTextBoxDepartmentName_KPA.Size = new System.Drawing.Size(240, 50);
            materialTextBoxDepartmentName_KPA.TabIndex = 3;
            materialTextBoxDepartmentName_KPA.Text = "";
            materialTextBoxDepartmentName_KPA.TrailingIcon = null;
            // 
            // materialTextBoxHeadTecher_KPA
            // 
            materialTextBoxHeadTecher_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            materialTextBoxHeadTecher_KPA.AnimateReadOnly = false;
            materialTextBoxHeadTecher_KPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialTextBoxHeadTecher_KPA.Depth = 0;
            materialTextBoxHeadTecher_KPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTextBoxHeadTecher_KPA.LeadingIcon = null;
            materialTextBoxHeadTecher_KPA.Location = new System.Drawing.Point(197, 581);
            materialTextBoxHeadTecher_KPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            materialTextBoxHeadTecher_KPA.MaxLength = 50;
            materialTextBoxHeadTecher_KPA.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxHeadTecher_KPA.Multiline = false;
            materialTextBoxHeadTecher_KPA.Name = "materialTextBoxHeadTecher_KPA";
            materialTextBoxHeadTecher_KPA.Size = new System.Drawing.Size(240, 50);
            materialTextBoxHeadTecher_KPA.TabIndex = 4;
            materialTextBoxHeadTecher_KPA.Text = "";
            materialTextBoxHeadTecher_KPA.TrailingIcon = null;
            // 
            // dataGridViewTeachers_KPA
            // 
            dataGridViewTeachers_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dataGridViewTeachers_KPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeachers_KPA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColumnName, ColumnClassroom, ColumnPosition, ColumnSubject });
            dataGridViewTeachers_KPA.Location = new System.Drawing.Point(501, 134);
            dataGridViewTeachers_KPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridViewTeachers_KPA.Name = "dataGridViewTeachers_KPA";
            dataGridViewTeachers_KPA.RowHeadersWidth = 51;
            dataGridViewTeachers_KPA.RowTemplate.Height = 24;
            dataGridViewTeachers_KPA.Size = new System.Drawing.Size(631, 497);
            dataGridViewTeachers_KPA.TabIndex = 5;
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
            // materialLabelDepartment_KPA
            // 
            materialLabelDepartment_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            materialLabelDepartment_KPA.AutoSize = true;
            materialLabelDepartment_KPA.Depth = 0;
            materialLabelDepartment_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabelDepartment_KPA.Location = new System.Drawing.Point(78, 147);
            materialLabelDepartment_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelDepartment_KPA.Name = "materialLabelDepartment_KPA";
            materialLabelDepartment_KPA.Size = new System.Drawing.Size(68, 19);
            materialLabelDepartment_KPA.TabIndex = 6;
            materialLabelDepartment_KPA.Text = "Кафедра";
            // 
            // materialLabelCode_KPA
            // 
            materialLabelCode_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            materialLabelCode_KPA.AutoSize = true;
            materialLabelCode_KPA.Depth = 0;
            materialLabelCode_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabelCode_KPA.Location = new System.Drawing.Point(78, 357);
            materialLabelCode_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelCode_KPA.Name = "materialLabelCode_KPA";
            materialLabelCode_KPA.Size = new System.Drawing.Size(30, 19);
            materialLabelCode_KPA.TabIndex = 7;
            materialLabelCode_KPA.Text = "Код";
            // 
            // materialLabelDepartmentName_KPA
            // 
            materialLabelDepartmentName_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            materialLabelDepartmentName_KPA.AutoSize = true;
            materialLabelDepartmentName_KPA.Depth = 0;
            materialLabelDepartmentName_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabelDepartmentName_KPA.Location = new System.Drawing.Point(78, 476);
            materialLabelDepartmentName_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelDepartmentName_KPA.Name = "materialLabelDepartmentName_KPA";
            materialLabelDepartmentName_KPA.Size = new System.Drawing.Size(73, 19);
            materialLabelDepartmentName_KPA.TabIndex = 8;
            materialLabelDepartmentName_KPA.Text = "Название";
            // 
            // materialLabelHeadTeacher_KPA
            // 
            materialLabelHeadTeacher_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            materialLabelHeadTeacher_KPA.AutoSize = true;
            materialLabelHeadTeacher_KPA.Depth = 0;
            materialLabelHeadTeacher_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabelHeadTeacher_KPA.Location = new System.Drawing.Point(78, 597);
            materialLabelHeadTeacher_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelHeadTeacher_KPA.Name = "materialLabelHeadTeacher_KPA";
            materialLabelHeadTeacher_KPA.Size = new System.Drawing.Size(99, 19);
            materialLabelHeadTeacher_KPA.TabIndex = 9;
            materialLabelHeadTeacher_KPA.Text = "Заведующий";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1163, 749);
            Controls.Add(materialLabelHeadTeacher_KPA);
            Controls.Add(materialLabelDepartmentName_KPA);
            Controls.Add(materialLabelCode_KPA);
            Controls.Add(materialLabelDepartment_KPA);
            Controls.Add(dataGridViewTeachers_KPA);
            Controls.Add(materialTextBoxHeadTecher_KPA);
            Controls.Add(materialTextBoxDepartmentName_KPA);
            Controls.Add(materialTextBoxDepartmentCode_KPA);
            Controls.Add(materialComboBoxDepartment_KPI);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainForm";
            Padding = new System.Windows.Forms.Padding(3, 80, 3, 4);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers_KPA).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewTeachers_KPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.ToolStripMenuItem преподавателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикToolStripMenuItem;
        private MaterialSkin.Controls.MaterialLabel materialLabelDepartment_KPA;
        private MaterialSkin.Controls.MaterialLabel materialLabelCode_KPA;
        private MaterialSkin.Controls.MaterialLabel materialLabelDepartmentName_KPA;
        private MaterialSkin.Controls.MaterialLabel materialLabelHeadTeacher_KPA;
    }
}

