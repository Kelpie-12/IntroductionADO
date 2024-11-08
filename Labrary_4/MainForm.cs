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
			LoadTablesToComboBox();
		}
		void LoadTablesToComboBox()
		{
			string cmd = "SELECT table_name FROM information_schema.tables";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					comboBoxTable.Items.Add(reader.GetString(0));
				}
			}
			reader.Close();
			connection.Close();
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

		private void comboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
		{
			dataGridView.DataSource = null;
			SelectAllFromTable(comboBoxTable.Text);
		}
		void SelectAllFromTable(string table_name)
		{
			string cmd = $"SELECT * FROM [{table_name}]";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				DataTable table = new DataTable();
				for (int i = 0; i < reader.FieldCount; i++)
					table.Columns.Add(reader.GetName(i));
				while(reader.Read())
				{
					DataRow row = table.NewRow();
					for (int i = 0; i < reader.FieldCount; i++)
					{
						row[i] = reader[i];
					}
					table.Rows.Add(row);
				}
				dataGridView.DataSource = table;

			}
			reader.Close();
			connection.Close();
		}
	}
}
