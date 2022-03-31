using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnSQL.Models;
using LearnSQL.Database;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LearnSQL.Controllers
{
    public static class UserController
    {
        public static User LoggedUser { get; set; }
        public static void RegisterUser(string username, string password, string firstName, string surname)
        {
            User registerUser = new User(username, firstName, surname, password, 1);
            DbContext.Users.Add(registerUser);
            LoggedUser = registerUser;
            DbContext.WriteInDatabase($"INSERT INTO Users (Username, Name, Surname, Password, Stage) VALUES ('{username}', '{firstName}', '{surname}', '{password}', 1)");
        }
        public static void LoginUser(string username,string password)
        {
            if(DbContext.Users.Any(x=>x.Username==username))
            {
                if (DbContext.Users.Find(x => x.Username == username).Password == password)
                {
                    LoggedUser = DbContext.Users.Find(x => x.Username == username);
                }
                else
                { 
                    MessageBox.Show("Грешно име или парола!", "Грешка"); 
                }
            }
            else
            {
                MessageBox.Show("Грешно име или парола!", "Грешка");
            }
        }
    }
}
