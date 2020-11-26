using System;
using System.Collections.Generic;
using System.Text;

namespace Завдання_2
{
    class mkv : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Файл .mkv может проигрываться");
        }
        public void Pause()
        {
            Console.WriteLine("Файл .mkv может ставиться на паузу");
        }

        public void Stop()
        {
            Console.WriteLine("Файл .mkv может стоппаться");
        }
    }
}
