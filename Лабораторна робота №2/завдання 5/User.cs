using System;
using System.Collections.Generic;
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
        DateTime BDate { get; set; }
        public User(string login, string name, string surname, int age, DateTime BDate)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.BDate = DateTime.Now;
        }
    }
}
