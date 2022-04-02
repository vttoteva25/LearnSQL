using LearnSQL.Database;
using LearnSQL.Views;
using System.Windows.Forms;

namespace LearnSQL.Controllers
{
	public static class DesignController
	{
		static MainForm mainForm;
		static IntroForm introForm;

		public static Form GetMainForm()
		{
			mainForm = new MainForm();
			introForm = new IntroForm();
			mainForm.OpenForm(introForm);
			return mainForm;
		}

		public static void OpenForm(Form form)
		{
			mainForm.OpenForm(form);
		}
	}
}
