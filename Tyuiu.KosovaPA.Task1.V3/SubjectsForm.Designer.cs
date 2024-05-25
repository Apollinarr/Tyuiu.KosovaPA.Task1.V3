namespace Tyuiu.KosovaPA.Task1.V3
{
    partial class SubjectsForm
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
            dataGridViewSubjects_KPA = new System.Windows.Forms.DataGridView();
            ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnHourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColumnIsExam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            materialLabelCount_KPA = new MaterialSkin.Controls.MaterialLabel();
            materialTextBoxCodeSubject_KPA = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxNameSubject_KPA = new MaterialSkin.Controls.MaterialTextBox();
            materialTextBoxHoursSubject_KPA = new MaterialSkin.Controls.MaterialTextBox();
            materialComboBoxIsExamSubject_KPA = new MaterialSkin.Controls.MaterialComboBox();
            materialLabelCodeSubject_KPA = new MaterialSkin.Controls.MaterialLabel();
            materialLabelNameSubject_KPA = new MaterialSkin.Controls.MaterialLabel();
            materialLabelHourseSubject_KPA = new MaterialSkin.Controls.MaterialLabel();
            materialLabelisExamSubject_KPA = new MaterialSkin.Controls.MaterialLabel();
            materialButtonAddSubject_KPA = new MaterialSkin.Controls.MaterialButton();
            materialButtonDeleteSubject_KPA = new MaterialSkin.Controls.MaterialButton();
            materialButtonEditSubject_KPA = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjects_KPA).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewSubjects_KPA
            // 
            dataGridViewSubjects_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            dataGridViewSubjects_KPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSubjects_KPA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ColumnCode, ColumnName, ColumnHourse, ColumnIsExam });
            dataGridViewSubjects_KPA.Location = new System.Drawing.Point(21, 122);
            dataGridViewSubjects_KPA.Name = "dataGridViewSubjects_KPA";
            dataGridViewSubjects_KPA.RowHeadersWidth = 51;
            dataGridViewSubjects_KPA.Size = new System.Drawing.Size(631, 375);
            dataGridViewSubjects_KPA.TabIndex = 0;
            dataGridViewSubjects_KPA.Click += dataGridViewSubjects_KPA_Click;
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
            ColumnName.HeaderText = "Нзвание";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.Width = 125;
            // 
            // ColumnHourse
            // 
            ColumnHourse.HeaderText = "Часы";
            ColumnHourse.MinimumWidth = 6;
            ColumnHourse.Name = "ColumnHourse";
            ColumnHourse.ReadOnly = true;
            ColumnHourse.Width = 125;
            // 
            // ColumnIsExam
            // 
            ColumnIsExam.HeaderText = "Тип контроля";
            ColumnIsExam.MinimumWidth = 6;
            ColumnIsExam.Name = "ColumnIsExam";
            ColumnIsExam.ReadOnly = true;
            ColumnIsExam.Width = 125;
            // 
            // materialLabelCount_KPA
            // 
            materialLabelCount_KPA.AutoSize = true;
            materialLabelCount_KPA.Depth = 0;
            materialLabelCount_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabelCount_KPA.Location = new System.Drawing.Point(21, 91);
            materialLabelCount_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelCount_KPA.Name = "materialLabelCount_KPA";
            materialLabelCount_KPA.Size = new System.Drawing.Size(97, 19);
            materialLabelCount_KPA.TabIndex = 1;
            materialLabelCount_KPA.Text = "Количество: ";
            // 
            // materialTextBoxCodeSubject_KPA
            // 
            materialTextBoxCodeSubject_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            materialTextBoxCodeSubject_KPA.AnimateReadOnly = false;
            materialTextBoxCodeSubject_KPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialTextBoxCodeSubject_KPA.Depth = 0;
            materialTextBoxCodeSubject_KPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTextBoxCodeSubject_KPA.LeadingIcon = null;
            materialTextBoxCodeSubject_KPA.Location = new System.Drawing.Point(884, 122);
            materialTextBoxCodeSubject_KPA.MaxLength = 5;
            materialTextBoxCodeSubject_KPA.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxCodeSubject_KPA.Multiline = false;
            materialTextBoxCodeSubject_KPA.Name = "materialTextBoxCodeSubject_KPA";
            materialTextBoxCodeSubject_KPA.Size = new System.Drawing.Size(240, 50);
            materialTextBoxCodeSubject_KPA.TabIndex = 2;
            materialTextBoxCodeSubject_KPA.Text = "";
            materialTextBoxCodeSubject_KPA.TrailingIcon = null;
            materialTextBoxCodeSubject_KPA.KeyPress += materialTextBoxCodeSubject_KPA_KeyPress;
            // 
            // materialTextBoxNameSubject_KPA
            // 
            materialTextBoxNameSubject_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            materialTextBoxNameSubject_KPA.AnimateReadOnly = false;
            materialTextBoxNameSubject_KPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialTextBoxNameSubject_KPA.Depth = 0;
            materialTextBoxNameSubject_KPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTextBoxNameSubject_KPA.LeadingIcon = null;
            materialTextBoxNameSubject_KPA.Location = new System.Drawing.Point(884, 226);
            materialTextBoxNameSubject_KPA.MaxLength = 50;
            materialTextBoxNameSubject_KPA.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxNameSubject_KPA.Multiline = false;
            materialTextBoxNameSubject_KPA.Name = "materialTextBoxNameSubject_KPA";
            materialTextBoxNameSubject_KPA.Size = new System.Drawing.Size(240, 50);
            materialTextBoxNameSubject_KPA.TabIndex = 3;
            materialTextBoxNameSubject_KPA.Text = "";
            materialTextBoxNameSubject_KPA.TrailingIcon = null;
            materialTextBoxNameSubject_KPA.KeyPress += materialTextBoxNameSubject_KPA_KeyPress;
            // 
            // materialTextBoxHoursSubject_KPA
            // 
            materialTextBoxHoursSubject_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            materialTextBoxHoursSubject_KPA.AnimateReadOnly = false;
            materialTextBoxHoursSubject_KPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            materialTextBoxHoursSubject_KPA.Depth = 0;
            materialTextBoxHoursSubject_KPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialTextBoxHoursSubject_KPA.LeadingIcon = null;
            materialTextBoxHoursSubject_KPA.Location = new System.Drawing.Point(884, 336);
            materialTextBoxHoursSubject_KPA.MaxLength = 3;
            materialTextBoxHoursSubject_KPA.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxHoursSubject_KPA.Multiline = false;
            materialTextBoxHoursSubject_KPA.Name = "materialTextBoxHoursSubject_KPA";
            materialTextBoxHoursSubject_KPA.Size = new System.Drawing.Size(240, 50);
            materialTextBoxHoursSubject_KPA.TabIndex = 4;
            materialTextBoxHoursSubject_KPA.Text = "";
            materialTextBoxHoursSubject_KPA.TrailingIcon = null;
            materialTextBoxHoursSubject_KPA.KeyPress += materialTextBoxHoursSubject_KPA_KeyPress;
            // 
            // materialComboBoxIsExamSubject_KPA
            // 
            materialComboBoxIsExamSubject_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            materialComboBoxIsExamSubject_KPA.AutoResize = false;
            materialComboBoxIsExamSubject_KPA.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            materialComboBoxIsExamSubject_KPA.Depth = 0;
            materialComboBoxIsExamSubject_KPA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            materialComboBoxIsExamSubject_KPA.DropDownHeight = 174;
            materialComboBoxIsExamSubject_KPA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            materialComboBoxIsExamSubject_KPA.DropDownWidth = 121;
            materialComboBoxIsExamSubject_KPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            materialComboBoxIsExamSubject_KPA.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            materialComboBoxIsExamSubject_KPA.FormattingEnabled = true;
            materialComboBoxIsExamSubject_KPA.IntegralHeight = false;
            materialComboBoxIsExamSubject_KPA.ItemHeight = 43;
            materialComboBoxIsExamSubject_KPA.Items.AddRange(new object[] { "Экзамен", "Зачёт" });
            materialComboBoxIsExamSubject_KPA.Location = new System.Drawing.Point(884, 448);
            materialComboBoxIsExamSubject_KPA.MaxDropDownItems = 4;
            materialComboBoxIsExamSubject_KPA.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBoxIsExamSubject_KPA.Name = "materialComboBoxIsExamSubject_KPA";
            materialComboBoxIsExamSubject_KPA.Size = new System.Drawing.Size(240, 49);
            materialComboBoxIsExamSubject_KPA.StartIndex = 0;
            materialComboBoxIsExamSubject_KPA.TabIndex = 5;
            // 
            // materialLabelCodeSubject_KPA
            // 
            materialLabelCodeSubject_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            materialLabelCodeSubject_KPA.AutoSize = true;
            materialLabelCodeSubject_KPA.Depth = 0;
            materialLabelCodeSubject_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabelCodeSubject_KPA.Location = new System.Drawing.Point(695, 134);
            materialLabelCodeSubject_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelCodeSubject_KPA.Name = "materialLabelCodeSubject_KPA";
            materialLabelCodeSubject_KPA.Size = new System.Drawing.Size(30, 19);
            materialLabelCodeSubject_KPA.TabIndex = 6;
            materialLabelCodeSubject_KPA.Text = "Код";
            // 
            // materialLabelNameSubject_KPA
            // 
            materialLabelNameSubject_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            materialLabelNameSubject_KPA.AutoSize = true;
            materialLabelNameSubject_KPA.Depth = 0;
            materialLabelNameSubject_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabelNameSubject_KPA.Location = new System.Drawing.Point(695, 241);
            materialLabelNameSubject_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelNameSubject_KPA.Name = "materialLabelNameSubject_KPA";
            materialLabelNameSubject_KPA.Size = new System.Drawing.Size(73, 19);
            materialLabelNameSubject_KPA.TabIndex = 7;
            materialLabelNameSubject_KPA.Text = "Название";
            // 
            // materialLabelHourseSubject_KPA
            // 
            materialLabelHourseSubject_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            materialLabelHourseSubject_KPA.AutoSize = true;
            materialLabelHourseSubject_KPA.Depth = 0;
            materialLabelHourseSubject_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabelHourseSubject_KPA.Location = new System.Drawing.Point(695, 347);
            materialLabelHourseSubject_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelHourseSubject_KPA.Name = "materialLabelHourseSubject_KPA";
            materialLabelHourseSubject_KPA.Size = new System.Drawing.Size(137, 19);
            materialLabelHourseSubject_KPA.TabIndex = 8;
            materialLabelHourseSubject_KPA.Text = "Количество часов";
            // 
            // materialLabelisExamSubject_KPA
            // 
            materialLabelisExamSubject_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            materialLabelisExamSubject_KPA.AutoSize = true;
            materialLabelisExamSubject_KPA.Depth = 0;
            materialLabelisExamSubject_KPA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            materialLabelisExamSubject_KPA.Location = new System.Drawing.Point(695, 462);
            materialLabelisExamSubject_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelisExamSubject_KPA.Name = "materialLabelisExamSubject_KPA";
            materialLabelisExamSubject_KPA.Size = new System.Drawing.Size(104, 19);
            materialLabelisExamSubject_KPA.TabIndex = 9;
            materialLabelisExamSubject_KPA.Text = "Тип контроля";
            // 
            // materialButtonAddSubject_KPA
            // 
            materialButtonAddSubject_KPA.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            materialButtonAddSubject_KPA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            materialButtonAddSubject_KPA.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonAddSubject_KPA.Depth = 0;
            materialButtonAddSubject_KPA.HighEmphasis = true;
            materialButtonAddSubject_KPA.Icon = null;
            materialButtonAddSubject_KPA.Location = new System.Drawing.Point(425, 566);
            materialButtonAddSubject_KPA.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            materialButtonAddSubject_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonAddSubject_KPA.Name = "materialButtonAddSubject_KPA";
            materialButtonAddSubject_KPA.NoAccentTextColor = System.Drawing.Color.Empty;
            materialButtonAddSubject_KPA.Size = new System.Drawing.Size(100, 36);
            materialButtonAddSubject_KPA.TabIndex = 10;
            materialButtonAddSubject_KPA.Text = "Добавить";
            materialButtonAddSubject_KPA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonAddSubject_KPA.UseAccentColor = false;
            materialButtonAddSubject_KPA.UseVisualStyleBackColor = true;
            materialButtonAddSubject_KPA.Click += materialButtonAddSubject_KPA_Click;
            // 
            // materialButtonDeleteSubject_KPA
            // 
            materialButtonDeleteSubject_KPA.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            materialButtonDeleteSubject_KPA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            materialButtonDeleteSubject_KPA.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonDeleteSubject_KPA.Depth = 0;
            materialButtonDeleteSubject_KPA.HighEmphasis = true;
            materialButtonDeleteSubject_KPA.Icon = null;
            materialButtonDeleteSubject_KPA.Location = new System.Drawing.Point(561, 566);
            materialButtonDeleteSubject_KPA.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            materialButtonDeleteSubject_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonDeleteSubject_KPA.Name = "materialButtonDeleteSubject_KPA";
            materialButtonDeleteSubject_KPA.NoAccentTextColor = System.Drawing.Color.Empty;
            materialButtonDeleteSubject_KPA.Size = new System.Drawing.Size(91, 36);
            materialButtonDeleteSubject_KPA.TabIndex = 11;
            materialButtonDeleteSubject_KPA.Text = "Удалить";
            materialButtonDeleteSubject_KPA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonDeleteSubject_KPA.UseAccentColor = false;
            materialButtonDeleteSubject_KPA.UseVisualStyleBackColor = true;
            materialButtonDeleteSubject_KPA.Click += materialButtonDeleteSubject_KPA_Click;
            // 
            // materialButtonEditSubject_KPA
            // 
            materialButtonEditSubject_KPA.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            materialButtonEditSubject_KPA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            materialButtonEditSubject_KPA.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonEditSubject_KPA.Depth = 0;
            materialButtonEditSubject_KPA.HighEmphasis = true;
            materialButtonEditSubject_KPA.Icon = null;
            materialButtonEditSubject_KPA.Location = new System.Drawing.Point(21, 566);
            materialButtonEditSubject_KPA.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            materialButtonEditSubject_KPA.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonEditSubject_KPA.Name = "materialButtonEditSubject_KPA";
            materialButtonEditSubject_KPA.NoAccentTextColor = System.Drawing.Color.Empty;
            materialButtonEditSubject_KPA.Size = new System.Drawing.Size(146, 36);
            materialButtonEditSubject_KPA.TabIndex = 12;
            materialButtonEditSubject_KPA.Text = "Редактировать";
            materialButtonEditSubject_KPA.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonEditSubject_KPA.UseAccentColor = false;
            materialButtonEditSubject_KPA.UseVisualStyleBackColor = true;
            materialButtonEditSubject_KPA.Click += materialButtonEditSubject_KPA_Click;
            // 
            // SubjectsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1178, 705);
            Controls.Add(materialButtonEditSubject_KPA);
            Controls.Add(materialButtonDeleteSubject_KPA);
            Controls.Add(materialButtonAddSubject_KPA);
            Controls.Add(materialLabelisExamSubject_KPA);
            Controls.Add(materialLabelHourseSubject_KPA);
            Controls.Add(materialLabelNameSubject_KPA);
            Controls.Add(materialLabelCodeSubject_KPA);
            Controls.Add(materialComboBoxIsExamSubject_KPA);
            Controls.Add(materialTextBoxHoursSubject_KPA);
            Controls.Add(materialTextBoxNameSubject_KPA);
            Controls.Add(materialTextBoxCodeSubject_KPA);
            Controls.Add(materialLabelCount_KPA);
            Controls.Add(dataGridViewSubjects_KPA);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "SubjectsForm";
            Padding = new System.Windows.Forms.Padding(3, 80, 3, 4);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Предмет";
            Load += SubjectsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubjects_KPA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSubjects_KPA;
        private MaterialSkin.Controls.MaterialLabel materialLabelCount_KPA;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxCodeSubject_KPA;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxNameSubject_KPA;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxHoursSubject_KPA;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxIsExamSubject_KPA;
        private MaterialSkin.Controls.MaterialLabel materialLabelCodeSubject_KPA;
        private MaterialSkin.Controls.MaterialLabel materialLabelNameSubject_KPA;
        private MaterialSkin.Controls.MaterialLabel materialLabelHourseSubject_KPA;
        private MaterialSkin.Controls.MaterialLabel materialLabelisExamSubject_KPA;
        private MaterialSkin.Controls.MaterialButton materialButtonAddSubject_KPA;
        private MaterialSkin.Controls.MaterialButton materialButtonDeleteSubject_KPA;
        private MaterialSkin.Controls.MaterialButton materialButtonEditSubject_KPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIsExam;
    }
}