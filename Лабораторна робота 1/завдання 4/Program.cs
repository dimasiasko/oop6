using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_4
{
    class Point
    {
        public string field;
        public int number1;
        public int number2;

        public int Number1
        {
            get
            {
                return number1;
            }
        }
        public int Number2
        {
            get
            {
                return number2;
            }
        }
        public string Field
        {
            get
            {
                return field;
            }
        }

        public Point()
            : this("", 0, 0) { }

        public Point(string field, int number1, int number2)
        {
            Console.WriteLine("Введите Point:");
            this.field = Console.ReadLine();

            Console.WriteLine("Введите первое число: ");
            this.number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            this.number2 = int.Parse(Console.ReadLine());
        }
    }
    class Figure
    {
        int number;
        Point[] points;
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void InitializeFigure()
        {
            Console.WriteLine("Введите количество вершин фигуры: ");
            number = int.Parse(Console.ReadLine());

            points = new Point[number];
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point();
            }

        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.number1 - b.number1, 2) + Math.Pow(a.number2 - b.number2, 2));
        }

        public double CalculatePerimeter()
        {
            double perimeter = 0;
            for (int i = 1; i < points.Length; i++)
            {
                perimeter += this.LengthSide(points[i - 1], points[i]);
            }
            perimeter += this.LengthSide(points[0], points[points.Length - 1]);
            return perimeter;
        }
        public Figure(string name)
        {
            InitializeFigure();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Figure cube = new Figure("cube");
            Console.WriteLine(cube.CalculatePerimeter());
            Console.ReadKey();
        }
    }
}
