using System;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int points;

            Console.Write("Please enter your grade: ");
            string gradeString = Console.ReadLine();

            int gradeInt = Convert.ToInt32(gradeString);

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

            Console.WriteLine("The points for the percentage {0} is {1}.", gradeString, points);
        }
    }
}
