using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using HW_Author.Views;
using HW_Author.Models;
using HW_Author.Repositories;
using HW_Author.Presenters;

namespace HW_Author
{
	internal static class Program
	{
		
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			string connectionString = ConfigurationManager.ConnectionStrings["ToAcademy"].ConnectionString;
			IMainView view = new MainView();
			new MainPresenter(view,connectionString);
			Application.Run((Form)view);
		}
	}
}
