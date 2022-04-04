using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using LearnSQL.Models;
using LearnSQL.Database;
using System.IO;

namespace LearnSQL.Controllers
{
    public static class ExerciseControler
    {
        private static SqlConnection connection;
        private static string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=LearnSQLExercises;Integrated Security=True";
        public static bool ValidateNonSelectQuery(string expected, string query)
        {
            expected = expected.ToLower();
            query = query.ToLower();
            List<string> queryItems = query.Replace("\n", " ").Replace('(', ' ').Replace(')', ' ').Replace(",", " ").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> expectedItems = expected.Replace("\n", " ").Replace('(', ' ').Replace(')', ' ').Replace(",", " ").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (queryItems.All(expectedItems.Contains))
            {
                MessageBox.Show("Вашата заявка беше изпълнена успешно!", "Поздравления!");
                connection = new SqlConnection(connectionString);
                using (connection)
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            else
            {
                MessageBox.Show(string.Join(" ", expectedItems) + "/////" +string.Join(" ", queryItems), "Грешка!");
            }
            return false;
        }
        public static bool ValidateSelectQuery(string expected, string query)
        {
            expected = expected.ToLower();
            query = query.ToLower();
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
                            for(int i=0;i<reader.FieldCount;i++)
                            {
                                QueryOutput.Add(reader[i].ToString());
                            }
                            
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
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                ExpectedOutput.Add(reader[i].ToString());
                            }
                        }
                    }
                }
                for(int i=0;i<ExpectedOutput.Count;i++)
                {
                    if (ExpectedOutput[i] != QueryOutput[i]) 
                    { 
                        MessageBox.Show("Грешка при синтаксиса на заявката! Заявката връща грешен резултат!", "Грешка!" + (ExpectedOutput.Count.ToString() + QueryOutput.Count.ToString()));
                        return false;
                    }
                }
                MessageBox.Show("Вашата заявка бе успешно изпълнена!", "Поздравления!");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Грешка при синтаксиса на заявката! Заявката не може да се изпълни!", "Грешка!");
                return false;
            }
        }
        public static void CreateExercisesDatabase()
        {
            DeleteDatabase();

            string createQuery = "CREATE DATABASE LearnSQLExercises";
            connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Database=master;Integrated Security=True");

            using (connection)
            {
                try
                {
                    SqlCommand command = new SqlCommand(createQuery, connection);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                }
                catch (Exception)
                {

                }
            }
        }

        private static void DeleteDatabase()
		{

            string deleteQuery = "ALTER DATABASE LearnSQLExercises SET SINGLE_USER WITH ROLLBACK IMMEDIATE DROP DATABASE LearnSQLExercises;";
            connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Database=master;Integrated Security=True");

            using (connection)
            {
                try
                {
                    SqlCommand command = new SqlCommand(deleteQuery, connection);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    
                }
            }
        }

        public static void RecreateDatabase(int stage)
        {
            CreateExercisesDatabase();

            List<MaterialExercise> helper = DbContext.MaterialsExercises.FindAll(y => y.Material.StageId < stage).ToList();
            List<Exercise> exercises = DbContext.Exercises.Where(x => helper.Select(y => y.ExerciseId).Contains(x.Id)).ToList();
            List<Exercise> filtered = exercises.Where(x => x.Solution.Contains("INSERT") || x.Solution.Contains("CREATE") || x.Solution.Contains("ALTER")).ToList();

            foreach (Exercise exercise in filtered)
            {
				if (exercise.Solution.Contains("INSERT"))
				{
                    List<string> path = Environment.CurrentDirectory.Split('\\').ToList();
                    path.RemoveRange(path.Count - 2, 2);
                    path.AddRange(new List<string>() { "Database", "FillMountainsAndCountriesDb.sql" });
                    string query = File.ReadAllText(string.Join("\\", path));
                    query = query.ToLower();

                    connection = new SqlConnection(connectionString);

                    using (connection)
                    {
                        SqlCommand command = new SqlCommand(query, connection);

                        connection.Open();
                        int result = command.ExecuteNonQuery();
                    }
                }
				else
				{
                    connection = new SqlConnection(connectionString);

                    using (connection)
                    {
                        SqlCommand command = new SqlCommand((exercise.Solution).ToLower(), connection);

                        connection.Open();
                        int result = command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
