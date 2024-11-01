using System;
using System.Data;
using System.Data.SqlClient;

namespace Library_2
{
	class Library
	{
		const string ConnectionString =
				"Data Source=(localdb)\\MSSQLLocalDB;" +
				"Initial Catalog=Library_PD_311;" +
				"Integrated Security=True;" +
				"Connect Timeout=30;Encrypt=False;" +
				"TrustServerCertificate=False;" +
				"ApplicationIntent=ReadWrite;" +
				"MultiSubnetFailover=False";
		static SqlConnection connection;
		static Library()
		{
			connection = new SqlConnection(ConnectionString);
		}
		public static void InsertBook(string title, string last_name, string first_name)
		{
			int author = GetAuthorID(first_name, last_name);
			string cmd = $"INSERT Books(title,author) VALUES ('{title}',{author})";

			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
		public static int GetAuthorID(string first_name, string last_name)
		{
			string cmd = $"(SELECT author_id FROM Authors WHERE first_name = @first_name AND last_name = @last_name)";
			
			SqlCommand command = new SqlCommand(cmd, connection);
			command.Parameters.AddWithValue("@first_name", first_name);
			command.Parameters.AddWithValue("@last_name", last_name);

			connection.Open();
			int author = Convert.ToInt32(command.ExecuteScalar());
			connection.Close();

			return author;
		}
		public static void InsertAuthor(string first_name, string last_name)
		{
			string sql = $"INSERT Authors(first_name,last_name) VALUES('{first_name}','{last_name}')";
			SqlCommand command = new SqlCommand(sql, connection);
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
		public static void Select(string columns, string table, string condition)
		{

			string cmd = $"SELECT {columns} FROM {table} WHERE {condition}";
			SqlCommand command = new SqlCommand(cmd, connection);
			//command.Parameters.Add("@id",System.Data.SqlDbType.NVarChar).Value=columns;
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				int padding = 32;
				for (int i = 0; i < reader.FieldCount; i++)
					Console.Write(reader.GetName(i).PadRight(padding));
				Console.WriteLine();
				while (reader.Read())
				{
					for (int i = 0; i < reader.FieldCount; i++)
					{
						Console.Write(reader[i].ToString().PadRight(padding));
					}
					Console.WriteLine();
				}

			}
			reader.Close();
			connection.Close();

		}
		public static void SelectBooks()
		{
			SqlCommand cmd = new SqlCommand("SELECT * FROM Books", connection);
			connection.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			if (reader.HasRows)
			{
				const int padding = 32;
				for (int i = 0; i < reader.FieldCount; i++)
					Console.Write(reader.GetName(i).PadRight(padding));
				Console.WriteLine();
				while (reader.Read())
				{
					for (int i = 0; i < reader.FieldCount; i++)
					{
						Console.Write(reader.GetValue(i).ToString().PadRight(padding));
					}
					Console.WriteLine();
				}
			}
			reader.Close();
			connection.Close();

		}
		public static void SelectAuthors()
		{
			SqlCommand cmd = new SqlCommand();
			
			cmd.Connection = connection;
			cmd.CommandText = "SELECT first_name  FROM Authors";
			//cmd.Parameters.Add("@id",System.Data.SqlDbType.Int);
			cmd.Parameters.AddWithValue("@first_name", System.Data.SqlDbType.NVarChar).Value="first_name";
			//cmd.Parameters.AddWithValue("@last_name", "last_name");
			//cmd.Parameters.AddWithValue("@Table", "Authors");

			connection.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			const int padding = 16;
			if (reader.HasRows)
			{
				for (int i = 0; i < reader.FieldCount; i++)
					Console.Write(reader.GetName(i).PadRight(padding));
				Console.WriteLine();
				while (reader.Read())
				{
					for (int i = 0; i < reader.FieldCount; i++)
					{
						Console.Write(reader.GetValue(i).ToString().PadRight(padding));
					}
					Console.WriteLine();
					//Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}");
				}
			}
			reader.Close();
			connection.Close();
			Console.WriteLine();

		}


	}
}
