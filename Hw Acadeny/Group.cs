using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_Acadeny
{
	public class Group
	{
		private string group_name;
		private int group_id;
		private int direction;
		private int learning_form;
		private string start_date;
		private string learning_time;
		private byte learning_days;

		public string Group_name { get => group_name; set => group_name = value; }
		public int Group_id { get => group_id; set => group_id = value; }
		public int Direction { get => direction; set => direction = value; }
		public int Learning_form { get => learning_form; set => learning_form = value; }
		public string Start_date { get => start_date; set => start_date = value; }
		public string Learning_time { get => learning_time; set => learning_time = value; }
		public byte Learning_days { get => learning_days; set => learning_days = value; }

		public void FullGroup()
		{
			if (group_name != string.Empty)
			{
				string connectionString = ConfigurationManager.ConnectionStrings["ToAcademy"].ConnectionString;
				string cmd = $"SELECT * FROM Groups WHERE group_name='{group_name}'";
				SqlConnection sqlConnection = new SqlConnection(connectionString);
				sqlConnection.Open();
				SqlCommand command = new SqlCommand(cmd, sqlConnection);

				SqlDataReader reader = command.ExecuteReader();
				if (reader.Read())
				{
					group_id = Convert.ToInt32(reader[0]);
					group_name = reader[1].ToString();
					direction = Convert.ToInt32(reader[2]);
					learning_form = Convert.ToInt32(reader[3]);
					start_date = reader[4].ToString();
					learning_time = reader[5].ToString();
					//learning_days = Convert.ToByte(reader[6]);
				}
				reader.Close();
				sqlConnection.Close();
			}
		}
		
	}
}
