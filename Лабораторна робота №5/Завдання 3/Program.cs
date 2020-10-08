using System;

namespace Завдання_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите размерность матрицы: ");
                    int sizeMatrix = int.Parse(Console.ReadLine());

                    Console.WriteLine("Выберите опцию: ");
                    Console.WriteLine("1. Обычная рандомная матрица");
                    Console.WriteLine("2. Единичная рандомная матрица");
                    Console.WriteLine("3. Верхняя треугольная матрица");
                    int option = int.Parse(Console.ReadLine());
                    try
                    {
                        if (option == 1)
                        {
                            Matrix matrix = new Matrix(sizeMatrix);
                            matrix.createMatrix();
                            return;
                            
                        }
                        else if (option == 2)
                        {
                            IdentityMatrix identity = new IdentityMatrix(sizeMatrix);
                            identity.createMatrix();
                            return;
                        }
                        else if (option == 3)
                        {
                            TriangularMatrix triangularMatrix = new TriangularMatrix(sizeMatrix);
                            triangularMatrix.createMatrix();                 
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Введите 1 или 2 или 3 !!!");
                            continue;
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Введите целое число");
                        continue;
                    }
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите целое число!");
                    continue;
                }
            }
        }
    }
}
