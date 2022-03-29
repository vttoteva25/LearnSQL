using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSQL.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public int StageId { get; set; }
        public Stage Stage { get; set; }
        public User(object username, object name, object surname, object password, object stage)
        {
            this.UserName =(string) username;
            this.Name = (string)name;
            this.Surname = (string)surname;
            this.Password = (string)password;
            this.StageId = (int)stage;
        }

    }
}
