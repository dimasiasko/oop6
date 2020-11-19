using System;

namespace Завдання_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите ваш документ: ");
                Console.WriteLine("1. EXCEL-файл");
                Console.WriteLine("2. WORD-файл");
                Console.WriteLine("3. БЛОКНОТ-файл");
                bool input = int.TryParse(Console.ReadLine(), out int result);
                if (input)
                {
                    if (result == 1)
                    {
                        AbstractHandler xml = new XMLHandler();

                        xml.Open();
                        xml.Change();
                        xml.Create();
                        return;
                    }
                    if (result == 2)
                    {
                        AbstractHandler doc = new DOCHandler();
                        doc.Open();
                        doc.Change();
                        doc.Create();
                        return;
                    }
                    if (result == 3)
                    {
                        AbstractHandler txt = new TXTHandler();
                        txt.Open();
                        txt.Change();
                        txt.Create();
                        return;
                    }
                }
            }            
        }
    }
}
