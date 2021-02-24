using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses
{
    public class Maps
    {
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

                    case ConsoleKey.UpArrow:
                        currentPosY -= 2;
                        if (currentPosY < 16)
                        {
                            currentPosY += 2;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.DownArrow:
                        currentPosY += 2;
                        if (currentPosY > 64)
                        {
                            currentPosY -= 2;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.LeftArrow:
                        currentPosX -= 5;
                        if (currentPosX < 63)
                        {
                            currentPosX += 5;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.RightArrow:
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

                    case ConsoleKey.UpArrow:
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
                            SFX.Route1();
                            reloadTestMap = true;
                        }
                        //reloadTestMap = true;
                        break;

                    case ConsoleKey.DownArrow:
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
                            SFX.Route1();
                            reloadTestMap = true;
                        }
                        //reloadTestMap = true;
                        break;

                    case ConsoleKey.LeftArrow:
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
                            SFX.Route1();
                            reloadTestMap = true;
                        }
                        //reloadTestMap = true;
                        break;

                    case ConsoleKey.RightArrow:
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
                            SFX.Route1();
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

                    case ConsoleKey.UpArrow:
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
                            DEMOPokeMart(player, 15, 17, navPlayerMenu, gbText, gbBackground);
                            currentPosY += 2;
                            posY += 4;
                            direction = 6;
                        }
                        //PokeCenter
                        if (currentPosX == 172 && currentPosY == 34)
                        {
                            DEMOPokeCenter(player, 30, 17, navPlayerMenu, gbText, gbBackground);
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
                            direction = 6;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.DownArrow:
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
                        //Border Bottom
                        if (currentPosY > 82)
                        {
                            currentPosY -= 2;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.LeftArrow:
                        direction = 1;
                        currentPosX -= 5;
                        posX -= 10;
                        //Border Left
                        if (currentPosX < 60)
                        {
                            currentPosX += 5;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.RightArrow:
                        direction = 2;
                        currentPosX += 5;
                        posX += 10;
                        //Border Right
                        if (currentPosX > 225)
                        {
                            currentPosX -= 5;
                        }
                        reloadTestMap = true;
                        break;
                    case ConsoleKey.M:
                        Player_Menus.PlayerMenu(player, navPlayerMenu, gbText, gbBackground);                        
                        reloadTestMap = true;
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.K:
                        string battle = "Do you want to battle?";
                        if (currentPosX == 117 && currentPosY == 68)
                        {
                            //Player_Menus.YesOrNo(battle, chooseNum, navPlayerMenu, gbText, gbBackground);
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
                                Console.SetCursorPosition(90, 46);
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.UpArrow:
                                    case ConsoleKey.W:
                                        Console.SetCursorPosition(61, menuPosY);
                                        Console.Write("   ");
                                        menuPosY -= 1;
                                        if (menuPosY < 22)
                                        {
                                            menuPosY += 1;
                                        }
                                        reloadBattleFAINT = true;
                                        break;
                                    case ConsoleKey.DownArrow:
                                    case ConsoleKey.S:
                                        Console.SetCursorPosition(61, menuPosY);
                                        Console.Write("   ");
                                        menuPosY += 1;
                                        if (menuPosY > 23)
                                        {
                                            menuPosY -= 1;
                                        }
                                        reloadBattleFAINT = true;
                                        break;
                                    case ConsoleKey.Enter:
                                    case ConsoleKey.K:
                                        if (menuPosY == 22)
                                        {
                                            SFX.LeagueBattle();
                                            ASCII.BattleIntroFLASH(player, direction, currentPosX, currentPosY, ASCII.DEMOMap);
                                            ASCII.FullBattleNPC(player, npc, gbText, gbBackground, navPlayerMenu);
                                            SFX.Route1();
                                            //ASCII.FullBattleWild(player, Monster.starters, 5, 10, gbText, gbBackground, navPlayerMenu);
                                            reloadBattleFAINT = false;
                                        }
                                        else if (menuPosY == 23)
                                        {
                                            reloadBattleFAINT = false;
                                        }
                                        break;
                                    case ConsoleKey.Backspace:
                                    case ConsoleKey.O:
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

                    case ConsoleKey.UpArrow:
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

                    case ConsoleKey.DownArrow:
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

                    case ConsoleKey.LeftArrow:
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

                    case ConsoleKey.RightArrow:
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

                    case ConsoleKey.UpArrow:
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

                    case ConsoleKey.DownArrow:
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

                    case ConsoleKey.LeftArrow:
                        direction = 1;
                        currentPosX -= 5;
                        if (currentPosX < 5)
                        {
                            currentPosX += 5;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.RightArrow:
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

                    case ConsoleKey.UpArrow:
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

                    case ConsoleKey.DownArrow:
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

                    case ConsoleKey.LeftArrow:
                        direction = 1;
                        currentPosX -= 5;
                        if (currentPosX < 5)
                        {
                            currentPosX += 5;
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.RightArrow:
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

                    case ConsoleKey.UpArrow:
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

                    case ConsoleKey.DownArrow:
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

                    case ConsoleKey.LeftArrow:
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

                    case ConsoleKey.RightArrow:
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
            int direction = 5;
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

                    case ConsoleKey.UpArrow:
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

                    case ConsoleKey.DownArrow:
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

                    case ConsoleKey.LeftArrow:
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

                    case ConsoleKey.RightArrow:
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

        public static void DEMOPokeMart(Player player, int currentPosX, int currentPosY, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;
            int posX = -27;
            int posY = 21;
            int direction = 5;
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

                    case ConsoleKey.UpArrow:
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

                    case ConsoleKey.DownArrow:
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

                    case ConsoleKey.LeftArrow:
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

                    case ConsoleKey.RightArrow:
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
