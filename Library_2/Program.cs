using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
			SelectAuthors();

			SqlCommand cmd = new SqlCommand("SELECT * FROM Authors", connection);
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
				for (int i = 0;i<reader.FieldCount;i++)
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
			connection.Close();
			Console.WriteLine("OKAY");

		}
	}
}
