using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ShortAttentionAI : IPlayer
    {

        int savedMove;
        public int NextMove()
        {

            if (savedMove == 0)
            {
                return 1;
            }
            if (savedMove == 1)
            {
                return 2;
            }
            else return 0;

        }
        public void SaveResult( int myMove, int otherMove)
        {
            savedMove = otherMove;
        }
    }
}
