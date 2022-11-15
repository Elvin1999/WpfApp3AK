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

namespace WpfApp12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           // myChecked.IsChecked = true;
        }

        private void myChecked_Checked(object sender, RoutedEventArgs e)
        {
           // myChecked.Content = "Already Check";
        }

        private void myChecked_Unchecked(object sender, RoutedEventArgs e)
        {
           // myChecked.Content = "Not Check";
        }

        public int Number { get; set; } = 0;
        private void normalBtn_Click(object sender, RoutedEventArgs e)
        {
            ++Number;
            //normalBtn.Content = Number.ToString();
        }

        private void repeatBtn_Click(object sender, RoutedEventArgs e)
        {
            ++Number;
           // repeatBtn.Content = Number.ToString();
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            ++Number;
           // toggleBtn.Content = Number.ToString();
        }
    }
}
