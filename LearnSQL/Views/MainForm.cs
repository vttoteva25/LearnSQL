using System.Drawing;
using System.Windows.Forms;

namespace LearnSQL.Views
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			Panel main = new Panel();
			main.Location = new Point(0, 0);

			IntroForm form = new IntroForm();
			form.TopLevel = false;

			this.Height = form.Height;
			this.Width = form.Width;

			main.Height = this.Height;
			main.Width = this.Width;

			main.Controls.Add(form);
			form.Show();

			this.Controls.Add(main);
		}
	}
}
