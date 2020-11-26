using System;
using System.IO;

namespace Завдання_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Выполняется сканирование папки: ");
                    PlayerItem playerItem = new PlayerItem();
                    playerItem.InitalizeMedia();

                    Console.WriteLine("Выберите файл: ");
                    bool bParse = int.TryParse(Console.ReadLine(), out int selectedFile);

                    if (selectedFile <= playerItem.MediaLenght && bParse)
                    {
                        Console.WriteLine("Выбраный файл: " + playerItem[selectedFile - 1]);
                    }
                    else
                    {
                        Console.WriteLine("------------- Выберите вариант из списка -------------");
                        continue;
                    }

                    switch (Path.GetExtension(playerItem.media[selectedFile - 1]))
                    {
                        case ".mkv":
                            mkv mk = new mkv();
                            mk.Play();
                            mk.Pause();
                            mk.Stop();
                            break;
                        case ".mp3":
                            mp3 mp = new mp3();
                            mp.Record();
                            mp.Pause();
                            mp.Stop();
                            break;
                        case ".wav":
                            wav wv = new wav();
                            wv.Play();
                            wv.Record();
                            wv.Pause();
                            wv.Stop();
                            break;
                    }
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.WriteLine("Можете выбрать заново!)");
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка");
                    continue;
                }
            }
            

        }
    }
    
}
