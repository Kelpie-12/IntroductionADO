using System;

namespace Library_2
{
	class Program
	{
		static void Main(string[] args)
		{
			//SelectAuthors();
			//SelectBooks();
			//Console.WriteLine();
			//Select("book_id,title,last_name,first_name", "Books, Authors", "author=author_id");

			//Console.WriteLine("Введите имя");
			//string first_name = Console.ReadLine();
			//Console.WriteLine("Введите фамилию");
			//string last_name = Console.ReadLine();
			//InsertAuthor(first_name, last_name);
			//Console.WriteLine(Library.GetAuthorID("James", "Cameron"));
			Console.Write("Введите название книги ");
			string title = Console.ReadLine();
			Console.Write("Ввeдите имя автора ");
			string first_name = "Scott";
			Console.Write("Введите фамилию автора ");
			string last_name = "Muller";
			Library.InsertBook(title, last_name, first_name);
			//Library.SelectBooks();
			//Library.SelectAuthors();
			Library.Select("title,last_name,first_name", "Books, Authors", "author=author_id");
			//Library.Select("last_name","Authors", "author_id=1");
			//Console.WriteLine(Library.GetAuthorID("Scott", "Muller"));
			Console.WriteLine("");
		}


	}
}
