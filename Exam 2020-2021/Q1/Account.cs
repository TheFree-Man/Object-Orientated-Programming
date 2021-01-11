/*
 * Github Link:     https://github.com/TheFree-Man/Object-Orientated-Programming/tree/master/Exam%202020-2021
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public abstract class Account
    {
        public decimal AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
        public string InterestDate { get; set; }

        public Account(decimal accountNumber, string firstName, string lastName, decimal balance, string interestDate)
        {
            AccountNumber = accountNumber;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
            InterestDate = interestDate;
        }

        //public decimal Deposit()
        //{

        //}

        //public decimal Withdraw()
        //{

        //}

        public abstract double CalculateInterest();
    }

    public class CurrentAccount : Account
    {
        public double InterestRateCA { get; set; }

        public CurrentAccount(decimal accountNumber, string firstName, string lastName, decimal balance, string interestDate, double interestRate) : base(accountNumber, firstName, lastName, balance, interestDate)
        {
            InterestRateCA = 0.03;
        }

        public override double CalculateInterest()
        {
            double total = (double)Balance * InterestRateCA;
            return total;
        }

        public override string ToString()
        {
            return string.Format($"{AccountNumber}, {LastName.ToUpper()}, {FirstName} - Current Account");     // Sets the formatting for how each employee will be displayed in the listbox
        }
    }

    public class SavingsAccount : Account
    {
        public double InterestRateSA { get; set; }

        public SavingsAccount(decimal accountNumber, string firstName, string lastName, decimal balance, string interestDate) : base(accountNumber, firstName, lastName, balance, interestDate)
        {
            InterestRateSA = 0.06;
        }

        public override double CalculateInterest()
        {
            double total = (double)Balance * InterestRateSA;
            return total;
        }

        public override string ToString()
        {
            return string.Format($"{AccountNumber}, {LastName.ToUpper()}, {FirstName} - Savings Account");     // Sets the formatting for how each employee will be displayed in the listbox
        }
    }
}
