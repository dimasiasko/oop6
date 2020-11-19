using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_5
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        DateTime BDate { get; set; }

        public User(string login, string name, string surname, int age, DateTime BDate)
        {
            this.Login = login;
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.BDate = DateTime.Now;
        }
    }
}
