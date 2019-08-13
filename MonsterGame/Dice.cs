using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    public static class Dice
    {
        private static Random random = new Random();

        // Roll the dice just once
        public static int RollTheDice()
        {
            return random.Next(1, 7);
        }

        // Roll the dice once but with a bigger dice
        public static int RollTheDice(int value)
        {
            return random.Next(1, value);
        }

    }
}
