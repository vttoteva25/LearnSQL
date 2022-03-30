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
        public static void RegisterUser(string username, string password, string FirstName, string SurnName)
        {
            DbContext.Users.Add(new User(username, FirstName, SurnName, password, 1));

        }
        public static void LoginUser(string username,string password)
        {
            if(DbContext.Users.Any(x=>x.UserName==username))
            {
                if (DbContext.Users.Find(x => x.UserName == username).Password == password)
                {
                    LoggedUser = DbContext.Users.Find(x => x.UserName == username);
                }
                else
                { 
                    MessageBox.Show("Incorrect Username or Password", "Error"); 
                }
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password", "Error");
            }
        }
    }
}
