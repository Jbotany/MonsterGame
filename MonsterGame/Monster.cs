using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Monster : Character
    {
        private bool isAlive;

        // Reward when you defeat the monster.
        public int Reward { get; set; }

        // Physical damages done by the monster when is attack is a success.
        public int AttackPoints { get; } = 10;
        
        // Constructor.
        public Monster()
        {
            this.isAlive = true;
        }

        // Check if the monster is Alive.
        public override bool IsAlive()
        {
            return isAlive;
        }

        // Attack of the monster.
        public override void Attack(Character enemy)
        {
            int CurrentCharacterDiceResult = RollTheDice();
            if (CurrentCharacterDiceResult > enemy.RollTheDice())
                enemy.SufferDamages(CurrentCharacterDiceResult);
        }

        // Kill the monster.
        public override void SufferDamages(int damage)
        {
            this.isAlive = false;
        }
    }
}
