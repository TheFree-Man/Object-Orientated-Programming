﻿using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Team
    {
        public string TeamName { get; private set; }
        public int NumberOfWins { get; private set; }
    }
}
