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
		DataTable dtStudents;
		DataTable dtGroups;
		DataTable dtDirection;
		List<string> a;
		public MainForm()
		{
			InitializeComponent();
			LoadAllDataTable();
			dataGridViewStudents.Rows.CollectionChanged += new CollectionChangeEventHandler(CountRows);
		}
		void CountRows(object sender, EventArgs e)
		{
			toolStripStatusLabelStudentCount.Text = $"Колличество студентов {dataGridViewStudents.RowCount}";
		}
		void LoadAllDataTable()
		{
			dtStudents = Connector.Select("last_name, first_name, birth_date, group_name, derection_name, [age] = (DATEDIFF(DAY, birth_date, GETDATE())) / 365", "Students, Groups, Directions", "[group]=group_id and direction = direction_id");
			dataGridViewStudents.DataSource = dtStudents;
			//dataGridViewStudents.DataSource = Connector.Select("last_name, first_name, birth_date, group_name, derection_name, [age] = (DATEDIFF(DAY, birth_date, GETDATE())) / 365", "Students, Groups, Directions", "[group]=group_id and direction = direction_id");
			LoadComboBox();
		}
		public void LoadComboBox()
		{
			a = new List<string>();
			dtGroups = Connector.Select("*", "Groups");
			cbGroupStudent.Items.Clear();
			string tmp;
			for (int i = 0; i < dtStudents.Rows.Count; i++)
			{
				tmp = dtStudents.Rows[i]["group_name"].ToString();
				if (!cbGroupStudent.Items.Contains(tmp))
					cbGroupStudent.Items.Add(tmp);
			}

			dtDirection = Connector.Select("*", "Directions");
			cbDirection.Items.Clear();
			cbDirection.Items.Add("");
			for (int i = 0; i < dtDirection.Rows.Count; i++)
			{
				tmp = dtDirection.Rows[i]["derection_name"].ToString();
				if (!cbDirection.Items.Contains(tmp))
					cbDirection.Items.Add(tmp);
				a.Add(tmp);
			}
			a.Sort();
		}

		private void textBoxSearchStudent_TextChanged(object sender, EventArgs e)
		{
			if (cbGroupStudent.SelectedIndex != -1)
				dataGridViewStudents.DataSource = Connector.Select("last_name, first_name, birth_date, group_name, derection_name , [age] = (DATEDIFF(DAY, birth_date, GETDATE())) / 365", "Students,Groups", $"(first_name LIKE '{textBoxSearchStudent.Text}' +'%' or last_name LIKE '{textBoxSearchStudent.Text}' +'%') AND [group]=group_id AND group_name = '{cbGroupStudent.Text}' ");
			else if (cbDirection.SelectedIndex != -1)
				dataGridViewStudents.DataSource = Connector.Select("last_name, first_name, birth_date, group_name, derection_name, [age] = (DATEDIFF(DAY, birth_date, GETDATE())) / 365 ", "Students,Groups,Directions", $"(first_name LIKE '{textBoxSearchStudent.Text}' +'%' or last_name LIKE '{textBoxSearchStudent.Text}' +'%') AND [group]=group_id and direction = direction_id AND derection_name = '{cbDirection.Text}' ");
			else
				dataGridViewStudents.DataSource = Connector.Select("last_name, first_name, birth_date, group_name, derection_name ", "Students,Groups,Directions", $"(first_name LIKE '{textBoxSearchStudent.Text}' +'%' or last_name LIKE '{textBoxSearchStudent.Text}' +'%') AND [group]=group_id and direction = direction_id ");

		}

		private void cbGroupStudent_SelectedIndexChanged(object sender, EventArgs e)
		{
			textBoxSearchStudent.Clear();
			dataGridViewStudents.DataSource = Connector.Select("last_name, first_name, birth_date, group_name, derection_name, [age] = (DATEDIFF(DAY, birth_date, GETDATE())) / 365", "Students, Groups, Directions", $" [group]=group_id and direction = direction_id AND group_name = '{cbGroupStudent.Text}' ");
			dtStudents = Connector.Select("last_name, first_name, birth_date, group_name, derection_name, [age] = (DATEDIFF(DAY, birth_date, GETDATE())) / 365", "Students, Groups, Directions", $"[group]=group_id and direction = direction_id AND group_name = '{cbGroupStudent.Text}' ");
			cbDirection.Items.Clear();
			cbDirection.Items.Add(dtStudents.Rows[0]["derection_name"]);
		}

		private void cbDirection_SelectedIndexChanged(object sender, EventArgs e)
		{
			textBoxSearchStudent.Clear();
			dataGridViewStudents.DataSource = Connector.Select("last_name, first_name, birth_date, group_name, derection_name, [age] = (DATEDIFF(DAY, birth_date, GETDATE())) / 365", "Students, Groups, Directions", $"[group]=group_id and direction = direction_id AND  derection_name = '{cbDirection.Text}'");
			dtStudents = Connector.Select("last_name, first_name, birth_date, group_name, derection_name, [age] = (DATEDIFF(DAY, birth_date, GETDATE())) / 365", "Students, Groups, Directions", $"[group]=group_id and direction = direction_id AND derection_name = '{cbDirection.Text}' ");
			dtDirection = Connector.Select("group_name", "Groups, Directions", $"direction = direction_id AND derection_name = '{cbDirection.Text}'");
			cbGroupStudent.Items.Clear();
			string tmp;
			for (int i = 0; i < dtStudents.Rows.Count; i++)
			{
				tmp = dtStudents.Rows[i]["group_name"].ToString();
				if (!cbGroupStudent.Items.Contains(tmp))
					cbGroupStudent.Items.Add(tmp);
			}

		}
	}
}
