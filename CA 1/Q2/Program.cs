using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundPlayer sndPlayer = new SoundPlayer("blackjack.wav");
            sndPlayer.PlayLooping();

            List<Card> deck = Card.CreateCards();

            Card.Shuffle(deck);

            List<Card> hand1 = deck.GetRange(0, 2);
            List<Card> hand2 = deck.GetRange(2, 2);

            Display(hand1);

            int points = Card.CountCards(hand1);

            Console.WriteLine("Points are: {0}", points);

            int playerPoints = points;

            Console.Write("\nWould you like to (s)tick or (t)wist?: ");
            string stickOrTwist = Console.ReadLine();
            if (stickOrTwist == "t")
            {
                deck.RemoveRange(0, 2);
                hand1 = deck.GetRange(0, 1);
                points = Card.CountCards(hand1);

                Display(hand1);

                playerPoints += points;
            }


            

            Console.WriteLine("Dealer's Turn:\n");

            Display(hand2);

            points = Card.CountDealersCards(hand2);

            Console.WriteLine("Points are: {0}", points);

            int dealerPoints = points;

            if (points <= 17)
            {
                deck.RemoveRange(2, 2);
                hand2 = deck.GetRange(2, 1);
                points = Card.CountDealersCards(hand2);
                Display(hand2);
                dealerPoints += points;
            }

            

            Console.WriteLine(playerPoints);
            Console.WriteLine(dealerPoints);
            Console.ReadLine();
            
        }

        private static void Display(List<Card> deck)
        {
            foreach (Card c in deck)
            {
                Console.WriteLine($"{c.Rank} of {c.Suit}");
            }

            Console.WriteLine();
        }
    }
}
