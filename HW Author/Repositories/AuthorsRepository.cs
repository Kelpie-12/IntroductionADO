using HW_Author.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HW_Author.Repositories
{
	public class AuthorsRepository : BaseRepository, IAuthorsRepository
	{
		public AuthorsRepository(string connecnionString)
		{
			this.connectionString = connecnionString;
		}
		public void Add(AuthorsModel authors)
		{
			using (var conn = new SqlConnection(connectionString))
			using (var command = new SqlCommand())
			{
				conn.Open();
				command.Connection = conn;
				command.CommandText = "INSERT INTO  Authors VALUES(@first_name,@last_name)";
				command.Parameters.Add("@first_name", SqlDbType.NVarChar, 150).Value = authors.First_name;
				command.Parameters.Add("@last_name", SqlDbType.NVarChar, 150).Value = authors.Last_name;
				command.ExecuteNonQuery();				
			}

		}
		public void Delete(int id)
		{
			using (var conn = new SqlConnection(connectionString))
			using (var command = new SqlCommand())
			{
				conn.Open();
				command.Connection = conn;
				command.CommandText = "DELETE FROM Authors WHERE author_id=@id";
				command.Parameters.Add("@id", SqlDbType.Int).Value = id;
				command.ExecuteNonQuery();


			}
		}
		public IEnumerable<AuthorsModel> GetAll()
		{
			var authorList = new List<AuthorsModel>();
			using (var conn = new SqlConnection(connectionString))
			using (var command = new SqlCommand())
			{
				conn.Open();
				command.Connection = conn;
				command.CommandText = "SELECT * FROM Authors ORDER BY author_id ";
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var authors = new AuthorsModel();
						authors.Id = (int)reader[0];
						authors.First_name = reader[1].ToString();
						authors.Last_name = reader[2].ToString();
					authorList.Add(authors);
					}
				}
			}

			return authorList;
		}
		public IEnumerable<AuthorsModel> GetByValue(string value)
		{
			int authorId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
			string authorLastName = value;
			string authorFirstName = value;

			var authorList = new List<AuthorsModel>();
			using (var conn = new SqlConnection(connectionString))
			using (var command = new SqlCommand())
			{
				conn.Open();
				command.Connection = conn;
				command.CommandText = "SELECT * FROM Authors WHERE author_id=@id  or first_name LIKE @first + '%' or last_name LIKE @last + '%' ORDER BY author_id  ";
				command.Parameters.Add("@id", SqlDbType.Int).Value = authorId;
				command.Parameters.Add("@first", SqlDbType.NVarChar, 150).Value = authorLastName;
				command.Parameters.Add("@last", SqlDbType.NVarChar, 150).Value = authorFirstName;

				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var authors = new AuthorsModel();
						authors.Id = (int)reader[0];
						authors.First_name = reader[1].ToString();
						authors.Last_name = reader[2].ToString();
						authorList.Add(authors);
					}
				}
			}

			return authorList;
		}
	}
}
