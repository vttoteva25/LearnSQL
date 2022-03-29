﻿
namespace LearnSQL
{
    partial class MainForm
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
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.OpenRegisterPanelLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.OpenLoginPanelLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.OpenLoginPanelButton = new System.Windows.Forms.Button();
            this.OpenRegisterPanelButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.RegisterPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackgroundImage = global::LearnSQL.Properties.Resources.learnSQL_Background;
            this.LoginPanel.Controls.Add(this.panel1);
            this.LoginPanel.Location = new System.Drawing.Point(5, 100);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(153, 74);
            this.LoginPanel.TabIndex = 1;
            this.LoginPanel.Visible = false;
            this.LoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPannel_Paint);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.Info;
            this.LoginButton.Location = new System.Drawing.Point(140, 316);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(146, 61);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Вход";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // OpenRegisterPanelLabel
            // 
            this.OpenRegisterPanelLabel.AutoSize = true;
            this.OpenRegisterPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenRegisterPanelLabel.Location = new System.Drawing.Point(312, 425);
            this.OpenRegisterPanelLabel.Name = "OpenRegisterPanelLabel";
            this.OpenRegisterPanelLabel.Size = new System.Drawing.Size(59, 22);
            this.OpenRegisterPanelLabel.TabIndex = 6;
            this.OpenRegisterPanelLabel.Text = "оттук";
            this.OpenRegisterPanelLabel.Click += new System.EventHandler(this.OpenRegisterPanelLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Нямаш акаунт? Регистрирай се ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(46, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Парола";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(40, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Потребителско име";
            // 
            // LoginPasswordTextBox
            // 
            this.LoginPasswordTextBox.Location = new System.Drawing.Point(98, 258);
            this.LoginPasswordTextBox.Name = "LoginPasswordTextBox";
            this.LoginPasswordTextBox.Size = new System.Drawing.Size(223, 28);
            this.LoginPasswordTextBox.TabIndex = 2;
            // 
            // LoginUsernameTextBox
            // 
            this.LoginUsernameTextBox.Location = new System.Drawing.Point(98, 160);
            this.LoginUsernameTextBox.Name = "LoginUsernameTextBox";
            this.LoginUsernameTextBox.Size = new System.Drawing.Size(223, 28);
            this.LoginUsernameTextBox.TabIndex = 1;
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.BackgroundImage = global::LearnSQL.Properties.Resources.learnSQL_Background1;
            this.RegisterPanel.Controls.Add(this.panel2);
            this.RegisterPanel.Location = new System.Drawing.Point(0, 0);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(1019, 650);
            this.RegisterPanel.TabIndex = 2;
            this.RegisterPanel.Visible = false;
            this.RegisterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RegisterPanel_Paint);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.ForeColor = System.Drawing.Color.Ivory;
            this.RegisterButton.Location = new System.Drawing.Point(123, 508);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(181, 56);
            this.RegisterButton.TabIndex = 15;
            this.RegisterButton.Text = "Регистрация";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // OpenLoginPanelLabel
            // 
            this.OpenLoginPanelLabel.AutoSize = true;
            this.OpenLoginPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenLoginPanelLabel.Location = new System.Drawing.Point(265, 577);
            this.OpenLoginPanelLabel.Name = "OpenLoginPanelLabel";
            this.OpenLoginPanelLabel.Size = new System.Drawing.Size(59, 22);
            this.OpenLoginPanelLabel.TabIndex = 14;
            this.OpenLoginPanelLabel.Text = "оттук";
            this.OpenLoginPanelLabel.Click += new System.EventHandler(this.OpenLoginPanelLabel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 577);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 22);
            this.label9.TabIndex = 13;
            this.label9.Text = "Имаш регистрация. Влез ";
            // 
            // RegisterConfirmPasswordTextBox
            // 
            this.RegisterConfirmPasswordTextBox.Location = new System.Drawing.Point(95, 458);
            this.RegisterConfirmPasswordTextBox.Name = "RegisterConfirmPasswordTextBox";
            this.RegisterConfirmPasswordTextBox.Size = new System.Drawing.Size(229, 28);
            this.RegisterConfirmPasswordTextBox.TabIndex = 12;
            // 
            // RegisterPasswordTextBox
            // 
            this.RegisterPasswordTextBox.Location = new System.Drawing.Point(95, 378);
            this.RegisterPasswordTextBox.Name = "RegisterPasswordTextBox";
            this.RegisterPasswordTextBox.Size = new System.Drawing.Size(229, 28);
            this.RegisterPasswordTextBox.TabIndex = 11;
            // 
            // RegisterLastNameTextBox
            // 
            this.RegisterLastNameTextBox.Location = new System.Drawing.Point(95, 298);
            this.RegisterLastNameTextBox.Name = "RegisterLastNameTextBox";
            this.RegisterLastNameTextBox.Size = new System.Drawing.Size(229, 28);
            this.RegisterLastNameTextBox.TabIndex = 10;
            // 
            // RegisterFirstNameTextBox
            // 
            this.RegisterFirstNameTextBox.Location = new System.Drawing.Point(95, 218);
            this.RegisterFirstNameTextBox.Name = "RegisterFirstNameTextBox";
            this.RegisterFirstNameTextBox.Size = new System.Drawing.Size(229, 28);
            this.RegisterFirstNameTextBox.TabIndex = 9;
            // 
            // RegisterUsernameTextBox
            // 
            this.RegisterUsernameTextBox.Location = new System.Drawing.Point(95, 138);
            this.RegisterUsernameTextBox.Name = "RegisterUsernameTextBox";
            this.RegisterUsernameTextBox.Size = new System.Drawing.Size(229, 28);
            this.RegisterUsernameTextBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label8.Location = new System.Drawing.Point(54, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Потвърди парола";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label7.Location = new System.Drawing.Point(54, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Парола";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Location = new System.Drawing.Point(54, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Location = new System.Drawing.Point(54, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Име";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Location = new System.Drawing.Point(54, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Потребителско име";
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = global::LearnSQL.Properties.Resources.learnSQL_Background1;
            this.MainPanel.Controls.Add(this.OpenLoginPanelButton);
            this.MainPanel.Controls.Add(this.OpenRegisterPanelButton);
            this.MainPanel.Location = new System.Drawing.Point(5, 12);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(153, 64);
            this.MainPanel.TabIndex = 0;
            // 
            // OpenLoginPanelButton
            // 
            this.OpenLoginPanelButton.Location = new System.Drawing.Point(695, 333);
            this.OpenLoginPanelButton.Name = "OpenLoginPanelButton";
            this.OpenLoginPanelButton.Size = new System.Drawing.Size(166, 59);
            this.OpenLoginPanelButton.TabIndex = 2;
            this.OpenLoginPanelButton.Text = "Вход";
            this.OpenLoginPanelButton.UseVisualStyleBackColor = true;
            this.OpenLoginPanelButton.Click += new System.EventHandler(this.OpenLoginPanelButton_Click);
            // 
            // OpenRegisterPanelButton
            // 
            this.OpenRegisterPanelButton.Location = new System.Drawing.Point(695, 433);
            this.OpenRegisterPanelButton.Name = "OpenRegisterPanelButton";
            this.OpenRegisterPanelButton.Size = new System.Drawing.Size(166, 59);
            this.OpenRegisterPanelButton.TabIndex = 1;
            this.OpenRegisterPanelButton.Text = "Регистрация";
            this.OpenRegisterPanelButton.UseVisualStyleBackColor = true;
            this.OpenRegisterPanelButton.Click += new System.EventHandler(this.OpenRegisterPanelButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Controls.Add(this.OpenRegisterPanelLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LoginPasswordTextBox);
            this.panel1.Controls.Add(this.LoginUsernameTextBox);
            this.panel1.Location = new System.Drawing.Point(537, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 495);
            this.panel1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(154, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 37);
            this.label10.TabIndex = 8;
            this.label10.Text = "Вход";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.RegisterButton);
            this.panel2.Controls.Add(this.label9);
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
            this.panel2.Location = new System.Drawing.Point(545, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 624);
            this.panel2.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(110, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 32);
            this.label11.TabIndex = 16;
            this.label11.Text = "Регистрация";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 628);
            this.Controls.Add(this.RegisterPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.LoginPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1056, 684);
            this.MinimumSize = new System.Drawing.Size(1056, 684);
            this.Name = "MainForm";
            this.Text = "LearnSQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginPanel.ResumeLayout(false);
            this.RegisterPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button OpenRegisterPanelButton;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label OpenRegisterPanelLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginPasswordTextBox;
        private System.Windows.Forms.TextBox LoginUsernameTextBox;
        private System.Windows.Forms.Panel RegisterPanel;
        private System.Windows.Forms.Label OpenLoginPanelLabel;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button OpenLoginPanelButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
    }
}

