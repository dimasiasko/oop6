using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace завдання_2
{
    class Rectangle
    {
        public double side1 = 0.0d;
        public double side2 = 0.0d;
        public Rectangle(double s1, double s2)
        {
            this.side1 = s1;
            this.side2 = s2;
        }
        
        public double AreaCalculator()
        {
            double area = side1 * side2;
            return area;
        }
        public double PerimeterCalculator()
        {
            double perimetr = (side1 + side2) * 2;
            return perimetr;
        }
        public double Area { get; }
        public double Perimeter { get; }
    }

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