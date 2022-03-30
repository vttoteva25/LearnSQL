namespace LearnSQL.Models
{
	public class Exercise
	{
		public Exercise(object id, object problem, object solution)
		{
			this.Id = (int)id;
			this.Problem = (string)problem;
			this.Solution = (string)solution;
		}

		public int Id { get; set; }
		public string Problem { get; set; }
		public string Solution { get; set; }
	}
}
