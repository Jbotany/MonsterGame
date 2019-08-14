using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class DifficultMonster : Monster
    {
        // Constructor.
        public DifficultMonster()
        {
            this.Reward = 2;
        }

        // Attack of the monster.
        public override void Attack(Character enemy)
        {
            int CurrentCharacterDiceResult = RollTheDice();
            if (CurrentCharacterDiceResult > enemy.RollTheDice())
                enemy.SufferDamages(CurrentCharacterDiceResult + MagicalDamages());
        }

        // Magical damages done by the monster when you loose the fight.
        public int MagicalDamages()
        {
            int diceRes = RollTheDice();
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
