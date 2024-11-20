using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Runtime.CompilerServices;


namespace Academy
{
	public partial class MainForm : Form
	{
		AddGroupForm addGroupForm;
		public MainForm()
		{
			InitializeComponent();
			LoadStudents();
			LoadGroups();
			addGroupForm = new AddGroupForm();
			AllocConsole();
		}
		void LoadStudents()
		{
			dataGridViewStudents.DataSource = Connector.Select("last_name, first_name, birth_date, group_name, derection_name", "Students, Groups, Directions", "[group]=group_id and direction = direction_id");
			dataGridViewStudents.Rows.CollectionChanged += new CollectionChangeEventHandler(SetStatusBarText);
			SetStatusBarText(dataGridViewStudents.Rows, new EventArgs());
			cbDirection.DataSource = Connector.Select("*","Directions");
			cbDirection.DisplayMember = "derection_name";
			cbDirection.ValueMember = "direction_id";
			cbDirection.SelectedIndex = -1;

			cbGroupStudent.DataSource = Connector.Select("*", "Groups");
			cbGroupStudent.DisplayMember = "group_name";
			cbGroupStudent.ValueMember = "group_id";
			cbGroupStudent.SelectedIndex = -1;

		}
		void LoadGroups()
		{
			dataGridViewGroups.Rows.CollectionChanged += new CollectionChangeEventHandler(SetStatusBarText);
			dataGridViewGroups.DataSource = Connector.Select(
				"group_id, group_name, [start_date], learning_time, derection_name, form_name, learning_days ",
				" Groups, Directions, LearningForms ",
				" direction=direction_id and learning_form=form_id"
				); ;

			//dataGridViewGroups.DataSource = Connector.Select
			//("group_name,[Nubers of Student]=COUNT(student_id),derection_name",
			//"Groups,Directions,Students",
			//"direction=direction_id AND [group]=group_id GROUP BY [group_name],derection_name");
			cbDirectionOnGroup.Items.AddRange(Connector.SelectColumn("derection_name", "Directions").ToArray());
			//cbDirectionOnGroup.Items.AddRange(Connector.Select("derection_name", "Directions").Rows[0].ItemArray);
			for (int i = 0; i < dataGridViewGroups.RowCount; i++)
			{
				dataGridViewGroups.Rows[i].Cells["learning_days"].Value =
					Week.ExtractDaysToString(Convert.ToByte(dataGridViewGroups.Rows[i].Cells["learning_days"].Value));
			}
		}
		void SetStatusBarText(object sender, EventArgs e)
		{
			toolStripStatusLabelStudentCount.Text = $"Number of {nameof(tabControlMain.SelectedTab.Text)}: {(sender as DataGridViewRowCollection).Count-1}";
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
			switch((sender as TabControl).SelectedIndex)
			{
				case 0: SetStatusBarText(dataGridViewStudents.Rows, e);
					break;
				case 1: SetStatusBarText(dataGridViewGroups.Rows, e);
					break;
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			SetStatusBarText((dataGridViewStudents.Rows), e);
		}

		private void btnAddGroup_Click(object sender, EventArgs e)
		{
			addGroupForm.ClearData();
			if (addGroupForm.ShowDialog()==DialogResult.OK)
			{
				//dataGridViewGroups.ClearSelection();
				//LoadGroups();
				Group group = new Group(addGroupForm);
				//group.GroupName = addGroupForm.textBGroupName.Text;
				//group.StartDate=addGroupForm.dateTPGroupStart.Value;
				//group.LearningTime = addGroupForm.dateTPGroupTime.Value.TimeOfDay;
				//group.Direction = addGroupForm.cbGroupDirection.SelectedIndex+1;
				//group.LearningFrom = addGroupForm.cbLearningForm.SelectedIndex+1;
				//group.LearningDays = addGroupForm.GetWeekDays();
				Connector.InsertGroup(group);
				LoadGroups();
			
			}
		}
		[DllImport("kernel32.dll")]
		static extern bool AllocConsole();

		private void dataGridViewGroups_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Group group = new Group((sender as DataGridView).SelectedRows[0]);
			//group.ID=Convert.ToInt32((sender as DataGridView).SelectedRows[0].Cells[0].Value);
			//group.GroupName=(sender as DataGridView).SelectedRows[0].Cells[1].Value.ToString();
			//group.StartDate = Convert.ToDateTime((sender as DataGridView).SelectedRows[0].Cells[2].Value);
			//group.LearningTime = Convert.ToDateTime((sender as DataGridView).SelectedRows[0].Cells[3].Value).TimeOfDay;
			//group.Direction = Connector.Directions[(sender as DataGridView).SelectedRows[0].Cells[4].Value.ToString()];
			//group.LearningFrom = Connector.LearningForms[(sender as DataGridView).SelectedRows[0].Cells[5].Value.ToString()];
			//group.LearningDays=Convert.ToByte((sender as DataGridView).SelectedRows[0].Cells[6].Value);
			addGroupForm.Init(group);
			addGroupForm.ShowDialog();

		}
	}
}
