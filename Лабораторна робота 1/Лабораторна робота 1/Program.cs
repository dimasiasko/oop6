using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_1
{
    class Adress
    {
        public int index { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int house { get; set; }
        public int apartment { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress();
            Console.WriteLine("Введите индекс: ");
            adress.index = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите страну: ");
            adress.country = Console.ReadLine();

            Console.WriteLine("Введите город: ");
            adress.city = Console.ReadLine();
            Console.WriteLine("Введите улицу: ");
            adress.street = Console.ReadLine();

            Console.WriteLine("Введите номер дома: ");
            adress.house = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите номер дома: ");
            adress.apartment = int.Parse(Console.ReadLine());

            Console.WriteLine($"Страна: {adress.country}, город: {adress.city}, индекс: {adress.index}, номер дома: {adress.house}, номер комнаты: {adress.apartment}");
        }
    }
}