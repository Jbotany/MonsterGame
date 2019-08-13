using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{ 
    class Player
    {
        // The player is alive at the start of the game.
        private bool isAlive = true;

        // The number of easy monsters that have been killed.
        public int EasyMonsterCounter { get; set; }

        // The number of difficult monsters that have been killed.
        public int DifficultMonsterCounter { get; set; }

        // Life points on read only.
        public int Life { get; }

        // The name of the palyer.
        public string Name { get; set; }

        // The points won by the player while killing monsters.
        public int Points { get; set; }

        // If the life points are set to 0, the player dies.
        public bool IsAlive
        {
            get
            {
                if (Life == 0)
                {
                    isAlive = false;
                }
                return isAlive;
            }
        }
        
        // Contructor which set life points to 150.
        public Player()
        {
            this.Life = 150;
        }

        // The attacking method to kill monsters. Throw a dice.
        public int Attack(object monster)
        {
            return Dice.RollTheDice();
        }
    }
}
