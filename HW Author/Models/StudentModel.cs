using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Author.Models
{
	public class StudentModel
	{
		private int id;
		private string firstName;
		private string lastName;
		private DateTime birthDay;
		private string middleName;
		private int group;

		public int Id { get => id; set => id = value; }
		public string FirstName { get => firstName; set => firstName = value; }
		public string LastName { get => lastName; set => lastName = value; }
		public DateTime BirthDay { get => birthDay; set => birthDay = value; }
		public string MiddleName { get => middleName; set => middleName = value; }
		public int Group { get => group; set => group = value; }
	}
}
