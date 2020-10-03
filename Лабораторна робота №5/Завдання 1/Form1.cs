using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Завдання_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                    
        }

        public int X;
        public int Y;
        public int lenght;
        
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                X = int.Parse(InputX.Text);
                Y = int.Parse(InputY.Text);
                lenght = int.Parse(InputLentght.Text);

                Bitmap bmp = new Bitmap(500, 500);
                Graphics g = Graphics.FromImage(bmp);
                Color color = Color.Black;
                Rectangle rectangle = new Rectangle(X, Y, lenght, lenght);
                g.DrawRectangle(new Pen(color), rectangle);
                pictureBox1.Image = bmp;
                label3.Text = $"Координаты по Х = {X}";
                label4.Text = $"Координаты по Х = {Y}";
            }

            catch (Exception)
            {
                MessageBox.Show("Введите целое число!");
                InputLentght.Text = string.Empty;
                InputX.Text = string.Empty;
                InputY.Text = string.Empty;
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int currentKey = e.KeyValue;
            if (checkBox1.Checked == true)
            {
                switch (currentKey)
                {
                    case 37:
                        pictureBox1.Location = new Point(pictureBox1.Location.X - lenght, pictureBox1.Location.Y);
                        X += -lenght;                      
                        break;
                    case 38:
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - lenght);
                        Y += -lenght;
                        break;
                    case 39:
                        pictureBox1.Location = new Point(pictureBox1.Location.X + lenght, pictureBox1.Location.Y);
                        X += lenght;
                        break;
                    case 40:
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + lenght);
                        Y += lenght;
                        break;
                }               
            }
            else
            {
                switch (currentKey)
                {
                    case 37:
                        pictureBox1.Location = new Point(pictureBox1.Location.X - 2, pictureBox1.Location.Y);
                        X += -2;
                        break;
                    case 38:
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 2);
                        Y += -2;
                        break;
                    case 39:
                        pictureBox1.Location = new Point(pictureBox1.Location.X + 2, pictureBox1.Location.Y);
                        X += 2;
                        break;
                    case 40:
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 2);
                        Y += 2;
                        break;
                }
            }



            label3.Text = $"Координаты по Х = {X}";
            label4.Text = $"Координаты по Y = {Y}";
        }

        
    }
}

