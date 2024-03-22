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
            this.dataGridViewDepartmnets_KPA = new System.Windows.Forms.DataGridView();
            this.materialTextBoxCodeDepartment_KPA = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxDepartmentName_KPA = new MaterialSkin.Controls.MaterialTextBox();
            this.materialComboBoxTeachers_KPA = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButtonAddDepartmnet_KPA = new MaterialSkin.Controls.MaterialButton();
            this.materialLabelCode_KPA = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelName_KPA = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelHeadTeacher_KPA = new MaterialSkin.Controls.MaterialLabel();
            this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeadTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialButtonDelete_KPA = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonEdit_KPA = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmnets_KPA)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDepartmnets_KPA
            // 
            this.dataGridViewDepartmnets_KPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartmnets_KPA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCode,
            this.ColumnName,
            this.HeadTeacher});
            this.dataGridViewDepartmnets_KPA.Location = new System.Drawing.Point(42, 109);
            this.dataGridViewDepartmnets_KPA.Name = "dataGridViewDepartmnets_KPA";
            this.dataGridViewDepartmnets_KPA.RowHeadersWidth = 51;
            this.dataGridViewDepartmnets_KPA.RowTemplate.Height = 24;
            this.dataGridViewDepartmnets_KPA.Size = new System.Drawing.Size(563, 313);
            this.dataGridViewDepartmnets_KPA.TabIndex = 0;
            this.dataGridViewDepartmnets_KPA.Click += new System.EventHandler(this.dataGridViewDepartmnets_KPA_Click);
            // 
            // materialTextBoxCodeDepartment_KPA
            // 
            this.materialTextBoxCodeDepartment_KPA.AnimateReadOnly = false;
            this.materialTextBoxCodeDepartment_KPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxCodeDepartment_KPA.Depth = 0;
            this.materialTextBoxCodeDepartment_KPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxCodeDepartment_KPA.LeadingIcon = null;
            this.materialTextBoxCodeDepartment_KPA.Location = new System.Drawing.Point(788, 109);
            this.materialTextBoxCodeDepartment_KPA.MaxLength = 20;
            this.materialTextBoxCodeDepartment_KPA.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxCodeDepartment_KPA.Multiline = false;
            this.materialTextBoxCodeDepartment_KPA.Name = "materialTextBoxCodeDepartment_KPA";
            this.materialTextBoxCodeDepartment_KPA.Size = new System.Drawing.Size(240, 50);
            this.materialTextBoxCodeDepartment_KPA.TabIndex = 1;
            this.materialTextBoxCodeDepartment_KPA.Text = "";
            this.materialTextBoxCodeDepartment_KPA.TrailingIcon = null;
            this.materialTextBoxCodeDepartment_KPA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBoxCodeDepartment_KPA_KeyPress);
            // 
            // materialTextBoxDepartmentName_KPA
            // 
            this.materialTextBoxDepartmentName_KPA.AnimateReadOnly = false;
            this.materialTextBoxDepartmentName_KPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxDepartmentName_KPA.Depth = 0;
            this.materialTextBoxDepartmentName_KPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxDepartmentName_KPA.LeadingIcon = null;
            this.materialTextBoxDepartmentName_KPA.Location = new System.Drawing.Point(788, 208);
            this.materialTextBoxDepartmentName_KPA.MaxLength = 50;
            this.materialTextBoxDepartmentName_KPA.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxDepartmentName_KPA.Multiline = false;
            this.materialTextBoxDepartmentName_KPA.Name = "materialTextBoxDepartmentName_KPA";
            this.materialTextBoxDepartmentName_KPA.Size = new System.Drawing.Size(240, 50);
            this.materialTextBoxDepartmentName_KPA.TabIndex = 2;
            this.materialTextBoxDepartmentName_KPA.Text = "";
            this.materialTextBoxDepartmentName_KPA.TrailingIcon = null;
            this.materialTextBoxDepartmentName_KPA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBoxDepartmentName_KPA_KeyPress);
            // 
            // materialComboBoxTeachers_KPA
            // 
            this.materialComboBoxTeachers_KPA.AutoResize = false;
            this.materialComboBoxTeachers_KPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxTeachers_KPA.Depth = 0;
            this.materialComboBoxTeachers_KPA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxTeachers_KPA.DropDownHeight = 174;
            this.materialComboBoxTeachers_KPA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxTeachers_KPA.DropDownWidth = 121;
            this.materialComboBoxTeachers_KPA.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxTeachers_KPA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxTeachers_KPA.FormattingEnabled = true;
            this.materialComboBoxTeachers_KPA.IntegralHeight = false;
            this.materialComboBoxTeachers_KPA.ItemHeight = 43;
            this.materialComboBoxTeachers_KPA.Location = new System.Drawing.Point(788, 316);
            this.materialComboBoxTeachers_KPA.MaxDropDownItems = 4;
            this.materialComboBoxTeachers_KPA.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxTeachers_KPA.Name = "materialComboBoxTeachers_KPA";
            this.materialComboBoxTeachers_KPA.Size = new System.Drawing.Size(240, 49);
            this.materialComboBoxTeachers_KPA.StartIndex = 0;
            this.materialComboBoxTeachers_KPA.TabIndex = 3;
            // 
            // materialButtonAddDepartmnet_KPA
            // 
            this.materialButtonAddDepartmnet_KPA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAddDepartmnet_KPA.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAddDepartmnet_KPA.Depth = 0;
            this.materialButtonAddDepartmnet_KPA.HighEmphasis = true;
            this.materialButtonAddDepartmnet_KPA.Icon = null;
            this.materialButtonAddDepartmnet_KPA.Location = new System.Drawing.Point(376, 471);
            this.materialButtonAddDepartmnet_KPA.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAddDepartmnet_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAddDepartmnet_KPA.Name = "materialButtonAddDepartmnet_KPA";
            this.materialButtonAddDepartmnet_KPA.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAddDepartmnet_KPA.Size = new System.Drawing.Size(100, 36);
            this.materialButtonAddDepartmnet_KPA.TabIndex = 4;
            this.materialButtonAddDepartmnet_KPA.Text = "добавить";
            this.materialButtonAddDepartmnet_KPA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAddDepartmnet_KPA.UseAccentColor = false;
            this.materialButtonAddDepartmnet_KPA.UseVisualStyleBackColor = true;
            this.materialButtonAddDepartmnet_KPA.Click += new System.EventHandler(this.materialButtonAddDepartmnet_KPA_Click);
            // 
            // materialLabelCode_KPA
            // 
            this.materialLabelCode_KPA.AutoSize = true;
            this.materialLabelCode_KPA.Depth = 0;
            this.materialLabelCode_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelCode_KPA.Location = new System.Drawing.Point(650, 120);
            this.materialLabelCode_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelCode_KPA.Name = "materialLabelCode_KPA";
            this.materialLabelCode_KPA.Size = new System.Drawing.Size(30, 19);
            this.materialLabelCode_KPA.TabIndex = 5;
            this.materialLabelCode_KPA.Text = "Код";
            // 
            // materialLabelName_KPA
            // 
            this.materialLabelName_KPA.AutoSize = true;
            this.materialLabelName_KPA.Depth = 0;
            this.materialLabelName_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelName_KPA.Location = new System.Drawing.Point(650, 224);
            this.materialLabelName_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelName_KPA.Name = "materialLabelName_KPA";
            this.materialLabelName_KPA.Size = new System.Drawing.Size(73, 19);
            this.materialLabelName_KPA.TabIndex = 6;
            this.materialLabelName_KPA.Text = "Название";
            // 
            // materialLabelHeadTeacher_KPA
            // 
            this.materialLabelHeadTeacher_KPA.AutoSize = true;
            this.materialLabelHeadTeacher_KPA.Depth = 0;
            this.materialLabelHeadTeacher_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelHeadTeacher_KPA.Location = new System.Drawing.Point(650, 335);
            this.materialLabelHeadTeacher_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelHeadTeacher_KPA.Name = "materialLabelHeadTeacher_KPA";
            this.materialLabelHeadTeacher_KPA.Size = new System.Drawing.Size(99, 19);
            this.materialLabelHeadTeacher_KPA.TabIndex = 7;
            this.materialLabelHeadTeacher_KPA.Text = "Заведующий";
            // 
            // ColumnCode
            // 
            this.ColumnCode.HeaderText = "Код";
            this.ColumnCode.MinimumWidth = 6;
            this.ColumnCode.Name = "ColumnCode";
            this.ColumnCode.ReadOnly = true;
            this.ColumnCode.Width = 125;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Название";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 125;
            // 
            // HeadTeacher
            // 
            this.HeadTeacher.HeaderText = "Заведующий";
            this.HeadTeacher.MinimumWidth = 6;
            this.HeadTeacher.Name = "HeadTeacher";
            this.HeadTeacher.ReadOnly = true;
            this.HeadTeacher.Width = 125;
            // 
            // materialButtonDelete_KPA
            // 
            this.materialButtonDelete_KPA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonDelete_KPA.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonDelete_KPA.Depth = 0;
            this.materialButtonDelete_KPA.HighEmphasis = true;
            this.materialButtonDelete_KPA.Icon = null;
            this.materialButtonDelete_KPA.Location = new System.Drawing.Point(514, 471);
            this.materialButtonDelete_KPA.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonDelete_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonDelete_KPA.Name = "materialButtonDelete_KPA";
            this.materialButtonDelete_KPA.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonDelete_KPA.Size = new System.Drawing.Size(91, 36);
            this.materialButtonDelete_KPA.TabIndex = 8;
            this.materialButtonDelete_KPA.Text = "Удалить";
            this.materialButtonDelete_KPA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonDelete_KPA.UseAccentColor = false;
            this.materialButtonDelete_KPA.UseVisualStyleBackColor = true;
            // 
            // materialButtonEdit_KPA
            // 
            this.materialButtonEdit_KPA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonEdit_KPA.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonEdit_KPA.Depth = 0;
            this.materialButtonEdit_KPA.HighEmphasis = true;
            this.materialButtonEdit_KPA.Icon = null;
            this.materialButtonEdit_KPA.Location = new System.Drawing.Point(42, 471);
            this.materialButtonEdit_KPA.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonEdit_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonEdit_KPA.Name = "materialButtonEdit_KPA";
            this.materialButtonEdit_KPA.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonEdit_KPA.Size = new System.Drawing.Size(146, 36);
            this.materialButtonEdit_KPA.TabIndex = 9;
            this.materialButtonEdit_KPA.Text = "Редактировать";
            this.materialButtonEdit_KPA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonEdit_KPA.UseAccentColor = false;
            this.materialButtonEdit_KPA.UseVisualStyleBackColor = true;
            this.materialButtonEdit_KPA.Click += new System.EventHandler(this.materialButtonEdit_KPA_Click);
            // 
            // DepartmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 564);
            this.Controls.Add(this.materialButtonEdit_KPA);
            this.Controls.Add(this.materialButtonDelete_KPA);
            this.Controls.Add(this.materialLabelHeadTeacher_KPA);
            this.Controls.Add(this.materialLabelName_KPA);
            this.Controls.Add(this.materialLabelCode_KPA);
            this.Controls.Add(this.materialButtonAddDepartmnet_KPA);
            this.Controls.Add(this.materialComboBoxTeachers_KPA);
            this.Controls.Add(this.materialTextBoxDepartmentName_KPA);
            this.Controls.Add(this.materialTextBoxCodeDepartment_KPA);
            this.Controls.Add(this.dataGridViewDepartmnets_KPA);
            this.Name = "DepartmentsForm";
            this.Text = "Кафедры";
            this.Load += new System.EventHandler(this.DepartmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartmnets_KPA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}