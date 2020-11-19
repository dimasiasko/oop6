using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_5
{
    
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите ваш логин:");
                    string login = Console.ReadLine();

                    DateTime BDate = DateTime.Now;

                    Console.WriteLine("Введите ваше имя:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Введите вашу фамилию:");
                    string surname = Console.ReadLine();

                    Console.WriteLine("Введите ваш возраст:");
                    int age = int.Parse(Console.ReadLine());

                    User user = new User(login, name, surname, age, BDate);
                    Console.WriteLine($"Ваг логин: {user.Login}, имя: {user.Name}, фамилия: {user.Surname}, возраст: {user.Age}, дата заполнения анкеты: {BDate}");
                }
                catch (Exception)
                {
                    return;
                }
                
            }
           
        }
    }
}
