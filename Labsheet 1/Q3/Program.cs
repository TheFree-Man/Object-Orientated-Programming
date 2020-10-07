using System;
using System.IO;

namespace Q3
{
    class Program
    {
        static void Main()
        {
            int points;
            string level;
            string gradeString;
            int gradeInt;

            Beginning:
            Console.Write("Please enter your level: ");
            level = Console.ReadLine().ToLower();
            if (level == "higher")
            {
                Console.Write("Please enter your grade: ");
                gradeString = Console.ReadLine();

                gradeInt = Convert.ToInt32(gradeString);

                if (gradeInt >= 90)
                {
                    points = 100;
                }
                else if (gradeInt >= 80)
                {
                    points = 88;
                }
                else if (gradeInt >= 70)
                {
                    points = 77;
                }
                else if (gradeInt >= 60)
                {
                    points = 66;
                }
                else if (gradeInt >= 50)
                {
                    points = 56;
                }
                else if (gradeInt >= 40)
                {
                    points = 46;
                }
                else if (gradeInt >= 30)
                {
                    points = 37;
                }
                else
                {
                    points = 0;
                }
            }
            else if (level == "ordinary")
            {
                Console.Write("Please enter your grade: ");
                gradeString = Console.ReadLine();

                gradeInt = Convert.ToInt32(gradeString);

                if (gradeInt >= 90)
                {
                    points = 56;
                }
                else if (gradeInt >= 80)
                {
                    points = 46;
                }
                else if (gradeInt >= 70)
                {
                    points = 37;
                }
                else if (gradeInt >= 60)
                {
                    points = 28 ;
                }
                else if (gradeInt >= 50)
                {
                    points = 20;
                }
                else if (gradeInt >= 40)
                {
                    points = 12;
                }
                else
                {
                    points = 0;
                }
            }
            else
            {
                Console.WriteLine("Please try again\n");
                goto Beginning;
            }

            Console.WriteLine("The points for the percentage {0} is {1}.", gradeString, points);
        }
    }
}
