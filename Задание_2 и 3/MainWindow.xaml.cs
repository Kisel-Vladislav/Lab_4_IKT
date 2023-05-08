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

namespace Задание_2_и_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double quantityGoods) || !double.TryParse(textBox2.Text, out double price) && price > 0 && quantityGoods > 0)
            {
                MessageBox.Show("Введите коректные данные");
                return;
            }
            double result = quantityGoods * price > 1000 ? (quantityGoods * price * 0.85) :(quantityGoods * price);
            textBlock.Text = (double.Parse(textBlock.Text) + result).ToString();
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "0";
        }
    }
}
