using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System;
using System.Drawing;


namespace AcademyDataSet
{
	public partial class MainForm : Form
	{
		string connectionString = string.Empty;
		SqlConnection connection = null;
		DataSet GroupsRelatinData = null;

		public MainForm()
		{
			InitializeComponent();
			AllocConsole();
			connectionString = ConfigurationManager.ConnectionStrings["ToAcademy"].ConnectionString;
			connection = new SqlConnection(connectionString);


			Console.WriteLine(connectionString);

			GroupsRelatinData = new DataSet(nameof(GroupsRelatinData));
			GroupsRelatinData.Tables.Add("Groups");
			GroupsRelatinData.Tables.Add("Directions");

			GroupsRelatinData.Tables["Directions"].Columns.Add("direction_id", typeof(short));
			GroupsRelatinData.Tables["Directions"].Columns.Add("direction_name", typeof(string));
			GroupsRelatinData.Tables["Directions"].PrimaryKey = new DataColumn[] { GroupsRelatinData.Tables["Directions"].Columns["direction_id"] };

			GroupsRelatinData.Tables["Groups"].Columns.Add("group_id", typeof(int));
			GroupsRelatinData.Tables["Groups"].Columns.Add("group_name", typeof(string));
			GroupsRelatinData.Tables["Groups"].Columns.Add("direction", typeof(short));
			GroupsRelatinData.Tables["Groups"].PrimaryKey = new DataColumn[] { GroupsRelatinData.Tables["Groups"].Columns["group_id"] };

			GroupsRelatinData.Relations.Add("GroupsDirection", GroupsRelatinData.Tables["Directions"].Columns["direction_id"], GroupsRelatinData.Tables["Groups"].Columns["direction"]);
			string directionsSqlQuery = "select * from Directions";
			string groupSqlQuery = "select group_id,group_name, direction from Groups";

			SqlDataAdapter directionsAdapter = new SqlDataAdapter(directionsSqlQuery, connection);
			SqlDataAdapter groupsAdapter = new SqlDataAdapter(groupSqlQuery, connection);

			connection.Open();
			directionsAdapter.Fill(GroupsRelatinData.Tables["Directions"]);
			groupsAdapter.Fill(GroupsRelatinData.Tables["Groups"]);

			connection.Close();
			foreach (DataRow row in GroupsRelatinData.Tables["Directions"].Rows)
				Console.WriteLine($"{row["direction_id"]}\t {row["direction_name"]}");
			for (int i = 0; i < GroupsRelatinData.Tables["Groups"].Rows.Count; i++)
			{
				for (int j = 0; j < GroupsRelatinData.Tables["Groups"].Columns.Count; j++)
					Console.Write($"{GroupsRelatinData.Tables["Groups"].Rows[i][j]} ");
				Console.WriteLine();
			}
				dataGridView1.DataSource = GroupsRelatinData.Tables[0];
			for (int i = 0; i < dataGridView1.Rows.Count; i++)
			{
				int thirdColumn = 2;
				DataGridViewColumn column =
					dataGridView1.Columns[thirdColumn];
				//DataGridViewLinkCell cell = new DataGridViewLinkCell();
				DataGridViewCell cell = new DataGridViewTextBoxCell();
				cell.Style.BackColor=Color.AliceBlue;
				column.CellTemplate = cell;
				dataGridView1.Rows[i].Cells[1] = cell;
				Console.WriteLine("add");
			}
		}
		[DllImport("kernel32.dll")]
		public static extern bool AllocConsole();
	}
}
