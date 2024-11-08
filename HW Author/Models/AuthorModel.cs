using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Author.Models
{
	public class AuthorsModel
	{
		private int id;
		private string last_name;
		private string first_name;

		public int Id { get => id; set => id = value; }
		public string Last_name { get => last_name; set => last_name = value; }
		public string First_name { get => first_name; set => first_name = value; }


	}
}
