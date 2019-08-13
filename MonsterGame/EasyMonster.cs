using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterGame
{
    class EasyMonster : Monster
    {
        // Reward when you defeat the monster.
        public int Reward { get; } = 1;        
    }
}
