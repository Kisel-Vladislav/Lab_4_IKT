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

namespace Lab_IKT_4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = null;
            int[,] ints = new int[8, 7];
            Random random = new Random();

            int sum = 0;
            for (int i = 0; i < ints.GetLength(0); i++)
            {
                ints[i, 0] = sum;
                sum = ints[i, 0];
                for (int j = 1; j < ints.GetLength(1); j++)
                {
                    ints[i, j] = random.Next(100);
                    sum += ints[i, j];
                }
            }

            for (int i = 0; i < ints.GetLength(0); i++)
            {
                textBox.Text += string.Format(@"{0,-5}{1,-5}{2,-5}{3,-5}{4,-5}{5,-5}{6,-5}", ints[i, 0], ints[i, 1], ints[i, 2], ints[i, 3], ints[i, 4], ints[i, 5], ints[i, 6]);
                textBox.Text += "\n";
            }
        }
    }
}
