/*
 * Github Link:     https://github.com/TheFree-Man/Object-Orientated-Programming/tree/master/Exam%202020-2021
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Account> account = new ObservableCollection<Account>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CurrentAccount CA1 = new CurrentAccount(344454, "Joe", "Bloggs", 3000, "12/11/20", 0.03);
            CurrentAccount CA2 = new CurrentAccount(278412, "Mary", "Wilson", 6000, "9/04/20", 0.03);
            SavingsAccount SA1 = new SavingsAccount(812645, "Paul", "Wilson", 4000, "10/04/20");
            SavingsAccount SA2 = new SavingsAccount(218083, "Ester", "Johnson", 8000, "12/01/20");

            account.Add(CA1);
            account.Add(CA2);
            account.Add(SA1);
            account.Add(SA2);

            lstbxAccountsList.ItemsSource = account;
        }
    }
}
