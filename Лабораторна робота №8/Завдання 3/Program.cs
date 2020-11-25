using System;
using System.Runtime.CompilerServices;

namespace Завдання_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 этап программы(массив int)\n");
            Console.WriteLine("Проверяем свойство:");

            IntArray intArray = new IntArray();
            Console.WriteLine("Размер массива = " + intArray.ArrayInts);

            Console.WriteLine("Теперь проверяем индексатор");
            intArray[5] = 24;
            Console.WriteLine("Присвоили элементу 24 и выводим его: " + intArray[5]);

            Console.WriteLine("========== 1 часть готова ==========\n");

            Console.WriteLine("2 этап программы(массив char)\n");

            Console.WriteLine("Проверяем свойство: ");

            DerivedArray derived = new DerivedArray();
            Console.WriteLine($"Размер массива int = {derived.PropertInts[0]}, char = {derived.PropertInts[1]}");

            Console.WriteLine("Теперь проверяем индексатор");

            derived['T'] = 'е';

            Console.WriteLine("Переводим англ алфавит в русский");
            Console.WriteLine($"Русская 'T' = {derived['T']}");
        }
    }
}
