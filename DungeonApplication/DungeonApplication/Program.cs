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
            string message = "Hello and welcome to the wonderful world of POKeFRAUD!";
            Console.SetWindowSize(91, 47);
            ConsoleColor GBText = ConsoleColor.White;
            ConsoleColor GBBackground = ConsoleColor.Black;
            ConsoleColor GBColor = ConsoleColor.DarkRed;
            ASCII.GameBoy(GBColor);
            ASCII.ResetScreen(ConsoleColor.Black, ConsoleColor.White);
            //ASCII.StaticMessageBox(GBColor, GBText, GBBackground);
            //ASCII.ScrollMessage(message, 50, 1000, GBColor, GBText, GBBackground);
            //ASCII.InstantMessage(message, GBColor, GBText, GBBackground);
            Monster_Moves defaultMove = new Monster_Moves();
            Monster_MovesEquipped pyraEquipped = new Monster_MovesEquipped();
            Monster monster = new Monster();
            monster.ANIWild = ASCII.pyraANI;
            monster.ASCIIPlayer = ASCII.pyraAttacker;
            monster.Name = "Pyra";
            Player player1 = new Player();
            player1.Name = "Dillon";
            player1.MonsterEquipped = monster;
            ASCII.StaticPMScreen(ASCII.PMPokedexSelect, player1, GBText, GBBackground);
            ASCII.ResetScreen(GBText, GBBackground);
            ASCII.WildEncounter(player1, monster, GBText, GBBackground);
        }
    }
}
