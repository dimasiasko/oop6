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

                label1.Hide(); // скрывает текст


                for (int i = 0; i < filesNew.Length; i++)
                {
                    switch (Path.GetExtension(pathsNew[i])) // проверка входящего формата
                    {
                        case ".mp3":
                        case ".wav":
                            listBoxSongs.Items.Add(filesNew[i]); // Отобразить имена треков в листбоксе
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
            label1.Hide();
            
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

        ToolStripMenuItem menuItem = new ToolStripMenuItem("Удалить");
        
        private void listBoxSongs_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    if (e.Button == )
            //    {

            //    }
            //    contextMenuStrip1.Show();
            //}
            contextMenuStrip1.Items.Add(menuItem);
            if (e.Button == MouseButtons.Left && listBoxSongs.SelectedItem == null )
            {
                return;
            }
            if (e.Button == MouseButtons.Right)
            {
                if (listBoxSongs.SelectedItem == null) return;

                Rectangle itemRect = listBoxSongs.GetItemRectangle(listBoxSongs.SelectedIndex);
                if (itemRect.Contains(e.Location))
                {
                    contextMenuStrip1.Show();
                }
                
                
            }
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
