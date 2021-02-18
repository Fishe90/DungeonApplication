using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainClasses;

namespace DungeonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(91, 47);
            ConsoleColor GBText = ConsoleColor.White;
            ConsoleColor GBBackground = ConsoleColor.Black;
            ConsoleColor GBColor = ConsoleColor.DarkRed;
            ConsoleKey navPlayerMenu = Console.ReadKey().Key;

            ASCII.GameBoy(GBColor);

            Monster_Moves Empty = new Monster_Moves("EMPTY", Monster_Race.NONE, 0, 0, 0);

            Monster_Moves fireEmber = new Monster_Moves("Ember", Monster_Race.Fire, 40, 15, 15);
            Monster_Moves waterWaterGun = new Monster_Moves("Water Gun", Monster_Race.Water, 40, 15, 15);
            Monster_Moves electricThunder = new Monster_Moves("Thunder", Monster_Race.Electric, 40, 15, 15);
            Monster_Moves groundRockSmash = new Monster_Moves("Rock Smash", Monster_Race.Ground, 40, 15, 15);
            Monster_Moves psychicPsychic = new Monster_Moves("Psychic", Monster_Race.Psychic, 40, 15, 15);

            Monster_MovesEquipped pyraDefault = new Monster_MovesEquipped(fireEmber, waterWaterGun, electricThunder, psychicPsychic);
            Monster_MovesEquipped douseyDefault = new Monster_MovesEquipped(waterWaterGun, Empty, Empty, Empty);
            Monster_MovesEquipped electraDefault = new Monster_MovesEquipped(electricThunder, Empty, Empty, Empty);
            Monster_MovesEquipped cobbletDefault = new Monster_MovesEquipped(groundRockSmash, Empty, Empty, Empty);
            Monster_MovesEquipped neoDefault = new Monster_MovesEquipped(psychicPsychic, Empty, Empty, Empty);

            Monster firePyra = new Monster("Pyra", "Pyra", '♂', false, 25, 50, 25, 0, 5, 1, "004", false, Monster_Race.Fire, "", ASCII.pyraAttacker, ASCII.pyraDefender, ASCII.pyraPokedex, pyraDefault);
            Monster waterDousey = new Monster("Dousey", "Dousey", '♂', false, 25, 50, 25, 0, 5, 1, "004", false, Monster_Race.Water, "", ASCII.douseyAttacker, ASCII.douseyDefender, ASCII.douseyPokedex, douseyDefault);
            Monster electricDousey = new Monster("Electra", "Electra", '♂', false, 25, 50, 25, 0, 5, 1, "004", false, Monster_Race.Electric, "", ASCII.electraAttacker, ASCII.electraDefender, ASCII.electraPokedex, electraDefault);
            Monster groundCobblet = new Monster("Cobblet", "Cobblet", '♂', false, 25, 50, 25, 0, 5, 1, "004", false, Monster_Race.Water, "", ASCII.cobbletAttacker, ASCII.cobbletDefender, ASCII.cobbletPokedex, cobbletDefault);
            Monster psychicNeo = new Monster("Neo", "Neo", '♂', false, 25, 50, 25, 0, 5, 1, "004", false, Monster_Race.Water, "", ASCII.neoAttacker, ASCII.neoDefender, ASCII.neoPokedex, neoDefault);

            Player player1 = new Player();
            player1.Name = "Dillon";
            player1.MonsterEquipped = firePyra;
            player1.Money = 0;
            Player NPC = new Player();
            NPC.Name = "Bryan";
            NPC.MonsterEquipped = waterDousey;
            NPC.ASCIIDefender = ASCII.npcDefender;
            NPC.ASCIIProfile = ASCII.npcProfile;

            //ASCII.DISATTandDEF(player1, NPC.MonsterEquipped, GBText, GBBackground);
            //ASCII.DISSelectFight(player1.MonsterEquipped,GBText, GBBackground);
            //Player_Menus.FightMenu(player1, NPC.MonsterEquipped, navPlayerMenu, GBText, GBBackground);

            ASCII.FullBattleWild(player1, Monster.starters, 3, 6, GBText, GBBackground, navPlayerMenu);
        }
    }
}
