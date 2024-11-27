using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw_Acadeny
{
	public partial class AddGroupForm : Form
	{
		Group group = new Group();
		public AddGroupForm(Group group_name)
		{
			InitializeComponent();
			if (group_name.Group_name != string.Empty)
			{
				SetWeekDays(group_name.Learning_days);//
				textBGroupName.Text = group_name.Group_name;
				//cbGroupDirection.Items.Add(Connector.Query($"SELECT derection_name FROM Directions WHERE direction_id = {group_name.Direction}"));
				cbGroupDirection.Items.AddRange(Connector.SelectColumn("direction_name", "Directions").ToArray());

				cbGroupDirection.SelectedItem = cbGroupDirection.Items[group_name.Direction - 1];
				dateTPGroupStart.Text = group_name.Start_date;
				dateTPGroupTime.Text = group_name.Learning_time;
				cbLearningForm.Items.AddRange(Connector.SelectColumn("form_name", "LearningForms").ToArray());
				//Convert.ToInt32(Connector.Query($"SELECT form_name FROM LearningForms WHERE form_id = {group_name.Learning_form}"))
				cbLearningForm.SelectedItem = cbLearningForm.Items[group_name.Learning_form - 1];
			}
		}
		private void SetWeekDays(byte days)
		{
			for (byte i = 0; i < checkedLBCroup.Items.Count; i++)
				checkedLBCroup.SetItemChecked(i, ((days & (1 << i)) != 0));
		}
		public AddGroupForm()
		{
			InitializeComponent();
			cbLearningForm.Items.AddRange(Connector.SelectColumn("form_name", "LearningForms").ToArray());
			cbGroupDirection.Items.AddRange(Connector.SelectColumn("direction_name", "Directions").ToArray());
		}
		public byte GetWeekDays()
		{
			byte days = 0;
			byte day = 1;
			for (byte i = 0; i < checkedLBCroup.Items.Count; i++)
			{
				Console.Write(checkedLBCroup.GetItemChecked(i) + "\t");
				if (checkedLBCroup.GetItemChecked(i))
					days |= (byte)(day << i);
			}
			Console.WriteLine(days);
			return days;
		}


		private void btnSaveGroup_Click_1(object sender, EventArgs e)
		{
			if (group.Group_name == string.Empty)
			{
				group.Group_id = Convert.ToInt32(Connector.Query("select max(group_id) from Groups")) + 1;
				group.Group_name = textBGroupName.Text;
				group.Direction = cbGroupDirection.SelectedIndex;
				group.Learning_form = cbLearningForm.SelectedIndex;
				group.Start_date = FormatDay();
				group.Learning_time = dateTPGroupTime.Value.ToShortTimeString();
				group.Learning_days = GetWeekDays();
				Connector.AddGroup(group);
			}
			else
			{
				group.Group_name = textBGroupName.Text;
				group.Direction = cbGroupDirection.SelectedIndex;
				group.Learning_form = cbLearningForm.SelectedIndex;
				group.Start_date = FormatDay();
				group.Learning_time = dateTPGroupTime.Value.ToShortTimeString();
				group.Learning_days = GetWeekDays();
				//Connector.UpdateGroup(group);
			}
			Clear();

		}
		private string FormatDay()
		{
			string r = string.Empty;
			DateTime date = dateTPGroupStart.Value;
			r = date.Year.ToString() + "-";
			r += date.Month.ToString() + "-";
			r += date.Day.ToString();
			return r;
		}

		private void Clear()
		{
			textBGroupName.Text = string.Empty;
			cbGroupDirection.SelectedIndex = 0;
			cbLearningForm.SelectedIndex = 0;
			dateTPGroupStart = null;
			dateTPGroupTime = null;
			SetWeekDays(0);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Clear();
		}
	}
}
