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

namespace Задание_4
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int x) || !int.TryParse(textBox2.Text, out int n) || x < 0 || n < 0)
            {
                MessageBox.Show("Tify");
                return;
            }
                
            double result = 1;
            for (int i = 0; i <= n; i++)
                result *= (i * x + Math.Sin(x)) / (10 * x);
            
            textBloc.Text = result.ToString();
        }
    }
}
