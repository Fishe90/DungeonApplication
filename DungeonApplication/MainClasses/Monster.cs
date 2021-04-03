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

        #region TEST MONSTERS

        public static Monster testPyra = new Monster("Pyra", "Pyra", '♂', false, 25, 25, 25, 0, 5, 0, "001", false, Monster_Race.Fire, false, "", ASCII.pyraAttacker, ASCII.pyraDefender, ASCII.pyraPokedex, Monster_MovesEquipped.fireLow);
        public static Monster testDowsey = new Monster("Dowsey", "Dowsey", '♂', false, 25, 25, 25, 0, 5, 0, "004", false, Monster_Race.Water, false, "", ASCII.dowseyAttacker, ASCII.dowseyDefender, ASCII.dowseyPokedex, Monster_MovesEquipped.waterLow);
        public static Monster testElectra = new Monster("Electra", "Electra", '♂', false, 25, 25, 25, 0, 5, 0, "007", false, Monster_Race.Electric, false, "", ASCII.electraAttacker, ASCII.electraDefender, ASCII.electraPokedex, Monster_MovesEquipped.electricLow);
        public static Monster testCobblet = new Monster("Cobblet", "Cobblet", '♂', false, 25, 25, 25, 0, 5, 0, "010", false, Monster_Race.Ground, false, "", ASCII.cobbletAttacker, ASCII.cobbletDefender, ASCII.cobbletPokedex, Monster_MovesEquipped.groundLow);

        #endregion

        #region NPC Monsters

        #region Rival Starters

        public static Monster rivalPyra = new Monster("Pyra", "Pyra", '♂', false, 25, 0, 25, 0, 5, 0, "001", false, Monster_Race.Fire, true, "", ASCII.pyraAttacker, ASCII.pyraDefender, ASCII.pyraPokedex, Monster_MovesEquipped.fireLow);
        public static Monster rivalDowsey = new Monster("Dowsey", "Dowsey", '♂', false, 25, 0, 25, 0, 5, 0, "004", false, Monster_Race.Water, true, "", ASCII.dowseyAttacker, ASCII.dowseyDefender, ASCII.dowseyPokedex, Monster_MovesEquipped.waterLow);
        public static Monster rivalElectra = new Monster("Electra", "Electra", '♂', false, 25, 0, 25, 0, 5, 0, "007", false, Monster_Race.Electric, true, "", ASCII.electraAttacker, ASCII.electraDefender, ASCII.electraPokedex, Monster_MovesEquipped.electricLow);
        public static Monster rivalCobblet = new Monster("Cobblet", "Cobblet", '♂', false, 25, 0, 25, 0, 5, 0, "010", false, Monster_Race.Ground, true, "", ASCII.cobbletAttacker, ASCII.cobbletDefender, ASCII.cobbletPokedex, Monster_MovesEquipped.groundLow);
        public static Monster rivalNeo = new Monster("Neo", "Neo", '♂', false, 25, 50, 25, 0, 5, 0, "013", false, Monster_Race.Psychic, true, "", ASCII.neoAttacker, ASCII.neoDefender, ASCII.neoPokedex, Monster_MovesEquipped.psychicLow);

        #endregion

        #endregion

        #region Player Choose Starter
        public static Monster starterPyra = new Monster("Pyra", "Pyra", '♂', false, 25, 25, 25, 0, 5, 0, "001", false, Monster_Race.Fire, true, "", ASCII.pyraAttacker, ASCII.pyraDefender, ASCII.pyraPokedex, Monster_MovesEquipped.fireLow);
        public static Monster starterDowsey = new Monster("Dowsey", "Dowsey", '♂', false, 25, 25, 25, 0, 5, 0, "004", false, Monster_Race.Water, true, "", ASCII.dowseyAttacker, ASCII.dowseyDefender, ASCII.dowseyPokedex, Monster_MovesEquipped.waterLow);
        public static Monster starterElectra = new Monster("Electra", "Electra", '♂', false, 25, 25, 25, 0, 5, 0, "007", false, Monster_Race.Electric, true, "", ASCII.electraAttacker, ASCII.electraDefender, ASCII.electraPokedex, Monster_MovesEquipped.electricLow);
        public static Monster starterNeo = new Monster("Neo", "Neo", '♂', false, 25, 25, 25, 0, 5, 0, "013", false, Monster_Race.Psychic, true, "", ASCII.neoAttacker, ASCII.neoDefender, ASCII.neoPokedex, Monster_MovesEquipped.psychicLow);
        #endregion

        #region Wild Monsters
        public static Monster Pyra = new Monster("Pyra", "Pyra", '♂', false, 25, 0, 25, 0, 5, 0, "001", false, Monster_Race.Fire, false, "", ASCII.pyraAttacker, ASCII.pyraDefender, ASCII.pyraPokedex, Monster_MovesEquipped.fireLow);
        public static Monster Dowsey = new Monster("Dowsey", "Dowsey", '♂', false, 0, 0, 0, 0, 0, 0, "004", false, Monster_Race.Water, false, "", ASCII.dowseyAttacker, ASCII.dowseyDefender, ASCII.dowseyPokedex, Monster_MovesEquipped.waterLow);
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

        //DEMO 
        public static Monster[] monsters = new Monster[]
            {
                Pyra, Pyra, Pyra, Pyra, Pyra,
                Dowsey, Dowsey, Dowsey, Dowsey, Dowsey,
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

        public static Monster[] PC =
        {
            emptySlot1,emptySlot2,emptySlot3,emptySlot4,emptySlot5,emptySlot6,emptySlot7,emptySlot8,emptySlot9,emptySlot10,
            emptySlot11,emptySlot12,emptySlot13,emptySlot14,emptySlot15,emptySlot16,emptySlot17,emptySlot18,emptySlot19,emptySlot20,
            emptySlot21,emptySlot22,emptySlot23,emptySlot24,emptySlot25
            };

        #endregion

        #region Player Pokedex[]

        public static Monster Pyra001 = new Monster
        {
            DefaultName = "Pyra",
            PokeIndex = "001",
            Description = "",
            Type = Monster_Race.NONE,
            IsCaught = false
        };
        public static Monster Dowsey004 = new Monster
        {
            DefaultName = "Dowsey",
            PokeIndex = "004",
            Description = "",
            Type = Monster_Race.NONE,
            IsCaught = false
        };
        public static Monster Electra007 = new Monster
        {
            DefaultName = "Electra",
            PokeIndex = "007",
            Description = "",
            Type = Monster_Race.NONE,
            IsCaught = false
        };
        public static Monster Cobblet010 = new Monster
        {
            DefaultName = "Electra",
            PokeIndex = "010",
            Description = "",
            Type = Monster_Race.NONE,
            IsCaught = false
        };
        public static Monster Neo013 = new Monster
        {
            DefaultName = "Electra",
            PokeIndex = "013",
            Description = "",
            Type = Monster_Race.NONE,
            IsCaught = false
        };

        /**** FOR WHEN DISCOVERED BUT NO CAUGHT ****
         *
         * int startIndex = 1;
         * while (defender.DefaultName != player.Pokedex[startIndex].DefaultName && player.Pokedex[startIndex].Type != Monster_Race.NONE)
         * {
         *      startIndex += 1;
         * }
         *     
         * if(defender.DefaultName == player.Pokedex[startIndex].DefaultName && player.Pokedex[startIndex].Type != Monster_Race.NONE)
         * {
         *     player.Pokedex[startIndex].Type = defender.Type;
         * }
         * 
         **** FOR WHEN DISCOVERED AND CAUGHT ****
         * int startIndex = 1;
         * while (defender.DefaultName != player.Pokedex[startIndex].DefaultName && player.Pokedex[startIndex].isCaught != false)
         * {
         *      startIndex += 1;
         * } 
         */
        public static Monster[] Pokedex = new Monster[]
        {
            Pyra001,Dowsey004,Electra007,Cobblet010,Neo013
        };

        #endregion

    }
}
