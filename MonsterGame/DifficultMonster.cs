using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class DifficultMonster : Monster
    {
        // Reward when you defeat the monster.
        public int Reward { get; } = 2;

        // Magical damages done by the monster when you loose the fight.
        public int MagicalDamages()
        {
            int diceRes = dice.RollTheDice();
            if (diceRes < 6)
            {
                return 5 * diceRes;
            }
            else
            {
                return 0;
            }                
        }
    }
}
