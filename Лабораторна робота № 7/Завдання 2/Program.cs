using System;

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
                    matrix[columns, rows] = random.Next(-100, 100);
                }
            }
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.WriteLine(matrix[i,j] + "\t");
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количетво столбцов:");
            
        }
    }
}
