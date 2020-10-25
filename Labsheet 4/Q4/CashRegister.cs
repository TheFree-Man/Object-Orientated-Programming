using System;
using System.Collections.Generic;
using System.Text;

namespace Q4
{
    class CashRegister
    {
        public int NumberOfItems { get; private set; }
        public double Total { get; set; }

        public void AddItem(double itemPrice)
        {
            Total += itemPrice;
            NumberOfItems++;
        }
    }
}
