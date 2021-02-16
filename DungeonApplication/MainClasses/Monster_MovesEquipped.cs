using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses
{
    public class Monster_MovesEquipped
    {
        public Monster_Moves Move1 { get; set; }
        public Monster_Moves Move2 { get; set; }
        public Monster_Moves Move3 { get; set; }
        public Monster_Moves Move4 { get; set; }

        public Monster_MovesEquipped() { }

        public Monster_MovesEquipped(Monster_Moves move1, Monster_Moves move2, Monster_Moves move3, Monster_Moves move4)
        {
            Move1 = move1;
            Move2 = move2;
            Move3 = move3;
            Move4 = move4;
        }
    }
}
