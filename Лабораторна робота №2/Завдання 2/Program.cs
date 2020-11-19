using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Завдання_2;


namespace завдання_2
{

    class Program
    {
        static void Main(string[] args)
        {
            double number;
            double number2;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите ширину: ");
                    bool width = double.TryParse(Console.ReadLine(), out number);

                    if (!width)
                        Console.WriteLine("Введите число!");

                    Console.WriteLine("Введите длину: ");
                    bool lenght = double.TryParse(Console.ReadLine(), out number2);

                    if (!lenght)
                        Console.WriteLine("Введите число!");

                    Rectangle rectangle = new Rectangle(number, number2);

                    Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}");
                    Console.WriteLine($"Периметр прямоугольника: {rectangle.Perimeter}");
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    continue;
                } 
            }
            
        }
    }
}