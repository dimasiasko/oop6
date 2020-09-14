using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_6
{
    public class Converter
    {
        public double USD { get; }
        public double EUR { get; }
        public double RUB { get; }

        public Converter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }

        public double ToUSD(double value)
        {
            return value / USD;
        }

        public double ToEUR(double value)
        {
            return value / EUR;
        }

        public double ToRUB(double value)
        {
            return value / RUB;
        }

        public double FromUSD(double value)
        {
            return USD * value;
        }

        public double FromEUR(double value)
        {
            return EUR * value;
        }

        public double FromRUB(double value)
        {
            return RUB * value;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            var converter = new Converter(28.17, 33.2, 0.31);
            
            Step1:
            Console.WriteLine("Выберыте опцию:");
            Console.WriteLine("1: Конвертировать В гривну");
            Console.WriteLine("2: Конвертировать ИЗ гривны");


            double option;        
            bool chooseOption = double.TryParse(Console.ReadLine(), out option);

            if (!chooseOption)
            {
                Console.WriteLine("Введите 1 или 2 !");
                goto Step1;
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
                        goto Step1;
                }
            }

            

            Console.WriteLine("Готово");
            Console.ReadKey();
        }

        private static void ConvertTo(Converter currencyConverter)
        {
            Console.WriteLine("Выберите опцию:");
            Console.WriteLine("1: Конвертировать в USD");
            Console.WriteLine("2: Конвертировать в EUR");
            Console.WriteLine("3: Конвертировать в RUB");

            var option = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите сумму");

            var input = double.Parse(Console.ReadLine());

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

        private static void ConvertFrom(Converter currencyConverter)
        {
            Console.WriteLine("Выберите опцию:");
            Console.WriteLine("1: Конвертировать в USD");
            Console.WriteLine("2: Конвертировать в EUR");
            Console.WriteLine("3: Конвертировать в RUB");

            var option = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите сумму");

            var input = double.Parse(Console.ReadLine());

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
    }

}