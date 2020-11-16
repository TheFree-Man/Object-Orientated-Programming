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
            SoundPlayer sndPlayer = new SoundPlayer();
            sndPlayer.SoundLocation = @"C:\Users\Uri\Desktop\Music\Music for game\sp8.wav";
            sndPlayer.PlayLooping();

            List<Card> deck = CreateCards();
        }

        private static List<Card> CreateCards()
        {
            string[] suits = { "Diamonds", "Spades", "Clubs", "Hearts" };
            string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        }
    }
}
