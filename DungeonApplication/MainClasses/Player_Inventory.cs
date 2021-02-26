using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses
{
    public class Player_Inventory
    {
        public Item[] ItemSection { get; set; }
        public Item[] MedSection { get; set; }
        public Item[] MoveSection { get; set; }
        public Item[] BattleSection { get; set; }

        //public Player_Inventory() { }

        public Player_Inventory(/*Item[] itemSection, Item[] medSection, Item[] moveSection, Item[] battleSection*/)
        {
            ItemSection = new Item[]
            {
                Item.pokeCatcher,
                Item.repel,
                Item.blazeStone,
                Item.aquaStone,
                Item.powerStone,
                Item.earthStone,
                Item.mindStone
            };
            MedSection = new Item[]
            {
                Item.healthPotion,
                Item.revive,
                Item.fullHeal,
                Item.fullRevive,
                Item.hpUp,
                Item.attackUp
            };
            MoveSection = new Item[] { };
            BattleSection = new Item[] { };
        }
    }

    public enum Type
    {
        Item,
        Med,
        Move,
        Battle
    }

    public class Item
    {
        public string Name { get; set; }
        public Type Section { get; set; }
        public Monster_Race Race { get; set; }
        public bool UseNow { get; set; }
        public int Amount { get; set; }
        public int PriceBuy { get; set; }
        public int PriceSell { get; set; }

        public Item() { }

        public Item(string name, Type section, Monster_Race race, bool useNow, int amount, int priceBuy, int priceSell)
        {
            Name = name;
            Section = section;
            Race = race;
            UseNow = useNow;
            Amount = amount;
            PriceBuy = priceBuy;
            PriceSell = priceSell;
        }

        public static Item pokeCatcher = new Item("Catcher", Type.Item, Monster_Race.BATTLE, false, 50, 200, 100);
        public static Item repel = new Item("Repel", Type.Item, Monster_Race.NONE, false, 5, 350, 175);
        public static Item blazeStone = new Item("Blaze Stone", Type.Item, Monster_Race.Fire, false, 5, 1000, 500);
        public static Item aquaStone = new Item("Aqua Stone", Type.Item, Monster_Race.Water, false, 5, 1000, 500);
        public static Item powerStone = new Item("Power Stone", Type.Item, Monster_Race.Electric, false, 5, 1000, 500);
        public static Item earthStone = new Item("Earth Stone", Type.Item, Monster_Race.Ground, false, 5, 1000, 500);
        public static Item mindStone = new Item("Mind Stone", Type.Item, Monster_Race.Psychic, false, 5, 1000, 500);

        public static Item healthPotion = new Item("Health Potion", Type.Med, Monster_Race.PLAYER, false, 5, 300, 150);
        public static Item revive = new Item("Revive", Type.Med, Monster_Race.PLAYER, false, 5, 1500, 750);
        public static Item fullHeal = new Item("Full Heal", Type.Med, Monster_Race.PLAYER, false, 5, 3000, 1500);
        public static Item fullRevive = new Item("Full Revive", Type.Med, Monster_Race.PLAYER, false, 5, 3000, 1500);
        public static Item attackUp = new Item("Attack-UP", Type.Med, Monster_Race.PLAYER, false, 5, 5000, 2500);
        public static Item hpUp = new Item("HP-UP", Type.Med, Monster_Race.PLAYER, false, 5, 5000, 2500);
    }

}
