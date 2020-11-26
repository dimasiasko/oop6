using System;
using System.Collections.Generic;
using System.Text;

namespace Завдання_2
{
    class mp3 : IRecordable
    {
        public void Record()
        {
            Console.WriteLine("Файл .mp3 может записываться");
        }

        public void Pause()
        {
            Console.WriteLine("Файл .mp3 может ставиться на паузу");
        }

        public void Stop()
        {
            Console.WriteLine("Файл .mp3 может стоппаться");
        }
    }
}
