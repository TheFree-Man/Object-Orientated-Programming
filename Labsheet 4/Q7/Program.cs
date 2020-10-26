using System;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            Schools schoolsClass;
            schoolsClass = new Schools();
            
            for (int i = 0; i != schoolsClass.schools.Length; i++)
            {
                Console.Write("Enter School Name: ");
                schoolsClass.schools[i] = Console.ReadLine();

                Console.Write("\nEnter number of students enroled: ");
                schoolsClass.enrolmentNo[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.Write("\n'-s' to sort by school, '-e' to sort by enrolment, or leave blank to continue unsorted: ");
            string response = Console.ReadLine();
            Console.WriteLine();

            if(response == "-s")
            {
                Array.Sort(schoolsClass.schools, schoolsClass.enrolmentNo);
            }

            for(int i = 0; i != schoolsClass.schools.Length; i++)
            {
                Console.WriteLine("{0} school has {1} students", schoolsClass.schools[i], schoolsClass.enrolmentNo[i]);
            }
        }
    }

    public class Schools
    {
        public string[] schools = new string[5];
        public int[] enrolmentNo = new int[5];
    }
}
