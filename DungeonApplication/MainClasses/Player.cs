using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MainClasses
{
    public class Player
    {
        public string Name { get; set; }
        public char Gender { get; set; }
        public int PlayerID { get; set; }
        public int Money { get; set; }
        public string StartTime { get; set; }
        public string[] ASCIIAttacker { get; set; }
        public string[] ASCIIDefender { get; set; }
        public string[] ASCIIProfile { get; set; }
        public Player_Party Party { get; set; }
        public Player_Inventory Inventory { get; set; }
        public Monster[] Pokedex { get; set; }
        public Monster[] PC { get; set; }

        public Player(string name, char gender, int playerID, int money, string startTime, string[] asciiAttacker, string[] asciiDefender, string[] asciiProfile, Player_Party party, Player_Inventory inventory, Monster[] pokedex, Monster[] pc)
        {
            Name = name;
            Gender = gender;
            PlayerID = playerID;
            Money = money;
            StartTime = startTime;
            ASCIIAttacker = asciiAttacker;
            ASCIIDefender = asciiDefender;
            ASCIIProfile = asciiProfile;
            Party = party;
            Inventory = inventory;
            Pokedex = pokedex;
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
