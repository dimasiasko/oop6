using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace завдання_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя фигуры: ");
            string name = Console.ReadLine();

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите количество вершин фигуры: ");
                    int number = int.Parse(Console.ReadLine());
                    if (number <= 0)
                    {
                        Console.WriteLine("Это уже не фигура :)");
                        continue;
                    }
                    else if (number == 1)
                    {
                        Console.WriteLine("Это точка :)");
                        continue;
                    }
                    else if (number == 2)
                    {
                        Console.WriteLine("А это отрезок)");
                        continue;
                    }

                    Console.WriteLine("Введите координату первой точки: ");
                    int pointA = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите координату второй точки: ");
                    int pointB = int.Parse(Console.ReadLine());

                    Figure figure = new Figure(pointA, pointB, number, name);

                    figure.PerimeterCalculator();
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }
    }
}
