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

namespace Q4
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

        private void tbxInput_GotFocus(object sender, RoutedEventArgs e)
        {
            tbxInput.Clear();
            tbxInput.Background = Brushes.White;
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            string input = tbxInput.Text;

            int number;
            bool isNum = int.TryParse(input, out number);
            if (isNum)
            {
                MessageBox.Show("Value entered is a valid number");
                tbxInput.Background = Brushes.Red;
            }
            else
            {
                MessageBox.Show("Value entered is not a valid number");
                tbxInput.Background = Brushes.Yellow;
            }
        }
    }
}
