using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Monster
    {
        // Physical damages done by the monster when is attack is a success.
        public int PhysicalDamages { get; } = 10;

        // Attack of the monster.
        public bool Attack(Player player)
        {
            int monsterDiceRes = RollTheDice();

            if (monsterDiceRes > player.RollTheDice())
            {
                return true;
            }

            return false;
        }

        // Dice throw of the monster.
        public int RollTheDice()
        {
            return Dice.RollTheDice();
        }
    }
}
