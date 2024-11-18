using System;
using System.Linq;
using System.Windows.Forms;

namespace Academy
{
	public partial class AddGroupForm : Form
	{
		public Group Group { get; set; }
		public AddGroupForm()
		{
			InitializeComponent();
			//cbLearningForm.Items.AddRange(Connector.SelectColumn("form_name", "LearningForms").ToArray());
			//cbGroupDirection.Items.AddRange(Connector.SelectColumn("derection_name", "Directions").ToArray());
			//SetWeekDays(42);
			cbLearningForm.Items.AddRange(Connector.LearningForms.Keys.ToArray());
			cbGroupDirection.Items.AddRange(Connector.Directions.Keys.ToArray());
		}
		public byte GetWeekDays()
		{
			byte days = 0;
			byte day = 1;
			for (byte i = 0; i < checkedLBCroup.Items.Count; i++)
			{
				//	Console.Write(checkedLBCroup.GetItemChecked(i) + "\t");
				if (checkedLBCroup.GetItemChecked(i))
					days |= (byte)(day << i);
			}
			//Console.WriteLine(days);
			return days;
		}
		public void SetWeekDays(byte days)
		{
			for (byte i = 0; i < checkedLBCroup.Items.Count; i++)
				checkedLBCroup.SetItemChecked(i, ((days & (1 << i)) != 0));
		}
		private void btnSaveGroup_Click(object sender, EventArgs e)
		{
			//GetWeekDays();
			//Group.GroupName = textBGroupName.Text;
			//Group.LearningDays = GetWeekDays();
			//Group.LearningFrom=1;

			//cbGroupDirection.Items.AddRange();
			//	Connector.InsertGroup(Group);

		}
		public void ClearData()
		{
			textBGroupName.Text = string.Empty;
			cbLearningForm.SelectedIndex = -1;
			cbGroupDirection.SelectedIndex = -1;
			dateTPGroupTime.Text = string.Empty;
			dateTPGroupStart.Text = string.Empty;
			//dateTPGroupStart.Value = DateTime.MinValue;
			//dateTPGroupTime.Value = DateTime.MinValue;
			SetWeekDays(0);
		}
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			ClearData();
		}
		public void Init(Group group)
		{
			Group = new Group(group);
			
			textBGroupName.Text = group.GroupName;
			cbGroupDirection.SelectedIndex = group.Direction - 1;
			cbLearningForm.SelectedIndex = group.LearningFrom - 1;
			SetWeekDays(group.LearningDays);
			dateTPGroupStart.Value = group.StartDate;
			dateTPGroupTime.Value = DateTime.Now.Date + group.LearningTime;


		}
	}
}
