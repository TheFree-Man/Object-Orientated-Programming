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
        ObservableCollection<Employee> employee = new ObservableCollection<Employee>();
        ObservableCollection<Employee> filterEmployee = new ObservableCollection<Employee>();
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FullTimeEmployee FTE1 = new FullTimeEmployee("Joe", "Murphy", 30000);
            FullTimeEmployee FTE2 = new FullTimeEmployee("Jess", "Walsh", 60000);
            PartTimeEmployee PTE1 = new PartTimeEmployee("Jane", "Jones", 9, 40);
            PartTimeEmployee PTE2 = new PartTimeEmployee("John", "Smith", 10, 38);

            employee.Add(FTE1);
            employee.Add(FTE2);
            employee.Add(PTE1);
            employee.Add(PTE2);

            lstbxEmployees.ItemsSource = employee;
            Sorting();

        }

        private void Filter()
        {
            filterEmployee.Clear();
            lstbxEmployees.ItemsSource = null;

            if (chkbxFullTime.IsChecked == true && chkbxPartTime.IsChecked == true)
            {
                foreach (Employee employees in employee)
                {
                    filterEmployee.Add(employees);
                }
                lstbxEmployees.ItemsSource = employee;
            }
            else if (chkbxFullTime.IsChecked == true)
            {
                foreach (Employee employees in employee)
                {
                    if (employees is FullTimeEmployee)
                    {
                        filterEmployee.Add(employees);
                    }
                }
                lstbxEmployees.ItemsSource = filterEmployee;
            }
            else
            {
                foreach (Employee employees in employee)
                {
                    if (employees is PartTimeEmployee)
                    {
                        filterEmployee.Add(employees);
                    }
                }
                lstbxEmployees.ItemsSource = filterEmployee;
            }

            Sorting();
        }

        private void Sorting()
        {
            if (chkbxFullTime.IsChecked == true || chkbxPartTime.IsChecked == true)
            {
                lstbxEmployees.ItemsSource = null;
                filterEmployee = new ObservableCollection<Employee>(filterEmployee.OrderBy(i => i.LastName));
                lstbxEmployees.ItemsSource = filterEmployee;
            }
            else
            {
                lstbxEmployees.ItemsSource = null;
                employee = new ObservableCollection<Employee>(employee.OrderBy(i => i.LastName));
                lstbxEmployees.ItemsSource = employee;
            }
        }

        private void chkbx_Click(object sender, RoutedEventArgs e)
        {
            Filter();
        }

        private void lstbxEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbxSalary.Clear();
            tbxHoursWorked.Clear();
            tbxHourlyRate.Clear();
            tblkMonthlyPay.Text = "";

            foreach (Employee employees in employee)
            {
                if (employees is FullTimeEmployee)
                {
                    FullTimeEmployee selectedEmployeeFullTime = lstbxEmployees.SelectedItem as FullTimeEmployee;
                    if (selectedEmployeeFullTime == null)
                    {
                        continue;
                    }

                    tbxFirstName.Text = selectedEmployeeFullTime.FirstName;
                    tbxSurname.Text = selectedEmployeeFullTime.LastName;
                    rbtnFT.IsChecked = true;
                    tbxSalary.Text = Convert.ToString(selectedEmployeeFullTime.Salary);
                    tblkMonthlyPay.Text = Convert.ToString(selectedEmployeeFullTime.CalculateMonthlyPay());
                }
                else if (employees is PartTimeEmployee)
                {
                    PartTimeEmployee selectedEmployeePartTime = lstbxEmployees.SelectedItem as PartTimeEmployee;
                    if (selectedEmployeePartTime == null)
                    {
                        continue;
                    }

                    tbxFirstName.Text = selectedEmployeePartTime.FirstName;
                    tbxSurname.Text = selectedEmployeePartTime.LastName;
                    rbtnPT.IsChecked = true;
                    tbxHoursWorked.Text = Convert.ToString(selectedEmployeePartTime.HoursWorked);
                    tbxHourlyRate.Text = Convert.ToString(selectedEmployeePartTime.HourlyRate);
                }
            } 
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
             Employee employeeForRemoval = lstbxEmployees.SelectedItem as Employee;
            employee.Remove(employeeForRemoval);
            
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            tbxFirstName.Clear();
            tbxSurname.Clear();
            rbtnFT.IsChecked = false;
            rbtnPT.IsChecked = false;
            tbxSalary.Clear();
            tbxHoursWorked.Clear();
            tbxHourlyRate.Clear();
            tblkMonthlyPay.Text = "";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string firstName = tbxFirstName.Text;
            string surname = tbxSurname.Text;

            if (rbtnFT.IsChecked == true && tbxSalary != null)
            {
                decimal salary = decimal.Parse(tbxSalary.Text);
                FullTimeEmployee FTE = new FullTimeEmployee(firstName, surname, salary);
                employee.Add(FTE);
                Filter();
            }
            else if (rbtnPT.IsChecked == true && tbxSalary == null)
            {
                decimal hoursWorked = decimal.Parse(tbxHoursWorked.Text);
                double hourlyRate = double.Parse(tbxHourlyRate.Text);
                PartTimeEmployee PTE = new PartTimeEmployee(firstName, surname, hoursWorked, hourlyRate);
                employee.Add(PTE);
                Filter();
            }
            else
            {
                MessageBox.Show("Error, please try again");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            Employee employeeUpdated = lstbxEmployees.SelectedItem as Employee;
            if (employeeUpdated != null)
            {
                string firstName = tbxFirstName.Text;
                string surname = tbxSurname.Text;

                if (rbtnFT.IsChecked == true && tbxSalary != null)
                {
                    decimal salary = decimal.Parse(tbxSalary.Text);
                    FullTimeEmployee FTE = new FullTimeEmployee(firstName, surname, salary);
                    employee.Add(FTE);
                    Filter();
                }
                else if (rbtnPT.IsChecked == true && tbxSalary == null)
                {
                    decimal hoursWorked = decimal.Parse(tbxHoursWorked.Text);
                    double hourlyRate = double.Parse(tbxHourlyRate.Text);
                    PartTimeEmployee PTE = new PartTimeEmployee(firstName, surname, hoursWorked, hourlyRate);
                    employee.Add(PTE);
                    Filter();
                }
                else
                {
                    MessageBox.Show("Error, please try again");
                }
            }
        }
    }
}
