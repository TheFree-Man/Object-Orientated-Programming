using System;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int points;
            int totalPoints = 0, lowestPoints = 100;

        Beginning:
            Console.Write("Please enter your level: ");
            string level = Console.ReadLine().ToLower();
            if (level == "higher")
            {
                

                for (int i = 0; i < 7; i++)
                {
                    Console.Write("$Please enter your grade {0}: ", i + 1);
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

                    totalPoints += points;
                    if (totalPoints < lowestPoints)
                    {
                        lowestPoints = points;
                    }
                }
            }
            else if (level == "ordinary")
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.Write("Please enter your grade: ");
                    string grade = Console.ReadLine().ToUpper();

                    switch (grade)
                    {
                        case "O1":
                            points = 56;
                            break;

                        case "O2":
                            points = 46;
                            break;

                        case "O3":
                            points = 37;
                            break;

                        case "O4":
                            points = 28;
                            break;

                        case "O5":
                            points = 20;
                            break;

                        case "O6":
                            points = 12;
                            break;

                        default:
                            points = 0;
                            break;
                    }

                    totalPoints += points;
                    if (totalPoints < lowestPoints)
                    {
                        lowestPoints = points;
                    }
                }
            }
            else
            {
                Console.WriteLine("Please try again\n");
                goto Beginning;
            }

            Console.WriteLine("Total points are: {0}", totalPoints - lowestPoints);
            Console.ReadLine();

        }
    }
}
