using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book = Books.Book;
using Library = Librarys.Library;

namespace LesApp1
{
    class Program
    {
        static void Main()
        {
            // підключення Unicode
            Console.OutputEncoding = Encoding.Unicode;

            #region створення екземплярів
            // створення бібліотеки
            Library[] library = new Library[3];

            // за замовчуванням
            library[0] = new Library();

            // користувацький 1
            library[1] = new Library("Jamie Dixon",
                "Mastering .NET Machine Learning");

            // користувацький 2
            library[2] = new Library(new Book()
            {
                Author = "Mathias Brandewinder",
                BookName = "Machine Learning Projects for .NET Developers"
            });
            #endregion

            // Виведення даних по бібліотеці
            Console.WriteLine("\nПерелік книг в бібліотеці:\n");
            for (int i = 0; i < library.Length; i++)
            {
                Console.WriteLine($"Book №{i + 1}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"\tTitle: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(library[i].Book.BookName);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"\tAuthor: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(library[i].Book.Author);
                Console.ResetColor();
                Console.WriteLine();
            }

            // delay
            Console.ReadKey(true);
        }
    }
}
