
namespace LearnSQL
{
    partial class PopUpForm
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
			this.CheckButton = new System.Windows.Forms.Button();
			this.problemBox = new System.Windows.Forms.RichTextBox();
			this.CancelButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.solutionBox = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CheckButton
			// 
			this.CheckButton.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.CheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CheckButton.ForeColor = System.Drawing.Color.Ivory;
			this.CheckButton.Location = new System.Drawing.Point(526, 459);
			this.CheckButton.Name = "CheckButton";
			this.CheckButton.Size = new System.Drawing.Size(163, 66);
			this.CheckButton.TabIndex = 0;
			this.CheckButton.Text = "Проверка";
			this.CheckButton.UseVisualStyleBackColor = false;
			this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
			// 
			// problemBox
			// 
			this.problemBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.problemBox.Location = new System.Drawing.Point(31, 74);
			this.problemBox.Name = "problemBox";
			this.problemBox.ReadOnly = true;
			this.problemBox.Size = new System.Drawing.Size(416, 345);
			this.problemBox.TabIndex = 1;
			this.problemBox.Text = "";
			// 
			// CancelButton
			// 
			this.CancelButton.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CancelButton.ForeColor = System.Drawing.Color.Ivory;
			this.CancelButton.Location = new System.Drawing.Point(708, 459);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(163, 66);
			this.CancelButton.TabIndex = 2;
			this.CancelButton.Text = "Отказ";
			this.CancelButton.UseVisualStyleBackColor = false;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.label1.Location = new System.Drawing.Point(26, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "Условие";
			// 
			// solutionBox
			// 
			this.solutionBox.Location = new System.Drawing.Point(482, 74);
			this.solutionBox.Name = "solutionBox";
			this.solutionBox.Size = new System.Drawing.Size(416, 345);
			this.solutionBox.TabIndex = 4;
			this.solutionBox.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.label2.Location = new System.Drawing.Point(477, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = "Заявка";
			// 
			// PopUpForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(921, 537);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.solutionBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.problemBox);
			this.Controls.Add(this.CheckButton);
			this.Name = "PopUpForm";
			this.Text = "Задача";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.RichTextBox problemBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox solutionBox;
		private System.Windows.Forms.Label label2;
	}
}