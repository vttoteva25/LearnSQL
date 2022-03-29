using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnSQL
{
    public partial class MainForm : Form
    {
        Course course = new Course();
        private void changePanel(Panel p, Panel p2, Panel p3)
        {
            p.Visible = true;
            p.Location = new Point(0, 0);
            p.Size = new Size(1056, 684);

            p2.Visible = false;
            p3.Visible = false;
        }
        public MainForm()
        {
            InitializeComponent();

            changePanel(MainPanel,LoginPanel,RegisterPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = LoginUsernameTextBox.Text;
            string password = LoginPasswordTextBox.Text;

            course.ShowDialog();
               // this.Close();
        }

        private void OpenRegisterPanelLabel_Click(object sender, EventArgs e)
        {
            changePanel(RegisterPanel, MainPanel, LoginPanel);
        }

        private void LoginPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = RegisterUsernameTextBox.Text;
            string firstName = RegisterFirstNameTextBox.Text;
            string loginName = RegisterLastNameTextBox.Text;
            string password = RegisterPasswordTextBox.Text;
            string confirmPassword = RegisterConfirmPasswordTextBox.Text;

            if(password != confirmPassword)
            {
                MessageBox.Show("Паролите не съвпадат");
                RegisterConfirmPasswordTextBox.Clear();
            }
            else
            {
                // .....

                MessageBox.Show("Регистрацията Ви е успешна!\nМожете да си влезете в профила");
                changePanel(LoginPanel, RegisterPanel, MainPanel);
            }           
        }

        private void OpenLoginPanelLabel_Click(object sender, EventArgs e)
        {
            changePanel(LoginPanel,RegisterPanel, MainPanel);
        }

        private void OpenLoginPanelButton_Click(object sender, EventArgs e)
        {
            changePanel(LoginPanel, RegisterPanel, MainPanel);
        }

        private void OpenRegisterPanelButton_Click(object sender, EventArgs e)
        {
            changePanel(RegisterPanel, MainPanel, LoginPanel);
        }

        private void RegisterPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
