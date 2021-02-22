using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses
{
    public class Player_Party
    {
        public Monster MonsterEquipped { get; set; }
        public Monster Slot2 { get; set; }
        public Monster Slot3 { get; set; }
        public Monster Slot4 { get; set; }
        public Monster Slot5 { get; set; }
        public Monster Slot6 { get; set; }
        public Monster MonsterSwitch { get; set; }

        public Player_Party() { }

        public Player_Party(Monster monsterEquipped, Monster slot2, Monster slot3, Monster slot4, Monster slot5, Monster slot6, Monster monsterSwitch)
        {
            MonsterEquipped = monsterEquipped;
            Slot2 = slot2;
            Slot3 = slot3;
            Slot4 = slot4;
            Slot5 = slot5;
            Slot6 = slot6;
            MonsterSwitch = monsterSwitch;
        }
    }
}
