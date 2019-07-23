using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// окремим файлом, більш всього напевне малось на увазі, що бібліотека dll

namespace Books
{
    /// <summary>
    /// Книжка
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Автор
        /// </summary>
        private string author;
        /// <summary>
        /// Назва книги
        /// </summary>
        private string bookName;

        /// <summary>
        /// Автор
        /// </summary>
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        /// <summary>
        /// Назва книги
        /// </summary>
        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
    }
}
