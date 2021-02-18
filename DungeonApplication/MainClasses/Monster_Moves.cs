using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses
{
    public class Monster_Moves
    {
        private int _uses;

        public string Name { get; set; }
        public Monster_Race Type { get; set; }
        public int Damage { get; set; }
        public int MaxUses { get; set; }

        public int Uses
        {
            get { return _uses; }
            set
            {
                _uses = value <= MaxUses ? value : MaxUses;
            }
        }

        public Monster_Moves() { }

        public Monster_Moves(string name, Monster_Race type, int damage, int maxUses, int uses)
        {
            Name = name;
            Type = type;
            Damage = damage;
            MaxUses = maxUses;
            Uses = uses;
        }

        public static Monster_Moves Empty = new Monster_Moves("NAME",Monster_Race.NONE,0,0,0);
        public static Monster_Moves fireEmber = new Monster_Moves("Ember",Monster_Race.Fire,40,15,15);
        public static Monster_Moves waterWaterGun = new Monster_Moves("Watergun", Monster_Race.Water, 40, 15, 15);
        public static Monster_Moves electricThundershock = new Monster_Moves("Thundershock", Monster_Race.Electric, 40, 15, 15);
        public static Monster_Moves groundMudshot = new Monster_Moves("Mudshot", Monster_Race.Ground, 40, 15, 15);
        public static Monster_Moves psychicConfusion = new Monster_Moves("Confusion", Monster_Race.Psychic, 40, 15, 15);
    }
}
