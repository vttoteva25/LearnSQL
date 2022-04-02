using LearnSQL.Controllers;
using LearnSQL.Database;
using LearnSQL.Models;
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
	public partial class Course : Form
	{
		public static int buttonIndex = 0;
		int lastClickedIndex = 0;

		public static List<Button> buttons = new List<Button>();

		private void changePanel(Panel p, Panel p2)
		{
			p.Visible = true;
			p.Location = new Point(0, 0);
			p.Size = new Size(1056, 684);

			p2.Visible = false;
		}

		public Course()
		{
			InitializeComponent();
			StagePanel.Location = new Point(0, 0);
			StagePanel.Size = new Size(1056, 684);
		}

		private void Course_Load(object sender, EventArgs e)
		{
			buttons.Add(IntroductionButton);
			buttons.Add(DatatypesButton);
			buttons.Add(CreateTablesButton);
			buttons.Add(TableRelationsButton);
			buttons.Add(InsertInfoButton);
			buttons.Add(SimpleSelectButton);
			buttons.Add(CriteriaSelectButton);
			buttons.Add(JoinsSelect);

			for (buttonIndex = 0; buttonIndex < UserController.LoggedUser.StageId; buttonIndex++)
			{
				UnlockButton(buttons[buttonIndex], buttonIndex);
			}

			buttons[buttonIndex - 1].ForeColor = Color.White;
			ExButton.Text = null;
		}

		public static void UnlockButton(Button button, int index)
		{
			button.Image = null;
			button.Text = DbContext.Stages.First(x => x.Id == index + 1).Name;
			button.Enabled = true;

			if (buttonIndex == 0 || buttonIndex == 1)
			{
				ExButton.Text = "Продължи";
			}
			else
			{
				ExButton.Text = "Упражнения";
			}

			buttons[buttonIndex].ForeColor = Color.MediumSeaGreen;
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			if (ExButton.Text == "Продължи" && buttons[buttonIndex].ForeColor != Color.MediumSeaGreen)
			{
				if (buttonIndex < DbContext.Stages.Count())
				{
					UserController.NextStage();
					UnlockButton(buttons[buttonIndex], buttonIndex);
					buttons[buttonIndex].ForeColor = Color.MediumSeaGreen;
					buttonIndex++;
				}
			}
			else
			{
				List<MaterialExercise> exercisesIds = DbContext.MaterialsExercises.Where(x => x.MaterialId == lastClickedIndex).ToList();
				List<Exercise> exercises = DbContext.Exercises.Where(x => exercisesIds.Any(y => y.ExerciseId == x.Id)).ToList();

				PopUpForm pop = new PopUpForm(exercises);
				pop.Show();
			}
		}

		private void IntroductionButton_Click(object sender, EventArgs e)
		{
			DisplayTheory(1);
		}

		private void DatatypesButton_Click(object sender, EventArgs e)
		{
			DisplayTheory(2);
		}

		private void CreateTablesButton_Click(object sender, EventArgs e)
		{
			DisplayTheory(3);
		}

		private void TableRelationsButton_Click(object sender, EventArgs e)
		{
			DisplayTheory(4);
		}

		private void InsertInfoButton_Click(object sender, EventArgs e)
		{
			DisplayTheory(5);
		}

		private void SimpleSelectButton_Click(object sender, EventArgs e)
		{
			DisplayTheory(6);
		}

		private void CriteriaSelectButton_Click(object sender, EventArgs e)
		{
			DisplayTheory(7);
		}

		private void JoinsSelect_Click(object sender, EventArgs e)
		{
			DisplayTheory(8);
		}

		private void DisplayTheory(int stageIndex)
		{
			string headline = DbContext.Stages.First(x => x.Id == stageIndex).Name;
			string reformText = DbContext.Materials.First(x => x.StageId == stageIndex).Theroy;

			string reformed = headline + Environment.NewLine + Environment.NewLine + reformText;
			MaterialsRichTextBox.Text = reformed;

			if (stageIndex > 2)
			{
				ExButton.Text = "Упражнения";
			}
			else
			{
				ExButton.Text = "Продължи";
			}

			lastClickedIndex = stageIndex;
			ExerciseControler.RecreateDatabase(stageIndex);
		}
	}
}
