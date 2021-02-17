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
            ASCII.GameBoy(GBColor);

            Monster_Moves Empty = new Monster_Moves("EMPTY", Monster_Race.NONE, 0, 0, 0);
            Monster_Moves fireEmber = new Monster_Moves("Ember", Monster_Race.Fire, 20, 15, 15);
            Monster_Moves waterWaterGun = new Monster_Moves("Water Gun", Monster_Race.Water, 20, 15, 15);

            Monster_MovesEquipped pyraDefault = new Monster_MovesEquipped(fireEmber, Empty, Empty, Empty);
            Monster_MovesEquipped douseyDefault = new Monster_MovesEquipped(waterWaterGun, Empty, Empty, Empty);

            Monster firePyra = new Monster("Pyra", "Pyra", '♂', false, 25, 50, 25, 0, 5, 1, "004", false, Monster_Race.Fire, "", ASCII.pyraAttacker, ASCII.pyraDefender, ASCII.pyraPokedex, pyraDefault);
            Monster waterDousey = new Monster("Dousey", "Dousey", '♂', false, 25, 50, 25, 0, 5, 1, "004", false, Monster_Race.Water, "", ASCII.douseyAttacker, ASCII.douseyDefender, ASCII.douseyPokedex, douseyDefault);

            Player player1 = new Player();
            player1.Name = "Dillon";
            player1.MonsterEquipped = firePyra;
            player1.Money = 0;
            Player NPC = new Player();
            NPC.Name = "Bryan";
            NPC.MonsterEquipped = waterDousey;
            NPC.ASCIIDefender = ASCII.npcDefender;
            NPC.ASCIIProfile = ASCII.npcProfile;

            ASCII.NPCEncounter(player1, NPC, GBText, GBBackground);
            ASCII.ANIDefenderFaint(NPC.MonsterEquipped, GBText, GBBackground);
            ASCII.ANIAttackerFaint(player1, GBText, GBBackground);
            ASCII.ANINPCNext(player1, NPC, GBText, GBBackground);
            ASCII.ANINPCDefeat(player1, NPC, 500, GBText, GBBackground);
        }
    }
}
