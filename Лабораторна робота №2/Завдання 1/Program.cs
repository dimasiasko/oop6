using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_1
{
    class Adress
    {
        public int index;
        public int Index
        {
            get { return index; }
            set
            {
                index = value;
            }
        }

        public string country
        public string Country
        {
            get { return country; }
            set
            {
                country = value;
            }
        }

        public string city;
        public string City
        {
            get { return city; }
            set
            {
                city = value
            }
        }

        public string street;
        public string Street
        {
            get { return street; }
            set
            {
                street = value;
            }
        }

        public int house;
        public string House
        {
            get { return house; }
            set
            {
                house = value;
            }
        }

        public int apartment;
        public int Apartment
        {
            get { return apartment; }
            set
            {
                apartment = value;
            }
        }
    }

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

                    Console.WriteLine("Введите номер дома: ");
                    adress.apartment = int.Parse(Console.ReadLine());
                    return;
                }
                catch (Exception e)
                {
                    continue;
                }
               
            }
            

            Console.WriteLine($"Страна: {adress.country}, город: {adress.city}, индекс: {adress.index}, номер дома: {adress.house}, номер комнаты: {adress.apartment}");
        }
    }
}