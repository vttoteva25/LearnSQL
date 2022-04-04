using LearnSQL.Controllers;
using LearnSQL.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LearnSQL
{
	public partial class PopUpForm : Form
	{
		List<Exercise> Exercises;

		public PopUpForm(List<Exercise> exercises)
		{
			InitializeComponent();
			Exercises = exercises;
			problemBox.Text = Exercises[0].Problem;
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CheckButton_Click(object sender, EventArgs e)
		{
			if (!Exercises[0].Solution.Contains("SELECT"))
			{
				if (ExerciseControler.ValidateNonSelectQuery(Exercises[0].Solution.Replace("^", "'"), solutionBox.Text))
				{
					if (Exercises.Count() != 1)
					{
						Exercises.RemoveAt(0);
						problemBox.Text = Exercises[0].Problem;
					}
					else
					{
						MessageBox.Show("Поздравления, успешно минахте на следващия урок", "Браво!");
						UserController.NextStage();
						Course.UnlockButton(Course.buttons[Course.buttonIndex], Course.buttonIndex);
						Course.buttons[Course.buttonIndex].ForeColor = Color.MediumSeaGreen;
						Course.buttonIndex++;
						this.Close();
					}
				}
			}
			else
			{
				if (ExerciseControler.ValidateSelectQuery(Exercises[0].Solution.Replace("^", "'"), solutionBox.Text))
				{
					if (Exercises.Count() != 1)
					{
						Exercises.RemoveAt(0);
						problemBox.Text = Exercises[0].Problem;
					}
					else
					{
						if(UserController.LoggedUser.StageId != 8)
						{
							MessageBox.Show("Поздравления, успешно минахте на следващия урок", "Браво!");
							UserController.NextStage();
							Course.UnlockButton(Course.buttons[Course.buttonIndex], Course.buttonIndex);
							Course.buttons[Course.buttonIndex].ForeColor = Color.MediumSeaGreen;
							Course.buttonIndex++;
							this.Close();
						}
						else
						{
							MessageBox.Show("Поздравления, успешно минахте всички упражнения", "Браво!");
							this.Close();
						}
					}
				}
			}
			
		}
	}
}
