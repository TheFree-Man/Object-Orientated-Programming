using System;

namespace ExtensionMethod
{
    static class Program
    {
        static void Main(string[] args)
        {
            string text = "This is a test sentence";

            Console.WriteLine("The number of works is \"{0}\" is {1}", text, text.WordCount());

            Console.ReadLine();
        }

        public static int WordCount(this string text)
        {
            string[] words = text.Split(' ');
            return words.Length;
        }
    }
}
