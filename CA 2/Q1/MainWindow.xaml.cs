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

namespace Q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollections<string> employee = new ObservableCollections<string>();

        public MainWindow()
        {
            InitializeComponent();

            FullTimeEmployee FTE1 = new FullTimeEmployee("Joe", "Murphy", 30000);
            FullTimeEmployee FTE2 = new FullTimeEmployee("Jess", "Walsh", 30000);
            PartTimeEmployee PTE1 = new PartTimeEmployee("Jane", "Jones", 8, 40);
            PartTimeEmployee PTE2 = new PartTimeEmployee("John", "Smith", 9, 38);
        }
    }
}
