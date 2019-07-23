using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book = Books.Book;

// окремим файлом, більш всього напевне малось на увазі, що бібліотека dll

namespace Librarys
{
    /// <summary>
    /// Бібліотека
    /// </summary>
    public class Library
    {
        // книжка, приватне поле
        private Book book = new Book();

        /// <summary>
        /// Книга
        /// </summary>
        public Book Book
        {
            get { return book; }
        }

        /// <summary>
        /// За замовчуванням створює якусь книжку
        /// </summary>
        public Library()
        {
            book.Author = "Nishith Pathak, " +
                "Anurag Bhandari";
            book.BookName = "IoT, AI, and Blockchain for .NET " +
                "Building a Next-Generation " +
                "Application from the Ground Up";
        }

        /// <summary>
        /// Користувацький конструктор
        /// </summary>
        /// <param name="book">книга</param>
        public Library(Book book)
        {
            this.book = book;
        }

        /// <summary>
        /// Користувацький конструктор
        /// </summary>
        /// <param name="author">автор</param>
        /// <param name="nameBook">назва книги</param>
        public Library(string author, string nameBook)
        {
            book.Author = author;
            book.BookName = nameBook;
        }
    }
}
