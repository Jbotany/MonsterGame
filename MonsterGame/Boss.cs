using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Boss
    {
        public int LifePoints { get; private set; }

        public bool IsAlive()
        {
            return LifePoints > 0;
        }

        public Boss(int points)
        {
            this.LifePoints = points;
        }

        public void Attack(Player player)
        {
            int bossDiceRes = RollTheDice(26);
            player.SufferDamage(bossDiceRes);

        }

        public void SufferDamage(int damage)
        {
            this.LifePoints -= damage;
        }

        public int RollTheDice(int value)
        {
            return Dice.RollTheDice(value);
        }
    }
}
