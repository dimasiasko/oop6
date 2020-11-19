using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_6
{
    class Program
    {
        public static void Main(string[] args)
        {
            var converter = new Converter(28.17, 33.2, 0.31);

            while (true)
            {
                try
                {
                    Console.WriteLine("Выберыте опцию:");
                    Console.WriteLine("1: Конвертировать В гривну");
                    Console.WriteLine("2: Конвертировать ИЗ гривны");

                    double option;
                    bool chooseOption = double.TryParse(Console.ReadLine(), out option);

                    if (!chooseOption)
                    {
                        Console.WriteLine("Введите 1 или 2 !");
                        continue;
                    }
                    else
                    {
                        switch (option)
                        {
                            case 1:
                                ConvertTo(converter);
                                break;
                            case 2:
                                ConvertFrom(converter);
                                break;
                            default:
                                Console.WriteLine("Введите 1 или 2!");
                                continue;
                        }
                    }
                    Console.WriteLine("Готово");
                    Console.ReadKey();
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        private static void ConvertTo(Converter currencyConverter)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Выберите опцию:");
                    Console.WriteLine("1: Конвертировать в USD");
                    Console.WriteLine("2: Конвертировать в EUR");
                    Console.WriteLine("3: Конвертировать в RUB");

                    bool booloption = int.TryParse(Console.ReadLine(),out int option);
                    if (!booloption)
                    {
                        Console.WriteLine("Выберите из списка (1,2,3) !");
                        continue;
                    }

                    Console.WriteLine("Введите сумму");
                    bool boolinput = double.TryParse(Console.ReadLine(),out double input);
                    if (!boolinput || input < 0)
                    {
                        Console.WriteLine("Введите число и больше 0!");
                        continue;
                    }

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine(currencyConverter.FromUSD(input));
                            break;
                        case 2:
                            Console.WriteLine(currencyConverter.FromEUR(input));
                            break;
                        case 3:
                            Console.WriteLine(currencyConverter.FromRUB(input));
                            break;
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
            
        }

        private static void ConvertFrom(Converter currencyConverter)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Выберите опцию:");
                    Console.WriteLine("1: Конвертировать в USD");
                    Console.WriteLine("2: Конвертировать в EUR");
                    Console.WriteLine("3: Конвертировать в RUB");

                    bool booloption = int.TryParse(Console.ReadLine(), out int option);
                    if (!booloption)
                    {
                        Console.WriteLine("Выберите из списка (1,2,3) !");
                        continue;
                    }

                    Console.WriteLine("Введите сумму");
                    bool boolinput = double.TryParse(Console.ReadLine(), out double input);
                    if (!boolinput || input < 0)
                    {
                        Console.WriteLine("Введите число и больше 0!");
                        continue;
                    }

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine(currencyConverter.ToUSD(input));
                            break;
                        case 2:
                            Console.WriteLine(currencyConverter.ToEUR(input));
                            break;
                        case 3:
                            Console.WriteLine(currencyConverter.ToRUB(input));
                            break;
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