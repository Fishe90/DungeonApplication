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

        #region NPC Monsters

        #region Rival Starters

        public static Monster rivalPyra = new Monster("Pyra", "Pyra", '♂', false, 25, 0, 25, 0, 5, 0, "001", false, Monster_Race.Fire, true, "", ASCII.pyraAttacker, ASCII.pyraDefender, ASCII.pyraPokedex, Monster_MovesEquipped.fireLow);
        public static Monster rivalDousey = new Monster("Dousey", "Dousey", '♂', false, 25, 0, 25, 0, 5, 0, "004", false, Monster_Race.Water, true, "", ASCII.douseyAttacker, ASCII.douseyDefender, ASCII.douseyPokedex, Monster_MovesEquipped.waterLow);
        public static Monster rivalElectra = new Monster("Electra", "Electra", '♂', false, 25, 0, 25, 0, 5, 0, "007", false, Monster_Race.Electric, true, "", ASCII.electraAttacker, ASCII.electraDefender, ASCII.electraPokedex, Monster_MovesEquipped.electricLow);
        public static Monster rivalCobblet = new Monster("Cobblet", "Cobblet", '♂', false, 25, 0, 25, 0, 5, 0, "010", false, Monster_Race.Ground, true, "", ASCII.cobbletAttacker, ASCII.cobbletDefender, ASCII.cobbletPokedex, Monster_MovesEquipped.groundLow);
        public static Monster rivalNeo = new Monster("Neo", "Neo", '♂', false, 25, 50, 25, 0, 5, 0, "013", false, Monster_Race.Psychic, true, "", ASCII.neoAttacker, ASCII.neoDefender, ASCII.neoPokedex, Monster_MovesEquipped.psychicLow);

        #endregion

        #endregion

        #region Player Choose Starter
        public static Monster starterPyra = new Monster("Pyra", "Pyra", '♂', false, 25, 50, 25, 0, 5, 0, "001", false, Monster_Race.Fire, true, "", ASCII.pyraAttacker, ASCII.pyraDefender, ASCII.pyraPokedex, Monster_MovesEquipped.fireLow);
        public static Monster starterDousey = new Monster("Dousey", "Dousey", '♂', false, 25, 50, 25, 0, 5, 0, "004", false, Monster_Race.Water, true, "", ASCII.douseyAttacker, ASCII.douseyDefender, ASCII.douseyPokedex, Monster_MovesEquipped.waterLow);
        public static Monster starterElectra = new Monster("Electra", "Electra", '♂', false, 25, 50, 25, 0, 5, 0, "007", false, Monster_Race.Electric, true, "", ASCII.electraAttacker, ASCII.electraDefender, ASCII.electraPokedex, Monster_MovesEquipped.electricLow);
        public static Monster starterNeo = new Monster("Neo", "Neo", '♂', false, 25, 50, 25, 0, 5, 0, "013", false, Monster_Race.Psychic, true, "", ASCII.neoAttacker, ASCII.neoDefender, ASCII.neoPokedex, Monster_MovesEquipped.psychicLow);
        #endregion

        #region Wild Monsters
        public static Monster Pyra = new Monster("Pyra", "Pyra", '♂', false, 0, 0, 0, 0, 0, 0, "001", false, Monster_Race.Fire, true, "", ASCII.pyraAttacker, ASCII.pyraDefender, ASCII.pyraPokedex, Monster_MovesEquipped.fireLow);
        public static Monster Dousey = new Monster("Dousey", "Dousey", '♂', false, 0, 0, 0, 0, 0, 0, "004", false, Monster_Race.Water, true, "", ASCII.douseyAttacker, ASCII.douseyDefender, ASCII.douseyPokedex, Monster_MovesEquipped.waterLow);
        public static Monster Electra = new Monster("Electra", "Electra", '♂', false, 0, 0, 0, 0, 0, 0, "007", false, Monster_Race.Electric, true, "", ASCII.electraAttacker, ASCII.electraDefender, ASCII.electraPokedex, Monster_MovesEquipped.electricLow);
        public static Monster Cobblet = new Monster("Cobblet", "Cobblet", '♂', false, 0, 0, 0, 0, 0, 0, "010", false, Monster_Race.Ground, true, "", ASCII.cobbletAttacker, ASCII.cobbletDefender, ASCII.cobbletPokedex, Monster_MovesEquipped.groundLow);
        #endregion

        #region Player Starter Party
        public static Monster default2 = new Monster();
        public static Monster default3 = new Monster();
        public static Monster default4 = new Monster();
        public static Monster default5 = new Monster();
        public static Monster default6 = new Monster();
        public static Monster monsterSwitch = new Monster();
        #endregion

        #region Wild Monster[] BY REGION
        Monster[] monsters = new Monster[]
            {
                Monster.Pyra, Monster.Pyra, Monster.Pyra, Monster.Pyra, Monster.Pyra,
                Monster.Dousey, Monster.Dousey, Monster.Dousey, Monster.Dousey, Monster.Dousey,
                Monster.Electra, Monster.Electra, Monster.Electra, Monster.Electra, Monster.Electra,
                Monster.Cobblet, Monster.Cobblet, Monster.Cobblet, Monster.Cobblet, Monster.Cobblet
            };
        #endregion

    }
}
