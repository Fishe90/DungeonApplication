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
    }
}
