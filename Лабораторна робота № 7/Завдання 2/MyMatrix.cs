using System;
using System.Collections.Generic;
using System.Text;

namespace Завдання_2
{
    class MyMatrix
    {
        public int[,] matrix = null;
        public int columns;
        public int rows;

        public int Columns
        {
            get { return columns; }
        }

        public int Rows
        {
            get { return rows; }
        }

        public MyMatrix()
        {

        }

        public MyMatrix(int columns, int rows)
        {
            if (columns < 0 || rows < 0)
            {
                Console.WriteLine("Размер матрицы не может быть отрицательным!");
            }
            else
            {
                this.columns = columns;
                this.rows = rows;
                matrix = new int[columns, rows];
            }
        }

        public void FillInMatrix()
        {
            Random random = new Random();

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    matrix[i, j] = random.Next(-100, 100);
                }
            }
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void ChangeMatrix(int m, int n)
        {
            if (m < 0 || n < 0)
            {
                Console.WriteLine("Размер матрицы не может быть отрицательным!");
            }
            else
            {
                this.columns = m;
                this.rows = n;
                matrix = new int[columns, rows];
            }
        }

        public int this[int columnsind, int rowsind]
        {
            set
            {
                if ((columnsind > 0 && rowsind > 0) && (columnsind < columns && rowsind < rows))
                    matrix[columnsind, rowsind] = value;
                else
                    Console.WriteLine($"Невозможно обратиться к элементу с индексами {columnsind} и {rowsind}!");
            }
            get
            {
                return matrix[columnsind, rowsind];
            }
        }
    }
}
