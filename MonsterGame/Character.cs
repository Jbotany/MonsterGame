using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    public abstract class Character
    {
        public abstract void Attack(Character character);

        public abstract bool IsAlive();

        public abstract void SufferDamages(int damages);

        public int RollTheDice()
        {
            return Dice.RollTheDice();
        }

        

    }
}
