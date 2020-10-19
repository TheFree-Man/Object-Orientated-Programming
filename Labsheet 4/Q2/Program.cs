using System;

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

            c1.DisplayCarInfo();

            Console.WriteLine(c2);

            for (int i = 0; i < 10; i++)
            {
                c1.Accelerate();
            }

            Console.WriteLine(c1);
        }
    }
}
