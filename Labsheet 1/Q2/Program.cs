using System;

namespace Q2
{
    class Program
    {
        static void Main()
        {
            int points;

            Console.Write("Please enter your grade: ");
            string grade = Console.ReadLine().ToUpper();

            switch (grade)
            {
                case "H1":
                    points = 100;
                    break;

                case "H2":
                    points = 88;
                    break;

                case "H3":
                    points = 77;
                    break;

                case "H4":
                    points = 66;
                    break;

                case "H5":
                    points = 56;
                    break;

                case "H6":
                    points = 46;
                    break;

                case "H7":
                    points = 37;
                    break;

                default:
                    points = 0;
                    break;
            }

            Console.WriteLine("The points for the grade {0} is {1}.", grade, points);
        }
    }
}
