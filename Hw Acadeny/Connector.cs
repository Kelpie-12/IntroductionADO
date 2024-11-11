using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Hw_Acadeny
{
	class Connector
	{
		static readonly string connectionString = ConfigurationManager.ConnectionStrings["ToAcademy"].ConnectionString;
		//static SqlConnection sqlConnection;
		static private SqlConnection sqlConnection;

		static public SqlConnection SqlConnection
		{
			get { return sqlConnection; }
		}

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
			if (reader.Read())
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


	}
}
