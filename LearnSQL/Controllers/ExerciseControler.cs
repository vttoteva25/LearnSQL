using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LearnSQL.Controllers
{
    public static class ExerciseControler
    {
        private static SqlConnection connection;
        private static string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=ExerciseSQL;Integrated Security=True";
        public static void ValidateNonSelectQuery(string expected, string query)
        {
            if (query.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries) == expected.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
            {
                MessageBox.Show("Вашата заявка беше изпълнена успешно!", "Поздравления!");
                connection = new SqlConnection(connectionString);
                using (connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Имате грешка в синтаксиса на заявката!", "Грешка!");
            }
        }
        public static void ValidateSelectQuery(string expected, string query)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                List<string> QueryOutput = new List<string>();
                using (connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            QueryOutput.AddRange(new string[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() });
                        }
                    }
                }
                connection = new SqlConnection(connectionString);
                List<string> ExpectedOutput = new List<string>();
                using (connection)
                {
                    SqlCommand command = new SqlCommand(expected, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    using (reader)
                    {
                        while (reader.Read())
                        {
                            ExpectedOutput.AddRange(new string[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString() });
                        }
                    }
                }
                if (ExpectedOutput == QueryOutput)
                {
                    MessageBox.Show("Вашата заявка бе успешно изпълнена!", "Поздравления!");
                }
                else
                {
                    MessageBox.Show("Грешка при синтаксиса на заявката! Заявката връща грешен резултат!", "Грешка!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Грешка при синтаксиса на заявката! Заявката не може да се изпълни!", "Грешка!");
            }
        }
    }

}
