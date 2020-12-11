using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public abstract class Employee
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public abstract decimal CalculateMonthlyPay();
    }

    public class FullTimeEmployee : Employee
    {
        decimal Salary { get; set; }

        public override decimal CalculateMonthlyPay()
        {
            decimal pay = Salary / 12;
            return pay;
        }

        public FullTimeEmployee(string firstName, string lastName, decimal salary) : base(firstName, lastName)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return string.Format($"{LastName.ToUpper()}, {FirstName} - Full Time");
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

        public PartTimeEmployee(string firstName, string lastName, decimal HourlyRate, double HoursWorked) : base(firstName, lastName)
        {
            decimal hourlyRate = HourlyRate;
            double hoursWorked = HoursWorked;
        }

        public override string ToString()
        {
            return string.Format($"{LastName.ToUpper()}, {FirstName} - Part Time");
        }
    }
}
