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

namespace WpfApp1
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

        private void count_word(object sender, RoutedEventArgs e)
        {
            string str = textBox1.Text.Trim();
            countLabel.Visibility = Visibility.Visible;
            countLabel.Content = $"Total Words = {Total_words(str)} | Total Characters = {str.Length}";
        }
        public static int Total_words(String s)
        {
            return s.Split(' ').Length;
        }
    }
}
