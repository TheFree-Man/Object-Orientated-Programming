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
    }
}
