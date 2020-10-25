using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            CashRegister cr1 = new CashRegister();

            Console.WriteLine("Adding an item worth 2.70 to cash register 1");
            Console.WriteLine("Adding an item worth 3.45 to cash register 1");
            Console.WriteLine("Adding an item worth 5.97 to cash register 1");
            cr1.AddItem(2.70);
            cr1.AddItem(3.45);

            CashRegister cr2 = new CashRegister();

            Console.WriteLine("\nAdding an item worth 12.52 to cash register 2");
            Console.WriteLine("Adding an item worth 1.43 to cash register 2");
            Console.WriteLine("Adding an item worth 15.57 to cash register 2");
            Console.WriteLine("Adding an item worth 5.15 to cash register 2");
            cr2.AddItem(12.52);
            cr2.AddItem(1.43);
            cr2.AddItem(15.57);
            cr2.AddItem(5.15);

            Console.WriteLine("\nCash register cr1 total: {0}", cr1.Total);
            Console.WriteLine("Cash register cr1 no. of items: {0}", cr1.NumberOfItems);
            Console.WriteLine("Cash register cr2 total: {0}", cr2.Total);
            Console.WriteLine("Cash register cr2 no. of items: {0}", cr2.NumberOfItems);

            Console.WriteLine("\nTotal items from all cash registers: {0}", CashRegister.TotalItemsAllCrs);
            Console.WriteLine("Total money from all cash registers: {0}", CashRegister.TotalMoneyAllCrs);
        }
    }
}
