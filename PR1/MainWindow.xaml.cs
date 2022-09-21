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

namespace PR1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var fitsts = textBlock.Text += One.Content;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var Twos = textBlock.Text += Two.Content;
        }

        private void Tree_Click(object sender, RoutedEventArgs e)
        {
            var Trees = textBlock.Text += Tree.Content;
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            var Fours = textBlock.Text += Four.Content;
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            var Fives = textBlock.Text += Five.Content;
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            var Sixs = textBlock.Text += Six.Content;
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            var Sevens = textBlock.Text += Seven.Content;
        }

        private void Eigth_Click(object sender, RoutedEventArgs e)
        {
            var Eigths = textBlock.Text += Eigth.Content;
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            var Nines = textBlock.Text += Nine.Content;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text  = String.Empty;
        }
    }
}
