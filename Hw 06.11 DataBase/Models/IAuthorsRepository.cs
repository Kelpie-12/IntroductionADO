using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_06._11_DataBase.Models
{
	public interface IAuthorsRepository
	{
		void Add(AuthorsModel authors);
		void Delete(int id);
		IEnumerable<AuthorsModel> GetAll();
		IEnumerable<AuthorsModel> GetByValue(string value);
	}
}
