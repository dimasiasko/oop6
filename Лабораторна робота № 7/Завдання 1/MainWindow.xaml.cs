using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
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

namespace Завдання_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int[] _elements;
        private int _count;
        private int _counter2;


        private void addArrBtn_Click(object sender, RoutedEventArgs e)
        {

            if (int.TryParse(currentValue.Text, out int currentNumber))
            {
                _elements[_count] = currentNumber;
                elementsArr.Items[_count] = currentNumber;
                UpdateProgressText(++_count, _elements.Length);
                ShowValues(_counter2);
                _counter2++;
            }
            else if (currentValue.GetType() != typeof(int))
            {
                MessageBox.Show(this, "Вводить нужно целые ЧИСЛА");
            }
            else
            {
                MessageBox.Show(this, "Вводить нужно ЧИСЛА");
            }
            UpdateEnabledState();
            currentValue.Text = string.Empty;
            
        }

        private void createArr_Click(object sender, RoutedEventArgs e)
        {
            Reset();

            if (int.TryParse(sizeArr.Text, out int size))
            {
                if (size > 0)
                {
                    _elements = new int[size];
                    for (int i = 0; i < size; i++)
                        elementsArr.Items.Add(0);
                }
                else
                    MessageBox.Show(this, "Нужно вводить ПОЛОЖИТЕЛЬНОЕ ЧИСЛО !");
            }
            else
            {
                MessageBox.Show(this, "Нужно вводить число!");
            }

            UpdateProgressText(0, _elements.Length);
            UpdateEnabledState();
        }

        private void UpdateProgressText(int value, int maxValue)
        {
            countElements.Text = string.Format("{0}/{1}", value, maxValue);
        }

        private void Reset()
        {
            _count = 0;
            elementsArr.Items.Clear();
            UpdateProgressText(0, 0);
        }
        private void UpdateEnabledState()
        {
            
            bool enabled = _elements != null && (_count != _elements.Length);
            addArrBtn.IsEnabled = enabled;
            currentValue.IsEnabled = enabled;
            countElements.IsEnabled = true;
            arrIndicate.Visibility = enabled ? Visibility.Hidden : Visibility.Visible;
        }
        private void ShowValues(int item)
        {
            minValue.Text = $"Минимум = {_elements.Min()}";
            maxValue.Text = $"Максимум = {_elements.Max()}";
            avgValue.Text = $"Среднее = {Math.Round(_elements.Average(), 2)}";
            sumValue.Text = $"Сумма = {Math.Round((double)_elements.Sum(), 2)}";           
            if (_elements[item] < 0)          
                negativeValues.Text += $"{_elements[item]}, ";
                    
        }
    }
        
}
