using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleChallenge
{
    public class Monster
    {
        public Monster() { }
        public int Hp { get; set; } = 100;
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
    }
}
