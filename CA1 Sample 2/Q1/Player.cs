using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class Player
    {
        public int ID { get; }
        public string PlayerName { get; set; }
        public int Score { get; private set; }

        public Player(int id, string playerName, int score)
        {
            ID = ID;
            PlayerName = playerName;
            Score = score;
        }

        public void IncreaseScore(int valueToAdd)
        {
            if(Score == 100)
            {
                Score += valueToAdd;
            }
        }
    }
}
