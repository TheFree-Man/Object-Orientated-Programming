using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Q1
{
    class Car
    {
        private string make;

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private int currentSpeed;

        public int CurrentSpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }
        }

        private double engineSize;

        public double EngineSize
        {
            get { return engineSize; }
            set { engineSize = value; }
        }
        public void DisplayCarInfo()
        {
            Console.WriteLine("Car make: {0}", Make);
            Console.WriteLine("\nCar model: {0}", Model);
            Console.WriteLine("\nEngine size: {0}", EngineSize);
            Console.WriteLine("\nCurrent speed: {0}", CurrentSpeed);
        }

        public override string ToString()
        {
            return
                string.Format("Car make: {0}", Make + "\nCar model: {0}", Model + "\nEngine size: {0}", EngineSize + "\nCurrent speed: {0}", CurrentSpeed);
        }

        public void Accelerate()
        {
            CurrentSpeed += 10;
            Console.WriteLine("Current speed: {0}", CurrentSpeed);
        }
    }
}