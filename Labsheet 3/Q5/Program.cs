using System;
using System.Net.NetworkInformation;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            int stock = 10, sales = 5;

            Console.WriteLine("Stock on hand = {0}", stock);

            if (UpdateStock(ref stock, sales))
            {
                Console.WriteLine("Sale successful, sold {0}, remaining stock {1}", sales, stock);
            }
            else
            {
                Console.WriteLine("Insufficient stock");
            }
        }

        static bool UpdateStock(ref int stock, int sales)
        {
            bool stockUpdated = false;

            if(stock >= sales)
            {
                stock -= sales;
                stockUpdated = true;
            }

            return stockUpdated;
        }
    }
}
