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
	}
}
