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
        private bool isAlive;

        // Instantiate a new dice for the class. 
        private Dice dice;

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
        public bool IsAlive
        {
            get
            {
                return this.Life > 0;
            }
        }
        
        // Contructor which set life points to 150.
        public Player()
        {
            this.Life = 150;
            dice = new Dice();
        }

        // The attacking method to kill monsters. Throw a dice.
        public bool Attack(Monster monster)
        {
            bool win = false;
            int diceRes = RollTheDice();

            if (diceRes >= monster.RollTheDice())
            {
                win = true;
            }

            return win;
        }

        // Dice throw of the player.
        public int RollTheDice()
        {
            return dice.RollTheDice();
        }

        public bool ShieldWorks()
        {
            return RollTheDice() <= 2;
        }


    }
}
