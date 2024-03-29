namespace Tyuiu.KosovaPA.Task1.V3
{
    partial class InfoForm
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
            labelName_KPA = new System.Windows.Forms.Label();
            flowLayoutPanelDescription_KPA = new System.Windows.Forms.FlowLayoutPanel();
            labelDescriptoin_KPA = new System.Windows.Forms.Label();
            labelName2_KPA = new System.Windows.Forms.Label();
            flowLayoutPanelDeveloper_KPA = new System.Windows.Forms.FlowLayoutPanel();
            labelDeveloper_KPA = new System.Windows.Forms.Label();
            flowLayoutPanelDescription_KPA.SuspendLayout();
            flowLayoutPanelDeveloper_KPA.SuspendLayout();
            SuspendLayout();
            // 
            // labelName_KPA
            // 
            labelName_KPA.AutoSize = true;
            labelName_KPA.Font = new System.Drawing.Font("Segoe UI", 19.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            labelName_KPA.Location = new System.Drawing.Point(267, 101);
            labelName_KPA.Name = "labelName_KPA";
            labelName_KPA.Size = new System.Drawing.Size(226, 46);
            labelName_KPA.TabIndex = 0;
            labelName_KPA.Text = "Университет";
            // 
            // flowLayoutPanelDescription_KPA
            // 
            flowLayoutPanelDescription_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            flowLayoutPanelDescription_KPA.Controls.Add(labelDescriptoin_KPA);
            flowLayoutPanelDescription_KPA.Location = new System.Drawing.Point(18, 210);
            flowLayoutPanelDescription_KPA.Name = "flowLayoutPanelDescription_KPA";
            flowLayoutPanelDescription_KPA.Size = new System.Drawing.Size(733, 95);
            flowLayoutPanelDescription_KPA.TabIndex = 1;
            // 
            // labelDescriptoin_KPA
            // 
            labelDescriptoin_KPA.AutoSize = true;
            labelDescriptoin_KPA.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            labelDescriptoin_KPA.Location = new System.Drawing.Point(3, 0);
            labelDescriptoin_KPA.Name = "labelDescriptoin_KPA";
            labelDescriptoin_KPA.Size = new System.Drawing.Size(695, 50);
            labelDescriptoin_KPA.TabIndex = 1;
            labelDescriptoin_KPA.Text = "В программе реализован функционал добавления, изменения и удаления данных. Данные хранятся в csv файле.";
            // 
            // labelName2_KPA
            // 
            labelName2_KPA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            labelName2_KPA.AutoSize = true;
            labelName2_KPA.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            labelName2_KPA.Location = new System.Drawing.Point(209, 164);
            labelName2_KPA.Name = "labelName2_KPA";
            labelName2_KPA.Size = new System.Drawing.Size(369, 25);
            labelName2_KPA.TabIndex = 2;
            labelName2_KPA.Text = "Учет преподавателей, кафедр и предметов.";
            // 
            // flowLayoutPanelDeveloper_KPA
            // 
            flowLayoutPanelDeveloper_KPA.Controls.Add(labelDeveloper_KPA);
            flowLayoutPanelDeveloper_KPA.Location = new System.Drawing.Point(18, 311);
            flowLayoutPanelDeveloper_KPA.Name = "flowLayoutPanelDeveloper_KPA";
            flowLayoutPanelDeveloper_KPA.Size = new System.Drawing.Size(733, 98);
            flowLayoutPanelDeveloper_KPA.TabIndex = 3;
            // 
            // labelDeveloper_KPA
            // 
            labelDeveloper_KPA.AutoSize = true;
            labelDeveloper_KPA.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            labelDeveloper_KPA.Location = new System.Drawing.Point(3, 0);
            labelDeveloper_KPA.Name = "labelDeveloper_KPA";
            labelDeveloper_KPA.Size = new System.Drawing.Size(470, 25);
            labelDeveloper_KPA.TabIndex = 0;
            labelDeveloper_KPA.Text = "Разработчик: Косова Полина Алексеевна. АСОиУб-21-2";
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(flowLayoutPanelDeveloper_KPA);
            Controls.Add(labelName2_KPA);
            Controls.Add(flowLayoutPanelDescription_KPA);
            Controls.Add(labelName_KPA);
            Name = "InfoForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "О программе";
            Load += InfoForm_Load;
            flowLayoutPanelDescription_KPA.ResumeLayout(false);
            flowLayoutPanelDescription_KPA.PerformLayout();
            flowLayoutPanelDeveloper_KPA.ResumeLayout(false);
            flowLayoutPanelDeveloper_KPA.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelName_KPA;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDescription_KPA;
        private System.Windows.Forms.Label labelName2_KPA;
        private System.Windows.Forms.Label labelDescriptoin_KPA;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDeveloper_KPA;
        private System.Windows.Forms.Label labelDeveloper_KPA;
    }
}