using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class Boss : LifePointsCharacters
    {        
        public Boss(int points)
        {
            this.LifePoints = points;
        }
    }
}
