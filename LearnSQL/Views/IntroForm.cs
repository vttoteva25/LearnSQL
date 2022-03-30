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
			UserController.RegisterUser(RegisterUsernameTextBox.Text, RegisterPasswordTextBox.Text, RegisterFirstNameTextBox.Text, RegisterLastNameTextBox.Text);
			DesignController.OpenForm(new Course());
        }
    }
}
