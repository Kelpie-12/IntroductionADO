using HW_Author.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Author.Repositories
{
	public class StudentRepository : BaseRepository, IStudentRepository
	{
		public StudentRepository(string connecnionString)
		{
			this.connectionString = connecnionString;
		}

		public void Add(StudentModel student)
		{
			using (var conn = new SqlConnection(connectionString))
			using (var command = new SqlCommand())
			{
				conn.Open();
				command.Connection = conn;
				command.CommandText = "INSERT INTO  Students VALUES(@first_name,@last_name,@middle_name,@birth_day,@group)";
				command.Parameters.Add("@first_name", SqlDbType.NVarChar, 150).Value = student.FirstName;
				command.Parameters.Add("@last_name", SqlDbType.NVarChar, 150).Value = student.LastName;
				command.Parameters.Add("@middle_name", SqlDbType.NVarChar, 150).Value = student.MiddleName;
				command.Parameters.Add("@birth_day", SqlDbType.Date).Value = student.BirthDay;
				command.Parameters.Add("@group", SqlDbType.Int).Value = student.Group;
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
				command.CommandText = "DELETE FROM Students WHERE student_id=@id";
				command.Parameters.Add("@id", SqlDbType.Int).Value = id;
				command.ExecuteNonQuery();


			}
		}
		public IEnumerable<StudentModel> GetAll()
		{
			List<StudentModel> studentsList = new List<StudentModel>();
			using (var conn = new SqlConnection(connectionString))
			using (var command = new SqlCommand())
			{
				conn.Open();
				command.Connection = conn;
				command.CommandText = "SELECT * FROM Students ORDER BY student_id ";
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var student = new StudentModel();
						student.Id = (int)reader[0];
						student.LastName = reader[1].ToString();
						student.FirstName = reader[2].ToString();
						student.MiddleName = reader[3].ToString();
						student.BirthDay = Convert.ToDateTime(reader[4]);
						student.Group = (int)reader[5];
						studentsList.Add(student);
					}
				}
			}

			return studentsList;
		}
		public IEnumerable<StudentModel> GetByValue(string value)
		{
			int studentId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
			string studentLastName = value;
			string studentFirstName = value;

			var studentList = new List<StudentModel>();
			using (var conn = new SqlConnection(connectionString))
			using (var command = new SqlCommand())
			{
				conn.Open();
				command.Connection = conn;
				command.CommandText = "SELECT * FROM Students WHERE student_id=@id  or first_name LIKE @first + '%' or last_name LIKE @last + '%' ORDER BY student_id  ";
				command.Parameters.Add("@id", SqlDbType.Int).Value = studentId;
				command.Parameters.Add("@first", SqlDbType.NVarChar, 150).Value = studentLastName;
				command.Parameters.Add("@last", SqlDbType.NVarChar, 150).Value = studentFirstName;

				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						var student = new StudentModel();
						student.Id = (int)reader[0];
						student.LastName = reader[1].ToString();
						student.FirstName = reader[2].ToString();
						student.MiddleName = reader[3].ToString();
						student.BirthDay = Convert.ToDateTime(reader[4]);
						student.Group = (int)reader[5];
						studentList.Add(student);
					}
				}
			}

			return studentList;
		}



	}
}
