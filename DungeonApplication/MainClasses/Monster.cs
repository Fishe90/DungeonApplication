using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses
{
    public class Monster : Character
    {
        private int _health;
        private int _exp;

        public int MaxHealth { get; set; }
        public int MaxExp { get; set; }
        public int Lv { get; set; }
        public int SlotNum { get; set; }
        public string PokeIndex { get; set; }
        public bool IsCaught { get; set; }
        public Monster_Race Type { get; set; }
        public string Description { get; set; }
        public string ASCIIPlayer { get; set; }
        public string ASCIIWild { get; set; }
        public string ASCIIPokeDex { get; set; }
        public Monster_MovesEquipped EquippedMoves { get; set; }

        public int Health
        {
            get { return _health; }
            set
            {
                _health = value <= MaxHealth ? value : MaxHealth;
            }
        }

        public int Exp
        {
            get { return _exp; }
            set
            {
                _exp = value <= MaxExp ? value : MaxExp;
            }
        }

        public Monster() { }

        public Monster(string defaultName, string name, char gender, bool isBoosted, int maxHealth, int maxExp, int health, int exp, int lv, int slotNum, string pokeIndex, bool isCaught, Monster_Race type, string description, string asciiPlayer, string asciiWild, string asciiPokeDex, Monster_MovesEquipped equippedMoves) : base(defaultName, name, gender, isBoosted)
        {
            MaxHealth = maxHealth;
            MaxExp = maxExp;
            Health = health;
            Exp = exp;
            Lv = lv;
            SlotNum = slotNum;
            PokeIndex = pokeIndex;
            IsCaught = isCaught;
            Type = type;
            Description = description;
            ASCIIPlayer = asciiPlayer;
            ASCIIWild = asciiWild;
            ASCIIPokeDex = asciiPokeDex;
            EquippedMoves = equippedMoves;
        }// end FQCTOR        

        public override string ToString()
        {
            return string.Format($@"
{Name}  {Gender}Lv{Lv}
{IsCaught}    HP: {Health}");
        }
    }
    }
