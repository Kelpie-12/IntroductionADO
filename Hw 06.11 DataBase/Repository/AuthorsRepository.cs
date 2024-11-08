using Hw_06._11_DataBase.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_06._11_DataBase.Repository
{
	public class AuthorsRepository : BaseRepository, IAuthorsRepository
	{


		public AuthorsRepository(string connecnionString)
		{
			this.connectionString = connecnionString;
		}
		public void Add(AuthorsModel authors)
		{
			throw new NotImplementedException();
		}
		public void Delete(int id)
		{
			throw new NotImplementedException();
		}
		public IEnumerable<AuthorsModel> GetAll()
		{
			var authorList = new List<AuthorsModel>();
			using (var conn = new SqlConnection(connectionString))
			using (var command = new SqlCommand())
			{
				conn.Open();
				command.Connection = conn;
				command.CommandText = "SELECT * FROM Authors ORDER BY author_id DESC ";
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var authors = new AuthorsModel();
						authors.Id = (int)reader[0];
						authors.First_name = reader[1].ToString();
						authors.Last_name = reader[2].ToString();
					}
				}
			}

			return authorList;
		}
		public IEnumerable<AuthorsModel> GetByValue(string value)
		{
			int authorId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0 ;
			string authorLastName = value;
			string authorFirstName = value;

			var authorList = new List<AuthorsModel>();
			using (var conn = new SqlConnection(connectionString))
			using (var command = new SqlCommand())
			{
				conn.Open();
				command.Connection = conn;
				command.CommandText = "SELECT * FROM Authors WHERE author_id=@id or first_name LIKE @first + '%' or last_name LIKE @last + '%' ORDER BY author_id DESC ";
				command.Parameters.Add("@id", SqlDbType.Int).Value = authorId;
				command.Parameters.Add("@first", SqlDbType.NVarChar,150).Value = authorLastName;
				command.Parameters.Add("@last", SqlDbType.NVarChar,150).Value = authorFirstName;

				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var authors = new AuthorsModel();
						authors.Id = (int)reader[0];
						authors.First_name = reader[1].ToString();
						authors.Last_name = reader[2].ToString();
					}
				}
			}

			return authorList;
		}
	}
}
