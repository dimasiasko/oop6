using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_3
{
    class Book
    {
        public Title ThisTitle { get; set; }
        public Author ThisAuthor { get; set; }

        public Content ThisContent { get; set; }
        public void Show()
        {

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            ThisTitle.Show();

            Console.ForegroundColor = ConsoleColor.Blue;
            ThisAuthor.Show();

            Console.ForegroundColor = ConsoleColor.Red;
            ThisContent.Show();
        }

        public Book(string AuthorName, string TitleBook, string ContentBook)
        {
            ThisAuthor = new Author();
            ThisTitle = new Title();
            ThisContent = new Content();

            ThisAuthor.AuthorName = AuthorName;
            ThisContent.ContentBook = ContentBook;
            ThisTitle.TitleBook = TitleBook;
        }

        public Book()
        {
            ThisAuthor = new Author();
            ThisTitle = new Title();
            ThisContent = new Content();
        }
    }
}
