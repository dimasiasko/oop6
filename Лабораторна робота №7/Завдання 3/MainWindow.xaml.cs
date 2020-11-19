using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Завдання_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Store();
        }


        
        private void SearchBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Store store = new Store();
            bool index = int.TryParse(indexORword.Text, out int currentNumber);
            if (index && currentNumber < store.Articles.Count)
            {
                ListBoxWatch.SelectedItem = ListBoxWatch.Items.GetItemAt(currentNumber);
                


            }
            else
            {
                MessageBox.Show("Элемента по такому индексу не существует !");
            }
        }


        private void CheckBox_OnClick(object sender, RoutedEventArgs e)
        {
            bool checking = (bool)CheckBox.IsChecked;
            if (checking)
            {
                TextBox1.Text = String.Empty;
                TextBox2.Text = String.Empty;
                TextBox3.Text = String.Empty;
            }

        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Store store = new Store();
            if (TextBox1.Text != string.Empty && TextBox2.Text != string.Empty && TextBox3.Text != string.Empty)
            {
                store.Articles.Add(new Article()
                {
                    NameArticle = TextBox1.Text,
                    NameStore = TextBox2.Text,
                    Price = int.Parse(TextBox3.Text)
                });
            }
            

        }
    }
}
