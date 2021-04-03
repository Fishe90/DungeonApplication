using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using MainClasses;

namespace DungeonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Current Line Count: 15,358
             * 
             * ASCII: 7191
             * Character: 27
             * Combat: 891
             * Maps: 1249
             * Monster: 235
             * Monster_Moves: 46
             * Monster_MovesEquipped: 43
             * Monster_Race: 25
             * Player: 63
             * Player_Inventory: 92
             * Player_Menus: 5145
             * Player_Party: 33
             * SFX: 318
             */
            Console.CursorVisible = false;
            Console.Title = "POKeFRAUD: QUARTZ VERSION";
            Console.SetWindowSize(91, 43);
            ConsoleColor gbText = ConsoleColor.White;
            ConsoleColor gbBackground = ConsoleColor.Black;
            ConsoleColor GBColor = ConsoleColor.DarkGreen;
            ConsoleKey navPlayerMenu = Console.ReadKey().Key;

            ASCII.TimePlayed.Start();

            ASCII.GameBoy(GBColor);

            #region Player Starting Stats

            Player player1 = new Player();
            player1.PlayerID = ASCII.random.Next(20000, 40000);
            player1.Party = new Player_Party();
            player1.Pokedex = Monster.Pokedex;
            player1.Inventory = new Player_Inventory();
            player1.StartTime = DateTime.Now.ToString($"{0:MMM dd}, {0:yyyy}");
            player1.PC = Monster.PC;
            player1.Party.MonsterEquipped = Monster.starterNeo;
            player1.Party.Slot2 = Monster.testPyra;
            player1.Party.Slot3 = Monster.testDowsey;
            player1.Party.Slot4 = Monster.testElectra;
            player1.Party.Slot5 = Monster.testCobblet;
            //player1.Party.Slot5.Health = 0;
            //player1.Party.Slot5.Name = "";
            player1.Party.Slot6 = Monster.default6;
            player1.Party.Slot6.Health = 0;
            player1.Party.Slot6.Name = "";
            player1.Party.MonsterSwitch = Monster.monsterSwitch;
            player1.Name = "Dillon";
            player1.Gender = '♀';
            player1.Money = 0;
            player1.PC[1] = Monster.testPyra;
            player1.PC[2] = Monster.testDowsey;

            #endregion

            #region NPC Bryan Stats

            Player NPC = new Player();
            NPC.Name = "Bryan";
            NPC.Party = new Player_Party();
            NPC.Party.MonsterEquipped = Monster.rivalPyra;
            NPC.Party.Slot2 = Monster.rivalElectra;
            NPC.Party.Slot3 = Monster.rivalCobblet;
            NPC.Party.Slot4 = new Monster();
            NPC.Party.Slot4.Type = Monster_Race.NONE;
            NPC.Party.Slot4.Health = 0;
            NPC.Party.Slot5 = new Monster();
            NPC.Party.Slot5.Type = Monster_Race.NONE;
            NPC.Party.Slot5.Health = 0;
            NPC.Party.Slot6 = new Monster();
            NPC.Party.Slot6.Type = Monster_Race.NONE;
            NPC.Party.Slot6.Health = 0;
            NPC.Party.MonsterSwitch = new Monster();
            NPC.Party.MonsterSwitch.Type = Monster_Race.NONE;
            NPC.ASCIIDefender = ASCII.npcDefender;
            NPC.ASCIIProfile = ASCII.npcProfile;

            #endregion

            

            int currentPosX = 167;
            int currentPosY = 56;

            //x = 4; y = 2
            int startY = 2;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            foreach (string line in ASCII.emptyPC)
            {
                Console.SetCursorPosition(4, startY);
                Console.Write(line);
                startY += 1;
            }
            //Player_Menus.PC(player1, new Monster(), new int(), false, navPlayerMenu, gbText, gbBackground);
            //Player_Menus.PCSwitch(navPlayerMenu, gbText, gbBackground);
            //Player_Menus.PCInner(player1, new Monster(), navPlayerMenu, gbText, gbBackground);
            //navPlayerMenu = Console.ReadKey().Key;

            //ASCII.DEMO(navPlayerMenu, currentPosX, currentPosY);
            SFX.Route2();
            Maps.DEMOMap(player1, NPC, currentPosX, currentPosY, navPlayerMenu, gbText, gbBackground);
        }
    }
}
