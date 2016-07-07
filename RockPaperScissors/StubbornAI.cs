using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class StubbornAI : IPlayer
    {
        
        
        public int NextMove()
        {
            return 0;//AI choice is hard coded to {0}(Rock).
        }

        public void SaveResult(int myMove, int otherMove)
        {
            //this void isn't returning anything. Just leave blank.
        }
    }
}
