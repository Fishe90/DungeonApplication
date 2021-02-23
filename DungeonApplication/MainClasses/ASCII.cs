using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses
{
    public class ASCII
    {
        /****FOR EACH NEW METHOD() ADD Console.SetCursorPosition(90, 46); AT THE END OF THE LAST WRITE/WRITELINE TO REMOVE THE (PRESS ANY KEY TO CONTINUE)****/

        #region METHODS: Screen Control

        public static void BattleIntroFLASH(Player player, int currentPosX, int currentPosY, string[] Map)
        {
            Console.SetCursorPosition(0, 0);
            GameMap(Map, currentPosX, currentPosY, ConsoleColor.White, ConsoleColor.Black);
            
            
            PlayerMovement(ConsoleColor.White, ConsoleColor.Black);
            System.Threading.Thread.Sleep(200);

            Console.SetCursorPosition(0, 0);
            GameMap(Map, currentPosX, currentPosY, ConsoleColor.Black, ConsoleColor.White);
            
            
            PlayerMovement(ConsoleColor.Black, ConsoleColor.White);
            System.Threading.Thread.Sleep(200);

            Console.SetCursorPosition(0, 0);
            GameMap(Map, currentPosX, currentPosY, ConsoleColor.White, ConsoleColor.Black);
            
            
            PlayerMovement(ConsoleColor.White, ConsoleColor.Black);
            System.Threading.Thread.Sleep(200);

            Console.SetCursorPosition(0, 0);
            GameMap(Map, currentPosX, currentPosY, ConsoleColor.Black, ConsoleColor.White);
            
            
            PlayerMovement(ConsoleColor.Black, ConsoleColor.White);
            System.Threading.Thread.Sleep(200);

            Console.SetCursorPosition(0, 0);
            GameMap(Map, currentPosX, currentPosY, ConsoleColor.White, ConsoleColor.Black);
            
            
            PlayerMovement(ConsoleColor.White, ConsoleColor.Black);
            System.Threading.Thread.Sleep(200);

            Console.SetCursorPosition(0, 0);
            GameMap(Map, currentPosX, currentPosY, ConsoleColor.Black, ConsoleColor.White);
            
            
            PlayerMovement(ConsoleColor.Black, ConsoleColor.White);
            System.Threading.Thread.Sleep(200);

            Console.SetCursorPosition(0, 0);
            GameMap(Map, currentPosX, currentPosY, ConsoleColor.White, ConsoleColor.Black);
            
            
            PlayerMovement(ConsoleColor.White, ConsoleColor.Black);
            System.Threading.Thread.Sleep(200);

            Console.SetCursorPosition(0, 0);
            GameMap(Map, currentPosX, currentPosY, ConsoleColor.Black, ConsoleColor.White);
            
            
            PlayerMovement(ConsoleColor.Black, ConsoleColor.White);
            System.Threading.Thread.Sleep(200);
        }

        public static void GameMap(string[] TestMap, int currentPosX, int currentPosY, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            int posY1 = 3;
            int posY2 = 2;
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            foreach (string line in TestMap)
            {
                Console.SetCursorPosition(4, posY2);
                Console.WriteLine(TestMap[currentPosY + posY1].Substring(currentPosX, 83));
                posY1 += 1;
                posY2 += 1;
                if (posY1 > 26 && posY2 > 25)
                {
                    posY1 -= 1;
                    posY2 -= 1;
                }
            }
            Console.SetCursorPosition(90, 46);
        }

        public static void PlayerMovement(ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.BackgroundColor = gbBackground;
            Console.SetCursorPosition(42, 10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"▄▄███▄");
            Console.SetCursorPosition(43, 11);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(@"▀"); Console.BackgroundColor = ConsoleColor.Black; Console.Write("▄█▄"); Console.BackgroundColor = gbBackground; Console.Write("▀");
            Console.SetCursorPosition(43, 12);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = gbBackground;
            Console.Write(@"▀"); Console.BackgroundColor = ConsoleColor.Black; Console.Write("▄█▄"); Console.BackgroundColor = gbBackground; Console.Write("▀");
            Console.SetCursorPosition(43, 13);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"▀   ▀");
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(100);

            Console.SetCursorPosition(42, 10);
            Console.BackgroundColor = gbBackground;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(@"▄▄███▄");
            Console.SetCursorPosition(43, 11);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = gbBackground;
            Console.Write(@"▀"); Console.BackgroundColor = ConsoleColor.Black; Console.Write("▄█▄"); Console.BackgroundColor = gbBackground; Console.Write("▀");
            Console.SetCursorPosition(43, 12);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = gbBackground;
            Console.Write(@"▀"); Console.BackgroundColor = ConsoleColor.Black; Console.Write("▄█▄"); Console.BackgroundColor = gbBackground; Console.Write("▀");
            Console.SetCursorPosition(43, 13);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(@" ▀ ▀ ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(90, 46);
        }

        public static void RegionNoEncounter(string[] Map, Player player, int currentPosX, int currentPosY, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;

            do
            {
                Console.SetBufferSize(2000, 2000);
                GameMap(Map, currentPosX, currentPosY, gbText, gbBackground);
                PlayerMovement(gbText, gbBackground);
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

        public static void RegionEncounter(string[] Map, Player player, Monster[] monsters, int currentPosX, int currentPosY, int lvLow, int lvHigh, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;
            Random rand = new Random();

            do
            {
                int encounterChance = rand.Next(0, 100);
                Console.SetBufferSize(2000, 2000);
                GameMap(Map, currentPosX, currentPosY, gbText, gbBackground);
                PlayerMovement(gbText, gbBackground);
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
                            BattleIntroFLASH(player, currentPosX, currentPosY, Map);
                            FullBattleWild(player, monsters, lvLow, lvHigh, gbText, gbBackground, navPlayerMenu);
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
                            BattleIntroFLASH(player, currentPosX, currentPosY, Map);
                            FullBattleWild(player, monsters, lvLow, lvHigh, gbText, gbBackground, navPlayerMenu);
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
                            BattleIntroFLASH(player, currentPosX, currentPosY, Map);
                            FullBattleWild(player, monsters, lvLow, lvHigh, gbText, gbBackground, navPlayerMenu);
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
                            BattleIntroFLASH(player, currentPosX, currentPosY, Map);
                            FullBattleWild(player, monsters, lvLow, lvHigh, gbText, gbBackground, navPlayerMenu);
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

        public static void GameBoy(ConsoleColor GBColor)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = GBColor;
            Console.Write(TEMGameBoy);
            Console.SetCursorPosition(90, 46);
        }

        /****ERASES THE CURRENT SCREEN DISPLAY****/
        public static void ResetScreen(ConsoleColor gbText, ConsoleColor gbBackground)
        {
            string[] screen = new string[]
            {
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   "
            };
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.SetCursorPosition(4, 2);
            Console.Write(screen[0].Substring(0, 83));
            Console.SetCursorPosition(4, 3);
            Console.Write(screen[1].Substring(0, 83));
            Console.SetCursorPosition(4, 4);
            Console.Write(screen[2].Substring(0, 83));
            Console.SetCursorPosition(4, 5);
            Console.Write(screen[3].Substring(0, 83));
            Console.SetCursorPosition(4, 6);
            Console.Write(screen[4].Substring(0, 83));
            Console.SetCursorPosition(4, 7);
            Console.Write(screen[5].Substring(0, 83));
            Console.SetCursorPosition(4, 8);
            Console.Write(screen[6].Substring(0, 83));
            Console.SetCursorPosition(4, 9);
            Console.Write(screen[7].Substring(0, 83));
            Console.SetCursorPosition(4, 10);
            Console.Write(screen[8].Substring(0, 83));
            Console.SetCursorPosition(4, 11);
            Console.Write(screen[9].Substring(0, 83));
            Console.SetCursorPosition(4, 12);
            Console.Write(screen[10].Substring(0, 83));
            Console.SetCursorPosition(4, 13);
            Console.Write(screen[11].Substring(0, 83));
            Console.SetCursorPosition(4, 14);
            Console.Write(screen[12].Substring(0, 83));
            Console.SetCursorPosition(4, 15);
            Console.Write(screen[13].Substring(0, 83));
            Console.SetCursorPosition(4, 16);
            Console.Write(screen[14].Substring(0, 83));
            Console.SetCursorPosition(4, 17);
            Console.Write(screen[15].Substring(0, 83));
            Console.SetCursorPosition(4, 18);
            Console.Write(screen[16].Substring(0, 83));
            Console.SetCursorPosition(4, 19);
            Console.Write(screen[17].Substring(0, 83));
            Console.SetCursorPosition(4, 20);
            Console.Write(screen[18].Substring(0, 83));
            Console.SetCursorPosition(4, 21);
            Console.Write(screen[19].Substring(0, 83));
            Console.SetCursorPosition(4, 22);
            Console.Write(screen[20].Substring(0, 83));
            Console.SetCursorPosition(4, 23);
            Console.Write(screen[21].Substring(0, 83));
            Console.SetCursorPosition(4, 24);
            Console.Write(screen[22].Substring(0, 83));
            Console.SetCursorPosition(4, 25);
            Console.Write(screen[23].Substring(0, 83));
            Console.SetCursorPosition(90, 46);
        }

        public static void ResetHalfScreen(int posY, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            string[] screen = new string[]
            {
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   ",
                "                                                                                   "
            };
            foreach (string item in screen)
            {
                Console.SetCursorPosition(4, posY);
                Console.Write(item);
                Console.SetCursorPosition(90, 46);
                posY += 1;
            }
        }

        /****DISPLAYS A STATIC SCREEN (FE: PLAYER MENU, EMPTY MENU SECTION)****/
        public static void StaticScreen(string[] ScreenDisplay, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.SetCursorPosition(4, 2);
            Console.Write(ScreenDisplay[0].Substring(0, 83));
            Console.SetCursorPosition(4, 3);
            Console.Write(ScreenDisplay[1].Substring(0, 83));
            Console.SetCursorPosition(4, 4);
            Console.Write(ScreenDisplay[2].Substring(0, 83));
            Console.SetCursorPosition(4, 5);
            Console.Write(ScreenDisplay[3].Substring(0, 83));
            Console.SetCursorPosition(4, 6);
            Console.Write(ScreenDisplay[4].Substring(0, 83));
            Console.SetCursorPosition(4, 7);
            Console.Write(ScreenDisplay[5].Substring(0, 83));
            Console.SetCursorPosition(4, 8);
            Console.Write(ScreenDisplay[6].Substring(0, 83));
            Console.SetCursorPosition(4, 9);
            Console.Write(ScreenDisplay[7].Substring(0, 83));
            Console.SetCursorPosition(4, 10);
            Console.Write(ScreenDisplay[8].Substring(0, 83));
            Console.SetCursorPosition(4, 11);
            Console.Write(ScreenDisplay[9].Substring(0, 83));
            Console.SetCursorPosition(4, 12);
            Console.Write(ScreenDisplay[10].Substring(0, 83));
            Console.SetCursorPosition(4, 13);
            Console.Write(ScreenDisplay[11].Substring(0, 83));
            Console.SetCursorPosition(4, 14);
            Console.Write(ScreenDisplay[12].Substring(0, 83));
            Console.SetCursorPosition(4, 15);
            Console.Write(ScreenDisplay[13].Substring(0, 83));
            Console.SetCursorPosition(4, 16);
            Console.Write(ScreenDisplay[14].Substring(0, 83));
            Console.SetCursorPosition(4, 17);
            Console.Write(ScreenDisplay[15].Substring(0, 83));
            Console.SetCursorPosition(4, 18);
            Console.Write(ScreenDisplay[16].Substring(0, 83));
            Console.SetCursorPosition(4, 19);
            Console.Write(ScreenDisplay[17].Substring(0, 83));
            Console.SetCursorPosition(4, 20);
            Console.Write(ScreenDisplay[18].Substring(0, 83));
            Console.SetCursorPosition(4, 21);
            Console.Write(ScreenDisplay[19].Substring(0, 83));
            Console.SetCursorPosition(4, 22);
            Console.Write(ScreenDisplay[20].Substring(0, 83));
            Console.SetCursorPosition(4, 23);
            Console.Write(ScreenDisplay[21].Substring(0, 83));
            Console.SetCursorPosition(4, 24);
            Console.Write(ScreenDisplay[22].Substring(0, 83));
            Console.SetCursorPosition(4, 25);
            Console.Write(ScreenDisplay[23].Substring(0, 83));
            Console.SetCursorPosition(90, 46);
        }

        /****DISPLAYS BACKGROUND MOVEMENT****/
        public static void MovementScreen(string[] ScreenDisplay, int currentPosX, int currentPosY, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.SetCursorPosition(4, 2);
            Console.Write(ScreenDisplay[currentPosY].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 3);
            Console.Write(ScreenDisplay[currentPosY + 1].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 4);
            Console.Write(ScreenDisplay[currentPosY + 2].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 5);
            Console.Write(ScreenDisplay[currentPosY + 3].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 6);
            Console.Write(ScreenDisplay[currentPosY + 4].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 7);
            Console.Write(ScreenDisplay[currentPosY + 5].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 8);
            Console.Write(ScreenDisplay[currentPosY + 6].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 9);
            Console.Write(ScreenDisplay[currentPosY + 7].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 10);
            Console.Write(ScreenDisplay[currentPosY + 8].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 11);
            Console.Write(ScreenDisplay[currentPosY + 9].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 12);
            Console.Write(ScreenDisplay[currentPosY + 10].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 13);
            Console.Write(ScreenDisplay[currentPosY + 11].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 14);
            Console.Write(ScreenDisplay[currentPosY + 12].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 15);
            Console.Write(ScreenDisplay[currentPosY + 13].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 16);
            Console.Write(ScreenDisplay[currentPosY + 14].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 17);
            Console.Write(ScreenDisplay[currentPosY + 15].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 18);
            Console.Write(ScreenDisplay[currentPosY + 16].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 19);
            Console.Write(ScreenDisplay[currentPosY + 17].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 20);
            Console.Write(ScreenDisplay[currentPosY + 18].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 21);
            Console.Write(ScreenDisplay[currentPosY + 19].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 22);
            Console.Write(ScreenDisplay[currentPosY + 20].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 23);
            Console.Write(ScreenDisplay[currentPosY + 21].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 24);
            Console.Write(ScreenDisplay[currentPosY + 22].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(4, 25);
            Console.Write(ScreenDisplay[currentPosY + 23].Substring(currentPosX, currentPosX + 83));
            Console.SetCursorPosition(90, 46);
        }

        /****DISPLAYS A STATIC SCREEN (FE: PLAYER MENU, EMPTY MENU SECTION)****/
        public static void StaticPMScreen(string[] ScreenDisplay, Player player, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.SetCursorPosition(4, 2);
            Console.Write(ScreenDisplay[0].Substring(0, 83));
            Console.SetCursorPosition(4, 3);
            Console.Write(ScreenDisplay[1].Substring(0, 83));
            Console.SetCursorPosition(4, 4);
            Console.Write(ScreenDisplay[2].Substring(0, 83));
            Console.SetCursorPosition(4, 5);
            Console.Write(ScreenDisplay[3].Substring(0, 83));
            Console.SetCursorPosition(4, 6);
            Console.Write(ScreenDisplay[4].Substring(0, 83));
            Console.SetCursorPosition(4, 7);
            Console.Write(ScreenDisplay[5].Substring(0, 83));
            Console.SetCursorPosition(4, 8);
            Console.Write(ScreenDisplay[6].Substring(0, 83));
            Console.SetCursorPosition(4, 9);
            Console.Write(ScreenDisplay[7].Substring(0, 83));
            Console.SetCursorPosition(4, 10);
            Console.Write(ScreenDisplay[8].Substring(0, 83));
            Console.SetCursorPosition(4, 11);
            Console.Write(ScreenDisplay[9].Substring(0, 83));
            Console.SetCursorPosition(4, 12);
            Console.Write(ScreenDisplay[10].Substring(0, 83));
            Console.SetCursorPosition(4, 13);
            Console.Write(ScreenDisplay[11].Substring(0, 83));
            Console.SetCursorPosition(4, 14);
            Console.Write(ScreenDisplay[12].Substring(0, 83));
            Console.SetCursorPosition(4, 15);
            Console.Write(ScreenDisplay[13].Substring(0, 83));
            Console.SetCursorPosition(4, 16);
            Console.Write(ScreenDisplay[14].Substring(0, 83));
            Console.SetCursorPosition(4, 17);
            Console.Write(ScreenDisplay[15].Substring(0, 83));
            Console.SetCursorPosition(4, 18);
            Console.Write(ScreenDisplay[16].Substring(0, 83));
            Console.SetCursorPosition(4, 19);
            Console.Write(ScreenDisplay[17].Substring(0, 83));
            Console.SetCursorPosition(4, 20);
            Console.Write(ScreenDisplay[18].Substring(0, 83));
            Console.SetCursorPosition(4, 21);
            Console.Write(ScreenDisplay[19].Substring(0, 83));
            Console.SetCursorPosition(4, 22);
            Console.Write(ScreenDisplay[20].Substring(0, 83));
            Console.SetCursorPosition(4, 23);
            Console.Write(ScreenDisplay[21].Substring(0, 83));
            Console.SetCursorPosition(4, 24);
            Console.Write(ScreenDisplay[22].Substring(0, 83));
            Console.SetCursorPosition(4, 25);
            Console.Write(ScreenDisplay[23].Substring(0, 83));
            Console.SetCursorPosition(0, 0);
            Console.SetCursorPosition(67, 12);
            Console.Write(player.Name);
            Console.SetCursorPosition(90, 46);
        }

        #endregion

        #region METHODS: Battle

        #region BATTLE: Object Displays (NEEDS COORDINATES)

        public static void BallFaceLeft(int positionX, int positionY, int delay, ConsoleColor gbBackground)
        {
            string[] pokeBall = new string[]
        {
                      @"▄▄▄   ",
                @"▄",@"██▄▀▀",@"▄  ",
                @"▀",@"█▀",@"  ▄",@"▀  ",
                      @"▀▀▀   ",
                    @"  ▄▄▄  ",
                    @"▄▀█▄██▄",
                    @"▀▄  ▀█▀",
                    @"  ▀▀▀  "

        };
            Console.SetCursorPosition(positionX + 2, positionY);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[0]);
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[1]);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[2]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[3]);
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(pokeBall[4]);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[5]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(pokeBall[6]);
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[7]);
            Console.SetCursorPosition(positionX + 2, positionY + 3);
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[8]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(delay);
        }

        public static void BallFaceRight(int positionX, int positionY, int delay, ConsoleColor gbBackground)
        {
            string[] pokeBall = new string[]
        {
                      @"▄▄▄   ",
                @"▄",@"██▄▀▀",@"▄  ",
                @"▀",@"█▀",@"  ▄",@"▀  ",
                      @"▀▀▀   ",
                        @"  ▄▄▄  ",
                    @"  ▄",@"▀█▄██",@"▄  ",
                    @"  ▀",@"▄  ",@"▀█",@"▀  ",
                        @"  ▀▀▀ "

        };
            Console.SetCursorPosition(positionX + 2, positionY);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[9]);
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[10]);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[11]);
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[12]);
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(pokeBall[13]);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[14]);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(pokeBall[15]);
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[16]);
            Console.SetCursorPosition(positionX + 2, positionY + 3);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[17]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(delay);
        }

        public static void PokeBallANI(int positionX, int positionY, int delay, ConsoleColor gbBackground)
        {
            string[] pokeBall = new string[]
        {
                      @"  ▄▄▄ ",
                @"  ▄",@"███▄█",@"▄ ",
            @"  ▀",@"▄ ",@"▀",@" ▄",@"▀ ",
                      @"  ▀▀▀   "
        };
            Console.SetCursorPosition(positionX + 2, positionY);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[0]);
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.Write(pokeBall[1]);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[2]);
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[3]);
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[4]);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[5]);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(pokeBall[6]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[7]);
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[8]);
            Console.SetCursorPosition(positionX + 2, positionY + 3);
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[9]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(delay);

            Console.SetCursorPosition(positionX, positionY);
            Console.Write("         ");
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.Write("         ");
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.Write("         ");
            Console.SetCursorPosition(positionX, positionY + 3);
            Console.Write("         ");
            Console.SetCursorPosition(90, 46);

        }

        public static void PokeBallStatic(int positionX, int positionY, ConsoleColor gbBackground)
        {
            string[] pokeBall = new string[]
        {
                      @"▄▄▄",
                @"▄",@"███▄█",@"▄",
            @"▀",@"▄ ",@"▀",@" ▄",@"▀",
                      @"▀▀▀"
        };
            Console.SetCursorPosition(positionX + 2, positionY);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[0]);
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.Write(pokeBall[1]);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[2]);
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[3]);
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[4]);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[5]);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(pokeBall[6]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[7]);
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[8]);
            Console.SetCursorPosition(positionX + 2, positionY + 3);
            Console.BackgroundColor = gbBackground;
            Console.Write(pokeBall[9]);
            Console.SetCursorPosition(90, 46);
        }

        public static void BallOpenClose(int positionX, int positionY, int delay, ConsoleColor gbBackground)
        {
            string[] frameONE = new string[]
            {
                @"                   ",
                @"                   ",
                @"         ▄         ",
                @"      ▀▄ ▀ ▄▀      ",
                @"     ▀▀     ▄▄     ",
                @"      ▄▀ ▄ ▀▄      ",
                @"         ▀         ",
                @"                   "
            };
            string[] frameTWO = new string[]
            {
                @"                   ",
                @"                   ",
                @"    ▄    ▄    ▄    ",
                @"     ▀   ▀   ▀     ",
                @"   ▄▄         ▄▄   ",
                @"                   ",
                @"    ▄▀   █   ▀▄    ",
                @"                   "
            };
            string[] frameTHREE = new string[]
            {
                @"                   ",
                @"         ▄         ",
                @"   ▀     ▄     ▀   ",
                @"     ▀       ▀     ",
                @" ▄ ▄           ▄ ▄ ",
                @"                   ",
                @"     ▀   ▄   ▀     ",
                @"   ▀     ▄     ▀   "
            };
            string[] frameFOUR = new string[]
            {
                @"                   ",
                @"         ▄         ",
                @"     ▄   ▄   ▄     ",
                @"    ▀         ▀    ",
                @" ▄ ▄           ▄ ▄ ",
                @"                   ",
                @"    ▀▄   ▄   ▄▀    ",
                @"         ▄         "
            };
            string[] frameFIVE = new string[]
            {
                @"                   ",
                @"                   ",
                @"         ▄         ",
                @"       ▄   ▄       ",
                @"    ▄ ▀     ▀ ▄    ",
                @"      ▀▄   ▄▀      ",
                @"         ▄         ",
                @"                   "
            };
            string[] frameSIX = new string[]
            {
                @"                   ",
                @"                   ",
                @"                   ",
                @"       ▄▀▀▀▄       ",
                @"      █     █      ",
                @"       ▀▄▄▄▀       ",
                @"                   ",
                @"                   "
            };


            Console.ForegroundColor = ConsoleColor.White;
            #region Frame One

            Console.SetCursorPosition(positionX, positionY);
            Console.Write(frameONE[0]);
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.Write(frameONE[1]);
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.Write(frameONE[2]);
            Console.SetCursorPosition(positionX, positionY + 3);
            Console.Write(frameONE[3]);
            Console.SetCursorPosition(positionX, positionY + 4);
            Console.Write(frameONE[4]);
            Console.SetCursorPosition(positionX, positionY + 5);
            Console.Write(frameONE[5]);
            Console.SetCursorPosition(positionX, positionY + 6);
            Console.Write(frameONE[6]);
            Console.SetCursorPosition(positionX, positionY + 7);
            Console.Write(frameONE[7]);
            Console.SetCursorPosition(90, 46);

            #endregion            
            System.Threading.Thread.Sleep(delay);
            #region Frame Two

            Console.SetCursorPosition(positionX, positionY);
            Console.Write(frameTWO[0]);
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.Write(frameTWO[1]);
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.Write(frameTWO[2]);
            Console.SetCursorPosition(positionX, positionY + 3);
            Console.Write(frameTWO[3]);
            Console.SetCursorPosition(positionX, positionY + 4);
            Console.Write(frameTWO[4]);
            Console.SetCursorPosition(positionX, positionY + 5);
            Console.Write(frameTWO[5]);
            Console.SetCursorPosition(positionX, positionY + 6);
            Console.Write(frameTWO[6]);
            Console.SetCursorPosition(positionX, positionY + 7);
            Console.Write(frameTWO[7]);
            Console.SetCursorPosition(90, 46);

            #endregion            
            System.Threading.Thread.Sleep(delay);
            #region Frame Three

            Console.SetCursorPosition(positionX, positionY);
            Console.Write(frameTHREE[0]);
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.Write(frameTHREE[1]);
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.Write(frameTHREE[2]);
            Console.SetCursorPosition(positionX, positionY + 3);
            Console.Write(frameTHREE[3]);
            Console.SetCursorPosition(positionX, positionY + 4);
            Console.Write(frameTHREE[4]);
            Console.SetCursorPosition(positionX, positionY + 5);
            Console.Write(frameTHREE[5]);
            Console.SetCursorPosition(positionX, positionY + 6);
            Console.Write(frameTHREE[6]);
            Console.SetCursorPosition(positionX, positionY + 7);
            Console.Write(frameTHREE[7]);
            Console.SetCursorPosition(90, 46);

            #endregion
            System.Threading.Thread.Sleep(delay);
            #region Frame Four

            Console.SetCursorPosition(positionX, positionY);
            Console.Write(frameFOUR[0]);
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.Write(frameFOUR[1]);
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.Write(frameFOUR[2]);
            Console.SetCursorPosition(positionX, positionY + 3);
            Console.Write(frameFOUR[3]);
            Console.SetCursorPosition(positionX, positionY + 4);
            Console.Write(frameFOUR[4]);
            Console.SetCursorPosition(positionX, positionY + 5);
            Console.Write(frameFOUR[5]);
            Console.SetCursorPosition(positionX, positionY + 6);
            Console.Write(frameFOUR[6]);
            Console.SetCursorPosition(positionX, positionY + 7);
            Console.Write(frameFOUR[7]);
            Console.SetCursorPosition(90, 46);

            #endregion
            System.Threading.Thread.Sleep(delay);
            #region Frame Five

            Console.SetCursorPosition(positionX, positionY);
            Console.Write(frameFIVE[0]);
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.Write(frameFIVE[1]);
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.Write(frameFIVE[2]);
            Console.SetCursorPosition(positionX, positionY + 3);
            Console.Write(frameFIVE[3]);
            Console.SetCursorPosition(positionX, positionY + 4);
            Console.Write(frameFIVE[4]);
            Console.SetCursorPosition(positionX, positionY + 5);
            Console.Write(frameFIVE[5]);
            Console.SetCursorPosition(positionX, positionY + 6);
            Console.Write(frameFIVE[6]);
            Console.SetCursorPosition(positionX, positionY + 7);
            Console.Write(frameFIVE[7]);
            Console.SetCursorPosition(90, 46);

            #endregion
            System.Threading.Thread.Sleep(delay);
            #region Frame Six

            Console.SetCursorPosition(positionX, positionY);
            Console.Write(frameSIX[0]);
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.Write(frameSIX[1]);
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.Write(frameSIX[2]);
            Console.SetCursorPosition(positionX, positionY + 3);
            Console.Write(frameSIX[3]);
            Console.SetCursorPosition(positionX, positionY + 4);
            Console.Write(frameSIX[4]);
            Console.SetCursorPosition(positionX, positionY + 5);
            Console.Write(frameSIX[5]);
            Console.SetCursorPosition(positionX, positionY + 6);
            Console.Write(frameSIX[6]);
            Console.SetCursorPosition(positionX, positionY + 7);
            Console.Write(frameSIX[7]);
            Console.SetCursorPosition(90, 46);

            #endregion
            System.Threading.Thread.Sleep(delay);
        }

        public static void BallBreak(int positionX, int positionY, int delay, ConsoleColor gbBackground)
        {
            #region Frames
            string[] frameONE = new string[]
           {
                @"                   ",
                @"         ▄         ",
                @"      ▀▄ ▀ ▄▀      ",
                @"     ▀▀     ▄▄     "
           };
            string[] frameTWO = new string[]
            {
                @"                   ",
                @"    ▄    ▄    ▄    ",
                @"     ▀   ▀   ▀     ",
                @"   ▄▄         ▄▄   "
            };
            string[] frameTHREE = new string[]
            {
                @"         ▄         ",
                @"   ▀     ▄     ▀   ",
                @"     ▀       ▀     ",
                @" ▄ ▄           ▄ ▄ "
            };
            string[] frameFOUR = new string[]
{
                @"                   ",
                @"   ▀     ▀     ▀   ",
                @"                   ",
                @" ▄               ▄ "
};
            string[] frameFIVE = new string[]
{
                @"                   ",
                @"                   ",
                @"                   ",
                @"                   "
};
            #endregion

            Console.ForegroundColor = ConsoleColor.White;
            #region Frame One

            Console.SetCursorPosition(positionX, positionY);
            Console.Write(frameONE[0]);
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.Write(frameONE[1]);
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.Write(frameONE[2]);
            Console.SetCursorPosition(positionX, positionY + 3);
            Console.Write(frameONE[3]);
            Console.SetCursorPosition(90, 46);

            #endregion            
            System.Threading.Thread.Sleep(delay);
            #region Frame Two

            Console.SetCursorPosition(positionX, positionY);
            Console.Write(frameTWO[0]);
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.Write(frameTWO[1]);
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.Write(frameTWO[2]);
            Console.SetCursorPosition(positionX, positionY + 3);
            Console.Write(frameTWO[3]);
            Console.SetCursorPosition(90, 46);

            #endregion            
            System.Threading.Thread.Sleep(delay);
            #region Frame Three

            Console.SetCursorPosition(positionX, positionY);
            Console.Write(frameTHREE[0]);
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.Write(frameTHREE[1]);
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.Write(frameTHREE[2]);
            Console.SetCursorPosition(positionX, positionY + 3);
            Console.Write(frameTHREE[3]);
            Console.SetCursorPosition(90, 46);

            #endregion
            System.Threading.Thread.Sleep(delay);
            #region Frame Four

            Console.SetCursorPosition(positionX, positionY);
            Console.Write(frameFOUR[0]);
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.Write(frameFOUR[1]);
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.Write(frameFOUR[2]);
            Console.SetCursorPosition(positionX, positionY + 3);
            Console.Write(frameFOUR[3]);
            Console.SetCursorPosition(90, 46);

            #endregion
            System.Threading.Thread.Sleep(delay);
            #region Frame Four

            Console.SetCursorPosition(positionX, positionY);
            Console.Write(frameFIVE[0]);
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.Write(frameFIVE[1]);
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.Write(frameFIVE[2]);
            Console.SetCursorPosition(positionX, positionY + 3);
            Console.Write(frameFIVE[3]);
            Console.SetCursorPosition(90, 46);

            #endregion
            System.Threading.Thread.Sleep(delay);
        }

        #endregion

        #region BATTLE: Info Displays (NEEDS COORDINATES)

        public static void HealthBar(Monster monster, int positionX, int positionY)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            if (monster.Health == monster.MaxHealth)
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("====================");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= (.95 * monster.MaxHealth) && monster.Health > (.9 * monster.MaxHealth))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("=================== ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= (.9 * monster.MaxHealth) && monster.Health > (.85 * monster.MaxHealth))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("==================  ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= (.85 * monster.MaxHealth) && monster.Health > (.8 * monster.MaxHealth))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("=================   ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= (.8 * monster.MaxHealth) && monster.Health > (.75 * monster.MaxHealth))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("================    ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= (.75 * monster.MaxHealth) && monster.Health > (.7 * monster.MaxHealth))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("===============     ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= (.7 * monster.MaxHealth) && monster.Health > (.65 * monster.MaxHealth))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("==============      ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= (.65 * monster.MaxHealth) && monster.Health > (.6 * monster.MaxHealth))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("=============       ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= (.6 * monster.MaxHealth) && monster.Health > (.55 * monster.MaxHealth))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("============        ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= (.55 * monster.MaxHealth) && monster.Health > (.5 * monster.MaxHealth))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("===========         ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= (.5 * monster.MaxHealth) && monster.Health > (.45 * monster.MaxHealth))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("==========          ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= (.45 * monster.MaxHealth) && monster.Health > (.4 * monster.MaxHealth))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("=========           ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= (.4 * monster.MaxHealth) && monster.Health > (.35 * monster.MaxHealth))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("========            ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= (.35 * monster.MaxHealth) && monster.Health > (.3 * monster.MaxHealth))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("=======             ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= (.3 * monster.MaxHealth) && monster.Health > (.25 * monster.MaxHealth))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("======              ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= (.25 * monster.MaxHealth) && monster.Health > (.2 * monster.MaxHealth))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("=====               ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= (.2 * monster.MaxHealth) && monster.Health > (.15 * monster.MaxHealth))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("====                ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= (.15 * monster.MaxHealth) && monster.Health > (.1 * monster.MaxHealth))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("===                 ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= (.1 * monster.MaxHealth) && monster.Health > (.05 * monster.MaxHealth))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("==                  ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= (.05 * monster.MaxHealth) && monster.Health > (0 * monster.MaxHealth))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("=                   ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Health <= 0)
            {
                Console.Write("HP:[                    ]");
            }
            Console.SetCursorPosition(90, 46);
        }

        public static void ExpBar(Monster monster, int positionX, int positionY)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            if (monster.Exp == monster.MaxExp)
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("====================");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.95 * monster.MaxExp) && monster.Exp > (.9 * monster.MaxExp))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("=================== ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.9 * monster.MaxExp) && monster.Exp > (.85 * monster.MaxExp))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("==================  ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.85 * monster.MaxExp) && monster.Exp > (.8 * monster.MaxExp))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("=================   ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.8 * monster.MaxExp) && monster.Exp > (.75 * monster.MaxExp))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("================    ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.75 * monster.MaxExp) && monster.Exp > (.7 * monster.MaxExp))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("===============     ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.7 * monster.MaxExp) && monster.Exp > (.65 * monster.MaxExp))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("==============      ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.65 * monster.MaxExp) && monster.Exp > (.6 * monster.MaxExp))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("=============       ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.6 * monster.MaxExp) && monster.Exp > (.55 * monster.MaxExp))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("============        ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.55 * monster.MaxExp) && monster.Exp > (.5 * monster.MaxExp))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("===========         ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.5 * monster.MaxExp) && monster.Exp > (.45 * monster.MaxExp))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("==========          ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.45 * monster.MaxExp) && monster.Exp > (.4 * monster.MaxExp))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("=========           ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.4 * monster.MaxExp) && monster.Exp > (.35 * monster.MaxExp))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("========            ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.35 * monster.MaxExp) && monster.Exp > (.3 * monster.MaxExp))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("=======             ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.3 * monster.MaxExp) && monster.Exp > (.25 * monster.MaxExp))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("======              ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.25 * monster.MaxExp) && monster.Exp > (.2 * monster.MaxExp))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("=====               ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.2 * monster.MaxExp) && monster.Exp > (.15 * monster.MaxExp))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("====                ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.15 * monster.MaxExp) && monster.Exp > (.1 * monster.MaxExp))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("===                 ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.1 * monster.MaxExp) && monster.Exp > (.05 * monster.MaxExp))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("==                  ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.05 * monster.MaxExp) && monster.Exp > (0 * monster.MaxExp))
            {
                Console.Write("HP:[");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("=                   ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= 0)
            {
                Console.Write("HP:[                    ]");
            }
            Console.SetCursorPosition(90, 46);
        }


        /****TO BE USED NEXT TO Health BAR DURING COMBAT IF DESIRED****/
        public static void Health(Monster monster, int positionX, int positionY, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.Write($"([{monster.Health}/{monster.MaxHealth}]");
        }

        public static void Name(Monster monster, int positionX, int positionY, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.Write(monster.Name.ToUpper());
        }

        public static void Gender(Monster monster, int positionX, int positionY, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            if (monster.Gender == '♂')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(monster.Gender);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(monster.Gender);
            }
            Console.ForegroundColor = gbText;
        }

        public static void NameANDGender(Monster monster, int positionX, int positionY, ConsoleColor gbText, ConsoleColor gbBackground)
        {

            Console.SetCursorPosition(positionX, positionY);
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.Write(monster.Name.ToUpper());
            if (monster.Gender == '♂')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(monster.Gender);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(monster.Gender);
            }
            Console.ForegroundColor = gbText;
        }

        public static void Level(Monster monster, int positionX, int positionY, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.SetCursorPosition(positionX, positionY);
            Console.Write($"Lv.{monster.Lv}");
        }

        public static void Party(Player player, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            int posY = 2;

            string[] party = new string[]
            {
                " ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄                                        ",
                "█   █                              █ 1 █     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ",
                "█   █                             █▄▄▄█     █ 2 █                           █   █",
                "█   █                                █     █▄▄▄█                            █   █",
                " ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀     █                                 █   █",
                "                                         ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ",
                " ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄                                        ",
                "█   █                              █ 3 █     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ",
                "█   █                             █▄▄▄█     █ 4 █                           █   █",
                "█   █                                █     █▄▄▄█                            █   █",
                " ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀     █                                 █   █",
                "                                         ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ",
                " ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄                                        ",
                "█   █                              █ 5 █     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ",
                "█   █                             █▄▄▄█     █ 6 █                           █   █",
                "█   █                                █     █▄▄▄█                            █   █",
                " ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀     █                                 █   █",
                "                                         ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ",
                "                                                                                 ",
                "▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄",
                "█                                                                               █",
                "█                                                                               █",
                "█                                                                               █",
                " ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ "
            };
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            foreach (string item in party)
            {
                Console.SetCursorPosition(5, posY);
                Console.Write(item);
                posY += 1;
            }

            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;

            //MonsterEquipped
            ASCII.NameANDGender(player.Party.MonsterEquipped, 11, 3, gbText, gbBackground);
            ASCII.Level(player.Party.MonsterEquipped, 30, 3, ConsoleColor.White, ConsoleColor.Black);
            ASCII.HealthBar(player.Party.MonsterEquipped, 11, 4);
            //Slot3
            if (player.Party.Slot3.Type != Monster_Race.NONE)
            {
                ASCII.NameANDGender(player.Party.Slot3, 11, 9, gbText, gbBackground);
                ASCII.Level(player.Party.Slot3, 30, 9, ConsoleColor.White, ConsoleColor.Black);
                ASCII.HealthBar(player.Party.Slot3, 11, 10);
            }
            //Slot5
            if (player.Party.Slot5.Type != Monster_Race.NONE)
            {
                ASCII.NameANDGender(player.Party.Slot5, 11, 15, gbText, gbBackground);
                ASCII.Level(player.Party.Slot5, 30, 15, ConsoleColor.White, ConsoleColor.Black);
                ASCII.HealthBar(player.Party.Slot5, 11, 16);
            }

            //Slot2
            if (player.Party.Slot2.Type != Monster_Race.NONE)
            {
                ASCII.NameANDGender(player.Party.Slot2, 55, 4, gbText, gbBackground);
                ASCII.Level(player.Party.Slot2, 74, 4, ConsoleColor.White, ConsoleColor.Black);
                ASCII.HealthBar(player.Party.Slot2, 55, 5);
            }
            //Slot4
            if (player.Party.Slot4.Type != Monster_Race.NONE)
            {
                ASCII.NameANDGender(player.Party.Slot4, 55, 10, gbText, gbBackground);
                ASCII.Level(player.Party.Slot4, 74, 10, ConsoleColor.White, ConsoleColor.Black);
                ASCII.HealthBar(player.Party.Slot4, 55, 11);
            }
            //Slot6
            if (player.Party.Slot6.Type != Monster_Race.NONE)
            {
                ASCII.NameANDGender(player.Party.Slot6, 55, 16, gbText, gbBackground);
                ASCII.Level(player.Party.Slot6, 74, 16, ConsoleColor.White, ConsoleColor.Black);
                ASCII.HealthBar(player.Party.Slot6, 55, 17);
            }
        }

        #endregion        

        #region BATTLE: PvP/PvM Displays

        public static void DISSelectFight(Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            string message = $"What will {monster.Name.ToUpper()} do?";
            InstantMessage(message, gbText, gbBackground);
            Console.SetCursorPosition(55, 21);
            Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.SetCursorPosition(55, 22);
            Console.Write("█     [FIGHT]         BAG ");
            Console.SetCursorPosition(55, 23);
            Console.Write("█      POKePARTY      RUN ");
            Console.SetCursorPosition(55, 24);
            Console.Write("█                         ");
            Console.SetCursorPosition(90, 46);
        }

        public static void DISSelectBag(Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            string message = $"What will {monster.Name.ToUpper()} do?";
            InstantMessage(message, gbText, gbBackground);
            Console.SetCursorPosition(55, 21);
            Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.SetCursorPosition(55, 22);
            Console.Write("█      FIGHT         [BAG]");
            Console.SetCursorPosition(55, 23);
            Console.Write("█      POKePARTY      RUN ");
            Console.SetCursorPosition(55, 24);
            Console.Write("█                         ");
            Console.SetCursorPosition(90, 46);
        }

        public static void DISSelectParty(Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            string message = $"What will {monster.Name.ToUpper()} do?";
            InstantMessage(message, gbText, gbBackground);
            Console.SetCursorPosition(55, 21);
            Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.SetCursorPosition(55, 22);
            Console.Write("█      FIGHT          BAG ");
            Console.SetCursorPosition(55, 23);
            Console.Write("█     [POKePARTY]     RUN ");
            Console.SetCursorPosition(55, 24);
            Console.Write("█                         ");
            Console.SetCursorPosition(90, 46);
        }

        public static void DISSelectRun(Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            string message = $"What will {monster.Name.ToUpper()} do?";
            InstantMessage(message, gbText, gbBackground);
            Console.SetCursorPosition(55, 21);
            Console.Write("█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.SetCursorPosition(55, 22);
            Console.Write("█      FIGHT          BAG ");
            Console.SetCursorPosition(55, 23);
            Console.Write("█      POKePARTY     [RUN]");
            Console.SetCursorPosition(55, 24);
            Console.Write("█                         ");
            Console.SetCursorPosition(90, 46);
        }

        public static void DISDefenderInfoBar(Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetCursorPosition(15, 2);
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.Write(" ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.SetCursorPosition(15, 3);
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.Write("█                               ▀▄");
            Console.SetCursorPosition(15, 4);
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.Write("█                                 ▀▄");
            Console.SetCursorPosition(15, 5);
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.Write("▀▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▀");
            System.Threading.Thread.Sleep(5);
            NameANDGender(monster, 17, 3, gbText, gbBackground);
            Level(monster, 38, 3, gbText, gbBackground);
            HealthBar(monster, 17, 4);
            Console.SetCursorPosition(90, 46);

        }

        public static void DISAttackerInfoBar(Player player, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetCursorPosition(37, 13);
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.Write("     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.SetCursorPosition(37, 14);
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.Write("   ▄▀                               █");
            Console.SetCursorPosition(37, 15);
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.Write(" ▄▀                                 █");
            Console.SetCursorPosition(37, 16);
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.Write("▀▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▀");
            System.Threading.Thread.Sleep(5);
            NameANDGender(player.Party.MonsterEquipped, 43, 14, gbText, gbBackground);
            Level(player.Party.MonsterEquipped, 64, 14, gbText, gbBackground);
            HealthBar(player.Party.MonsterEquipped, 43, 15);
            Console.SetCursorPosition(90, 46);
        }

        public static void DISDefender(Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.SetCursorPosition(58, 3);
            Console.Write(monster.ASCIIPokedex[0]);
            Console.SetCursorPosition(58, 4);
            Console.Write(monster.ASCIIPokedex[1]);
            Console.SetCursorPosition(58, 5);
            Console.Write(monster.ASCIIPokedex[2]);
            Console.SetCursorPosition(58, 6);
            Console.Write(monster.ASCIIPokedex[3]);
            Console.SetCursorPosition(58, 7);
            Console.Write(monster.ASCIIPokedex[4]);
            Console.SetCursorPosition(58, 8);
            Console.Write(monster.ASCIIPokedex[5]);
            Console.SetCursorPosition(58, 9);
            Console.Write(monster.ASCIIPokedex[6]);
            Console.SetCursorPosition(58, 10);
            Console.Write(monster.ASCIIPokedex[7]);
            Console.SetCursorPosition(90, 46);
            DISDefenderInfoBar(monster, gbText, gbBackground);
            StaticMessageBox(gbText, gbBackground);
        }

        public static void DISAttacker(Player player, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.SetCursorPosition(4, 13);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[0]);
            Console.SetCursorPosition(4, 14);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[1]);
            Console.SetCursorPosition(4, 15);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[2]);
            Console.SetCursorPosition(4, 16);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[3]);
            Console.SetCursorPosition(4, 17);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[4]);
            Console.SetCursorPosition(4, 18);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[5]);
            Console.SetCursorPosition(4, 19);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[6]);
            Console.SetCursorPosition(4, 20);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[7]);
            Console.SetCursorPosition(90, 46);
            DISAttackerInfoBar(player, gbText, gbBackground);
            StaticMessageBox(gbText, gbBackground);
        }

        public static void DISNPC(Player npc, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.SetCursorPosition(58, 5);
            Console.Write(npc.ASCIIProfile[0]);
            Console.SetCursorPosition(58, 6);
            Console.Write(npc.ASCIIProfile[1]);
            Console.SetCursorPosition(58, 7);
            Console.Write(npc.ASCIIProfile[2]);
            Console.SetCursorPosition(58, 8);
            Console.Write(npc.ASCIIProfile[3]);
            Console.SetCursorPosition(58, 9);
            Console.Write(npc.ASCIIProfile[4]);
            Console.SetCursorPosition(58, 10);
            Console.Write(npc.ASCIIProfile[5]);
            Console.SetCursorPosition(90, 46);
            StaticMessageBox(gbText, gbBackground);
        }

        public static void DISJustDefender(Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            ResetHalfScreen(12, gbText, gbBackground);
            DISDefender(monster, gbText, gbBackground);
        }

        public static void DISJustAttacker(Player player, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            ResetScreen(gbText, gbBackground);
            DISAttacker(player, gbText, gbBackground);
        }

        public static void DISATTandDEF(Player player, Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            ResetScreen(gbText, gbBackground);
            DISDefender(monster, gbText, gbBackground);
            DISAttacker(player, gbText, gbBackground);
            StaticMessageBox(gbText, gbBackground);
        }

        #endregion

        #region BATTLE: Animations

        public static void ThrowBall(Player player, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            PokeBallANI(4, 13, 50, gbBackground);
            DISAttacker(player, gbText, gbBackground);
            PokeBallANI(12, 11, 50, gbBackground);
            DISAttacker(player, gbText, gbBackground);
            PokeBallANI(20, 9, 50, gbBackground);
            DISAttacker(player, gbText, gbBackground);
            PokeBallANI(28, 8, 50, gbBackground);
            PokeBallANI(36, 7, 50, gbBackground);
            PokeBallANI(44, 6, 50, gbBackground);
            PokeBallANI(52, 6, 50, gbBackground);
            PokeBallANI(56, 6, 50, gbBackground);
            PokeBallANI(60, 6, 500, gbBackground);
            BallOpenClose(56, 3, 50, gbBackground);
            PokeBallANI(60, 6, 250, gbBackground);
            PokeBallANI(60, 7, 50, gbBackground);
            PokeBallANI(60, 8, 50, gbBackground);
            PokeBallANI(60, 9, 50, gbBackground);
            PokeBallANI(60, 8, 50, gbBackground);
            PokeBallANI(60, 9, 1500, gbBackground);
        }

        public static void BallShakeLeft(ConsoleColor gbBackground)
        {
            BallFaceLeft(61, 9, 500, gbBackground);
            PokeBallANI(61, 9, 1000, gbBackground);
            Console.SetCursorPosition(90, 46);
        }

        public static void BallShakeRight(ConsoleColor gbBackground)
        {
            BallFaceRight(62, 9, 500, gbBackground);
            PokeBallANI(61, 9, 1000, gbBackground);
            Console.SetCursorPosition(90, 46);
        }

        public static void ANIAttackerSwitch(ConsoleColor gbBackground)
        {
            PokeBallANI(12, 13, 50, gbBackground);
            PokeBallANI(12, 14, 50, gbBackground);
            PokeBallANI(12, 15, 50, gbBackground);
            PokeBallANI(12, 16, 50, gbBackground);
            PokeBallANI(12, 17, 50, gbBackground);
            PokeBallANI(12, 16, 50, gbBackground);
            PokeBallANI(12, 17, 1000, gbBackground);
            BallBreak(8, 16, 50, gbBackground);
        }

        public static void ANIDefenderSwitch(ConsoleColor gbBackground)
        {
            PokeBallANI(60, 5, 50, gbBackground);
            PokeBallANI(60, 6, 50, gbBackground);
            PokeBallANI(60, 7, 50, gbBackground);
            PokeBallANI(60, 8, 50, gbBackground);
            PokeBallANI(60, 9, 50, gbBackground);
            PokeBallANI(60, 8, 50, gbBackground);
            PokeBallANI(60, 9, 1000, gbBackground);
            BallBreak(56, 8, 50, gbBackground);

        }

        public static void ANIDefenderFaint(Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            string message = $"{monster.Name.ToUpper()} fainted!";

            #region Frames
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.SetCursorPosition(58, 3);
            Console.Write(monster.ASCIIPokedex[0]);
            Console.SetCursorPosition(58, 4);
            Console.Write(monster.ASCIIPokedex[1]);
            Console.SetCursorPosition(58, 5);
            Console.Write(monster.ASCIIPokedex[2]);
            Console.SetCursorPosition(58, 6);
            Console.Write(monster.ASCIIPokedex[3]);
            Console.SetCursorPosition(58, 7);
            Console.Write(monster.ASCIIPokedex[4]);
            Console.SetCursorPosition(58, 8);
            Console.Write(monster.ASCIIPokedex[5]);
            Console.SetCursorPosition(58, 9);
            Console.Write(monster.ASCIIPokedex[6]);
            Console.SetCursorPosition(58, 10);
            Console.Write(monster.ASCIIPokedex[7]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

            Console.SetCursorPosition(58, 3);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 4);
            Console.Write(monster.ASCIIPokedex[0]);
            Console.SetCursorPosition(58, 5);
            Console.Write(monster.ASCIIPokedex[1]);
            Console.SetCursorPosition(58, 6);
            Console.Write(monster.ASCIIPokedex[2]);
            Console.SetCursorPosition(58, 7);
            Console.Write(monster.ASCIIPokedex[3]);
            Console.SetCursorPosition(58, 8);
            Console.Write(monster.ASCIIPokedex[4]);
            Console.SetCursorPosition(58, 9);
            Console.Write(monster.ASCIIPokedex[5]);
            Console.SetCursorPosition(58, 10);
            Console.Write(monster.ASCIIPokedex[6]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

            Console.SetCursorPosition(58, 3);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 4);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 5);
            Console.Write(monster.ASCIIPokedex[0]);
            Console.SetCursorPosition(58, 6);
            Console.Write(monster.ASCIIPokedex[1]);
            Console.SetCursorPosition(58, 7);
            Console.Write(monster.ASCIIPokedex[2]);
            Console.SetCursorPosition(58, 8);
            Console.Write(monster.ASCIIPokedex[3]);
            Console.SetCursorPosition(58, 9);
            Console.Write(monster.ASCIIPokedex[4]);
            Console.SetCursorPosition(58, 10);
            Console.Write(monster.ASCIIPokedex[5]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

            Console.SetCursorPosition(58, 3);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 4);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 5);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 6);
            Console.Write(monster.ASCIIPokedex[0]);
            Console.SetCursorPosition(58, 7);
            Console.Write(monster.ASCIIPokedex[1]);
            Console.SetCursorPosition(58, 8);
            Console.Write(monster.ASCIIPokedex[2]);
            Console.SetCursorPosition(58, 9);
            Console.Write(monster.ASCIIPokedex[3]);
            Console.SetCursorPosition(58, 10);
            Console.Write(monster.ASCIIPokedex[4]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

            Console.SetCursorPosition(58, 3);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 4);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 5);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 6);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 7);
            Console.Write(monster.ASCIIPokedex[0]);
            Console.SetCursorPosition(58, 8);
            Console.Write(monster.ASCIIPokedex[1]);
            Console.SetCursorPosition(58, 9);
            Console.Write(monster.ASCIIPokedex[2]);
            Console.SetCursorPosition(58, 10);
            Console.Write(monster.ASCIIPokedex[3]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

            Console.SetCursorPosition(58, 3);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 4);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 5);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 6);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 7);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 8);
            Console.Write(monster.ASCIIPokedex[0]);
            Console.SetCursorPosition(58, 9);
            Console.Write(monster.ASCIIPokedex[1]);
            Console.SetCursorPosition(58, 10);
            Console.Write(monster.ASCIIPokedex[2]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

            Console.SetCursorPosition(58, 3);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 4);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 5);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 6);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 7);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 8);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 9);
            Console.Write(monster.ASCIIPokedex[0]);
            Console.SetCursorPosition(58, 10);
            Console.Write(monster.ASCIIPokedex[1]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

            Console.SetCursorPosition(58, 3);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 4);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 5);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 6);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 7);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 8);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 9);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 10);
            Console.Write(monster.ASCIIPokedex[0]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

            Console.SetCursorPosition(58, 3);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 4);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 5);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 6);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 7);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 8);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 9);
            Console.Write("                  ");
            Console.SetCursorPosition(58, 10);
            Console.Write("                  ");
            Console.SetCursorPosition(90, 46);
            #endregion

            System.Threading.Thread.Sleep(1000);
            ScrollMessage(message, 50, 2000, gbText, gbBackground);
        }

        public static void ANIAttackerFaint(Player player, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            string message = $"{player.Party.MonsterEquipped.Name.ToUpper()} fainted!";

            #region Frames
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.SetCursorPosition(4, 13);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 14);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[0]);
            Console.SetCursorPosition(4, 15);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[1]);
            Console.SetCursorPosition(4, 16);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[2]);
            Console.SetCursorPosition(4, 17);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[3]);
            Console.SetCursorPosition(4, 18);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[4]);
            Console.SetCursorPosition(4, 19);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[5]);
            Console.SetCursorPosition(4, 20);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[6]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

            Console.SetCursorPosition(4, 13);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 14);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 15);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[0]);
            Console.SetCursorPosition(4, 16);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[1]);
            Console.SetCursorPosition(4, 17);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[2]);
            Console.SetCursorPosition(4, 18);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[3]);
            Console.SetCursorPosition(4, 19);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[4]);
            Console.SetCursorPosition(4, 20);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[5]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

            Console.SetCursorPosition(4, 13);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 14);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 15);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 16);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[0]);
            Console.SetCursorPosition(4, 17);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[1]);
            Console.SetCursorPosition(4, 18);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[2]);
            Console.SetCursorPosition(4, 19);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[3]);
            Console.SetCursorPosition(4, 20);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[4]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

            Console.SetCursorPosition(4, 13);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 14);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 15);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 16);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 17);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[0]);
            Console.SetCursorPosition(4, 18);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[1]);
            Console.SetCursorPosition(4, 19);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[2]);
            Console.SetCursorPosition(4, 20);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[3]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

            Console.SetCursorPosition(4, 13);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 14);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 15);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 16);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 17);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 18);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[0]);
            Console.SetCursorPosition(4, 19);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[1]);
            Console.SetCursorPosition(4, 20);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[2]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

            Console.SetCursorPosition(4, 13);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 14);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 15);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 16);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 17);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 18);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 19);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[0]);
            Console.SetCursorPosition(4, 20);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[1]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

            Console.SetCursorPosition(4, 13);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 14);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 15);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 16);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 17);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 18);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 19);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 20);
            Console.Write(player.Party.MonsterEquipped.ASCIIAttacker[0]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

            Console.SetCursorPosition(4, 13);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 14);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 15);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 16);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 17);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 18);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 19);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 20);
            Console.Write("                       ");
            Console.SetCursorPosition(90, 46);
            #endregion

            System.Threading.Thread.Sleep(1000);
            ScrollMessage(message, 50, 2000, gbText, gbBackground);
        }

        public static void ANIWildAppear(Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            string message = $"A wild {monster.Name} appeared!";
            string distance = "                                                                      ";
            int startPositionX = 95;
            foreach (char frame in distance)
            {
                Console.SetCursorPosition(4, 3);
                Console.Write(monster.ASCIIDefender[0].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 4);
                Console.Write(monster.ASCIIDefender[1].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 5);
                Console.Write(monster.ASCIIDefender[2].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 6);
                Console.Write(monster.ASCIIDefender[3].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 7);
                Console.Write(monster.ASCIIDefender[4].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 8);
                Console.Write(monster.ASCIIDefender[5].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 9);
                Console.Write(monster.ASCIIDefender[6].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 10);
                Console.Write(monster.ASCIIDefender[7].Substring(startPositionX, 83));
                Console.SetCursorPosition(90, 46);
                startPositionX -= 1;
                System.Threading.Thread.Sleep(1);
            }
            DISDefenderInfoBar(monster, gbText, gbBackground);
            ScrollMessage(message, 50, 2000, gbText, gbBackground);
        }

        public static void ANINPCAppear(Player npc, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            string message = $"{npc.Name} challenged you to a battle!";
            string distance = "                                                                      ";
            int startPositionX = 95;
            foreach (char frame in distance)
            {
                Console.SetCursorPosition(4, 5);
                Console.Write(npc.ASCIIDefender[0].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 6);
                Console.Write(npc.ASCIIDefender[1].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 7);
                Console.Write(npc.ASCIIDefender[2].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 8);
                Console.Write(npc.ASCIIDefender[3].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 9);
                Console.Write(npc.ASCIIDefender[4].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 10);
                Console.Write(npc.ASCIIDefender[5].Substring(startPositionX, 83));
                Console.SetCursorPosition(90, 46);
                startPositionX -= 1;
                System.Threading.Thread.Sleep(1);
            }
            ScrollMessage(message, 50, 1500, gbText, gbBackground);
        }

        public static void ANINPCSend(Player npc, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            string message = $"{npc.Name} sent out {npc.Party.MonsterEquipped.Name}!";
            System.Threading.Thread.Sleep(1500);
            ScrollMessage(message, 50, 2000, gbText, gbBackground);
            ANIDefenderSwitch(gbBackground);
            DISDefender(npc.Party.MonsterEquipped, gbText, gbBackground);
        }

        public static void ANIPlayerSend(Player player, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            string message = $"{player.Name} sent out {player.Party.MonsterEquipped.Name}!";
            ScrollMessage(message, 50, 1500, gbText, gbBackground);
            ANIAttackerSwitch(gbBackground);
            Console.ForegroundColor = gbText;
            DISAttacker(player, gbText, gbBackground);
            DISAttackerInfoBar(player, gbText, gbBackground);
        }

        public static void ANIReturn(int positionX, int positionY, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            int startPos = positionY;
            #region Frames
            string[] frameFIVE = new string[]
            {
                "                       ",
                "                       ",
                "                       ",
                "                       ",
                "                       ",
                "                       ",
                "                       ",
                "                       "
            };
            string[] frameFOUR = new string[]
            {
                "                       ",
                "                       ",
                "                       ",
                "                       ",
                "                       ",
                "           ▄           ",
                "        ▀▄ ▀ ▄▀        ",
                "       ▀▀     ▄▄       "
            };
            string[] frameTHREE = new string[]
            {
                "                       ",
                "                       ",
                "                       ",
                "                       ",
                "                       ",
                "      ▄    ▄    ▄      ",
                "       ▀   ▀   ▀       ",
                "     ▄▄         ▄▄     "
            };
            string[] frameTWO = new string[]
            {
                "                       ",
                "                       ",
                "                       ",
                "                       ",
                "           ▄           ",
                "     ▀     ▄     ▀     ",
                "       ▀       ▀       ",
                "   ▄ ▄           ▄ ▄   "
            };
            string[] frameONE = new string[]
            {
                "                       ",
                "                       ",
                "                       ",
                "                       ",
                "                       ",
                "     ▀     ▀     ▀     ",
                "                       ",
                "   ▄               ▄   "
            };
            #endregion

            Console.ForegroundColor = ConsoleColor.White;
            #region Frame One

            foreach (string frame in frameONE)
            {
                Console.SetCursorPosition(positionX, positionY);
                Console.Write(frame);
                Console.SetCursorPosition(90, 46);
                positionY += 1;
            }

            #endregion            
            System.Threading.Thread.Sleep(50);
            #region Frame Two

            positionY = startPos;
            foreach (string frame in frameTWO)
            {
                Console.SetCursorPosition(positionX, positionY);
                Console.Write(frame);
                Console.SetCursorPosition(90, 46);
                positionY += 1;
            }

            #endregion            
            System.Threading.Thread.Sleep(50);
            #region Frame Three

            positionY = startPos;
            foreach (string frame in frameTHREE)
            {
                Console.SetCursorPosition(positionX, positionY);
                Console.Write(frame);
                Console.SetCursorPosition(90, 46);
                positionY += 1;
            }

            #endregion
            System.Threading.Thread.Sleep(50);
            #region Frame Four

            positionY = startPos;
            foreach (string frame in frameFOUR)
            {
                Console.SetCursorPosition(positionX, positionY);
                Console.Write(frame);
                Console.SetCursorPosition(90, 46);
                positionY += 1;
            }

            #endregion
            System.Threading.Thread.Sleep(50);
            #region Frame Five

            positionY = startPos;
            foreach (string frame in frameFIVE)
            {
                Console.SetCursorPosition(positionX, positionY);
                Console.Write(frame);
                Console.SetCursorPosition(90, 46);
                positionY += 1;
            }

            #endregion
            System.Threading.Thread.Sleep(500);
        }

        public static void ANIPlayerSwitchSend(Player player, int slot, Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            string message = $"{player.Party.MonsterEquipped.Name.ToUpper()} return!";
            if (player.Party.MonsterEquipped.Health >= 0)
            {
                DISATTandDEF(player, monster, gbText, gbBackground);
                ScrollMessage(message, 50, 1000, gbText, gbBackground);
                ANIReturn(6, 13, gbText, gbBackground);
            }
            ResetHalfScreen(12, gbText, gbBackground);
            System.Threading.Thread.Sleep(1000);
            switch (slot)
            {
                case 2:
                    player.Party.MonsterSwitch = player.Party.MonsterEquipped;
                    player.Party.MonsterEquipped = player.Party.Slot2;
                    player.Party.Slot2 = player.Party.MonsterSwitch;
                    break;
                case 3:
                    player.Party.MonsterSwitch = player.Party.MonsterEquipped;
                    player.Party.MonsterEquipped = player.Party.Slot3;
                    player.Party.Slot3 = player.Party.MonsterSwitch;
                    break;
                case 4:
                    player.Party.MonsterSwitch = player.Party.MonsterEquipped;
                    player.Party.MonsterEquipped = player.Party.Slot4;
                    player.Party.Slot4 = player.Party.MonsterSwitch;
                    break;
                case 5:
                    player.Party.MonsterSwitch = player.Party.MonsterEquipped;
                    player.Party.MonsterEquipped = player.Party.Slot5;
                    player.Party.Slot5 = player.Party.MonsterSwitch;
                    break;
                case 6:
                    player.Party.MonsterSwitch = player.Party.MonsterEquipped;
                    player.Party.MonsterEquipped = player.Party.Slot6;
                    player.Party.Slot6 = player.Party.MonsterSwitch;
                    break;
                default:
                    break;
            }          
            ANIPlayerSend(player, gbText, gbBackground);
        }

        public static void ANIPlayerSwitchSendNPCFaint(Player player, int slot, Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            string message = $"{player.Party.MonsterEquipped.Name.ToUpper()} return!";
            if (player.Party.MonsterEquipped.Health >= 0)
            {
                DISJustAttacker(player, gbText, gbBackground);
                ScrollMessage(message, 50, 1000, gbText, gbBackground);
                ANIReturn(6, 13, gbText, gbBackground);
            }
            ResetHalfScreen(12, gbText, gbBackground);
            System.Threading.Thread.Sleep(1000);
            switch (slot)
            {
                case 2:
                    player.Party.MonsterSwitch = player.Party.MonsterEquipped;
                    player.Party.MonsterEquipped = player.Party.Slot2;
                    player.Party.Slot2 = player.Party.MonsterSwitch;
                    break;
                case 3:
                    player.Party.MonsterSwitch = player.Party.MonsterEquipped;
                    player.Party.MonsterEquipped = player.Party.Slot3;
                    player.Party.Slot3 = player.Party.MonsterSwitch;
                    break;
                case 4:
                    player.Party.MonsterSwitch = player.Party.MonsterEquipped;
                    player.Party.MonsterEquipped = player.Party.Slot4;
                    player.Party.Slot4 = player.Party.MonsterSwitch;
                    break;
                case 5:
                    player.Party.MonsterSwitch = player.Party.MonsterEquipped;
                    player.Party.MonsterEquipped = player.Party.Slot5;
                    player.Party.Slot5 = player.Party.MonsterSwitch;
                    break;
                case 6:
                    player.Party.MonsterSwitch = player.Party.MonsterEquipped;
                    player.Party.MonsterEquipped = player.Party.Slot6;
                    player.Party.Slot6 = player.Party.MonsterSwitch;
                    break;
                default:
                    break;
            }
            ANIPlayerSend(player, gbText, gbBackground);
        }

        public static void ANINPCNext(Player player, Player npc, int slot, ConsoleColor gbText, ConsoleColor gbBackground)
        {            
            switch (slot)
            {
                case 2:
                    npc.Party.MonsterSwitch = npc.Party.MonsterEquipped;
                    npc.Party.MonsterEquipped = npc.Party.Slot2;
                    npc.Party.Slot2 = npc.Party.MonsterSwitch;
                    break;
                case 3:
                    npc.Party.MonsterSwitch = npc.Party.MonsterEquipped;
                    npc.Party.MonsterEquipped = npc.Party.Slot3;
                    npc.Party.Slot3 = npc.Party.MonsterSwitch;
                    break;
                case 4:
                    npc.Party.MonsterSwitch = npc.Party.MonsterEquipped;
                    npc.Party.MonsterEquipped = npc.Party.Slot4;
                    npc.Party.Slot4 = npc.Party.MonsterSwitch;
                    break;
                case 5:
                    npc.Party.MonsterSwitch = npc.Party.MonsterEquipped;
                    npc.Party.MonsterEquipped = npc.Party.Slot5;
                    npc.Party.Slot5 = npc.Party.MonsterSwitch;
                    break;
                case 6:
                    npc.Party.MonsterSwitch = npc.Party.MonsterEquipped;
                    npc.Party.MonsterEquipped = npc.Party.Slot6;
                    npc.Party.Slot6 = npc.Party.MonsterSwitch;
                    break;
                default:
                    break;
            }
            string message1 = $"{npc.Name.ToUpper()} is about to send {npc.Party.MonsterEquipped.Name.ToUpper()}.";
            string message2 = $"Will you send out another Pokefraud?";
            ScrollMessage(message1, 50, 2000, gbText, gbBackground);
            ScrollMessage(message2, 50, 1000, gbText, gbBackground);
        }

        public static void ANINPCDefeat(Player player, Player npc, int money, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            string message1 = $"{player.Name.ToUpper()} defeated {npc.Name.ToUpper()}!";
            string message2 = $"{npc.Name.ToUpper()} rewarded {player.Name.ToUpper()} ${money}.";
            DISNPC(npc, gbText, gbBackground);
            DISAttacker(player, gbText, gbBackground);
            ScrollMessage(message1, 50, 2000, gbText, gbBackground);
            ScrollMessage(message2, 50, 2000, gbText, gbBackground);
            player.Money += money;
        }

        public static void ANIQuePlayerFight(Player player, Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            DISATTandDEF(player, monster, gbText, gbBackground);
        }

        #endregion

        #region BATTLE: Situational Encounters

        public static void WildEncounter(Player player, Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            ResetScreen(gbText, gbBackground);
            ANIWildAppear(monster, gbText, gbBackground);
            System.Threading.Thread.Sleep(1500);
            ANIPlayerSend(player, gbText, gbBackground);
            System.Threading.Thread.Sleep(1500);
        }

        public static void NPCEncounter(Player player, Player npc, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            ResetScreen(gbText, gbBackground);
            ANINPCAppear(npc, gbText, gbBackground);
            ANINPCSend(npc, gbText, gbBackground);
            ANIPlayerSend(player, gbText, gbBackground);
            System.Threading.Thread.Sleep(2000);
        }

        public static void FullBattleWild(Player player, Monster[] monsters, int lvLow, int lvHigh, ConsoleColor gbText, ConsoleColor gbBackground, ConsoleKey navPlayerMenu)
        {
            Random rand = new Random();
            int diceRole = rand.Next(lvLow, lvHigh);
            char[] genders = new char[] { '♂', '♀' };
            int diceRollGender = rand.Next(1, 10);
            char gender = new char();
            if (diceRollGender == 1 || diceRollGender == 3 || diceRollGender == 5 || diceRollGender == 7 || diceRollGender == 9)
            {
                gender = genders[0];
            }
            else
            {
                gender = genders[1];
            }

            Monster defender = monsters[new Random().Next(monsters.Length)];
            defender.Lv = diceRole;
            defender.MaxHealth = diceRole * 5;
            defender.Health = diceRole * 5;
            defender.Gender = gender;

            //SFX.Battle();
            WildEncounter(player, defender, gbText, gbBackground);

            Player_Menus.WildFightMenu(player, defender, navPlayerMenu, gbText, gbBackground);
        }

        public static void FullBattleNPC(Player player, Player npc, ConsoleColor gbText, ConsoleColor gbBackground, ConsoleKey navPlayerMenu)
        {
            NPCEncounter(player, npc, gbText, gbBackground);

            Player_Menus.NPCFightMenu(player, npc, navPlayerMenu, gbText, gbBackground);
        }

        #endregion

        #endregion

        #region METHODS: Display Objects

        public static void StaticMessageBox(ConsoleColor GameText, ConsoleColor GameBackground)
        {
            Console.ForegroundColor = GameText;
            Console.BackgroundColor = GameBackground;
            Console.SetCursorPosition(4, 21);
            Console.WriteLine(" ▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄ ");
            Console.SetCursorPosition(4, 22);
            Console.WriteLine(" █                                                                               █ ");
            Console.SetCursorPosition(4, 23);
            Console.WriteLine(" █                                                                               █ ");
            Console.SetCursorPosition(4, 24);
            Console.WriteLine(" █                                                                               █ ");
            Console.SetCursorPosition(4, 25);
            Console.WriteLine("  ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  ");
            Console.SetCursorPosition(90, 46);
        }

        public static void InstantMessage(string Message, ConsoleColor GameText, ConsoleColor GameBackground)
        {
            Console.ForegroundColor = GameText;
            Console.BackgroundColor = GameBackground;
            Console.SetCursorPosition(4, 21);
            Console.WriteLine(" ▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄ ");
            Console.SetCursorPosition(4, 22);
            Console.WriteLine(" █                                                                               █ ");
            Console.SetCursorPosition(4, 23);
            Console.WriteLine(" █                                                                               █ ");
            Console.SetCursorPosition(4, 24);
            Console.WriteLine(" █                                                                               █ ");
            Console.SetCursorPosition(4, 25);
            Console.WriteLine("  ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  ");
            Console.SetCursorPosition(8, 22);
            Console.Write(Message);
        }

        /****DISPLAYS A SCROLLING MESSAGE ([Speed/Delay] FOR BATTLE: 50/1000, FOR ESCAPE: 15/2000, FOR CATCH SUCCESS: 50/2000****/
        public static void ScrollMessage(string Message, int Speed, int Delay, ConsoleColor GameText, ConsoleColor GameBackground)
        {
            Console.ForegroundColor = GameText;
            Console.BackgroundColor = GameBackground;
            Console.SetCursorPosition(4, 21);
            Console.WriteLine(" ▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄ ");
            Console.SetCursorPosition(4, 22);
            Console.WriteLine(" █                                                                               █ ");
            Console.SetCursorPosition(4, 23);
            Console.WriteLine(" █                                                                               █ ");
            Console.SetCursorPosition(4, 24);
            Console.WriteLine(" █                                                                               █ ");
            Console.SetCursorPosition(4, 25);
            Console.WriteLine("  ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  ");
            Console.SetCursorPosition(8, 22);
            foreach (char c in Message)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(Speed);
            }
            System.Threading.Thread.Sleep(Delay);
        }

        /****TODO: CREATE METHODS FOR OBJECTS WITH COLOR TO BE PASTED IN THE MAPS****/
        public static void CharacterMale(int posX, int posY, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            //(42, 10) **Top Left of Player at Center Screen
            //(4,2) **Top Left of Screen
            //(87,25) **Bottom Right of Screen
            
            string[] defaultMale = new string[]
            {
                "▄▄███▄",
                "▀",
                "▄█▄",
                "▀",
                "▀",
                "▄█▄",
                "▀",
                "▀ ▀"
            };

            if (posX <= 80 && posX >= 4 && posY <= 21 && posY >= 2)
            {
                #region IF ON SCREEN
                Console.BackgroundColor = gbBackground;
                Console.SetCursorPosition(posX, posY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(defaultMale[0]);

                Console.SetCursorPosition(posX + 1, posY + 1);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(defaultMale[1]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(defaultMale[2]);
                Console.BackgroundColor = gbBackground;
                Console.Write(defaultMale[3]);

                Console.SetCursorPosition(posX + 1, posY + 2);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = gbBackground;
                Console.Write(defaultMale[4]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(defaultMale[5]);
                Console.BackgroundColor = gbBackground;
                Console.Write(defaultMale[6]);

                Console.SetCursorPosition(posX + 2, posY + 3);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(defaultMale[7]);
                Console.SetCursorPosition(90, 46);
                #endregion
            }

            #region IF BORDER RIGHT
            //Console.BackgroundColor = gbBackground;
            //Console.SetCursorPosition(posX, posY);
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(defaultMale[0]);

            //Console.SetCursorPosition(posX + 1, posY + 1);
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.Write(defaultMale[1]);
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.Write(defaultMale[2]);
            //Console.BackgroundColor = gbBackground;
            //Console.Write(defaultMale[3]);

            //Console.SetCursorPosition(posX + 1, posY + 2);
            //Console.ForegroundColor = ConsoleColor.DarkGray;
            //Console.BackgroundColor = gbBackground;
            //Console.Write(defaultMale[4]);
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.Write(defaultMale[5]);
            //Console.BackgroundColor = gbBackground;
            //Console.Write(defaultMale[6]);

            //Console.SetCursorPosition(posX + 2, posY + 3);
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Console.Write(defaultMale[7]);
            //Console.SetCursorPosition(90, 46);
            #endregion
        }

        #endregion

        #region ASCII: String[] Templates

        #region Player Menu

        public static string[] PMPokedexSelect = new string[]
            {
               @"                                                        ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄  ",
               @"                                                         █     PokeROLODEX      █  ",
               @"                                                          █                     █  ",
               @"      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄                  █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"     ██                                  █                  █  PARTY            █  ",
               @"     █ █   (O)  o o o                     █                 █                   █  ",
               @"      █ █                     ▄▄▄▄▄▄▄▄▄▄▄▄ █                █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"       █ █                   █            █ █               █  BAG              █  ",
               @"        █ █   ▄▄▄▄▄▄▄▄▄▄▄▄▄▄█              █ █              █                   █  ",
               @"         █ █ █                              █ █             █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"          █ █ █                              █ █            █                   █  ",
               @"           █ █ █                              █ █           █                   █  ",
               @"            █ █ █ █▀▀▄▄                        █ █          █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"             █ █ █ █  ▄▀                        █ █         █  EXIT             █  ",
               @"              █ █ █ █▀                           █ █        █                   █  ",
               @"               █ █ █                              █ █       █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"                █ █ █                              █ █                             ",
               @"                 █ █ █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█ █                            ",
               @"                  █ █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█                           ",
               @"                   █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▀                           ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   "
            };

        public static string[] PMPartySelect = new string[]
            {
               @"                                                            ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄  ",
               @"                                                            █  PokeROLODEX      █  ",
               @"                                                            █                   █  ",
               @"                                                        ▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"                                                         █     PARTY            █  ",
               @"                         ▄▄▄▄▄▄▄▄                         █                     █  ",
               @"                    ▄▄▀▀▀        ▀▀▀▄▄                     █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"                 ▄▀▀          ▀███▄   ▀▀▄                   █  BAG              █  ",
               @"               ▄▀                ▀██▄    ▀▄                 █                   █  ",
               @"              █                     ▀▄     █                █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"             █       ▄▄▄▄▄                  █               █                   █  ",
               @"            █▄▄▄▄▄▄▄▀ ▄▄▄ ▀▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█              █                   █  ",
               @"            █______█ █   █ █_________________█              █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"            ████████▄ ▀▀▀ ▄███████████████████              █  EXIT             █  ",
               @"             ████████████████████████████████               █                   █  ",
               @"              ██████████████████████████████                █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"               ▀██████████████████████████▀                                        ",
               @"                 ▀██████████████████████▀                                          ",
               @"                    ▀▀██████████████▀▀                                             ",
               @"                         ▀▀▀▀▀▀▀▀                                                  ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   "
            };

        public static string[] PMBagSelect = new string[]
            {
               @"                                                            ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄  ",
               @"                                                            █  PokeROLODEX      █  ",
               @"                                                            █                   █  ",
               @"                                                            █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"                                                            █  PARTY            █  ",
               @"                                                            █                   █  ",
               @"                                                        ▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"                      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄                     █     BAG              █  ",
               @"                     █/            \█                     █                     █  ",
               @"               _____█|______________|█_____                █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"            ▄▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▄              █                   █  ",
               @"           █|     ▀▄_______▀▄▄▀_______▄▀      █             █                   █  ",
               @"          █|    ▄▄▄▄▄▄     ▀▄▄▀     ▄▄▄▄▄▄     █            █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"         █|    █__o___█            █___o__█     █           █  EXIT             █  ",
               @"         █|    █      █            █      █     █           █                   █  ",
               @"          █|    ▀▄▄▄▄▄█            █▄▄▄▄▄▀     █            █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"           █|                                |█                                    ",
               @"            ▀▄-____________________________-▄▀                                     ",
               @"              ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀                                       ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   "
            };

        public static string[] PMProfileSelect = new string[]
            {
               @"                                                            ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄  ",
               @"                                                            █  PokeROLODEX      █  ",
               @"                                                            █                   █  ",
               @"                                                            █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"                 ▄▀▀▀▀▀▀▄                                   █  PARTY            █  ",
               @"                █ ██████ █                                  █                   █  ",
               @"               ██▀▄▄▄▄▄▄▀██                                 █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"              █ ▀  ▄  ▄  ▀ █                                █  BAG              █  ",
               @"               ██▄ ▀  ▀ ▄██                                 █                   █  ",
               @"              █  ████████  █    ▄▀▀▀▀▀▀▄                ▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"               ▀█▀▄▄▀▀▄▄▀█▀    █ ██████ █                █                      █  ",
               @"                ▀▄▄▄▀▀▄▄▄▀    ██▀▄▄▄▄▄▄▀██                █                     █  ",
               @"                             █ ▀  ▄  ▄  ▀ █                █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"                              ██▄ ▀  ▀ ▄██                  █  EXIT             █  ",
               @"                             █  ████████  █                 █                   █  ",
               @"                              ▀█▀▄▄▀▀▄▄▀█▀                  █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"                               ▀▄▄▄▀▀▄▄▄▀                                          ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   "
            };

        public static string[] PMExitSelect = new string[]
            {
               @"                                                            ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄  ",
               @"                                                            █  PokeROLODEX      █  ",
               @"                                                            █                   █  ",
               @"                                                            █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"                                                            █  PARTY            █  ",
               @"                                                            █                   █  ",
               @"                                                            █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"                                                            █  BAG              █  ",
               @"                                                            █                   █  ",
               @"                                                            █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"                                                            █                   █  ",
               @"                                                            █                   █  ",
               @"                                                        ▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"                                                         █     EXIT             █  ",
               @"                                                          █                     █  ",
               @"                                                           █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   "
            };

        #endregion

        #region Maps

        #region DEMO Map

        public static string[] DEMOMap = new string[]
        {
@"   ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄  ",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                                                                                                                                       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                                                                                                                                 ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                                                                                                                                       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                          ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄                                         ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄                                          ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                       ▄▀▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▀▄                                     ▄▀▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▀▄                                       ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                      █ █                   █ █                                   █ █       █   █       █ █                                      ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                           █ █                   █ █                                   █ █       █▀▀▀█       █ █                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                          █ ▀▄▄▄▄▄▄  ▄▄▄  ▄▄▄▄▄▄▀ █                                   █ ▀▄▄▄▄▄▄  ▄▄▄  ▄▄▄▄▄▄▀ █                                          ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                         ██        ▀ ▄ ▀        ██                                   ██        ▀ ▄ ▀        ██                                         ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                       █▀███████ ▀▄▄▄▀ ███████▀█                                   █▀███████ ▀▄▄▄▀ ███████▀█                                       ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                      █                       █                                   █                       █                                      ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                      █  ▄▄▄▄▄▄▄▄▄    ▄▄▄▄▄▄  █                                   █       ▄▄▄▄▄▄▄▄▄       █                                      ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                           █ █▀▄▄▄▄▄▄▄▀█   |SALE|  █                                   █      █▀▄▄▄▄▄▄▄▀█      █                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                          █ █ █     █ █   ▀▀▀▀▀▀  █                                   █      █ █     █ █      █                                          ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                          ▀█ █   ▀ █ █▄▄▄▄▄▄▄▄▄▄▄▀                                    ▀▄▄▄▄▄█ █   ▀ █ █▄▄▄▄▄▄▀                                         ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                          ▀█▄▄▄▄▄█▀                                                        ▀█▄▄▄▄▄█▀                                               ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                                                                                                                                 ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                                                                                                                                       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                              ▄▄▄▄▄▄                                                           ▄▄▄▄▄▄                                              ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                          ▄▄▄█    █▄▄▄                                                     ▄▄▄█    █▄▄▄                                          ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                       ▄▄▄█  █    █  █▄▄▄                                               ▄▄▄█  █    █  █▄▄▄                                       ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                         ▄▄▄█  █  █    █  █  █▄▄▄                                         ▄▄▄█  █  █    █  █  █▄▄▄                                         ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                     ▄▄▄█  █  █  █    █  █  █  █▄▄▄                                   ▄▄▄█  █  █  █    █  █  █  █▄▄▄                                     ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                    █  █  █  █  █▄▄▄▄█  █  █  █  █                                   █  █  █  █  █▄▄▄▄█  █  █  █  █                                    ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                  █  █  █  █▄▄█ ██ █▄▄█  █  █  █                                   █  █  █  █▄▄█ ██ █▄▄█  █  █  █                                  ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                 █  █  █▄▄█    ██    █▄▄█  █  █                                   █  █  █▄▄█    ██    █▄▄█  █  █                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                 █  █▄▄█  ▀▀█▄ ██ ▄█▀▀  █▄▄█  █                                   █  █▄▄█  ▀▀█▄ ██ ▄█▀▀  █▄▄█  █                                 ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                      █▄▄█▄▄▄▄▄▄▄▄▄████▄▄▄▄▄▄▄▄▄█▄▄█                                   █▄▄█▄▄▄▄▄▄▄▄▄████▄▄▄▄▄▄▄▄▄█▄▄█                                      ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                      █                          █                                     █                          █                                      ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                     █  ▄▄▄▄▄▄▄      ▄▄▄▄▄▄▄▄   █                                     █  ▄▄▄▄▄▄▄      ▄▄▄▄▄▄▄▄   █                                     ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                   █  █     █     █ █    █ █  █                                     █  █     █     █ █    █ █  █                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                  █  █   ▀ █      ▀▀▀▀▀▀▀▀   █                                     █  █   ▀ █      ▀▀▀▀▀▀▀▀   █                                  ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                  █▄▄█▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█                                     █▄▄█▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█                                  ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                                                                                                                                       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄                                                     ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                          █                          █                          █                                                          ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                         █                          █                          █                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                        █                          █                          █                                                        ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                      █                          █                          █                                                      ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                               ▄▄▄▄▄▄█                        ▄▄█▄▄                        █▄▄▄▄▄▄                                               ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                               █     █                     ▄▀▀  █  ▀▀▄                     █     █                                               ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                    █     █                    ▄▀ ▄▀▀█▀▀▄ ▀▄                    █     █                                                    ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                   █     █                    █  █  █  █  █                    █     █                                                   ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                  █     █                     █  ▀▀█▀▀  █                     █     █                                                  ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                █▄▄▄▄▄█                      ▀▀▄▄█▄▄▀▀                      █▄▄▄▄▄█                                                ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                     █                          █                          █                                                     ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                     █                          █                          █                                                     ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                          █                          █                          █                                                          ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                         █                          █                          █                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                        █                          █                          █                                                        ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                      █                          █                          █                                                      ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                     ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀                                                     ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                                                                                                                                 ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█"
        };
       
        #endregion

        #region Home Town
        public static string[] TestMap = new string[]
        {
@"   ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄                                                       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄  ",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                 ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                 ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                 ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                 ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀                                                 ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                                                                                                                                       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                                                                                                                                 ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                ▄▄▄                                                                     ▄▄▄                                                ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                            ▄▄▄█ █▄▄▄                                                               ▄▄▄█ █▄▄▄                                            ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                        ▄▄▄█  █ █  █▄▄▄                                                         ▄▄▄█  █ █  █▄▄▄                                        ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                   ▄▄▄█  █  █ █  █  █▄▄▄                                                   ▄▄▄█  █  █ █  █  █▄▄▄                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                               ▄▄▄█  █  █  █ █  █  █  █▄▄▄                                             ▄▄▄█  █  █  █ █  █  █  █▄▄▄                               ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                            ▄▄▄█  █  █  █  █▄█  █  █  █  █▄▄▄                                       ▄▄▄█  █  █  █  █▄█  █  █  █  █▄▄▄                            ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                 █  █  █  █  █▄█ █ █▄█  █  █  █  █                                       █  █  █  █  █▄█ █ █▄█  █  █  █  █                                 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                █  █  █  █▄█    █    █▄█  █  █  █                                       █  █  █  █▄█    █    █▄█  █  █  █                                ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                               █  █  █▄██▄     █     ▄██▄█  █  █                                       █  █  █▄██▄     █     ▄██▄█  █  █                               ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                             █  █▄█    ▀▀█▄▄ █ ▄▄█▀▀    █▄█  █                                       █  █▄█    ▀▀█▄▄ █ ▄▄█▀▀    █▄█  █                             ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                            █▄█▄▄▄▄▄▄▄▄▄▄▄█████▄▄▄▄▄▄▄▄▄▄▄█▄█                                       █▄█▄▄▄▄▄▄▄▄▄▄▄█████▄▄▄▄▄▄▄▄▄▄▄█▄█                            ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                             █                             █                                         █                             █                             ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                  █    ▄▄▄▄▄       ▄▄▄▄▄▄▄▄     █                                         █    ▄▄▄▄▄       ▄▄▄▄▄▄▄▄     █                                  ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                 █   █     █     █ █    █ █    █                                         █   █     █     █ █    █ █    █                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                █   █   ▀ █      ▀▀▀▀▀▀▀▀     █                                         █   █   ▀ █      ▀▀▀▀▀▀▀▀     █                                ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                              █▄▄▄█▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█                                         █▄▄▄█▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█                              ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                                                                                                                                 ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                              ▄▄▄                                                                     ▄▄▄                                              ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                         ▄▄▄█ █▄▄▄                                                               ▄▄▄█ █▄▄▄                                         ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                     ▄▄▄█  █ █  █▄▄▄                                                         ▄▄▄█  █ █  █▄▄▄                                     ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                  ▄▄▄█  █  █ █  █  █▄▄▄                                                   ▄▄▄█  █  █ █  █  █▄▄▄                                  ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                    ▄▄▄█  █  █  █ █  █  █  █▄▄▄                                             ▄▄▄█  █  █  █ █  █  █  █▄▄▄                                    ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                ▄▄▄█  █  █  █  █▄█  █  █  █  █▄▄▄                                       ▄▄▄█  █  █  █  █▄█  █  █  █  █▄▄▄                                ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                               █  █  █  █  █▄█ █ █▄█  █  █  █  █                                       █  █  █  █  █▄█ █ █▄█  █  █  █  █                               ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                             █  █  █  █▄█    █    █▄█  █  █  █                                       █  █  █  █▄█    █    █▄█  █  █  █                             ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                            █  █  █▄██▄     █     ▄██▄█  █  █                                       █  █  █▄██▄     █     ▄██▄█  █  █                            ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                            █  █▄█    ▀▀█▄▄ █ ▄▄█▀▀    █▄█  █                                       █  █▄█    ▀▀█▄▄ █ ▄▄█▀▀    █▄█  █                            ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                 █▄█▄▄▄▄▄▄▄▄▄▄▄█████▄▄▄▄▄▄▄▄▄▄▄█▄█                                       █▄█▄▄▄▄▄▄▄▄▄▄▄█████▄▄▄▄▄▄▄▄▄▄▄█▄█                                 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                 █                             █                                         █                             █                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                █    ▄▄▄▄▄       ▄▄▄▄▄▄▄▄     █                                         █    ▄▄▄▄▄       ▄▄▄▄▄▄▄▄     █                                ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                              █   █     █     █ █    █ █    █                                         █   █     █     █ █    █ █    █                              ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                             █   █   ▀ █      ▀▀▀▀▀▀▀▀     █                                         █   █   ▀ █      ▀▀▀▀▀▀▀▀     █                             ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                             █▄▄▄█▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█                                         █▄▄▄█▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█                             ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                                                                                                                                       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                                                                                                                                 ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀█▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█"
        };
        #endregion

        #region Home Town My House

        public static string[] playerHouse = new string[]
        {
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                           █▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█        █▀██▀█▀█▀█▀█▀█▀█▀█▀█▀█                                           ",
            @"                                           █ █ █ █ █ █ █▀▀█▀▀█ █ █ █ █        █ █▀██ █ █ █ █ █ █ █ █                                           ",
            @"                                           █ █ █ █ █ █ █▄▄█▄▄█ █ █ █ █        █ █ █▀██ █ █ █ █ █ █ █                                           ",
            @"                                           █▄█▄█▄█▄█▄█ █ █ █ █ █████ █        █▀█ █ █▀██ █ █ █ █ █ █                                           ",
            @"                                           ██___||+_+█▄█▄█▄█▄█▄██  █▄█        █  ▀█ █ █▀██▄█▄█▄█▄█▄█                                           ",
            @"                                           ██▀▀▀██▀▀▀█          ████ █        █    ▀█ █ █          █                                           ",
            @"                                           ██___██___█          ████ █▄▄▄▄▄▄▄▄█      ▀█ █          █                                           ",
            @"                                           █                         █        █▄▄▄▄▄▄▄▄██          █                                           ",
            @"                                           █__________               █ █▀▀▀▀█ █                    █                                           ",
            @"                                           █ ▀▀▀▀▀▀▀ █               █ █▀▀▀▀█ █                    █                                           ",
            @"                                           █▀▀▀▀▀▀▀▀█▀               ███▄▄▄▄███                    █                                           ",
            @"                                           █________█                █___██___█                    █                                           ",
            @"                                           █                                                       █                                           ",
            @"                                           █                                                       █                                           ",
            @"                                           █                                                       █                                           ",
            @"                                           █  _  ▄▄▄▄ █▀▀▀▀▀▀▀▀█                    ▄▄ ██      _   █                                           ",
            @"                                           █ +|* █▄▄█ █        █                    █  ██     +|*  █                                           ",
            @"                                           █ *█+ ▀  ▀ █▄▄▄▄▄▄▄▄█          ▄██████████▄▄██     *█+  █                                           ",
            @"                                           █ ▄▄█▄      █      █           █▄▄▄▄▄▄▄▄▄▄▄▄▄█     ▄▄█▄ █                                           ",
            @"                                           █ █▄▄█                                             █▄▄█ █                                           ",
            @"                                           █  ▀▀                                               ▀▀  █                                           ",
            @"                                            ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀     ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀                                            ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                            ▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄                                            ",
            @"                                            ▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀                                            ",
            @"                                            ▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀                                            "
        };

        #endregion

        #region Home Town My Room

        public static string[] playerRoom = new string[]
{
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                    ▄▄▄▄▄▄▄                                                                    ",
            @"                                                               ▄▄▄▄▄█     █▄▄▄▄▄                                                               ",
            @"                                                          ▄▄▄▄▄█               █▄▄▄▄▄                                                          ",
            @"                                                     ▄▄▄▄▄█        ▄▄▄▄▄▄▄▄▄        █▄▄▄▄▄                                                     ",
            @"                                                ▄▄▄▄▄█             █▀▀▀█▀▀▀█             █▄▄▄▄▄                                                ",
            @"                                           ▄▄▄▄▄█                  █▄▄▄█▄▄▄█                  █▄▄▄▄▄                                           ",
            @"                                           █                       █   █   █                       █                                           ",
            @"                                           █                 ▄▄▄▄▄▄▀▀▀▀▀▀▀▀▀                       █                                           ",
            @"                                           █ ▄▄▄▄▄▄▄▄▄ ███  █▀▀▀▀▀▀█  ███                          █                                           ",
            @"                                           █_█▄▄▄▄▄▄▄█_█o█_██▄▄▄▄▄▄██_█o█_______________▄▄▄▄▄▄▄▄▄▄_█                                           ",
            @"                                           █  █     █  █O█ █___██___█ █O█               █▄▄▄     █ █                                           ",
            @"                                           █     █▀▀█  ▀▀▀            ▀▀▀               █  █▄▄▄  █ █                                           ",
            @"                                           █     █▀▀█                                   █▄▄█▄▄█▄▄█ █                                           ",
            @"                                           █                                                       █                                           ",
            @"                                           █                                                       █                                           ",
            @"                                           █           |||||||||||||||||||                         █                                           ",
            @"                                           █  _        █       ▄▄▄       █         ▄     ▄         █                                           ",
            @"                                           █ +|*       █      ▀ ▄ ▀      █         █▀███▀█         █                                           ",
            @"                                           █ *█+       █      ▀▄▄▄▀      █         █▄▀▀▀▀█         █                                           ",
            @"                                           █ ▄▄█▄      █                 █         █     █         █                                           ",
            @"                                           █ █▄▄█      |||||||||||||||||||         █▀▀▀▀▀█         █                                           ",
            @"                                           █  ▀▀                                                   █                                           ",
            @"                                            ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀                                            ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                            ▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄                                            ",
            @"                                            ▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀                                            ",
            @"                                            ▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀                                            "
};


        #endregion

        #region Home Town Rival House

        public static string[] rivalHouse = new string[]
        {
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                           █▀█▀█▀█▀█▀█▀█▀█▀█▀██▀█        █▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█                                           ",
            @"                                           █ █ █ █ █ █ █ █ ██▀█ █        █ █ █ █ █▀▀█▀▀█ █ █ █ █ █ █                                           ",
            @"                                           █ █ █ █ █ █ █ ██▀█ █ █        █ █ █ █ █▄▄█▄▄█ █ █ █ █ █ █                                           ",
            @"                                           █ █ █ █ █ █ ██▀█ █ █▀█        █ █████ █ █ █ █ █▄█▄█▄█▄█▄█                                           ",
            @"                                           █▄█▄█▄█▄█▄██▀█ █ █▀  █        █▄█  ██▄█▄█▄█▄█▄█___||+_+██                                           ",
            @"                                           █          █ █ █▀    █        █ ████          █▀▀▀██▀▀▀██                                           ",
            @"                                           █          █ █▀      █▄▄▄▄▄▄▄▄█ ████          █___██___██                                           ",
            @"                                           █          ██▄▄▄▄▄▄▄▄█        █                         █                                           ",
            @"                                           █                    █ █▀▀▀▀█ █               __________█                                           ",
            @"                                           █                    █ █▀▀▀▀█ █               █ ▀▀▀▀▀▀▀ █                                           ",
            @"                                           █                    ███▄▄▄▄███               ▀█▀▀▀▀▀▀▀▀█                                           ",
            @"                                           █                    █___██___█                █________█                                           ",
            @"                                           █                                                       █                                           ",
            @"                                           █                                                       █                                           ",
            @"                                           █                                                       █                                           ",
            @"                                           █  _       ██ ▄▄                    █▀▀▀▀▀▀▀▀█ ▄▄▄▄ _   █                                           ",
            @"                                           █ +|*      ██  █                    █        █ █▄▄█+|*  █                                           ",
            @"                                           █ *█+      ██▄▄██████████▄          █▄▄▄▄▄▄▄▄█ ▀  ▀*█+  █                                           ",
            @"                                           █ ▄▄█▄     █▄▄▄▄▄▄▄▄▄▄▄▄▄█           █      █      ▄▄█▄ █                                           ",
            @"                                           █ █▄▄█                                             █▄▄█ █                                           ",
            @"                                           █  ▀▀                                               ▀▀  █                                           ",
            @"                                            ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀     ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀                                            ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                            ▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄                                            ",
            @"                                            ▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀                                            ",
            @"                                            ▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀                                            "
        };

        #endregion

        #region Home Town Rival Room

        public static string[] rivalRoom = new string[]
{
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                    ▄▄▄▄▄▄▄                                                                    ",
            @"                                                               ▄▄▄▄▄█     █▄▄▄▄▄                                                               ",
            @"                                                          ▄▄▄▄▄█               █▄▄▄▄▄                                                          ",
            @"                                                     ▄▄▄▄▄█        ▄▄▄▄▄▄▄▄▄        █▄▄▄▄▄                                                     ",
            @"                                                ▄▄▄▄▄█             █▀▀▀█▀▀▀█             █▄▄▄▄▄                                                ",
            @"                                           ▄▄▄▄▄█                  █▄▄▄█▄▄▄█                  █▄▄▄▄▄                                           ",
            @"                                           █                       █   █   █                       █                                           ",
            @"                                           █                       ▀▀▀▀▀▀▀▀▀▄▄▄▄▄▄                 █                                           ",
            @"                                           █                          ███  █▀▀▀▀▀▀█  ███ ▄▄▄▄▄▄▄▄▄ █                                           ",
            @"                                           █_▄▄▄▄▄▄▄▄▄▄_______________█o█_██▄▄▄▄▄▄██_█o█_█▄▄▄▄▄▄▄█_█                                           ",
            @"                                           █ █     ▄▄▄█               █O█ █___██___█ █O█  █     █  █                                           ",
            @"                                           █ █  ▄▄▄█  █               ▀▀▀            ▀▀▀  █▀▀█     █                                           ",
            @"                                           █ █▄▄█▄▄█▄▄█                                   █▀▀█     █                                           ",
            @"                                           █                                                       █                                           ",
            @"                                           █                                                       █                                           ",
            @"                                           █                         |||||||||||||||||||           █                                           ",
            @"                                           █         ▄     ▄         █       ▄▄▄       █       _   █                                           ",
            @"                                           █         █▀███▀█         █      ▀ ▄ ▀      █      +|*  █                                           ",
            @"                                           █         █▄▀▀▀▀█         █      ▀▄▄▄▀      █      *█+  █                                           ",
            @"                                           █         █     █         █                 █      ▄▄█▄ █                                           ",
            @"                                           █         █▀▀▀▀▀█         |||||||||||||||||||      █▄▄█ █                                           ",
            @"                                           █                                                   ▀▀  █                                           ",
            @"                                            ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀                                            ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                            ▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄                                            ",
            @"                                            ▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀                                            ",
            @"                                            ▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀                                            "
};

        #endregion

        #region Poke Center

        public static string[] pokeCenter = new string[]
{
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                           █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█                                           ",
            @"                                           █                        █▀█▀▀▀▀█                       █                                           ",
            @"                                           █                        █▀  ▄▀ █                       █                                           ",
            @"                                           █               ███▄▀▀▀▄ █▄▄▄▄▄▄█     ███ ▄▄▄▄█▀▀▀█▄▄▄▄ █                                           ",
            @"                                           █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄███     █▄▄▄▄▄▄▄▄▄▄▄▄▄███▄█  ▄▀▀▀▀▀▄  █▄█                                           ",
            @"                                           █               ███▄▀▀▀▄█             ███ █▄▄█     █▄▄█ █                                           ",
            @"                                           █               ███▄▄█▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄███ █           █ █                                           ",
            @"                                           █               █████████████████████████               █                                           ",
            @"                                           █                █                     █                █                                           ",
            @"                                           █                ███████████████████████                █                                           ",
            @"                                           █                                                       █                                           ",
            @"                                           █                      ▄▄▄▀▀▀▀▀▀▄▄▄                     █                                           ",
            @"                                           █                   ▄▀▀ ▄▄▄▀▀▀▀▄▄▄ ▀▀▄                  █                                           ",
            @"                                           █                  █  ▄▀   ▄▄▄▄   ▀▄  █                 █                                           ",
            @"                                           █                         ██████                        █                                           ",
            @"                                           █                  ████▄   ▀▀▀▀   ▄████                 █                                           ",
            @"                                           █                   ▀██████▄▄▄▄██████▀                  █                                           ",
            @"                                           █                      ▀▀▀██████▀▀▀                     █                                           ",
            @"                                           █                                                       █                                           ",
            @"                                           █                                                       █                                           ",
            @"                                           █                                                       █                                           ",
            @"                                            ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀     ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀                                            ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                            ▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄                                            ",
            @"                                            ▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀                                            ",
            @"                                            ▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀                                            "
};

        #endregion

        #region Poke Mart

        public static string[] pokeMart = new string[]
{
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                           █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█                                           ",
            @"                                           █                                                       █                                           ",
            @"                                           █                                                       █                                           ",
            @"                                           █                 ███                                   █                                           ",
            @"                                           █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄███▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄██▄▄▄▄▄▄▄▄▄▄▄▄▄██                                           ",
            @"                                           █                 ███                ▄█ ██ █▄       ▄█ ██                                           ",
            @"                                           █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄███               █ █▄██▄█ █     █ █▄██                                           ",
            @"                                           █████████████████████               █▄▀ ██ ▀▄█     █▄▀ ██                                           ",
            @"                                           █                  █                █   ██   █     █   ██                                           ",
            @"                                           ████████████████████                █▄▄▄██▄▄▄█     █▄▄▄██                                           ",
            @"                                           █                                                       █                                           ",
            @"                                           █                                                       █                                           ",
            @"                                           █                                      ▄██▄           ▄██                                           ",
            @"                                           █                                    ▄█ ██ █▄       ▄█ ██                                           ",
            @"                                           █                                   █ █▄██▄█ █     █ █▄██                                           ",
            @"                                           █                                   █▄▀ ██ ▀▄█     █▄▀ ██                                           ",
            @"                                           █                                   █   ██   █     █   ██                                           ",
            @"                                           █                                   █▄▄▄██▄▄▄█     █▄▄▄██                                           ",
            @"                                           █                                                       █                                           ",
            @"                                           █                                                       █                                           ",
            @"                                           █                                                       █                                           ",
            @"                                            ▀▀▀▀▀▀▀▀▀▀     ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀                                            ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                                                                                                                               ",
            @"                                            ▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄▄███▄                                            ",
            @"                                            ▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀                                            ",
            @"                                            ▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀▀▄█▄▀                                            "
};


        #endregion

        #endregion

        #endregion

        #region ASCII: Art Templates

        #region Display Screen Objects

        #region GameBoy

        public static string TEMGameBoy = @"█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█
█  ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  █                                                                                   █  █
█  ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  █
█                                                                                         █
█                                                                                         █
█                 _▄▄▄▄▄_                                                                 █
█                ▄▀▄ ▄ ▄▀▄                                                                █
█                █ ▀▄▀▄▀ █                                                                █
█                 ▀▄▄▄▄▄▀                                              _▄▄▄▄▄_            █
█       _▄▄▄▄▄_             _▄▄▄▄▄_                                   ▄▀ ▄▀▄ ▀▄           █
█      ▄▀ ▄▀▄ ▀▄           ▄▀ █▀▄ ▀▄                                  █  ▀▄▀  █           █
█      █  █▀█  █           █  █▄▀  █                                   ▀▄▄▄▄▄▀            █
█       ▀▄▄▄▄▄▀             ▀▄▄▄▄▄▀                            _▄▄▄▄▄_                    █
█                 _▄▄▄▄▄_                                     ▄▀ ▄ ▄ ▀▄                   █
█                ▄▀ ▄█▀ ▀▄                                    █  █▀▄  █                   █
█                █  ▄█▀  █                                     ▀▄▄▄▄▄▀                    █
█                 ▀▄▄▄▄▄▀        _▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄_                               █
█                               ▄▀ ▄   ▄ ▄▄▄▄ ▄   ▄ ▄   ▄ ▀▄                              █
█                               █  █▀▄▀█ █▄   █▀▄ █ █   █  █                              █
█                               █  █   █ █▄▄▄ █  ▀█ ▀▄▄▄▀  █                              █
█                                ▀▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▀                               █
█                                                                                         █
█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█";

        #endregion

        #region Game Screen
        public static string TEMGameScreenRefresh = @"
   ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀";

        #endregion

        #region Game Buttons
        public static string TEMGameButtons = @"
█  ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  █
█                                                                                         █
█                                                                                         █
█                _▄▄▄▄▄_                                                                  █
█               ▄▀▄ ▄ ▄▀▄                                                                 █
█               █ ▀▄▀▄▀ █                                                                 █
█                ▀▄▄▄▄▄▀                                              _▄▄▄▄▄_             █
█      _▄▄▄▄▄_             _▄▄▄▄▄_                                   ▄▀ ▄▀▄ ▀▄            █
█     ▄▀ ▄▀▄ ▀▄           ▄▀ █▀▄ ▀▄                                  █  ▀▄▀  █            █
█     █  █▀█  █           █  █▄▀  █                                   ▀▄▄▄▄▄▀             █
█      ▀▄▄▄▄▄▀             ▀▄▄▄▄▄▀                            _▄▄▄▄▄_                     █
█                _▄▄▄▄▄_                                     ▄▀ ▄ ▄ ▀▄                    █
█               ▄▀ ▄█▀ ▀▄                                    █  █▀▄  █                    █
█               █  ▄█▀  █                                     ▀▄▄▄▄▄▀                     █
█                ▀▄▄▄▄▄▀                                                                  █
█                                                                                         █
█                                                                                         █
█                                                                                         █
█                                                                                         █
█                                                                                         █
█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█";

        #endregion

        #region Message Box

        public static string TEMMessageBox = @"
     ▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄
     █                                                                               █
     █                                                                               █
     █                                                                               █
      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ";

        #endregion

        #region Empty Defender

        public static string EmptyDefender = @"
   
   ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ 
   █             ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄                                       █
   █            █                               ▀▄                                     █
   █            █ HP:                             ▀▄                                   █
   █            ▀▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▀                                  █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █";

        #endregion

        #region Empty Attacker

        public static string EmptyAttacker = @"
   █                                                                                   █
   █                                                                                   █
   █                                       ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄             █
   █                                     ▄▀                               █            █
   █                                   ▄▀   HP:                           █            █
   █                                  ▀▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▀            █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █";

        #endregion

        #region Ball Idle

        public static string BallIdle = $@"
   █                                                                          
   █                                                                          
   █                                                             ▄▄▄        
   █                                                           ▄███▄█▄      
   █                                                           ▀▄ ▀ ▄▀      
   █                                                             ▀▀▀        ";

        #endregion

        #region Ball Player Switch

        public static string[] pokeBall = new string[]
        {
            @" ▄█▀▀▀█▄ ",
            @"█▄▄▄o▄▄▄█",
            @" ▀█▄▄▄█▀ "
        };

        #endregion

        #region PokeCatcher

        public static string[] pokeCatcher = new string[] {
        @"                                                                                                                                                                                  ",
        @"                                                                                                                                                                                  ",
        @"                                                                                                                                                                                  ",
        @"                                                                                      ▄█▀▀▀█▄                                                                                     ",
        @"                                                                                     █▄▄▄o▄▄▄█                                                                                    ",
        @"                                                                                      ▀█▄▄▄█▀                                                                                     ",
        @"                                                                                                                                                                                  ",
        @"                                                                                                                                                                                  "};

        #endregion

        #endregion

        #region Display Map Ojects

        public static string TreeTopFiller = @"

    ▄
  ▄▀█▀▄
 ▄▀█▀█▀▄                    ─▄████▄▄          ░
▄▀█▀█▀█▀▄          ▐  └─┐░░ ▄▀█▀▐└─┐░░ ▄▀█▀▐└─┐░░ ▄▀█▀▐└─┐░░
▀█▀█▀█▀█▀
    █  
";

        public static string RowOfTrees16 = @"
    ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄
  ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄
 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ 
▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄
▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀█▀
    █       █       █       █       █       █       █       █       █       █       █       █       █       █       █       █  ";

        public static string RowOfTreesTOP16 = @"
▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       
█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀
▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█
█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀
  ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄ 
 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄
 ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀

█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀
▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█
█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀
  ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄ 
 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄
▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▀█▀█▀█▀ ";

        #region HOME

        public static string Home = @"              









   ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄                                                       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄   
 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄ 
▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄
▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                 ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀
▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀
█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█
▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀
 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄ 
▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄
▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                 ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀
▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀
█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█
▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀
 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄ 
▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄
▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                 ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀
▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀
█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█
▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀
 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄ 
▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄
▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                 ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀
▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀
█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█
▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀
 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄ 
▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄
▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀                                                 ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀ ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀
▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀
█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█
▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                                                                                                                                       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀
 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄ 
▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄
▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                                                                                                                                 ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀
▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                ▄▄▄                                                                     ▄▄▄                                                ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀
█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                            ▄▄▄█ █▄▄▄                                                               ▄▄▄█ █▄▄▄                                            ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█
▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                        ▄▄▄█  █ █  █▄▄▄                                                         ▄▄▄█  █ █  █▄▄▄                                        ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀
 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                   ▄▄▄█  █  █ █  █  █▄▄▄                                                   ▄▄▄█  █  █ █  █  █▄▄▄                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄ 
▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                               ▄▄▄█  █  █  █ █  █  █  █▄▄▄                                             ▄▄▄█  █  █  █ █  █  █  █▄▄▄                               ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄
▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                            ▄▄▄█  █  █  █  █▄█  █  █  █  █▄▄▄                                       ▄▄▄█  █  █  █  █▄█  █  █  █  █▄▄▄                            ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀
▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                 █  █  █  █  █▄█ █ █▄█  █  █  █  █                                       █  █  █  █  █▄█ █ █▄█  █  █  █  █                                 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀
█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                █  █  █  █▄█    █    █▄█  █  █  █                                       █  █  █  █▄█    █    █▄█  █  █  █                                ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█
▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                               █  █  █▄██▄     █     ▄██▄█  █  █                                       █  █  █▄██▄     █     ▄██▄█  █  █                               ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀
 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                             █  █▄█    ▀▀█▄▄ █ ▄▄█▀▀    █▄█  █                                       █  █▄█    ▀▀█▄▄ █ ▄▄█▀▀    █▄█  █                             ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄ 
▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                            █▄█▄▄▄▄▄▄▄▄▄▄▄█████▄▄▄▄▄▄▄▄▄▄▄█▄█                                       █▄█▄▄▄▄▄▄▄▄▄▄▄█████▄▄▄▄▄▄▄▄▄▄▄█▄█                            ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄
▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                             █                             █                                         █                             █                             ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀
▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                  █    ▄▄▄▄▄       ▄▄▄▄▄▄▄▄     █                                         █    ▄▄▄▄▄       ▄▄▄▄▄▄▄▄     █                                  ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀
█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                 █   █     █     █ █    █ █    █                                         █   █     █     █ █    █ █    █                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█
▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                █   █   ▀ █      ▀▀▀▀▀▀▀▀     █                                         █   █   ▀ █      ▀▀▀▀▀▀▀▀     █                                ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀
 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                              █▄▄▄█▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█                                         █▄▄▄█▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█                              ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄ 
▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄
▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                                                                                                                                 ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀
▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀
█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█
▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                              ▄▄▄                                                                     ▄▄▄                                              ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀
 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                         ▄▄▄█ █▄▄▄                                                               ▄▄▄█ █▄▄▄                                         ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄ 
▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                     ▄▄▄█  █ █  █▄▄▄                                                         ▄▄▄█  █ █  █▄▄▄                                     ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄
▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                  ▄▄▄█  █  █ █  █  █▄▄▄                                                   ▄▄▄█  █  █ █  █  █▄▄▄                                  ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀
▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                    ▄▄▄█  █  █  █ █  █  █  █▄▄▄                                             ▄▄▄█  █  █  █ █  █  █  █▄▄▄                                    ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀
█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                ▄▄▄█  █  █  █  █▄█  █  █  █  █▄▄▄                                       ▄▄▄█  █  █  █  █▄█  █  █  █  █▄▄▄                                ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█
▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                               █  █  █  █  █▄█ █ █▄█  █  █  █  █                                       █  █  █  █  █▄█ █ █▄█  █  █  █  █                               ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀
 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                             █  █  █  █▄█    █    █▄█  █  █  █                                       █  █  █  █▄█    █    █▄█  █  █  █                             ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄ 
▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                            █  █  █▄██▄     █     ▄██▄█  █  █                                       █  █  █▄██▄     █     ▄██▄█  █  █                            ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄
▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                            █  █▄█    ▀▀█▄▄ █ ▄▄█▀▀    █▄█  █                                       █  █▄█    ▀▀█▄▄ █ ▄▄█▀▀    █▄█  █                            ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀
▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                 █▄█▄▄▄▄▄▄▄▄▄▄▄█████▄▄▄▄▄▄▄▄▄▄▄█▄█                                       █▄█▄▄▄▄▄▄▄▄▄▄▄█████▄▄▄▄▄▄▄▄▄▄▄█▄█                                 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀
█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                 █                             █                                         █                             █                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█
▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                █    ▄▄▄▄▄       ▄▄▄▄▄▄▄▄     █                                         █    ▄▄▄▄▄       ▄▄▄▄▄▄▄▄     █                                ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀
 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                              █   █     █     █ █    █ █    █                                         █   █     █     █ █    █ █    █                              ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄ 
▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                             █   █   ▀ █      ▀▀▀▀▀▀▀▀     █                                         █   █   ▀ █      ▀▀▀▀▀▀▀▀     █                             ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄
▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                             █▄▄▄█▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█                                         █▄▄▄█▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█                             ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀
▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀
█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█
▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                                                                                                                                       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀
 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄ 
▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄
▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                                                                                                                                 ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀
▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀
█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                         ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█
▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀
 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄ 
▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄
▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀
▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀
█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█
▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀
 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄ 
▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄
▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀
▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀
█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█
▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀█▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀
 ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄ 
▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄
▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀
▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀
█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█
▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀";

        #endregion

        #endregion

        #region Display Menu Objects

        #region Player Menu (NEW ASCII)

        public static string TEMPlayerMenu = @"
   ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
   █                                                        ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄  █
   █                                                         █     PokeROLODEX      █  █
   █                                                          █                     █  █
   █      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄                  █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █     ██                                  █                  █  Party            █  █
   █     █ █   (O)  o o o                     █                 █                   █  █
   █      █ █                     ▄▄▄▄▄▄▄▄▄▄▄▄ █                █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █       █ █                   █            █ █               █  BAG              █  █
   █        █ █   ▄▄▄▄▄▄▄▄▄▄▄▄▄▄█              █ █              █                   █  █
   █         █ █ █                              █ █             █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █          █ █ █                              █ █            █                   █  █
   █           █ █ █                              █ █           █                   █  █
   █            █ █ █ █▀▀▄▄                        █ █          █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █             █ █ █ █  ▄▀                        █ █         █  EXIT             █  █
   █              █ █ █ █▀                           █ █        █                   █  █
   █               █ █ █                              █ █       █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █                █ █ █                              █ █                             █
   █                 █ █ █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█ █                            █
   █                  █ █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█                           █
   █                   █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▀                           █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀";

        public static string TEMPlayerMenuParty = @"
   ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
   █                                                            ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄  █
   █                                                            █  PokeROLODEX      █  █
   █                                                            █                   █  █
   █                                                        ▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █                                                         █     PARTY            █  █
   █                         ▄▄▄▄▄▄▄▄                         █                     █  █
   █                    ▄▄▀▀▀        ▀▀▀▄▄                     █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █                 ▄▀▀          ▀███▄   ▀▀▄                   █  BAG              █  █
   █               ▄▀                ▀██▄    ▀▄                 █                   █  █
   █              █                     ▀▄     █                █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █             █       ▄▄▄▄▄                  █               █                   █  █
   █            █▄▄▄▄▄▄▄▀ ▄▄▄ ▀▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█              █                   █  █
   █            █______█ █   █ █_________________█              █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █            ████████▄ ▀▀▀ ▄███████████████████              █  EXIT             █  █
   █             ████████████████████████████████               █                   █  █
   █              ██████████████████████████████                █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █               ▀██████████████████████████▀                                        █
   █                 ▀██████████████████████▀                                          █
   █                    ▀▀██████████████▀▀                                             █
   █                         ▀▀▀▀▀▀▀▀                                                  █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀";

        public static string TEMPlayerMenuBag = @"
   ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
   █                                                            ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄  █
   █                                                            █  PokeROLODEX      █  █
   █                                                            █                   █  █
   █                                                            █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █                                                            █  PARTY            █  █
   █                                                            █                   █  █
   █                                                        ▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █                      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄                     █     BAG              █  █
   █                     █/            \█                     █                     █  █
   █               _____█|______________|█_____                █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █            ▄▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▄              █                   █  █
   █           █|     ▀▄_______▀▄▄▀_______▄▀      █             █                   █  █
   █          █|    ▄▄▄▄▄▄     ▀▄▄▀     ▄▄▄▄▄▄     █            █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █         █|    █__o___█            █___o__█     █           █  EXIT             █  █
   █         █|    █      █            █      █     █           █                   █  █
   █          █|    ▀▄▄▄▄▄█            █▄▄▄▄▄▀     █            █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █           █|                                |█                                    █
   █            ▀▄-____________________________-▄▀                                     █
   █              ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀                                       █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀";

        public static string TEMPlayerMenuProfile = @"
   ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
   █                                                            ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄  █
   █                                                            █  PokeROLODEX      █  █
   █                                                            █                   █  █
   █                                                            █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █                                                            █  PARTY            █  █
   █                                                            █                   █  █
   █                 ▄▀▀▀▀▀▀▄                                   █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █                █ ██████ █                                  █  BAG              █  █
   █               ██▀▄▄▄▄▄▄▀██                                 █                   █  █
   █              █ ▀  ▄  ▄  ▀ █                            ▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █               ██▄ ▀  ▀ ▄██                              █                      █  █
   █              █  ████████  █    ▄▀▀▀▀▀▀▄                  █                     █  █
   █               ▀█▀▄▄▀▀▄▄▀█▀    █ ██████ █                  █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █                ▀▄▄▄▀▀▄▄▄▀    ██▀▄▄▄▄▄▄▀██                  █  EXIT             █  █
   █                             █ ▀  ▄  ▄  ▀ █                 █                   █  █
   █                              ██▄ ▀  ▀ ▄██                  █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █                             █  ████████  █                                        █
   █                              ▀█▀▄▄▀▀▄▄▀█▀                                         █
   █                               ▀▄▄▄▀▀▄▄▄▀                                          █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀";

        public static string TEMPlayerMenuExit = @"
   ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
   █                                                            ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄  █
   █                                                            █  PokeROLODEX      █  █
   █                                                            █                   █  █
   █                                                            █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █                                                            █  PARTY            █  █
   █                                                            █                   █  █
   █                                                            █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █                                                            █  BAG              █  █
   █                                                            █                   █  █
   █                                                            █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █                                                            █                   █  █
   █                                                            █                   █  █
   █                                                        ▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █                                                         █     EXIT             █  █
   █                                                          █                     █  █
   █                                                           █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   █                                                                                   █
   ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀";

        #endregion

        #region PLayer Bag (NEW ASCII)

        #region Item Section

        public static string ItemSection = @"
 _______________________________________________________________________________________
|  ___________________________________________________________________________________  |
| |                                             ____________________________________  | |
| |                                             ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ | |
| |                                             █ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█ | |
| |                                             █ █                                   | |
| |                                             █ █                                   | |
| |                                             █ █                                   | |
| |                                             █ █                                   | |
| |                                             █ █                                   | |
| |                                             █ █                                   | |
| |                                             █ █                                   | |
| |                                             █ █                                   | |
| |                                             █ █                                   | |
| |                                             █ █                                   | |
| | ▄▄▄▄▄▄▄▄▄                                   █ █                                   | |
| | █ ITEMS █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ █ █                                   | |
| | █       | MEDICINE | MOVES | BATTLE ITEMS █ █ █                                   | |
| | █                                         █ █ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█ | |
| | ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ | |
| |  _______________________________________________________________________________  | |
| | |                                                                               | | |
| | |                                                                               | | |
| | |                                                                               | | |
| | |_______________________________________________________________________________| | |
| |___________________________________________________________________________________| |";



        #endregion

        #region Med Section

        public static string MedSection = @"
 _______________________________________________________________________________________
|  ___________________________________________________________________________________  |
| |                                             ____________________________________  | |
| |                                            |  __________________________________| | |
| |                                            | |     Health Potion    x             | |
| |                                            | |                                    | |
| |                   _____                    | |     Full Heal        x             | |
| |                  //   \\                   | |                                    | |
| |              ___||_____||___               | |     Full Revive      x             | |
| |             / ___       ___ \              | |                                    | |
| |            | /___\     /___\ |             | |     HP-Up            x             | |
| |            | |___|     |___| |             | |                                    | |
| |             \_______________/              | |     Attack-Up        x             | |
| |                                            | |                                    | |
| |                                            | |                                    | |
| |          __________                        | |                                    | |
| |  _______| MEDICINE |______________________ | |                                    | |
| | | ITEMS |          | MOVES | BATTLE ITEMS || |__________________________________  | |
| | |                                         ||                                    | | |
| | |_________________________________________||____________________________________| | |
| |  _______________________________________________________________________________  | |
| | |                                                                               | | |
| | |                                                                               | | |
| | |                                                                               | | |
| | |_______________________________________________________________________________| | |
| |___________________________________________________________________________________| |";

        #endregion

        #region Move Section

        public static string MoveSection = @"
 _______________________________________________________________________________________
|  ___________________________________________________________________________________  |
| |                                             ____________________________________  | |
| |                                            |  __________________________________| | |
| |                                            | |     (empty)                        | |
| |                                            | |                                    | |
| |                   _____                    | |                                    | |
| |                  //   \\                   | |                                    | |
| |              ___||_____||___               | |                                    | |
| |             / ___       ___ \              | |                                    | |
| |            | /___\     /___\ |             | |                                    | |
| |            | |___|     |___| |             | |                                    | |
| |             \_______________/              | |                                    | |
| |                                            | |                                    | |
| |                                            | |                                    | |
| |                     _______                | |                                    | |
| |  __________________| MOVES |______________ | |                                    | |
| | | ITEMS | MEDICINE |       | BATTLE ITEMS || |__________________________________  | |
| | |                                         ||                                    | | |
| | |_________________________________________||____________________________________| | |
| |  _______________________________________________________________________________  | |
| | |                                                                               | | |
| | |                                                                               | | |
| | |                                                                               | | |
| | |_______________________________________________________________________________| | |
| |___________________________________________________________________________________| |";

        #endregion

        #region Battle Item Section

        public static string BattleItemSection = @"
 _______________________________________________________________________________________
|  ___________________________________________________________________________________  |
| |                                             ____________________________________  | |
| |                                            |  __________________________________| | |
| |                                            | |     (empty)                        | |
| |                                            | |                                    | |
| |                   _____                    | |                                    | |
| |                  //   \\                   | |                                    | |
| |              ___||_____||___               | |                                    | |
| |             / ___       ___ \              | |                                    | |
| |            | /___\     /___\ |             | |                                    | |
| |            | |___|     |___| |             | |                                    | |
| |             \_______________/              | |                                    | |
| |                                            | |                                    | |
| |                                            | |                                    | |
| |                             ______________ | |                                    | |
| |  __________________________| BATTLE ITEMS || |                                    | |
| | | ITEMS | MEDICINE | MOVES |              || |__________________________________  | |
| | |                                         ||                                    | | |
| | |_________________________________________||____________________________________| | |
| |  _______________________________________________________________________________  | |
| | |                                                                               | | |
| | |                                                                               | | |
| | |                                                                               | | |
| | |_______________________________________________________________________________| | |
| |___________________________________________________________________________________| |";

        #endregion

        #endregion

        #region Player Party (NEW ASCII)

        public static string PlayerParty = @"
                                                                                      
      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄                                         
     █                                 █ 1 █     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄   
     █                                █▄▄▄█     █ 2 █                              █  
     █                                   █     █▄▄▄█                               █  
      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀     █                                    █  
                                             ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀   
      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄                                         
     █                                 █ 3 █     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄   
     █                                █▄▄▄█     █ 4 █                              █  
     █                                   █     █▄▄▄█                               █  
      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀     █                                    █  
                                             ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀   
      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄                                         
     █                                 █ 5 █     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄   
     █                                █▄▄▄█     █ 6 █                              █  
     █                                   █     █▄▄▄█                               █  
      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀     █                                    █  
                                             ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀   
                                                                                      
    ▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄ 
    █                                                                               █ 
    █                                                                               █ 
    █                                                                               █ 
     ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  ";

        #endregion

        #region Fight Menu

        public static string BattleSelectFIGHT = @"
  █ ▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄ █
  █ █                                                 █     [FIGHT]         BAG     █ █
  █ █                                                 █      POKePARTY      RUN     █ █
  █ █                                                 █                             █ █
     ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀   ";

        public static string BattleSelectBAG = @"
  █ ▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄ █
  █ █                                                 █      FIGHT         [BAG]    █ █
  █ █                                                 █      POKePARTY      RUN     █ █
  █ █                                                 █                             █ █
     ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀   ";

        public static string BattleSelectPlayerParty = @"
  █ ▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄ █
  █ █                                                 █      FIGHT          BAG     █ █
  █ █                                                 █     [POKePARTY]     RUN     █ █
  █ █                                                 █                             █ █
     ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀   ";

        public static string BattleSelectRun = @"
  █ ▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄ █
  █ █                                                 █      FIGHT          BAG     █ █
  █ █                                                 █      POKePARTY     [RUN]    █ █
  █ █                                                 █                             █ █
     ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀   ";

        #endregion

        #region Choose Fight Move Menu (NEW ASCII)

        public static string Move1 = @"
  █ ▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄ █
  █ █  -->                                            █  PP                         █ █
  █ █                                                 █  TYPE:                      █ █
  █ █                                                 █                             █ █
     ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀   ";

        public static string Move2 = @"
  █ ▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄ █
  █ █                          -->                    █  PP                         █ █
  █ █                                                 █  TYPE:                      █ █
  █ █                                                 █                             █ █
     ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀   ";

        public static string Move3 = @"
  █ ▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄ █
  █ █                                                 █  PP                         █ █
  █ █  -->                                            █  TYPE:                      █ █
  █ █                                                 █                             █ █
     ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀   ";

        public static string Move4 = @"
  █ ▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄ █
  █ █                                                 █  PP                         █ █
  █ █                          -->                    █  TYPE:                      █ █
  █ █                                                 █                             █ █
     ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀   ";

        #endregion

        #endregion

        #region Player Profile Objects

        public static string[] npcDefender = new string[] {
        @"                                                                                                                                                                                  ",
        @"                                                                                                                                                                                  ",
        @"                                                                                   ▄▄███▄                                                                                         ",
        @"                                                                                    ▀▄█▄▀                                                                                         ",
        @"                                                                                    ▀▄█▄▀                                                                                         ",
        @"                                                                                     ▀ ▀                                                                                          "};

        public static string[] npcProfile = new string[] {
        @"                 ",
        @"                 ",
        @"  ▄▄███▄         ",
        @"   ▀▄█▄▀         ",
        @"   ▀▄█▄▀         ",
        @"    ▀ ▀          "
        };

        public static string[] npcAttacker = new string[] {
        @"    |\_/\__      ",
        @"   _/oYo \/_     ",
        @"  (_y__-  \/_    ",
        @"    |      \/    ",
        @"   _|||_(   \_   ",
        @"  (_(_|(____|/   "
        };

        #endregion

        #region Display Monster Objects

        #region Pyra

        public static string[] pyraDefender = new string[] {
        @"                                                                                   ▄   ▄     ▄                                                                                    ",
        @"                                                                                   █▀▄▄▀▄     █                                                                                   ",
        @"                                                                                 ▄▄▀     ▀▀▄▀▀▄                                                                                   ",
        @"                                                                                 ▀▄▄▄▄▀        █                                                                                  ",
        @"                                                                                     █     ▄█ █                                                                                   ",
        @"                                                                                     █ █ ▄▀  █ █                                                                                  ",
        @"                                                                                   ▄▀ ▄▀ █  ▀ ▀                                                                                   ",
        @"                                                                                  █▄ █▄ █                                                                                         "};

        public static string[] pyraPokedex = new string[] {
        @"   ▄   ▄     ▄    ",
        @"   █▀▄▄▀▄     █   ",
        @" ▄▄▀     ▀▀▄▀▀▄   ",
        @" ▀▄▄▄▄▀        █  ",
        @"     █     ▄█ █   ",
        @"     █ █ ▄▀  █ █  ",
        @"   ▄▀ ▄▀ █  ▀ ▀   ",
        @"  █▄ █▄ █         "
        };

        public static string[] pyraAttacker = new string[] {
        @"                       ",
        @"               ▄   ▄   ",
        @"             ▄▀█▄▄█▀   ",
        @"           █▀      ▀▄  ",
        @"         ██          ▀█",
        @"        ██         ▄▄▄▀",
        @"       ██  ▄      █    ",
        @"      ██  ▄  ▄    █    "
        };

        #endregion

        #region Dousey

        public static string[] douseyDefender = new string[] {
        @"                                                                                                                                                                                  ",
        @"                                                                                                                                                                                  ",
        @"                                                                                    ▄▄▄▀▀▄                                                                                        ",
        @"                                                                                      ▀█  █▄                                                                                      ",
        @"                                                                                     ▄▀█   █▀▄                                                                                    ",
        @"                                                                                    █ ▄█   █▄ █                                                                                   ",
        @"                                                                                    █▀ █   █ ▀█                                                                                   ",
        @"                                                                                      ▄▀▄▄▀▄▄_                                                                                    "};

        public static string[] douseyPokedex = new string[] {
        @"                  ",
        @"                  ",
        @"    ▄▄▄▀▀▄        ",
        @"      ▀█  █▄      ",
        @"     ▄▀█   █▀▄    ",
        @"    █ ▄█   █▄ █   ",
        @"    █▀ █   █ ▀█   ",
        @"      ▄▀▄▄▀▄▄_    "
        };

        public static string[] douseyAttacker = new string[] {
        @"                       ",
        @"             ▄▄▄▄_     ",
        @"           ▄▀   ▀▄▀    ",
        @"          █      █     ",
        @"        ▄█     ▄▀█▄    ",
        @"      ▄███     ▄▀███▄  ",
        @"     ██▀█      ▄▀█ ▀██ ",
        @"     ▀  █        █   ▀█"
        };

        #endregion

        #region Electra

        public static string[] electraDefender = new string[] {
        @"                                                                                                                                                                                  ",
        @"                                                                                        ▄█                                                                                        ",
        @"                                                                                      ▄▀ █                                                                                        ",
        @"                                                                                     █0 0 █▄                                                                                      ",
        @"                                                                                  ▄▄█ ▀██▀ █▄▄                                                                                    ",
        @"                                                                                ▀▀█▄▄      ▄▄█▀▀                                                                                  ",
        @"                                                                                ▄▀▀          ▀▀▄                                                                                  ",
        @"                                                                                                                                                                                  "};

        public static string[] electraPokedex = new string[] {
        @"                 ",
        @"        ▄█       ",
        @"      ▄▀ █       ",
        @"     █0 0 █▄     ",
        @"  ▄▄█ ▀██▀ █▄▄   ",
        @"▀▀█▄▄      ▄▄█▀▀ ",
        @"▄▀▀          ▀▀▄ ",
        @"                 "
        };

        public static string[] electraAttacker = new string[] {
        @"                       ",
        @"                       ",
        @"         █▀▄           ",
        @"         █  ▀▄         ",
        @"        █     █        ",
        @"   ▄▄▄█▀ ▀▄▄▄▀ ▀█▄▄▄▄▄ ",
        @"   ▄██▄   ▀▀      ▄█▄ ▀",
        @"                     ▀▀"
        };

        #endregion

        #region Cobblet

        public static string[] cobbletDefender = new string[] {
        @"                                                                                                                                                                                  ",
        @"                                                                                      ▄   ▄                                                                                       ",
        @"                                                                                 ▄▄ ▄▀ ▀▀▀ ▀▄ ▄▄                                                                                  ",
        @"                                                                                █  ██\▀▄ ▄▀/██  █                                                                                 ",
        @"                                                                                █ █▀ ▄     ▄ ▀█ █                                                                                 ",
        @"                                                                                ▀▄ ▄▀ ▀▀▀▀▀ ▀▄ ▄▀                                                                                 ",
        @"                                                                                  ▀           ▀                                                                                   ",
        @"                                                                                  ▀███████████▀                                                                                   "};

        public static string[] cobbletPokedex = new string[] {
        @"                 ",
        @"      ▄   ▄      ",
        @" ▄▄ ▄▀ ▀▀▀ ▀▄ ▄▄ ",
        @"█  ██\▀▄ ▄▀/██  █",
        @"█ █▀ ▄     ▄ ▀█ █",
        @"▀▄ ▄▀ ▀▀▀▀▀ ▀▄ ▄▀",
        @"  ▀           ▀  ",
        @"  ▀███████████▀  "
        };

        public static string[] cobbletAttacker = new string[] {
        @"                       ",
        @"           ▄   ▄       ",
        @"     ▄▀█▄▀▀▀▀▀▀█    ▄▄ ",
        @"     █  █\█  ▄▀/█  █  █",
        @"      █  ▄     ▄ ▀▄█ █ ",
        @"       █▀ ▀▀▀▀▀ ▀▄ ▄▀  ",
        @"                  ▀    ",
        @"                       "
        };

        #endregion

        #region Neo

        public static string[] neoDefender = new string[] {
        @"                                                                                   █▀▀▄█▀▀▀█▄▀▀█                                                                                  ",
        @"                                                                                   █           █                                                                                  ",
        @"                                                                                   ▄▀         ▀▄                                                                                  ",
        @"                                                                                   █ ▀▀▄   ▄▀▀ █                                                                                  ",
        @"                                                                                   ▄▀▀▄▄   ▄▄▀▀▄                                                                                  ",
        @"                                                                                   ▀▄▄▀ ▀▀▀ ▀▄▄▀                                                                                  ",
        @"                                                                                  █▀  █  █  █  ▀█                                                                                 ",
        @"                                                                                   ▀▀▄▄▀▀▀▀▀▄▄▀▀                                                                                  "};

        public static string[] neoPokedex = new string[] {
        @"   █▀▀▄█▀▀▀█▄▀▀█ ",
        @"   █           █ ",
        @"   ▄▀         ▀▄ ",
        @"   █ ▀▀▄   ▄▀▀ █ ",
        @"   ▄▀▀▄▄   ▄▄▀▀▄ ",
        @"   ▀▄▄▀ ▀▀▀ ▀▄▄▀ ",
        @"  █▀  █  █  █  ▀█",
        @"   ▀▀▄▄▀▀▀▀▀▄▄▀▀ "
        };

        public static string[] neoAttacker = new string[] {
        @"       ▄           ▄         ",
        @"       █▀▄▄▀▀▀▀▄▄▀██         ",
        @"      █            █         ",
        @"     █              █        ",
        @"     ▄▀▄  ▄▄▄▄▄  ▄▀▄▀ ▄ ▄    ",
        @"     █  █▀     ▀█   █▄▀▀█▄   ",
        @"    █ █▄█        █▄▄▀ ▄▀     ",
        @"    ▀▄ █         █ ▀▄▀       "
        };

        #endregion

        #endregion

        #endregion   
    }
}
