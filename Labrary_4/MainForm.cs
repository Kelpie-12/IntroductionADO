using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Labrary_4
{
	public partial class MainForm : Form
	{
		SqlConnection connection;
		readonly string connectionString = ConfigurationManager.ConnectionStrings["ToLibrary"].ConnectionString;

		public MainForm()
		{
			connection = new SqlConnection(connectionString);
			InitializeComponent();
		}

		private void buttonExecute_Click(object sender, EventArgs e)
		{
			string cmd = textBoxQuery.Text;
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			DataTable table = new DataTable();
			SqlDataReader reader = command.ExecuteReader();
			for (int i = 0; i < reader.FieldCount; i++)
				table.Columns.Add(reader.GetName(i));
			while (reader.Read())
			{
				DataRow row = table.NewRow();
				for (int j = 0; j < reader.FieldCount; j++)
					row[j] = reader[j];
				table.Rows.Add(row);
			}
			reader.Close();
			connection.Close();
			dataGridView.DataSource = table;
		}
	}
}
