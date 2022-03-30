﻿using LearnSQL.Database;
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
		public PopUpForm form = new PopUpForm();
		List<Button> buttons = new List<Button>();

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

			for(int i = 0; i < 8; i++)
			{
				buttons[i].Image = null;
				buttons[i].Text = DbContext.Stages.First(x => x.Id == i + 1).Name;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void previousButton_Click(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			form.Show();
		}

		private void IntroductionButton_Click(object sender, EventArgs e)
		{
			string headline = DbContext.Stages.First(x => x.Id == 1).Name;
			string reformText = DbContext.Materials.First(x => x.StageId == 1).Theroy;

			string reformed = headline + Environment.NewLine + reformText.Replace("№", Environment.NewLine);
			MaterialsRichTextBox.Text = reformed;
		}
	}
}
