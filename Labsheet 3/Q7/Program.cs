using System;
using System.Collections.Generic;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> team = new List<string>();

            Console.WriteLine("Enter team member name (-1 to quit): ");
            string input = Console.ReadLine();

            while (input != "-1")
            {
                team.Add(input);

                Console.WriteLine("Enter team member name, -1 to quit: ");
                input = Console.ReadLine();
            }

            foreach (string member in team)
            {
                Console.WriteLine(member);
            }

            team.Sort();

            foreach (string member in team)
            {
                Console.WriteLine(member);
            }
        }
    }
}
