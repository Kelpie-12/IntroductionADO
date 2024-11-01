
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace HomeWork
{
	internal class Program
	{
		const string ConnectionString =
					"Data Source=(localdb)\\MSSQLLocalDB;" +
					"Initial Catalog=Library_PD_311;" +
					"Integrated Security=True;" +
					"Connect Timeout=30;Encrypt=False;" +
					"TrustServerCertificate=False;" +
					"ApplicationIntent=ReadWrite;" +
					"MultiSubnetFailover=False";
		static void Main(string[] args)
		{
			Select("Authors");
			Console.WriteLine();
			Select("Books");
			List<string> strings = new List<string> { /*"Books.title",*/"Authors.author_id", "Authors.first_name", "Authors.last_name" };
			List<string> tables = new List<string> { /*"Books",*/ "Authors" };
			Select(tables, strings, @"Authors.first_name = 'James'");
		}

		static void Select(string table_name)
		{
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				connection.Open();
				//Console.WriteLine("Подключение открыто");
				using (SqlCommand command = new SqlCommand())
				{
					command.CommandText = $"SELECT * FROM {table_name}";
					command.Connection = connection;
					SqlDataReader reader = command.ExecuteReader();
					if (reader.Read())
					{
						const int padding = 32;
						for (int i = 0; i < reader.FieldCount; i++)
							Console.Write(reader.GetName(i).PadRight(padding));
						Console.WriteLine();
						while (reader.Read())
						{
							for (int j = 0; j < reader.FieldCount; j++)
							{
								Console.Write(reader.GetValue(j).ToString().PadRight(padding));
							}
							Console.WriteLine();							
						}
					}
				}
			}
			//Console.WriteLine("Подключение закрыто");
			//Console.WriteLine("Программа завершила работу");	
		}

		static void Select(List<string> table, List<string> strings, string where)
		{
			const int padding = 32;
			string sql = "SELECT ";
			for (int i = 0; i < strings.Count; i++)
			{
				sql += strings[i];
				sql += " ";
				if (strings.Count != 1 && strings.Count - 1 != i)
					sql += ", ";
			}
			sql += " FROM ";
			for (int i = 0; i < table.Count; i++)
			{
				sql += table[i];
				sql += " ";
				if (table.Count != 1 && table.Count - 1 != i)
					sql += ", ";
			}
			sql += " WHERE ";
			sql += where;

			//string sql2 = "SELECT Books.title , Authors.first_name , Authors.last_name FROM Books , Authors WHERE Books.author = Authors.author_id";
		//string sql3 = @"SELECT * FROM Authors WHERE Authors.author_id = 2";			
		//	sql = sql3;
			//if (sql != sql3)
			//	Console.WriteLine("neВерно");
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				connection.Open();
				
				//Console.WriteLine("Подключение открыто");
				using (SqlCommand command = new SqlCommand(/*sql, connection*/))
				{
					command.CommandText = sql;
					command.Connection = connection;
					SqlDataReader reader = command.ExecuteReader();
					if (reader.Read())
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
						}
					}
				}
			}
		}
	}
}
