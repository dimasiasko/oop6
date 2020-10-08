using System;
using System.Collections.Generic;
using System.Text;

namespace Завдання_3
{
    class TriangularMatrix : Matrix
    {
        public TriangularMatrix(int sz)
            : base(sz) { }

        public override void createMatrix()
        {
            int[,] mas = new int[size, size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i >= j)
                    {
                        mas[i, j] = 0;                        
                        Console.Write(mas[i, j] + "\t");
                    }
                    else
                    {
                        mas[i, j] = rnd.Next(0, 9);
                        Console.Write(mas[i, j] + "\t");
                    }
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    sum += mas[i, j];

                }

            }
            Console.WriteLine($"Подсчет матрицы = {sum}");
        }
    }
}
