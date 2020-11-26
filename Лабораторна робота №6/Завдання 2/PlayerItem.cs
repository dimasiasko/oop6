using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Завдання_2
{
    class PlayerItem:IMedia
    {
        public string[] media;
        public int MediaLenght
        {
            get { return media.Length; }
        }

        public string this[int index]
        {
            get { return Path.GetFileNameWithoutExtension(media[index]); }
        }
        public void InitalizeMedia()
        {
            media = Directory.GetFiles(@"D:\oop6\Лабораторна робота №6\Завдання 2\media\");

            var dir = new DirectoryInfo(@"D:\oop6\Лабораторна робота №6\Завдання 2\media\");  

            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine(Path.GetFileNameWithoutExtension(file.FullName));
            }
        }

        
    }
}
