using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    public class Dice
    {
        private Random random;

        // A new dice is instantiate in the constructor
        public Dice()
        {
            random = new Random();
        }

        public int RollTheDice()
        {
            return random.Next(1, 7);
        }
    }
}
