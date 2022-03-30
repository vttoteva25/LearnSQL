
namespace LearnSQL
{
    partial class Course
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
			this.MaterialsRichTextBox = new System.Windows.Forms.RichTextBox();
			this.StagePanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.StagesListBox = new System.Windows.Forms.ListBox();
			this.OpenPopUpFormButton = new System.Windows.Forms.Button();
			this.StagePanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// MaterialsRichTextBox
			// 
			this.MaterialsRichTextBox.BackColor = System.Drawing.Color.Ivory;
			this.MaterialsRichTextBox.Location = new System.Drawing.Point(338, 21);
			this.MaterialsRichTextBox.Name = "MaterialsRichTextBox";
			this.MaterialsRichTextBox.ReadOnly = true;
			this.MaterialsRichTextBox.Size = new System.Drawing.Size(672, 511);
			this.MaterialsRichTextBox.TabIndex = 0;
			this.MaterialsRichTextBox.Text = "";
			// 
			// StagePanel
			// 
			this.StagePanel.Controls.Add(this.panel1);
			this.StagePanel.Controls.Add(this.OpenPopUpFormButton);
			this.StagePanel.Controls.Add(this.MaterialsRichTextBox);
			this.StagePanel.Location = new System.Drawing.Point(-2, -1);
			this.StagePanel.Name = "StagePanel";
			this.StagePanel.Size = new System.Drawing.Size(1035, 629);
			this.StagePanel.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightGreen;
			this.panel1.Controls.Add(this.StagesListBox);
			this.panel1.Location = new System.Drawing.Point(28, 21);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(292, 584);
			this.panel1.TabIndex = 6;
			// 
			// StagesListBox
			// 
			this.StagesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.StagesListBox.FormattingEnabled = true;
			this.StagesListBox.ItemHeight = 26;
			this.StagesListBox.Location = new System.Drawing.Point(16, 21);
			this.StagesListBox.Name = "StagesListBox";
			this.StagesListBox.Size = new System.Drawing.Size(254, 550);
			this.StagesListBox.TabIndex = 4;
			// 
			// OpenPopUpFormButton
			// 
			this.OpenPopUpFormButton.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.OpenPopUpFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OpenPopUpFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OpenPopUpFormButton.ForeColor = System.Drawing.Color.White;
			this.OpenPopUpFormButton.Location = new System.Drawing.Point(761, 554);
			this.OpenPopUpFormButton.Name = "OpenPopUpFormButton";
			this.OpenPopUpFormButton.Size = new System.Drawing.Size(249, 63);
			this.OpenPopUpFormButton.TabIndex = 5;
			this.OpenPopUpFormButton.Text = "Към задачите";
			this.OpenPopUpFormButton.UseVisualStyleBackColor = false;
			this.OpenPopUpFormButton.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// Course
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.ClientSize = new System.Drawing.Size(1034, 628);
			this.Controls.Add(this.StagePanel);
			this.MaximumSize = new System.Drawing.Size(1056, 684);
			this.MinimumSize = new System.Drawing.Size(1056, 684);
			this.Name = "Course";
			this.Text = "Course";
			this.Load += new System.EventHandler(this.Course_Load);
			this.StagePanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox MaterialsRichTextBox;
        private System.Windows.Forms.Panel StagePanel;
        private System.Windows.Forms.ListBox StagesListBox;
        private System.Windows.Forms.Button OpenPopUpFormButton;
        private System.Windows.Forms.Panel panel1;
    }
}