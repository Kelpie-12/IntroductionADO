using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Hw_Acadeny
{
	class Connector
	{
		static readonly string connectionString = ConfigurationManager.ConnectionStrings["ToAcademy"].ConnectionString;
		static SqlConnection sqlConnection;
		static SqlDataAdapter adapter;
		static DataSet set;
		static SqlCommandBuilder sqlCB;
		static Connector()
		{
			sqlConnection = new SqlConnection(connectionString);
		}
		
		static void Init()
		{
			adapter = new SqlDataAdapter("select * from Students", sqlConnection);
			sqlCB = new SqlCommandBuilder(adapter);
			sqlCB.GetDeleteCommand();
			sqlCB.GetInsertCommand();
			sqlCB.GetUpdateCommand();
		//	set = new DataSet();
		//	adapter.Fill(set,"Students");
		}
		public static void GetDataSet(ref DataSet set,string table, string colums = "*")
		{
			set = new DataSet();
			string sql = $"select {colums} from {table}";
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);
			sqlDataAdapter.Fill(set, table);		
		}
		public static void GetTableForDataSet(ref DataSet set,string table,string colums="*",string condition = "")
		{
			set.Tables.Add(Connector.Select(colums, table,condition));
		}

		public static void UpdateGroup(Group group,DataTable table)
		{
			string sql = $"UPDATE Groups SET direction='{group.Direction + 1}'," +
				$" learning_form='{group.Learning_form + 1}'," +
				$" learning_time = '{group.Learning_time}'," +
				$" learning_days = '{group.Learning_days}'," +
				$" start_date = '{group.Start_date}'," +
				$"  group_name= '{group.Group_name}' " +
				$" WHERE  group_id = '{group.Group_id}' ";
			adapter = new SqlDataAdapter();			
			adapter.Update(table);
			adapter.UpdateCommand = new SqlCommand(sql);
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
			dt.TableName = tables;
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
		public static List<string> SelectColumn(DataTable dataTable)
		{
			List<string> values = new List<string>();
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				values.Add(dataTable.Rows[0].ToString());
			}
			return values;
		}

		//public static void UpdateGroup(Group group)
		//{
		//	string cmd = $"UPDATE Groups SET direction='{group.Direction+1}'," +
		//		$" learning_form='{group.Learning_form+1}'," +
		//		$" learning_time = '{group.Learning_time}'," +
		//		$" learning_days = '{group.Learning_days}'," +
		//		$" start_date = '{group.Start_date}'," +
		//		$"  group_name= '{group.Group_name}' " +
		//		$" WHERE  group_id = '{group.Group_id}' ";
		//
		//	var command = new SqlCommand(cmd, sqlConnection);
		//	sqlConnection.Open();
		//	command.ExecuteNonQuery();
		//	sqlConnection.Close();
		//
		//
		//}
		public static void AddGroup(Group group)
		{
			string cmd = $"INSERT INTO Groups VALUES({group.Group_id}, " +
				$"'{group.Group_name}' ,{group.Direction + 1}, {group.Learning_form + 1}," +
				$" '{group.Start_date}',  '{group.Learning_time}' , {group.Learning_days} )";
			var command = new SqlCommand(cmd, sqlConnection);
			sqlConnection.Open();
			command.ExecuteNonQuery();
			sqlConnection.Close();
		}

		public static string Query(string s)
		{
			string r = string.Empty;
			var command = new SqlCommand(s, sqlConnection);
			sqlConnection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
				r = reader[0].ToString();
			reader.Close();
			sqlConnection.Close();
			return r;
		}

		public static void UpdateStudent(ref DataTable row )
		{
			adapter = new SqlDataAdapter();
			adapter.InsertCommand = new SqlCommand($"update Students set last_name = '{row.Rows[0][1]}', first_name = '{row.Rows[0][2]}', middle_name='{row.Rows[0][3]}' ,birth_date='{row.Rows[0][4]}', [group]={row.Rows[0][5]} where student_id = {row.Rows[0][0]}",sqlConnection);
			
			adapter.Update(row);
		}


	}
}
