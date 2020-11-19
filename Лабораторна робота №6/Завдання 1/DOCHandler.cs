using System;
using System.Collections.Generic;
using System.Text;

namespace Завдання_1
{
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOC-file Opened");
        }
        public override void Create()
        {
            Console.WriteLine("DOC-file Created");
        }
        public override void Change()
        {
            Console.WriteLine("DOC-file Changed");
        }
    }
}
