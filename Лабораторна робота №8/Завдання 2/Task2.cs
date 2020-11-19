using System;
using System.Collections.Generic;
using System.Text;

namespace Завдання_2
{
    class Task2
    {
        public DateTime dateTime;

        public Task2(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public DateTime this[int index]
        {
            get
            {
                if (index > 0)
                    return dateTime.AddDays(index);
                else if (index < 0)
                    return dateTime.AddDays(index);
                else
                    return dateTime;
            }
        }
    }
}
