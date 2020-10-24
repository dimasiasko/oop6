using System;
using System.Collections.Generic;
using System.Text;

namespace Завдання_1
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XML-file Opened");
        }
        public override void Create()
        {
            Console.WriteLine("XML-file Created");
        }
        public override void Change()
        {
            Console.WriteLine("XML-file Changed");
        }
    }
}
