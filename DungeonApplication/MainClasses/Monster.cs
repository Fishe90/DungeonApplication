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
        public static Monster starterPyra = new Monster("Pyra", "Pyra", '♂', false, 25, 25, 25, 0, 5, 0, "001", false, Monster_Race.Fire, true, "", ASCII.pyraAttacker, ASCII.pyraDefender, ASCII.pyraPokedex, Monster_MovesEquipped.fireLow);
        public static Monster starterDousey = new Monster("Dousey", "Dousey", '♂', false, 25, 25, 25, 0, 5, 0, "004", false, Monster_Race.Water, true, "", ASCII.douseyAttacker, ASCII.douseyDefender, ASCII.douseyPokedex, Monster_MovesEquipped.waterLow);
        public static Monster starterElectra = new Monster("Electra", "Electra", '♂', false, 25, 25, 25, 0, 5, 0, "007", false, Monster_Race.Electric, true, "", ASCII.electraAttacker, ASCII.electraDefender, ASCII.electraPokedex, Monster_MovesEquipped.electricLow);
        public static Monster starterNeo = new Monster("Neo", "Neo", '♂', false, 25, 25, 25, 0, 5, 0, "013", false, Monster_Race.Psychic, true, "", ASCII.neoAttacker, ASCII.neoDefender, ASCII.neoPokedex, Monster_MovesEquipped.psychicLow);
        #endregion

        #region Wild Monsters
        public static Monster Pyra = new Monster("Pyra", "Pyra", '♂', false, 25, 0, 25, 0, 5, 0, "001", false, Monster_Race.Fire, false, "", ASCII.pyraAttacker, ASCII.pyraDefender, ASCII.pyraPokedex, Monster_MovesEquipped.fireLow);
        public static Monster Dousey = new Monster("Dousey", "Dousey", '♂', false, 0, 0, 0, 0, 0, 0, "004", false, Monster_Race.Water, false, "", ASCII.douseyAttacker, ASCII.douseyDefender, ASCII.douseyPokedex, Monster_MovesEquipped.waterLow);
        public static Monster Electra = new Monster("Electra", "Electra", '♂', false, 0, 0, 0, 0, 0, 0, "007", false, Monster_Race.Electric, false, "", ASCII.electraAttacker, ASCII.electraDefender, ASCII.electraPokedex, Monster_MovesEquipped.electricLow);
        public static Monster Cobblet = new Monster("Cobblet", "Cobblet", '♂', false, 25, 0, 25, 0, 5, 0, "010", false, Monster_Race.Ground, false, "", ASCII.cobbletAttacker, ASCII.cobbletDefender, ASCII.cobbletPokedex, Monster_MovesEquipped.groundLow);
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
        public static Monster[] monsters = new Monster[]
            {
                Pyra, Pyra, Pyra, Pyra, Pyra,
                Dousey, Dousey, Dousey, Dousey, Dousey,
                Electra, Electra, Electra, Electra, Electra,
                Cobblet, Cobblet, Cobblet, Cobblet, Cobblet
            };
        #endregion

        #region Player PC[]

        public static Monster emptySlot1 = new Monster();
        public static Monster emptySlot2 = new Monster();
        public static Monster emptySlot3 = new Monster();
        public static Monster emptySlot4 = new Monster();
        public static Monster emptySlot5 = new Monster();
        public static Monster emptySlot6 = new Monster();
        public static Monster emptySlot7 = new Monster();
        public static Monster emptySlot8 = new Monster();
        public static Monster emptySlot9 = new Monster();
        public static Monster emptySlot10 = new Monster();
        public static Monster emptySlot11 = new Monster();
        public static Monster emptySlot12 = new Monster();
        public static Monster emptySlot13 = new Monster();
        public static Monster emptySlot14 = new Monster();
        public static Monster emptySlot15 = new Monster();
        public static Monster emptySlot16 = new Monster();
        public static Monster emptySlot17 = new Monster();
        public static Monster emptySlot18 = new Monster();
        public static Monster emptySlot19 = new Monster();
        public static Monster emptySlot20 = new Monster();
        public static Monster emptySlot21 = new Monster();
        public static Monster emptySlot22 = new Monster();
        public static Monster emptySlot23 = new Monster();
        public static Monster emptySlot24 = new Monster();
        public static Monster emptySlot25 = new Monster();
        public static Monster emptySlot26 = new Monster();
        public static Monster emptySlot27 = new Monster();
        public static Monster emptySlot28 = new Monster();
        public static Monster emptySlot29 = new Monster();
        public static Monster emptySlot30 = new Monster();

        public static Monster[] PC =
        {
            emptySlot1,emptySlot2,emptySlot3,emptySlot4,emptySlot5,emptySlot6,emptySlot7,emptySlot8,emptySlot9,emptySlot10,
            emptySlot11,emptySlot12,emptySlot13,emptySlot14,emptySlot15,emptySlot16,emptySlot17,emptySlot18,emptySlot19,emptySlot20,
            emptySlot21,emptySlot22,emptySlot23,emptySlot24,emptySlot25,emptySlot26,emptySlot27,emptySlot28,emptySlot29,emptySlot30
            };

        #endregion

    }
}
