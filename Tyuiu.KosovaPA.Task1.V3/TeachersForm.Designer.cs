namespace Tyuiu.KosovaPA.Task1.V3
{
    partial class TeachersForm
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
            dataGridViewTeachers_KPA = new System.Windows.Forms.DataGridView();
            ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnClassroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            materialTextBoxTeacherName_KPA = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxTeacherPosition_KPA = new MaterialSkin.Controls.MaterialTextBox();
            materialComboBoxTeacherSubject_KPA = new MaterialSkin.Controls.MaterialComboBox();
            materialComboBoxTeacherDepartment_KPA = new MaterialSkin.Controls.MaterialComboBox();
            materialTextBoxTeacherClassroom_KPA = new MaterialSkin.Controls.MaterialTextBox();
            materialButtonAddTeacher_KPA = new MaterialSkin.Controls.MaterialButton();
            materialButtonDeleteTeacher_KPA = new MaterialSkin.Controls.MaterialButton();
            materialButtonEditTeacher_KPA = new MaterialSkin.Controls.MaterialButton();
            materialLabelCountTeachers_KPA = new MaterialSkin.Controls.MaterialLabel();
            materialLabelTeacherName_KPA = new MaterialSkin.Controls.MaterialLabel();
            materialLabelTeacherPosition_KPA = new MaterialSkin.Controls.MaterialLabel();
            materialLabelTeacherSubject_KPA = new MaterialSkin.Controls.MaterialLabel();
            materialLabelTeacherDepartment_KPA = new MaterialSkin.Controls.MaterialLabel();
            materialLabelTeacherClassroom_KPA = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers_KPA).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTeachers_KPA
            // 
            dataGridViewTeachers_KPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeachers_KPA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColumnName, ColumnPosition, ColumnSubject, ColumnDepartment, ColumnClassroom });
            dataGridViewTeachers_KPA.Location = new System.Drawing.Point(24, 121);
            dataGridViewTeachers_KPA.Name = "dataGridViewTeachers_KPA";
            dataGridViewTeachers_KPA.RowHeadersWidth = 51;
            dataGridViewTeachers_KPA.Size = new System.Drawing.Size(767, 377);
            dataGridViewTeachers_KPA.TabIndex = 0;
            dataGridViewTeachers_KPA.Click += dataGridViewTeachers_KPA_Click;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Имя";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.Width = 125;
            // 
            // ColumnPosition
            // 
            ColumnPosition.HeaderText = "Должность";
            ColumnPosition.MinimumWidth = 6;
            ColumnPosition.Name = "ColumnPosition";
            ColumnPosition.ReadOnly = true;
            ColumnPosition.Width = 125;
            // 
            // ColumnSubject
            // 
            ColumnSubject.HeaderText = "Предмет";
            ColumnSubject.MinimumWidth = 6;
            ColumnSubject.Name = "ColumnSubject";
            ColumnSubject.ReadOnly = true;
            ColumnSubject.Width = 125;
            // 
            // ColumnDepartment
            // 
            ColumnDepartment.HeaderText = "Кафедра";
            ColumnDepartment.MinimumWidth = 6;
            ColumnDepartment.Name = "ColumnDepartment";
            ColumnDepartment.ReadOnly = true;
            ColumnDepartment.Width = 125;
            // 
            // ColumnClassroom
            // 
            ColumnClassroom.HeaderText = "Аудитория";
            ColumnClassroom.MinimumWidth = 6;
            ColumnClassroom.Name = "ColumnClassroom";
            ColumnClassroom.ReadOnly = true;
            ColumnClassroom.Width = 125;
            // 
            // materialTextBoxTeacherName_KPA
            // 
            materialTextBoxTeacherName_KPA.AnimateReadOnly = false;
            materialTextBoxTeacherName_KPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialTextBoxTeacherName_KPA.Depth = 0;
            materialTextBoxTeacherName_KPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTextBoxTeacherName_KPA.LeadingIcon = null;
            materialTextBoxTeacherName_KPA.Location = new System.Drawing.Point(970, 121);
            materialTextBoxTeacherName_KPA.MaxLength = 50;
            materialTextBoxTeacherName_KPA.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxTeacherName_KPA.Multiline = false;
            materialTextBoxTeacherName_KPA.Name = "materialTextBoxTeacherName_KPA";
            materialTextBoxTeacherName_KPA.Size = new System.Drawing.Size(240, 50);
            materialTextBoxTeacherName_KPA.TabIndex = 1;
            materialTextBoxTeacherName_KPA.Text = "";
            materialTextBoxTeacherName_KPA.TrailingIcon = null;
            materialTextBoxTeacherName_KPA.KeyPress += materialTextBoxTeacherName_KPA_KeyPress;
            // 
            // materialTextBoxTeacherPosition_KPA
            // 
            materialTextBoxTeacherPosition_KPA.AnimateReadOnly = false;
            materialTextBoxTeacherPosition_KPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialTextBoxTeacherPosition_KPA.Depth = 0;
            materialTextBoxTeacherPosition_KPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTextBoxTeacherPosition_KPA.LeadingIcon = null;
            materialTextBoxTeacherPosition_KPA.Location = new System.Drawing.Point(970, 226);
            materialTextBoxTeacherPosition_KPA.MaxLength = 20;
            materialTextBoxTeacherPosition_KPA.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxTeacherPosition_KPA.Multiline = false;
            materialTextBoxTeacherPosition_KPA.Name = "materialTextBoxTeacherPosition_KPA";
            materialTextBoxTeacherPosition_KPA.Size = new System.Drawing.Size(240, 50);
            materialTextBoxTeacherPosition_KPA.TabIndex = 2;
            materialTextBoxTeacherPosition_KPA.Text = "";
            materialTextBoxTeacherPosition_KPA.TrailingIcon = null;
            materialTextBoxTeacherPosition_KPA.KeyPress += materialTextBoxTeacherPosition_KPA_KeyPress;
            // 
            // materialComboBoxTeacherSubject_KPA
            // 
            materialComboBoxTeacherSubject_KPA.AutoResize = false;
            materialComboBoxTeacherSubject_KPA.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            materialComboBoxTeacherSubject_KPA.Depth = 0;
            materialComboBoxTeacherSubject_KPA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            materialComboBoxTeacherSubject_KPA.DropDownHeight = 174;
            materialComboBoxTeacherSubject_KPA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            materialComboBoxTeacherSubject_KPA.DropDownWidth = 121;
            materialComboBoxTeacherSubject_KPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            materialComboBoxTeacherSubject_KPA.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            materialComboBoxTeacherSubject_KPA.FormattingEnabled = true;
            materialComboBoxTeacherSubject_KPA.IntegralHeight = false;
            materialComboBoxTeacherSubject_KPA.ItemHeight = 43;
            materialComboBoxTeacherSubject_KPA.Location = new System.Drawing.Point(970, 338);
            materialComboBoxTeacherSubject_KPA.MaxDropDownItems = 4;
            materialComboBoxTeacherSubject_KPA.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxTeacherSubject_KPA.Name = "materialComboBoxTeacherSubject_KPA";
            materialComboBoxTeacherSubject_KPA.Size = new System.Drawing.Size(240, 49);
            materialComboBoxTeacherSubject_KPA.StartIndex = 0;
            materialComboBoxTeacherSubject_KPA.TabIndex = 3;
            // 
            // materialComboBoxTeacherDepartment_KPA
            // 
            materialComboBoxTeacherDepartment_KPA.AutoResize = false;
            materialComboBoxTeacherDepartment_KPA.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            materialComboBoxTeacherDepartment_KPA.Depth = 0;
            materialComboBoxTeacherDepartment_KPA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            materialComboBoxTeacherDepartment_KPA.DropDownHeight = 174;
            materialComboBoxTeacherDepartment_KPA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            materialComboBoxTeacherDepartment_KPA.DropDownWidth = 121;
            materialComboBoxTeacherDepartment_KPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            materialComboBoxTeacherDepartment_KPA.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            materialComboBoxTeacherDepartment_KPA.FormattingEnabled = true;
            materialComboBoxTeacherDepartment_KPA.IntegralHeight = false;
            materialComboBoxTeacherDepartment_KPA.ItemHeight = 43;
            materialComboBoxTeacherDepartment_KPA.Location = new System.Drawing.Point(970, 449);
            materialComboBoxTeacherDepartment_KPA.MaxDropDownItems = 4;
            materialComboBoxTeacherDepartment_KPA.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxTeacherDepartment_KPA.Name = "materialComboBoxTeacherDepartment_KPA";
            materialComboBoxTeacherDepartment_KPA.Size = new System.Drawing.Size(240, 49);
            materialComboBoxTeacherDepartment_KPA.StartIndex = 0;
            materialComboBoxTeacherDepartment_KPA.TabIndex = 4;
            // 
            // materialTextBoxTeacherClassroom_KPA
            // 
            materialTextBoxTeacherClassroom_KPA.AnimateReadOnly = false;
            materialTextBoxTeacherClassroom_KPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialTextBoxTeacherClassroom_KPA.Depth = 0;
            materialTextBoxTeacherClassroom_KPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTextBoxTeacherClassroom_KPA.LeadingIcon = null;
            materialTextBoxTeacherClassroom_KPA.Location = new System.Drawing.Point(970, 556);
            materialTextBoxTeacherClassroom_KPA.MaxLength = 4;
            materialTextBoxTeacherClassroom_KPA.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxTeacherClassroom_KPA.Multiline = false;
            materialTextBoxTeacherClassroom_KPA.Name = "materialTextBoxTeacherClassroom_KPA";
            materialTextBoxTeacherClassroom_KPA.Size = new System.Drawing.Size(240, 50);
            materialTextBoxTeacherClassroom_KPA.TabIndex = 5;
            materialTextBoxTeacherClassroom_KPA.Text = "";
            materialTextBoxTeacherClassroom_KPA.TrailingIcon = null;
            materialTextBoxTeacherClassroom_KPA.KeyPress += materialTextBoxTeacherClassroom_KPA_KeyPress;
            // 
            // materialButtonAddTeacher_KPA
            // 
            materialButtonAddTeacher_KPA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            materialButtonAddTeacher_KPA.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonAddTeacher_KPA.Depth = 0;
            materialButtonAddTeacher_KPA.HighEmphasis = true;
            materialButtonAddTeacher_KPA.Icon = null;
            materialButtonAddTeacher_KPA.Location = new System.Drawing.Point(568, 556);
            materialButtonAddTeacher_KPA.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            materialButtonAddTeacher_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonAddTeacher_KPA.Name = "materialButtonAddTeacher_KPA";
            materialButtonAddTeacher_KPA.NoAccentTextColor = System.Drawing.Color.Empty;
            materialButtonAddTeacher_KPA.Size = new System.Drawing.Size(100, 36);
            materialButtonAddTeacher_KPA.TabIndex = 6;
            materialButtonAddTeacher_KPA.Text = "Добавить";
            materialButtonAddTeacher_KPA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonAddTeacher_KPA.UseAccentColor = false;
            materialButtonAddTeacher_KPA.UseVisualStyleBackColor = true;
            materialButtonAddTeacher_KPA.Click += materialButtonAddTeacher_KPA_Click;
            // 
            // materialButtonDeleteTeacher_KPA
            // 
            materialButtonDeleteTeacher_KPA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            materialButtonDeleteTeacher_KPA.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonDeleteTeacher_KPA.Depth = 0;
            materialButtonDeleteTeacher_KPA.HighEmphasis = true;
            materialButtonDeleteTeacher_KPA.Icon = null;
            materialButtonDeleteTeacher_KPA.Location = new System.Drawing.Point(700, 556);
            materialButtonDeleteTeacher_KPA.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            materialButtonDeleteTeacher_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonDeleteTeacher_KPA.Name = "materialButtonDeleteTeacher_KPA";
            materialButtonDeleteTeacher_KPA.NoAccentTextColor = System.Drawing.Color.Empty;
            materialButtonDeleteTeacher_KPA.Size = new System.Drawing.Size(91, 36);
            materialButtonDeleteTeacher_KPA.TabIndex = 7;
            materialButtonDeleteTeacher_KPA.Text = "Удалить";
            materialButtonDeleteTeacher_KPA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonDeleteTeacher_KPA.UseAccentColor = false;
            materialButtonDeleteTeacher_KPA.UseVisualStyleBackColor = true;
            materialButtonDeleteTeacher_KPA.Click += materialButtonDeleteTeacher_KPA_Click;
            // 
            // materialButtonEditTeacher_KPA
            // 
            materialButtonEditTeacher_KPA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            materialButtonEditTeacher_KPA.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonEditTeacher_KPA.Depth = 0;
            materialButtonEditTeacher_KPA.HighEmphasis = true;
            materialButtonEditTeacher_KPA.Icon = null;
            materialButtonEditTeacher_KPA.Location = new System.Drawing.Point(24, 556);
            materialButtonEditTeacher_KPA.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            materialButtonEditTeacher_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonEditTeacher_KPA.Name = "materialButtonEditTeacher_KPA";
            materialButtonEditTeacher_KPA.NoAccentTextColor = System.Drawing.Color.Empty;
            materialButtonEditTeacher_KPA.Size = new System.Drawing.Size(146, 36);
            materialButtonEditTeacher_KPA.TabIndex = 8;
            materialButtonEditTeacher_KPA.Text = "Редактировать";
            materialButtonEditTeacher_KPA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonEditTeacher_KPA.UseAccentColor = false;
            materialButtonEditTeacher_KPA.UseVisualStyleBackColor = true;
            materialButtonEditTeacher_KPA.Click += materialButtonEditTeacher_KPA_Click;
            // 
            // materialLabelCountTeachers_KPA
            // 
            materialLabelCountTeachers_KPA.AutoSize = true;
            materialLabelCountTeachers_KPA.Depth = 0;
            materialLabelCountTeachers_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabelCountTeachers_KPA.Location = new System.Drawing.Point(24, 90);
            materialLabelCountTeachers_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelCountTeachers_KPA.Name = "materialLabelCountTeachers_KPA";
            materialLabelCountTeachers_KPA.Size = new System.Drawing.Size(93, 19);
            materialLabelCountTeachers_KPA.TabIndex = 9;
            materialLabelCountTeachers_KPA.Text = "Количество:";
            // 
            // materialLabelTeacherName_KPA
            // 
            materialLabelTeacherName_KPA.AutoSize = true;
            materialLabelTeacherName_KPA.Depth = 0;
            materialLabelTeacherName_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabelTeacherName_KPA.Location = new System.Drawing.Point(838, 135);
            materialLabelTeacherName_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelTeacherName_KPA.Name = "materialLabelTeacherName_KPA";
            materialLabelTeacherName_KPA.Size = new System.Drawing.Size(33, 19);
            materialLabelTeacherName_KPA.TabIndex = 10;
            materialLabelTeacherName_KPA.Text = "Имя";
            // 
            // materialLabelTeacherPosition_KPA
            // 
            materialLabelTeacherPosition_KPA.AutoSize = true;
            materialLabelTeacherPosition_KPA.Depth = 0;
            materialLabelTeacherPosition_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabelTeacherPosition_KPA.Location = new System.Drawing.Point(838, 240);
            materialLabelTeacherPosition_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelTeacherPosition_KPA.Name = "materialLabelTeacherPosition_KPA";
            materialLabelTeacherPosition_KPA.Size = new System.Drawing.Size(86, 19);
            materialLabelTeacherPosition_KPA.TabIndex = 11;
            materialLabelTeacherPosition_KPA.Text = "Должность";
            // 
            // materialLabelTeacherSubject_KPA
            // 
            materialLabelTeacherSubject_KPA.AutoSize = true;
            materialLabelTeacherSubject_KPA.Depth = 0;
            materialLabelTeacherSubject_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabelTeacherSubject_KPA.Location = new System.Drawing.Point(838, 352);
            materialLabelTeacherSubject_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelTeacherSubject_KPA.Name = "materialLabelTeacherSubject_KPA";
            materialLabelTeacherSubject_KPA.Size = new System.Drawing.Size(67, 19);
            materialLabelTeacherSubject_KPA.TabIndex = 12;
            materialLabelTeacherSubject_KPA.Text = "Предмет";
            // 
            // materialLabelTeacherDepartment_KPA
            // 
            materialLabelTeacherDepartment_KPA.AutoSize = true;
            materialLabelTeacherDepartment_KPA.Depth = 0;
            materialLabelTeacherDepartment_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabelTeacherDepartment_KPA.Location = new System.Drawing.Point(838, 452);
            materialLabelTeacherDepartment_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelTeacherDepartment_KPA.Name = "materialLabelTeacherDepartment_KPA";
            materialLabelTeacherDepartment_KPA.Size = new System.Drawing.Size(68, 19);
            materialLabelTeacherDepartment_KPA.TabIndex = 13;
            materialLabelTeacherDepartment_KPA.Text = "Кафедра";
            // 
            // materialLabelTeacherClassroom_KPA
            // 
            materialLabelTeacherClassroom_KPA.AutoSize = true;
            materialLabelTeacherClassroom_KPA.Depth = 0;
            materialLabelTeacherClassroom_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabelTeacherClassroom_KPA.Location = new System.Drawing.Point(838, 567);
            materialLabelTeacherClassroom_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelTeacherClassroom_KPA.Name = "materialLabelTeacherClassroom_KPA";
            materialLabelTeacherClassroom_KPA.Size = new System.Drawing.Size(82, 19);
            materialLabelTeacherClassroom_KPA.TabIndex = 14;
            materialLabelTeacherClassroom_KPA.Text = "Аудитория";
            // 
            // TeachersForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1253, 705);
            Controls.Add(materialLabelTeacherClassroom_KPA);
            Controls.Add(materialLabelTeacherDepartment_KPA);
            Controls.Add(materialLabelTeacherSubject_KPA);
            Controls.Add(materialLabelTeacherPosition_KPA);
            Controls.Add(materialLabelTeacherName_KPA);
            Controls.Add(materialLabelCountTeachers_KPA);
            Controls.Add(materialButtonEditTeacher_KPA);
            Controls.Add(materialButtonDeleteTeacher_KPA);
            Controls.Add(materialButtonAddTeacher_KPA);
            Controls.Add(materialTextBoxTeacherClassroom_KPA);
            Controls.Add(materialComboBoxTeacherDepartment_KPA);
            Controls.Add(materialComboBoxTeacherSubject_KPA);
            Controls.Add(materialTextBoxTeacherPosition_KPA);
            Controls.Add(materialTextBoxTeacherName_KPA);
            Controls.Add(dataGridViewTeachers_KPA);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "TeachersForm";
            Padding = new System.Windows.Forms.Padding(3, 80, 3, 4);
            Text = "Преподаватели";
            Load += TeachersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers_KPA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTeachers_KPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClassroom;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxTeacherName_KPA;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxTeacherPosition_KPA;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxTeacherSubject_KPA;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxTeacherDepartment_KPA;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxTeacherClassroom_KPA;
        private MaterialSkin.Controls.MaterialButton materialButtonAddTeacher_KPA;
        private MaterialSkin.Controls.MaterialButton materialButtonDeleteTeacher_KPA;
        private MaterialSkin.Controls.MaterialButton materialButtonEditTeacher_KPA;
        private MaterialSkin.Controls.MaterialLabel materialLabelCountTeachers_KPA;
        private MaterialSkin.Controls.MaterialLabel materialLabelTeacherName_KPA;
        private MaterialSkin.Controls.MaterialLabel materialLabelTeacherPosition_KPA;
        private MaterialSkin.Controls.MaterialLabel materialLabelTeacherSubject_KPA;
        private MaterialSkin.Controls.MaterialLabel materialLabelTeacherDepartment_KPA;
        private MaterialSkin.Controls.MaterialLabel materialLabelTeacherClassroom_KPA;
    }
}