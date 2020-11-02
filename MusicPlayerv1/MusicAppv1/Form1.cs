using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace MusicAppv1
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
            listBoxSongs.Text = "";
        }

        //Создаем глобальные списки типа стринг, для сохранения названий треков и пути к ним
        
        List<string> files = new List<string>();
        List<string> paths = new List<string>();

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            // код для кнопки для выбора треков
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\"; // изначальная папка в окне

            openFileDialog.Filter = "All Supported Audio (*.mp3;...) | *.mp3; *.wav; | All files (*.*) | *.*"; // фильтр для лучшего поиска музыки                   
            openFileDialog.Title = "Выберите свою музыку"; // установка имени диалогового окна

            // для выбора нескольких файлов
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // временные массивы для сохранения имени и пути выбраных файлов
                string[] filesNew = openFileDialog.SafeFileNames;
                string[] pathsNew = openFileDialog.FileNames;

                // добавление в наш список в конец выбраные элементы 
                for (int i = 0; i < filesNew.Length; i++)
                {
                    files.Add(filesNew[i]);
                    paths.Add(pathsNew[i]);
                }

                labelChoosing.Hide(); // скрывает текст


                for (int i = 0; i < filesNew.Length; i++)
                {
                    switch (Path.GetExtension(pathsNew[i])) // проверка входящего формата
                    {
                        case ".mp3":
                        case ".wav":
                            listBoxSongs.Items.Add(Path.GetFileNameWithoutExtension(filesNew[i])); // Отобразить имена треков в листбоксе
                            break;
                        default:
                            MessageBox.Show($"Файл {filesNew[i]} имеет неверный формат !");
                            break;
                    }
                }             
            }
            else if (openFileDialog.ShowDialog() ==  DialogResult.Cancel)
            {
                MessageBox.Show("Выберите файлы для проигрывания!");
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Код, который закрывает программу
            Application.Exit(); 
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // код который проигрывает музыку     
            
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];           
        }

        private void listBoxSongs_DragEnter(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
              e.Effect = DragDropEffects.Copy; // эффект перетаскивания файлов       
            } 
        }
        private void label1_DragEnter(object sender, DragEventArgs e)
        {
            labelChoosing.Hide();
            
            btnSelectSongs_Click(sender, e); // при перетаскивании файлов вызывает окно выбора файлов
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            btnSelectSongs_Click(sender, e); // двойной клик на надпись вызывает выбор файлов
        }


        // 4  следующих метода которые реализируют перемещение окна
        // при удерживании кнопки мыши на панеле 
        
        //////////////////////////////////////////////////////
        Point lastPoint;
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MusicPlayerApp_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MusicPlayerApp_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }



        ///////////////////////////////////////////

        

        private void listBoxSongs_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedIndex == -1)            
                listBoxSongs.SelectedIndex = 0;                     
        }
        
       
        // клик по кнопке - играть, анимация нажатия
        private void PlayButton_Click(object sender, EventArgs e)
        {
            
            axWindowsMediaPlayerMusic.Ctlcontrols.play();
        }

        private void PlayButton_MouseDown(object sender, MouseEventArgs e)
        {
            PlayButton.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PlayButton_MouseUp(object sender, MouseEventArgs e)
        {
            PlayButton.BorderStyle = BorderStyle.FixedSingle;
        }
        
        // клик по кнопке - стоп, анимация нажатия
        private void StopButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayerMusic.Ctlcontrols.pause();
        }
        private void StopButton_MouseDown(object sender, MouseEventArgs e)
        {
            PauseButton.BorderStyle = BorderStyle.Fixed3D;
        }

        private void StopButton_MouseUp(object sender, MouseEventArgs e)
        {
            PauseButton.BorderStyle = BorderStyle.FixedSingle;
        }

        // метод для следующих треков (в том числе и при нажатой кнопке "рандом") в плейлисте и - анимация нажатия
       
        List<int> tempIndex = new List<int>();
        
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (mixTracksButton.BorderStyle == BorderStyle.FixedSingle)
            {
                if ((listBoxSongs.SelectedIndex + 1) >= paths.Count)
                {
                    listBoxSongs.SelectedIndex = 0;
                    axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
                }
                else
                {
                    axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex + 1];
                    listBoxSongs.SelectedIndex += 1;
                }
            }
            else
            {
                Random rnd = new Random();
                int nowPlayIndex = rnd.Next(paths.Count);

                tempIndex.Add(nowPlayIndex);
                
                axWindowsMediaPlayerMusic.URL = paths[nowPlayIndex];
                listBoxSongs.SelectedIndex = nowPlayIndex;              
            }                       
        }

        private void NextButton_MouseDown(object sender, MouseEventArgs e)
        {
            NextButton.BorderStyle = BorderStyle.Fixed3D;
        }

        private void NextButton_MouseUp(object sender, MouseEventArgs e)
        {
            NextButton.BorderStyle = BorderStyle.FixedSingle;
        }

        int count = 2;
        // метод для предыдущих треков в плейлисте(и предыдущих в том числе) и - анимация нажатия
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (mixTracksButton.BorderStyle == BorderStyle.FixedSingle)
            {
                if ((listBoxSongs.SelectedIndex - 1) == -1)
                {
                    listBoxSongs.SelectedIndex = paths.Count - 1;
                    axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
                }
                else
                {
                    axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex - 1];
                    listBoxSongs.SelectedIndex -= 1;
                }
            }
            else
            {           
                int[] lastPlayIndex = tempIndex.ToArray();
                listBoxSongs.SelectedIndex = lastPlayIndex[tempIndex.Count- count];
                axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
                while (tempIndex.Count > count)
                {
                    count++;
                }              
            }
        }

        private void PreviousButton_MouseDown(object sender, MouseEventArgs e)
        {
            PreviousButton.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PreviousButton_MouseUp(object sender, MouseEventArgs e)
        {
            PreviousButton.BorderStyle = BorderStyle.FixedSingle;
        }

        // автоматическое переключения треков на следующий при заканчивании проигрывания
        private void timerPlaying_Tick(object sender, EventArgs e)
        {
            timerPlaying.Enabled = false;
            NextButton_Click(sender, e);
        }

        private void axWindowsMediaPlayerMusic_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                timerPlaying.Enabled = true;
            }
        }

        // вызов контекстного меню при нажатии ИМЕННО на элемент правой кнопкой мыши
        private void listBoxSongs_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBoxSongs.SelectedIndex == -1)
            {
                listBoxSongs_Click(sender, e);
            }
            if (e.Button == MouseButtons.Right)
            {
                Rectangle itemRect = listBoxSongs.GetItemRectangle(listBoxSongs.SelectedIndex);
                if (itemRect.Contains(e.Location))
                {
                    Point point = MousePosition;
                    contextMenu.Show(point);
                }            
            }                      
        }

        // клик по кнопке перемешать треки
        private void mixTracksButton_Click(object sender, EventArgs e)
        {
            if (mixTracksButton.BorderStyle == BorderStyle.FixedSingle)
            {
                mixTracksButton.BorderStyle = BorderStyle.Fixed3D;
                tempIndex.Add(listBoxSongs.SelectedIndex);
            }
            else
            {
                mixTracksButton.BorderStyle = BorderStyle.FixedSingle;
            }            
        }

        // удаление элементов в листбоксе
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxSongs.SelectedIndex;
            
            if (listBoxSongs.Items.Count != 1)
            {

                listBoxSongs.SelectedIndex = 0;
                


                paths.RemoveAt(index);
                files.RemoveAt(index);
                listBoxSongs.Items.RemoveAt(index);

                for (int i = index; i < files.Count - index; i++)
                {
                    paths[i] = paths[i + 1];
                    files[i] = files[i + 1];
                    listBoxSongs.Items[i] = listBoxSongs.Items[i + 1];

                }

            }
            else
            {
                listBoxSongs.Items.Clear();
                paths.Clear();
                files.Clear();
            }
            
            
        }
        //удаления для клавишы DELETE
        private void listBoxSongs_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Delete && listBoxSongs.Items.Count > 0)
                buttonDelete_Click(sender, e);
        }
    }
}
