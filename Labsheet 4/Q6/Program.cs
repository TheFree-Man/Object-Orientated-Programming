using System;
using System.Globalization;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Lunch lunch1, lunch2, lunch3, lunch4, lunch5;
            lunch1 = new Lunch();
            lunch2 = new Lunch();
            lunch3 = new Lunch();
            lunch4 = new Lunch();
            lunch5 = new Lunch();

            lunch1.Entree = "hamburger";
            lunch1.Side = "fries";
            lunch1.Drink = "cola";

            lunch2.Entree = "hot dog";
            lunch2.Side = "chips";
            lunch2.Drink = "lemonade";

            lunch3.Entree = "pizza";
            lunch3.Side = "salad";
            lunch3.Drink = "iced tea";

            lunch4.Entree = "tuna sandwich";
            lunch4.Side = "fruit cup";
            lunch4.Drink = "water";

            lunch5.Entree = "peanut butter sandwich";
            lunch5.Side = "cookie";
            lunch5.Drink = "milk";

            Display(lunch1, lunch2, lunch3);
            Console.WriteLine();
            Display(lunch1, lunch2, lunch3, lunch4);
            Console.WriteLine();
            Display(lunch1, lunch2, lunch3, lunch4, lunch5);
        }

        static void Display(params Lunch[] lunches)
        {
            Console.WriteLine("{0, -24}{1, -12}{2, -10}", "Entree", "Side", "Drink", "Colour", "Value");

            foreach (Lunch lunch in lunches)
            {
                Console.WriteLine("{0, -24}{1, -12}{2, -10}", lunch.Entree, lunch.Side, lunch.Drink);
            }
        }
    }

    public class Lunch
    {
        public string Entree { get; set; }
        public string Side { get; set; }
        public string Drink { get; set; }
    }
}
