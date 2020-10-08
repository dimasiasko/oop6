using System;
using System.Collections.Generic;
using System.Text;

namespace Завдання_3
{
    class Matrix
    {
        public int size;
        public Matrix(int sz)
        {
            this.size = sz;
        }
        public virtual void createMatrix()
        {
            int[,] mas = new int[size, size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    mas[i, j] = rnd.Next(0, 9);
                    Console.Write(mas[i, j] + "\t");
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
