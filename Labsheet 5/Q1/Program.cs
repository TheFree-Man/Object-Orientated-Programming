using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game g1 =
            //   new Game("Monopoly", 19.99m, new DateTime(1970, 01, 31));

            //Game g2 =
            //   new Game() { Price = 10.99m, ReleaseDate = new DateTime(2000, 6, 15) };

            ComputerGame cg1 = new ComputerGame("Sonic", 29.99m, new DateTime(1990, 3, 15), "U");

            ComputerGame cg2 = new ComputerGame("Mario", 24.99m, new DateTime(1995, 11, 17), "7");

            //DisplayGame(g1);
            //DisplayGame(g2);
            DisplayGame(cg1);
            DisplayGame(cg2);
        }

        static void DisplayGame(Game game)
        {
            Console.WriteLine(game);
        }
    }
}
