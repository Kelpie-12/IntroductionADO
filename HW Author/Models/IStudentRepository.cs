using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Author.Models
{
	public interface IStudentRepository
	{
		void Add(StudentModel student);
		void Delete(int id);
		IEnumerable<StudentModel> GetAll();
		IEnumerable<StudentModel> GetByValue(string value);
	}
}
