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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public abstract class Employee
    {
        public string FirstName { get; set; }       // Sets attributes for employee's first name
        public string LastName { get; set; }        // Sets attributes for employee's surname

        public Employee(string firstName, string lastName)      // Sets attributes as strings
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public abstract decimal CalculateMonthlyPay();      // Main CalCulateMonthlyPay() method 
    }

    public class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }     // Sets attributes for full time employee's salary

        public override decimal CalculateMonthlyPay()       // Calculates monthly pay for part time employees
        {
            decimal pay = Salary / 12;
            return pay;
        }

        public FullTimeEmployee(string firstName, string lastName, decimal salary) : base(firstName, lastName)      // Sets attributes as string
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return string.Format($"{LastName.ToUpper()}, {FirstName} - Full Time");     // Sets the formatting for how each employee will be displayed in the listbox
        }
    }

    public class PartTimeEmployee : Employee
    {
        public decimal HourlyRate { get; set; }     // Sets attributes for part time employee's hourly rate
        public double HoursWorked { get; set; }     // Sets attributes for part time employee's hurs worked

        public override decimal CalculateMonthlyPay()       // Calculates monthly pay for part time employees
        {
            decimal pay = HourlyRate * (decimal)HoursWorked;
            return pay;
        }

        public PartTimeEmployee(string firstName, string lastName, decimal hourlyRate, double hoursWorked) : base(firstName, lastName)      // Sets attributes as strings
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override string ToString()
        {
            return string.Format($"{LastName.ToUpper()}, {FirstName} - Part Time");     // Sets the formatting for how each employee will be displayed in the listbox
        }
    }
}
