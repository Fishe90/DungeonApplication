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
        public Player_Party Party { get; set; }
        public Player_Inventory Inventory { get; set; }
        public Monster[] PC { get; set; }

        public Player(string name, char gender, int money, string[] asciiAttacker, string[] asciiDefender, string[] asciiProfile, Player_Party party, Player_Inventory inventory, Monster[] pc)
        {
            Name = name;
            Gender = gender;
            Money = money;
            ASCIIAttacker = asciiAttacker;
            ASCIIDefender = asciiDefender;
            ASCIIProfile = asciiProfile;
            Party = party;
            Inventory = inventory;
            PC = pc;
        }

        public Player() { }

        public static Item[] PlayerInventory = new Item[]
        {
            Item.pokeCatcher,
            Item.repel,
            Item.blazeStone,
            Item.aquaStone,
            Item.powerStone,
            Item.earthStone,
            Item.mindStone,

            Item.healthPotion,
            Item.revive,
            Item.fullHeal,
            Item.fullRevive,
            Item.attackUp,
            Item.hpUp
        };
        
    }
}
