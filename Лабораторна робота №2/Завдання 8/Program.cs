using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_8
{
    
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите цену за 1 количество: ");
                    int account = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите имя покупателя: ");
                    string customer = Console.ReadLine();

                    Console.WriteLine("Введите имя поставщика: ");
                    string provider = Console.ReadLine();

                    Console.WriteLine("Введите артикул товара: ");
                    string article = Console.ReadLine();

                    Console.WriteLine("Введите количество товара: ");
                    int quantity = int.Parse(Console.ReadLine());


                    Invoice invoice = new Invoice(account, customer, provider, article, quantity);

                    Console.WriteLine("Узнать цену:");
                    Console.WriteLine("1. С НДС");
                    Console.WriteLine("2. Без НДС");

                    int option = int.Parse(Console.ReadLine());
                    if (option == 1)
                        Console.WriteLine(invoice.NDSprice());
                    else if (option == 2)
                        Console.WriteLine(invoice.WithoutNDSprice());
                    else
                        Console.WriteLine("Введите 1 или 2 !");
                }
                catch (Exception)
                {
                    continue;
                }
                
            }
            
            
        }
    }
}
