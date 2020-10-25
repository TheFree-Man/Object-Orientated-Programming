using System;
using System.Collections.Generic;
using System.Text;

namespace Q4
{
    class CashRegister
    {
        public int NumberOfItems { get; private set; }
        public double Total { get; set; }

        public static double TotalMoneyAllCrs { get; set; }
        public static int TotalItemsAllCrs { get; set; }

        public void AddItem(double itemPrice)
        {
            Total += itemPrice;
            NumberOfItems++;

            TotalItemsAllCrs++;
            TotalMoneyAllCrs += itemPrice;
        }
    }
}
