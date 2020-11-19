using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_3
{
    class Title
    {
        public string TitleBook { get; set; }
        public void Show()
        {
            Console.WriteLine($"Заголовок книжки: {TitleBook}");
        }
    }
    class Author
    {
        public string AuthorName { get; set; }
        public void Show()
        {
            Console.WriteLine($"Псевдоним автора: {AuthorName}");
        }
    }
    
    class Content
    {
        public string ContentBook { get; set; }
        public void Show()
        {
            Console.WriteLine($"О чем книга: {ContentBook}");
        }
    }
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите псевдоним: ");
            string author = Console.ReadLine();

            Console.WriteLine("Введите название книги: ");
            string title = Console.ReadLine();

            Console.WriteLine("О чем эта книга?: ");
            string content = Console.ReadLine();

            Book book = new Book(author, title, content);
            book.Show();           
        }
    }
}
