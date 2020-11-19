using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_7
{
    class Employee
    {
        public double Salary { get; set; }
        public double Tax { get; set; }
        public int Position { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public void SalaryCount()
        {
            Console.WriteLine("Выберите вашу должность: ");
            Console.WriteLine("1. Кассир");
            Console.WriteLine("2. Менеджер");
            Console.WriteLine("3. Уборщик");
            Console.WriteLine("4. Администратор");

            Position = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш стаж в месяцах: ");
            int exp = int.Parse(Console.ReadLine());

            double newsalary = 0;
            
            if (Position == 1)
                Salary = 5000;
            else if (Position == 2)
                Salary = 7200;
            else if (Position == 3)
                Salary = 3500;
            else if (Position == 4)
                Salary = 8900;
            else
                Console.WriteLine("Выберите должность из списка!");

            newsalary = Salary + (exp * 10);
            Tax = newsalary * 0.18;

            Console.WriteLine($"Имя: {Name}, Фамилия: {Surname}, Должность: {Position}, Стаж: {exp}");
            Console.WriteLine($"Ваша зарплата без налога: {newsalary}");
            Console.WriteLine($"Налог(18%): {Tax}");
            Console.WriteLine($"Конечная сумма: {newsalary - Tax}");
        }
    }
}
