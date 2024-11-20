using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Author.Views
{
	public interface IMainView
	{
		event EventHandler ShowAuthorView;
		event EventHandler CloseAuthorView;
		event EventHandler ShowStudentView;
		event EventHandler CloseStudentView;
	}
}
