namespace LearnSQL.Models
{
	public class Stage
    {
        public Stage(object Id, object Name)
        {
            this.Id = (int)Id;
            this.Name = (string)Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
