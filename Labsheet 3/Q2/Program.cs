using System;
using System.ComponentModel.Design.Serialization;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetProductCost("jeans"));
            Console.WriteLine(GetProductCost("jacket"));
            Console.WriteLine(GetProductCost("boots"));
            Console.WriteLine(GetProductCost("scarves"));
            Console.WriteLine(GetProductCost("belts"));
            Console.WriteLine(GetProductCost("socks"));
        }

        static decimal GetProductCost(string desc)
        {
            decimal cost;

            switch (desc)
            {
                case "jeans":
                    cost = 67.99m;
                    break;

                case "jacket":
                    cost = 68.99m;
                    break;

                case "boots":
                    cost = 34.99m;
                    break;

                case "Scarves":
                case "belts":
                case "socks":
                    cost = 10m;
                    break;

                default:
                    cost = -999m;
                    break;
            }

            return cost;
        }
    }
}
