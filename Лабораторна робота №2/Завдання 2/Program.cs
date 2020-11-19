using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace завдання_2
{

    class Program
    {
        static void Main(string[] args)
        {
            double number;
            double number2;

            Step1:
            Console.WriteLine("Введите ширину: ");
            bool width = double.TryParse(Console.ReadLine(), out number);

            if (!width)
            {
                Console.WriteLine("Введите число!");
                goto Step1;
            }

            Step2:
            Console.WriteLine("Введите длину: ");
            bool lenght = double.TryParse(Console.ReadLine(), out number2);

            if (!lenght)
            {
                Console.WriteLine("Введите число!");
                goto Step2;
            }

            Rectangle rectangle = new Rectangle(number, number2);

            Console.WriteLine($"Площадь прямоугольника: {rectangle.AreaCalculator()}");
            Console.WriteLine($"Периметр прямоугольника: {rectangle.PerimeterCalculator()}");
        }
    }
}