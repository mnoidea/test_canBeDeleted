using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowlingGame
{
    
    public class Game
    {
        private int _score = 0;
        public void Roll(int p)
        {
            _score += p;
        }

        public object Score()
        {
            return _score;
        }
    }
}
