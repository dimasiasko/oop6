using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_1
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress();
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите индекс: ");
                    adress.Index = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите страну: ");
                    adress.Country = Console.ReadLine();

                    Console.WriteLine("Введите город: ");
                    adress.City = Console.ReadLine();
                    Console.WriteLine("Введите улицу: ");
                    adress.Street = Console.ReadLine();

                    Console.WriteLine("Введите номер дома: ");
                    adress.House = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите номер квартиры: ");

                    adress.Apartment = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Страна: {adress.Country}, город: {adress.City}, индекс: {adress.Index}, номер дома: {adress.House}, номер комнаты: {adress.Apartment}");
                    Console.WriteLine();
                    Console.WriteLine("Попробуйте еще\n");
                }
                catch (Exception)
                {
                    continue;
                }
                
                
            }
            

            
        }
    }
}