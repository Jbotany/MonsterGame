using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class DifficultMonster : Monster
    {
        private readonly int award = 2;

        public int MagicalcalDamages()
        {
            int dice = Dice.RollTheDice();
            if (dice < 6)
            {
                return 5 * dice;
            }
            else
            {
                return 0;
            }                
        }
    }
}
