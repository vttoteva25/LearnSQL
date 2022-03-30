using LearnSQL.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace LearnSQL.Database
{
	static class DbContext
	{
		private static SqlConnection connection;
		private static string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=LearnSQL;Integrated Security=True";

		public static List<User> Users { get; set; }
		public static List<Stage> Stages { get; set; }
		public static List<Material> Materials { get; set; }
		public static List<Exercise> Exercises { get; set; }
		public static List<MaterialExercise> MaterialsExercises { get; set; }

		public static void FillTheDb()
		{
			FillUsers();
			FillStages();
			FillMaterials();
			FillExercises();
			FillMaterialsExercises();
			
		}

		private static void FillUsers()
		{
			Users = new List<User>();

			connection = new SqlConnection(connectionString);
			string query = "SELECT * FROM Users";

			using (connection)
			{
				SqlCommand command = new SqlCommand(query, connection);
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();
				using (reader)
				{
					while (reader.Read())
					{
						Users.Add(new User(reader[0], reader[1], reader[2], reader[3], reader[4]));
					}
				}
			}
		}

		private static void FillStages()
		{
			Stages = new List<Stage>();

			connection = new SqlConnection(connectionString);
			string query = "SELECT * FROM Stages";

			using (connection)
			{
				SqlCommand command = new SqlCommand(query, connection);
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();
				using (reader)
				{
					while (reader.Read())
					{
						Stages.Add(new Stage(reader[0], reader[1]));
					}
				}
			}
		}

		private static void FillMaterials()
		{
			Materials = new List<Material>();

			connection = new SqlConnection(connectionString);
			string query = "SELECT * FROM Materials";

			using (connection)
			{
				SqlCommand command = new SqlCommand(query, connection);
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();
				using (reader)
				{
					while (reader.Read())
					{
						Materials.Add(new Material(reader[0], reader[1], reader[2]));
					}
				}
			}
		}

		private static void FillExercises()
		{
			Exercises = new List<Exercise>();

			connection = new SqlConnection(connectionString);
			string query = "SELECT * FROM Excercises";

			using (connection)
			{
				SqlCommand command = new SqlCommand(query, connection);
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();
				using (reader)
				{
					while (reader.Read())
					{
						Exercises.Add(new Exercise(reader[0], reader[1], reader[2]));
					}
				}
			}
		}

		private static void FillMaterialsExercises()
		{
			MaterialsExercises = new List<MaterialExercise>();

			connection = new SqlConnection(connectionString);
			string query = "SELECT * FROM MaterialsExcercises";

			using (connection)
			{
				SqlCommand command = new SqlCommand(query, connection);
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();
				using (reader)
				{
					while (reader.Read())
					{
						MaterialsExercises.Add(new MaterialExercise(reader[0], reader[1]));
					}
				}
			}
		}

	}
}