using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace Academy
{
	class Connector
	{
		static readonly string connectionString = ConfigurationManager.ConnectionStrings["ToAcademy"].ConnectionString;
		static SqlConnection sqlConnection;
		static Connector()
		{
			sqlConnection = new SqlConnection(connectionString);
		}
		public static DataTable Select(string colums, string tables, string condition = "")
		{
			DataTable dt = new DataTable();
			string cmd = $"SELECT {colums} FROM {tables}";
			if (condition.Length > 0)
				cmd += $" WHERE {condition}";
			SqlCommand command = new SqlCommand(cmd, sqlConnection);
			sqlConnection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				for (int i = 0; i < reader.FieldCount; i++)
					dt.Columns.Add(reader.GetName(i));
				while (reader.Read())
				{
					DataRow row = dt.NewRow();
					for (int i = 0; i < reader.FieldCount; i++)
						row[i] = reader[i];
					dt.Rows.Add(row);
				}

			}
			reader.Close();
			sqlConnection.Close();

			return dt;
		}

		public static List<string> SelectColumn(string colums, string tables)
		{
			List<string> values = new List<string>();
			string cmd = $"SELECT {colums} FROM {tables}";
			SqlCommand command = new SqlCommand(cmd, sqlConnection);
			sqlConnection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
					values.Add(reader[0].ToString());
			}
			reader.Close();
			sqlConnection.Close();
			return values;
		}

		public static void InsertGroup(Group group)
		{
			SqlParameter[] parameters = new SqlParameter[6];
			parameters[0].ParameterName = "@group_name"; parameters[0].SqlDbType = SqlDbType.NVarChar; parameters[0].Value = group.GroupName;
			parameters[1].ParameterName = "@start_date"; parameters[1].SqlDbType = SqlDbType.Date; parameters[1].Value = group.StartDate;
			parameters[2].ParameterName = "@learning_time"; parameters[2].SqlDbType = SqlDbType.Time; parameters[2].Value = group.LearningTime;
			parameters[3].ParameterName = "@direction"; parameters[3].SqlDbType = SqlDbType.SmallInt; parameters[3].Value = group.Direction;
			parameters[4].ParameterName = "@learnig_form"; parameters[4].SqlDbType = SqlDbType.TinyInt; parameters[4].Value = group.LearningFrom;
			parameters[5].ParameterName = "@learning_days"; parameters[4].SqlDbType = SqlDbType.TinyInt; parameters[5].Value = group.LearningDays;			
			
			string cmd = $"if non exists (select group_id from Groups where group_name=@group_name) begin " +
				$"INSERT  Groups(group_name, start_date,learning_time, direction, learning_form, learning_days) " +
				$"VALUES('@group_name', " +
				$" '@start_date'," +
				$" '@learning_time'," +
				$" '@direction'," +
				$" '@learnig_form', " +
				$" ' @learning_days' end)";
			SqlCommand command = new SqlCommand(cmd, sqlConnection);
			sqlConnection.Open();
			command.Parameters.AddRange(parameters);
			command.ExecuteNonQuery();
			sqlConnection.Close();
		}

	}
}
