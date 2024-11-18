using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	public class Group
	{

		public int ID { get; set; }
		public string GroupName { get; set; }
		public int Direction { get; set; }
		public DateTime StartDate { get; set; }	
		public TimeSpan LearningTime { get; set; }	
		public int LearningFrom { get; set; }
		public byte LearningDays { get; set; }



	}
}
