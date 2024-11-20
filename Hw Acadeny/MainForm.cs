using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw_Acadeny
{
	public partial class MainForm : Form
	{

		AddGroupForm addGroupForm;
		DataSet dataSet;
		public MainForm()
		{			
			InitializeComponent();
			LoadStudents();
			LoadGroups();
			addGroupForm = new AddGroupForm();
			AllocConsole();
			DataSetLoad();
		}
		void DataSetLoad()
		{
			dataSet = Connector.GetDataSet("Directions");
			dataSet.Tables.Add(Connector.Select("*", "Groups"));
			cbDirection.DataSource = dataSet.Tables["Directions"];
			cbDirection.DisplayMember = "derection_name";
			cbGroupStudent.DataSource = dataSet.Tables["Groups"];
			cbGroupStudent.DisplayMember = "group_name";
		}
		void LoadStudents()
		{
			dataGridViewStudents.DataSource = Connector.Select("last_name, first_name, birth_date, group_name, derection_name", "Students, Groups, Directions", "[group]=group_id and direction = direction_id");
			dataGridViewStudents.Rows.CollectionChanged += new CollectionChangeEventHandler(SetStatusBarText);
			SetStatusBarText(dataGridViewStudents.Rows, new EventArgs());
		}
		void LoadGroups()
		{
			dataGridViewGroups.Rows.CollectionChanged += new CollectionChangeEventHandler(SetStatusBarText);
			//dataGridViewGroups.DataSource = Connector.Select
			//	("group_name,[Nubers of Student]=COUNT(student_id),derection_name",
			//	"Groups,Directions,Students",
			//	"direction=direction_id AND [group]=group_id GROUP BY [group_name],derection_name");
			cbDirectionOnGroup.Items.AddRange(Connector.SelectColumn("derection_name", "Directions").ToArray());
			dataGridViewGroups.DataSource = Connector.Select("*", "Groups");
			//cbDirectionOnGroup.Items.AddRange(Connector.Select("derection_name", "Directions").Rows[0].ItemArray);
		}
		void SetStatusBarText(object sender, EventArgs e)
		{
			toolStripStatusLabelStudentCount.Text = $"Number of {nameof(tabControlMain.SelectedTab.Text)}: {(sender as DataGridViewRowCollection).Count - 1}";
			//toolStripStatusLabelStudentCount.Text = $"Number of {nameof(tabControlMain.SelectedTab.Text.ToLower)}: {dataGridViewStudents.RowCount}";
		}


		private void textBoxSearchStudent_TextChanged(object sender, EventArgs e)
		{
			string[] values = textBoxSearchStudent.Text.Split(' ');
			if (values.Length > 1)
				values = values.Where(v => v != "").ToArray();
			string search_pattern = "";
			if (values.Length == 1)
				search_pattern = $"last_name LIKE '{values[0]}' + '%'  or first_name LIKE '{values[0]}' + '%'  ";
			else
				search_pattern = $"(last_name LIKE '{values[0]}'  or first_name LIKE '{values[1]}' ) or ( first_name LIKE '{values[0]}' + '%' or last_name LIKE '{values[1]}') ";
			//else search_pattern = $"last_name LIKE '{values[1]}'  or first_name LIKE '{values[0]}' ";

			dataGridViewStudents.DataSource = Connector.Select(
				"last_name, first_name, birth_date, group_name, derection_name",
				"Students, Groups, Directions",
				$"[group]=group_id and direction = direction_id AND ({search_pattern})");
		}	
		
		[DllImport("kernel32.dll")]
		static extern bool AllocConsole();

		private void btnAddGroup_Click_1(object sender, EventArgs e)
		{
			if (addGroupForm.ShowDialog() == DialogResult.OK)
			{
				dataGridViewGroups.ClearSelection();
				dataGridViewGroups.DataSource = Connector.Select("*", "Groups");
			}

		}

		private void tabControlMain_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			switch ((sender as TabControl).SelectedIndex)
			{
				case 0:
					SetStatusBarText(dataGridViewStudents.Rows, e);
					break;
				case 1:
					SetStatusBarText(dataGridViewGroups.Rows, e);
					break;
			}
		}

		private void MainForm_Load_1(object sender, EventArgs e)
		{
			SetStatusBarText((dataGridViewStudents.Rows), e);

		}
		


		private void dataGridViewGroups_CellClick(object sender, DataGridViewCellEventArgs e)
		{
Group group = new Group();
			string a = dataGridViewGroups.CurrentCell.Value.ToString();
			group.Group_name = a;
			group.FullGroup();
			addGroupForm = new AddGroupForm(group);
			if (addGroupForm.ShowDialog() == DialogResult.OK)
			{

			}
		}

	
	}
}
