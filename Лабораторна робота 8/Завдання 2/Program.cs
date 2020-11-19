using System;

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
                    Console.WriteLine("Введите год: ");
                    bool boolyears = int.TryParse(Console.ReadLine(), out int year);
                    if (!boolyears && year > 2020)
                    {
                        Console.WriteLine("\nВы живете в 2020 ;)\n");
                        continue;
                    }

                    Console.WriteLine("Введите месяц(от 1 до 12):");
                    bool boolmonths = int.TryParse(Console.ReadLine(), out int months);
                    if (!boolmonths && months > 12)
                    {
                        Console.WriteLine("\nВ году 12 месяцев!\n");
                        continue;
                    }

                    Console.WriteLine("Введите день(от 1 до 31): ");
                    bool boolday = int.TryParse(Console.ReadLine(), out int day);
                    if (!boolday && day > 31 && day < 1)
                    {
                        Console.WriteLine("\nВ месяце до 31 дня!\n");
                        continue;
                    }

                    DateTime dateTime = new DateTime(year, months, day);

                    Task2 task2 = new Task2(dateTime);

                    Console.WriteLine("Сколько дней вы хотите добавить или отнять?");
                    bool plusdays = int.TryParse(Console.ReadLine(), out int daystoadd);
                    if (plusdays)
                    {
                        Console.WriteLine($"Новая дата: {task2[daystoadd]}");
                    }
                    
                }
                catch (Exception)
                {
                    continue;
                }
                

            }
            
        }
    }
}
