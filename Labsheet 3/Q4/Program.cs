using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(2,10));
        }

        static int Sum(int number1, int number2)
        {
            int total = 0, temp;

            if (number2 < number1)
            {
                temp = number2;
                number2 = number1;
                number1 = temp;
            }

            for (int i = number1; i <=number2; i++)
            {
                if (i % 2 == 0)
                {
                    total += i;
                }
            }

            return total;
        }
    }
}
