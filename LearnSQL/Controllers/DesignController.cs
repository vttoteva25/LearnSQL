using LearnSQL.Views;
using System.Windows.Forms;

namespace LearnSQL.Controllers
{
	public static class DesignController
	{
		static MainForm mainForm;
		static Course courseForm;
		static IntroForm introForm;
		static PopUpForm excersiseForm;

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

		public static void OpenPopUp(Form form)
		{
			form.Show();
		}
	}
}
