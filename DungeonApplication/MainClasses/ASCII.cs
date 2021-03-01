using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MainClasses
{ 
    public class ASCII
    {
        /****FOR EACH NEW METHOD() ADD Console.SetCursorPosition(90, 42); AT THE END OF THE LAST WRITE/WRITELINE TO REMOVE THE (PRESS ANY KEY TO CONTINUE)****/

        //TODO Create Move Conversion Method() that rewrites the selected move into the desired slot just like how the CatchSort Functionality works
        //TODO Be able to utilize the conversion method() when a monster is caught to prevent rewriting the original move structured code.

        #region TIME CONTROL

        public static Stopwatch TimePlayed = new Stopwatch();

        public static TimeSpan PlayTime = TimePlayed.Elapsed;

        public static string elapsedTime = string.Format("{0:00}:{1:00}", PlayTime.Hours, PlayTime.Minutes);

        #endregion

        #region METHODS: Game Versions

        public static Random random = new Random();

        public static void DEMO(ConsoleKey navPlayerMenu, int currentPosX, int currentPosY)
        {
            bool reloadMainScreen = false;
            bool reloadColorFormat = false;

            ConsoleColor GBColor = new ConsoleColor();
            ConsoleColor GBText = new ConsoleColor();
            ConsoleColor GBBackground = new ConsoleColor();

            TimePlayed.Start();

            #region Player Starting Stats

            Player player = new Player();
            player.PlayerID = random.Next(20000, 40000);
            player.Party = new Player_Party();
            player.Inventory = new Player_Inventory();
            player.PC = Monster.PC;
            player.StartTime = DateTime.Now.ToString($"{0:MMM dd}, {0:yyyy}");
            player.Party.MonsterEquipped = new Monster();
            player.Party.Slot2 = Monster.default2;
            player.Party.Slot2.Health = 0;
            player.Party.Slot2.Name = "";
            player.Party.Slot3 = Monster.default3;
            player.Party.Slot3.Health = 0;
            player.Party.Slot3.Name = "";
            player.Party.Slot4 = Monster.default4;
            player.Party.Slot4.Health = 0;
            player.Party.Slot4.Name = "";
            player.Party.Slot5 = Monster.default5;
            player.Party.Slot5.Health = 0;
            player.Party.Slot5.Name = "";
            player.Party.Slot6 = Monster.default6;
            player.Party.Slot6.Health = 0;
            player.Party.Slot6.Name = "";
            player.Party.MonsterSwitch = Monster.monsterSwitch;
            player.Money = 0;

            #endregion

            #region Starting Rival Stats

            Player rival = new Player();
            rival.Party = new Player_Party();
            rival.Party.MonsterEquipped = new Monster();
            rival.Party.MonsterEquipped.Type = Monster_Race.NONE;
            rival.Party.Slot2 = new Monster();
            rival.Party.Slot2.Type = Monster_Race.NONE;
            rival.Party.Slot2.Health = 0;
            rival.Party.Slot3 = new Monster();
            rival.Party.Slot3.Type = Monster_Race.NONE;
            rival.Party.Slot3.Health = 0;
            rival.Party.Slot4 = new Monster();
            rival.Party.Slot4.Type = Monster_Race.NONE;
            rival.Party.Slot4.Health = 0;
            rival.Party.Slot5 = new Monster();
            rival.Party.Slot5.Type = Monster_Race.NONE;
            rival.Party.Slot5.Health = 0;
            rival.Party.Slot6 = new Monster();
            rival.Party.Slot6.Type = Monster_Race.NONE;
            rival.Party.Slot6.Health = 0;
            rival.Party.MonsterSwitch = new Monster();
            rival.Party.MonsterSwitch.Type = Monster_Race.NONE;
            rival.ASCIIDefender = npcDefender;
            rival.ASCIIProfile = npcProfile;

            #endregion                        

            //****Choose Console Color
            do
            {
                GameBoy(ConsoleColor.DarkGray);
                ResetScreen(ConsoleColor.White, ConsoleColor.Black);
                Console.SetCursorPosition(4, 3);
                Console.WriteLine("                       - Choose Your Game Console Color -");
                Console.SetCursorPosition(4, 5);
                Console.WriteLine("     [R]ED     [B]LUE     [Y]ELLOW     [G]REEN     [L]IGHT-BLUE     [P]URPLE");
                Console.SetCursorPosition(90, 42);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.R:
                        GBColor = ConsoleColor.DarkRed;
                        GameBoy(GBColor);
                        ResetScreen(ConsoleColor.White, ConsoleColor.Black);
                        Console.SetCursorPosition(32, 15);
                        Console.WriteLine("     CONFIRM CHOICE?");
                        Console.SetCursorPosition(32, 17);
                        Console.WriteLine("[ENTER] YES [BACKSPACE] NO");
                        Console.SetCursorPosition(90, 42);
                        navPlayerMenu = Console.ReadKey().Key;
                        switch (navPlayerMenu)
                        {
                            case ConsoleKey.Enter:
                                reloadMainScreen = false;
                                break;
                            case ConsoleKey.Backspace:
                                reloadMainScreen = true;
                                break;
                            default:
                                reloadMainScreen = true;
                                break;
                        }
                        break;
                    case ConsoleKey.B:
                        GBColor = ConsoleColor.DarkBlue;
                        GameBoy(GBColor);
                        ResetScreen(ConsoleColor.White, ConsoleColor.Black);
                        Console.SetCursorPosition(32, 15);
                        Console.WriteLine("     CONFIRM CHOICE?");
                        Console.SetCursorPosition(32, 17);
                        Console.WriteLine("[ENTER] YES [BACKSPACE] NO");
                        Console.SetCursorPosition(90, 42);
                        navPlayerMenu = Console.ReadKey().Key;
                        switch (navPlayerMenu)
                        {
                            case ConsoleKey.Enter:
                                reloadMainScreen = false;
                                break;
                            case ConsoleKey.Backspace:
                                reloadMainScreen = true;
                                break;
                            default:
                                reloadMainScreen = true;
                                break;
                        }
                        break;
                    case ConsoleKey.Y:
                        GBColor = ConsoleColor.DarkYellow;
                        GameBoy(GBColor);
                        ResetScreen(ConsoleColor.White, ConsoleColor.Black);
                        Console.SetCursorPosition(32, 15);
                        Console.WriteLine("     CONFIRM CHOICE?");
                        Console.SetCursorPosition(32, 17);
                        Console.WriteLine("[ENTER] YES [BACKSPACE] NO");
                        Console.SetCursorPosition(90, 42);
                        navPlayerMenu = Console.ReadKey().Key;
                        switch (navPlayerMenu)
                        {
                            case ConsoleKey.Enter:
                                reloadMainScreen = false;
                                break;
                            case ConsoleKey.Backspace:
                                reloadMainScreen = true;
                                break;
                            default:
                                reloadMainScreen = true;
                                break;
                        }
                        break;
                    case ConsoleKey.G:
                        GBColor = ConsoleColor.DarkGreen;
                        GameBoy(GBColor);
                        ResetScreen(ConsoleColor.White, ConsoleColor.Black);
                        Console.SetCursorPosition(32, 15);
                        Console.Write("     CONFIRM CHOICE?");
                        Console.SetCursorPosition(32, 17);
                        Console.Write("[ENTER] YES [BACKSPACE] NO");
                        Console.SetCursorPosition(90, 42);
                        navPlayerMenu = Console.ReadKey().Key;
                        switch (navPlayerMenu)
                        {
                            case ConsoleKey.Enter:
                                reloadMainScreen = false;
                                break;
                            case ConsoleKey.Backspace:
                                reloadMainScreen = true;
                                break;
                            default:
                                reloadMainScreen = true;
                                break;
                        }
                        break;
                    case ConsoleKey.L:
                        GBColor = ConsoleColor.DarkCyan;
                        GameBoy(GBColor);
                        ResetScreen(ConsoleColor.White, ConsoleColor.Black);
                        Console.SetCursorPosition(32, 15);
                        Console.Write("     CONFIRM CHOICE?");
                        Console.SetCursorPosition(32, 17);
                        Console.Write("[ENTER] YES [BACKSPACE] NO");
                        Console.SetCursorPosition(90, 42);
                        navPlayerMenu = Console.ReadKey().Key;
                        switch (navPlayerMenu)
                        {
                            case ConsoleKey.Enter:
                                reloadMainScreen = false;
                                break;
                            case ConsoleKey.Backspace:
                                reloadMainScreen = true;
                                break;
                            default:
                                reloadMainScreen = true;
                                break;
                        }
                        break;
                    case ConsoleKey.P:
                        GBColor = ConsoleColor.DarkMagenta;
                        GameBoy(GBColor);
                        ResetScreen(ConsoleColor.White, ConsoleColor.Black);
                        Console.SetCursorPosition(32, 15);
                        Console.Write("     CONFIRM CHOICE?");
                        Console.SetCursorPosition(32, 17);
                        Console.Write("[ENTER] YES [BACKSPACE] NO");
                        Console.SetCursorPosition(90, 42);
                        navPlayerMenu = Console.ReadKey().Key;
                        switch (navPlayerMenu)
                        {
                            case ConsoleKey.Enter:
                                reloadMainScreen = false;
                                break;
                            case ConsoleKey.Backspace:
                                reloadMainScreen = true;
                                break;
                            default:
                                reloadMainScreen = true;
                                break;
                        }
                        break;
                    default:
                        reloadMainScreen = true;
                        break;
                }
            } while (reloadMainScreen);

            //****Choose Game Screen Format
            do
            {
                GameBoy(GBColor);
                ResetScreen(ConsoleColor.White, ConsoleColor.Black);
                Console.SetCursorPosition(4, 3);
                Console.WriteLine("                       - Choose Your Game Color Format -");
                Console.SetCursorPosition(4, 5);
                Console.WriteLine("                  [L]IGHT MODE                        [D]ARK MODE             ");
                Console.SetCursorPosition(90, 42);
                navPlayerMenu = Console.ReadKey().Key;

                switch (navPlayerMenu)
                {
                    case ConsoleKey.L:
                        GBText = ConsoleColor.Black;
                        GBBackground = ConsoleColor.White;
                        GameMap(DEMOMap, currentPosX, currentPosY, GBText, GBBackground);
                        Console.SetCursorPosition(32, 15);
                        Console.WriteLine("     CONFIRM CHOICE?");
                        Console.SetCursorPosition(32, 17);
                        Console.WriteLine("[ENTER] YES [BACKSPACE] NO");
                        Console.SetCursorPosition(90, 42);
                        navPlayerMenu = Console.ReadKey().Key;
                        switch (navPlayerMenu)
                        {
                            case ConsoleKey.Enter:
                                reloadColorFormat = false;
                                break;
                            case ConsoleKey.Backspace:
                                reloadColorFormat = true;
                                break;
                            default:
                                reloadColorFormat = true;
                                break;
                        }
                        break;
                    case ConsoleKey.D:
                        GBText = ConsoleColor.White;
                        GBBackground = ConsoleColor.Black;
                        GameMap(DEMOMap, currentPosX, currentPosY, GBText, GBBackground);
                        Console.SetCursorPosition(32, 15);
                        Console.WriteLine("     CONFIRM CHOICE?");
                        Console.SetCursorPosition(32, 17);
                        Console.WriteLine("[ENTER] YES [BACKSPACE] NO");
                        Console.SetCursorPosition(90, 42);
                        navPlayerMenu = Console.ReadKey().Key;
                        switch (navPlayerMenu)
                        {
                            case ConsoleKey.Enter:
                                reloadColorFormat = false;
                                break;
                            case ConsoleKey.Backspace:
                                reloadColorFormat = true;
                                break;
                            default:
                                reloadColorFormat = true;
                                break;
                        }
                        break;
                    default:
                        reloadColorFormat = true;
                        break;
                }
            } while (reloadColorFormat);

            SFX.IntroTheme();

            #region ANIMATES TITLE INTRO
            ResetScreen(GBText, GBBackground);
            System.Threading.Thread.Sleep(4500);
            int startLine = 2;
            foreach (string line in Title)
            {
                Console.SetCursorPosition(6, startLine + 1);
                Console.Write(line);
                Console.SetCursorPosition(90, 42);
                startLine += 1;
            }
            
            System.Threading.Thread.Sleep(2000);
            startLine = Title.Length;

            foreach (string line in Title)
            {
                Console.SetCursorPosition(6, startLine + 2);
                Console.Write("                                                                               ");
                Console.SetCursorPosition(90, 42);
                startLine -= 1;
                System.Threading.Thread.Sleep(100);
            }
            #endregion

            #region INPUT INFO

            string message1 = "Welcome to the world of Pokefraud! My name is SALIX!";
            string message2 = "But most people call me the Pokefraud Prof!";
            string message3 = "This world is inhabited by magical creatures called Pokefraud!";
            string message4 = "For some people, Pokefraud are pets. Others use them for fights.";
            string message5 = "Myself...I study Pokefraud as a profession.";
            string message6 = "First, what is your name? ";            
            StaticMessageBox(GBText, GBBackground);
            System.Threading.Thread.Sleep(1000);
            int proY = 8;
            foreach (string line in Professor)
            {
                Console.SetCursorPosition(40, proY);
                Console.Write(line);
                proY += 1;
            }
            ScrollMessage(message1, 50, 1500, GBText, GBBackground);
            ScrollMessage(message2, 50, 1500, GBText, GBBackground);
            ScrollMessage(message3, 50, 1500, GBText, GBBackground);
            PokeBallANI(30, 10, 25, GBBackground);
            PokeBallANI(29, 11, 25, GBBackground);
            PokeBallANI(28, 12, 25, GBBackground);
            PokeBallANI(27, 13, 25, GBBackground);
            PokeBallANI(27, 14, 25, GBBackground);
            PokeBallANI(27, 13, 25, GBBackground);
            PokeBallANI(27, 14, 2000, GBBackground);
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
            BallBreak(26, 13, 50, GBText, GBBackground);
            int pokY = 10;
            foreach (string line in cobbletPokedex)
            {
                Console.ForegroundColor = GBText;
                Console.BackgroundColor = GBBackground;
                Console.SetCursorPosition(18, pokY);
                Console.Write(line);
                pokY += 1;
            }
            ScrollMessage(message4, 50, 1500, GBText, GBBackground);
            ScrollMessage(message5, 50, 1500, GBText, GBBackground);
            ResetHalfScreen(8, GBText, GBBackground);
            proY = 8;
            foreach (string line in Professor)
            {
                Console.SetCursorPosition(40, proY);
                Console.Write(line);
                proY += 1;
            }
            ScrollMessage(message6, 50, 1, GBText, GBBackground);
            string playerName = Console.ReadLine().ToUpper();
            player.Name = playerName;
            string message7 = $"SALIX: Right! So your name is {player.Name.ToUpper()}!";
            ScrollMessage(message7, 50, 1500, GBText, GBBackground);
            string message8 = "SALIX: And are you a boy or a girl?";
            ScrollMessage(message8, 50, 1000, GBText, GBBackground);

            bool reloadGender = false;
            int posY = 22;
            int chooseNum = 0;

            Console.SetCursorPosition(65, 22);
            Console.Write("BOY");
            Console.SetCursorPosition(65, 23);
            Console.Write("GIRL");
            do
            {
                Console.SetCursorPosition(61, posY);
                Console.Write("-->");
                Console.SetCursorPosition(90, 42);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Console.SetCursorPosition(61, posY);
                        Console.Write("   ");
                        posY -= 1;
                        if (posY < 22)
                        {
                            posY += 1;
                        }
                        reloadGender = true;
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Console.SetCursorPosition(61, posY);
                        Console.Write("   ");
                        posY += 1;
                        if (posY > 23)
                        {
                            posY -= 1;
                        }
                        reloadGender = true;
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.K:
                        if (posY == 22)
                        {
                            player.Gender = '♂';
                            string boy = "SALIX: Ah yes! So you're a boy!";
                            ScrollMessage(boy, 50, 1500, GBText, GBBackground);
                            chooseNum += 1;
                            reloadGender = false;
                        }
                        else if (posY == 23)
                        {
                            player.Gender = '♀';
                            string girl = "SALIX: Ah yes! So you're a girl!";
                            ScrollMessage(girl, 50, 1500, GBText, GBBackground);
                            chooseNum += 2;
                            reloadGender = false;
                        }
                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        reloadGender = false;
                        break;
                    default:
                        reloadGender = true;
                        break;
                }
            } while (reloadGender);
            string message9 = "SALIX: This is my grandson. He's been your rival since you were a baby.";
            string message10 = "SALIX: ..Erm, what is his name again? ";
            proY = 8;
            foreach (string line in Rival)
            {
                Console.SetCursorPosition(25, proY);
                Console.Write(line);
                proY += 1;
            }
            ScrollMessage(message9, 50, 1500, GBText, GBBackground);
            ScrollMessage(message10, 50, 1, GBText, GBBackground);
            string rivalName = Console.ReadLine().ToUpper();
            rival.Name = rivalName;
            string message11 = $"SALIX: That's right! I remember now! His name is {rival.Name.ToUpper()}!";
            ScrollMessage(message11, 50, 1500, GBText, GBBackground);
            ResetHalfScreen(8, GBText, GBBackground);
            proY = 8;
            foreach (string line in Professor)
            {
                Console.SetCursorPosition(40, proY);
                Console.Write(line);
                proY += 1;
            }
            string message12 = "SALIX: Now...You can't just venture off alone in this world.";
            string message13 = "SALIX: You first need to choose a Pokefraud companion.";
            string message14 = "SALIX: Here are 3 excellent starters that bond quickly with their trainers.";
            ScrollMessage(message12, 50, 1500, GBText, GBBackground);
            ScrollMessage(message13, 50, 1500, GBText, GBBackground);    
            
            #region Animates Professor Movement

            ResetHalfScreen(8, GBText, GBBackground);
            proY = 7;
            foreach (string line in Professor)
            {
                Console.SetCursorPosition(40, proY);
                Console.Write(line);
                proY += 1;
            }
            System.Threading.Thread.Sleep(25);
            ResetHalfScreen(7, GBText, GBBackground);
            proY = 6;
            foreach (string line in Professor)
            {
                Console.SetCursorPosition(40, proY);
                Console.Write(line);
                proY += 1;
            }
            System.Threading.Thread.Sleep(25);
            ResetHalfScreen(6, GBText, GBBackground);
            proY = 5;
            foreach (string line in Professor)
            {
                Console.SetCursorPosition(40, proY);
                Console.Write(line);
                proY += 1;
            }
            System.Threading.Thread.Sleep(25);
            ResetHalfScreen(5, GBText, GBBackground);
            proY = 4;
            foreach (string line in Professor)
            {
                Console.SetCursorPosition(40, proY);
                Console.Write(line);
                proY += 1;
            }
            System.Threading.Thread.Sleep(25);
            ResetHalfScreen(4, GBText, GBBackground);
            proY = 3;
            foreach (string line in Professor)
            {
                Console.SetCursorPosition(40, proY);
                Console.Write(line);
                proY += 1;
            }                                   
            System.Threading.Thread.Sleep(25);
            ResetHalfScreen(3, GBText, GBBackground);
            proY = 2;
            foreach (string line in Professor)
            {
                Console.SetCursorPosition(40, proY);
                Console.Write(line);
                proY += 1;
            }
            System.Threading.Thread.Sleep(25);

            #endregion

            #region Animates Starters
            PokeBallStatic(20, 15, ConsoleColor.Black);
            PokeBallStatic(43, 15, ConsoleColor.Black);
            PokeBallStatic(66, 15, ConsoleColor.Black);
            BallBreak(20, 15, 50, ConsoleColor.White, ConsoleColor.Black);
            posY = 11;
            foreach (string line in pyraPokedex)
            {
                Console.SetCursorPosition(14, posY);
                Console.Write(line);
                posY += 1;
            }
            BallBreak(43, 15, 50, ConsoleColor.White, ConsoleColor.Black);
            posY = 11;
            foreach (string line in dowseyPokedex)
            {
                Console.SetCursorPosition(37, posY);
                Console.Write(line);
                posY += 1;
            }
            BallBreak(66, 15, 50, ConsoleColor.White, ConsoleColor.Black);
            posY = 11;
            foreach (string line in electraPokedex)
            {
                Console.SetCursorPosition(60, posY);
                Console.Write(line);
                posY += 1;
            }
            #endregion

            ScrollMessage(message14, 50, 1500, GBText, GBBackground);
            bool reloadStarters = false;
            int posX = 15;
            do
            {
                if (posX == 15)
                {
                    Console.SetCursorPosition(posX, 19);
                    Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
                    StaticMessageBox(GBText, GBBackground);
                    Console.SetCursorPosition(8, 22);
                    Console.Write("PYRA: The ");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("FIRE");
                    Console.ForegroundColor = GBText;
                    Console.Write(" Type Pokefraud.");
                    Console.SetCursorPosition(8, 23);
                    Console.Write("This creature can produce blazing flame attacks. (Weakness: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("WATER");
                    Console.ForegroundColor = GBText;
                    Console.Write(" Types)");
                }
                if (posX == 38)
                {
                    Console.SetCursorPosition(posX, 19);
                    Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
                    StaticMessageBox(GBText, GBBackground);
                    Console.SetCursorPosition(8, 22);
                    Console.Write("DOWSEY: The ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("WATER");
                    Console.ForegroundColor = GBText;
                    Console.Write(" Type Pokefraud.");
                    Console.SetCursorPosition(8, 23);
                    Console.Write("Can generate water at will to attack its enemies. (Weakness: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("ELECTRIC");
                    Console.ForegroundColor = GBText;
                    Console.Write(" Types)");
                }
                if (posX == 61)
                {
                    Console.SetCursorPosition(posX, 19);
                    Console.Write("█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
                    StaticMessageBox(GBText, GBBackground);
                    Console.SetCursorPosition(8, 22);
                    Console.Write("ELECTRA: The ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("ELECTRIC");
                    Console.ForegroundColor = GBText;
                    Console.Write(" Type Pokefraud.");
                    Console.SetCursorPosition(8, 23);
                    Console.Write("Produces high voltage attacks. (Weakness: ");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("GROUND");
                    Console.ForegroundColor = GBText;
                    Console.Write(" Types)");
                }                
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        Console.SetCursorPosition(posX, 19);
                        Console.Write("                   ");
                        posX += 23;
                        if (posX > 61)
                        {
                            posX -= 23;
                            reloadStarters = true;
                        }
                        else
                        {
                            Console.SetCursorPosition(posX, 19);
                            Console.Write("                   ");
                            reloadStarters = true;
                        }                        
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        Console.SetCursorPosition(posX, 19);
                        Console.Write("                   ");
                        posX -= 23;
                        if (posX < 15)
                        {
                            posX += 23;
                            reloadStarters = true;
                        }
                        else
                        {
                            Console.SetCursorPosition(posX, 19);
                            Console.Write("                   ");
                            reloadStarters = true;
                        }
                        break;

                    //EASTER EGG
                    case ConsoleKey.P:
                        navPlayerMenu = Console.ReadKey().Key;
                        switch (navPlayerMenu)
                        {
                            case ConsoleKey.S:
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.Y:
                                        navPlayerMenu = Console.ReadKey().Key;
                                        switch (navPlayerMenu)
                                        {
                                            case ConsoleKey.C:
                                                navPlayerMenu = Console.ReadKey().Key;
                                                switch (navPlayerMenu)
                                                {
                                                    case ConsoleKey.H:
                                                        navPlayerMenu = Console.ReadKey().Key;
                                                        switch (navPlayerMenu)
                                                        {
                                                            case ConsoleKey.I:
                                                                navPlayerMenu = Console.ReadKey().Key;
                                                                switch (navPlayerMenu)
                                                                {
                                                                    case ConsoleKey.C:
                                                                        //ResetHalfScreen(10, GBText, GBBackground);
                                                                        player.Party.MonsterEquipped = Monster.starterNeo;
                                                                        rival.Party.MonsterEquipped = Monster.rivalElectra;
                                                                        rival.Party.Slot2 = Monster.rivalCobblet;
                                                                        ResetHalfScreen(11, GBText, GBBackground);
                                                                        string message = "SALIX: Oh no! It looks like all the available Pokefraud were chosen!";
                                                                        string messageRare1 = "SALIX: But..";
                                                                        string messageRare2 = "SALIX: We do have a fourth option for you..";
                                                                        ScrollMessage(message, 50, 1500, GBText, GBBackground);
                                                                        ScrollMessage(messageRare1, 50, 1500, GBText, GBBackground);
                                                                        ScrollMessage(messageRare2, 50, 2500, GBText, GBBackground);
                                                                        PokeBallStatic(43, 15, ConsoleColor.Black);
                                                                        System.Threading.Thread.Sleep(1000);
                                                                        BallBreak(43, 15, 50, ConsoleColor.White, ConsoleColor.Black);
                                                                        posY = 12;
                                                                        foreach (string line in neoPokedex)
                                                                        {
                                                                            Console.SetCursorPosition(37, posY);
                                                                            Console.Write(line);
                                                                            posY += 1;
                                                                        }
                                                                        string messageRare3 = "SALIX: This is NEO. The ";
                                                                        StaticMessageBox(GBText, GBBackground);
                                                                        posX = 8;                                                                        
                                                                        foreach (char letter in messageRare3)
                                                                        {
                                                                            Console.SetCursorPosition(posX, 22);
                                                                            Console.Write(letter);
                                                                            posX += 1;
                                                                            System.Threading.Thread.Sleep(50);

                                                                        }
                                                                        foreach (char letter in "PSYCHIC")
                                                                        {
                                                                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                                                            Console.SetCursorPosition(posX, 22);
                                                                            Console.Write(letter);
                                                                            posX += 1;
                                                                            System.Threading.Thread.Sleep(50);
                                                                        }
                                                                        foreach (char letter in " Pokefraud!")
                                                                        {
                                                                            Console.ForegroundColor = GBText;
                                                                            Console.SetCursorPosition(posX, 22);
                                                                            Console.Write(letter);
                                                                            posX += 1;
                                                                            System.Threading.Thread.Sleep(50);
                                                                        }
                                                                        System.Threading.Thread.Sleep(1500);
                                                                        string messageRare4 = "SALIX: NEO is a powerful Pokefraud with its very few weaknesses!";
                                                                        string messageRare5 = "SALIX: But..";
                                                                        string messageRare6 = "SALIX: NEO tends not to listen to its trainer's commands at times..";
                                                                        string messageRare7 = "SALIX: Good luck!";
                                                                        ScrollMessage(messageRare4, 50, 1500, GBText, GBBackground);
                                                                        ScrollMessage(messageRare5, 50, 1500, GBText, GBBackground);
                                                                        ScrollMessage(messageRare6, 50, 1500, GBText, GBBackground);
                                                                        ScrollMessage(messageRare7, 50, 1500, GBText, GBBackground);
                                                                        reloadStarters = false;
                                                                        break;
                                                                    default:
                                                                        reloadStarters = true;
                                                                        break;
                                                                }
                                                                break;
                                                            default:
                                                                reloadStarters = true;
                                                                break;
                                                        }
                                                        break;
                                                    default:
                                                        reloadStarters = true;
                                                        break;
                                                }
                                                break;
                                            default:
                                                reloadStarters = true;
                                                break;
                                        }
                                        break;
                                    default:
                                        reloadStarters = true;
                                        break;
                                }
                                break;
                            default:
                                reloadStarters = true;
                                break;
                        }
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.K:
                        StaticMessageBox(GBText, GBBackground);
                        Console.SetCursorPosition(8, 22);
                        Console.Write("I see...So you want ");
                        if (posX == 15)
                        {
                            Console.Write("PYRA");
                            player.Party.MonsterEquipped = Monster.starterPyra;
                            rival.Party.MonsterEquipped = Monster.rivalDowsey;
                        }
                        if (posX == 38)
                        {
                            Console.Write("DOWSEY");
                            player.Party.MonsterEquipped = Monster.starterDowsey;
                            rival.Party.MonsterEquipped = Monster.rivalElectra;
                        }
                        if (posX == 61)
                        {
                            Console.Write("ELECTRA");
                            player.Party.MonsterEquipped = Monster.starterElectra;
                            rival.Party.MonsterEquipped = Monster.rivalPyra;
                        }
                        Console.Write("?");
                        bool reloadChoose = false;
                        posY = 22;
                        chooseNum = 0;

                        Console.SetCursorPosition(65, 22);
                        Console.Write("YES");
                        Console.SetCursorPosition(65, 23);
                        Console.Write("NO");
                        do
                        {
                            Console.SetCursorPosition(61, posY);
                            Console.Write("-->");
                            Console.SetCursorPosition(90, 42);
                            navPlayerMenu = Console.ReadKey().Key;
                            switch (navPlayerMenu)
                            {
                                case ConsoleKey.UpArrow:
                                case ConsoleKey.W:
                                    Console.SetCursorPosition(61, posY);
                                    Console.Write("   ");
                                    posY -= 1;
                                    if (posY < 22)
                                    {
                                        posY += 1;
                                    }
                                    reloadChoose = true;
                                    break;
                                case ConsoleKey.DownArrow:
                                case ConsoleKey.S:
                                    Console.SetCursorPosition(61, posY);
                                    Console.Write("   ");
                                    posY += 1;
                                    if (posY > 23)
                                    {
                                        posY -= 1;
                                    }
                                    reloadChoose = true;
                                    break;
                                case ConsoleKey.Enter:
                                case ConsoleKey.K:
                                    if (posY == 22)
                                    {
                                        reloadChoose = false;
                                        reloadStarters = false;
                                    }
                                    else if (posY == 23)
                                    {
                                        ScrollMessage("SALIX: Well then..", 50, 1500, GBText, GBBackground);
                                        ScrollMessage("SALIX: Please choose a Pokefraud.", 50, 2000, GBText, GBBackground);
                                        reloadChoose = false;
                                        reloadStarters = true;
                                    }
                                    break;
                                case ConsoleKey.Backspace:
                                case ConsoleKey.O:
                                    ScrollMessage("SALIX: Well then..", 50, 1500, GBText, GBBackground);
                                    ScrollMessage("SALIX: Please choose a Pokefraud.", 50, 2000, GBText, GBBackground);
                                    reloadChoose = false;
                                    reloadStarters = true;
                                    break;
                                default:
                                    reloadChoose = true;
                                    break;
                            }
                        } while (reloadChoose);
                        break;
                    default:
                        reloadStarters = true;
                        break;
                }                
            } while (reloadStarters);

            ResetHalfScreen(12, GBText, GBBackground);
            if (player.Party.MonsterEquipped != Monster.starterNeo)
            {
                if (player.Party.MonsterEquipped == Monster.starterPyra)
                {
                    //Deletes Dowsey
                    posY = 11;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(37, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    //Deletes Electra
                    posY = 11;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(60, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    //Redisplays Pyra
                    posY = 11;
                    foreach (string line in pyraPokedex)
                    {
                        Console.SetCursorPosition(14, posY);
                        Console.Write(line);
                        posY += 1;
                    }

                    #region Animates Professor Movement

                    posY = 2;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 3;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    posY = 3;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 4;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    posY = 4;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 5;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    posY = 5;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 6;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    posY = 6;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 7;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    posY = 7;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 8;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    posY = 8;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 9;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    #endregion
                }
                if (player.Party.MonsterEquipped == Monster.starterDowsey)
                {
                    //Deletes Pyra
                    posY = 11;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(14, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    //Deletes Electra
                    posY = 11;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(60, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    //Redisplays Dowsey                
                    posX = 37;
                    string moveOver = "                   ";
                    foreach (char number in moveOver)
                    {
                        posY = 11;
                        foreach (string line in dowseyPokedex)
                        {
                            Console.SetCursorPosition(posX, posY);
                            Console.Write(line);
                            posY += 1;
                        }
                        System.Threading.Thread.Sleep(50);
                        posX += 1;
                    }

                    #region Animates Professor Movement

                    posY = 2;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 3;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    posY = 3;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 4;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    posY = 4;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 5;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    posY = 5;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 6;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    posY = 6;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 7;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    posY = 7;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 8;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    posY = 8;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 9;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    #endregion
                }
                if (player.Party.MonsterEquipped == Monster.starterElectra)
                {
                    //Deletes Pyra
                    posY = 11;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(14, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    //Deletes Dowsey
                    posY = 11;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(60, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    //Redisplays Electra  
                    posY = 11;
                    foreach (string line in electraPokedex)
                    {
                        Console.SetCursorPosition(60, posY);
                        Console.Write(line);
                        posY += 1;
                    }

                    #region Animates Professor Movement

                    posY = 2;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 3;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    posY = 3;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 4;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    posY = 4;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 5;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    posY = 5;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 6;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    posY = 6;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 7;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    posY = 7;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 8;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    posY = 8;
                    foreach (string line in emptyPokedex)
                    {
                        Console.SetCursorPosition(40, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    proY = 9;
                    foreach (string line in Professor)
                    {
                        Console.SetCursorPosition(40, proY);
                        Console.Write(line);
                        proY += 1;
                    }
                    System.Threading.Thread.Sleep(50);
                    #endregion
                }

                string message15 = $"SALIX: A fine choice! {player.Party.MonsterEquipped.Name.ToUpper()} will surely serve you well!";
                ScrollMessage(message15, 50, 1500, GBText, GBBackground);
            }
            else
            {
                #region Animates Professor Movement

                posY = 2;
                foreach (string line in emptyPokedex)
                {
                    Console.SetCursorPosition(40, posY);
                    Console.Write(line);
                    posY += 1;
                }
                proY = 3;
                foreach (string line in Professor)
                {
                    Console.SetCursorPosition(40, proY);
                    Console.Write(line);
                    proY += 1;
                }
                System.Threading.Thread.Sleep(50);
                posY = 3;
                foreach (string line in emptyPokedex)
                {
                    Console.SetCursorPosition(40, posY);
                    Console.Write(line);
                    posY += 1;
                }
                proY = 4;
                foreach (string line in Professor)
                {
                    Console.SetCursorPosition(40, proY);
                    Console.Write(line);
                    proY += 1;
                }
                System.Threading.Thread.Sleep(50);
                posY = 4;
                foreach (string line in emptyPokedex)
                {
                    Console.SetCursorPosition(40, posY);
                    Console.Write(line);
                    posY += 1;
                }
                proY = 5;
                foreach (string line in Professor)
                {
                    Console.SetCursorPosition(40, proY);
                    Console.Write(line);
                    proY += 1;
                }
                System.Threading.Thread.Sleep(50);
                posY = 5;
                foreach (string line in emptyPokedex)
                {
                    Console.SetCursorPosition(40, posY);
                    Console.Write(line);
                    posY += 1;
                }
                proY = 6;
                foreach (string line in Professor)
                {
                    Console.SetCursorPosition(40, proY);
                    Console.Write(line);
                    proY += 1;
                }
                System.Threading.Thread.Sleep(50);
                posY = 6;
                foreach (string line in emptyPokedex)
                {
                    Console.SetCursorPosition(40, posY);
                    Console.Write(line);
                    posY += 1;
                }
                proY = 7;
                foreach (string line in Professor)
                {
                    Console.SetCursorPosition(40, proY);
                    Console.Write(line);
                    proY += 1;
                }
                System.Threading.Thread.Sleep(50);
                posY = 7;
                foreach (string line in emptyPokedex)
                {
                    Console.SetCursorPosition(40, posY);
                    Console.Write(line);
                    posY += 1;
                }
                proY = 8;
                foreach (string line in Professor)
                {
                    Console.SetCursorPosition(40, proY);
                    Console.Write(line);
                    proY += 1;
                }
                System.Threading.Thread.Sleep(50);
                posY = 8;
                foreach (string line in emptyPokedex)
                {
                    Console.SetCursorPosition(40, posY);
                    Console.Write(line);
                    posY += 1;
                }
                proY = 9;
                foreach (string line in Professor)
                {
                    Console.SetCursorPosition(40, proY);
                    Console.Write(line);
                    proY += 1;
                }
                System.Threading.Thread.Sleep(50);
                #endregion
            }
            string message16 = "SALIX: Your very own Pokefraud legend is about to unfold!";
            string message17 = "SALIX: A world of dreams and adventures with Pokefraud awaits! Let's go!";            
            ScrollMessage(message16, 50, 1500, GBText, GBBackground);
            ScrollMessage(message17, 50, 1500, GBText, GBBackground);            

            #endregion

            InstantMessage("Press any key to continue..", GBText, GBBackground);
                
            navPlayerMenu = Console.ReadKey().Key;

            SFX.Route2();
            Maps.DEMOMap(player, rival, currentPosX, currentPosY, navPlayerMenu, GBText, GBBackground);
        }

        #endregion

        #region METHODS: Screen Control

        public static void BattleIntroFLASH(Player player, int direction, int currentPosX, int currentPosY, string[] Map)
        {
            Console.SetCursorPosition(0, 0);
            GameMap(Map, currentPosX, currentPosY, ConsoleColor.White, ConsoleColor.Black);


            PlayerMovement(player, direction, ConsoleColor.White, ConsoleColor.Black);
            System.Threading.Thread.Sleep(200);

            Console.SetCursorPosition(0, 0);
            GameMap(Map, currentPosX, currentPosY, ConsoleColor.Black, ConsoleColor.White);


            PlayerMovement(player, direction, ConsoleColor.Black, ConsoleColor.White);
            System.Threading.Thread.Sleep(200);

            Console.SetCursorPosition(0, 0);
            GameMap(Map, currentPosX, currentPosY, ConsoleColor.White, ConsoleColor.Black);


            PlayerMovement(player, direction, ConsoleColor.White, ConsoleColor.Black);
            System.Threading.Thread.Sleep(200);

            Console.SetCursorPosition(0, 0);
            GameMap(Map, currentPosX, currentPosY, ConsoleColor.Black, ConsoleColor.White);


            PlayerMovement(player, direction, ConsoleColor.Black, ConsoleColor.White);
            System.Threading.Thread.Sleep(200);

            Console.SetCursorPosition(0, 0);
            GameMap(Map, currentPosX, currentPosY, ConsoleColor.White, ConsoleColor.Black);


            PlayerMovement(player, direction, ConsoleColor.White, ConsoleColor.Black);
            System.Threading.Thread.Sleep(200);

            Console.SetCursorPosition(0, 0);
            GameMap(Map, currentPosX, currentPosY, ConsoleColor.Black, ConsoleColor.White);


            PlayerMovement(player, direction, ConsoleColor.Black, ConsoleColor.White);
            System.Threading.Thread.Sleep(200);

            Console.SetCursorPosition(0, 0);
            GameMap(Map, currentPosX, currentPosY, ConsoleColor.White, ConsoleColor.Black);


            PlayerMovement(player, direction, ConsoleColor.White, ConsoleColor.Black);
            System.Threading.Thread.Sleep(200);

            Console.SetCursorPosition(0, 0);
            GameMap(Map, currentPosX, currentPosY, ConsoleColor.Black, ConsoleColor.White);


            PlayerMovement(player, direction, ConsoleColor.Black, ConsoleColor.White);
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
            Console.SetCursorPosition(90, 42);
        }

        public static void PlayerForward(ConsoleColor gbText, ConsoleColor gbBackground)
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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);
        }

        public static void PlayerMovement(Player player, int direction, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            //If the player gender == Male USE the Male movement animations, else use the female animations
            //Create an updating int that knows which foot to step forward when going forwards or backwards
            //OR Just for the UP and DOWN movements, display two frames

            #region Male Movement
            string[] MoveRight1 = new string[]
            {
                "▄▄███▄ ",                  //"▄▄███▄ ",
                "▀██","▄","▀",              // "▀██▄▀",
                "▄","███","▀",              // "▄███▀",
                "▀   ▀"                     // "▀   ▀"  
            };
            string[] MoveRight2 = new string[]
            {
                 "▄▄███▄ ",                 //"▄▄███▄ ",
                 "▀██","▄","▀",             // "▀██▄▀",
                 " ","█▀█"," ",             // " █▀█ ",
                 " ▀ ▀ "                    // " ▀ ▀ "  
            };
            string[] MoveLeft1 = new string[]
            {
                 " ▄███▄▄",                 //" ▄███▄▄",
                 "▀","▄","██▀",             // "▀▄██▀", 
                 "▀","███▄",                // "▀███▄", 
                 "▀   ▀"                    // "▀   ▀"  
            };
            string[] MoveLeft2 = new string[]
            {
                 " ▄███▄▄",                 //" ▄███▄▄",
                  "▀","▄","██▀",            // "▀▄██▀",
                  " █","▀","█ ",            // " █▀█ ",
                  " ▀ ▀ "                   // " ▀ ▀ "  
            };
            string[] MoveUpRF = new string[]
            {
                 " ▄███▄ ",                 //" ▄███▄ ",         //" ▄███▄ ",
                  "▀███▀",                  // "▀███▀",          // "▀███▀", 
                  "▀███▀",                  // "▀███▀",          // "▀███▀", 
                  " █   "                   // " ▀ █ "           // " ▀ ▀ "  
            };
            string[] MoveUpLF = new string[]
{
                 " ▄███▄ ",                 //" ▄███▄ ",         //" ▄███▄ ",
                  "▀███▀",                  // "▀███▀",          // "▀███▀", 
                  "▀███▀",                  // "▀███▀",          // "▀███▀", 
                  "   █ "                   // " ▀ █ "           // " ▀ ▀ "  
};
            string[] MoveUpIdle = new string[]
            {
                 " ▄███▄ ",                 //" ▄███▄ ",         //" ▄███▄ ",
                  "▀███▀",                  // "▀███▀",          // "▀███▀", 
                  "▀███▀",                  // "▀███▀",          // "▀███▀", 
                  " ▀ ▀ "                   // " ▀ █ "           // " ▀ ▀ "  
            };
            string[] MoveDownRF = new string[]
            {
                 " ▄███▄ ",                 //" ▄███▄ ",         //" ▄███▄ ",
                  "▀","▄█▄","▀",            // "▀▄█▄▀",          // "▀███▀", 
                  "▀███▀",                  // "▀███▀",          // "▀███▀", 
                  " █   "                   // " ▀ █ "           // " ▀ ▀ "  
            };
            string[] MoveDownLF = new string[]
{
                 " ▄███▄ ",                 //" ▄███▄ ",         //" ▄███▄ ",
                  "▀","▄█▄","▀",            // "▀▄█▄▀",          // "▀███▀", 
                  "▀███▀",                  // "▀███▀",          // "▀███▀", 
                  "   █ "                   // " ▀ █ "           // " ▀ ▀ "  
};
            string[] MoveDownIdle = new string[]
            {
                 " ▄███▄ ",                 //" ▄███▄ ",         //" ▄███▄ ",
                  "▀","▄█▄","▀",            // "▀███▀",          // "▀███▀", 
                  "▀███▀",                  // "▀███▀",          // "▀███▀", 
                  " ▀ ▀ "                   // " ▀ █ "           // " ▀ ▀ "  
            };
            #endregion

            //TODO Create Female Version

            //1 = Move Left
            //2 = Move Right
            //3 = Move Up RF
            //4 = Move Up LF
            //5 = Move Down RF
            //6 = Move Down LF
            if (direction == 1 && player.Gender == '♂')
            {
                #region MOVING LEFT
                //HAT *SAME COLOR SCEME
                Console.SetCursorPosition(42, 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveLeft1[0]);

                //HEAD *SAME COLOR SCEME
                Console.SetCursorPosition(43, 11);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(MoveLeft1[1]);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(MoveLeft1[2]);

                Console.BackgroundColor = gbBackground;
                Console.Write(MoveLeft1[3]);

                //SHIRT
                Console.SetCursorPosition(43, 12);
                Console.Write(MoveLeft1[4]);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(MoveLeft1[5]);

                //PANTS
                Console.SetCursorPosition(43, 13);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(MoveLeft1[6]);

                Console.SetCursorPosition(90, 42);
                #endregion
                System.Threading.Thread.Sleep(100);
                #region IDLE LEFT
                //HAT
                Console.SetCursorPosition(42, 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveLeft2[0]);

                //HEAD
                Console.SetCursorPosition(43, 11);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(MoveLeft2[1]);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(MoveLeft2[2]);

                Console.BackgroundColor = gbBackground;
                Console.Write(MoveLeft2[3]);

                //SHIRT
                Console.SetCursorPosition(43, 12);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(MoveLeft2[4]);

                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(MoveLeft2[5]);

                Console.BackgroundColor = gbBackground;
                Console.Write(MoveLeft2[6]);

                //PANTS
                Console.SetCursorPosition(43, 13);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(MoveLeft2[7]);

                Console.SetCursorPosition(90, 42);
                #endregion
            }
            if (direction == 2 && player.Gender == '♂')
            {
                #region MOVING RIGHT
                //HAT
                Console.SetCursorPosition(42, 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveRight1[0]);

                //HEAD
                Console.SetCursorPosition(43, 11);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(MoveRight1[1]);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(MoveRight1[2]);

                Console.BackgroundColor = gbBackground;
                Console.Write(MoveRight1[3]);

                //SHIRT
                Console.SetCursorPosition(43, 12);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(MoveRight1[4]);
                Console.Write(MoveRight1[5]);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(MoveRight1[6]);

                //PANTS
                Console.SetCursorPosition(43, 13);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(MoveRight1[7]);

                Console.SetCursorPosition(90, 42);
                #endregion
                System.Threading.Thread.Sleep(100);
                #region IDLE RIGHT
                //HAT
                Console.SetCursorPosition(42, 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveRight2[0]);

                //HEAD
                Console.SetCursorPosition(43, 11);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(MoveRight2[1]);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(MoveRight2[2]);

                Console.BackgroundColor = gbBackground;
                Console.Write(MoveRight2[3]);

                //SHIRT
                Console.SetCursorPosition(43, 12);
                Console.Write(MoveRight2[4]);

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(MoveRight2[5]);

                Console.BackgroundColor = gbBackground;
                Console.Write(MoveRight2[6]);

                //PANTS
                Console.SetCursorPosition(43, 13);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(MoveRight2[7]);

                Console.SetCursorPosition(90, 42);
                #endregion
            }
            if (direction == 3 && player.Gender == '♂')
            {
                #region MOVING UP RF
                //HAT *SAME COLOR SCEME
                Console.SetCursorPosition(42, 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveUpRF[0]);

                //HEAD *SAME COLOR SCEME
                Console.SetCursorPosition(43, 11);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(MoveUpRF[1]);

                //SHIRT
                Console.SetCursorPosition(43, 12);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(MoveUpRF[2]);

                //PANTS
                Console.SetCursorPosition(43, 13);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveUpRF[3]);

                Console.SetCursorPosition(90, 42);
                #endregion
                System.Threading.Thread.Sleep(50);
                #region IDLE UP
                //HAT *SAME COLOR SCEME
                Console.SetCursorPosition(42, 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveUpIdle[0]);

                //HEAD *SAME COLOR SCEME
                Console.SetCursorPosition(43, 11);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(MoveUpIdle[1]);

                //SHIRT
                Console.SetCursorPosition(43, 12);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(MoveUpIdle[2]);

                //PANTS
                Console.SetCursorPosition(43, 13);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveUpIdle[3]);

                Console.SetCursorPosition(90, 42);
                #endregion
            }
            if (direction == 4 && player.Gender == '♂')
            {
                #region MOVING UP LF
                //HAT *SAME COLOR SCEME
                Console.SetCursorPosition(42, 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveUpLF[0]);

                //HEAD *SAME COLOR SCEME
                Console.SetCursorPosition(43, 11);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(MoveUpLF[1]);

                //SHIRT
                Console.SetCursorPosition(43, 12);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(MoveUpLF[2]);

                //PANTS
                Console.SetCursorPosition(43, 13);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveUpLF[3]);

                Console.SetCursorPosition(90, 42);
                #endregion
                System.Threading.Thread.Sleep(50);
                #region IDLE UP
                //HAT *SAME COLOR SCEME
                Console.SetCursorPosition(42, 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveUpIdle[0]);

                //HEAD *SAME COLOR SCEME
                Console.SetCursorPosition(43, 11);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(MoveUpIdle[1]);

                //SHIRT
                Console.SetCursorPosition(43, 12);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(MoveUpIdle[2]);

                //PANTS
                Console.SetCursorPosition(43, 13);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveUpIdle[3]);

                Console.SetCursorPosition(90, 42);
                #endregion
            }
            if (direction == 5 && player.Gender == '♂')
            {
                #region MOVING DOWN RF
                //HAT *SAME COLOR SCEME
                Console.SetCursorPosition(42, 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveDownRF[0]);

                //HEAD *SAME COLOR SCEME
                Console.SetCursorPosition(43, 11);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(MoveDownRF[1]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(MoveDownRF[2]);
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveDownRF[3]);

                //SHIRT
                Console.SetCursorPosition(43, 12);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(MoveDownRF[4]);

                //PANTS
                Console.SetCursorPosition(43, 13);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveDownRF[5]);

                Console.SetCursorPosition(90, 42);
                #endregion
                System.Threading.Thread.Sleep(100);
                #region IDLE DOWN
                //HAT *SAME COLOR SCEME
                Console.SetCursorPosition(42, 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveDownIdle[0]);

                //HEAD *SAME COLOR SCEME
                Console.SetCursorPosition(43, 11);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(MoveDownIdle[1]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(MoveDownIdle[2]);
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveDownIdle[3]);

                //SHIRT
                Console.SetCursorPosition(43, 12);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(MoveDownIdle[4]);

                //PANTS
                Console.SetCursorPosition(43, 13);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveDownIdle[5]);

                Console.SetCursorPosition(90, 42);
                #endregion
            }
            if (direction == 6 && player.Gender == '♂')
            {
                #region MOVING DOWN LF
                //HAT *SAME COLOR SCEME
                Console.SetCursorPosition(42, 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveDownLF[0]);

                //HEAD *SAME COLOR SCEME
                Console.SetCursorPosition(43, 11);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(MoveDownLF[1]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(MoveDownLF[2]);
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveDownLF[3]);

                //SHIRT
                Console.SetCursorPosition(43, 12);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(MoveDownLF[4]);

                //PANTS
                Console.SetCursorPosition(43, 13);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveDownLF[5]);

                Console.SetCursorPosition(90, 42);
                #endregion
                System.Threading.Thread.Sleep(100);
                #region IDLE DOWN
                //HAT *SAME COLOR SCEME
                Console.SetCursorPosition(42, 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveDownIdle[0]);

                //HEAD *SAME COLOR SCEME
                Console.SetCursorPosition(43, 11);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(MoveDownIdle[1]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(MoveDownIdle[2]);
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveDownIdle[3]);

                //SHIRT
                Console.SetCursorPosition(43, 12);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(MoveDownIdle[4]);

                //PANTS
                Console.SetCursorPosition(43, 13);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = gbBackground;
                Console.Write(MoveDownIdle[5]);

                Console.SetCursorPosition(90, 42);
                #endregion
            }
        }

        public static void RegionNoEncounter(string[] Map, Player player, int currentPosX, int currentPosY, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;

            do
            {
                Console.SetBufferSize(2000, 2000);
                GameMap(Map, currentPosX, currentPosY, gbText, gbBackground);
                PlayerForward(gbText, gbBackground);
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
                GameMap(Map, currentPosX, currentPosY, gbText, gbBackground);
                PlayerForward(gbText, gbBackground);
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
                            BattleIntroFLASH(player, direction, currentPosX, currentPosY, Map);
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
                            BattleIntroFLASH(player, direction, currentPosX, currentPosY, Map);
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
                            BattleIntroFLASH(player, direction, currentPosX, currentPosY, Map);
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
                            BattleIntroFLASH(player, direction, currentPosX, currentPosY, Map);
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
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = GBColor;
            Console.Write(TEMGameBoy);
            Console.SetCursorPosition(90, 42);
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
            Console.SetCursorPosition(90, 42);
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
                "                                                                                   ",
                "                                                                                   "
            };
            foreach (string item in screen)
            {
                Console.SetCursorPosition(4, posY);
                Console.Write(item);
                Console.SetCursorPosition(90, 42);
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
            Console.SetCursorPosition(90, 42);
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
            Console.SetCursorPosition(90, 42);
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
            Console.SetCursorPosition(90, 42);
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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

            System.Threading.Thread.Sleep(delay);

            Console.SetCursorPosition(positionX, positionY);
            Console.Write("         ");
            Console.SetCursorPosition(positionX, positionY + 1);
            Console.Write("         ");
            Console.SetCursorPosition(positionX, positionY + 2);
            Console.Write("         ");
            Console.SetCursorPosition(positionX, positionY + 3);
            Console.Write("         ");
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);
        }

        public static void BallOpenClose(int positionX, int positionY, int delay, ConsoleColor gbText)
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


            Console.ForegroundColor = gbText;
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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

            #endregion
            System.Threading.Thread.Sleep(delay);
        }

        public static void BallBreak(int positionX, int positionY, int delay, ConsoleColor gbText, ConsoleColor gbBackground)
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

            Console.ForegroundColor = gbText;
            #region Frame One

            Console.SetCursorPosition(positionX - 6, positionY);
            Console.Write(frameONE[0]);
            Console.SetCursorPosition(positionX - 6, positionY + 1);
            Console.Write(frameONE[1]);
            Console.SetCursorPosition(positionX - 6, positionY + 2);
            Console.Write(frameONE[2]);
            Console.SetCursorPosition(positionX - 6, positionY + 3);
            Console.Write(frameONE[3]);
            Console.SetCursorPosition(90, 42);

            #endregion            
            System.Threading.Thread.Sleep(delay);
            #region Frame Two

            Console.SetCursorPosition(positionX - 6, positionY);
            Console.Write(frameTWO[0]);
            Console.SetCursorPosition(positionX - 6, positionY + 1);
            Console.Write(frameTWO[1]);
            Console.SetCursorPosition(positionX - 6, positionY + 2);
            Console.Write(frameTWO[2]);
            Console.SetCursorPosition(positionX - 6, positionY + 3);
            Console.Write(frameTWO[3]);
            Console.SetCursorPosition(90, 42);

            #endregion            
            System.Threading.Thread.Sleep(delay);
            #region Frame Three

            Console.SetCursorPosition(positionX - 6, positionY);
            Console.Write(frameTHREE[0]);
            Console.SetCursorPosition(positionX - 6, positionY + 1);
            Console.Write(frameTHREE[1]);
            Console.SetCursorPosition(positionX - 6, positionY + 2);
            Console.Write(frameTHREE[2]);
            Console.SetCursorPosition(positionX - 6, positionY + 3);
            Console.Write(frameTHREE[3]);
            Console.SetCursorPosition(90, 42);

            #endregion
            System.Threading.Thread.Sleep(delay);
            #region Frame Four

            Console.SetCursorPosition(positionX - 6, positionY);
            Console.Write(frameFOUR[0]);
            Console.SetCursorPosition(positionX - 6, positionY + 1);
            Console.Write(frameFOUR[1]);
            Console.SetCursorPosition(positionX - 6, positionY + 2);
            Console.Write(frameFOUR[2]);
            Console.SetCursorPosition(positionX - 6, positionY + 3);
            Console.Write(frameFOUR[3]);
            Console.SetCursorPosition(90, 42);

            #endregion
            System.Threading.Thread.Sleep(delay);
            #region Frame Four

            Console.SetCursorPosition(positionX - 6, positionY);
            Console.Write(frameFIVE[0]);
            Console.SetCursorPosition(positionX - 6, positionY + 1);
            Console.Write(frameFIVE[1]);
            Console.SetCursorPosition(positionX - 6, positionY + 2);
            Console.Write(frameFIVE[2]);
            Console.SetCursorPosition(positionX - 6, positionY + 3);
            Console.Write(frameFIVE[3]);
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);
        }

        public static void ExpBar(Monster monster, int positionX, int positionY)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            if (monster.Exp == monster.MaxExp)
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("====================");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.95 * monster.MaxExp) && monster.Exp > (.9 * monster.MaxExp))
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("=================== ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.9 * monster.MaxExp) && monster.Exp > (.85 * monster.MaxExp))
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("==================  ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.85 * monster.MaxExp) && monster.Exp > (.8 * monster.MaxExp))
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("=================   ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.8 * monster.MaxExp) && monster.Exp > (.75 * monster.MaxExp))
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("================    ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.75 * monster.MaxExp) && monster.Exp > (.7 * monster.MaxExp))
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("===============     ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.7 * monster.MaxExp) && monster.Exp > (.65 * monster.MaxExp))
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("==============      ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.65 * monster.MaxExp) && monster.Exp > (.6 * monster.MaxExp))
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("=============       ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.6 * monster.MaxExp) && monster.Exp > (.55 * monster.MaxExp))
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("============        ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.55 * monster.MaxExp) && monster.Exp > (.5 * monster.MaxExp))
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("===========         ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.5 * monster.MaxExp) && monster.Exp > (.45 * monster.MaxExp))
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("==========          ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.45 * monster.MaxExp) && monster.Exp > (.4 * monster.MaxExp))
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("=========           ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.4 * monster.MaxExp) && monster.Exp > (.35 * monster.MaxExp))
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("========            ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.35 * monster.MaxExp) && monster.Exp > (.3 * monster.MaxExp))
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("=======             ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.3 * monster.MaxExp) && monster.Exp > (.25 * monster.MaxExp))
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("======              ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.25 * monster.MaxExp) && monster.Exp > (.2 * monster.MaxExp))
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("=====               ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.2 * monster.MaxExp) && monster.Exp > (.15 * monster.MaxExp))
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("====                ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.15 * monster.MaxExp) && monster.Exp > (.1 * monster.MaxExp))
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("===                 ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.1 * monster.MaxExp) && monster.Exp > (.05 * monster.MaxExp))
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("==                  ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= (.05 * monster.MaxExp) && monster.Exp > (0 * monster.MaxExp))
            {
                Console.Write("EXP[");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("=                   ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("]");
            }
            else if (monster.Exp <= 0)
            {
                Console.Write("EXP[                    ]");
            }
            Console.SetCursorPosition(90, 42);
        }


        /****TO BE USED NEXT TO Health BAR DURING COMBAT IF DESIRED****/
        public static void Health(Monster monster, int positionX, int positionY, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.Write($"{monster.Health}/{monster.MaxHealth}");
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

        public static void Type(Monster_Race type, int positionX, int positionY, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.ForegroundColor = ConsoleColor.White;
            switch (type)
            {
                case Monster_Race.Fire:
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case Monster_Race.Water:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case Monster_Race.Electric:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case Monster_Race.Ground:
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    break;
                case Monster_Race.Psychic:
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    break;
            }
            Console.Write(" " + type + " ");
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
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
            Console.SetCursorPosition(90, 42);
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
            Console.SetCursorPosition(90, 42);
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
            Console.SetCursorPosition(90, 42);
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
            Console.SetCursorPosition(90, 42);
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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);
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
            Console.SetCursorPosition(90, 42);
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
            Console.SetCursorPosition(90, 42);
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
            Console.SetCursorPosition(90, 42);
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
            PokeBallANI(61, 6, 500, gbBackground);
            BallOpenClose(57, 3, 50, gbText);
            PokeBallANI(61, 6, 250, gbBackground);
            PokeBallANI(61, 7, 50, gbBackground);
            PokeBallANI(61, 8, 50, gbBackground);
            PokeBallANI(61, 9, 50, gbBackground);
            PokeBallANI(61, 8, 50, gbBackground);
            PokeBallANI(61, 9, 1500, gbBackground);
        }

        public static void BallShakeLeft(ConsoleColor gbBackground)
        {
            BallFaceLeft(61, 9, 500, gbBackground);
            PokeBallANI(61, 9, 1000, gbBackground);
            Console.SetCursorPosition(90, 42);
        }

        public static void BallShakeRight(ConsoleColor gbBackground)
        {
            BallFaceRight(62, 9, 500, gbBackground);
            PokeBallANI(61, 9, 1000, gbBackground);
            Console.SetCursorPosition(90, 42);
        }

        public static void ANIAttackerSwitch(ConsoleColor gbText, ConsoleColor gbBackground)
        {
            PokeBallANI(12, 13, 50, gbBackground);
            PokeBallANI(12, 14, 50, gbBackground);
            PokeBallANI(12, 15, 50, gbBackground);
            PokeBallANI(12, 16, 50, gbBackground);
            PokeBallANI(12, 17, 50, gbBackground);
            PokeBallANI(12, 16, 50, gbBackground);
            PokeBallANI(12, 17, 1000, gbBackground);
            BallBreak(12, 16, 50, gbText, gbBackground);
        }

        public static void ANIDefenderSwitch(ConsoleColor gbText, ConsoleColor gbBackground)
        {
            PokeBallANI(60, 5, 50, gbBackground);
            PokeBallANI(60, 6, 50, gbBackground);
            PokeBallANI(60, 7, 50, gbBackground);
            PokeBallANI(60, 8, 50, gbBackground);
            PokeBallANI(60, 9, 50, gbBackground);
            PokeBallANI(60, 8, 50, gbBackground);
            PokeBallANI(60, 9, 1000, gbBackground);
            BallBreak(60, 8, 50, gbText, gbBackground);
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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);
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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);

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
            Console.SetCursorPosition(90, 42);
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
                Console.SetCursorPosition(90, 42);
                startPositionX -= 1;
                System.Threading.Thread.Sleep(1);
            }
            DISDefenderInfoBar(monster, gbText, gbBackground);
            ScrollMessage(message, 50, 1500, gbText, gbBackground);
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
                Console.SetCursorPosition(90, 42);
                startPositionX -= 1;
                System.Threading.Thread.Sleep(1);
            }
            ScrollMessage(message, 50, 1500, gbText, gbBackground);
        }

        public static void ANINPCSend(Player npc, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            string message = $"{npc.Name} sent out {npc.Party.MonsterEquipped.Name}!";
            ScrollMessage(message, 50, 1500, gbText, gbBackground);
            ANIDefenderSwitch(gbText, gbBackground);
            DISDefender(npc.Party.MonsterEquipped, gbText, gbBackground);
        }

        public static void ANIPlayerSend(Player player, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            string message = $"{player.Name} sent out {player.Party.MonsterEquipped.Name}!";
            ScrollMessage(message, 50, 1500, gbText, gbBackground);
            ANIAttackerSwitch(gbText, gbBackground);
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
                Console.SetCursorPosition(90, 42);
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
                Console.SetCursorPosition(90, 42);
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
                Console.SetCursorPosition(90, 42);
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
                Console.SetCursorPosition(90, 42);
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
                Console.SetCursorPosition(90, 42);
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
            Combat.DoAttackMonster(monster, player, monster.EquippedMoves.Move1, gbText, gbBackground);
        }

        public static void ANIPlayerSwitchSendTEST(Player player, int slot, Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            string message = $"{player.Party.MonsterEquipped.Name.ToUpper()} return!";
            if (player.Party.MonsterEquipped.Health >= 0)
            {
                if (monster.Health > 0)
                {
                    DISATTandDEF(player, monster, gbText, gbBackground);
                    ScrollMessage(message, 50, 1000, gbText, gbBackground);
                    ANIReturn(6, 13, gbText, gbBackground);
                }
                else
                {
                    DISJustAttacker(player, gbText, gbBackground);
                    ScrollMessage(message, 50, 1000, gbText, gbBackground);
                    ANIReturn(6, 13, gbText, gbBackground);
                }
            }
            ResetHalfScreen(11, gbText, gbBackground);
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
            if (monster.Health > 0)
            {
                Combat.DoAttackMonster(monster, player, monster.EquippedMoves.Move1, gbText, gbBackground);
            }            
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

        public static void ANINPCNext(Player player, Player npc, int slot, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {                        
            string message = "";
            if (slot == 2)
            {
                message = $"{npc.Name.ToUpper()} is about to send {npc.Party.Slot2.Name.ToUpper()}.";
            }
            if (slot == 3)
            {
                message = $"{npc.Name.ToUpper()} is about to send {npc.Party.Slot3.Name.ToUpper()}.";
            }
            if (slot == 4)
            {
                message = $"{npc.Name.ToUpper()} is about to send {npc.Party.Slot4.Name.ToUpper()}.";
            }
            if (slot == 5)
            {
                message = $"{npc.Name.ToUpper()} is about to send {npc.Party.Slot5.Name.ToUpper()}.";
            }
            if (slot == 6)
            {
                message = $"{npc.Name.ToUpper()} is about to send {npc.Party.Slot6.Name.ToUpper()}.";
            }
            string message1 = $"Will you send out another Pokefraud?";
            ScrollMessage(message, 50, 1500, gbText, gbBackground);
            ScrollMessage(message1, 50, 500, gbText, gbBackground);
            Player_Menus.QueSwitch(player, npc.Party.MonsterEquipped, 0, navPlayerMenu, gbText, gbBackground);
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
            ASCII.DISJustAttacker(player, gbText, gbBackground);
            ANINPCSend(npc, gbText, gbBackground);
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
            System.Threading.Thread.Sleep(500);
            ANIPlayerSend(player, gbText, gbBackground);
            System.Threading.Thread.Sleep(500);
        }

        public static void NPCEncounter(Player player, Player npc, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            ResetScreen(gbText, gbBackground);
            ANINPCAppear(npc, gbText, gbBackground);
            ANINPCSend(npc, gbText, gbBackground);
            System.Threading.Thread.Sleep(500);
            ANIPlayerSend(player, gbText, gbBackground);
            System.Threading.Thread.Sleep(500);
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

            WildEncounter(player, defender, gbText, gbBackground);
            Player_Menus.FightMenu(player, defender, navPlayerMenu, gbText, gbBackground);
        }

        public static void FullBattleNPC(Player player, Player npc, ConsoleColor gbText, ConsoleColor gbBackground, ConsoleKey navPlayerMenu)
        {
            NPCEncounter(player, npc, gbText, gbBackground);
            Player_Menus.NPCFightMenu(player, npc, 500, navPlayerMenu, gbText, gbBackground);
        }

        #endregion

        #endregion

        #region METHODS: Display Objects

        public static void PCMain(Player player, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadPC = false;
            int posX = 66;
            int posY = 3;            
            posY = 4;
            do
            {
                int navY = 3;
                foreach (string line in pcMain)
                {
                    Console.SetCursorPosition(posX, navY);
                    Console.Write(line);
                    navY += 1;
                }
                Console.SetCursorPosition(69, 4);
                Console.Write(player.Name.ToUpper() + "'S PC");
                Console.SetCursorPosition(90, 42);
                Console.SetCursorPosition(67, posY);
                Console.Write(">");
                Console.SetCursorPosition(90, 42);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(67, posY);
                        Console.Write(" ");
                        posY -= 1;
                        if (posY == 3)
                        {
                            posY += 1;
                        }
                        reloadPC = true;
                        break;
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(67, posY);
                        Console.Write(" ");
                        posY += 1;
                        if (posY == 8)
                        {
                            posY -= 1;
                        }
                        reloadPC = true;
                        break;
                    case ConsoleKey.Enter:
                        //Loads Player Monster PC
                        if (posY == 4)
                        {
                            Player_Menus.PlayerPC(player, new Monster(), navPlayerMenu, gbText, gbBackground);
                            reloadPC = false;
                        }
                        //Loads Professor PC
                        if (posY == 5)
                        {
                            reloadPC = true;
                        }
                        //Loads Hall of Fame PC
                        if (posY == 6)
                        {
                            reloadPC = true;
                        }
                        //Swithes off PC
                        if (posY == 7)
                        {
                            reloadPC = false;
                        }
                        break;
                    default:
                        reloadPC = false;
                        break;
                }
            } while (reloadPC);           
        }

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
            Console.SetCursorPosition(90, 42);
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
                Console.SetCursorPosition(90, 42);
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
            //Console.SetCursorPosition(90, 42);
            #endregion
        }

        public static void CharacterMerchant(int posX, int posY, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            //(42, 10) **Top Left of Player at Center Screen
            //(4,2) **Top Left of Screen
            //(87,25) **Bottom Right of Screen

            string[] defaultMale = new string[]
            {
                "█",
                "▀▀▀", //TOP
                "█",

                "█",
                "▄█▄", //MIDDLE
                "█",

                "▀",
                "█▄█", //BOTTOM
                "▀"
            };

            if (posX <= 80 && posX >= 4 && posY <= 21 && posY >= 2)
            {
                #region IF ON SCREEN                
                Console.SetCursorPosition(posX + 1, posY);
                Console.BackgroundColor = gbBackground;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(defaultMale[0]);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(defaultMale[1]);
                Console.BackgroundColor = gbBackground;
                Console.Write(defaultMale[2]);

                Console.SetCursorPosition(posX + 1, posY + 1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(defaultMale[3]);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(defaultMale[4]);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(defaultMale[5]);

                Console.SetCursorPosition(posX + 1, posY + 2);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.BackgroundColor = gbBackground;
                Console.Write(defaultMale[6]);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(defaultMale[7]);
                Console.BackgroundColor = gbBackground;
                Console.Write(defaultMale[8]);
                Console.SetCursorPosition(90, 42);
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
            //Console.SetCursorPosition(90, 42);
            #endregion
        }

        public static void CharacterPokeCenter(int posX, int posY, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            //(42, 10) **Top Left of Player at Center Screen
            //(4,2) **Top Left of Screen
            //(87,25) **Bottom Right of Screen

            string[] defaultMale = new string[]
            {
                "▄███▄",
                "▀",
                "▄█▄",
                "▀",
                "▀",
                "█▄█",
                "▀"
            };

            if (posX <= 80 && posX >= 4 && posY <= 21 && posY >= 2)
            {
                #region IF ON SCREEN
                Console.BackgroundColor = gbBackground;
                Console.SetCursorPosition(posX + 1, posY);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(defaultMale[0]);

                Console.SetCursorPosition(posX + 1, posY + 1);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(defaultMale[1]);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(defaultMale[2]);
                Console.BackgroundColor = gbBackground;
                Console.Write(defaultMale[3]);

                Console.SetCursorPosition(posX + 1, posY + 2);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.BackgroundColor = gbBackground;
                Console.Write(defaultMale[4]);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(defaultMale[5]);
                Console.BackgroundColor = gbBackground;
                Console.Write(defaultMale[6]);
                Console.SetCursorPosition(90, 42);
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
            //Console.SetCursorPosition(90, 42);
            #endregion
        }
        #endregion

        #region ASCII: String[] Templates

        #region Characters

        public static string[] playerMale = new string[]
        {
            " ▄▄██▀▀██▄▄ ",
            " ████ ▄████ ",
            "█▀ ▀█▀▀█▀ ▀█",
            "▀▄  ▀  ▀  ▄▀ ",
            " ▄▀▄▄▄▄▄▄▀▄ ",
            "█ ▄  ▀▀  ▄ █",
            "▀▄▀▄▄▄▄▄▄▀▄▀",
            "  █  ▄▄  █  ",
            "  ▀▄▄▀▀▄▄▀  "
        };

        public static string[] playerFemale = new string[]
        {
            " ▄▄██▀▀██▄▄ ",
            " ████ ▄████ ",
            "█▀ ▀█▀▀█▀ ▀█",
            "▀▄  ▀  ▀  ▄▀ ",
            " ▄▀▄▄▄▄▄▄▀▄ ",
            "█ ▄  ▀▀  ▄ █",
            "▀▄▀▄▄▄▄▄▄▀▄▀",
            "  █  ▄▄  █  ",
            "  ▀▄▄▀▀▄▄▀  "
        };

        public static string[] Professor = new string[]
        {
            " ███████▄▄  ",
            " ██████████ ",
            "█▀ ▀▄  ▄▀ ▀█",
            "▀▄  ▀  ▀  ▄▀ ",
            " ▄▀▄▄▄▄▄▄▀▄ ",
            "█ ▄      ▄ █",
            "▀▄▀▄▄▄▄▄▄▀▄▀",
            "  █  ▄▄  █  ",
            "  ▀▄▄▀▀▄▄▀  "
        };

        public static string[] Rival = new string[]
{
            " ▀████████▄  ",
            "▀████████████ ",
            " █▀  ▄  ▄  ▀█ ",
            " ▀▄  ▀  ▀  ▄▀ ",
            "  ▄▀▄▄▄▄▄▄▀▄ ",
            " █ ▄  ▀▀  ▄ █",
            " ▀▄▀▄▄▄▄▄▄▀▄▀",
            "   █  ▄▄  █  ",
            "   ▀▄▄▀▀▄▄▀  "
};


        #endregion

        #region Display Art

        public static string[] Title = new string[]
            {
                "                                  ▄▀▄                                          ",
                "    ▄▄▀▀▀▀▄        ▄▄▄▄         ▄▀  ▄█       ▄▄▀▀▀▀▄                           ",
                "_▄▄▀       ▀▄     █    █  █▀▄  ▀▄▄▀▀     ▄▄▀▀      █                      █▀▀▄▄",
                "█      ▄▄    █    ▀▄▄  █ █   ▀▄  ▄▄▄    █        ▄▄█                      █   █",
                " ██    █ █   █  ▄▄  █  ██    ▄▀▄▀▄  ▀▄  █   ▄▄▀▀▀            ▄▄           █   █",
                "   █    █▀   █▄▀ ▄▀▄█      ▄▀ █ █ █ █   █  █▄▄▀█▀▀▀▄▄   ▄▄▄█▀▄ █ █▀▄▄ ▄▄▄ █   █",
                "    █     ▄▀▀█  █ █ █    ▄▀  █  ▀█ █ ▄▀▄█   ▄▄▀█  ▄▄ ██▀ ▄▄  █ █ █  █▀   ▀    █",
                "     █    █ █   ▀▄▀  █    ▀▄  █    ▀▀  ██  █   █  █ ▀█  █  █ █ ▀▄▀  █   ▄▀▀▄  █",
                "      █    █ █      █       ▀▀▄▀▄▄▄▄▄▄▀ █  █   █▄▄█  █   ▀▀  ▀▄▄▄▄▄▀ █   ▀▀   █",
                "       █    █ ▀▄▄▄▄▀█  █▀▄▄    ▀▀█      █▄▄█          ▀▄▄▄▄▀▄▀        ▀▀▄▄▄▀▄▄█",
                "        █▄▄▀▀       █▄▄█   ▀▀▄▄▄ █                                             ",
                "                                ▀▀                                             ",
                "                                                                               ",
                "                 ▄▀▀▀▄   █   █   ▄▀▀▄   █▀▀▄   ▀▀█▀▀   ▀█▀▀▀▀▀                 ",
                "                 █  ▄█   █   █   █▀▀█   █▀▀▄     █       ▀▄                    ",
                "                  ▀▀▀ ▀   ▀▀▀    ▀  ▀   ▀  ▀     ▀   ▀▀▀▀▀▀                    ",
                "                 ▀▀▀▀▀█ █  █▀▀  █▀▄  ▄▀▀  ▀█▀  ▄▀▄  █▄ █▀▀▀▀▀                  ",
                "                      █ █  █▀   █▀▄  ▀▀█   █   █ █  █ ▀█                       ",
                "                       ▀   ▀▀▀  ▀ ▀  ▀▀   ▀▀▀   ▀   ▀  ▀                       "
            };

        #endregion

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

        public static string[] PMPokedexSelectTAB = new string[]
            {
               @"▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄",
               @" █     PokeROLODEX      █",
               @"  █                     █",
               @"   █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @"    █  PARTY            █",
               @"    █                   █",
               @"    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @"    █  BAG              █",
               @"    █                   █",
               @"    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @"    █                   █",
               @"    █                   █",
               @"    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @"    █  EXIT             █",
               @"    █                   █",
               @"    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█"
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

        public static string[] PMPartySelectTAB = new string[]
            {
               @"    ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄",
               @"    █  PokeROLODEX      █",
               @"    █                   █",
               @"▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @" █     PARTY            █",
               @"  █                     █",
               @"   █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @"    █  BAG              █",
               @"    █                   █",
               @"    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @"    █                   █",
               @"    █                   █",
               @"    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @"    █  EXIT             █",
               @"    █                   █",
               @"    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█"
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

        public static string[] PMBagSelectTAB = new string[]
            {
               @"    ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄",
               @"    █  PokeROLODEX      █",
               @"    █                   █",
               @"    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @"    █  PARTY            █",
               @"    █                   █",
               @"▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @" █     BAG              █",
               @"  █                     █",
               @"   █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @"    █                   █",
               @"    █                   █",
               @"    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @"    █  EXIT             █",
               @"    █                   █",
               @"    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█"
            };

        public static string[] PMProfileSelect = new string[]
            {
               @"                                                            ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄  ",
               @"                                                            █  PokeROLODEX      █  ",
               @"                                                            █                   █  ",
               @"                                                            █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"              ▄▀▀▀▀▀▄                  ▄▄▄▄▄▄▄▄▄            █  PARTY            █  ",
               @"             █▄▀▀▄   █              ▄▀▀       █             █                   █  ",
               @"             █▀█▀▀█▀█ ▀▄            █████████  █            █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"         ▄   ▀▄▀  ▀▄▀▀▀▀           █ █ █  █ █ █             █  BAG              █  ",
               @"      ▄██▀     ▀█▀█                █ ▀▄    ▄▀ █             █                   █  ",
               @"       ▀▄▀▄▄▄▄██▀▄███▄            █    ▀█▀█   █         ▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"         ▀▄▄████ ██▀██▀▄         █   ▄▀█▄▄▄▀▄  █         █                      █  ",
               @"             ██  ██  █ █       ▄▀▄▄▄▀▄▀█  █▀▄▀▄ █         █                     █  ",
               @"            ██  ██ ▄█▄▀          ▄▀▄▀  █  █  █ █           █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"           █▄▀▀█▀█  ▀█          ▀██   █   ▀▄  █ █           █  EXIT             █  ",
               @"          █   ▄ ▀▄█                  █▄▄▄▄▄▄█  ██▀          █                   █  ",
               @"         █  ▄▀ ▀▄  █                █▄▄█▄▄█▄█               █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█  ",
               @"         █  █    █  █              █ ▄▀   █ █                                      ",
               @"         █  █     █  █            █▄▀      █ █                                     ",
               @"         █▄██      ██▄█          █▄▀        ██                                     ",
               @"        ▀▀▀▀        ▀▀▀         ▀▀          ▀▀                                     ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   ",
               @"                                                                                   "
            };

        public static string[] PMProfileSelectTAB = new string[]
            {
               @"    ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄",
               @"    █  PokeROLODEX      █",
               @"    █                   █",
               @"    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @"    █  PARTY            █",
               @"    █                   █",
               @"    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @"    █  BAG              █",
               @"    █                   █",
               @"▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @" █                      █",
               @"  █                     █",
               @"   █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @"    █  EXIT             █",
               @"    █                   █",
               @"    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█"
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

        public static string[] PMExitSelectTAB = new string[]
            {
               @"    ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄",
               @"    █  PokeROLODEX      █",
               @"    █                   █",
               @"    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @"    █  PARTY            █",
               @"    █                   █",
               @"    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @"    █  BAG              █",
               @"    █                   █",
               @"    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @"    █                   █",
               @"    █                   █",
               @"▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
               @" █     EXIT             █",
               @"  █                     █",
               @"   █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█"
            };

        #endregion

        #region PC

        public static string[] pcMain = new string[]
        {
            $"█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█",
            $"█                 █",
            $"█  SALIX'S PC     █",
            $"█  HALL OF FAME   █",
            $"█  SWITCH OFF     █",
            $"█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█"
        };

        public static string[] emptyPC = new string[]
            {
                " ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ",
                " █ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄           ▄ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄           █ ",
                " █ █                           █         ▄██ █         1-25        █ ██▄         █ ",
                " █ █▄▄▄▄▄▄▄▄▄▄▄                █          ▀█ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ █▀          █ ",
                " █ █           ▀▄              █                                                 █ ",
                " █ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█ █ ",
                " █ █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█ █                                             █ █ ",
                " █ █                           █ █                                             █ █ ",
                " █ █                           █ █                                             █ █ ",
                " █ █                           █ █                                             █ █ ",
                " █ █                           █ █                                             █ █ ",
                " █ █                           █ █                                             █ █ ",
                " █ █                           █ █                                             █ █ ",
                " █ █                           █ █                                             █ █ ",
                " █ █                           █ █                                             █ █ ",
                " █ █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█ █                                             █ █ ",
                " █ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ █                                             █ █ ",
                " █ █                           █ █                                             █ █ ",
                " █ █ Lv.                       █ █                                             █ █ ",
                " █ █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█ █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█ █ ",
                " █ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ █ ",
                " █ █ TYPE:                     █ █        PARTY       ▄▀ ▄▀        CLOSE       █ █ ",
                " █ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ █ ",
                " ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ "
            };

        #endregion

        #region Player party

        public static string[] partyNoBattle = new string[]
        {
            $"█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█",
            $"█  SUMMARY        █",
            $"█  SWITCH         █",
            $"█  ITEM           █",
            $"█  CANCEL         █",
            $"█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█"
        };

        public static string[] partyBattle = new string[]
        {
            $"█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█",
            $"█  SWITCH         █",
            $"█  CHECK STATS    █",
            $"█  CANCEL         █",
            $"█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█"
        };

        #endregion

        #region Pokedex Entry

        public static string[] pokedexEntry = new string[]
        {//(4,2)
            " ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ",
            " █                   █████████████████             █               █             █ ",
            " █                   █ POKEDEX ENTRY █    STATS    █     MOVES     █    EXIT     █ ",
            " █                   █████████████████▄▄▄▄▄▄▄▄▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄█ ",
            " █                   █                                                           █ ",
            " █                   █            Pokedex No.                                    █ ",
            " █                   █                                                           █ ",
            " █                   █            Name                                           █ ",
            " █                   █                                                           █ ",
            " █                   █            Type                                           █ ",
            " █                   █                                                           █ ",
            " █                   █            OT                                             █ ",
            " █                   █                                                           █ ",
            " █                   █            Exp. Points                                    █ ",
            " █                   █                                                           █ ",
            " █                   █                                                           █ ",
            " █                   █            To Next Lv.                                    █ ",
            " █                   █                                                           █ ",
            " █                   █                                                           █ ",
            " █                   █                                                           █ ",
            " █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█                                                           █ ",
            " █ ITEM              █                                                           █ ",
            " █                   █                                                           █ ",
            " ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ "
        };

        public static string[] pokedexStats = new string[]
        {
            "▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄",
            "█               ███████████████               █             █",
            "█ POKEDEX ENTRY █    STATS    █     MOVES     █    EXIT     █",
            "█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄███████████████▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄█",
            "█                                                           █",
            "█             HP                                            █",
            "█                                                           █",
            "█         Attack                                            █",
            "█                                                           █",
            "█        Defense                                            █",
            "█                                                           █",
            "█       Weakness                                            █",
            "█                                                           █",
            "█                                                           █",
            "█                                                           █",
            "█                                                           █",
            "█                                                           █",
            "█                                                           █",
            "█                                                           █",
            "█             ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█",
            "█  ABILITY  ▄▀                                              █",
            "█▀▀▀▀▀▀▀▀▀▀▀                                                █",
            "█                                                           █",
            "▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀"
        };

        public static string[] pokedexMoves = new string[]
        {
            "▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄",
            "█               █             █████████████████             █",
            "█ POKEDEX ENTRY █    STATS    █     MOVES     █    EXIT     █",
            "█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄█████████████████▄▄▄▄▄▄▄▄▄▄▄▄▄█",
            "█                                                           █",
            "█                                                           █",
            "█              ▄▄▄▄▄▄     ▄                                 █",
            "█              ▀          ▀                                 █",
            "█                                                           █",
            "█                                                           █",
            "█              ▄     ▄▄▄▄▄▄                                 █",
            "█              ▀          ▀                                 █",
            "█                                                           █",
            "█                                                           █",
            "█              ▄          ▄                                 █",
            "█              ▀▀▀▀▀▀     ▀                                 █",
            "█                                                           █",
            "█                                                           █",
            "█              ▄          ▄                                 █",
            "█              ▀     ▀▀▀▀▀▀                                 █",
            "█                                                           █",
            "█                                                           █",
            "█                                                           █",
            "▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀"
        };

        public static string[] pokedexExit = new string[]
        {
            "▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄",
            "█               █             █               ███████████████",
            "█ POKEDEX ENTRY █    STATS    █     MOVES     █    EXIT     █",
            "█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄█▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄███████████████",
            "█                                                           █",
            "█                                                           █",
            "█                                                           █",
            "█                                                           █",
            "█               ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄             █",
            "█               █                             █             █",
            "█               █                             █             █",
            "█               █        Close window.        █             █",
            "█               █                             █             █",
            "█               █                             █             █",
            "█               ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀             █",
            "█                                                           █",
            "█                                                           █",
            "█                                                           █",
            "█                                                           █",
            "█                                                           █",
            "█                                                           █",
            "█                                                           █",
            "█                                                           █",
            "▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀"
        };

        public static string[] pokedexRefreshRIGHT = new string[]
        {
            //(26, 6)
            "                                                           ",
            "                                                           ",
            "                                                           ",
            "                                                           ",
            "                                                           ",
            "                                                           ",
            "                                                           ",
            "                                                           ",
            "                                                           ",
            "                                                           ",
            "                                                           ",
            "                                                           ",
            "                                                           ",
            "                                                           ",
            "                                                           ",
            "                                                           ",
            "                                                           ",
            "                                                           ",
            "                                                           " 
        };

        public static string[] pokedexRefreshLEFT = new string[]
        {
            //(5, 3)
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄",
            " ITEM              ",
            "                   "
        };

        #endregion

        #region Player Profile

        public static string[] playerProfileMale = new string[]
        {//(4,2)
            " ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ",
            " █           ▄▄▄                  ▄▄▄           ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ █ ",
            " █          ▀ ▄ ▀  TRAINER CARD  ▀ ▄ ▀          █                              █ █ ",
            " █          ▀▄▄▄▀                ▀▄▄▄▀          █             ▄▀▀▀▀▀▄          █ █ ",
            " █                                              █            █▄▀▀▄   █         █ █ ",
            " █  IDNo.                                       █            █▀█▀▀█▀█ ▀▄       █ █ ",
            " █                                              █        ▄   ▀▄▀  ▀▄▀▀▀▀       █ █ ",
            " █  NAME                                        █     ▄██▀     ▀█▀█            █ █ ",
            " █                                              █      ▀▄▀▄▄▄▄██▀▄███▄         █ █ ",
            " █  MONEY                                       █        ▀▄▄████ ██▀██▀▄       █ █ ",
            " █                                              █            ██  ██  █ █       █ █ ",
            " █  POKeDEX                                     █           ██  ██ ▄█▄▀        █ █ ",
            " █                                              █          █▄▀▀█▀█  ▀█         █ █ ",
            " █  TIME                                        █         █   ▄ ▀▄█            █ █ ",
            " █                                              █        █  ▄▀ ▀▄  █           █ █ ",
            " █  ADVENTURE STARTED                           █        █  █    █  █          █ █ ",
            " █                                              █        █  █     █  █         █ █ ",
            " █                                              █        █▄██      ██▄█        █ █ ",
            " █                                              █       ▀▀▀▀        ▀▀▀        █ █ ",
            " █                                              █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█ █ ",
            " █                                                                               █ ",
            " █                                                                               █ ",
            " █                                                                               █ ",
            " ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ "
        };

        public static string[] playerProfileFemale = new string[]
        {//(4,2)
            " ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ",
            " █           ▄▄▄                  ▄▄▄           ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ █ ",
            " █          ▀ ▄ ▀  TRAINER CARD  ▀ ▄ ▀          █              ▄▄▄▄▄▄▄▄▄       █ █ ",
            " █          ▀▄▄▄▀                ▀▄▄▄▀          █           ▄▀▀       █        █ █ ",
            " █                                              █           █████████  █       █ █ ",
            " █  IDNo.                                       █          █ █ █  █ █ █        █ █ ",
            " █                                              █          █ ▀▄    ▄▀ █        █ █ ",
            " █  NAME                                        █         █    ▀█▀█   █        █ █ ",
            " █                                              █        █   ▄▀█▄▄▄▀▄  █       █ █ ",
            " █  MONEY                                       █      ▄▀▄▄▄▀▄▀█  █▀▄▀▄ █      █ █ ",
            " █                                              █        ▄▀▄▀  █  █  █ █       █ █ ",
            " █  POKeDEX                                     █       ▀██   █   ▀▄  █ █      █ █ ",
            " █                                              █            █▄▄▄▄▄▄█  ██▀     █ █ ",
            " █  TIME                                        █           █▄▄█▄▄█▄█          █ █ ",
            " █                                              █          █ ▄▀   █ █          █ █ ",
            " █  ADVENTURE STARTED                           █         █▄▀      █ █         █ █ ",
            " █                                              █        █▄▀        ██         █ █ ",
            " █                                              █       ▀▀          ▀▀         █ █ ",
            " █                                              █                              █ █ ",
            " █                                              ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ █ ",
            " █                                                                               █ ",
            " █                                                                               █ ",
            " █                                                                               █ ",
            " ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ "
        };

        string asdf = @"
    ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄  
   █               ▀█▄
  █                █ █
  █▀█▀█▀█▀█▀▀▀█▀▀▄▄█▀ 
  █▀▀█▀▀▀▀▀▀▀▀▀▀▀▀ █  
  █  ██   ██  █  █▀█  
  █  █        █  █ █  
  █   █▄▄   ▄▄█ ▄▀ █  
 ▄█     ▀▀█▀▀█▀▀   █  
▄█      ▄▀    ▀▄ ▄█▀  
 ▀▀▄   ▄█    ▀▄ ▀█    
   ▀▀█▀▄▀█   █ ▀▄ █   
  ▄▄▀▄▀  █   █  █ █   
 ███▀   █     ▀▄███   
       █▄▄▄▄▄▄▄▄█     
      █▄▄█▄▄▄▄█▄▄█    
     █  ▄▀   █  █     
    █ ▄▀      █ █     
   █▄▀         ██     
  ▀▀           ▀▀     

";

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
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                          ▀█ █   ▀ █ █▄▄▄▄▄▄▄▄▄▄▄▀                                    ▀▄▄▄▄▄█ █   ▀ █ █▄▄▄▄▄▀                                          ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
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
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                                                                                                                                                       ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                                                                                                                                 ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                                                                                                                                                 ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                                                                                                                                           ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄                                                ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                              █▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█                                              ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                             ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄                                             ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                           █▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█                                           ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                            ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄                                            ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                █▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█                                                ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
@"█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                                ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄                                                ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀",
@"▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄                                              █▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█                                              ▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█",
@" ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                             ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄                                             ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄",
@"▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄                                           █▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█                                           ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀▄ ▄▀█▀█▀",
@"▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀                                            ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄ █ ▄ ▄                                            ▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█▀▄▀█▀█▀█",
@"▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄                                                █▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█▄█                                                ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄▀█▀▄   ▄",
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
█                 _▄▄▄▄▄_                                                                 █
█                ▄▀▄ ▄ ▄▀▄                                                                █
█                █ ▀▄▀▄▀ █                                             _▄▄▄▄▄_            █
█        _▄▄▄▄▄_  ▀▄▄▄▄▄▀  _▄▄▄▄▄_                                    ▄▀ ▄▀▄ ▀▄           █
█       ▄▀ ▄▀▄ ▀▄         ▄▀ █▀▄ ▀▄                                   █  ▀▄▀  █           █
█       █  █▀█  █         █  █▄▀  █                            _▄▄▄▄▄_ ▀▄▄▄▄▄▀            █
█        ▀▄▄▄▄▄▀  _▄▄▄▄▄_  ▀▄▄▄▄▄▀                            ▄▀ ▄ ▄ ▀▄                   █
█                ▄▀ ▄█▀ ▀▄                                    █  █▀▄  █                   █
█                █  ▄█▀  █       _▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄_    ▀▄▄▄▄▄▀                    █
█                 ▀▄▄▄▄▄▀       ▄▀ ▄   ▄ ▄▄▄▄ ▄   ▄ ▄   ▄ ▀▄                              █
█                               █  █▀▄▀█ █▄   █▀▄ █ █   █  █                              █
█                               █  █   █ █▄▄▄ █  ▀█ ▀▄▄▄▀  █                              █
█                                ▀▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▀                               █
█                                                                                         █
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀";

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

        #region Empty Space

        public static string[] emptyPokedex = new string[] {
        @"                   ",
        @"                   ",
        @"                   ",
        @"                   ",
        @"                   ",
        @"                   ",
        @"                   ",
        @"                   "
        };

        #endregion

        #region Pyra

        public static string[] pyraDefender = new string[] {
        @"                                                                                    ▄   ▄     ▄                                                                                   ",
        @"                                                                                    █▀▄▄▀▄     █                                                                                  ",
        @"                                                                                  ▄▄▀     ▀▀▄▀▀▄                                                                                  ",
        @"                                                                                  ▀▄▄▄▄▀        █                                                                                 ",
        @"                                                                                      █     ▄█ █                                                                                  ",
        @"                                                                                      █ █ ▄▀  █ █                                                                                 ",
        @"                                                                                    ▄▀ ▄▀ █  ▀ ▀                                                                                  ",
        @"                                                                                   █▄ █▄ █                                                                                        "};

        public static string[] pyraPokedex = new string[] {
        @"    ▄   ▄     ▄    ",
        @"    █▀▄▄▀▄     █   ",
        @"  ▄▄▀     ▀▀▄▀▀▄   ",
        @"  ▀▄▄▄▄▀        █  ",
        @"      █     ▄█ █   ",
        @"      █ █ ▄▀  █ █  ",
        @"    ▄▀ ▄▀ █  ▀ ▀   ",
        @"   █▄ █▄ █         "
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

        public static string[] dowseyDefender = new string[] {
        @"                                                                                                                                                                                  ",
        @"                                                                                    ▄▄▄▀▀▄                                                                                        ",
        @"                                                                                      ▀█  █▄                                                                                      ",
        @"                                                                                     ▄▀█   █▀▄                                                                                    ",
        @"                                                                                    █ ▄█   █▄ █                                                                                   ",
        @"                                                                                    █▀ █   █ ▀█                                                                                   ",
        @"                                                                                       █   █                                                                                      ",
        @"                                                                                      ▄▀▄▄▀▄▄_                                                                                    "};

        public static string[] dowseyPokedex = new string[] {
        @"                   ",
        @"    ▄▄▄▀▀▄         ",
        @"      ▀█  █▄       ",
        @"     ▄▀█   █▀▄     ",
        @"    █ ▄█   █▄ █    ",
        @"    █▀ █   █ ▀█    ",
        @"       █   █       ",
        @"      ▄▀▄▄▀▄▄_     "
        };

        public static string[] dowseyAttacker = new string[] {
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
        @"                                                                                         ▄█                                                                                       ",
        @"                                                                                       ▄▀ █                                                                                       ",
        @"                                                                                      █0 0 █▄                                                                                     ",
        @"                                                                                   ▄▄█ ▀██▀ █▄▄                                                                                   ",
        @"                                                                                 ▀▀█▄▄      ▄▄█▀▀                                                                                 ",
        @"                                                                                 ▄▀▀          ▀▀▄                                                                                 ",
        @"                                                                                                                                                                                  "};

        public static string[] electraPokedex = new string[] {
        @"                   ",
        @"         ▄█        ",
        @"       ▄▀ █        ",
        @"      █0 0 █▄      ",
        @"   ▄▄█ ▀██▀ █▄▄    ",
        @" ▀▀█▄▄      ▄▄█▀▀  ",
        @" ▄▀▀          ▀▀▄  ",
        @"                   "
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
        @"                                                                                       ▄   ▄                                                                                      ",
        @"                                                                                  ▄▄ ▄▀ ▀▀▀ ▀▄ ▄▄                                                                                 ",
        @"                                                                                 █  ██\▀▄ ▄▀/██  █                                                                                ",
        @"                                                                                 █ █▀ ▄     ▄ ▀█ █                                                                                ",
        @"                                                                                 ▀▄ ▄▀ ▀▀▀▀▀ ▀▄ ▄▀                                                                                ",
        @"                                                                                   ▀           ▀                                                                                  ",
        @"                                                                                   ▀███████████▀                                                                                  "};

        public static string[] cobbletPokedex = new string[] {
        @"                   ",
        @"       ▄   ▄       ",
        @"  ▄▄ ▄▀ ▀▀▀ ▀▄ ▄▄  ",
        @" █  ██\▀▄ ▄▀/██  █ ",
        @" █ █▀ ▄     ▄ ▀█ █ ",
        @" ▀▄ ▄▀ ▀▀▀▀▀ ▀▄ ▄▀ ",
        @"   ▀           ▀   ",
        @"   ▀███████████▀   "
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
        @"   █▀▀▄█▀▀▀█▄▀▀█   ",
        @"   █           █   ",
        @"   ▄▀         ▀▄   ",
        @"   █ ▀▀▄   ▄▀▀ █   ",
        @"   ▄▀▀▄▄   ▄▄▀▀▄   ",
        @"   ▀▄▄▀ ▀▀▀ ▀▄▄▀   ",
        @"  █▀  █  █  █  ▀█  ",
        @"   ▀▀▄▄▀▀▀▀▀▄▄▀▀   "
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
