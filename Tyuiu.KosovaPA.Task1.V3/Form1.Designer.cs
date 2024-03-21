namespace Tyuiu.KosovaPA.Task1.V3
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кафедрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialComboBoxDepartment_KPI = new MaterialSkin.Controls.MaterialComboBox();
            this.materialTextBoxDepartmentCode_KPA = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxDepartmentName_KPA = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxHeadTecher_KPA = new MaterialSkin.Controls.MaterialTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClassroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.преподавателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.кафедрыToolStripMenuItem,
            this.предметыToolStripMenuItem,
            this.преподавателиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1157, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // кафедрыToolStripMenuItem
            // 
            this.кафедрыToolStripMenuItem.Name = "кафедрыToolStripMenuItem";
            this.кафедрыToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.кафедрыToolStripMenuItem.Text = "Кафедры";
            // 
            // предметыToolStripMenuItem
            // 
            this.предметыToolStripMenuItem.Name = "предметыToolStripMenuItem";
            this.предметыToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.предметыToolStripMenuItem.Text = "Предметы";
            // 
            // materialComboBoxDepartment_KPI
            // 
            this.materialComboBoxDepartment_KPI.AutoResize = false;
            this.materialComboBoxDepartment_KPI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxDepartment_KPI.Depth = 0;
            this.materialComboBoxDepartment_KPI.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxDepartment_KPI.DropDownHeight = 174;
            this.materialComboBoxDepartment_KPI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxDepartment_KPI.DropDownWidth = 121;
            this.materialComboBoxDepartment_KPI.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxDepartment_KPI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxDepartment_KPI.FormattingEnabled = true;
            this.materialComboBoxDepartment_KPI.IntegralHeight = false;
            this.materialComboBoxDepartment_KPI.ItemHeight = 43;
            this.materialComboBoxDepartment_KPI.Location = new System.Drawing.Point(68, 107);
            this.materialComboBoxDepartment_KPI.MaxDropDownItems = 4;
            this.materialComboBoxDepartment_KPI.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxDepartment_KPI.Name = "materialComboBoxDepartment_KPI";
            this.materialComboBoxDepartment_KPI.Size = new System.Drawing.Size(151, 49);
            this.materialComboBoxDepartment_KPI.StartIndex = 0;
            this.materialComboBoxDepartment_KPI.TabIndex = 1;
            // 
            // materialTextBoxDepartmentCode_KPA
            // 
            this.materialTextBoxDepartmentCode_KPA.AnimateReadOnly = false;
            this.materialTextBoxDepartmentCode_KPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxDepartmentCode_KPA.Depth = 0;
            this.materialTextBoxDepartmentCode_KPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxDepartmentCode_KPA.LeadingIcon = null;
            this.materialTextBoxDepartmentCode_KPA.Location = new System.Drawing.Point(68, 270);
            this.materialTextBoxDepartmentCode_KPA.MaxLength = 50;
            this.materialTextBoxDepartmentCode_KPA.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxDepartmentCode_KPA.Multiline = false;
            this.materialTextBoxDepartmentCode_KPA.Name = "materialTextBoxDepartmentCode_KPA";
            this.materialTextBoxDepartmentCode_KPA.Size = new System.Drawing.Size(151, 50);
            this.materialTextBoxDepartmentCode_KPA.TabIndex = 2;
            this.materialTextBoxDepartmentCode_KPA.Text = "";
            this.materialTextBoxDepartmentCode_KPA.TrailingIcon = null;
            // 
            // materialTextBoxDepartmentName_KPA
            // 
            this.materialTextBoxDepartmentName_KPA.AnimateReadOnly = false;
            this.materialTextBoxDepartmentName_KPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxDepartmentName_KPA.Depth = 0;
            this.materialTextBoxDepartmentName_KPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxDepartmentName_KPA.LeadingIcon = null;
            this.materialTextBoxDepartmentName_KPA.Location = new System.Drawing.Point(68, 363);
            this.materialTextBoxDepartmentName_KPA.MaxLength = 50;
            this.materialTextBoxDepartmentName_KPA.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxDepartmentName_KPA.Multiline = false;
            this.materialTextBoxDepartmentName_KPA.Name = "materialTextBoxDepartmentName_KPA";
            this.materialTextBoxDepartmentName_KPA.Size = new System.Drawing.Size(151, 50);
            this.materialTextBoxDepartmentName_KPA.TabIndex = 3;
            this.materialTextBoxDepartmentName_KPA.Text = "";
            this.materialTextBoxDepartmentName_KPA.TrailingIcon = null;
            // 
            // materialTextBoxHeadTecher_KPA
            // 
            this.materialTextBoxHeadTecher_KPA.AnimateReadOnly = false;
            this.materialTextBoxHeadTecher_KPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxHeadTecher_KPA.Depth = 0;
            this.materialTextBoxHeadTecher_KPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxHeadTecher_KPA.LeadingIcon = null;
            this.materialTextBoxHeadTecher_KPA.Location = new System.Drawing.Point(68, 466);
            this.materialTextBoxHeadTecher_KPA.MaxLength = 50;
            this.materialTextBoxHeadTecher_KPA.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxHeadTecher_KPA.Multiline = false;
            this.materialTextBoxHeadTecher_KPA.Name = "materialTextBoxHeadTecher_KPA";
            this.materialTextBoxHeadTecher_KPA.Size = new System.Drawing.Size(151, 50);
            this.materialTextBoxHeadTecher_KPA.TabIndex = 4;
            this.materialTextBoxHeadTecher_KPA.Text = "";
            this.materialTextBoxHeadTecher_KPA.TrailingIcon = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnClassroom,
            this.ColumnPosition,
            this.ColumnSubject});
            this.dataGridView1.Location = new System.Drawing.Point(278, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(735, 346);
            this.dataGridView1.TabIndex = 5;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Имя";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 125;
            // 
            // ColumnClassroom
            // 
            this.ColumnClassroom.HeaderText = "Аудитория";
            this.ColumnClassroom.MinimumWidth = 6;
            this.ColumnClassroom.Name = "ColumnClassroom";
            this.ColumnClassroom.Width = 125;
            // 
            // ColumnPosition
            // 
            this.ColumnPosition.HeaderText = "Должность";
            this.ColumnPosition.MinimumWidth = 6;
            this.ColumnPosition.Name = "ColumnPosition";
            this.ColumnPosition.Width = 125;
            // 
            // ColumnSubject
            // 
            this.ColumnSubject.HeaderText = "Предмет";
            this.ColumnSubject.MinimumWidth = 6;
            this.ColumnSubject.Name = "ColumnSubject";
            this.ColumnSubject.Width = 125;
            // 
            // преподавателиToolStripMenuItem
            // 
            this.преподавателиToolStripMenuItem.Name = "преподавателиToolStripMenuItem";
            this.преподавателиToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.преподавателиToolStripMenuItem.Text = "Преподаватели";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 599);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.materialTextBoxHeadTecher_KPA);
            this.Controls.Add(this.materialTextBoxDepartmentName_KPA);
            this.Controls.Add(this.materialTextBoxDepartmentCode_KPA);
            this.Controls.Add(this.materialComboBoxDepartment_KPI);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

