﻿using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.Make = "Ford";
            c1.Model = "Focus";
            c1.CurrentSpeed = 0;
            c1.EngineSize = 1.6;

            Car c2 = new Car();
            c2.Make = "Opel";
            c2.Model = "Astra";
            c2.CurrentSpeed = 0;
            c2.EngineSize = 1.2;

            Console.WriteLine("The {0} {1}, engine size: {2}l, is currently travelling at {3} km/h", c1.Make, c1.Model, c1.EngineSize, c1.CurrentSpeed);

            Console.WriteLine("\nThe {0} {1}, engine size: {2}l, is currently travelling at {3} km/h", c2.Make, c2.Model, c2.EngineSize, c2.CurrentSpeed);
        }
    }
}
