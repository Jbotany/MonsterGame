using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{ 
    class Player : LifePointsCharacters
    {
        // The number of easy monsters that have been killed.
        public int EasyMonsterCounter { get; set; } = 0;

        // The number of difficult monsters that have been killed.
        public int DifficultMonsterCounter { get; set; } = 0;

        // The name of the palyer.
        public string Name { get; set; }

        // The points won by the player while killing monsters.
        public int VictoryPoints { get; set; }
        
        // Contructor which set life points to 150.
        public Player()
        {
            this.LifePoints = 150;
        }

        // If the restult is 1 or 2, the shield works.
        public bool ShieldWorks()
        {
            return RollTheDice() <= 2;
        }

        public override void SufferDamages(int damages)
        {
            if (!ShieldWorks())
            {
                this.LifePoints -= damages;
            }           
        }
    }
}
