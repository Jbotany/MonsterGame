using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    public static class Dice
    {
        public static int RollTheDice()
        {
            Random rand = new Random();

            return rand.Next(1, 7);
        }
    }
}
