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
        //Создаем глобальные переменные массива строкового типа, для сохранения названий треков и пути к ним
        String[] files;
        String[] paths;
        
        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            // код для кнопки выбора треков
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // для выбора нескольких файлов
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                files = openFileDialog.SafeFileNames; // Сохраняет имена файлов в массив 
                paths = openFileDialog.FileNames; // Сохраняет пути к трекам в массив

                label1.Hide(); // скрывает текст

                // Отобразить имена треков в листбоксе
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]); // отображаем треки в листбоксе
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
              e.Effect = DragDropEffects.Copy;        // эффект перетаскивания файлов       
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

        private void listBoxSongs_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void listBoxSongs_MouseDown(object sender, MouseEventArgs e)
        {

        }
        
        private void listBoxSongs_PreviewKeyDown(object sender,  PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                listBoxSongs.Items.RemoveAt(listBoxSongs.SelectedIndex);
                
            }
            
        }
    }
}
