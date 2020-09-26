using System;

namespace Завдання_4
{
    class ApplicationLicense
    {
        public void AllowTrial()
        {
            Console.WriteLine("Вам доступен ТРИАЛЬНЫЙ режим на 30 дней");
        }
        public void AllowCommon()
        {
            Console.WriteLine("Вам доступна БЕСПЛАТНАЯ версия"); 
        }
        public void AllowPro()
        {
            Console.WriteLine("Вам доступна ПОЛНАЯ ПЛАТНАЯ версия");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            while (i >= 0)
            {
                ApplicationLicense applicationLicense = new ApplicationLicense();

                string key;
                string code;
                
                    //коды доступа
                    //ПРО: 76BTVRO3HPD6
                    //ТРИАЛ: 6tr8nfyrlr30
                    //ФРИ: yf896eio0r21
                    Console.WriteLine("Введите ваш код доступа(12 символов): ");

                    key = Console.ReadLine();
                    code = key.ToUpper();

                if (code.Contains("P") && code.StartsWith("76") && code.Contains("R") && code.Contains("O"))
                {
                    applicationLicense.AllowPro();
                    break;
                }                     
                else if (code.Contains("T") && code.EndsWith("30") && code.Contains("L") && code.Contains("R"))
                {
                    applicationLicense.AllowTrial();
                    break;                   
                }                        
                else if (code.Contains("F") && code.EndsWith("21") && code.Contains("E") && code.Contains("R"))
                {
                    applicationLicense.AllowCommon();
                    break;
                }                       
                else
                {
                    Console.WriteLine("Неверный ключ");
                    if (i == 0)
                    {
                        Console.WriteLine("Блокировка АККАУНТА!");
                        break;
                    }
                    Console.WriteLine($"У вас еще {i} попыток, иначе АККАУНТ БЛОКИРУЕТСЯ");
                    i--;
                    continue;
                }               
            }
            
            Console.ReadKey();


        }
    }
}
