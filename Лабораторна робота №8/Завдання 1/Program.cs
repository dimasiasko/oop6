using System;

namespace Завдання_1
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Task1  task1 = new Task1();
            Console.WriteLine("Обращаемся к элементу по индексу 0: " + task1[0]);
            Console.WriteLine("Обращаемся к элементу по индексу 1: " + task1[1]);
            Console.WriteLine("Обращаемся к элементу по индексу 5: " + task1[5]);

        }
    }
}
