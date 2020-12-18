/*
 * Name:            Mark Gilmartin
 * 
 * Description:     WPF application that lists out employees and lets you view, add, delete, and update the employees
 * 
 * Date:            8/12/2020
 * 
 * Last Modified:   18/12/2020
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
        ObservableCollection<Employee> employee = new ObservableCollection<Employee>();     // Creates Observible collection named "employee"
        ObservableCollection<Employee> filterEmployee = new ObservableCollection<Employee>();       // Creates observible collection named "filterEmployee" for Filter() method
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Pre-registered employees
            FullTimeEmployee FTE1 = new FullTimeEmployee("Joe", "Murphy", 30000);
            FullTimeEmployee FTE2 = new FullTimeEmployee("Jess", "Walsh", 60000);
            PartTimeEmployee PTE1 = new PartTimeEmployee("Jane", "Jones", 9, 40);
            PartTimeEmployee PTE2 = new PartTimeEmployee("John", "Smith", 10, 38);

            // Adds pre-registered employees to the listbox
            employee.Add(FTE1);
            employee.Add(FTE2);
            employee.Add(PTE1);
            employee.Add(PTE2);

            lstbxEmployees.ItemsSource = employee;
            Sorting();

        }

        private void Filter()       // Filters employees based on what checkbox is checked
        {
            filterEmployee.Clear();
            lstbxEmployees.ItemsSource = null;      // Clears listbox

            if (chkbxFullTime.IsChecked == true && chkbxPartTime.IsChecked == true)     // Checks if "Full Time" & "Part time" checkboxes are checked
            {
                foreach (Employee employees in employee)
                {
                    filterEmployee.Add(employees);
                }
                lstbxEmployees.ItemsSource = filterEmployee;
            }
            else if (chkbxFullTime.IsChecked == true)       // Checks if only "Full Time" checkbox is checked
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
            else       // Checks if only "Part Time" checkbox is checked
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

        private void Sorting()      // Sorts employees alphabetically
        {
            if (chkbxFullTime.IsChecked == true || chkbxPartTime.IsChecked == true)     // Checks if employees were filered or not [see Filter() method]
            {
                // Clears old listbox and creates new observible collection which is sorted alphabetically, then added to listbox
                lstbxEmployees.ItemsSource = null;
                filterEmployee = new ObservableCollection<Employee>(filterEmployee.OrderBy(i => i.LastName));
                lstbxEmployees.ItemsSource = filterEmployee;
            }
            else
            {
                // Clears old listbox and creates new observible collection which is sorted alphabetically, then added to listbox
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
            // Clears any previous selection
            tbxSalary.Clear();
            tbxHoursWorked.Clear();
            tbxHourlyRate.Clear();
            tblkMonthlyPay.Text = "";

            foreach (Employee employees in employee)
            {
                if (employees is FullTimeEmployee)      // Checks if employee is full time
                {
                    FullTimeEmployee selectedEmployeeFullTime = lstbxEmployees.SelectedItem as FullTimeEmployee;
                    if (selectedEmployeeFullTime == null)
                    {
                        continue;
                    }

                    // Displays employee info in textboxes
                    tbxFirstName.Text = selectedEmployeeFullTime.FirstName;
                    tbxSurname.Text = selectedEmployeeFullTime.LastName;
                    rbtnFT.IsChecked = true;
                    tbxSalary.Text = Convert.ToString(selectedEmployeeFullTime.Salary);
                    tblkMonthlyPay.Text = Convert.ToString(selectedEmployeeFullTime.CalculateMonthlyPay());
                }
                else if (employees is PartTimeEmployee)     //Checks if employee is part time
                {
                    PartTimeEmployee selectedEmployeePartTime = lstbxEmployees.SelectedItem as PartTimeEmployee;
                    if (selectedEmployeePartTime == null)
                    {
                        continue;
                    }

                    // Displays employee info in textboxes
                    tbxFirstName.Text = selectedEmployeePartTime.FirstName;
                    tbxSurname.Text = selectedEmployeePartTime.LastName;
                    rbtnPT.IsChecked = true;
                    tbxHoursWorked.Text = Convert.ToString(selectedEmployeePartTime.HoursWorked);
                    tbxHourlyRate.Text = Convert.ToString(selectedEmployeePartTime.HourlyRate);
                    tblkMonthlyPay.Text = Convert.ToString(selectedEmployeePartTime.CalculateMonthlyPay());
                }
            } 
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)      // Deletes an employee from the listbox
        {
             Employee employeeForRemoval = lstbxEmployees.SelectedItem as Employee;
            employee.Remove(employeeForRemoval);
            
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)       // Clears all textboxes
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)     // Adds a new employee based on info inputted into the textboxes
        {
            string firstName = tbxFirstName.Text;
            string surname = tbxSurname.Text;

            if (rbtnFT.IsChecked == true && tbxSalary != null)      // Determines if employee is full time by the "FT" radio button being checked
            {
                decimal salary = decimal.Parse(tbxSalary.Text);
                FullTimeEmployee FTE = new FullTimeEmployee(firstName, surname, salary);        // Creates new employee
                employee.Add(FTE);
                Filter();
            }
            else if (rbtnPT.IsChecked == true && tbxSalary.Text == "")      // Determines if employee is part time by the "PT" radio button being checked
            {
                decimal hWorked = decimal.Parse(tbxHoursWorked.Text);
                double hRate = double.Parse(tbxHourlyRate.Text);
                PartTimeEmployee PTE = new PartTimeEmployee(firstName, surname, hWorked, hRate);        // Creates new employee
                employee.Add(PTE);
                Filter();
            }
            else       // Shows error is something is wrong
            {
                MessageBox.Show("Error, please try again");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)      // Updates employee selected in the listbox based on what is in the textboxes
        {
            Employee employeeUpdated = lstbxEmployees.SelectedItem as Employee;
            if (employeeUpdated != null)
            {
                string firstName = tbxFirstName.Text;
                string surname = tbxSurname.Text;

                if (rbtnFT.IsChecked == true && tbxSalary != null)      // Determines if employee is full time by the "FT" radio button being checked
                {
                    decimal salary = decimal.Parse(tbxSalary.Text);
                    FullTimeEmployee FTE = new FullTimeEmployee(firstName, surname, salary);        // Creates new employee entry with updated information
                    employee.Remove(employeeUpdated);       // Removes old employee entry with outdated indformation
                    employee.Add(FTE);
                    Filter();
                }
                else if (rbtnPT.IsChecked == true && tbxSalary.Text == "")      // Determines if employee is part time by the "PT" radio button being checked
                {
                    decimal hoursWorked = decimal.Parse(tbxHoursWorked.Text);
                    double hourlyRate = double.Parse(tbxHourlyRate.Text);
                    PartTimeEmployee PTE = new PartTimeEmployee(firstName, surname, hoursWorked, hourlyRate);       // Creates new employee entry with updated information
                    employee.Remove(employeeUpdated);       // Removes old employee entry with outdated indformation
                    employee.Add(PTE);
                    Filter();
                }
                else       // Shows error is something is wrong
                {
                    MessageBox.Show("Error, please try again");
                }
            }
        }
    }
}
