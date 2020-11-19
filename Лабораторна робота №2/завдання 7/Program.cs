using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_7
{
    class Employee
    {   

        public double salary;
        public double tax;
        public int position;
        public string name;
        public string surname;
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public void Salary ()
        {
            Console.WriteLine("Выберите вашу должность: ");
            Console.WriteLine("1. Кассир");
            Console.WriteLine("2. Менеджер");
            Console.WriteLine("3. Уборщик");
            Console.WriteLine("4. Администратор");

            position = int.Parse(Console.ReadLine());
            
            Step1:
            if (position == 1)
            {
                salary = 5000;
                
                Console.WriteLine("Введите ваш стаж в месяцах: ");
                int exp = int.Parse(Console.ReadLine());

                double newsalary = salary + (exp * 10);
                tax = newsalary * 0.18;

                Console.WriteLine($"Имя: {name}, Фамилия: {surname}, Должность: {position}, Стаж: {exp}");
                Console.WriteLine($"Ваша зарплата без налога: {newsalary}");
                Console.WriteLine($"Налог(18%): {tax}");
                Console.WriteLine($"Конечная сумма: {newsalary - tax}");

            }
            else if (position == 2)
            {
                salary = 7200;

                Console.WriteLine("Введите ваш стаж в месяцах: ");
                int exp = int.Parse(Console.ReadLine());

                double newsalary = salary + (exp * 10);
                tax = newsalary * 0.18;

                Console.WriteLine($"Имя: {name}, Фамилия: {surname}, Должность: {position}, Стаж: {exp}");
                Console.WriteLine($"Ваша зарплата без налога: {newsalary}");
                Console.WriteLine($"Налог(18%): {tax}");
                Console.WriteLine($"Конечная сумма: {newsalary - tax}");
            }
            else if (position == 3)
            {
                salary = 3500;

                Console.WriteLine("Введите ваш стаж в месяцах: ");
                int exp = int.Parse(Console.ReadLine());

                double newsalary = salary + (exp * 10);
                tax = newsalary * 0.18;

                Console.WriteLine($"Имя: {name}, Фамилия: {surname}, Должность: {position}, Стаж: {exp}");
                Console.WriteLine($"Ваша зарплата без налога: {newsalary}");
                Console.WriteLine($"Налог(18%): {tax}");
                Console.WriteLine($"Конечная сумма: {newsalary - tax}");
            }
            else if (position == 4)
            {
                salary = 8900;

                Console.WriteLine("Введите ваш стаж в месяцах: ");
                int exp = int.Parse(Console.ReadLine());

                double newsalary = salary + (exp * 10);
                tax = newsalary * 0.18;

                Console.WriteLine($"Имя: {name}, Фамилия: {surname}, Должность: {position}, Стаж: {exp}");
                Console.WriteLine($"Ваша зарплата без налога: {newsalary}");
                Console.WriteLine($"Налог(18%): {tax}");
                Console.WriteLine($"Конечная сумма: {newsalary - tax}");
            }
            else
            {
                Console.WriteLine("Выберите должность из списка!");
                goto Step1;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию: ");
            string surname = Console.ReadLine();

            Employee employee = new Employee(name,surname);
            employee.Salary();
        }
    }
}
