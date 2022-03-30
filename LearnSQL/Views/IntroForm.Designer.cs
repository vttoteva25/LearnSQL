
namespace LearnSQL.Views
{
	partial class IntroForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroForm));
			this.LoginPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.LoginButton = new System.Windows.Forms.Button();
			this.OpenRegisterPanelLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.LoginPasswordTextBox = new System.Windows.Forms.TextBox();
			this.LoginUsernameTextBox = new System.Windows.Forms.TextBox();
			this.RegisterPanel = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.RegisterButton = new System.Windows.Forms.Button();
			this.OpenLoginPanelLabel = new System.Windows.Forms.Label();
			this.RegisterConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
			this.RegisterPasswordTextBox = new System.Windows.Forms.TextBox();
			this.RegisterLastNameTextBox = new System.Windows.Forms.TextBox();
			this.RegisterFirstNameTextBox = new System.Windows.Forms.TextBox();
			this.RegisterUsernameTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.MainPanel = new System.Windows.Forms.Panel();
			this.label13 = new System.Windows.Forms.Label();
			this.OpenLoginPanelButton = new System.Windows.Forms.Button();
			this.OpenRegisterPanelButton = new System.Windows.Forms.Button();
			this.LoginPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.RegisterPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.MainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// LoginPanel
			// 
			this.LoginPanel.BackgroundImage = global::LearnSQL.Properties.Resources.Background;
			this.LoginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.LoginPanel.Controls.Add(this.panel1);
			this.LoginPanel.Location = new System.Drawing.Point(151, 35);
			this.LoginPanel.Name = "LoginPanel";
			this.LoginPanel.Size = new System.Drawing.Size(889, 580);
			this.LoginPanel.TabIndex = 5;
			this.LoginPanel.Visible = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Ivory;
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.LoginButton);
			this.panel1.Controls.Add(this.OpenRegisterPanelLabel);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.LoginPasswordTextBox);
			this.panel1.Controls.Add(this.LoginUsernameTextBox);
			this.panel1.Location = new System.Drawing.Point(646, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(399, 495);
			this.panel1.TabIndex = 8;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(164, 51);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(92, 37);
			this.label10.TabIndex = 8;
			this.label10.Text = "Вход";
			// 
			// LoginButton
			// 
			this.LoginButton.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LoginButton.ForeColor = System.Drawing.SystemColors.Info;
			this.LoginButton.Location = new System.Drawing.Point(132, 331);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(147, 62);
			this.LoginButton.TabIndex = 7;
			this.LoginButton.Text = "Вход";
			this.LoginButton.UseVisualStyleBackColor = false;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// OpenRegisterPanelLabel
			// 
			this.OpenRegisterPanelLabel.AutoSize = true;
			this.OpenRegisterPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OpenRegisterPanelLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.OpenRegisterPanelLabel.Location = new System.Drawing.Point(290, 425);
			this.OpenRegisterPanelLabel.Name = "OpenRegisterPanelLabel";
			this.OpenRegisterPanelLabel.Size = new System.Drawing.Size(51, 20);
			this.OpenRegisterPanelLabel.TabIndex = 6;
			this.OpenRegisterPanelLabel.Text = "оттук";
			this.OpenRegisterPanelLabel.Click += new System.EventHandler(this.OpenRegisterPanelLabel_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.label2.Location = new System.Drawing.Point(84, 226);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Парола";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(44, 425);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(253, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Нямаш акаунт? Регистрирай се ";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.label12.Location = new System.Drawing.Point(80, 137);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(161, 20);
			this.label12.TabIndex = 3;
			this.label12.Text = "Потребителско име";
			// 
			// LoginPasswordTextBox
			// 
			this.LoginPasswordTextBox.Location = new System.Drawing.Point(87, 257);
			this.LoginPasswordTextBox.Name = "LoginPasswordTextBox";
			this.LoginPasswordTextBox.PasswordChar = '*';
			this.LoginPasswordTextBox.Size = new System.Drawing.Size(247, 26);
			this.LoginPasswordTextBox.TabIndex = 2;
			// 
			// LoginUsernameTextBox
			// 
			this.LoginUsernameTextBox.Location = new System.Drawing.Point(87, 160);
			this.LoginUsernameTextBox.Name = "LoginUsernameTextBox";
			this.LoginUsernameTextBox.Size = new System.Drawing.Size(247, 26);
			this.LoginUsernameTextBox.TabIndex = 1;
			// 
			// RegisterPanel
			// 
			this.RegisterPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegisterPanel.BackgroundImage")));
			this.RegisterPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.RegisterPanel.Controls.Add(this.panel2);
			this.RegisterPanel.Controls.Add(this.label9);
			this.RegisterPanel.Location = new System.Drawing.Point(12, 12);
			this.RegisterPanel.Name = "RegisterPanel";
			this.RegisterPanel.Size = new System.Drawing.Size(106, 129);
			this.RegisterPanel.TabIndex = 4;
			this.RegisterPanel.Visible = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Ivory;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.RegisterButton);
			this.panel2.Controls.Add(this.OpenLoginPanelLabel);
			this.panel2.Controls.Add(this.RegisterConfirmPasswordTextBox);
			this.panel2.Controls.Add(this.RegisterPasswordTextBox);
			this.panel2.Controls.Add(this.RegisterLastNameTextBox);
			this.panel2.Controls.Add(this.RegisterFirstNameTextBox);
			this.panel2.Controls.Add(this.RegisterUsernameTextBox);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Location = new System.Drawing.Point(634, 11);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(428, 608);
			this.panel2.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(92, 572);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(199, 20);
			this.label1.TabIndex = 17;
			this.label1.Text = "Имаш регистрация. Влез\r\n";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(111, 46);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(194, 32);
			this.label11.TabIndex = 16;
			this.label11.Text = "Регистрация";
			// 
			// RegisterButton
			// 
			this.RegisterButton.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.RegisterButton.ForeColor = System.Drawing.Color.Ivory;
			this.RegisterButton.Location = new System.Drawing.Point(117, 500);
			this.RegisterButton.Name = "RegisterButton";
			this.RegisterButton.Size = new System.Drawing.Size(182, 57);
			this.RegisterButton.TabIndex = 15;
			this.RegisterButton.Text = "Регистрация";
			this.RegisterButton.UseVisualStyleBackColor = false;
			this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// OpenLoginPanelLabel
			// 
			this.OpenLoginPanelLabel.AutoSize = true;
			this.OpenLoginPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OpenLoginPanelLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.OpenLoginPanelLabel.Location = new System.Drawing.Point(291, 572);
			this.OpenLoginPanelLabel.Name = "OpenLoginPanelLabel";
			this.OpenLoginPanelLabel.Size = new System.Drawing.Size(51, 20);
			this.OpenLoginPanelLabel.TabIndex = 14;
			this.OpenLoginPanelLabel.Text = "оттук";
			this.OpenLoginPanelLabel.Click += new System.EventHandler(this.OpenLoginPanelLabel_Click);
			// 
			// RegisterConfirmPasswordTextBox
			// 
			this.RegisterConfirmPasswordTextBox.Location = new System.Drawing.Point(84, 443);
			this.RegisterConfirmPasswordTextBox.Name = "RegisterConfirmPasswordTextBox";
			this.RegisterConfirmPasswordTextBox.PasswordChar = '*';
			this.RegisterConfirmPasswordTextBox.Size = new System.Drawing.Size(260, 26);
			this.RegisterConfirmPasswordTextBox.TabIndex = 12;
			// 
			// RegisterPasswordTextBox
			// 
			this.RegisterPasswordTextBox.Location = new System.Drawing.Point(84, 363);
			this.RegisterPasswordTextBox.Name = "RegisterPasswordTextBox";
			this.RegisterPasswordTextBox.PasswordChar = '*';
			this.RegisterPasswordTextBox.Size = new System.Drawing.Size(260, 26);
			this.RegisterPasswordTextBox.TabIndex = 11;
			// 
			// RegisterLastNameTextBox
			// 
			this.RegisterLastNameTextBox.Location = new System.Drawing.Point(84, 283);
			this.RegisterLastNameTextBox.Name = "RegisterLastNameTextBox";
			this.RegisterLastNameTextBox.Size = new System.Drawing.Size(260, 26);
			this.RegisterLastNameTextBox.TabIndex = 10;
			// 
			// RegisterFirstNameTextBox
			// 
			this.RegisterFirstNameTextBox.Location = new System.Drawing.Point(84, 203);
			this.RegisterFirstNameTextBox.Name = "RegisterFirstNameTextBox";
			this.RegisterFirstNameTextBox.Size = new System.Drawing.Size(260, 26);
			this.RegisterFirstNameTextBox.TabIndex = 9;
			// 
			// RegisterUsernameTextBox
			// 
			this.RegisterUsernameTextBox.Location = new System.Drawing.Point(84, 123);
			this.RegisterUsernameTextBox.Name = "RegisterUsernameTextBox";
			this.RegisterUsernameTextBox.Size = new System.Drawing.Size(260, 26);
			this.RegisterUsernameTextBox.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.label8.Location = new System.Drawing.Point(78, 415);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(147, 20);
			this.label8.TabIndex = 7;
			this.label8.Text = "Потвърди парола";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.label7.Location = new System.Drawing.Point(78, 338);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 20);
			this.label7.TabIndex = 6;
			this.label7.Text = "Парола";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.label6.Location = new System.Drawing.Point(78, 260);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "Фамилия";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.label5.Location = new System.Drawing.Point(78, 180);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Име";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.label4.Location = new System.Drawing.Point(78, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(161, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Потребителско име";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(632, 577);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(199, 20);
			this.label9.TabIndex = 13;
			this.label9.Text = "Имаш регистрация. Влез\r\n";
			// 
			// MainPanel
			// 
			this.MainPanel.BackgroundImage = global::LearnSQL.Properties.Resources.Background;
			this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.MainPanel.Controls.Add(this.label13);
			this.MainPanel.Controls.Add(this.OpenLoginPanelButton);
			this.MainPanel.Controls.Add(this.OpenRegisterPanelButton);
			this.MainPanel.Location = new System.Drawing.Point(16, 203);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(117, 111);
			this.MainPanel.TabIndex = 3;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label13.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.label13.Location = new System.Drawing.Point(578, 274);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(404, 37);
			this.label13.TabIndex = 3;
			this.label13.Text = "Добре дошли в LearnSQL";
			// 
			// OpenLoginPanelButton
			// 
			this.OpenLoginPanelButton.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.OpenLoginPanelButton.FlatAppearance.BorderSize = 2;
			this.OpenLoginPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OpenLoginPanelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OpenLoginPanelButton.ForeColor = System.Drawing.Color.White;
			this.OpenLoginPanelButton.Location = new System.Drawing.Point(588, 383);
			this.OpenLoginPanelButton.Name = "OpenLoginPanelButton";
			this.OpenLoginPanelButton.Size = new System.Drawing.Size(189, 80);
			this.OpenLoginPanelButton.TabIndex = 2;
			this.OpenLoginPanelButton.Text = "Вход";
			this.OpenLoginPanelButton.UseVisualStyleBackColor = false;
			this.OpenLoginPanelButton.Click += new System.EventHandler(this.OpenLoginPanelButton_Click);
			// 
			// OpenRegisterPanelButton
			// 
			this.OpenRegisterPanelButton.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.OpenRegisterPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OpenRegisterPanelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.OpenRegisterPanelButton.ForeColor = System.Drawing.Color.White;
			this.OpenRegisterPanelButton.Location = new System.Drawing.Point(825, 385);
			this.OpenRegisterPanelButton.Name = "OpenRegisterPanelButton";
			this.OpenRegisterPanelButton.Size = new System.Drawing.Size(189, 78);
			this.OpenRegisterPanelButton.TabIndex = 1;
			this.OpenRegisterPanelButton.Text = "Регистрация";
			this.OpenRegisterPanelButton.UseVisualStyleBackColor = false;
			this.OpenRegisterPanelButton.Click += new System.EventHandler(this.OpenRegisterPanelLabel_Click);
			// 
			// IntroForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1131, 689);
			this.Controls.Add(this.LoginPanel);
			this.Controls.Add(this.RegisterPanel);
			this.Controls.Add(this.MainPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(1131, 689);
			this.MinimumSize = new System.Drawing.Size(1131, 689);
			this.Name = "IntroForm";
			this.Text = "LoginForm";
			this.LoginPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.RegisterPanel.ResumeLayout(false);
			this.RegisterPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.MainPanel.ResumeLayout(false);
			this.MainPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel MainPanel;
		private System.Windows.Forms.Button OpenLoginPanelButton;
		private System.Windows.Forms.Button OpenRegisterPanelButton;
		private System.Windows.Forms.Panel RegisterPanel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button RegisterButton;
		private System.Windows.Forms.Label OpenLoginPanelLabel;
		private System.Windows.Forms.TextBox RegisterConfirmPasswordTextBox;
		private System.Windows.Forms.TextBox RegisterPasswordTextBox;
		private System.Windows.Forms.TextBox RegisterLastNameTextBox;
		private System.Windows.Forms.TextBox RegisterFirstNameTextBox;
		private System.Windows.Forms.TextBox RegisterUsernameTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel LoginPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.Label OpenRegisterPanelLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox LoginPasswordTextBox;
		private System.Windows.Forms.TextBox LoginUsernameTextBox;
		private System.Windows.Forms.Label label13;
	}
}