using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_3
{
    class Content
    {
        public string ContentBook { get; set; }
        public void Show()
        {
            Console.WriteLine($"О чем книга: {ContentBook}");
        }
    }
}
