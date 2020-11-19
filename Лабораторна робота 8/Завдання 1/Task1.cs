using System;
using System.Collections.Generic;
using System.Text;

namespace Завдання_1
{
    class Task1
    {
        public string x = "string X";
        public string y = "string Y";

        public string this[int index]
        {
            get
            {
                if (index == 0) return x;
                if (index == 1) return y;
                else
                    return "Введите верный индекс";
            }

        }
    }
}
