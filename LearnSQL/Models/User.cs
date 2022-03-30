namespace LearnSQL.Models
{
	public class User
    {
        public User(object username, object firstName, object surname, object password, object stage)
        {
            this.Username = (string)username;
            this.FirstName = (string)firstName;
            this.Surname = (string)surname;
            this.Password = (string)password;
            this.StageId = (int)stage;
        }

        public string Username { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }

        public int StageId { get; set; }
        public Stage Stage { get; set; }

    }
}
