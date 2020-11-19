using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_7
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию: ");
            string surname = Console.ReadLine();

            Employee employee = new Employee(name,surname);
            employee.SalaryCount();
        }
    }
}
