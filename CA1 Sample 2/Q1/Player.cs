using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class Player : IComparable
    {
        public int ID { get; }
        public string PlayerName { get; set; }
        public int Score { get; private set; }
        public static int HighScore { get; set; }

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

            if (Score > HighScore)
            {
                HighScore = Score;
            }
        }

        public override string ToString()
        {
            return $"{ID}\t{PlayerName}\t{Score}";

        }

        public int CompareTo(object obj)
        {
            Player objecThatIAmComparingTo = obj as Player;

            int returnValue = this.Score.CompareTo(objecThatIAmComparingTo.Score);

            return returnValue;
        }
    }
}
