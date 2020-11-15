using System;
using System.Collections.Generic;
using System.Text;

namespace Q1
{
    public abstract class Game
    {
        private readonly string _name;
        public string Name
        {
            get
            {
                return _name;
            }
        }

        protected decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Game(string name, decimal place, decimal price, DateTime releasedate)
        {
            _name = name;
            Price = price;
            ReleaseDate = releasedate;
        }

        public Game(string name, decimal price) : this(name, price, DateTime.Now)
        {

        }

        public Game() : this("", 0) { }

        public override string ToString()
        {
            return string.Format($"{Name} {Price:C} {ReleaseDate.ToShortDateString()}");
        }

        public abstract void UpdatePrice(decimal percentageIncrease);
        //{
        //    Price *= (1 + percentageIncrease);
        //}
    }

    public class ComputerGame : Game
    {
        public string PEGI_Rateing { get; set; }

        public ComputerGame(string name,decimal price, DateTime date, string pegi) : base(name, price, date)
        {
            PEGI_Rateing = pegi;
        }

        public override string ToString()
        {
            return string.Format($"{base.ToString()} PEGI {PEGI_Rateing}");
        }

        public decimal GetDiscountPrice()
        {
            return Price * .9m;
        }

        public override void UpdatePrice(decimal percentageIncrease)
        {
            Price *= (1 + percentageIncrease);
            Console.WriteLine("Updating the price...");
        }
    }
}
