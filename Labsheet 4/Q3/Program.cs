using System;
using System.IO;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BankAccount acc1 = new BankAccount("45682012", "Tom Smith", 1000);
            BankAccount acc2 = new BankAccount("75587891", "Mary Mills", 2000);

            Console.WriteLine(acc1.GetAccountDetails());
            Console.WriteLine(acc2.GetAccountDetails());

            Console.WriteLine("Adding €1000 to account 1");
            acc1.Deposit(1000);
            Console.WriteLine(acc1.GetAccountDetails());

            Console.WriteLine("Withdrawing €500 from account 2");
            acc2.Withdraw(2000);
            Console.WriteLine(acc2.GetAccountDetails());
        }
    }
}
