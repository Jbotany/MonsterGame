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

        // Instantiate a new dice for the class. 
        protected Dice dice;

        public Monster()
        {
            dice = new Dice();
        }

        // Attack of the monster.
        public bool Attack(Player player)
        {
            bool win = false;
            int diceRes = RollTheDice();

            if (diceRes > player.RollTheDice())
            {
                win = true;
            }

            return win;
        }

        // Dice throw of the monster.
        public int RollTheDice()
        {
            return dice.RollTheDice();
        }
    }
}
