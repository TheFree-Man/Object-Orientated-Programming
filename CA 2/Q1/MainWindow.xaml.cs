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
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public abstract class Employee
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        public abstract decimal CalculateMonthlyPay()
        {

        }
    }

    public class FullTimeEmployee : Employee
    {
        decimal Salary { get; set; }

        public override decimal CalculateMonthlyPay()
        {
            decimal pay = Salary / 12;
            return pay;
        }
    }

    public class PartTimeEmployee : Employee
    {
        decimal HourlyRate { get; set; }
        double HoursWorked { get; set; }

        public override decimal CalculateMonthlyPay()
        {
            decimal pay = HourlyRate * (decimal)HoursWorked;
            return pay;
        }
    }
}
