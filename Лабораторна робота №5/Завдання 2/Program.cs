using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите высоту вашего конуса(H): ");
                    double height = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите радиус основания вашего конуса(R): ");
                    double radius = double.Parse(Console.ReadLine());

                    Console.WriteLine("Выберите опцию: ");
                    Console.WriteLine("1. Объем и площадь конуса");
                    Console.WriteLine("2. Объем и пощадь усеченного конуса");
                    int option = int.Parse(Console.ReadLine());
                    try
                    {
                        if (option == 1)
                        {
                            Cone cone = new Cone(height, radius);
                            cone.Volume();
                            cone.Area();
                            return;
                        }
                        else if (option == 2)
                        {
                            Console.WriteLine("Введите радиус верхнего основания: ");
                            double smallR = double.Parse(Console.ReadLine());

                            Frustum frustum = new Frustum(height, radius, smallR);
                            frustum.Area();
                            frustum.Volume();
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Введите 1 или 2 !!!");
                            continue;
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Введите число");
                        continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите числоs!");
                    continue;
                }              
            }
            Console.ReadKey();
        }
    }
}
