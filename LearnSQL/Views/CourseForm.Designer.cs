
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Course));
			this.MaterialsRichTextBox = new System.Windows.Forms.RichTextBox();
			this.StagePanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.JoinsSelect = new System.Windows.Forms.Button();
			this.CriteriaSelectButton = new System.Windows.Forms.Button();
			this.SimpleSelectButton = new System.Windows.Forms.Button();
			this.InsertInfoButton = new System.Windows.Forms.Button();
			this.TableRelationsButton = new System.Windows.Forms.Button();
			this.CreateTablesButton = new System.Windows.Forms.Button();
			this.DatatypesButton = new System.Windows.Forms.Button();
			this.IntroductionButton = new System.Windows.Forms.Button();
			ExButton = new System.Windows.Forms.Button();
			this.StagePanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// MaterialsRichTextBox
			// 
			this.MaterialsRichTextBox.BackColor = System.Drawing.Color.Ivory;
			this.MaterialsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MaterialsRichTextBox.Location = new System.Drawing.Point(338, 21);
			this.MaterialsRichTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaterialsRichTextBox.Name = "MaterialsRichTextBox";
			this.MaterialsRichTextBox.ReadOnly = true;
			this.MaterialsRichTextBox.Size = new System.Drawing.Size(672, 512);
			this.MaterialsRichTextBox.TabIndex = 0;
			this.MaterialsRichTextBox.Text = "";
			// 
			// StagePanel
			// 
			this.StagePanel.Controls.Add(this.panel1);
			this.StagePanel.Controls.Add(ExButton);
			this.StagePanel.Controls.Add(this.MaterialsRichTextBox);
			this.StagePanel.Location = new System.Drawing.Point(-2, -1);
			this.StagePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.StagePanel.Name = "StagePanel";
			this.StagePanel.Size = new System.Drawing.Size(1035, 629);
			this.StagePanel.TabIndex = 6;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightGreen;
			this.panel1.Controls.Add(this.JoinsSelect);
			this.panel1.Controls.Add(this.CriteriaSelectButton);
			this.panel1.Controls.Add(this.SimpleSelectButton);
			this.panel1.Controls.Add(this.InsertInfoButton);
			this.panel1.Controls.Add(this.TableRelationsButton);
			this.panel1.Controls.Add(this.CreateTablesButton);
			this.panel1.Controls.Add(this.DatatypesButton);
			this.panel1.Controls.Add(this.IntroductionButton);
			this.panel1.Location = new System.Drawing.Point(32, 21);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(288, 561);
			this.panel1.TabIndex = 6;
			// 
			// JoinsSelect
			// 
			this.JoinsSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.JoinsSelect.Enabled = false;
			this.JoinsSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.JoinsSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.JoinsSelect.ForeColor = System.Drawing.Color.White;
			this.JoinsSelect.Image = ((System.Drawing.Image)(resources.GetObject("JoinsSelect.Image")));
			this.JoinsSelect.Location = new System.Drawing.Point(0, 488);
			this.JoinsSelect.Name = "JoinsSelect";
			this.JoinsSelect.Size = new System.Drawing.Size(289, 72);
			this.JoinsSelect.TabIndex = 7;
			this.JoinsSelect.UseVisualStyleBackColor = true;
			this.JoinsSelect.Click += new System.EventHandler(this.JoinsSelect_Click);
			// 
			// CriteriaSelectButton
			// 
			this.CriteriaSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.CriteriaSelectButton.Enabled = false;
			this.CriteriaSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CriteriaSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CriteriaSelectButton.ForeColor = System.Drawing.Color.White;
			this.CriteriaSelectButton.Image = ((System.Drawing.Image)(resources.GetObject("CriteriaSelectButton.Image")));
			this.CriteriaSelectButton.Location = new System.Drawing.Point(0, 417);
			this.CriteriaSelectButton.Name = "CriteriaSelectButton";
			this.CriteriaSelectButton.Size = new System.Drawing.Size(289, 72);
			this.CriteriaSelectButton.TabIndex = 6;
			this.CriteriaSelectButton.UseVisualStyleBackColor = true;
			this.CriteriaSelectButton.Click += new System.EventHandler(this.CriteriaSelectButton_Click);
			// 
			// SimpleSelectButton
			// 
			this.SimpleSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.SimpleSelectButton.Enabled = false;
			this.SimpleSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SimpleSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SimpleSelectButton.ForeColor = System.Drawing.Color.White;
			this.SimpleSelectButton.Image = ((System.Drawing.Image)(resources.GetObject("SimpleSelectButton.Image")));
			this.SimpleSelectButton.Location = new System.Drawing.Point(-1, 346);
			this.SimpleSelectButton.Name = "SimpleSelectButton";
			this.SimpleSelectButton.Size = new System.Drawing.Size(289, 72);
			this.SimpleSelectButton.TabIndex = 5;
			this.SimpleSelectButton.UseVisualStyleBackColor = true;
			this.SimpleSelectButton.Click += new System.EventHandler(this.SimpleSelectButton_Click);
			// 
			// InsertInfoButton
			// 
			this.InsertInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.InsertInfoButton.Enabled = false;
			this.InsertInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.InsertInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.InsertInfoButton.ForeColor = System.Drawing.Color.White;
			this.InsertInfoButton.Image = ((System.Drawing.Image)(resources.GetObject("InsertInfoButton.Image")));
			this.InsertInfoButton.Location = new System.Drawing.Point(-1, 276);
			this.InsertInfoButton.Name = "InsertInfoButton";
			this.InsertInfoButton.Size = new System.Drawing.Size(289, 72);
			this.InsertInfoButton.TabIndex = 4;
			this.InsertInfoButton.UseVisualStyleBackColor = true;
			this.InsertInfoButton.Click += new System.EventHandler(this.InsertInfoButton_Click);
			// 
			// TableRelationsButton
			// 
			this.TableRelationsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.TableRelationsButton.Enabled = false;
			this.TableRelationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TableRelationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TableRelationsButton.ForeColor = System.Drawing.Color.White;
			this.TableRelationsButton.Image = ((System.Drawing.Image)(resources.GetObject("TableRelationsButton.Image")));
			this.TableRelationsButton.Location = new System.Drawing.Point(0, 207);
			this.TableRelationsButton.Name = "TableRelationsButton";
			this.TableRelationsButton.Size = new System.Drawing.Size(289, 72);
			this.TableRelationsButton.TabIndex = 3;
			this.TableRelationsButton.UseVisualStyleBackColor = true;
			this.TableRelationsButton.Click += new System.EventHandler(this.TableRelationsButton_Click);
			// 
			// CreateTablesButton
			// 
			this.CreateTablesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.CreateTablesButton.Enabled = false;
			this.CreateTablesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CreateTablesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CreateTablesButton.ForeColor = System.Drawing.Color.White;
			this.CreateTablesButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateTablesButton.Image")));
			this.CreateTablesButton.Location = new System.Drawing.Point(0, 138);
			this.CreateTablesButton.Name = "CreateTablesButton";
			this.CreateTablesButton.Size = new System.Drawing.Size(289, 72);
			this.CreateTablesButton.TabIndex = 2;
			this.CreateTablesButton.UseVisualStyleBackColor = true;
			this.CreateTablesButton.Click += new System.EventHandler(this.CreateTablesButton_Click);
			// 
			// DatatypesButton
			// 
			this.DatatypesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DatatypesButton.Enabled = false;
			this.DatatypesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DatatypesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DatatypesButton.ForeColor = System.Drawing.Color.White;
			this.DatatypesButton.Image = ((System.Drawing.Image)(resources.GetObject("DatatypesButton.Image")));
			this.DatatypesButton.Location = new System.Drawing.Point(0, 68);
			this.DatatypesButton.Name = "DatatypesButton";
			this.DatatypesButton.Size = new System.Drawing.Size(289, 72);
			this.DatatypesButton.TabIndex = 1;
			this.DatatypesButton.UseVisualStyleBackColor = true;
			this.DatatypesButton.Click += new System.EventHandler(this.DatatypesButton_Click);
			// 
			// IntroductionButton
			// 
			this.IntroductionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.IntroductionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.IntroductionButton.ForeColor = System.Drawing.Color.White;
			this.IntroductionButton.Location = new System.Drawing.Point(0, 0);
			this.IntroductionButton.Name = "IntroductionButton";
			this.IntroductionButton.Size = new System.Drawing.Size(289, 72);
			this.IntroductionButton.TabIndex = 0;
			this.IntroductionButton.Text = "Въведение";
			this.IntroductionButton.UseVisualStyleBackColor = true;
			this.IntroductionButton.Click += new System.EventHandler(this.IntroductionButton_Click);
			// 
			// ExButton
			// 
			ExButton.BackColor = System.Drawing.Color.MediumSeaGreen;
			ExButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			ExButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			ExButton.ForeColor = System.Drawing.Color.White;
			ExButton.Location = new System.Drawing.Point(760, 554);
			ExButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			ExButton.Name = "ExButton";
			ExButton.Size = new System.Drawing.Size(249, 62);
			ExButton.TabIndex = 5;
			ExButton.Text = "Към задачите";
			ExButton.UseVisualStyleBackColor = false;
			ExButton.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// Course
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.ClientSize = new System.Drawing.Size(1059, 696);
			this.Controls.Add(this.StagePanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximumSize = new System.Drawing.Size(1059, 696);
			this.MinimumSize = new System.Drawing.Size(1059, 696);
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
        private static System.Windows.Forms.Button ExButton;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button JoinsSelect;
		private System.Windows.Forms.Button CriteriaSelectButton;
		private System.Windows.Forms.Button SimpleSelectButton;
		private System.Windows.Forms.Button InsertInfoButton;
		private System.Windows.Forms.Button TableRelationsButton;
		private System.Windows.Forms.Button CreateTablesButton;
		private System.Windows.Forms.Button DatatypesButton;
		private System.Windows.Forms.Button IntroductionButton;
	}
}