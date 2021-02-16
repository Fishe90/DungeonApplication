using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses
{
    public class Player_Inventory
    {
        public ItemSection BagSlot1 { get; set; }
        public MedSection BagSlot2 { get; set; }
        public MoveSection BagSlot3 { get; set; }
        public BattleItemSection BagSlot4 { get; set; }

        public Player_Inventory(ItemSection bagSlot1, MedSection bagSlot2, MoveSection bagSlot3, BattleItemSection bagSlot4)
        {
            BagSlot1 = bagSlot1;
            BagSlot2 = bagSlot2;
            BagSlot3 = bagSlot3;
            BagSlot4 = bagSlot4;
        }

        public Player_Inventory() { }
    }

    public class ItemSection
    {
        public int PokeCatcher { get; set; }
        public int Repel { get; set; }
        public int BlazeStone { get; set; }
        public int AquaStone { get; set; }
        public int PowerStone { get; set; }
        public int EarthStone { get; set; }
        public int MindStone { get; set; }

        public ItemSection(int pokeCatcher, int repel, int blazeStone, int aquaStone, int powerStone, int earthStone, int mindStone)
        {
            PokeCatcher = pokeCatcher;
            Repel = repel;
            BlazeStone = blazeStone;
            AquaStone = aquaStone;
            PowerStone = powerStone;
            EarthStone = earthStone;
            MindStone = mindStone;
        }

        public ItemSection() { }
    }

    public class MedSection
    {
        public int HealthPotion { get; set; }
        public int FullHeal { get; set; }
        public int FullRevive { get; set; }
        public int HPUp { get; set; }
        public int AttackUp { get; set; }

        public MedSection(int healthPotion, int fullHeal, int fullRevive, int hpUp, int attackUp)
        {
            HealthPotion = healthPotion;
            FullHeal = fullHeal;
            FullRevive = fullRevive;
            HPUp = hpUp;
            AttackUp = attackUp;
        }

        public MedSection() { }
    }

    public class MoveSection
    {
        public MoveSection() { }
    }

    public class BattleItemSection
    {
        public BattleItemSection() { }
    }
}
