using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw_Acadeny
{
	public partial class MainForm : Form
	{

		public MainForm()
		{
			InitializeComponent();
			LoadStudents();
			LoadGroups();
			tabControlMain.TabPages.Remove(tbAddNewGroup);
			Events();
		}
		void Events()
		{
			btnAddGroup.Click += delegate
			{
				foreach (TabPage item in tabControlMain.TabPages)
					tabControlMain.TabPages.Remove(item);				
				tabControlMain.TabPages.Add(tbAddNewGroup);
				DataTable dataTable = new DataTable();
				dataTable = Connector.Select("derection_name", "Directions ORDER BY direction_id ");
				for (int i = 0; i < dataTable.Rows.Count; i++)
					cbDirectionAddGroup.Items.Add(dataTable.Rows[i]["derection_name"]);
			};
			btnSaveNewGroup.Click += delegate
			{
				Connector.Insert("Groups (group_id,group_name,direction)", $"{Convert.ToInt32(textbIdAddNewGroup.Text)},'{textbNameAddGroup.Text}',{Convert.ToInt32(cbDirectionAddGroup.SelectedIndex) + 1}");
				tabControlMain.TabPages.Add(tabPageStudent);
				tabControlMain.TabPages.Add(tabPageGroups);
				tabControlMain.TabPages.Add(tabPageDiscipline);
				tabControlMain.TabPages.Add(tabPageTeacher);
			};
			btnCancel.Click += delegate
			{				
				tabControlMain.TabPages.Remove(tbAddNewGroup);
				tabControlMain.TabPages.Add(tabPageStudent);
				tabControlMain.TabPages.Add(tabPageGroups);
				tabControlMain.TabPages.Add(tabPageDiscipline);
				tabControlMain.TabPages.Add(tabPageTeacher);
			};
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
			dataGridViewGroups.DataSource = Connector.Select
				("group_name,[Nubers of Student]=COUNT(student_id),derection_name",
				"Groups,Directions,Students"
				, "direction=direction_id AND [group]=group_id GROUP BY [group_name],derection_name");
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

		private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
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

		private void MainForm_Load(object sender, EventArgs e)
		{
			SetStatusBarText((dataGridViewStudents.Rows), e);
		}



	}
}
