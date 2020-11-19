using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
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
                catch (Exception)
                {
                    continue;
                }
                
            }
                       
        }
    }
}
