using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace завдання_3
{
    class Title
    {
        public string TitleBook { get; set; }
        public void Show()
        {
            Console.WriteLine($"Заголовок книжки: {TitleBook}");
        }
    }
}
