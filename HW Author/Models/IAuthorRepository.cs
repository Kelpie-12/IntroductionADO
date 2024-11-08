using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Author.Models
{
	public interface IAuthorsRepository
	{
		void Add(AuthorsModel authors);
		void Delete(int id);
		IEnumerable<AuthorsModel> GetAll();
		IEnumerable<AuthorsModel> GetByValue(string value);
	}
}
