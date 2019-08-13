using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{ 
    class Player
    {
        // The number of easy monsters that have been killed.
        public int EasyMonsterCounter { get; set; } = 0;

        // The number of difficult monsters that have been killed.
        public int DifficultMonsterCounter { get; set; } = 0;

        // Life points on read only.
        public int Life { get; set; }

        // The name of the palyer.
        public string Name { get; set; }

        // The points won by the player while killing monsters.
        public int Points { get; set; }

        // If the life points are set to 0, the player dies.
        public bool IsAlive()
        {
            return this.Life > 0;
        }
        
        // Contructor which set life points to 150.
        public Player()
        {
            this.Life = 150;
        }

        // The attacking method to kill monsters. Throw a dice.
        public bool Attack(Monster monster)
        {
            int playerDiceRes = RollTheDice();

            if (playerDiceRes >= monster.RollTheDice())
            {
                return true;
            }

            return false;
        }

        // The attacking method to kill boss. Throw a dice.
        public void Attack(Boss boss)
        {
            int playerDiceRes = RollTheDice(26);
            boss.SufferDamage(playerDiceRes);
        }

        // Dice throw by the player.
        public int RollTheDice()
        {
            return Dice.RollTheDice();
        }

        // Dice throw by the player with a different limit.
        public int RollTheDice(int value)
        {
            return Dice.RollTheDice(value);
        }

        // If the restult is 1 or 2, the shield works.
        public bool ShieldWorks()
        {
            return RollTheDice() <= 2;
        }

        public void SufferDamage(int damage)
        {
            this.Life -= damage;
        }

    }
}
