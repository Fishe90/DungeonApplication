using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses
{
    public class ASCII
    {
        /****FOR EACH NEW METHOD() ADD Console.SetCursorPosition(90, 46); TO THE END TO REMOVE THE (PRESS ANY KEY TO CONTINUE)****/

        #region METHODS: Screen Control

        public static void GameBoy(ConsoleColor GBColor)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = GBColor;
            Console.Write(TEMGameBoy);
        }

        /****ERASES THE CURRENT SCREEN DISPLAY****/
        public static void ResetScreen(ConsoleColor GBText, ConsoleColor GBBackground)
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
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
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

        /****DISPLAYS A STATIC SCREEN (FE: PLAYER MENU, EMPTY MENU SECTION)****/
        public static void StaticScreen(string[] ScreenDisplay, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
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
        public static void MovementScreen(string[] ScreenDisplay, int currentPosX, int currentPosY, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
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
        public static void StaticPMScreen(string[] ScreenDisplay, Player player, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
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

        public static void BallFaceLeft(int positionX, int positionY, int delay, ConsoleColor GBBackground)
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
            Console.BackgroundColor = GBBackground;
            Console.Write(pokeBall[0]);
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.BackgroundColor = GBBackground;
            Console.Write(pokeBall[1]);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[2]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = GBBackground;
            Console.Write(pokeBall[3]);
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(pokeBall[4]);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[5]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(pokeBall[6]);
            Console.BackgroundColor = GBBackground;
            Console.Write(pokeBall[7]);
            Console.SetCursorPosition(positionX + 2, positionY + 3);
            Console.BackgroundColor = GBBackground;
            Console.Write(pokeBall[8]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(delay);
        }

        public static void BallFaceRight(int positionX, int positionY, int delay, ConsoleColor GBBackground)
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
            Console.BackgroundColor = GBBackground;
            Console.Write(pokeBall[9]);
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = GBBackground;
            Console.Write(pokeBall[10]);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[11]);
            Console.BackgroundColor = GBBackground;
            Console.Write(pokeBall[12]);
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(pokeBall[13]);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[14]);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(pokeBall[15]);
            Console.BackgroundColor = GBBackground;
            Console.Write(pokeBall[16]);
            Console.SetCursorPosition(positionX + 2, positionY + 3);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = GBBackground;
            Console.Write(pokeBall[17]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(delay);
        }

        public static void PokeBallANI(int positionX, int positionY, int delay, ConsoleColor GBBackground)
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
            Console.BackgroundColor = GBBackground;
            Console.Write(pokeBall[0]);
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.Write(pokeBall[1]);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[2]);
            Console.BackgroundColor = GBBackground;
            Console.Write(pokeBall[3]);
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = GBBackground;
            Console.Write(pokeBall[4]);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[5]);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(pokeBall[6]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[7]);
            Console.BackgroundColor = GBBackground;
            Console.Write(pokeBall[8]);
            Console.SetCursorPosition(positionX + 2, positionY + 3);
            Console.BackgroundColor = GBBackground;
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

        public static void PokeBallStatic(int positionX, int positionY, ConsoleColor GBBackground)
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
            Console.BackgroundColor = GBBackground;
            Console.Write(pokeBall[0]);
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.Write(pokeBall[1]);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[2]);
            Console.BackgroundColor = GBBackground;
            Console.Write(pokeBall[3]);
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = GBBackground;
            Console.Write(pokeBall[4]);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[5]);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(pokeBall[6]);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(pokeBall[7]);
            Console.BackgroundColor = GBBackground;
            Console.Write(pokeBall[8]);
            Console.SetCursorPosition(positionX + 2, positionY + 3);
            Console.BackgroundColor = GBBackground;
            Console.Write(pokeBall[9]);
            Console.SetCursorPosition(90, 46);
        }

        public static void BallOpenClose(int positionX, int positionY, int delay, ConsoleColor GBBackground)
        {
            string[] frameONE = new string[]
            {
                @"                   ",
                @"         ▄         ",
                @"      ▀▄ ▀ ▄▀      ",
                @"     ▀▀     ▄▄     ",
                @"      ▄▀ ▄ ▀▄      ",
                @"         ▀         "
            };
            string[] frameTWO = new string[]
            {
                @"                   ",
                @"    ▄    ▄    ▄    ",
                @"     ▀   ▀   ▀     ",
                @"   ▄▄         ▄▄   ",
                @"                   ",
                @"    ▄▀   █   ▀▄    "
            };
            string[] frameTHREE = new string[]
            {
                @"         ▄         ",
                @"   ▀     ▄     ▀   ",
                @"     ▀       ▀     ",
                @" ▄ ▄           ▄ ▄ ",
                @"                   ",
                @"     ▄       ▄     "
            };
            string[] frameFOUR = new string[]
{
                @"         ▄         ",
                @"     ▄   ▄   ▄     ",
                @"    ▀         ▀    ",
                @" ▄ ▄           ▄ ▄ ",
                @"                   ",
                @"    ▀▄       ▄▀    "
};
            string[] frameFIVE = new string[]
{
                @"                   ",
                @"         ▄         ",
                @"       ▄   ▄       ",
                @"    ▄ ▀     ▀ ▄    ",
                @"      ▀▄   ▄▀      ",
                @"                   "
};
            string[] frameSIX = new string[]
{
                @"                   ",
                @"                   ",
                @"       ▄▀▀▀▄       ",
                @"      █     █      ",
                @"       ▀▄▄▄▀       ",
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
            Console.SetCursorPosition(90, 46);

            #endregion
            System.Threading.Thread.Sleep(delay);
        }

        public static void BallBreak(int positionX, int positionY, int delay, ConsoleColor GBBackground)
        {
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

        /****TO BE USED NEXT TO Health BAR DURING COMBAT IF DESIRED****/
        public static void Health(Monster monster, int positionX, int positionY, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
            Console.Write($"([{monster.Health}/{monster.MaxHealth}]");
        }

        public static void Name(Monster monster, int positionX, int positionY, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
            Console.Write(monster.Name.ToUpper());
        }

        public static void Gender(Monster monster, int positionX, int positionY, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
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
            Console.ForegroundColor = GBText;
        }

        public static void NameANDGender(Monster monster, int positionX, int positionY, ConsoleColor GBText, ConsoleColor GBBackground)
        {

            Console.SetCursorPosition(positionX, positionY);
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
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
            Console.ForegroundColor = GBText;
        }

        public static void Level(Monster monster, int positionX, int positionY, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
            Console.SetCursorPosition(positionX, positionY);
            Console.Write($"Lv.{monster.Lv}");
        }

        #endregion        

        #region BATTLE: PvP/PvM Displays

        public static void DISSelectFight(Monster monster, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            string message = $"What will {monster.Name.ToUpper()} do?";
            InstantMessage(message, GBText, GBBackground);
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

        public static void DISSelectBag(Monster monster, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            string message = $"What will {monster.Name.ToUpper()} do?";
            InstantMessage(message, GBText, GBBackground);
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

        public static void DISSelectParty(Monster monster, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            string message = $"What will {monster.Name.ToUpper()} do?";
            InstantMessage(message, GBText, GBBackground);
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

        public static void DISSelectRun(Monster monster, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            string message = $"What will {monster.Name.ToUpper()} do?";
            InstantMessage(message, GBText, GBBackground);
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

        public static void DISDefenderInfoBar(Monster monster, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Console.SetCursorPosition(15, 2);
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
            Console.Write(" ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.SetCursorPosition(15, 3);
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
            Console.Write("█                               ▀▄");
            Console.SetCursorPosition(15, 4);
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
            Console.Write("█                                 ▀▄");
            Console.SetCursorPosition(15, 5);
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
            Console.Write("▀▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▀");
            System.Threading.Thread.Sleep(5);
            NameANDGender(monster, 17, 3, GBText, GBBackground);
            Level(monster, 38, 3, GBText, GBBackground);
            HealthBar(monster, 17, 4);
            Console.SetCursorPosition(90, 46);

        }

        public static void DISAttackerInfoBar(Player player, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Console.SetCursorPosition(37, 13);
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
            Console.Write("     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.SetCursorPosition(37, 14);
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
            Console.Write("   ▄▀                               █");
            Console.SetCursorPosition(37, 15);
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
            Console.Write(" ▄▀                                 █");
            Console.SetCursorPosition(37, 16);
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
            Console.Write("▀▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▀");
            System.Threading.Thread.Sleep(5);
            NameANDGender(player.MonsterEquipped, 43, 14, GBText, GBBackground);
            Level(player.MonsterEquipped, 64, 14, GBText, GBBackground);
            HealthBar(player.MonsterEquipped, 43, 15);
            Console.SetCursorPosition(90, 46);
        }

        public static void DISDefender(Monster monster, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
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
            DISDefenderInfoBar(monster, GBText, GBBackground);
            StaticMessageBox(GBText, GBBackground);
        }

        public static void DISAttacker(Player player, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
            Console.SetCursorPosition(4, 15);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[0]);
            Console.SetCursorPosition(4, 16);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[1]);
            Console.SetCursorPosition(4, 17);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[2]);
            Console.SetCursorPosition(4, 18);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[3]);
            Console.SetCursorPosition(4, 19);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[4]);
            Console.SetCursorPosition(4, 20);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[5]);
            Console.SetCursorPosition(90, 46);
            DISAttackerInfoBar(player, GBText, GBBackground);
            StaticMessageBox(GBText, GBBackground);
        }

        public static void DISNPC(Player npc, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
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
            StaticMessageBox(GBText, GBBackground);
        }

        public static void DISJustDefender(Monster monster, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            ResetScreen(GBText, GBBackground);
            DISDefender(monster, GBText, GBBackground);
        }

        public static void DISJustAttacker(Player player, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            ResetScreen(GBText, GBBackground);
            DISAttacker(player, GBText, GBBackground);
        }

        public static void DISATTandDEF(Player player, Monster monster, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            ResetScreen(GBText, GBBackground);
            DISDefender(monster, GBText, GBBackground);
            DISAttacker(player, GBText, GBBackground);
            StaticMessageBox(GBText, GBBackground);
        }

        #endregion

        #region BATTLE: Animations

        public static void ThrowBall(ConsoleColor GBBackground)
        {
            PokeBallANI(4, 13, 50, GBBackground);
            PokeBallANI(12, 11, 50, GBBackground);
            PokeBallANI(20, 9, 50, GBBackground);
            PokeBallANI(28, 8, 50, GBBackground);
            PokeBallANI(36, 7, 50, GBBackground);
            PokeBallANI(44, 6, 50, GBBackground);
            PokeBallANI(52, 6, 50, GBBackground);
            PokeBallANI(56, 6, 50, GBBackground);
            PokeBallANI(60, 6, 1000, GBBackground);
            BallOpenClose(56, 5, 50, GBBackground);
            PokeBallANI(60, 6, 250, GBBackground);
            PokeBallANI(60, 7, 50, GBBackground);
            PokeBallANI(60, 8, 50, GBBackground);
            PokeBallANI(60, 9, 50, GBBackground);
            PokeBallANI(60, 8, 50, GBBackground);
            PokeBallANI(60, 9, 1500, GBBackground);
        }

        public static void BallShakeLeft(ConsoleColor GBBackground)
        {
            BallFaceLeft(61, 9, 500, GBBackground);
            PokeBallANI(61, 9, 1000, GBBackground);
            Console.SetCursorPosition(90, 46);
        }

        public static void BallShakeRight(ConsoleColor GBBackground)
        {
            BallFaceRight(62, 9, 500, GBBackground);
            PokeBallANI(61, 9, 1000, GBBackground);
            Console.SetCursorPosition(90, 46);
        }

        public static void ANIAttackerSwitch(ConsoleColor GBBackground)
        {           
            PokeBallANI(12, 17, 1500, GBBackground);
            BallBreak(8, 16, 50, GBBackground);
        }

        public static void ANIDefenderSwitch(ConsoleColor GBBackground)
        {
            PokeBallANI(60, 6, 250, GBBackground);
            PokeBallANI(60, 7, 50, GBBackground);
            PokeBallANI(60, 8, 50, GBBackground);
            PokeBallANI(60, 9, 50, GBBackground);
            PokeBallANI(60, 8, 50, GBBackground);
            PokeBallANI(60, 9, 1000, GBBackground);
            BallBreak(56, 8, 50, GBBackground);

        }

        public static void ANIDefenderFaint(Monster monster, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            string message = $"{monster.Name.ToUpper()} fainted!";

            #region Frames
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
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
            ScrollMessage(message, 50, 2000, GBText, GBBackground);
        }

        public static void ANIAttackerFaint(Player player, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            string message = $"{player.MonsterEquipped.Name.ToUpper()} fainted!";

            #region Frames
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
            Console.SetCursorPosition(4, 15);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[0]);
            Console.SetCursorPosition(4, 16);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[1]);
            Console.SetCursorPosition(4, 17);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[2]);
            Console.SetCursorPosition(4, 18);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[3]);
            Console.SetCursorPosition(4, 19);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[4]);
            Console.SetCursorPosition(4, 20);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[5]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

            Console.SetCursorPosition(4, 15);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 16);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[0]);
            Console.SetCursorPosition(4, 17);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[1]);
            Console.SetCursorPosition(4, 18);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[2]);
            Console.SetCursorPosition(4, 19);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[3]);
            Console.SetCursorPosition(4, 20);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[4]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

            Console.SetCursorPosition(4, 15);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 16);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 17);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[0]);
            Console.SetCursorPosition(4, 18);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[1]);
            Console.SetCursorPosition(4, 19);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[2]);
            Console.SetCursorPosition(4, 20);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[3]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

            Console.SetCursorPosition(4, 15);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 16);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 17);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 18);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[0]);
            Console.SetCursorPosition(4, 19);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[1]);
            Console.SetCursorPosition(4, 20);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[2]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

            Console.SetCursorPosition(4, 15);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 16);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 17);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 18);
            Console.Write("                       ");
            Console.SetCursorPosition(4, 19);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[0]);
            Console.SetCursorPosition(4, 20);
            Console.Write(player.MonsterEquipped.ASCIIAttacker[1]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

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
            Console.Write(player.MonsterEquipped.ASCIIAttacker[0]);
            Console.SetCursorPosition(90, 46);

            System.Threading.Thread.Sleep(25);

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
            ScrollMessage(message, 50, 2000, GBText, GBBackground);
        }

        public static void ANIWildAppear(Monster monster, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            string message = $"A wild {monster.Name} appeared!";
            string distance = "                                                                      ";
            int startPositionX = 95;
            foreach (char frame in distance)
            {
                Console.SetCursorPosition(4, 5);
                Console.Write(monster.ASCIIDefender[0].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 6);
                Console.Write(monster.ASCIIDefender[1].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 7);
                Console.Write(monster.ASCIIDefender[2].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 8);
                Console.Write(monster.ASCIIDefender[3].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 9);
                Console.Write(monster.ASCIIDefender[4].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 10);
                Console.Write(monster.ASCIIDefender[5].Substring(startPositionX, 83));
                Console.SetCursorPosition(90, 46);
                startPositionX -= 1;
                System.Threading.Thread.Sleep(1);
            }
            DISDefenderInfoBar(monster, GBText, GBBackground);
            ScrollMessage(message, 50, 2000, GBText, GBBackground);
        }

        public static void ANINPCAppear(Player npc, ConsoleColor GBText, ConsoleColor GBBackground)
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
            ScrollMessage(message, 50, 2000, GBText, GBBackground);
        }

        public static void ANINPCSwitch(Player npc, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            string message = $"{npc.Name} sent out {npc.MonsterEquipped.Name}!";
            ScrollMessage(message, 50, 2000, GBText, GBBackground);
            ANIDefenderSwitch(GBBackground);
            DISDefender(npc.MonsterEquipped, GBText, GBBackground);
        }

        public static void ANIPlayerSwitch(Player player, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            string message = $"{player.Name} sent out {player.MonsterEquipped.Name}!";
            ScrollMessage(message, 50, 1500, GBText, GBBackground);
            ANIAttackerSwitch(GBBackground);
            Console.ForegroundColor = GBText;
            DISAttacker(player, GBText, GBBackground);
            DISAttackerInfoBar(player, GBText, GBBackground);
        }

        public static void ANINPCNext(Player player, Player npc, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            string message1 = $"{npc.Name.ToUpper()} is about to send {npc.MonsterEquipped.Name.ToUpper()}.";
            string message2 = $"Will you send out another Pokefraud?";
            DISJustAttacker(player, GBText, GBBackground);
            System.Threading.Thread.Sleep(2000);
            ScrollMessage(message1, 50, 2000, GBText, GBBackground);
            ScrollMessage(message2, 50, 2000, GBText, GBBackground);
        }

        public static void ANINPCDefeat(Player player, Player npc, int money, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            string message1 = $"{player.Name.ToUpper()} defeated {npc.Name.ToUpper()}!";
            string message2 = $"{npc.Name.ToUpper()} rewarded {player.Name.ToUpper()} ${money}.";
            DISNPC(npc, GBText, GBBackground);
            DISAttacker(player, GBText, GBBackground);
            ScrollMessage(message1, 50, 2000, GBText, GBBackground);
            ScrollMessage(message2, 50, 2000, GBText, GBBackground);
            player.Money += money;
        }

        public static void ANIQuePlayerFight(Player player, Monster monster, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            DISATTandDEF(player, monster, GBText, GBBackground);

        }

        #endregion

        #region BATTLE: Situational Encounters

        public static void WildEncounter(Player player, Monster monster, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            ResetScreen(GBText, GBBackground);
            ANIWildAppear(monster, GBText, GBBackground);
            System.Threading.Thread.Sleep(1500);
            ANIPlayerSwitch(player, GBText, GBBackground);
            System.Threading.Thread.Sleep(1500);
        }

        public static void NPCEncounter(Player player, Player npc, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            ResetScreen(GBText, GBBackground);
            ANINPCAppear(npc, GBText, GBBackground);
            ANINPCSwitch(npc, GBText, GBBackground);
            System.Threading.Thread.Sleep(2000);
            ANIPlayerSwitch(player, GBText, GBBackground);
            System.Threading.Thread.Sleep(2000);
        }

        public static void FullBattleWild(Player player, Monster[] monsters, int lvLow, int lvHigh, ConsoleColor GBText, ConsoleColor GBBackground, ConsoleKey navPlayerMenu)
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

            WildEncounter(player, defender, GBText, GBBackground);

            Player_Menus.BattleFightMenu(player, defender, navPlayerMenu, GBText, GBBackground);
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

        #endregion

        #region ASCII: String[] Templates

        #region Player Menu

        public static string[] PMPokedexSelect = new string[]
            {
               @"                                                        ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄  ",
               @"                                                         █     PokeROLODEX      █  ",
               @"                                                          █                     █  ",
               @"      ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄                  █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"     ██                                  █                  █  Party            █  ",
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
               @"                                                            █  PARTY            █  ",
               @"                                                            █                   █  ",
               @"                 ▄▀▀▀▀▀▀▄                                   █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"                █ ██████ █                                  █  BAG              █  ",
               @"               ██▀▄▄▄▄▄▄▀██                                 █                   █  ",
               @"              █ ▀  ▄  ▄  ▀ █                            ▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"               ██▄ ▀  ▀ ▄██                              █                      █  ",
               @"              █  ████████  █    ▄▀▀▀▀▀▀▄                  █                     █  ",
               @"               ▀█▀▄▄▀▀▄▄▀█▀    █ ██████ █                  █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"                ▀▄▄▄▀▀▄▄▄▀    ██▀▄▄▄▄▄▄▀██                  █  EXIT             █  ",
               @"                             █ ▀  ▄  ▄  ▀ █                 █                   █  ",
               @"                              ██▄ ▀  ▀ ▄██                  █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"                             █  ████████  █                                        ",
               @"                              ▀█▀▄▄▀▀▄▄▀█▀                                         ",
               @"                               ▀▄▄▄▀▀▄▄▄▀                                          ",
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
█                 ▀▄▄▄▄▄▀                                                                 █
█                                                                                         █
█                                                                                         █
█                                                                                         █
█                                                                                         █
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
| |                                            |  __________________________________| | |
| |                                            | |     Poke Catcher     x             | |
| |                                            | |                                    | |
| |                   _____                    | |     Repel            x             | |
| |                  //   \\                   | |                                    | |
| |              ___||_____||___               | |     Blaze Stone      x             | |
| |             / ___       ___ \              | |                                    | |
| |            | /___\     /___\ |             | |     Aqua Stone       x             | |
| |            | |___|     |___| |             | |                                    | |
| |             \_______________/              | |     Power Stone      x             | |
| |                                            | |                                    | |
| |                                            | |     Earth Stone      x             | |
| |  _______                                   | |                                    | |
| | | ITEMS |_________________________________ | |     Mind Stone       x             | |
| | |       | MEDICINE | MOVES | BATTLE ITEMS || |__________________________________  | |
| | |                                         ||                                    | | |
| | |_________________________________________||____________________________________| | |
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
        @"                                                                                      ___                                                                                         ",
        @"                                                                                    _|P__|                                                                                        ",
        @"                                                                                    _|^-^)_                                                                                       ",
        @"                                                                                   |_  Y  _|                                                                                      ",
        @"                                                                                    || _ ||                                                                                       ",
        @"                                                                                     |/ \|                                                                                        "};

        public static string[] npcProfile = new string[] {
        @"     ___         ",
        @"   _|P__|        ",
        @"   _|^-^)_       ",
        @"  |_  Y  _|      ",
        @"   || _ ||       ",
        @"    |/ \|        "
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
        @"                                                                                     |\_/\__                                                                                      ",
        @"                                                                                    _/oYo \/_                                                                                     ",
        @"                                                                                   (_y__-  \/_                                                                                    ",
        @"                                                                                     |      \/                                                                                    ",
        @"                                                                                    _|||_(   \_                                                                                   ",
        @"                                                                                   (_(_|(____|/                                                                                   "};

        public static string[] pyraPokedex = new string[] {
        @"     |\_/\__      ",
        @"    _/oYo \/_     ",
        @"   (_y__-  \/_    ",
        @"     |      \/    ",
        @"    _|||_(   \_   ",
        @"   (_(_|(____|/   "
        };

        public static string[] pyraAttacker = new string[] {
        @"                       ",
        @"              /\_/|    ",
        @"           __/     \_  ",
        @"          _\/      __) ",
        @"         _\/  O   |    ",
        @"         \/  O  O |    "
        };

        #endregion

        #region Dousey

        public static string[] douseyDefender = new string[] {
        @"                                                                                      __                                                                                          ",
        @"                                                                                   -=(o `\                                                                                        ",
        @"                                                                                      '.-.\                                                                                       ",
        @"                                                                                      /|  \\                                                                                      ",
        @"                                                                                      '|  ||                                                                                      ",
        @"                                                                                       _\_):,_                                                                                    "};

        public static string[] douseyPokedex = new string[] {
        @"      __          ",
        @"   -=(o `\        ",
        @"      '.-.\       ",
        @"      /|  \\      ",
        @"      '|  ||      ",
        @"       _\_):,_    "
        };

        public static string[] douseyAttacker = new string[] {
        @"                       ",
        @"              __       ",
        @"            /    \>    ",
        @"           /     |     ",
        @"          /|    /|     ",
        @"          |/    ||     "
        };

        #endregion

        #region Electra

        public static string[] electraDefender = new string[] {
        @"                                                                                     |\_/\__                                                                                      ",
        @"                                                                                    _/oYo \/_                                                                                     ",
        @"                                                                                   (_y__-  \/_                                                                                    ",
        @"                                                                                     |      \/                                                                                    ",
        @"                                                                                    _|||_(   \_                                                                                   ",
        @"                                                                                   (_(_|(____|/                                                                                   "};

        public static string[] electraPokedex = new string[] {
        @"    |\_/\__      ",
        @"   _/oYo \/_     ",
        @"  (_y__-  \/_    ",
        @"    |      \/    ",
        @"   _|||_(   \_   ",
        @"  (_(_|(____|/   "
        };

        public static string[] electraAttacker = new string[] {
        @"    |\_/\__      ",
        @"   _/oYo \/_     ",
        @"  (_y__-  \/_    ",
        @"    |      \/    ",
        @"   _|||_(   \_   ",
        @"  (_(_|(____|/   "
        };

        #endregion

        #region Cobblet

        public static string[] cobbletDefender = new string[] {
        @"                                                                                                                                                                                  ",
        @"                                                                                      _   _                                                                                       ",
        @"                                                                                ___  / \_/ \  ___                                                                                 ",
        @"                                                                                \ / |\_= =_/| \ /                                                                                 ",
        @"                                                                                 \\//\_\_/_/\\//                                                                                  ",
        @"                                                                                  \/         \/                                                                                   "};

        public static string[] cobbletPokedex = new string[] {
        @"                 ",
        @"      _   _      ",
        @"___  / \_/ \  ___",
        @"\ / |\_= =_/| \ /",
        @" \\//\_\_/_/\\// ",
        @"  \/         \/  "
        };

        public static string[] cobbletAttacker = new string[] {
        @"                       ",
        @"          _   _        ",
        @"         / \_/ \   ___ ",
        @"        |\_/ \_/|  \ / ",
        @"        \\_\_/_/\\_//  ",
        @"         \/      \_/   "
        };

        #endregion

        #region Neo

        public static string[] neoDefender = new string[] {
        @"                                                                                     |\_/\__                                                                                      ",
        @"                                                                                    _/oYo \/_                                                                                     ",
        @"                                                                                   (_y__-  \/_                                                                                    ",
        @"                                                                                     |      \/                                                                                    ",
        @"                                                                                    _|||_(   \_                                                                                   ",
        @"                                                                                   (_(_|(____|/                                                                                   "};

        public static string[] neoPokedex = new string[] {
        @"    |\_/\__      ",
        @"   _/oYo \/_     ",
        @"  (_y__-  \/_    ",
        @"    |      \/    ",
        @"   _|||_(   \_   ",
        @"  (_(_|(____|/   "
        };

        public static string[] neoAttacker = new string[] {
        @"    |\_/\__      ",
        @"   _/oYo \/_     ",
        @"  (_y__-  \/_    ",
        @"    |      \/    ",
        @"   _|||_(   \_   ",
        @"  (_(_|(____|/   "
        };

        #endregion

        #endregion

        #endregion   
    }
}
