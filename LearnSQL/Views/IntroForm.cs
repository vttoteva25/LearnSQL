using System;
using System.Drawing;
using System.Windows.Forms;
using LearnSQL.Controllers;

namespace LearnSQL.Views
{
	public partial class IntroForm : Form
	{
		public IntroForm()
		{
			InitializeComponent();
			ResizePanels(MainPanel, LoginPanel, RegisterPanel);
		}

		public void ResizePanels(Panel visiblePanel, Panel hiddenPanel1, Panel hiddenPanel2)
		{
			visiblePanel.BackgroundImageLayout = ImageLayout.Stretch;
			visiblePanel.Location = new Point(0, 0);
			visiblePanel.Visible = true;
			visiblePanel.Width = 750;
			visiblePanel.Height = 450;
			hiddenPanel1.Visible = false;
			hiddenPanel2.Visible = false;
		}

		private void OpenLoginPanelButton_Click(object sender, EventArgs e)
		{
			ResizePanels(LoginPanel, MainPanel, RegisterPanel);
		}

		private void OpenRegisterPanelButton_Click(object sender, EventArgs e)
		{
			ResizePanels(RegisterPanel, MainPanel, LoginPanel);
		}

		private void OpenLoginPanelLabel_Click(object sender, EventArgs e)
		{
			ResizePanels(LoginPanel, MainPanel, RegisterPanel);
		}

		private void OpenRegisterPanelLabel_Click(object sender, EventArgs e)
		{
			ResizePanels(RegisterPanel, MainPanel, LoginPanel);
		}

		private void OpenLoginPanelButton_Click_1(object sender, EventArgs e)
		{

		}

        private void RegisterButton_Click(object sender, EventArgs e)
        {
			if(RegisterConfirmPasswordTextBox.Text==RegisterPasswordTextBox.Text)
            {
				if(RegisterPasswordTextBox.Text.Length<6||RegisterPasswordTextBox.Text.Length >30 )
                {
					MessageBox.Show("Паролата трябва да е между 6 и 30 симовола!","Грешка");
                }
				else
                {
					UserController.RegisterUser(RegisterUsernameTextBox.Text, RegisterPasswordTextBox.Text, RegisterFirstNameTextBox.Text, RegisterLastNameTextBox.Text);
					if(DialogResult.OK==MessageBox.Show("Вие успешно се регистрирахте!","Поздравелния",MessageBoxButtons.OK))
                    {
						DesignController.OpenForm(new Course());
					}
				}
			}
			else
            {
				MessageBox.Show("Полетата за парола не свъпадат!", "Грешка");
			}
			
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
			UserController.LoginUser(LoginUsernameTextBox.Text, LoginPasswordTextBox.Text);
			if(!(UserController.LoggedUser is null))
			{
				DesignController.OpenForm(new Course());
			}
        }
    }
}
