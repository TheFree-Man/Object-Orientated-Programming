using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Card
    {
        public string Rank { get; set; }
        public string Suit { get; set; }

        public static void Shuffle(List<Card> deck)
        {
            Random rand = new Random();
            Card temp = new Card();
            int cardNumber;

            for (int i = 0; i < deck.Count; i++)
            {
                cardNumber = rand.Next(deck.Count);

                temp = deck.ElementAt(i);
                deck[i] = deck.ElementAt(cardNumber);
                deck[cardNumber] = temp;
            }
        }

        public static List<Card> CreateCards()
        {
            string[] suits = { "Diamonds", "Spades", "Clubs", "Hearts" };
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            List<Card> deck = new List<Card>();

            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < ranks.Length; j++)
                {
                    Card c = new Card();
                    c.Suit = suits[i];
                    c.Rank = ranks[j];
                    deck.Add(c);
                }
            }

            return deck;
        }

        public static int CountCards(List<Card> hand1)
        {
            int points = 0;
            for (int i = 0; i < hand1.Count; i++)
            {
                switch (hand1[i].Rank)
                {
                    case "Ace":
                        if (points <= 10)
                        {
                            Console.Write("\nYouve been dealt an ace! Would you like to count this as 11 or 1?: ");
                            int aceChoice = int.Parse(Console.ReadLine());
                            if (aceChoice == 11)
                            {
                                points += 11;
                            }
                            else
                            {
                                points += 1;
                            }
                        }
                        break;

                    case "2":
                        points += 2;
                        break;

                    case "3":
                        points += 3;
                        break;

                    case "4":
                        points += 4;
                        break;

                    case "5":
                        points += 5;
                        break;

                    case "6":
                        points += 6;
                        break;

                    case "7":
                        points += 7;
                        break;

                    case "8":
                        points += 8;
                        break;

                    case "9":
                        points += 9;
                        break;

                    case "Jack":
                        points += 10;
                        break;

                    case "Queen":
                        points += 10;
                        break;

                    case "King":
                        points += 10;
                        break;

                    default:
                        break;
                }
            }

            return points;
        }

        public static int CountDealersCards(List<Card> hand2)
        {
            int points = 0;
            for (int i = 0; i < hand2.Count; i++)
            {
                switch (hand2[i].Rank)
                {
                    case "Ace":
                        if (points <= 10)
                        {
                            points += 11;
                        }
                        else
                        {
                            points += 1;
                        }
                        break;

                    case "2":
                        points += 2;
                        break;

                    case "3":
                        points += 3;
                        break;

                    case "4":
                        points += 4;
                        break;

                    case "5":
                        points += 5;
                        break;

                    case "6":
                        points += 6;
                        break;

                    case "7":
                        points += 7;
                        break;

                    case "8":
                        points += 8;
                        break;

                    case "9":
                        points += 9;
                        break;

                    case "Jack":
                        points += 10;
                        break;

                    case "Queen":
                        points += 10;
                        break;

                    case "King":
                        points += 10;
                        break;

                    default:
                        break;
                }
            }

            return points;
        }
    }
}
