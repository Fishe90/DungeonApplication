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
        public bool IsOwned { get; set; }
        public string Description { get; set; }
        public string[] ASCIIAttacker { get; set; }
        public string[] ASCIIDefender { get; set; }
        public string[] ASCIIPokedex { get; set; }
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

        public Monster(string defaultName, string name, char gender, bool isBoosted, int maxHealth, int maxExp, int health, int exp, int lv, int slotNum, string pokeIndex, bool isCaught, Monster_Race type, bool isOwned, string description, string[] asciiAttacker, string[] asciiDefender, string[] asciiPokedex, Monster_MovesEquipped equippedMoves) : base(defaultName, name, gender, isBoosted)
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
            IsOwned = isOwned;
            Description = description;
            ASCIIAttacker = asciiAttacker;
            ASCIIDefender = asciiDefender;
            ASCIIPokedex = asciiPokedex;
            EquippedMoves = equippedMoves;
        }// end FQCTOR  

        /****NPC Monster Library****/

        public static Monster rivalPyra = new Monster("Pyra", "Pyra", '0', false, 0, 0, 0, 0, 0, 0, "001", false, Monster_Race.Fire, true, "", ASCII.pyraAttacker, ASCII.pyraDefender, ASCII.pyraPokedex, Monster_MovesEquipped.fireLow);
        public static Monster rivalDousey = new Monster("Dousey", "Dousey", '0', false, 0, 0, 0, 0, 0, 0, "004", false, Monster_Race.Water, true, "", ASCII.douseyAttacker, ASCII.douseyDefender, ASCII.douseyPokedex, Monster_MovesEquipped.waterLow);
        public static Monster rivalElectra = new Monster("Electra", "Electra", '0', false, 0, 0, 0, 0, 0, 0, "007", false, Monster_Race.Electric, true, "", ASCII.electraAttacker, ASCII.electraDefender, ASCII.electraPokedex, Monster_MovesEquipped.electricLow);
        public static Monster rivalCobblet = new Monster("Cobblet", "Cobblet", '0', false, 0, 0, 0, 0, 0, 0, "010", false, Monster_Race.Ground, true, "", ASCII.cobbletAttacker, ASCII.cobbletDefender, ASCII.cobbletPokedex, Monster_MovesEquipped.groundLow);
        public static Monster rivalNeo = new Monster("Neo", "Neo", '0', false, 0, 0, 0, 0, 0, 0, "013", false, Monster_Race.Psychic, true, "", ASCII.neoAttacker, ASCII.neoDefender, ASCII.neoPokedex, Monster_MovesEquipped.psychicLow);


        /****Player Monster Library****/

        public static Monster pyra = new Monster("Pyra", "Pyra", '♂', false, 25, 50, 25, 0, 5, 0, "001", false, Monster_Race.Fire, true, "", ASCII.pyraAttacker, ASCII.pyraDefender, ASCII.pyraPokedex, Monster_MovesEquipped.fireLow);
        public static Monster dousey = new Monster("Dousey", "Dousey", '♂', false, 25, 50, 25, 0, 5, 0, "004", false, Monster_Race.Water, true, "", ASCII.douseyAttacker, ASCII.douseyDefender, ASCII.douseyPokedex, Monster_MovesEquipped.waterLow);
        public static Monster electra = new Monster("Electra", "Electra", '♂', false, 25, 50, 25, 0, 5, 0, "007", false, Monster_Race.Electric, true, "", ASCII.electraAttacker, ASCII.electraDefender, ASCII.electraPokedex, Monster_MovesEquipped.electricLow);
        public static Monster cobblet = new Monster("Cobblet", "Cobblet", '♂', false, 25, 50, 25, 0, 5, 0, "010", false, Monster_Race.Ground, true, "", ASCII.cobbletAttacker, ASCII.cobbletDefender, ASCII.cobbletPokedex, Monster_MovesEquipped.groundLow);
        public static Monster neo = new Monster("Neo", "Neo", '♂', false, 25, 50, 25, 0, 5, 0, "013", false, Monster_Race.Psychic, true, "", ASCII.neoAttacker, ASCII.neoDefender, ASCII.neoPokedex, Monster_MovesEquipped.psychicLow);

        public static Monster[] starters = new Monster[]
        {
            pyra, pyra, pyra, pyra, pyra,
            dousey, dousey, dousey, dousey ,dousey,
            electra, electra, electra, electra, electra,
            cobblet, cobblet, cobblet, cobblet, cobblet,
            neo
        };
    }
}
