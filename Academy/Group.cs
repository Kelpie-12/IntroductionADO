using System;
using System.Windows.Forms;

namespace Academy
{
	public class Group
	{
		public Group(Group other)
		{
			this.ID = other.ID;
			this.GroupName = other.GroupName;
			this.LearningFrom = other.LearningFrom;
			this.LearningDays = other.LearningDays;
			this.Direction = other.Direction;
			this.StartDate = other.StartDate;
			this.LearningTime = other.LearningTime;
		}
		public Group() { }
		public Group(AddGroupForm addGroupForm)
		{
			this.GroupName = addGroupForm.textBGroupName.Text;
			this.StartDate = addGroupForm.dateTPGroupStart.Value;
			this.LearningTime = addGroupForm.dateTPGroupTime.Value.TimeOfDay;
			this.Direction = addGroupForm.cbGroupDirection.SelectedIndex + 1;
			this.LearningFrom = addGroupForm.cbLearningForm.SelectedIndex + 1;
			this.LearningDays = addGroupForm.GetWeekDays();
		}
		public Group(DataGridViewRow row)
		{
			this.ID = Convert.ToInt32(row.Cells[0].Value);
			this.GroupName = row.Cells[1].Value.ToString();
			this.StartDate = Convert.ToDateTime(row.Cells[2].Value);
			this.LearningTime = Convert.ToDateTime(row.Cells[3].Value).TimeOfDay;
			this.Direction = Connector.Directions[row.Cells[4].Value.ToString()];
			this.LearningFrom = Connector.LearningForms[row.Cells[5].Value.ToString()];
			this.LearningDays = Convert.ToByte(row.Cells[6].Value);

		}
		public int ID { get; set; }
		public string GroupName { get; set; }
		public int Direction { get; set; }
		public DateTime StartDate { get; set; }
		public TimeSpan LearningTime { get; set; }
		public int LearningFrom { get; set; }
		public byte LearningDays { get; set; }



	}
}
