using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses
{
    public class Player
    {
        public string Name { get; set; }
        public char Gender { get; set; }
        public int Money { get; set; }
        public string[] ASCIIAttacker { get; set; }
        public string[] ASCIIDefender { get; set; }
        public string[] ASCIIProfile { get; set; }
        public Monster MonsterEquipped { get; set; }
        public Player_Party Party { get; set; }
        public Player_Inventory Inventory { get; set; }
        public Monster[] PC { get; set; }

        public Player(string name, char gender, int money, string[] asciiAttacker, string[] asciiDefender, string[] asciiProfile, Monster monsterEquipped, Player_Party party, Player_Inventory inventory, Monster[] pc)
        {
            Name = name;
            Gender = gender;
            Money = money;
            ASCIIAttacker = asciiAttacker;
            ASCIIDefender = asciiDefender;
            ASCIIProfile = asciiProfile;
            MonsterEquipped = monsterEquipped;
            Party = party;
            Inventory = inventory;
            PC = pc;
        }

        public Player() { }
    }
}
