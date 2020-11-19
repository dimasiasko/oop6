using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_8
{
    class Invoice
    {
        public int Price { get; private set; }
        public string Customer { get; private set; }
        public string Provider { get; private set; }
        private string article;
        private int quantity;

        public Invoice(int acc, string cust, string prov, string artic, int quant)
        {
            this.Price = acc;
            this.Customer = cust;
            this.Provider = prov;
            this.article = artic;
            this.quantity = quant;
        }
        public double NDSprice()
        {
            double lastprice = Price * quantity;
            double NDSprice = lastprice - (lastprice * 0.175);
            return NDSprice;
        }
        public double WithoutNDSprice()
        {
            double lastprice = Price * quantity;
            
            return lastprice;
        }
    }
    class Program
    {
        static void Main(string[] args)
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
            {
                Console.WriteLine(invoice.NDSprice());
            }
            else if (option == 2)
            {
                Console.WriteLine(invoice.WithoutNDSprice()); 
            }
        }
    }
}
