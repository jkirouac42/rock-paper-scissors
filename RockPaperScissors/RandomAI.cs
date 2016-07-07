using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RandomAI : IPlayer
    {
        Random random = new Random();
        public int NextMove()
        { //could return: 0, 1, or 2

           return random.Next(0, 3);// high is not 2 because max value must be higher than value

        }

        public void SaveResult(int myMove, int otherMove)
        {
           // throw new NotImplementedException();
           //this method intentionally left blank
        }
    }
}
