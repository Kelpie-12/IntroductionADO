using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.Design;

namespace Library_2
{
	class Program
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
		static Program()
		{
			connection = new SqlConnection(ConnectionString);
		}
		static void Main(string[] args)
		{
			//SelectAuthors();
			//SelectBooks();
			//Console.WriteLine();
			//Select("book_id,title,last_name,first_name", "Books, Authors", "author=author_id");

			//Console.WriteLine("Введите имя");
			//string first_name = Console.ReadLine();
			//Console.WriteLine("Введите фамилию");
			//string last_name = Console.ReadLine();
			//InsertAuthor(first_name, last_name);
			Console.WriteLine(GetAuthorID("James", "Cameron"));
			Console.Write("Введите название книги ");
			string title = Console.ReadLine();
			Console.Write("Ввудите имя автора ");
			string first_name = Console.ReadLine();
			Console.Write("Введите фамилию автора ");
			string last_name = Console.ReadLine(); 
			InsertBook(title,last_name,first_name);
			SelectBooks();

		}
		static void InsertBook(string title, string last_name, string first_name)
		{
			int author = GetAuthorID( first_name, last_name);
			string cmd = $"INSERT Books(title,author) VALUES ('{title}',{author})";

			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
		static int GetAuthorID(string first_name, string last_name)
		{
			string cmd = $"(SELECT author_id FROM Authors WHERE first_name=N'{first_name}' and last_name=N'{last_name}')";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			int author = Convert.ToInt32(command.ExecuteScalar());

			connection.Close();
			return author;
		}
		static void InsertAuthor(string first_name, string last_name)
		{
			string sql = $"INSERT Authors(first_name,last_name) VALUES('{first_name}','{last_name}')";
			SqlCommand command = new SqlCommand(sql, connection);
			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();
		}
		static void Select(string columns, string table, string condition)
		{
			string cmd = $"SELECT {columns} FROM {table} WHERE {condition}";
			SqlCommand command = new SqlCommand(cmd, connection);
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
		static void SelectBooks()
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
		static void SelectAuthors()
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandText = "SELECT * FROM Authors";
			cmd.Connection = connection;
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
			Console.WriteLine("OKAY");

		}


	}
}
