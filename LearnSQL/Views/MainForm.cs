using System.Drawing;
using System.Windows.Forms;
using LearnSQL.Database;

namespace LearnSQL.Views
{
	public partial class MainForm : Form
	{
		Panel main;

		public MainForm()
		{
			InitializeComponent();
			DbContext.FillTheDb();

			main = new Panel();
			main.Location = new Point(0, 0);
		}

		public void OpenForm(Form form)
		{
			main.Controls.Clear();

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
