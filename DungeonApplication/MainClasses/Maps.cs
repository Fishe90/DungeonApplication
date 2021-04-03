using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MainClasses
{
    public class Maps
    {
        //TODO Add to movement where if the player keys in a direction that they aren't already facing in, make it so they face that direction first, then the next time they key in the same direction it allows movement.

        //TODO Add MINIGAMES in the PC menu that the player can play.

        #region Map TYPE Templates

        public static void RegionNoEncounter(string[] Map, Player player, int currentPosX, int currentPosY, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;

            do
            {
                Console.SetBufferSize(2000, 2000);
                ASCII.GameMap(Map, currentPosX, currentPosY, gbText, gbBackground);
                ASCII.PlayerForward(gbText, gbBackground);
                navPlayerMenu = Console.ReadKey().Key;

                switch (navPlayerMenu)
                {

                    case ConsoleKey.UpArrow: case ConsoleKey.W:
                        currentPosY -= 2;
                        if (currentPosY < 16)
                        {
                            currentPosY += 2;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.DownArrow: case ConsoleKey.S:
                        currentPosY += 2;
                        if (currentPosY > 64)
                        {
                            currentPosY -= 2;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.LeftArrow: case ConsoleKey.A:
                        currentPosX -= 5;
                        if (currentPosX < 63)
                        {
                            currentPosX += 5;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.RightArrow: case ConsoleKey.D:
                        currentPosX += 5;
                        if (currentPosX > 220)
                        {
                            currentPosX -= 5;
                        }
                        reloadTestMap = true;
                        break;
                    case ConsoleKey.M:
                        Player_Menus.PlayerMenu(player, navPlayerMenu, gbText, gbBackground);
                        reloadTestMap = true;
                        break;
                    default:
                        reloadTestMap = true;
                        break;
                }
            } while (reloadTestMap);
        }

        public static void RegionEncounter(string[] Map, Player player, Monster[] monsters, int direction, int currentPosX, int currentPosY, int lvLow, int lvHigh, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;
            Random rand = new Random();

            do
            {
                int encounterChance = rand.Next(0, 100);
                Console.SetBufferSize(2000, 2000);
                ASCII.GameMap(Map, currentPosX, currentPosY, gbText, gbBackground);
                ASCII.PlayerForward(gbText, gbBackground);
                navPlayerMenu = Console.ReadKey().Key;

                switch (navPlayerMenu)
                {

                    case ConsoleKey.UpArrow: case ConsoleKey.W:
                        currentPosY -= 2;
                        if (currentPosY < 1)
                        {
                            currentPosY += 2;
                        }
                        else if (encounterChance < 99)
                        {
                            reloadTestMap = true;
                        }
                        else
                        {
                            SFX.RivalBattle();
                            ASCII.BattleIntroFLASH(player, direction, currentPosX, currentPosY, Map);
                            ASCII.FullBattleWild(player, monsters, lvLow, lvHigh, gbText, gbBackground, navPlayerMenu);
                            SFX.Route2();
                            reloadTestMap = true;
                        }
                        //reloadTestMap = true;
                        break;

                    case ConsoleKey.DownArrow: case ConsoleKey.S:
                        currentPosY += 2;
                        if (currentPosY > 63)
                        {
                            currentPosY -= 2;
                        }
                        else if (encounterChance < 99)
                        {
                            reloadTestMap = true;
                        }
                        else
                        {
                            SFX.RivalBattle();
                            ASCII.BattleIntroFLASH(player, direction, currentPosX, currentPosY, Map);
                            ASCII.FullBattleWild(player, monsters, lvLow, lvHigh, gbText, gbBackground, navPlayerMenu);
                            SFX.Route2();
                            reloadTestMap = true;
                        }
                        //reloadTestMap = true;
                        break;

                    case ConsoleKey.LeftArrow: case ConsoleKey.A:
                        currentPosX -= 5;
                        if (currentPosX < 63)
                        {
                            currentPosX += 5;
                        }
                        else if (encounterChance < 99)
                        {
                            reloadTestMap = true;
                        }
                        else
                        {
                            SFX.RivalBattle();
                            ASCII.BattleIntroFLASH(player, direction, currentPosX, currentPosY, Map);
                            ASCII.FullBattleWild(player, monsters, lvLow, lvHigh, gbText, gbBackground, navPlayerMenu);
                            SFX.Route2();
                            reloadTestMap = true;
                        }
                        //reloadTestMap = true;
                        break;

                    case ConsoleKey.RightArrow: case ConsoleKey.D:
                        currentPosX += 5;
                        //if (currentPosX > TestMap.Length)
                        //{
                        //    currentPosX -= 4;
                        //}
                        if (encounterChance < 99)
                        {
                            reloadTestMap = true;
                        }
                        else
                        {
                            SFX.RivalBattle();
                            ASCII.BattleIntroFLASH(player, direction, currentPosX, currentPosY, Map);
                            ASCII.FullBattleWild(player, monsters, lvLow, lvHigh, gbText, gbBackground, navPlayerMenu);
                            SFX.Route2();
                            reloadTestMap = true;
                        }
                        //reloadTestMap = true;
                        break;
                    case ConsoleKey.M:
                        Player_Menus.PlayerMenu(player, navPlayerMenu, gbText, gbBackground);
                        reloadTestMap = true;
                        break;
                    default:
                        reloadTestMap = true;
                        break;
                }
            } while (reloadTestMap);
        }

        #endregion

        #region Maps

        public static void DEMOMap(Player player, Player npc, int currentPosX, int currentPosY, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;
            int posX = 180;
            int posY = 34;
            int direction = 6;
            Random rand = new Random();
            int encounterChance = rand.Next(0, 100);
            //(167,56) **Player Position            
            do
            {
                Console.SetBufferSize(2000, 2000);
                ASCII.GameMap(ASCII.DEMOMap, currentPosX, currentPosY, gbText, gbBackground);
                ASCII.CharacterMale((currentPosX - posX), (currentPosY - posY), gbText, gbBackground);
                ASCII.PlayerMovement(player, direction, gbText, gbBackground);
                //ASCII.PlayerForward(gbText, gbBackground);                
                navPlayerMenu = Console.ReadKey().Key;

                switch (navPlayerMenu)
                {

                    case ConsoleKey.UpArrow: case ConsoleKey.W:
                        direction += 1;
                        if (direction < 3)
                        {
                            direction = 3;
                        }
                        if (direction == 5)
                        {
                            direction -= 2;
                        }
                        if (direction == 6)
                        {
                            direction -= 3;
                        }
                        if (direction == 7)
                        {
                            direction -= 4;
                        }
                        currentPosY -= 2;
                        posY -= 4;
                        //Catching Field    
                        encounterChance = rand.Next(0, 100);
                        if (currentPosX <= 177 && currentPosX >= 107 && currentPosY >= 88 && currentPosY <= 98 && encounterChance > 98)
                        {
                            currentPosY += 2;
                            posY += 4;
                            SFX.Battle();
                            ASCII.BattleIntroFLASH(player, direction, currentPosX, currentPosY, ASCII.DEMOMap);
                            ASCII.FullBattleWild(player, Monster.monsters, 3, 5, gbText, gbBackground, navPlayerMenu);
                            SFX.Route2();
                        }
                        //Rival House
                        if (currentPosX == 102 && currentPosY == 54)
                        {
                            DEMORivalHouse(player, 30, 17, navPlayerMenu, gbText, gbBackground);
                            currentPosY += 2;
                            posY += 4;
                            direction = 6;
                        }
                        //PokeMart
                        if (currentPosX == 107 && currentPosY == 34)
                        {
                            SFX.EnterStore();
                            System.Threading.Thread.Sleep(1000);
                            DEMOPokeMart(player, 15, 17, navPlayerMenu, gbText, gbBackground);
                            SFX.Route2();
                            currentPosY += 2;
                            posY += 4;
                            direction = 6;
                        }
                        //PokeCenter
                        if (currentPosX == 172 && currentPosY == 34)
                        {
                            SFX.EnterStore();
                            System.Threading.Thread.Sleep(1000);
                            SFX.PokeCenter();
                            DEMOPokeCenter(player, 30, 17, navPlayerMenu, gbText, gbBackground);
                            SFX.Route2();
                            currentPosY += 2;
                            posY += 4;
                            direction = 6;
                        }
                        //Player's House
                        if (currentPosX == 167 && currentPosY == 54)
                        {
                            DEMOPlayerHouse(player, 30, 17, navPlayerMenu, gbText, gbBackground);
                            currentPosY += 2;
                            posY += 4;
                            direction = 6;
                        }
                        //Border Top
                        if (currentPosY < 16)
                        {
                            currentPosY += 2;
                            posY += 4;
                            direction = 6;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.DownArrow: case ConsoleKey.S:
                        direction += 1;
                        currentPosY += 2;
                        posY += 4;
                        if (direction < 5)
                        {
                            direction = 5;
                        }
                        if (direction == 7)
                        {
                            direction -= 2;
                        }                        
                        //Catching Field    
                        encounterChance = rand.Next(0, 100);
                        if (currentPosX <= 177 && currentPosX >= 107 && currentPosY >= 88 && currentPosY <= 98 && encounterChance > 98)
                        {
                            currentPosY -= 2;
                            posY -= 4;
                            SFX.Battle();
                            ASCII.BattleIntroFLASH(player, direction, currentPosX, currentPosY, ASCII.DEMOMap);
                            ASCII.FullBattleWild(player, Monster.monsters, 3, 5, gbText, gbBackground, navPlayerMenu);
                            SFX.Route2();
                        }
                        //Border Bottom
                        if (currentPosY > 106)
                        {
                            currentPosY -= 2;
                            posY -= 4;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.LeftArrow: case ConsoleKey.A:
                        direction = 1;
                        currentPosX -= 5;
                        posX -= 10;
                        //Catching Field    
                        encounterChance = rand.Next(0, 100);
                        if (currentPosX <= 177 && currentPosX >= 107 && currentPosY >= 88 && currentPosY <= 98 && encounterChance > 98)
                        {
                            currentPosX += 5;
                            posX += 10;
                            SFX.Battle();
                            ASCII.BattleIntroFLASH(player, direction, currentPosX, currentPosY, ASCII.DEMOMap);
                            ASCII.FullBattleWild(player, Monster.monsters, 3, 5, gbText, gbBackground, navPlayerMenu);
                            SFX.Route2();
                        }
                        //Border Left
                        if (currentPosX < 60)
                        {
                            currentPosX += 5;
                            posX += 10;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.RightArrow: case ConsoleKey.D:
                        direction = 2;
                        currentPosX += 5;
                        posX += 10;
                        //Catching Field    
                        encounterChance = rand.Next(0, 100);
                        if (currentPosX <= 177 && currentPosX >= 107 && currentPosY >= 88 && currentPosY <= 98 && encounterChance > 95)
                        {
                            currentPosX -= 5;
                            posX -= 10;
                            SFX.Battle();
                            ASCII.BattleIntroFLASH(player, direction, currentPosX, currentPosY, ASCII.DEMOMap);
                            ASCII.FullBattleWild(player, Monster.monsters, 3, 5, gbText, gbBackground, navPlayerMenu);
                            SFX.Route2();
                        }
                        //Border Right
                        if (currentPosX > 225)
                        {
                            currentPosX -= 5;
                            posX -= 10;
                        }
                        reloadTestMap = true;
                        break;
                    case ConsoleKey.M:
                        Player_Menus.PlayerMenu(player, navPlayerMenu, gbText, gbBackground);                        
                        reloadTestMap = true;
                        break;
                    case ConsoleKey.Enter: case ConsoleKey.K:
                    
                        string battle = "Do you want to battle?";
                        if (currentPosX == 117 && currentPosY == 68)
                        {
                            bool reloadBattleFAINT = false;
                            int menuPosY = 22;

                            ASCII.InstantMessage(battle, gbText, gbBackground);
                            Console.SetCursorPosition(65, 22);
                            Console.Write("YES");
                            Console.SetCursorPosition(65, 23);
                            Console.Write("NO");
                            do
                            {
                                Console.SetCursorPosition(61, menuPosY);
                                Console.Write("-->");
                                Console.SetCursorPosition(90, 42);
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.UpArrow: case ConsoleKey.W:                                   
                                        Console.SetCursorPosition(61, menuPosY);
                                        Console.Write("   ");
                                        menuPosY -= 1;
                                        if (menuPosY < 22)
                                        {
                                            menuPosY += 1;
                                        }
                                        reloadBattleFAINT = true;
                                        break;
                                    case ConsoleKey.DownArrow: case ConsoleKey.S:                                    
                                        Console.SetCursorPosition(61, menuPosY);
                                        Console.Write("   ");
                                        menuPosY += 1;
                                        if (menuPosY > 23)
                                        {
                                            menuPosY -= 1;
                                        }
                                        reloadBattleFAINT = true;
                                        break;
                                    case ConsoleKey.Enter: case ConsoleKey.K:                                    
                                        if (menuPosY == 22)
                                        {
                                            SFX.LeagueBattleRE();
                                            //SFX.LeagueBattleRE();
                                            ASCII.BattleIntroFLASH(player, direction, currentPosX, currentPosY, ASCII.DEMOMap);
                                            ASCII.FullBattleNPC(player, npc, gbText, gbBackground, navPlayerMenu);
                                            SFX.Route2();
                                            reloadBattleFAINT = false;
                                        }
                                        else if (menuPosY == 23)
                                        {
                                            reloadBattleFAINT = false;
                                        }
                                        break;
                                    case ConsoleKey.Backspace: case ConsoleKey.O:                                    
                                        reloadBattleFAINT = false;
                                        break;
                                    default:
                                        reloadBattleFAINT = true;
                                        break;
                                }
                            } while (reloadBattleFAINT);
                        }
                        else
                        {
                            reloadTestMap = true;
                        }                        
                        break;  
                    default:
                        reloadTestMap = true;
                        break;
                }
            } while (reloadTestMap);
        }

        public static void DEMOPlayerHouse(Player player, int currentPosX, int currentPosY, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;
            int direction = 4;
            //(30,17)
            do
            {
                Console.SetBufferSize(2000, 2000);
                ASCII.GameMap(ASCII.playerHouse, currentPosX, currentPosY, gbText, gbBackground);
                ASCII.PlayerMovement(player, direction, gbText, gbBackground);
                //ASCII.PlayerForward(gbText, gbBackground);
                navPlayerMenu = Console.ReadKey().Key;

                switch (navPlayerMenu)
                {

                    case ConsoleKey.UpArrow: case ConsoleKey.W:
                        direction += 1;
                        if (direction < 3)
                        {
                            direction = 3;
                        }
                        if (direction == 5)
                        {
                            direction -= 2;
                        }
                        if (direction == 6)
                        {
                            direction -= 3;
                        }
                        if (direction == 7)
                        {
                            direction -= 4;
                        }
                        currentPosY -= 2;                        
                        if (currentPosY < 3)
                        {
                            currentPosY += 2;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.DownArrow: case ConsoleKey.S:
                        direction += 1;
                        if (direction < 5)
                        {
                            direction = 5;
                        }
                        if (direction == 7)
                        {
                            direction -= 2;
                        }
                        currentPosY += 2;
                        if (currentPosX == 30 && currentPosY > 17)
                        {
                            currentPosY -= 2;
                            reloadTestMap = false;
                        }
                        if (currentPosY > 17)
                        {
                            currentPosY -= 2;
                            reloadTestMap = true;
                        }                  
                        break;

                    case ConsoleKey.LeftArrow: case ConsoleKey.A:
                        direction = 1;
                        currentPosX -= 5;
                        if (currentPosX == 45 && currentPosY == 3)
                        {
                            DEMOPlayerRoom(player, 45, 3, navPlayerMenu, gbText, gbBackground);
                            currentPosX += 5;
                            direction = 2;
                            reloadTestMap = true;
                        }
                        if (currentPosX < 5)
                        {
                            currentPosX += 5;
                            reloadTestMap = true;
                        }                        
                        break;

                    case ConsoleKey.RightArrow: case ConsoleKey.D:
                        direction = 2;
                        currentPosX += 5;
                        if (currentPosX > 55)
                        {
                            currentPosX -= 5;
                        }
                        reloadTestMap = true;
                        break;
                    case ConsoleKey.M:
                        Player_Menus.PlayerMenu(player, navPlayerMenu, gbText, gbBackground);
                        reloadTestMap = true;
                        break;
                    default:
                        reloadTestMap = true;
                        break;
                }
            } while (reloadTestMap);
        }

        public static void DEMOPlayerRoom(Player player, int currentPosX, int currentPosY, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;
            int direction = 1;
            //(45,3)
            do
            {
                Console.SetBufferSize(2000, 2000);
                ASCII.GameMap(ASCII.playerRoom, currentPosX, currentPosY, gbText, gbBackground);
                ASCII.PlayerMovement(player, direction, gbText, gbBackground);
                //ASCII.PlayerForward(gbText, gbBackground);
                navPlayerMenu = Console.ReadKey().Key;

                switch (navPlayerMenu)
                {

                    case ConsoleKey.UpArrow: case ConsoleKey.W:
                        direction += 1;
                        if (direction < 3)
                        {
                            direction = 3;
                        }
                        if (direction == 5)
                        {
                            direction -= 2;
                        }
                        if (direction == 6)
                        {
                            direction -= 3;
                        }
                        if (direction == 7)
                        {
                            direction -= 4;
                        }
                        currentPosY -= 2;
                        if (currentPosY < 3)
                        {
                            currentPosY += 2;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.DownArrow: case ConsoleKey.S:
                        direction += 1;
                        if (direction < 5)
                        {
                            direction = 5;
                        }
                        if (direction == 7)
                        {
                            direction -= 2;
                        }
                        currentPosY += 2;
                        if (currentPosY > 13)
                        {
                            currentPosY -= 2;
                            reloadTestMap = true;
                        }
                        break;

                    case ConsoleKey.LeftArrow: case ConsoleKey.A:
                        direction = 1;
                        currentPosX -= 5;
                        if (currentPosX < 5)
                        {
                            currentPosX += 5;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.RightArrow: case ConsoleKey.D:
                        direction = 2;
                        currentPosX += 5;
                        if (currentPosX == 50 && currentPosY == 3)
                        {
                            currentPosX -= 5;
                            reloadTestMap = false;
                        }
                        if (currentPosX > 55)
                        {
                            currentPosX -= 5;

                            reloadTestMap = true;
                        }
                        break;
                    case ConsoleKey.M:
                        Player_Menus.PlayerMenu(player, navPlayerMenu, gbText, gbBackground);
                        reloadTestMap = true;
                        break;
                    default:
                        reloadTestMap = true;
                        break;
                }
            } while (reloadTestMap);
        }

        public static void DEMORivalHouse(Player player, int currentPosX, int currentPosY, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;
            int direction = 4;
            //(30,17)
            do
            {
                Console.SetBufferSize(2000, 2000);
                ASCII.GameMap(ASCII.rivalHouse, currentPosX, currentPosY, gbText, gbBackground);
                ASCII.PlayerMovement(player, direction, gbText, gbBackground);
                //ASCII.PlayerForward(gbText, gbBackground);
                navPlayerMenu = Console.ReadKey().Key;

                switch (navPlayerMenu)
                {

                    case ConsoleKey.UpArrow: case ConsoleKey.W:
                        direction += 1;
                        if (direction < 3)
                        {
                            direction = 3;
                        }
                        if (direction == 5)
                        {
                            direction -= 2;
                        }
                        if (direction == 6)
                        {
                            direction -= 3;
                        }
                        if (direction == 7)
                        {
                            direction -= 4;
                        }
                        currentPosY -= 2;
                        if (currentPosY < 3)
                        {
                            currentPosY += 2;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.DownArrow: case ConsoleKey.S:
                        direction += 1;
                        if (direction < 5)
                        {
                            direction = 5;
                        }
                        if (direction == 7)
                        {
                            direction -= 2;
                        }
                        currentPosY += 2;
                        if (currentPosX == 30 && currentPosY > 17)
                        {
                            currentPosY -= 2;
                            reloadTestMap = false;
                        }
                        if (currentPosY > 17)
                        {
                            currentPosY -= 2;
                            reloadTestMap = true;
                        }
                        break;

                    case ConsoleKey.LeftArrow: case ConsoleKey.A:
                        direction = 1;
                        currentPosX -= 5;
                        if (currentPosX < 5)
                        {
                            currentPosX += 5;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.RightArrow: case ConsoleKey.D:
                        direction = 2;
                        currentPosX += 5;
                        if (currentPosX == 15 && currentPosY == 3)
                        {
                            DEMORivalRoom(player, 15, 3, navPlayerMenu, gbText, gbBackground);
                            currentPosX -= 5;
                            direction = 1;
                            reloadTestMap = true;
                        }
                        if (currentPosX > 55)
                        {
                            currentPosX -= 5;
                            reloadTestMap = true;
                        }                        
                        break;
                    case ConsoleKey.M:
                        Player_Menus.PlayerMenu(player, navPlayerMenu, gbText, gbBackground);
                        reloadTestMap = true;
                        break;
                    default:
                        reloadTestMap = true;
                        break;
                }
            } while (reloadTestMap);
        }

        public static void DEMORivalRoom(Player player, int currentPosX, int currentPosY, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;
            int direction = 2;
            //(15,3)
            do
            {
                Console.SetBufferSize(2000, 2000);
                ASCII.GameMap(ASCII.rivalRoom, currentPosX, currentPosY, gbText, gbBackground);
                ASCII.PlayerMovement(player, direction, gbText, gbBackground);
                //ASCII.PlayerForward(gbText, gbBackground);
                navPlayerMenu = Console.ReadKey().Key;

                switch (navPlayerMenu)
                {

                    case ConsoleKey.UpArrow: case ConsoleKey.W:
                        direction += 1;
                        if (direction < 3)
                        {
                            direction = 3;
                        }
                        if (direction == 5)
                        {
                            direction -= 2;
                        }
                        if (direction == 6)
                        {
                            direction -= 3;
                        }
                        if (direction == 7)
                        {
                            direction -= 4;
                        }
                        currentPosY -= 2;
                        if (currentPosY < 3)
                        {
                            currentPosY += 2;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.DownArrow: case ConsoleKey.S:
                        direction += 1;
                        if (direction < 5)
                        {
                            direction = 5;
                        }
                        if (direction == 7)
                        {
                            direction -= 2;
                        }
                        currentPosY += 2;
                        if (currentPosY > 13)
                        {
                            currentPosY -= 2;
                            reloadTestMap = true;
                        }
                        break;

                    case ConsoleKey.LeftArrow: case ConsoleKey.A:
                        direction = 1;
                        currentPosX -= 5;
                        if (currentPosX == 10 && currentPosY == 3)
                        {
                            currentPosX += 5;
                            reloadTestMap = false;
                        }
                        if (currentPosX < 5)
                        {
                            currentPosX += 5;
                            reloadTestMap = true;
                        }                        
                        break;

                    case ConsoleKey.RightArrow: case ConsoleKey.D:
                        direction = 2;
                        currentPosX += 5;
                        if (currentPosX > 55)
                        {
                            currentPosX -= 5;
                            reloadTestMap = true;
                        }
                        reloadTestMap = true;
                        break;
                    case ConsoleKey.M:
                        Player_Menus.PlayerMenu(player, navPlayerMenu, gbText, gbBackground);
                        reloadTestMap = true;
                        break;
                    default:
                        reloadTestMap = true;
                        break;
                }
            } while (reloadTestMap);
        }

        public static void DEMOPokeCenter(Player player, int currentPosX, int currentPosY, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;
            int posX = -12;
            int posY = 21;
            int direction = 4;
            //(30,17)
            do
            {
                Console.SetBufferSize(2000, 2000);
                //switch back to playerHouse
                ASCII.GameMap(ASCII.pokeCenter, currentPosX, currentPosY, gbText, gbBackground);
                ASCII.CharacterPokeCenter((currentPosX - posX), (currentPosY - posY), gbText, gbBackground);
                ASCII.PlayerMovement(player, direction, gbText, gbBackground);
                //ASCII.PlayerForward(gbText, gbBackground);
                navPlayerMenu = Console.ReadKey().Key;

                switch (navPlayerMenu)
                {

                    case ConsoleKey.UpArrow: case ConsoleKey.W:
                        direction += 1;
                        if (direction < 3)
                        {
                            direction = 3;
                        }
                        if (direction == 5)
                        {
                            direction -= 2;
                        }
                        if (direction == 6)
                        {
                            direction -= 3;
                        }
                        if (direction == 7)
                        {
                            direction -= 4;
                        }
                        currentPosY -= 2;
                        posY -= 4;
                        if (currentPosY < 3)
                        {
                            currentPosY += 2;
                            posY += 4;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.DownArrow: case ConsoleKey.S:
                        direction += 1;
                        if (direction < 5)
                        {
                            direction = 5;
                        }
                        if (direction == 7)
                        {
                            direction -= 2;
                        }
                        currentPosY += 2;
                        posY += 4;
                        if (currentPosX == 30 && currentPosY > 17)
                        {
                            currentPosY -= 2;
                            posY -= 4;
                            reloadTestMap = false;
                        }
                        if (currentPosY > 17)
                        {
                            currentPosY -= 2;
                            posY -= 4;
                            reloadTestMap = true;
                        }
                        break;

                    case ConsoleKey.LeftArrow: case ConsoleKey.A:
                        direction = 1;
                        currentPosX -= 5;
                        posX -= 10;
                        if (currentPosX < 5)
                        {
                            currentPosX += 5;
                            posX += 10;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.RightArrow: case ConsoleKey.D:
                        direction = 2;
                        currentPosX += 5;
                        posX += 10;
                        if (currentPosX > 55)
                        {
                            currentPosX -= 5;
                            posX -= 10;
                        }
                        reloadTestMap = true;
                        break;
                    case ConsoleKey.M:
                        Player_Menus.PlayerMenu(player, navPlayerMenu, gbText, gbBackground);
                        reloadTestMap = true;
                        break;
                    case ConsoleKey.Enter: case ConsoleKey.K:
                    
                        //Access PC
                        if (currentPosX == 50 && currentPosY == 5)
                        {
                            ASCII.ScrollMessage($"{player.Name.ToUpper()} booted up the PC.", 25, 1500, gbText, gbBackground);
                            ASCII.ScrollMessage("Which PC should be accessed?", 25, 1500, gbText, gbBackground);
                            ASCII.PCMain(player, currentPosX, currentPosY, navPlayerMenu, gbText, gbBackground);
                        }
                        //Heal PokeFraud
                        if (currentPosX == 30 && currentPosY == 7)
                        {
                            string message1 = "Hello! Welcome to the PokeCenter!";
                            string message2 = "Would you like to heal you Pokefraud?";
                            string message3 = "Have a nice day!";
                            string message4 = "Sure! Give me just a moment.";
                            string message5 = "Your Pokefraud are all healed up!";
                            ASCII.ScrollMessage(message1, 50, 1500, gbText, gbBackground);
                            ASCII.ScrollMessage(message2, 50, 1, gbText, gbBackground);
                            int chooseNum = 0;
                            int chooseY = 22;
                            bool reloadBattleFAINT = false;
                            
                            Console.SetCursorPosition(65, 22);
                            Console.Write("YES");
                            Console.SetCursorPosition(65, 23);
                            Console.Write("NO");
                            do
                            {
                                Console.SetCursorPosition(61, chooseY);
                                Console.Write("-->");
                                Console.SetCursorPosition(90, 42);
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.UpArrow: case ConsoleKey.W:
                                    
                                        Console.SetCursorPosition(61, chooseY);
                                        Console.Write("   ");
                                        chooseY -= 1;
                                        if (chooseY < 22)
                                        {
                                            chooseY += 1;
                                        }
                                        reloadBattleFAINT = true;
                                        break;
                                    case ConsoleKey.DownArrow: case ConsoleKey.S:
                                    
                                        Console.SetCursorPosition(61, chooseY);
                                        Console.Write("   ");
                                        chooseY += 1;
                                        if (chooseY > 23)
                                        {
                                            chooseY -= 1;
                                        }
                                        reloadBattleFAINT = true;
                                        break;
                                    case ConsoleKey.Enter: case ConsoleKey.K:
                                    
                                        if (chooseY == 22)
                                        {
                                            ASCII.ScrollMessage(message4, 50, 1500, gbText, gbBackground);
                                            //TODO Insert Pokeball animation
                                            Console.SetCursorPosition(37, 6);
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.BackgroundColor = gbText;
                                            Console.Write("▄");
                                            SFX.HealingIndividual();
                                            Console.SetCursorPosition(90, 42);
                                            player.Party.MonsterEquipped.Health = player.Party.MonsterEquipped.MaxHealth;
                                            player.Party.MonsterEquipped.EquippedMoves.Move1.Uses = player.Party.MonsterEquipped.EquippedMoves.Move1.MaxUses;
                                            player.Party.MonsterEquipped.EquippedMoves.Move2.Uses = player.Party.MonsterEquipped.EquippedMoves.Move2.MaxUses;
                                            player.Party.MonsterEquipped.EquippedMoves.Move3.Uses = player.Party.MonsterEquipped.EquippedMoves.Move3.MaxUses;
                                            player.Party.MonsterEquipped.EquippedMoves.Move4.Uses = player.Party.MonsterEquipped.EquippedMoves.Move4.MaxUses;
                                            System.Threading.Thread.Sleep(500);
                                            if (player.Party.Slot2.Type != Monster_Race.NONE)
                                            {
                                                Console.SetCursorPosition(39, 6);
                                                Console.Write("▄");
                                                SFX.HealingIndividual();
                                                Console.SetCursorPosition(90, 42);
                                                player.Party.Slot2.Health = player.Party.Slot2.MaxHealth;
                                                player.Party.Slot2.EquippedMoves.Move1.Uses = player.Party.Slot2.EquippedMoves.Move1.MaxUses;
                                                player.Party.Slot2.EquippedMoves.Move2.Uses = player.Party.Slot2.EquippedMoves.Move2.MaxUses;
                                                player.Party.Slot2.EquippedMoves.Move3.Uses = player.Party.Slot2.EquippedMoves.Move3.MaxUses;
                                                player.Party.Slot2.EquippedMoves.Move4.Uses = player.Party.Slot2.EquippedMoves.Move4.MaxUses;
                                                System.Threading.Thread.Sleep(500);
                                            }
                                            
                                            Console.BackgroundColor = gbBackground;
                                            if (player.Party.Slot3.Type != Monster_Race.NONE)
                                            {
                                                
                                                Console.SetCursorPosition(37, 7);
                                                Console.Write("▀");
                                                SFX.HealingIndividual();
                                                Console.SetCursorPosition(90, 42);
                                                player.Party.Slot3.Health = player.Party.Slot3.MaxHealth;
                                                player.Party.Slot3.EquippedMoves.Move1.Uses = player.Party.Slot3.EquippedMoves.Move1.MaxUses;
                                                player.Party.Slot3.EquippedMoves.Move2.Uses = player.Party.Slot3.EquippedMoves.Move2.MaxUses;
                                                player.Party.Slot3.EquippedMoves.Move3.Uses = player.Party.Slot3.EquippedMoves.Move3.MaxUses;
                                                player.Party.Slot3.EquippedMoves.Move4.Uses = player.Party.Slot3.EquippedMoves.Move4.MaxUses;
                                                System.Threading.Thread.Sleep(500);
                                            }
                                            
                                            if (player.Party.Slot4.Type != Monster_Race.NONE)
                                            {
                                                Console.SetCursorPosition(39, 7);
                                                Console.Write("▀");
                                                SFX.HealingIndividual();
                                                Console.SetCursorPosition(90, 42);
                                                player.Party.Slot4.Health = player.Party.Slot4.MaxHealth;
                                                player.Party.Slot4.EquippedMoves.Move1.Uses = player.Party.Slot4.EquippedMoves.Move1.MaxUses;
                                                player.Party.Slot4.EquippedMoves.Move2.Uses = player.Party.Slot4.EquippedMoves.Move2.MaxUses;
                                                player.Party.Slot4.EquippedMoves.Move3.Uses = player.Party.Slot4.EquippedMoves.Move3.MaxUses;
                                                player.Party.Slot4.EquippedMoves.Move4.Uses = player.Party.Slot4.EquippedMoves.Move4.MaxUses;
                                                System.Threading.Thread.Sleep(500);
                                            }
                                            
                                            if (player.Party.Slot5.Type != Monster_Race.NONE)
                                            {
                                                Console.SetCursorPosition(37, 7);
                                                Console.Write("█");
                                                SFX.HealingIndividual();
                                                Console.SetCursorPosition(90, 42);
                                                player.Party.Slot5.Health = player.Party.Slot5.MaxHealth;
                                                player.Party.Slot5.EquippedMoves.Move1.Uses = player.Party.Slot5.EquippedMoves.Move1.MaxUses;
                                                player.Party.Slot5.EquippedMoves.Move2.Uses = player.Party.Slot5.EquippedMoves.Move2.MaxUses;
                                                player.Party.Slot5.EquippedMoves.Move3.Uses = player.Party.Slot5.EquippedMoves.Move3.MaxUses;
                                                player.Party.Slot5.EquippedMoves.Move4.Uses = player.Party.Slot5.EquippedMoves.Move4.MaxUses;
                                                System.Threading.Thread.Sleep(500);
                                            }
                                            
                                            if (player.Party.Slot6.Type != Monster_Race.NONE)
                                            {
                                                Console.SetCursorPosition(39, 7);
                                                Console.Write("█");
                                                SFX.HealingIndividual();
                                                Console.SetCursorPosition(90, 42);
                                                player.Party.Slot6.Health = player.Party.Slot6.MaxHealth;
                                                player.Party.Slot6.EquippedMoves.Move1.Uses = player.Party.Slot6.EquippedMoves.Move1.MaxUses;
                                                player.Party.Slot6.EquippedMoves.Move2.Uses = player.Party.Slot6.EquippedMoves.Move2.MaxUses;
                                                player.Party.Slot6.EquippedMoves.Move3.Uses = player.Party.Slot6.EquippedMoves.Move3.MaxUses;
                                                player.Party.Slot6.EquippedMoves.Move4.Uses = player.Party.Slot6.EquippedMoves.Move4.MaxUses;
                                            }
                                            System.Threading.Thread.Sleep(250);
                                            SFX.HealingComplete();
                                            System.Threading.Thread.Sleep(4000);
                                            SFX.PokeCenter();
                                            Console.ForegroundColor = gbText;
                                            Console.BackgroundColor = gbBackground;
                                            ASCII.ScrollMessage(message5, 50, 1500, gbText, gbBackground);
                                            ASCII.ScrollMessage(message3, 50, 1500, gbText, gbBackground);                                            
                                            
                                            chooseNum += 1;
                                            reloadBattleFAINT = false;
                                        }
                                        else if (chooseY == 23)
                                        {
                                            ASCII.ScrollMessage(message3, 50, 1500, gbText, gbBackground);
                                            chooseNum += 2;
                                            reloadBattleFAINT = false;
                                        }
                                        break;
                                    case ConsoleKey.Backspace: case ConsoleKey.O:
                                    
                                        ASCII.ScrollMessage(message2, 50, 1500, gbText, gbBackground);
                                        reloadBattleFAINT = false;
                                        break;
                                    default:
                                        reloadBattleFAINT = true;
                                        break;
                                }
                            } while (reloadBattleFAINT);
                        }
                        reloadTestMap = true;
                        break;
                    default:
                        reloadTestMap = true;
                        break;
                }
            } while (reloadTestMap);
        }

        public static void DEMOPokeMart(Player player, int currentPosX, int currentPosY, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;
            int posX = -27;
            int posY = 21;
            int direction = 4;
            //(15,17)
            do
            {
                Console.SetBufferSize(2000, 2000);
                //switch back to playerHouse
                ASCII.GameMap(ASCII.pokeMart, currentPosX, currentPosY, gbText, gbBackground);
                ASCII.CharacterMerchant((currentPosX - posX), (currentPosY - posY), gbText, gbBackground);
                ASCII.PlayerMovement(player, direction, gbText, gbBackground);
                //ASCII.PlayerForward(gbText, gbBackground);
                navPlayerMenu = Console.ReadKey().Key;

                switch (navPlayerMenu)
                {

                    case ConsoleKey.UpArrow: case ConsoleKey.W:
                        direction += 1;
                        if (direction < 3)
                        {
                            direction = 3;
                        }
                        if (direction == 5)
                        {
                            direction -= 2;
                        }
                        if (direction == 6)
                        {
                            direction -= 3;
                        }
                        if (direction == 7)
                        {
                            direction -= 4;
                        }
                        currentPosY -= 2;
                        posY -= 4;
                        if (currentPosY < 3)
                        {
                            currentPosY += 2;
                            posY += 4;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.DownArrow: case ConsoleKey.S:
                        direction += 1;
                        if (direction < 5)
                        {
                            direction = 5;
                        }
                        if (direction == 7)
                        {
                            direction -= 2;
                        }
                        currentPosY += 2;
                        posY += 4;
                        if (currentPosX == 15 && currentPosY > 17)
                        {
                            currentPosY -= 2;
                            posY -= 4;
                            reloadTestMap = false;
                        }
                        if (currentPosY > 17)
                        {
                            currentPosY -= 2;
                            posY -= 4;
                            reloadTestMap = true;
                        }
                        break;

                    case ConsoleKey.LeftArrow: case ConsoleKey.A:
                        direction = 1;
                        currentPosX -= 5;
                        posX -= 10;
                        if (currentPosX < 5)
                        {
                            currentPosX += 5;
                            posX += 10;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.RightArrow: case ConsoleKey.D:
                        direction = 2;
                        currentPosX += 5;
                        posX += 10;
                        if (currentPosX > 55)
                        {
                            currentPosX -= 5;
                            posX -= 10;
                        }
                        reloadTestMap = true;
                        break;
                    case ConsoleKey.M:
                        Player_Menus.PlayerMenu(player, navPlayerMenu, gbText, gbBackground);
                        reloadTestMap = true;
                        break;
                    default:
                        reloadTestMap = true;
                        break;
                }
            } while (reloadTestMap);
        }

        #endregion
    }
}
