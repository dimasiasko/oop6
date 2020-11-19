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
                    adress.index = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите страну: ");
                    adress.country = Console.ReadLine();

                    Console.WriteLine("Введите город: ");
                    adress.city = Console.ReadLine();
                    Console.WriteLine("Введите улицу: ");
                    adress.street = Console.ReadLine();

                    Console.WriteLine("Введите номер дома: ");
                    adress.house = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите номер квартиры: ");
                    adress.apartment = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Страна: {adress.country}, город: {adress.city}, индекс: {adress.index}, номер дома: {adress.house}, номер комнаты: {adress.apartment}");
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