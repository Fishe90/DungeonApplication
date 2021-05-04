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
        public string Description { get; set; }
        public Type Section { get; set; }
        public Monster_Race Race { get; set; }
        public bool UseNow { get; set; }
        public int Amount { get; set; }
        public int PriceBuy { get; set; }
        public int PriceSell { get; set; }

        public Item() { }

        public Item(string name, string description, Type section, Monster_Race race, bool useNow, int amount, int priceBuy, int priceSell)
        {
            Name = name;
            Description = description;
            Section = section;
            Race = race;
            UseNow = useNow;
            Amount = amount;
            PriceBuy = priceBuy;
            PriceSell = priceSell;
        }

        public static Item empty = new Item("empty", "emptyasdfasdfasdfasdfasdfasdfasdfasdfasdfasdfasdf", Type.Move, Monster_Race.NONE, false, 1, 0, 0);
        public static Item pokeCatcher = new Item("Catcher", "A device for catching wild PokeFraud. It is thrown like a ball at the target. It is designed as a capsule system.", Type.Item, Monster_Race.BATTLE, false, 50, 200, 100);
        public static Item repel = new Item("Repel", "An item that prevents weak wild PokeFraud from appearing for 100 steps after its use.", Type.Item, Monster_Race.NONE, false, 5, 350, 175);
        public static Item blazeStone = new Item("Blaze Stone", "A curious rock that powers up Fire-Type moves.", Type.Item, Monster_Race.Fire, false, 5, 1000, 500);
        public static Item aquaStone = new Item("Aqua Stone", "A curious rock that powers up Water-Type moves.", Type.Item, Monster_Race.Water, false, 5, 1000, 500);
        public static Item powerStone = new Item("Power Stone", "A curious rock that powers up Electric-Type moves.", Type.Item, Monster_Race.Electric, false, 5, 1000, 500);
        public static Item earthStone = new Item("Earth Stone", "A curious rock that powers up Ground-Type moves.", Type.Item, Monster_Race.Ground, false, 5, 1000, 500);
        public static Item mindStone = new Item("Mind Stone", "A curious rock that powers up Psychic-Type moves.", Type.Item, Monster_Race.Psychic, false, 5, 1000, 500);

        public static Item healthPotion = new Item("Health Potion", "A spray-type medicine for wounds. It restores the HP of one PokeFraud by just 20 points.", Type.Med, Monster_Race.PLAYER, false, 5, 300, 150);
        public static Item revive = new Item("Revive", "A medicine that revives a fainted PokeFraud. It restores half the PokeFraud's maximum HP.", Type.Med, Monster_Race.PLAYER, false, 5, 1500, 750);
        public static Item fullHeal = new Item("Full Heal", "A medicine that fully restores the HP and heals any status problems of a single PokeFraud.", Type.Med, Monster_Race.PLAYER, false, 5, 3000, 1500);
        public static Item fullRevive = new Item("Full Revive", "A medicine that revives a fainted PokeFraud. It fully restores the PokeFraud's HP.", Type.Med, Monster_Race.PLAYER, false, 5, 3000, 1500);
        public static Item attackUp = new Item("Attack-UP", "A PokeFraud nutrient that increases it's maximum attack stat by 1-point.", Type.Med, Monster_Race.PLAYER, false, 5, 5000, 2500);
        public static Item hpUp = new Item("HP-UP", "A PokeFraud nutrient that increases it's maximum HP by 1-point.", Type.Med, Monster_Race.PLAYER, false, 5, 5000, 2500);

        public static Item[] PokeMartItems = new Item[]
        {
            pokeCatcher,
            repel,
            blazeStone,
            aquaStone,
            powerStone,
            earthStone,
            mindStone,
            healthPotion,
            revive,
            fullHeal,
            fullRevive,
            attackUp,
            hpUp
        };

    }
}
