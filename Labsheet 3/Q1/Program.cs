using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
            string input = Console.ReadLine();
            int age = int.Parse(input);

            if (ValidateAge(age))
            {
                Console.WriteLine("You can now access the site");
            }
            else
            {
                Console.WriteLine("Sorry, you cannot access this site");
            }
        }

        static bool ValidateAge(int age)
        {
            bool validAge = false;

            if (age >= 18 && age <= 21)
            {
                validAge = true;
            }
            else
            {
                return validAge;
            }
        }
    }
}
