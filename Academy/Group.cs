using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		public int ID { get; set; }
		public string GroupName { get; set; }
		public int Direction { get; set; }
		public DateTime StartDate { get; set; }	
		public TimeSpan LearningTime { get; set; }	
		public int LearningFrom { get; set; }
		public byte LearningDays { get; set; }



	}
}
