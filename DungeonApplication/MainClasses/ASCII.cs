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

        #region ASCII Screen Control Functions

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

        #region ASCII Battle Screen Functions

        public static void ANIPlayerSwitch()
        {
            string[] pokeBall = new string[]
        {
            @"                       ",
            @"                       ",
            @"                       ",
            @"                       ",
            @"                       ",
            @"                       ",

            @"▀▄                     ",
            @"▀▀█                    ",
            @"▄▀                     ",
            @"                       ",
            @"                       ",
            @"                       ",

            @"████▀▄                 ",
            @"▀▀o▀▀▀█                ",
            @"▄▄▄▄▄▀                 ",
            @"                       ",
            @"                       ",
            @"                       ",

            @"▄████▀▄                ",
            @"▀▀▀o▀▀▀█               ",
            @"▀▄▄▄▄▄▀                ",
            @"                       ",
            @"                       ",
            @"                       ",

            @"   ▄████▀▄             ",
            @"  █▀▀▀o▀▀▀█            ",
            @"   ▀▄▄▄▄▄▀             ",
            @"                       ",
            @"                       ",
            @"                       ",
                                       
            @"                       ",
            @"      ▄████▀▄          ",
            @"     █▀▀▀o▀▀▀█         ",
            @"      ▀▄▄▄▄▄▀          ",
            @"                       ",
            @"                       ",

            @"                       ",
            @"                       ",
            @"         ▄████▀▄       ",
            @"        █▀▀▀o▀▀▀█      ",
            @"         ▀▄▄▄▄▄▀       ",
            @"                       ",

            @"                       ",
            @"                       ",
            @"                       ",
            @"           ▄████▀▄     ",
            @"          █▀▀▀o▀▀▀█    ",
            @"           ▀▄▄▄▄▄▀     ",

            @"                       ",
            @"                       ",
            @"                       ",
            @"           ▄████▀▄     ",
            @"          █▀▀▀o▀▀▀█    ",
            @"           ▀▄▄▄▄▄▀     ",

            @"                       ",
            @"                       ",
            @"                       ",
            @"           ▄████▀▄     ",
            @"          █▀▀▀o▀▀▀█    ",
            @"           ▀▄▄▄▄▄▀     ",

            @"                       ",
            @"                       ",
            @"                       ",
            @"           ▄████▀▄     ",
            @"          █▀▀▀o▀▀▀█    ",
            @"           ▀▄▄▄▄▄▀     ",

            @"                       ",
            @"                       ",
            @"                       ",
            @"           ▄████▀▄     ",
            @"          █▀▀▀o▀▀▀█    ",
            @"           ▀▄▄▄▄▄▀     ",

            @"                       ",
            @"                       ",
            @"                       ",
            @"           ▄████▀▄     ",
            @"          █▀▀▀o▀▀▀█    ",
            @"           ▀▄▄▄▄▄▀     ",

            @"                       ",
            @"                       ",
            @"                       ",
            @"           ▄████▀▄     ",
            @"          █▀▀▀o▀▀▀█    ",
            @"           ▀▄▄▄▄▄▀     ",

            @"                       ",
            @"                       ",
            @"                       ",
            @"           ▄████▀▄     ",
            @"          █▀▀▀o▀▀▀█    ",
            @"           ▀▄▄▄▄▄▀     ",

            @"                       ",
            @"                       ",
            @"                       ",
            @"           ▄████▀▄     ",
            @"          █▀▀▀o▀▀▀█    ",
            @"           ▀▄▄▄▄▄▀     ",

            @"                       ",
            @"                       ",
            @"                       ",
            @"           ▄████▀▄     ",
            @"          █▀▀▀o▀▀▀█    ",
            @"           ▀▄▄▄▄▄▀     ",

            @"                       ",
            @"                       ",
            @"                       ",
            @"          ▄█ ▀▀▀ █▄    ",
            @"         █ ▄▄▄o▄▄▄ █   ",
            @"          ▀█ ▄▄▄ █▀    ",

            @"                       ",
            @"                       ",
            @"             ▄▄▄       ",
            @"          ▀       ▀    ",
            @"        █     o     █  ",
            @"          ▄  ▄▄▄  ▄    ",

            @"                       ",
            @"              ▄        ",
            @"        ▀▄    ▀    ▄▀  ",
            @"                       ",
            @"     ▄▄       o      ▄▄",
            @"          ▄  ▄▄▄  ▄    "
        };
            string length = "                    ";
            int frame = 0;
            foreach (char item in length)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(4, 15);
                Console.Write(pokeBall[frame]);
                Console.SetCursorPosition(4, 16);
                Console.Write(pokeBall[frame + 1]);
                Console.SetCursorPosition(4, 17);
                Console.Write(pokeBall[frame + 2]);
                Console.SetCursorPosition(4, 18);
                Console.Write(pokeBall[frame + 3]);
                Console.SetCursorPosition(4, 19);
                Console.Write(pokeBall[frame + 4]);
                Console.SetCursorPosition(4, 20);
                Console.Write(pokeBall[frame + 5]);
                Console.SetCursorPosition(90, 46);
                frame += 6;
                System.Threading.Thread.Sleep(25);
            }            
        }

        public static void WildDefenderAppear(string[] ScreenDisplay, Monster monster, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            string message = $"A wild {monster.Name} appeared!";
            string distance = "                                                                      ";
            int startPositionX = 95;
            foreach (char frame in distance)
            {
                Console.SetCursorPosition(4, 5);
                Console.Write(ScreenDisplay[0].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 6);
                Console.Write(ScreenDisplay[1].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 7);
                Console.Write(ScreenDisplay[2].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 8);
                Console.Write(ScreenDisplay[3].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 9);
                Console.Write(ScreenDisplay[4].Substring(startPositionX, 83));
                Console.SetCursorPosition(4, 10);
                Console.Write(ScreenDisplay[5].Substring(startPositionX, 83));
                Console.SetCursorPosition(90, 46);
                startPositionX -= 1;
                System.Threading.Thread.Sleep(1);
            }
            ScrollMessage(message, 50, 2000, GBText, GBBackground);
        }

        public static void PlayerAttackerSwitch(string[] ScreenDisplay, Player player, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            string message = $"{player.Name} sent out {player.MonsterEquipped.Name}!";
            ScrollMessage(message, 50, 2000, GBText, GBBackground);
            ANIPlayerSwitch();
            Console.ForegroundColor = GBText;
            Console.SetCursorPosition(4, 15);
            Console.Write(ScreenDisplay[0]);
            Console.SetCursorPosition(4, 16);
            Console.Write(ScreenDisplay[1]);
            Console.SetCursorPosition(4, 17);
            Console.Write(ScreenDisplay[2]);
            Console.SetCursorPosition(4, 18);
            Console.Write(ScreenDisplay[3]);
            Console.SetCursorPosition(4, 19);
            Console.Write(ScreenDisplay[4]);
            Console.SetCursorPosition(4, 20);
            Console.Write(ScreenDisplay[5]);
            Console.SetCursorPosition(90, 46);
        }

        public static void WildEncounter(Player player, Monster monster, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            WildDefenderAppear(monster.ANIWild, monster, GBText, GBBackground);
            System.Threading.Thread.Sleep(2000);
            PlayerAttackerSwitch(player.MonsterEquipped.ASCIIPlayer, player, GBText, GBBackground);
        }

        #endregion

        #region ASCII Object Display Functions

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

        #region ASCII String[] Displays

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

        #region ASCII Templates

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
   █                                                                          
   █                                                            ▄█▀▀▀█▄       
   █                                                           █▄▄▄o▄▄▄█      
   █                                                            ▀█▄▄▄█▀       ";

        #endregion

        #region Ball Player Switch

        public static string[] pokeBall = new string[]
        {
            @" ▄█▀▀▀█▄ ",
            @"█▄▄▄o▄▄▄█",
            @" ▀█▄▄▄█▀ "
        };

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

        #region Battle Menu (NEW ASCII)

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

        #region Display Monster Objects

        #region Pyra

        public static string[] pyraANI = new string[] {
        @"                                                                                     |\_/\__                                                                                      ",
        @"                                                                                    _/oYo \/_                                                                                     ",
        @"                                                                                   (_y__-  \/_                                                                                    ",
        @"                                                                                     |      \/                                                                                    ",
        @"                                                                                    _|||_(   \_                                                                                   ",
        @"                                                                                   (_(_|(____|/                                                                                   "};

        public static string[] pyraDefender = new string[] {
        @"    |\_/\__      ",
        @"   _/oYo \/_     ",
        @"  (_y__-  \/_    ",
        @"    |      \/    ",
        @"   _|||_(   \_   ",
        @"  (_(_|(____|/   "
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

        public static string[] douseyANI = new string[] {
        @"                                                                                       __                                                                                         ",
        @"                                                                                    -=(o `\                                                                                       ",
        @"                                                                                       '.-.\                                                                                      ",
        @"                                                                                       /|  \\                                                                                     ",
        @"                                                                                       '|  ||                                                                                     ",
        @"                                                                                        _\_):,_                                                                                   "};

        public static string[] douseyDefender = new string[] {
        @"      __         ",
        @"   -=(o `\       ",
        @"      '.-.\      ",
        @"      /|  \\     ",
        @"      '|  ||     ",
        @"       _\_):,_   "
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

        public static string[] electraANI = new string[] {
        @"                                                                                     |\_/\__                                                                                      ",
        @"                                                                                    _/oYo \/_                                                                                     ",
        @"                                                                                   (_y__-  \/_                                                                                    ",
        @"                                                                                     |      \/                                                                                    ",
        @"                                                                                    _|||_(   \_                                                                                   ",
        @"                                                                                   (_(_|(____|/                                                                                   "};

        public static string[] electraDefender = new string[] {
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

        public static string[] cobbletANI = new string[] {
        @"                                                                                                                                                                                  ",
        @"                                                                                      _   _                                                                                       ",
        @"                                                                                ___  / \_/ \  ___                                                                                 ",
        @"                                                                                \ / |\_= =_/| \ /                                                                                 ",
        @"                                                                                 \\//\_\_/_/\\//                                                                                  ",
        @"                                                                                  \/         \/                                                                                   "};

        public static string[] cobbletDefender = new string[] {
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

        public static string[] neoANI = new string[] {
        @"                                                                                     |\_/\__                                                                                      ",
        @"                                                                                    _/oYo \/_                                                                                     ",
        @"                                                                                   (_y__-  \/_                                                                                    ",
        @"                                                                                     |      \/                                                                                    ",
        @"                                                                                    _|||_(   \_                                                                                   ",
        @"                                                                                   (_(_|(____|/                                                                                   "};

        public static string[] neoDefender = new string[] {
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


































        #region Locations (NEW ASCII)

        public static string HomeTown = $@"
 _______________________________________________________________________________________ 
|  ___________________________________________________________________________________  |
| |  _____________________ _ ____________|     |____________________ _ _____________  | |
| | |            _________|_|_                             _________|_|_            | | |
| | |           | /=======| | |__________       __________| /=======| | |           | | |
| | |           |/========|_|\|          |     |          |/========|_|\|           | | |
| | |           |=============|          |     |          |=============|           | | |
| | |           | _   ___   _ |          |     |          | _   ___   _ |           | | |
| | |           ||+| |  o| |+||          |     |          ||+| |  o| |+||           | | |
| | |           |____|___|____|          |     |          |____|___|____|           | | |
| | |                |   |_______________|     |_______________|   |                | | |
| | |                |                                             |                | | |
| | |                |___________________       ___________________|                | | |
| | |                      _             |     |                     _              | | |
| | |            _________|_|_           |     |           _________|_|_            | | |
| | |           | /=======| | |          |     |          | /=======| | |           | | |
| | |           |/========|_|\|          |     |          |/========|_|\|           | | |
| | |           |=============|          |     |          |=============|           | | |
| | |           | _   ___   _ |          |     |          | _   ___   _ |           | | |
| | |           ||+| |  o| |+||          |     |          ||+| |  o| |+||           | | |
| | |           |____|___|____|          |     |          |____|___|____|           | | |
| | |                |   |_______________|     |_______________|   |                | | |
| | |                |                                             |                | | |
| | |                |_____________________________________________|                | | |
| | |_______________________________________________________________________________| | |
| |___________________________________________________________________________________| |";

        public static string PlayerHome = $@"
 _______________________________________________________________________________________
|  ___________________________________________________________________________________  |
| | o-======-o                      ||             ||    |                            | |
| |  |______|                       ||             ||    |                            | |
| |  |      |                       ||             || __ |                            | |
| |  |      |                       ||______       |||__||                            | |
| |  |______|                                      |||__||                            | |
| |                                                ||    |                            | |
| |                                                ||    |______  _____               | |
| |                                 ||             ||     | 0 0 ||     |              | |
| |                                 ||             ||     | 0 0 ||     |              | |
| |===================================             ====================               | |
| |                                                                                   | |
| |                     |                                                             | |
| |                     |                                                             | |
| |=====================|       ======                 _A_    _______________         | |
| ||________||_|                    ||                | X |  |_______________|        | |
| |                \|||||||/        ||                |===|  |_|___________|_|  ======| |
| |                |       |        ||                                         /  ____| |
| |   ____         |       |      __||               ____                      | |    | |
| |  |    |        |  (o)  |   _ | _||              | |__|                     | |____| |
| |  |    |        |       |  |=|||_||              | |  |                     \      | |
| |  |____|        |       |     |__||              | |__|                      ======| |
| | o|____|o       /|||||||\        ||              |_|__|                            | |
| |_________________________________||___       ______________________________________| |
| |______________________________________|_____|______________________________________| |";

        public static string LeaveHomeTown = $@"
 _______________________________________________________________________________________
|  ___________________________________________________________________________________  |
| |                                              ||                                   | |
| |                                              ||                                   | |
| |                                              ||                                   | |
| |                                              ||                                   | |
| |                                              ||                                   | |
| |                                              ||                                   | |
| |                                               ====================================| |
| |                                               vVvvVvVvvVvVvvVvVvvVvVvvvvVvVvvVvVvv| |
| |                                               VvvVvVvvVvVvvVvVvvVvVvvVvVvVvvVvVvvV| |
| |                                               vVvvVvVvvVvVvvVvVvvVvVvvvvVvVvvVvVvv| |
| |                                               VvvVvVvvVvVvvVvVvvVvVvvVvVvVvvVvVvvV| |
| |                                               vVvvVvVvvVvVvvVvVvvVvVvvvvVvVvvVvVvv| |
| |                                               VvvVvVvvVvVvvVvVvvVvVvvVvVvVvvVvVvvV| |
| |                                               vVvvVvVvvVvVvvVvVvvVvVvvvvVvVvvVvVvv| |
| |                                               VvvVvVvvVvVvvVvVvvVvVvvVvVvVvvVvVvvV| |
| |                                                                                   | |
| |                                                                                   | |
| |                                                                                   | |
| |                                                                                   | |
| |                                                                                   | |
| |                                                                                   | |
| |                                                                                   | |
| |______________________________________       ______________________________________| |
| |______________________________________|_____|______________________________________| |";

        #endregion

        #endregion   
    }
}
