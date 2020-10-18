using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] {3, 5, 7, 9, 11 };

            DisplayArray(numbers);

            Zero(numbers);

            DisplayArray(numbers);
        }

        static void DisplayArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element {0} : {1}", i, numbers[i]);
            }
        }

        static void Zero(int[] numbers)
        {
            for (int i = 0; i< numbers.Length; i++)
            {
                numbers[i] = 0;
            }
        }
    }
}
