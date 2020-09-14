using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_5
{
    class User
    {
        public string login;
        public string name;
        public string surname;
        public int age;
        DateTime BDate { get;  set; }
        public User(string login, string name, string surname, int age, DateTime BDate)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.BDate = DateTime.Now;
        }
        



    }
    class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine($"Ваг логин: {user.login}, имя: {user.name}, фамилия: {user.surname}, возраст: {user.age}, дата заполнения анкеты: {BDate}");
        }
    }
}
