using System;

namespace Завдання_2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите количество столбцов: ");
                bool parseColumns = int.TryParse(Console.ReadLine(), out int columns);

                Console.WriteLine("Введите количество рядов: ");
                bool parseRows = int.TryParse(Console.ReadLine(), out int rows);
                if (!(parseColumns && parseRows))
                    continue;
                
                MyMatrix myMatrix = new MyMatrix(columns, rows);

                myMatrix.FillInMatrix();
                myMatrix.ShowMatrix();

                Console.WriteLine("\n" + new string('/', 25));

                Console.WriteLine($"Размер матрицы: {myMatrix.Columns}х{myMatrix.Rows}");

                Console.WriteLine("\n" + new string('/', 25));


                Console.WriteLine("Введите новое количество столбцов: ");
                bool parseColumns2 = int.TryParse(Console.ReadLine(), out int columnsNew);

                Console.WriteLine("Введите новое количество рядов: ");
                bool parseRows2 = int.TryParse(Console.ReadLine(), out int rowsNew);

                if (!(parseColumns2 && parseRows2))
                    continue;
                myMatrix.ChangeMatrix(columnsNew, rowsNew);
                myMatrix.FillInMatrix();
                myMatrix.ShowMatrix();

                Console.WriteLine("\n" + new string('/', 25));

                Console.WriteLine($"Размер новой матрицы: {myMatrix.Columns}х{myMatrix.Rows}");

                Console.WriteLine("\n" + new string('/', 25));

                Console.WriteLine("Сейчас попробуем обратиться к индексу, которого не существует и существует");
                myMatrix[myMatrix.Columns + 5, myMatrix.Rows + 5] = 228;
            }
            
        }
    }
}
