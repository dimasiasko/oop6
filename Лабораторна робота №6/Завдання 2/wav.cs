using System;
using System.Collections.Generic;
using System.Text;

namespace Завдання_2
{
    class wav : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Файл .wav может проигрываться");
        }
        public void Record()
        {
            Console.WriteLine("Файл .wav может записываться");
        }

        public void Pause()
        {
            Console.WriteLine("Файл .wav может ставиться на паузу");
        }

        public void Stop()
        {
            Console.WriteLine("Файл .wav может стоппаться");
        }
    }
}
