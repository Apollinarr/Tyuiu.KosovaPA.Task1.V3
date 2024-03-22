namespace Tyuiu.KosovaPA.Task1.V3
{
    partial class DepartmentsForm
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
            dataGridViewDepartmnets_KPA = new System.Windows.Forms.DataGridView();
            ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HeadTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            materialTextBoxCodeDepartment_KPA = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxDepartmentName_KPA = new MaterialSkin.Controls.MaterialTextBox();
            materialComboBoxTeachers_KPA = new MaterialSkin.Controls.MaterialComboBox();
            materialButtonAddDepartmnet_KPA = new MaterialSkin.Controls.MaterialButton();
            materialLabelCode_KPA = new MaterialSkin.Controls.MaterialLabel();
            materialLabelName_KPA = new MaterialSkin.Controls.MaterialLabel();
            materialLabelHeadTeacher_KPA = new MaterialSkin.Controls.MaterialLabel();
            materialButtonDelete_KPA = new MaterialSkin.Controls.MaterialButton();
            materialButtonEdit_KPA = new MaterialSkin.Controls.MaterialButton();
            materialLabelDepCount_KPA = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartmnets_KPA).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDepartmnets_KPA
            // 
            dataGridViewDepartmnets_KPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDepartmnets_KPA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColumnCode, ColumnName, HeadTeacher });
            dataGridViewDepartmnets_KPA.Location = new System.Drawing.Point(42, 136);
            dataGridViewDepartmnets_KPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridViewDepartmnets_KPA.Name = "dataGridViewDepartmnets_KPA";
            dataGridViewDepartmnets_KPA.RowHeadersWidth = 51;
            dataGridViewDepartmnets_KPA.RowTemplate.Height = 24;
            dataGridViewDepartmnets_KPA.Size = new System.Drawing.Size(563, 391);
            dataGridViewDepartmnets_KPA.TabIndex = 0;
            dataGridViewDepartmnets_KPA.Click += dataGridViewDepartmnets_KPA_Click;
            // 
            // ColumnCode
            // 
            ColumnCode.HeaderText = "Код";
            ColumnCode.MinimumWidth = 6;
            ColumnCode.Name = "ColumnCode";
            ColumnCode.ReadOnly = true;
            ColumnCode.Width = 125;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Название";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.Width = 125;
            // 
            // HeadTeacher
            // 
            HeadTeacher.HeaderText = "Заведующий";
            HeadTeacher.MinimumWidth = 6;
            HeadTeacher.Name = "HeadTeacher";
            HeadTeacher.ReadOnly = true;
            HeadTeacher.Width = 125;
            // 
            // materialTextBoxCodeDepartment_KPA
            // 
            materialTextBoxCodeDepartment_KPA.AnimateReadOnly = false;
            materialTextBoxCodeDepartment_KPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialTextBoxCodeDepartment_KPA.Depth = 0;
            materialTextBoxCodeDepartment_KPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTextBoxCodeDepartment_KPA.LeadingIcon = null;
            materialTextBoxCodeDepartment_KPA.Location = new System.Drawing.Point(788, 136);
            materialTextBoxCodeDepartment_KPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            materialTextBoxCodeDepartment_KPA.MaxLength = 20;
            materialTextBoxCodeDepartment_KPA.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxCodeDepartment_KPA.Multiline = false;
            materialTextBoxCodeDepartment_KPA.Name = "materialTextBoxCodeDepartment_KPA";
            materialTextBoxCodeDepartment_KPA.Size = new System.Drawing.Size(240, 50);
            materialTextBoxCodeDepartment_KPA.TabIndex = 1;
            materialTextBoxCodeDepartment_KPA.Text = "";
            materialTextBoxCodeDepartment_KPA.TrailingIcon = null;
            materialTextBoxCodeDepartment_KPA.KeyPress += materialTextBoxCodeDepartment_KPA_KeyPress;
            // 
            // materialTextBoxDepartmentName_KPA
            // 
            materialTextBoxDepartmentName_KPA.AnimateReadOnly = false;
            materialTextBoxDepartmentName_KPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialTextBoxDepartmentName_KPA.Depth = 0;
            materialTextBoxDepartmentName_KPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTextBoxDepartmentName_KPA.LeadingIcon = null;
            materialTextBoxDepartmentName_KPA.Location = new System.Drawing.Point(788, 260);
            materialTextBoxDepartmentName_KPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            materialTextBoxDepartmentName_KPA.MaxLength = 50;
            materialTextBoxDepartmentName_KPA.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxDepartmentName_KPA.Multiline = false;
            materialTextBoxDepartmentName_KPA.Name = "materialTextBoxDepartmentName_KPA";
            materialTextBoxDepartmentName_KPA.Size = new System.Drawing.Size(240, 50);
            materialTextBoxDepartmentName_KPA.TabIndex = 2;
            materialTextBoxDepartmentName_KPA.Text = "";
            materialTextBoxDepartmentName_KPA.TrailingIcon = null;
            materialTextBoxDepartmentName_KPA.KeyPress += materialTextBoxDepartmentName_KPA_KeyPress;
            // 
            // materialComboBoxTeachers_KPA
            // 
            materialComboBoxTeachers_KPA.AutoResize = false;
            materialComboBoxTeachers_KPA.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            materialComboBoxTeachers_KPA.Depth = 0;
            materialComboBoxTeachers_KPA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            materialComboBoxTeachers_KPA.DropDownHeight = 174;
            materialComboBoxTeachers_KPA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            materialComboBoxTeachers_KPA.DropDownWidth = 121;
            materialComboBoxTeachers_KPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            materialComboBoxTeachers_KPA.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            materialComboBoxTeachers_KPA.FormattingEnabled = true;
            materialComboBoxTeachers_KPA.IntegralHeight = false;
            materialComboBoxTeachers_KPA.ItemHeight = 43;
            materialComboBoxTeachers_KPA.Location = new System.Drawing.Point(788, 395);
            materialComboBoxTeachers_KPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            materialComboBoxTeachers_KPA.MaxDropDownItems = 4;
            materialComboBoxTeachers_KPA.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxTeachers_KPA.Name = "materialComboBoxTeachers_KPA";
            materialComboBoxTeachers_KPA.Size = new System.Drawing.Size(240, 49);
            materialComboBoxTeachers_KPA.StartIndex = 0;
            materialComboBoxTeachers_KPA.TabIndex = 3;
            // 
            // materialButtonAddDepartmnet_KPA
            // 
            materialButtonAddDepartmnet_KPA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            materialButtonAddDepartmnet_KPA.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonAddDepartmnet_KPA.Depth = 0;
            materialButtonAddDepartmnet_KPA.HighEmphasis = true;
            materialButtonAddDepartmnet_KPA.Icon = null;
            materialButtonAddDepartmnet_KPA.Location = new System.Drawing.Point(376, 589);
            materialButtonAddDepartmnet_KPA.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            materialButtonAddDepartmnet_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonAddDepartmnet_KPA.Name = "materialButtonAddDepartmnet_KPA";
            materialButtonAddDepartmnet_KPA.NoAccentTextColor = System.Drawing.Color.Empty;
            materialButtonAddDepartmnet_KPA.Size = new System.Drawing.Size(100, 36);
            materialButtonAddDepartmnet_KPA.TabIndex = 4;
            materialButtonAddDepartmnet_KPA.Text = "добавить";
            materialButtonAddDepartmnet_KPA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonAddDepartmnet_KPA.UseAccentColor = false;
            materialButtonAddDepartmnet_KPA.UseVisualStyleBackColor = true;
            materialButtonAddDepartmnet_KPA.Click += materialButtonAddDepartmnet_KPA_Click;
            // 
            // materialLabelCode_KPA
            // 
            materialLabelCode_KPA.AutoSize = true;
            materialLabelCode_KPA.Depth = 0;
            materialLabelCode_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabelCode_KPA.Location = new System.Drawing.Point(650, 150);
            materialLabelCode_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelCode_KPA.Name = "materialLabelCode_KPA";
            materialLabelCode_KPA.Size = new System.Drawing.Size(30, 19);
            materialLabelCode_KPA.TabIndex = 5;
            materialLabelCode_KPA.Text = "Код";
            // 
            // materialLabelName_KPA
            // 
            materialLabelName_KPA.AutoSize = true;
            materialLabelName_KPA.Depth = 0;
            materialLabelName_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabelName_KPA.Location = new System.Drawing.Point(650, 280);
            materialLabelName_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelName_KPA.Name = "materialLabelName_KPA";
            materialLabelName_KPA.Size = new System.Drawing.Size(73, 19);
            materialLabelName_KPA.TabIndex = 6;
            materialLabelName_KPA.Text = "Название";
            // 
            // materialLabelHeadTeacher_KPA
            // 
            materialLabelHeadTeacher_KPA.AutoSize = true;
            materialLabelHeadTeacher_KPA.Depth = 0;
            materialLabelHeadTeacher_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabelHeadTeacher_KPA.Location = new System.Drawing.Point(650, 419);
            materialLabelHeadTeacher_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelHeadTeacher_KPA.Name = "materialLabelHeadTeacher_KPA";
            materialLabelHeadTeacher_KPA.Size = new System.Drawing.Size(99, 19);
            materialLabelHeadTeacher_KPA.TabIndex = 7;
            materialLabelHeadTeacher_KPA.Text = "Заведующий";
            // 
            // materialButtonDelete_KPA
            // 
            materialButtonDelete_KPA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            materialButtonDelete_KPA.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonDelete_KPA.Depth = 0;
            materialButtonDelete_KPA.HighEmphasis = true;
            materialButtonDelete_KPA.Icon = null;
            materialButtonDelete_KPA.Location = new System.Drawing.Point(514, 589);
            materialButtonDelete_KPA.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            materialButtonDelete_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonDelete_KPA.Name = "materialButtonDelete_KPA";
            materialButtonDelete_KPA.NoAccentTextColor = System.Drawing.Color.Empty;
            materialButtonDelete_KPA.Size = new System.Drawing.Size(91, 36);
            materialButtonDelete_KPA.TabIndex = 8;
            materialButtonDelete_KPA.Text = "Удалить";
            materialButtonDelete_KPA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonDelete_KPA.UseAccentColor = false;
            materialButtonDelete_KPA.UseVisualStyleBackColor = true;
            materialButtonDelete_KPA.Click += materialButtonDelete_KPA_Click;
            // 
            // materialButtonEdit_KPA
            // 
            materialButtonEdit_KPA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            materialButtonEdit_KPA.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonEdit_KPA.Depth = 0;
            materialButtonEdit_KPA.HighEmphasis = true;
            materialButtonEdit_KPA.Icon = null;
            materialButtonEdit_KPA.Location = new System.Drawing.Point(42, 589);
            materialButtonEdit_KPA.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            materialButtonEdit_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonEdit_KPA.Name = "materialButtonEdit_KPA";
            materialButtonEdit_KPA.NoAccentTextColor = System.Drawing.Color.Empty;
            materialButtonEdit_KPA.Size = new System.Drawing.Size(146, 36);
            materialButtonEdit_KPA.TabIndex = 9;
            materialButtonEdit_KPA.Text = "Редактировать";
            materialButtonEdit_KPA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonEdit_KPA.UseAccentColor = false;
            materialButtonEdit_KPA.UseVisualStyleBackColor = true;
            materialButtonEdit_KPA.Click += materialButtonEdit_KPA_Click;
            // 
            // materialLabelDepCount_KPA
            // 
            materialLabelDepCount_KPA.AutoSize = true;
            materialLabelDepCount_KPA.Depth = 0;
            materialLabelDepCount_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabelDepCount_KPA.Location = new System.Drawing.Point(42, 102);
            materialLabelDepCount_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelDepCount_KPA.Name = "materialLabelDepCount_KPA";
            materialLabelDepCount_KPA.Size = new System.Drawing.Size(97, 19);
            materialLabelDepCount_KPA.TabIndex = 10;
            materialLabelDepCount_KPA.Text = "Количество: ";
            // 
            // DepartmentsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1054, 705);
            Controls.Add(materialLabelDepCount_KPA);
            Controls.Add(materialButtonEdit_KPA);
            Controls.Add(materialButtonDelete_KPA);
            Controls.Add(materialLabelHeadTeacher_KPA);
            Controls.Add(materialLabelName_KPA);
            Controls.Add(materialLabelCode_KPA);
            Controls.Add(materialButtonAddDepartmnet_KPA);
            Controls.Add(materialComboBoxTeachers_KPA);
            Controls.Add(materialTextBoxDepartmentName_KPA);
            Controls.Add(materialTextBoxCodeDepartment_KPA);
            Controls.Add(dataGridViewDepartmnets_KPA);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "DepartmentsForm";
            Padding = new System.Windows.Forms.Padding(3, 80, 3, 4);
            Text = "Кафедры";
            Load += DepartmentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartmnets_KPA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDepartmnets_KPA;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxCodeDepartment_KPA;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxDepartmentName_KPA;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxTeachers_KPA;
        private MaterialSkin.Controls.MaterialButton materialButtonAddDepartmnet_KPA;
        private MaterialSkin.Controls.MaterialLabel materialLabelCode_KPA;
        private MaterialSkin.Controls.MaterialLabel materialLabelName_KPA;
        private MaterialSkin.Controls.MaterialLabel materialLabelHeadTeacher_KPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeadTeacher;
        private MaterialSkin.Controls.MaterialButton materialButtonDelete_KPA;
        private MaterialSkin.Controls.MaterialButton materialButtonEdit_KPA;
        private MaterialSkin.Controls.MaterialLabel materialLabelDepCount_KPA;
    }
}