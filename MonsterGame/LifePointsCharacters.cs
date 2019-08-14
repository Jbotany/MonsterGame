using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class LifePointsCharacters : Character
    {
        public int LifePoints { get; protected set; }

        // Check if character is alive.
        public override bool IsAlive()
        {

            return LifePoints > 0;

        }

        // Attack an enemy and make him suffer damages.
        public override void Attack(Character enemy)
        {
            int CurrentCharacterDiceResult = RollTheDice(26);
            if (CurrentCharacterDiceResult >= enemy.RollTheDice())
                enemy.SufferDamages(CurrentCharacterDiceResult);
        }

        // Action when the character sufer damages.
        public override void SufferDamages(int damage)
        {
            this.LifePoints -= damage;
        }

        // Roll the dice with a variable limit.
        public int RollTheDice(int value)
        {
            return Dice.RollTheDice(value);
        }
    }
}
