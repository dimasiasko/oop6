using System;
using System.Collections.Generic;
using System.Text;

namespace Завдання_1
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT-file Opened");
        }
        public override void Create()
        {
            Console.WriteLine("TXT-file Created");
        }
        public override void Change()
        {
            Console.WriteLine("TXT-file Changed");
        }
    }
}
