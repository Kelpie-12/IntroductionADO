using Hw_06._11_DataBase.Presenter;
using Hw_06._11_DataBase.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw_06._11_DataBase
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			string connectionString = ConfigurationManager.ConnectionStrings["ToLibrary"].ConnectionString;
			var r = new AuthorsRepository(connectionString);
			var view = new MainForms();
			
			new AuthorsPresenter(view, r);
			Application.Run(view);
		}
	}
}
