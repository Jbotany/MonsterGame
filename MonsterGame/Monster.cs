using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    abstract class Monster
    {
        private readonly int physicalDamages = 10;

        private readonly int award;

        public int Attack()
        {
            return Dice.RollTheDice();
        }
    }
}
