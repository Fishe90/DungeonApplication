using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses
{
    public class Player_Menus
    {
        /****FIGHT MENU****/

        #region Fight Menu

        public static void BattleFightMenu(Player attacker, Monster defender, ConsoleKey navPlayerMenu, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            bool reloadBattleFIGHT = false;
            bool reloadBattleBAG = false;
            bool reloadBattlePOKeFRAUD = false;
            bool reloadBattleRUN = false;

            ASCII.DISATTandDEF(attacker, defender, GBText, GBBackground);
            do
            {                
                ASCII.DISSelectFight(attacker.MonsterEquipped, GBText, GBBackground);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.K:
                    case ConsoleKey.Enter:
                        FightMenu(attacker, defender, navPlayerMenu, GBText, GBBackground);
                        if (defender.Health <= 0)
                        {
                            System.Threading.Thread.Sleep(2000);
                            ASCII.ANIDefenderFaint(defender, GBText, GBBackground);
                            reloadBattleFIGHT = false;
                            reloadBattleBAG = false;
                            reloadBattlePOKeFRAUD = false;
                            reloadBattleRUN = false;
                        }
                        else
                        {
                            reloadBattleFIGHT = true;
                            reloadBattleBAG = false;
                            reloadBattlePOKeFRAUD = false;
                            reloadBattleRUN = false;
                        }
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        do
                        {
                            //Displays BattleBAG
                            ASCII.DISSelectBag(attacker.MonsterEquipped, GBText, GBBackground);
                            navPlayerMenu = Console.ReadKey().Key;
                            switch (navPlayerMenu)
                            {
                                case ConsoleKey.K:
                                case ConsoleKey.Enter:
                                    //Insert Battle Menu BAG Functionality HERE
                                    //ItemSection(attacker, defender, navPlayerMenu, GBText, GBBackground);
                                    Combat.FUNTryCatchANDSort(attacker, defender, GBText, GBBackground);
                                    if (defender.IsCaught == true)
                                    {
                                        reloadBattleFIGHT = false;
                                        reloadBattleBAG = false;
                                        reloadBattlePOKeFRAUD = false;
                                        reloadBattleRUN = false;
                                    }
                                    else
                                    {
                                        reloadBattleFIGHT = true;
                                        reloadBattleBAG = false;
                                        reloadBattlePOKeFRAUD = false;
                                        reloadBattleRUN = false;
                                    }
                                    break;
                                case ConsoleKey.S:
                                case ConsoleKey.DownArrow:
                                    do
                                    {
                                        //Displays BattleRUN
                                        ASCII.DISSelectRun(attacker.MonsterEquipped, GBText, GBBackground);
                                        navPlayerMenu = Console.ReadKey().Key;
                                        switch (navPlayerMenu)
                                        {
                                            case ConsoleKey.K:
                                            case ConsoleKey.Enter:
                                                string message = $"{attacker.Name.ToUpper()} fled to safety!";
                                                ASCII.ScrollMessage(message, 15, 2000, GBText, GBBackground);
                                                reloadBattleFIGHT = false;
                                                reloadBattleBAG = false;
                                                reloadBattlePOKeFRAUD = false;
                                                reloadBattleRUN = false;
                                                break;
                                            case ConsoleKey.A:
                                            case ConsoleKey.LeftArrow:
                                                do
                                                {
                                                    //Displays BattlePOKeFRAUD
                                                    ASCII.DISSelectParty(attacker.MonsterEquipped, GBText, GBBackground);
                                                    navPlayerMenu = Console.ReadKey().Key;
                                                    switch (navPlayerMenu)
                                                    {
                                                        case ConsoleKey.K:
                                                        case ConsoleKey.Enter:
                                                            //MonsterShiftMenu(attacker, attacker.PlayersParty, defender, navPlayerMenu, GBText, GBBackground);
                                                            reloadBattleFIGHT = true;
                                                            reloadBattleBAG = false;
                                                            reloadBattlePOKeFRAUD = false;
                                                            reloadBattleRUN = false;
                                                            break;
                                                        case ConsoleKey.W:
                                                        case ConsoleKey.UpArrow:
                                                            //Reloads BattleFIGHT
                                                            reloadBattleBAG = false;
                                                            reloadBattlePOKeFRAUD = false;
                                                            reloadBattleRUN = false;
                                                            reloadBattleFIGHT = true;
                                                            break;
                                                        case ConsoleKey.D:
                                                        case ConsoleKey.RightArrow:
                                                            //Reloads BattleRUN
                                                            reloadBattleRUN = true;
                                                            reloadBattlePOKeFRAUD = false;
                                                            break;
                                                        default:
                                                            //Reloads BattlePOKeFRAUD
                                                            reloadBattlePOKeFRAUD = true;
                                                            break;
                                                    }//end switch navPlayerMenu
                                                } while (reloadBattlePOKeFRAUD);//end dowhile reloadBattlePOKeFRAUD 
                                                break;
                                            case ConsoleKey.W:
                                            case ConsoleKey.UpArrow:
                                                //Reloads BattleBAG
                                                reloadBattleBAG = true;
                                                reloadBattlePOKeFRAUD = false;
                                                reloadBattleRUN = false;
                                                break;
                                            default:
                                                //Reloads BattleRUN
                                                reloadBattleRUN = true;
                                                break;
                                        }//end switch navPlayerMenu
                                    } while (reloadBattleRUN);//end dowhile reloadBattleRUN                                    
                                    break;
                                case ConsoleKey.A:
                                case ConsoleKey.LeftArrow:
                                    //Reloads BattleFIGHT
                                    reloadBattleFIGHT = true;
                                    reloadBattlePOKeFRAUD = false;
                                    reloadBattleBAG = false;
                                    reloadBattleRUN = false;
                                    break;
                                default:
                                    //Reloads BattleBAG
                                    reloadBattleBAG = true;
                                    break;
                            }
                        } while (reloadBattleBAG);//end dowhile reloadBattleBag
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        do
                        {
                            //Displays BattlePOKeFRAUD
                            ASCII.DISSelectParty(attacker.MonsterEquipped, GBText, GBBackground);
                            navPlayerMenu = Console.ReadKey().Key;
                            switch (navPlayerMenu)
                            {
                                case ConsoleKey.K:
                                case ConsoleKey.Enter:
                                    //TODO Add MonsterShiftMenu() HERE!!!
                                    //MonsterShiftMenu(attacker, attacker.PlayersParty, defender, navPlayerMenu, GBText, GBBackground);
                                    reloadBattleFIGHT = true;
                                    reloadBattleBAG = false;
                                    reloadBattlePOKeFRAUD = false;
                                    reloadBattleRUN = false;
                                    break;
                                case ConsoleKey.D:
                                case ConsoleKey.RightArrow:
                                    do
                                    {
                                        //Displays BattleRUN
                                        ASCII.DISSelectRun(attacker.MonsterEquipped, GBText, GBBackground);
                                        navPlayerMenu = Console.ReadKey().Key;
                                        switch (navPlayerMenu)
                                        {
                                            case ConsoleKey.K:
                                            case ConsoleKey.Enter:
                                                string message = $"{attacker.Name.ToUpper()} fled to safety!";
                                                ASCII.ScrollMessage(message, 15, 2000, GBText, GBBackground);
                                                reloadBattleFIGHT = false;
                                                reloadBattleBAG = false;
                                                reloadBattlePOKeFRAUD = false;
                                                reloadBattleRUN = false;
                                                break;
                                            case ConsoleKey.W:
                                            case ConsoleKey.UpArrow:
                                                do
                                                {
                                                    //Displays BattleBAG
                                                    ASCII.DISSelectBag(attacker.MonsterEquipped, GBText, GBBackground);
                                                    navPlayerMenu = Console.ReadKey().Key;
                                                    switch (navPlayerMenu)
                                                    {
                                                        case ConsoleKey.K:
                                                        case ConsoleKey.Enter:
                                                            //Player_Inventory.ItemSection(attacker, defender, navPlayerMenu, GBText, GBBackground);
                                                            if (defender.IsCaught == true)
                                                            {
                                                                reloadBattleFIGHT = false;
                                                                reloadBattleBAG = false;
                                                                reloadBattlePOKeFRAUD = false;
                                                                reloadBattleRUN = false;
                                                            }
                                                            else
                                                            {
                                                                reloadBattleFIGHT = true;
                                                                reloadBattleBAG = false;
                                                                reloadBattlePOKeFRAUD = false;
                                                                reloadBattleRUN = false;
                                                            }
                                                            break;
                                                        case ConsoleKey.S:
                                                        case ConsoleKey.DownArrow:
                                                            //Reloads BattleRUN
                                                            reloadBattleRUN = true;
                                                            reloadBattleBAG = false;
                                                            break;
                                                        case ConsoleKey.A:
                                                        case ConsoleKey.LeftArrow:
                                                            //Reloads BattleFIGHT
                                                            reloadBattleBAG = false;
                                                            reloadBattlePOKeFRAUD = false;
                                                            reloadBattleRUN = false;
                                                            reloadBattleFIGHT = true;
                                                            break;
                                                        default:
                                                            //Reloads BattleBAG
                                                            reloadBattleBAG = true;
                                                            break;
                                                    }//end switch navPlayerMenu
                                                } while (reloadBattleBAG);//end dowhile reloadBattleBAG
                                                break;
                                            case ConsoleKey.A:
                                            case ConsoleKey.LeftArrow:
                                                //Reloads BattlePOKeFRAUD
                                                reloadBattlePOKeFRAUD = true;
                                                reloadBattleBAG = false;
                                                reloadBattleRUN = false;
                                                break;
                                            default:
                                                //Reloads POKeFRAUD
                                                reloadBattleRUN = true;
                                                break;
                                        }//end switch navPlayerMenu
                                    } while (reloadBattleRUN);//end dowhile reloadBattleRUN
                                    break;
                                case ConsoleKey.W:
                                case ConsoleKey.UpArrow:
                                    //Reloads BattleFIGHT
                                    reloadBattleFIGHT = true;
                                    reloadBattleBAG = false;
                                    reloadBattlePOKeFRAUD = false;
                                    reloadBattleRUN = false;
                                    break;
                                default:
                                    //Reloads POKeFRAUD
                                    reloadBattlePOKeFRAUD = true;
                                    break;
                            }//end switch navPlayerMenu
                        } while (reloadBattlePOKeFRAUD);//end dowhile reloadBattlePOKeFRAUD
                        break;
                    default:
                        //Reloads BattleFIGHT
                        reloadBattleFIGHT = true;
                        break;
                }//end switch navPlayerMenu
            } while (reloadBattleFIGHT);//end dowhile reloadBattleFIGHT
        }//end BattleMenu()

        #endregion

        #region Fight Menu Select Moves 

        public static void DISFightMoves(Monster monster, Monster_Moves move, ConsoleColor GBText, ConsoleColor GBBackground)
        {           
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
            Console.SetCursorPosition(11, 22);
            if (monster.EquippedMoves.Move1.Type == Monster_Race.NONE)
            {
                Console.Write("");
            }
            else
            {
                Console.Write(monster.EquippedMoves.Move1.Name);
            }
            Console.SetCursorPosition(36, 22);
            if (monster.EquippedMoves.Move2.Type == Monster_Race.NONE)
            {
                Console.Write("");
            }
            else
            {
                Console.Write(monster.EquippedMoves.Move2.Name);
            }
            Console.SetCursorPosition(11, 23);
            if (monster.EquippedMoves.Move3.Type == Monster_Race.NONE)
            {
                Console.Write("");
            }
            else
            {
                Console.Write(monster.EquippedMoves.Move3.Name);
            }
            Console.SetCursorPosition(36, 23);
            if (monster.EquippedMoves.Move4.Type == Monster_Race.NONE)
            {
                Console.Write("");
            }
            else
            {
                Console.Write(monster.EquippedMoves.Move4.Name);
            }
            Console.SetCursorPosition(75, 22);
            if (move.Type == Monster_Race.NONE)
            {
                Console.Write("");
            }
            else
            {
                Console.Write($@"{move.Uses}/{move.MaxUses}");
            }                     
            Console.SetCursorPosition(75, 23);
            if (move.Type == Monster_Race.NONE)
            {
                Console.Write("");
            }
            else
            {
                switch (move.Type)
                {
                    case Monster_Race.Fire:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Monster_Race.Water:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Monster_Race.Electric:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Monster_Race.Ground:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    case Monster_Race.Psychic:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                }
                Console.Write(move.Type);
            }                        
            Console.ForegroundColor = GBText;
            Console.SetCursorPosition(0, 0);
            //TestCombat.GameConsole(GameBoyColor);
        }

        public static void DISFightMove1(Monster monster, ConsoleColor GBText, ConsoleColor GBBackground)
        {            
            Console.SetCursorPosition(5, 21);
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
            Console.WriteLine("▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄");
            Console.SetCursorPosition(5, 22);
            Console.WriteLine("█  -->                                            █  PP                         █");
            Console.SetCursorPosition(5, 23);
            Console.WriteLine("█                                                 █  TYPE:                      █");
            Console.SetCursorPosition(5, 24);
            Console.WriteLine("█                                                 █                             █");
            Console.SetCursorPosition(5, 25);
            Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ");
            DISFightMoves(monster, monster.EquippedMoves.Move1, GBText, GBBackground);
            //Console.SetCursorPosition(0, 20);
            //Console.Write(_ASCII.Move1);
            //TestCombat.GameConsole(GameBoyColor);
        }

        public static void DISFightMove2(Monster monster, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
            Console.SetCursorPosition(5, 21);
            Console.WriteLine("▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄");
            Console.SetCursorPosition(5, 22);
            Console.WriteLine("█                          -->                    █  PP                         █");
            Console.SetCursorPosition(5, 23);
            Console.WriteLine("█                                                 █  TYPE:                      █");
            Console.SetCursorPosition(5, 24);
            Console.WriteLine("█                                                 █                             █");
            Console.SetCursorPosition(5, 25);
            Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ");
            DISFightMoves(monster, monster.EquippedMoves.Move2, GBText, GBBackground);
            //Console.SetCursorPosition(0, 20);
            //Console.Write(_ASCII.Move2);
            //TestCombat.GameConsole(GameBoyColor);
        }

        public static void DISFightMove3(Monster monster, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
            Console.SetCursorPosition(5, 21);
            Console.WriteLine("▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄");
            Console.SetCursorPosition(5, 22);
            Console.WriteLine("█                                                 █  PP                         █");
            Console.SetCursorPosition(5, 23);
            Console.WriteLine("█  -->                                            █  TYPE:                      █");
            Console.SetCursorPosition(5, 24);
            Console.WriteLine("█                                                 █                             █");
            Console.SetCursorPosition(5, 25);
            Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ");
            DISFightMoves(monster, monster.EquippedMoves.Move3, GBText, GBBackground);
            //Console.SetCursorPosition(0, 20);
            //Console.Write(_ASCII.Move3);
            //TestCombat.GameConsole(GameBoyColor);
        }

        public static void DISFightMove4(Monster monster, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Console.ForegroundColor = GBText;
            Console.BackgroundColor = GBBackground;
            Console.SetCursorPosition(5, 21);
            Console.WriteLine("▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄");
            Console.SetCursorPosition(5, 22);
            Console.WriteLine("█                                                 █  PP                         █");
            Console.SetCursorPosition(5, 23);
            Console.WriteLine("█                          -->                    █  TYPE:                      █");
            Console.SetCursorPosition(5, 24);
            Console.WriteLine("█                                                 █                             █");
            Console.SetCursorPosition(5, 25);
            Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ");
            DISFightMoves(monster, monster.EquippedMoves.Move4, GBText, GBBackground);
            //Console.SetCursorPosition(0, 20);
            //Console.Write(_ASCII.Move4);
            //TestCombat.GameConsole(GameBoyColor);
        }

        public static void FightMenu(Player player, Monster monster, ConsoleKey navPlayerMenu, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            bool reloadFightMove1 = false;
            bool reloadFightMove2 = false;
            bool reloadFightMove3 = false;
            bool reloadFightMove4 = false;

            ASCII.DISATTandDEF(player, monster, GBText, GBBackground);
            do
            {
                //Displays FightMove1                
                DISFightMove1(player.MonsterEquipped, GBText, GBBackground);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.K:
                    case ConsoleKey.Enter:
                        Combat.DoBattle(player, monster, player.MonsterEquipped.EquippedMoves.Move1, GBText, GBBackground);
                        reloadFightMove1 = false;
                        reloadFightMove2 = false;
                        reloadFightMove3 = false;
                        reloadFightMove4 = false;
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        do
                        {
                            //Displays FightMove2
                            DISFightMove2(player.MonsterEquipped, GBText, GBBackground);
                            navPlayerMenu = Console.ReadKey().Key;
                            switch (navPlayerMenu)
                            {
                                case ConsoleKey.K:
                                case ConsoleKey.Enter:
                                    Combat.DoBattle(player, monster, player.MonsterEquipped.EquippedMoves.Move2, GBText, GBBackground);
                                    reloadFightMove1 = false;
                                    reloadFightMove2 = false;
                                    reloadFightMove3 = false;
                                    reloadFightMove4 = false;
                                    break;
                                case ConsoleKey.S:
                                case ConsoleKey.DownArrow:
                                    do
                                    {
                                        //Displays FightMove4
                                        DISFightMove4(player.MonsterEquipped, GBText, GBBackground);
                                        navPlayerMenu = Console.ReadKey().Key;
                                        switch (navPlayerMenu)
                                        {
                                            case ConsoleKey.K:
                                            case ConsoleKey.Enter:
                                                Combat.DoBattle(player, monster, player.MonsterEquipped.EquippedMoves.Move4, GBText, GBBackground);
                                                reloadFightMove1 = false;
                                                reloadFightMove2 = false;
                                                reloadFightMove3 = false;
                                                reloadFightMove4 = false;
                                                break;
                                            case ConsoleKey.A:
                                            case ConsoleKey.LeftArrow:
                                                do
                                                {
                                                    //Displays FightMove3
                                                    DISFightMove3(player.MonsterEquipped, GBText, GBBackground);
                                                    navPlayerMenu = Console.ReadKey().Key;
                                                    switch (navPlayerMenu)
                                                    {
                                                        case ConsoleKey.K:
                                                        case ConsoleKey.Enter:
                                                            Combat.DoBattle(player, monster, player.MonsterEquipped.EquippedMoves.Move3, GBText, GBBackground);
                                                            reloadFightMove1 = false;
                                                            reloadFightMove2 = false;
                                                            reloadFightMove3 = false;
                                                            reloadFightMove4 = false;
                                                            break;
                                                        case ConsoleKey.W:
                                                        case ConsoleKey.UpArrow:
                                                            //Reloads FightMove1
                                                            reloadFightMove1 = true;
                                                            reloadFightMove2 = false;
                                                            reloadFightMove3 = false;
                                                            reloadFightMove4 = false;
                                                            break;
                                                        case ConsoleKey.D:
                                                        case ConsoleKey.RightArrow:
                                                            //Reloads FightMove4
                                                            reloadFightMove4 = true;
                                                            reloadFightMove3 = false;
                                                            break;
                                                        case ConsoleKey.Backspace:
                                                            reloadFightMove1 = false;
                                                            reloadFightMove2 = false;
                                                            reloadFightMove3 = false;
                                                            reloadFightMove4 = false;
                                                            break;
                                                        default:
                                                            //Reloads FightMove3
                                                            reloadFightMove3 = true;
                                                            break;
                                                    }//end switch navPlayerMenu
                                                } while (reloadFightMove3);//end dowhile reloadFightMove3 
                                                break;
                                            case ConsoleKey.W:
                                            case ConsoleKey.UpArrow:
                                                //Reloads FightMove2
                                                reloadFightMove2 = true;
                                                reloadFightMove3 = false;
                                                reloadFightMove4 = false;
                                                break;
                                            case ConsoleKey.Backspace:
                                                reloadFightMove1 = false;
                                                reloadFightMove2 = false;
                                                reloadFightMove3 = false;
                                                reloadFightMove4 = false;
                                                break;
                                            default:
                                                //Reloads FightMove4
                                                reloadFightMove4 = true;
                                                break;
                                        }//end switch navPlayerMenu
                                    } while (reloadFightMove4);//end dowhile reloadFightMove4                                    
                                    break;
                                case ConsoleKey.A:
                                case ConsoleKey.LeftArrow:
                                    //Reloads FightMove1
                                    reloadFightMove1 = true;
                                    reloadFightMove2 = false;
                                    reloadFightMove3 = false;
                                    reloadFightMove4 = false;
                                    break;
                                case ConsoleKey.Backspace:
                                    reloadFightMove1 = false;
                                    reloadFightMove2 = false;
                                    reloadFightMove3 = false;
                                    reloadFightMove4 = false;
                                    break;
                                default:
                                    //Reloads FightMove2
                                    reloadFightMove2 = true;
                                    break;
                            }
                        } while (reloadFightMove2);//end dowhile reloadBattleBag
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        do
                        {
                            //Displays Move3
                            DISFightMove3(player.MonsterEquipped, GBText, GBBackground);
                            navPlayerMenu = Console.ReadKey().Key;
                            switch (navPlayerMenu)
                            {
                                case ConsoleKey.K:
                                case ConsoleKey.Enter:
                                    Combat.DoBattle(player, monster, player.MonsterEquipped.EquippedMoves.Move3, GBText, GBBackground);
                                    reloadFightMove1 = false;
                                    reloadFightMove2 = false;
                                    reloadFightMove3 = false;
                                    reloadFightMove4 = false;
                                    break;
                                case ConsoleKey.D:
                                case ConsoleKey.RightArrow:
                                    do
                                    {
                                        //Displays Move4
                                        DISFightMove4(player.MonsterEquipped, GBText, GBBackground);
                                        navPlayerMenu = Console.ReadKey().Key;
                                        switch (navPlayerMenu)
                                        {
                                            case ConsoleKey.K:
                                            case ConsoleKey.Enter:
                                                Combat.DoBattle(player, monster, player.MonsterEquipped.EquippedMoves.Move4, GBText, GBBackground);
                                                reloadFightMove1 = false;
                                                reloadFightMove2 = false;
                                                reloadFightMove3 = false;
                                                reloadFightMove4 = false;
                                                break;
                                            case ConsoleKey.W:
                                            case ConsoleKey.UpArrow:
                                                do
                                                {
                                                    //Displays Move2
                                                    DISFightMove2(player.MonsterEquipped, GBText, GBBackground);
                                                    navPlayerMenu = Console.ReadKey().Key;
                                                    switch (navPlayerMenu)
                                                    {
                                                        case ConsoleKey.K:
                                                        case ConsoleKey.Enter:
                                                            Combat.DoBattle(player, monster, player.MonsterEquipped.EquippedMoves.Move2, GBText, GBBackground);
                                                            reloadFightMove1 = false;
                                                            reloadFightMove2 = false;
                                                            reloadFightMove3 = false;
                                                            reloadFightMove4 = false;
                                                            break;
                                                        case ConsoleKey.S:
                                                        case ConsoleKey.DownArrow:
                                                            //Reloads BattleRUN
                                                            reloadFightMove4 = true;
                                                            reloadFightMove2 = false;
                                                            break;
                                                        case ConsoleKey.A:
                                                        case ConsoleKey.LeftArrow:
                                                            //Reloads BattleFIGHT
                                                            reloadFightMove1 = true;
                                                            reloadFightMove2 = false;
                                                            reloadFightMove3 = false;
                                                            reloadFightMove4 = false;
                                                            break;
                                                        case ConsoleKey.Backspace:
                                                            reloadFightMove1 = false;
                                                            reloadFightMove2 = false;
                                                            reloadFightMove3 = false;
                                                            reloadFightMove4 = false;
                                                            break;
                                                        default:
                                                            //Reloads BattleBAG
                                                            reloadFightMove2 = true;
                                                            break;
                                                    }//end switch navPlayerMenu
                                                } while (reloadFightMove2);//end dowhile reloadBattleBAG
                                                break;
                                            case ConsoleKey.A:
                                            case ConsoleKey.LeftArrow:
                                                //Reloads BattlePOKeFRAUD
                                                reloadFightMove3 = true;
                                                reloadFightMove2 = false;
                                                reloadFightMove4 = false;
                                                break;
                                            case ConsoleKey.Backspace:
                                                reloadFightMove1 = false;
                                                reloadFightMove2 = false;
                                                reloadFightMove3 = false;
                                                reloadFightMove4 = false;
                                                break;
                                            default:
                                                //Reloads POKeFRAUD
                                                reloadFightMove4 = true;
                                                break;
                                        }//end switch navPlayerMenu
                                    } while (reloadFightMove4);//end dowhile reloadBattleRUN
                                    break;
                                case ConsoleKey.W:
                                case ConsoleKey.UpArrow:
                                    //Reloads BattleFIGHT
                                    reloadFightMove1 = true;
                                    reloadFightMove2 = false;
                                    reloadFightMove3 = false;
                                    reloadFightMove4 = false;
                                    break;
                                case ConsoleKey.Backspace:
                                    reloadFightMove1 = false;
                                    reloadFightMove2 = false;
                                    reloadFightMove3 = false;
                                    reloadFightMove4 = false;
                                    break;
                                default:
                                    //Reloads POKeFRAUD
                                    reloadFightMove3 = true;
                                    break;
                            }//end switch navPlayerMenu
                        } while (reloadFightMove3);//end dowhile reloadBattlePOKeFRAUD
                        break;
                    case ConsoleKey.Backspace:
                        reloadFightMove1 = false;
                        reloadFightMove2 = false;
                        reloadFightMove3 = false;
                        reloadFightMove4 = false;
                        break;
                    default:
                        //Reloads BattleFIGHT
                        reloadFightMove1 = true;
                        break;
                }//end switch navPlayerMenu
            } while (reloadFightMove1);//end dowhile reloadBattleFIGHT
        }

        #endregion

        #region Fight Menu Inventory 

        public static void ItemSection(Player player, Monster monster, ConsoleKey navPlayerMenu, ConsoleColor GameScreenText, ConsoleColor GameScreenBackground)
        {

        }

        public static void MedSection(Player player, Monster monster, ConsoleKey navPlayerMenu, ConsoleColor GameScreenText, ConsoleColor GameScreenBackground)
        {

        }

        #endregion

        #region Fight Menu Player Party 

        public static void DISInfoPlayerParty(Player player)
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            //Console.Write(_ASCII.PlayerParty);
            //MonsterEquipped
            //DISMonsterNameANDGender(player.MonsterEquipped, 10, 3);
            //DISMonsterLevel(player.MonsterEquipped, 30, 3, ConsoleColor.White);
            //DISMonsterHealthBar(player.MonsterEquipped, 10, 4, ConsoleColor.White, ConsoleColor.Black);
            //Slot3
            if (player.Party.Slot3.Type == Monster_Race.NONE)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("");
            }
            else
            {
                //DISMonsterNameANDGender(player.Party.Slot3, 10, 9);
                //DISMonsterLevel(player.Party.Slot3, 30, 9, ConsoleColor.White);
                //DISMonsterHealthBar(player.Party.Slot3, 10, 10, ConsoleColor.White, ConsoleColor.Black);
            }
            //Slot5
            if (player.Party.Slot5.Type == Monster_Race.NONE)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("");
            }
            else
            {
                //DISMonsterNameANDGender(player.Party.Slot5, 10, 15);
                //DISMonsterLevel(player.Party.Slot5, 30, 15, ConsoleColor.White);
                //DISMonsterHealthBar(player.Party.Slot5, 10, 16, ConsoleColor.White, ConsoleColor.Black);
            }
            //Slot2
            if (player.Party.Slot2.Type == Monster_Race.NONE)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("");
            }
            else
            {
                //DISMonsterNameANDGender(player.Party.Slot2, 55, 4);
                //DISMonsterLevel(player.Party.Slot2, 75, 4, ConsoleColor.White);
                //DISMonsterHealthBar(player.Party.Slot2, 55, 5, ConsoleColor.White, ConsoleColor.Black);
            }
            //Slot4
            if (player.Party.Slot4.Type == Monster_Race.NONE)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("");
            }
            else
            {
                //DISMonsterNameANDGender(player.Party.Slot4, 55, 10);
                //DISMonsterLevel(player.Party.Slot4, 75, 10, ConsoleColor.White);
                //DISMonsterHealthBar(player.Party.Slot4, 55, 11, ConsoleColor.White, ConsoleColor.Black);
            }
            //Slot6
            if (player.Party.Slot6.Type == Monster_Race.NONE)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("");
            }
            else
            {
                //DISMonsterNameANDGender(player.Party.Slot6, 55, 16);
                //DISMonsterLevel(player.Party.Slot6, 75, 16, ConsoleColor.White);
                //DISMonsterHealthBar(player.Party.Slot6, 55, 17, ConsoleColor.White, ConsoleColor.Black);
            }
            //GameConsole(GameBoyColor);
        }

        #endregion

        /****PLAYER MENU****/

        #region Player Menu

        public static void DISPlayerNameMenu(Player player)
        {
            string name = $"{player.Name}";
            Console.SetCursorPosition(66, 13);
            Console.Write(name);
            Console.SetCursorPosition(0, 0);
        }

        public static void PlayerMenu(Player player, Monster monster, ConsoleKey navPlayerMenu, ConsoleColor GameScreenText, ConsoleColor GameScreenBackground)
        {
            bool reloadPlayerMenu = false;
            bool reloadPlayerMonstersEquipped = false;
            bool reloadPlayerBag = false;
            bool reloadPlayerProfile = false;
            bool reloadPlayerEXIT = false;

            do
            {
                Console.SetCursorPosition(0, 0);
                Console.Write(" ");
                Console.Write(player.ToString());
                //Console.Write(ASCII.gameButtons);
                //DisplayPlayerNameMenu(player);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {

                    //Opens and Displays PlayerMenuRolodex

                    case ConsoleKey.Enter: //TODO ADD POKEDEX SECTION
                        //SFX.Select();
                        do
                        {
                        } while (reloadPlayerMenu);
                        break;

                    //Navigates Down to PlayerMonstersEquipped

                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        //SFX.Select();
                        do
                        {
                            Console.SetCursorPosition(0, 0);
                            Console.Write(" ");
                            //Console.Write(player.PlayerMenuMonstersEquipped());
                            //Console.Write(ASCII.gameButtons);
                            //DisplayPlayerNameMenu(player);
                            navPlayerMenu = Console.ReadKey().Key;
                            switch (navPlayerMenu)
                            {

                                //Navigates DOWN to PlayerBag

                                case ConsoleKey.Enter:
                                    //SFX.Select();
                                    //TODO Insert MONSTERS EQUIPPED CODE HERE!!!
                                    break;
                                case ConsoleKey.UpArrow:
                                case ConsoleKey.W:
                                    //SFX.Select();
                                    reloadPlayerMenu = true;
                                    reloadPlayerMonstersEquipped = false;
                                    reloadPlayerBag = false;
                                    reloadPlayerProfile = false;
                                    reloadPlayerEXIT = false;
                                    break;
                                case ConsoleKey.DownArrow:
                                case ConsoleKey.S:
                                    //SFX.Select();
                                    do
                                    {
                                        Console.SetCursorPosition(0, 0);
                                        Console.Write(" ");
                                        //Console.Write(player.PlayerMenuBag());
                                        //Console.Write(ASCII.gameButtons);
                                        //DisplayPlayerNameMenu(player);
                                        navPlayerMenu = Console.ReadKey().Key;
                                        switch (navPlayerMenu)
                                        {
                                            case ConsoleKey.Enter:
                                                //SFX.Select();
                                                //PlayerItemSectionOutsideBattle(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                                                break;
                                            case ConsoleKey.UpArrow:
                                            case ConsoleKey.W:
                                                //SFX.Select();
                                                reloadPlayerMonstersEquipped = true;
                                                reloadPlayerBag = false;
                                                reloadPlayerProfile = false;
                                                reloadPlayerEXIT = false;
                                                break;
                                            case ConsoleKey.DownArrow:
                                            case ConsoleKey.S:
                                                //SFX.Select();
                                                do
                                                {
                                                    Console.SetCursorPosition(0, 0);
                                                    Console.Write(" ");
                                                    //Console.Write(player.PlayerMenuProfile());
                                                    //Console.Write(ASCII.gameButtons);
                                                    //DisplayPlayerNameMenu(player);
                                                    navPlayerMenu = Console.ReadKey().Key;
                                                    switch (navPlayerMenu)
                                                    {
                                                        case ConsoleKey.Enter:
                                                            //SFX.Select();
                                                            //TODO Insert PLAYER PROFILE CODE HERE!!!
                                                            break;
                                                        case ConsoleKey.UpArrow:
                                                        case ConsoleKey.W:
                                                            //SFX.Select();
                                                            reloadPlayerBag = true;
                                                            reloadPlayerProfile = false;
                                                            reloadPlayerEXIT = false;
                                                            break;
                                                        case ConsoleKey.DownArrow:
                                                        case ConsoleKey.S:
                                                            //SFX.Select();
                                                            do
                                                            {
                                                                Console.SetCursorPosition(0, 0);
                                                                Console.Write(" ");
                                                                //Console.Write(player.PlayerMenuExit());
                                                                //Console.Write(ASCII.gameButtons);
                                                                //DisplayPlayerNameMenu(player);
                                                                navPlayerMenu = Console.ReadKey().Key;
                                                                switch (navPlayerMenu)
                                                                {
                                                                    case ConsoleKey.Enter:
                                                                        //SFX.Select();
                                                                        //TODO Insert EXIT MENU CODE HERE!!!
                                                                        break;
                                                                    case ConsoleKey.UpArrow:
                                                                    case ConsoleKey.W:
                                                                        //SFX.Select();
                                                                        reloadPlayerProfile = true;
                                                                        reloadPlayerEXIT = false;
                                                                        break;
                                                                    default:
                                                                        reloadPlayerEXIT = true;
                                                                        break;
                                                                    case ConsoleKey.Backspace:
                                                                        //SFX.Select();
                                                                        reloadPlayerBag = false;
                                                                        reloadPlayerEXIT = false;
                                                                        reloadPlayerMenu = false;
                                                                        reloadPlayerMonstersEquipped = false;
                                                                        reloadPlayerProfile = false;
                                                                        break;
                                                                }//end switch PlayerMenuBag
                                                            } while (reloadPlayerEXIT);//end dowhile reloadPlayerBag
                                                            break;
                                                        case ConsoleKey.Backspace:
                                                            //SFX.Select();
                                                            reloadPlayerBag = false;
                                                            reloadPlayerEXIT = false;
                                                            reloadPlayerMenu = false;
                                                            reloadPlayerMonstersEquipped = false;
                                                            reloadPlayerProfile = false;
                                                            break;
                                                        default:
                                                            reloadPlayerProfile = true;
                                                            break;
                                                    }//end switch PlayerMenuBag
                                                } while (reloadPlayerProfile);//end dowhile reloadPlayerBag
                                                break;
                                            case ConsoleKey.Backspace:
                                                //SFX.Select();
                                                reloadPlayerBag = false;
                                                reloadPlayerEXIT = false;
                                                reloadPlayerMenu = false;
                                                reloadPlayerMonstersEquipped = false;
                                                reloadPlayerProfile = false;
                                                break;
                                            default:
                                                reloadPlayerBag = true;
                                                break;
                                        }//end switch PlayerMenuBag
                                    } while (reloadPlayerBag);//end dowhile reloadPlayerBag
                                    break;
                                case ConsoleKey.Backspace:
                                    //SFX.Select();
                                    reloadPlayerBag = false;
                                    reloadPlayerEXIT = false;
                                    reloadPlayerMenu = false;
                                    reloadPlayerMonstersEquipped = false;
                                    reloadPlayerProfile = false;
                                    break;
                                default:
                                    reloadPlayerMonstersEquipped = true;
                                    break;
                            }//end switch MenuMonstersEquipped
                        } while (reloadPlayerMonstersEquipped);//end dowhile reloadplayerMonstersEquipped
                        break;
                    case ConsoleKey.Backspace:
                        //SFX.Select();
                        reloadPlayerBag = false;
                        reloadPlayerEXIT = false;
                        reloadPlayerMenu = false;
                        reloadPlayerMonstersEquipped = false;
                        reloadPlayerProfile = false;
                        break;
                    default:
                        reloadPlayerMenu = true;
                        break;
                }//end switch PlayerMenu
            } while (reloadPlayerMenu);//end dowhile reloadPlayerMenu            
        }//end MenuPokedex()

        #endregion

        #region Player Menu Pokedex



        #endregion

        #region Player Menu Party



        #endregion

        #region Player Menu Inventory

        public static void PlayerItemSection(Player player, Monster monster, ConsoleKey navPlayerMenu, ConsoleColor GameScreenText, ConsoleColor GameScreenBackground)
        {
            bool reloadItemRepel = false;
            bool reloadItemBlazeStone = false;
            bool reloadItemAquaStone = false;
            bool reloadItemPowerStone = false;
            bool reloadItemEarthStone = false;
            bool reloadItemMindStone = false;
            bool reloadItemSection = false;

            do
            {
                Console.SetCursorPosition(0, 0);
                Console.Write(" ");
                //Console.Write(player.PlayerInv.BagSlot1);
                //Console.Write(ASCII.defaultMessageDisplay);
                //Console.Write(ASCII.gameButtons);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.Enter:
                        Console.SetCursorPosition(0, 0);
                        Console.Write(" ");
                        //Console.Write(player.PlayerInv.BagSlot1);
                        //Console.Write(ASCII.messageDisplayUseItem);
                        //Console.Write(ASCII.gameButtons);
                        navPlayerMenu = Console.ReadKey().Key;
                        switch (navPlayerMenu)
                        {
                            case ConsoleKey.Y:
                            case ConsoleKey.Enter:
                                //TestCombat.FUNTryCatchANDSort(player, monster, GameScreenText, GameScreenBackground);
                                reloadItemAquaStone = false;
                                reloadItemBlazeStone = false;
                                reloadItemEarthStone = false;
                                reloadItemMindStone = false;
                                reloadItemPowerStone = false;
                                reloadItemRepel = false;
                                reloadItemSection = false;
                                break;
                            default:
                                reloadItemSection = true;
                                break;
                        }
                        break;

                    /*Highlights the Medicine Tab in the PlayerBag Menu with Health Potions selected*/

                    case ConsoleKey.RightArrow:
                        reloadItemRepel = false;
                        reloadItemBlazeStone = false;
                        reloadItemAquaStone = false;
                        reloadItemPowerStone = false;
                        reloadItemEarthStone = false;
                        reloadItemMindStone = false;
                        reloadItemSection = false;
                        PlayerMedSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                        break;

                    /*Selects Repel*/
                    case ConsoleKey.DownArrow:
                        do
                        {
                            Console.SetCursorPosition(0, 0);
                            Console.Write(" ");
                            //Console.Write(player.PlayerInv.BagSlot1.SelectRepel());
                            //Console.Write(ASCII.defaultMessageDisplay);
                            //Console.Write(ASCII.gameButtons);
                            navPlayerMenu = Console.ReadKey().Key;
                            switch (navPlayerMenu)
                            {
                                case ConsoleKey.Enter:
                                    //TODO Add GIVE/TOSS/CANCEL Functionality
                                    break;
                                case ConsoleKey.RightArrow:
                                    reloadItemRepel = false;
                                    reloadItemBlazeStone = false;
                                    reloadItemAquaStone = false;
                                    reloadItemPowerStone = false;
                                    reloadItemEarthStone = false;
                                    reloadItemMindStone = false;
                                    reloadItemSection = false;
                                    PlayerMedSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                                    break;

                                case ConsoleKey.UpArrow:
                                    reloadItemRepel = false;
                                    reloadItemBlazeStone = false;
                                    reloadItemAquaStone = false;
                                    reloadItemPowerStone = false;
                                    reloadItemEarthStone = false;
                                    reloadItemMindStone = false;
                                    reloadItemSection = true;
                                    break;

                                /*Selects Blaze Stone*/
                                case ConsoleKey.DownArrow:
                                    do
                                    {
                                        Console.SetCursorPosition(0, 0);
                                        Console.Write(" ");
                                        //Console.Write(player.PlayerInv.BagSlot1.SelectBlazeStone());
                                        //Console.Write(ASCII.defaultMessageDisplay);
                                        //Console.Write(ASCII.gameButtons);
                                        navPlayerMenu = Console.ReadKey().Key;
                                        switch (navPlayerMenu)
                                        {
                                            case ConsoleKey.Enter:
                                                //TODO Add GIVE/TOSS/CANCEL Functionality
                                                break;
                                            case ConsoleKey.RightArrow:
                                                reloadItemRepel = false;
                                                reloadItemBlazeStone = false;
                                                reloadItemAquaStone = false;
                                                reloadItemPowerStone = false;
                                                reloadItemEarthStone = false;
                                                reloadItemMindStone = false;
                                                reloadItemSection = false;
                                                PlayerMedSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                                                break;

                                            case ConsoleKey.UpArrow:
                                                reloadItemRepel = true;
                                                reloadItemBlazeStone = false;
                                                reloadItemAquaStone = false;
                                                reloadItemPowerStone = false;
                                                reloadItemEarthStone = false;
                                                reloadItemMindStone = false;
                                                break;

                                            /*Selects AquaStone*/
                                            case ConsoleKey.DownArrow:
                                                do
                                                {
                                                    Console.SetCursorPosition(0, 0);
                                                    Console.Write(" ");
                                                    //Console.Write(player.PlayerInv.BagSlot1.SelectAquaStone());
                                                    //Console.Write(ASCII.defaultMessageDisplay);
                                                    //Console.Write(ASCII.gameButtons);
                                                    navPlayerMenu = Console.ReadKey().Key;
                                                    switch (navPlayerMenu)
                                                    {
                                                        case ConsoleKey.Enter:
                                                            //TODO Add GIVE/TOSS/CANCEL Functionality
                                                            break;
                                                        case ConsoleKey.RightArrow:
                                                            reloadItemRepel = false;
                                                            reloadItemBlazeStone = false;
                                                            reloadItemAquaStone = false;
                                                            reloadItemPowerStone = false;
                                                            reloadItemEarthStone = false;
                                                            reloadItemMindStone = false;
                                                            reloadItemSection = false;
                                                            PlayerMedSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                                                            break;

                                                        case ConsoleKey.UpArrow:
                                                            reloadItemBlazeStone = true;
                                                            reloadItemAquaStone = false;
                                                            reloadItemPowerStone = false;
                                                            reloadItemEarthStone = false;
                                                            reloadItemMindStone = false;
                                                            break;

                                                        /*Selects Power Stone*/
                                                        case ConsoleKey.DownArrow:
                                                            do
                                                            {
                                                                Console.SetCursorPosition(0, 0);
                                                                Console.Write(" ");
                                                                //Console.Write(player.PlayerInv.BagSlot1.SelectPowerStone());
                                                                //Console.Write(ASCII.defaultMessageDisplay);
                                                                //Console.Write(ASCII.gameButtons);
                                                                navPlayerMenu = Console.ReadKey().Key;
                                                                switch (navPlayerMenu)
                                                                {
                                                                    case ConsoleKey.Enter:
                                                                        //TODO Add GIVE/TOSS/CANCEL Functionality
                                                                        break;
                                                                    case ConsoleKey.RightArrow:
                                                                        reloadItemRepel = false;
                                                                        reloadItemBlazeStone = false;
                                                                        reloadItemAquaStone = false;
                                                                        reloadItemPowerStone = false;
                                                                        reloadItemEarthStone = false;
                                                                        reloadItemMindStone = false;
                                                                        reloadItemSection = false;
                                                                        PlayerMedSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                                                                        break;

                                                                    case ConsoleKey.UpArrow:
                                                                        reloadItemAquaStone = true;
                                                                        reloadItemPowerStone = false;
                                                                        reloadItemEarthStone = false;
                                                                        reloadItemMindStone = false;
                                                                        break;

                                                                    /*Selects Earth Stone*/
                                                                    case ConsoleKey.DownArrow:
                                                                        do
                                                                        {
                                                                            Console.SetCursorPosition(0, 0);
                                                                            Console.Write(" ");
                                                                            //Console.Write(player.PlayerInv.BagSlot1.SelectEarthStone());
                                                                            //Console.Write(ASCII.defaultMessageDisplay);
                                                                            //Console.Write(ASCII.gameButtons);
                                                                            navPlayerMenu = Console.ReadKey().Key;
                                                                            switch (navPlayerMenu)
                                                                            {
                                                                                case ConsoleKey.Enter:
                                                                                    //TODO Add GIVE/TOSS/CANCEL Functionality
                                                                                    break;
                                                                                case ConsoleKey.RightArrow:
                                                                                    reloadItemRepel = false;
                                                                                    reloadItemBlazeStone = false;
                                                                                    reloadItemAquaStone = false;
                                                                                    reloadItemPowerStone = false;
                                                                                    reloadItemEarthStone = false;
                                                                                    reloadItemMindStone = false;
                                                                                    reloadItemSection = false;
                                                                                    PlayerMedSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                                                                                    break;

                                                                                case ConsoleKey.UpArrow:
                                                                                    reloadItemPowerStone = true;
                                                                                    reloadItemEarthStone = false;
                                                                                    reloadItemMindStone = false;
                                                                                    break;

                                                                                /*Selects Mind Stone*/
                                                                                case ConsoleKey.DownArrow:
                                                                                    do
                                                                                    {
                                                                                        Console.SetCursorPosition(0, 0);
                                                                                        Console.Write(" ");
                                                                                        //Console.Write(player.PlayerInv.BagSlot1.SelectMindStone());
                                                                                        //Console.Write(ASCII.defaultMessageDisplay);
                                                                                        //Console.Write(ASCII.gameButtons);
                                                                                        navPlayerMenu = Console.ReadKey().Key;
                                                                                        switch (navPlayerMenu)
                                                                                        {
                                                                                            case ConsoleKey.Enter:
                                                                                                break;
                                                                                            case ConsoleKey.RightArrow:
                                                                                                reloadItemRepel = false;
                                                                                                reloadItemBlazeStone = false;
                                                                                                reloadItemAquaStone = false;
                                                                                                reloadItemPowerStone = false;
                                                                                                reloadItemEarthStone = false;
                                                                                                reloadItemMindStone = false;
                                                                                                reloadItemSection = false;
                                                                                                PlayerMedSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                                                                                                break;
                                                                                            case ConsoleKey.UpArrow:
                                                                                                reloadItemEarthStone = true;
                                                                                                reloadItemMindStone = false;
                                                                                                break;
                                                                                            case ConsoleKey.Backspace:
                                                                                                Console.SetCursorPosition(0, 0);
                                                                                                Console.Write(" ");
                                                                                                //Console.Write(player.PlayerInv.BagSlot1.SelectMindStone());
                                                                                                //Console.Write(ASCII.messageDisplayYesNoSwitch);
                                                                                                //Console.Write(ASCII.gameButtons);
                                                                                                navPlayerMenu = Console.ReadKey().Key;
                                                                                                switch (navPlayerMenu)
                                                                                                {
                                                                                                    case ConsoleKey.Y:
                                                                                                    case ConsoleKey.Enter:
                                                                                                        reloadItemMindStone = false;
                                                                                                        break;
                                                                                                    case ConsoleKey.N:
                                                                                                    case ConsoleKey.Backspace:
                                                                                                        reloadItemMindStone = true;
                                                                                                        break;
                                                                                                    default:
                                                                                                        reloadItemMindStone = true;
                                                                                                        break;
                                                                                                }
                                                                                                break;
                                                                                            default:
                                                                                                reloadItemMindStone = true;
                                                                                                break;
                                                                                        }//end switch navPlayerMenu
                                                                                    } while (reloadItemMindStone);//end Do-While reloadMindStone
                                                                                    break;
                                                                                case ConsoleKey.Backspace:
                                                                                    Console.SetCursorPosition(0, 0);
                                                                                    Console.Write(" ");
                                                                                    //Console.Write(player.PlayerInv.BagSlot1.SelectEarthStone());
                                                                                    //Console.Write(ASCII.messageDisplayYesNoSwitch);
                                                                                    //Console.Write(ASCII.gameButtons);
                                                                                    navPlayerMenu = Console.ReadKey().Key;
                                                                                    switch (navPlayerMenu)
                                                                                    {
                                                                                        case ConsoleKey.Y:
                                                                                        case ConsoleKey.Enter:
                                                                                            reloadItemEarthStone = false;
                                                                                            break;
                                                                                        case ConsoleKey.N:
                                                                                        case ConsoleKey.Backspace:
                                                                                            reloadItemEarthStone = true;
                                                                                            break;
                                                                                        default:
                                                                                            reloadItemEarthStone = true;
                                                                                            break;
                                                                                    }
                                                                                    break;
                                                                                default:
                                                                                    reloadItemEarthStone = true;
                                                                                    break;
                                                                            }//end switch navPlayerMenu
                                                                        } while (reloadItemEarthStone);//end Do-While reloadEarthStone
                                                                        break;
                                                                    case ConsoleKey.Backspace:
                                                                        Console.SetCursorPosition(0, 0);
                                                                        Console.Write(" ");
                                                                        //Console.Write(player.PlayerInv.BagSlot1.SelectPowerStone());
                                                                        //Console.Write(ASCII.messageDisplayYesNoSwitch);
                                                                        //Console.Write(ASCII.gameButtons);
                                                                        navPlayerMenu = Console.ReadKey().Key;
                                                                        switch (navPlayerMenu)
                                                                        {
                                                                            case ConsoleKey.Y:
                                                                            case ConsoleKey.Enter:
                                                                                reloadItemPowerStone = false;
                                                                                break;
                                                                            case ConsoleKey.N:
                                                                            case ConsoleKey.Backspace:
                                                                                reloadItemPowerStone = true;
                                                                                break;
                                                                            default:
                                                                                reloadItemPowerStone = true;
                                                                                break;
                                                                        }
                                                                        break;
                                                                    default:
                                                                        reloadItemPowerStone = true;
                                                                        break;
                                                                }//end switch navPlayerMenu
                                                            } while (reloadItemPowerStone);//end Do-While reloadPowerStone
                                                            break;
                                                        case ConsoleKey.Backspace:
                                                            Console.SetCursorPosition(0, 0);
                                                            Console.Write(" ");
                                                            //Console.Write(player.PlayerInv.BagSlot1.SelectAquaStone());
                                                            //Console.Write(ASCII.messageDisplayYesNoSwitch);
                                                            //Console.Write(ASCII.gameButtons);
                                                            navPlayerMenu = Console.ReadKey().Key;
                                                            switch (navPlayerMenu)
                                                            {
                                                                case ConsoleKey.Y:
                                                                case ConsoleKey.Enter:
                                                                    reloadItemAquaStone = false;
                                                                    break;
                                                                case ConsoleKey.N:
                                                                case ConsoleKey.Backspace:
                                                                    reloadItemAquaStone = true;
                                                                    break;
                                                                default:
                                                                    reloadItemAquaStone = true;
                                                                    break;
                                                            }
                                                            break;
                                                        default:
                                                            reloadItemAquaStone = true;
                                                            break;
                                                    }//end switch navPlayerMenu
                                                } while (reloadItemAquaStone);//end Do-While reloadAquaStone
                                                break;
                                            case ConsoleKey.Backspace:
                                                Console.SetCursorPosition(0, 0);
                                                Console.Write(" ");
                                                //Console.Write(player.PlayerInv.BagSlot1.SelectBlazeStone());
                                                //Console.Write(ASCII.messageDisplayYesNoSwitch);
                                                //Console.Write(ASCII.gameButtons);
                                                navPlayerMenu = Console.ReadKey().Key;
                                                switch (navPlayerMenu)
                                                {
                                                    case ConsoleKey.Y:
                                                    case ConsoleKey.Enter:
                                                        reloadItemBlazeStone = false;
                                                        break;
                                                    case ConsoleKey.N:
                                                    case ConsoleKey.Backspace:
                                                        reloadItemBlazeStone = true;
                                                        break;
                                                    default:
                                                        reloadItemBlazeStone = true;
                                                        break;
                                                }
                                                break;
                                            default:
                                                reloadItemBlazeStone = true;
                                                break;
                                        }//end switch navPlayerMenu
                                    } while (reloadItemBlazeStone);//end Do-While reloadBlazeStone
                                    break;
                                case ConsoleKey.Backspace:
                                    Console.SetCursorPosition(0, 0);
                                    Console.Write(" ");
                                    //Console.Write(player.PlayerInv.BagSlot1.SelectRepel());
                                    //Console.Write(ASCII.messageDisplayYesNoSwitch);
                                    //Console.Write(ASCII.gameButtons);
                                    navPlayerMenu = Console.ReadKey().Key;
                                    switch (navPlayerMenu)
                                    {
                                        case ConsoleKey.Y:
                                        case ConsoleKey.Enter:
                                            reloadItemRepel = false;
                                            break;
                                        case ConsoleKey.N:
                                        case ConsoleKey.Backspace:
                                            reloadItemRepel = true;
                                            break;
                                        default:
                                            reloadItemRepel = true;
                                            break;
                                    }
                                    break;
                                default:
                                    reloadItemRepel = true;
                                    break;
                            }//end switch navPlayerMenu
                        } while (reloadItemRepel);//end Do-While reloadRepel
                        break;
                    case ConsoleKey.Backspace:
                        Console.SetCursorPosition(0, 0);
                        Console.Write(" ");
                        //Console.Write(player.PlayerInv.BagSlot1);
                        //Console.Write(ASCII.messageDisplayYesNoSwitch);
                        //Console.Write(ASCII.gameButtons);
                        navPlayerMenu = Console.ReadKey().Key;
                        switch (navPlayerMenu)
                        {
                            case ConsoleKey.Y:
                            case ConsoleKey.Enter:
                                reloadItemSection = false;
                                break;
                            case ConsoleKey.N:
                            case ConsoleKey.Backspace:
                                reloadItemSection = true;
                                break;
                            default:
                                reloadItemSection = true;
                                break;
                        }
                        break;
                    default:
                        reloadItemSection = true;
                        break;
                }//end switch navPlayerMenu
            } while (reloadItemSection);//end Do-While reloadItemSection      

        }//end ItemSection()

        public static void PlayerMedSection(Player player, Monster monster, ConsoleKey navPlayerMenu, ConsoleColor GameScreenText, ConsoleColor GameScreenBackground)
        {
            bool reloadItemSection = true; //Replace with ItemSection()
            bool reloadMedSection = false;
            bool reloadMedFullHeal = false;
            bool reloadMedFullRevive = false;
            bool reloadMedHPUp = false;
            bool reloadMedAttackUp = false;

            do
            {
                Console.SetCursorPosition(0, 0);
                Console.Write(" ");
                //Console.Write(player.PlayerInv.BagSlot2);
                //Console.Write(ASCII.defaultMessageDisplay);
                //Console.Write(ASCII.gameButtons);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.Enter:
                        //TODO Add Use Functionality
                        break;
                    case ConsoleKey.RightArrow:
                        PlayerMovesSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                        break;
                    case ConsoleKey.LeftArrow:
                        PlayerItemSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                        reloadMedSection = false;
                        reloadMedFullHeal = false;
                        reloadMedFullRevive = false;
                        reloadMedHPUp = false;
                        reloadMedAttackUp = false;
                        break;
                    case ConsoleKey.DownArrow:
                        do
                        {
                            Console.SetCursorPosition(0, 0);
                            Console.Write(" ");
                            //Console.Write(player.PlayerInv.BagSlot2.SelectFullHeal());
                            //Console.Write(ASCII.defaultMessageDisplay);
                            //Console.Write(ASCII.gameButtons);
                            navPlayerMenu = Console.ReadKey().Key;
                            switch (navPlayerMenu)
                            {
                                case ConsoleKey.Enter:
                                    //TODO Add Use Functionality
                                    break;
                                case ConsoleKey.RightArrow:
                                    PlayerMovesSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                                    break;
                                case ConsoleKey.LeftArrow:
                                    PlayerItemSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                                    reloadMedSection = false;
                                    reloadMedFullHeal = false;
                                    reloadMedFullRevive = false;
                                    reloadMedHPUp = false;
                                    reloadMedAttackUp = false;
                                    break;
                                case ConsoleKey.UpArrow:
                                    reloadMedSection = true;
                                    reloadMedFullHeal = false;
                                    reloadMedFullRevive = false;
                                    reloadMedHPUp = false;
                                    reloadMedAttackUp = false;
                                    break;
                                case ConsoleKey.DownArrow:
                                    do
                                    {
                                        Console.SetCursorPosition(0, 0);
                                        Console.Write(" ");
                                        //Console.Write(player.PlayerInv.BagSlot2.SelectFullRevive());
                                        //Console.Write(ASCII.defaultMessageDisplay);
                                        //Console.Write(ASCII.gameButtons);
                                        navPlayerMenu = Console.ReadKey().Key;
                                        switch (navPlayerMenu)
                                        {
                                            case ConsoleKey.Enter:
                                                //TODO Add Use Functionality
                                                break;
                                            case ConsoleKey.RightArrow:
                                                PlayerMovesSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                                                break;
                                            case ConsoleKey.LeftArrow:
                                                PlayerItemSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                                                reloadMedSection = false;
                                                reloadMedFullHeal = false;
                                                reloadMedFullRevive = false;
                                                reloadMedHPUp = false;
                                                reloadMedAttackUp = false;
                                                break;
                                            case ConsoleKey.UpArrow:
                                                reloadMedFullHeal = true;
                                                reloadMedFullRevive = false;
                                                reloadMedHPUp = false;
                                                reloadMedAttackUp = false;
                                                break;
                                            case ConsoleKey.DownArrow:
                                                do
                                                {
                                                    Console.SetCursorPosition(0, 0);
                                                    Console.Write(" ");
                                                    //Console.Write(player.PlayerInv.BagSlot2.SelectHPUp());
                                                    //Console.Write(ASCII.defaultMessageDisplay);
                                                    //Console.Write(ASCII.gameButtons);
                                                    navPlayerMenu = Console.ReadKey().Key;
                                                    switch (navPlayerMenu)
                                                    {
                                                        case ConsoleKey.Enter:
                                                            //TODO Add Use Functionality
                                                            break;
                                                        case ConsoleKey.RightArrow:
                                                            PlayerMovesSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                                                            break;
                                                        case ConsoleKey.LeftArrow:
                                                            PlayerItemSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                                                            reloadMedSection = false;
                                                            reloadMedFullHeal = false;
                                                            reloadMedFullRevive = false;
                                                            reloadMedHPUp = false;
                                                            reloadMedAttackUp = false;
                                                            break;
                                                        case ConsoleKey.UpArrow:
                                                            reloadMedFullRevive = true;
                                                            reloadMedHPUp = false;
                                                            reloadMedAttackUp = false;
                                                            break;
                                                        case ConsoleKey.DownArrow:
                                                            do
                                                            {
                                                                Console.SetCursorPosition(0, 0);
                                                                Console.Write(" ");
                                                                //Console.Write(player.PlayerInv.BagSlot2.SelectAttackUp());
                                                                //Console.Write(ASCII.defaultMessageDisplay);
                                                                //Console.Write(ASCII.gameButtons);
                                                                navPlayerMenu = Console.ReadKey().Key;
                                                                switch (navPlayerMenu)
                                                                {
                                                                    case ConsoleKey.Enter:
                                                                        //TODO Add Use Functionality
                                                                        break;
                                                                    case ConsoleKey.RightArrow:
                                                                        PlayerMovesSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                                                                        break;
                                                                    case ConsoleKey.LeftArrow:
                                                                        PlayerItemSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                                                                        reloadMedSection = false;
                                                                        reloadMedFullHeal = false;
                                                                        reloadMedFullRevive = false;
                                                                        reloadMedHPUp = false;
                                                                        reloadMedAttackUp = false;
                                                                        break;
                                                                    case ConsoleKey.UpArrow:
                                                                        reloadMedHPUp = true;
                                                                        reloadMedAttackUp = false;
                                                                        break;
                                                                    case ConsoleKey.Backspace:
                                                                        Console.SetCursorPosition(0, 0);
                                                                        Console.Write(" ");
                                                                        //Console.Write(player.PlayerInv.BagSlot2.SelectAttackUp());
                                                                        //Console.Write(ASCII.messageDisplayYesNoSwitch);
                                                                        //Console.Write(ASCII.gameButtons);
                                                                        navPlayerMenu = Console.ReadKey().Key;
                                                                        switch (navPlayerMenu)
                                                                        {
                                                                            case ConsoleKey.Y:
                                                                            case ConsoleKey.Enter:
                                                                                reloadMedAttackUp = false;
                                                                                break;
                                                                            case ConsoleKey.N:
                                                                            case ConsoleKey.Backspace:
                                                                                reloadMedAttackUp = true;
                                                                                break;
                                                                            default:
                                                                                reloadMedAttackUp = true;
                                                                                break;
                                                                        }
                                                                        break;
                                                                    default:
                                                                        reloadMedAttackUp = true;
                                                                        break;
                                                                }
                                                            } while (reloadMedAttackUp);
                                                            break;
                                                        case ConsoleKey.Backspace:
                                                            Console.SetCursorPosition(0, 0);
                                                            Console.Write(" ");
                                                            //Console.Write(player.PlayerInv.BagSlot2.SelectHPUp());
                                                            //Console.Write(ASCII.messageDisplayYesNoSwitch);
                                                            //Console.Write(ASCII.gameButtons);
                                                            navPlayerMenu = Console.ReadKey().Key;
                                                            switch (navPlayerMenu)
                                                            {
                                                                case ConsoleKey.Y:
                                                                case ConsoleKey.Enter:
                                                                    reloadMedHPUp = false;
                                                                    break;
                                                                case ConsoleKey.N:
                                                                case ConsoleKey.Backspace:
                                                                    reloadMedHPUp = true;
                                                                    break;
                                                                default:
                                                                    reloadMedHPUp = true;
                                                                    break;
                                                            }
                                                            break;
                                                        default:
                                                            reloadMedHPUp = true;
                                                            break;
                                                    }
                                                } while (reloadMedHPUp);
                                                break;
                                            case ConsoleKey.Backspace:
                                                Console.SetCursorPosition(0, 0);
                                                Console.Write(" ");
                                                //Console.Write(player.PlayerInv.BagSlot2.SelectFullRevive());
                                                //Console.Write(ASCII.messageDisplayYesNoSwitch);
                                                //Console.Write(ASCII.gameButtons);
                                                navPlayerMenu = Console.ReadKey().Key;
                                                switch (navPlayerMenu)
                                                {
                                                    case ConsoleKey.Y:
                                                    case ConsoleKey.Enter:
                                                        reloadMedFullRevive = false;
                                                        break;
                                                    case ConsoleKey.N:
                                                    case ConsoleKey.Backspace:
                                                        reloadMedFullRevive = true;
                                                        break;
                                                    default:
                                                        reloadMedFullRevive = true;
                                                        break;
                                                }
                                                break;
                                            default:
                                                reloadMedFullRevive = true;
                                                break;
                                        }
                                    } while (reloadMedFullRevive);
                                    break;
                                case ConsoleKey.Backspace:
                                    Console.SetCursorPosition(0, 0);
                                    Console.Write(" ");
                                    //Console.Write(player.PlayerInv.BagSlot2.SelectFullHeal());
                                    //Console.Write(ASCII.messageDisplayYesNoSwitch);
                                    //Console.Write(ASCII.gameButtons);
                                    navPlayerMenu = Console.ReadKey().Key;
                                    switch (navPlayerMenu)
                                    {
                                        case ConsoleKey.Y:
                                        case ConsoleKey.Enter:
                                            reloadMedFullHeal = false;
                                            break;
                                        case ConsoleKey.N:
                                        case ConsoleKey.Backspace:
                                            reloadMedFullHeal = true;
                                            break;
                                        default:
                                            reloadMedFullHeal = true;
                                            break;
                                    }
                                    break;
                                default:
                                    reloadMedFullHeal = true;
                                    break;
                            }
                        } while (reloadMedFullHeal);
                        break;
                    case ConsoleKey.Backspace:
                        Console.SetCursorPosition(0, 0);
                        Console.Write(" ");
                        //Console.Write(player.PlayerInv.BagSlot2);
                        //Console.Write(ASCII.messageDisplayYesNoSwitch);
                        //Console.Write(ASCII.gameButtons);
                        navPlayerMenu = Console.ReadKey().Key;
                        switch (navPlayerMenu)
                        {
                            case ConsoleKey.Y:
                            case ConsoleKey.Enter:
                                reloadMedSection = false;
                                break;
                            case ConsoleKey.N:
                            case ConsoleKey.Backspace:
                                reloadMedSection = true;
                                break;
                            default:
                                reloadMedSection = true;
                                break;
                        }
                        break;
                    default:
                        reloadMedSection = true;
                        break;
                }
            } while (reloadMedSection);//end Do-While reloadMedSection

        }//end MedSection()

        public static void PlayerMovesSection(Player player, Monster monster, ConsoleKey navPlayerMenu, ConsoleColor GameScreenText, ConsoleColor GameScreenBackground)
        {
            bool reloadMedSection = false; //replace with MedSection()
            bool reloadBASection = true; //replace with BattleItemsSection()
            bool reloadMovesSection = false;

            do
            {
                Console.SetCursorPosition(0, 0);
                Console.Write(" ");
                //Console.Write(player.PlayerInv.BagSlot3);
                //Console.Write(ASCII.defaultMessageDisplay);
                //Console.Write(ASCII.gameButtons);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.Enter:
                        //TODO Paste Use Item Functionality
                        break;
                    case ConsoleKey.RightArrow:
                        PlayerBattleItemSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                        reloadMovesSection = false;
                        break;
                    case ConsoleKey.LeftArrow:
                        PlayerMedSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                        reloadMovesSection = false;
                        break;
                    case ConsoleKey.DownArrow:
                        //TODO Paste Future Player Moves Inventory
                        break;
                    case ConsoleKey.Backspace:
                        Console.SetCursorPosition(0, 0);
                        Console.Write(" ");
                        //Console.Write(player.PlayerInv.BagSlot3);
                        //Console.Write(ASCII.messageDisplayYesNoSwitch);
                        //Console.Write(ASCII.gameButtons);
                        navPlayerMenu = Console.ReadKey().Key;
                        switch (navPlayerMenu)
                        {
                            case ConsoleKey.Y:
                            case ConsoleKey.Enter:
                                reloadMovesSection = false;
                                break;
                            case ConsoleKey.N:
                            case ConsoleKey.Backspace:
                                reloadMovesSection = true;
                                break;
                            default:
                                reloadMovesSection = true;
                                break;
                        }
                        break;
                    default:
                        reloadMovesSection = true;
                        break;
                }
            } while (reloadMovesSection);

        }//end MovesSection()

        public static void PlayerBattleItemSection(Player player, Monster monster, ConsoleKey navPlayerMenu, ConsoleColor GameScreenText, ConsoleColor GameScreenBackground)
        {
            bool reloadMovesSection = false; //Replace with MovesSection()
            bool reloadBASection = false;

            do
            {
                Console.SetCursorPosition(0, 0);
                Console.Write(" ");
                //Console.Write(player.PlayerInv.BagSlot4);
                //Console.Write(ASCII.defaultMessageDisplay);
                //Console.Write(ASCII.gameButtons);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.Enter:
                        //TODO Paste Use Item Functionality
                        break;
                    case ConsoleKey.LeftArrow:
                        PlayerMovesSection(player, monster, navPlayerMenu, GameScreenText, GameScreenBackground);
                        reloadBASection = false;
                        break;
                    case ConsoleKey.DownArrow:
                        //TODO Paste Future Player Moves Inventory
                        break;
                    case ConsoleKey.Backspace:
                        Console.SetCursorPosition(0, 0);
                        Console.Write(" ");
                        //Console.Write(player.PlayerInv.BagSlot4);
                        //Console.Write(ASCII.messageDisplayYesNoSwitch);
                        //Console.Write(ASCII.gameButtons);
                        navPlayerMenu = Console.ReadKey().Key;
                        switch (navPlayerMenu)
                        {
                            case ConsoleKey.Y:
                            case ConsoleKey.Enter:
                                reloadBASection = false;
                                break;
                            case ConsoleKey.N:
                            case ConsoleKey.Backspace:
                                reloadBASection = true;
                                break;
                            default:
                                reloadBASection = true;
                                break;
                        }
                        break;
                    default:
                        reloadBASection = true;
                        break;
                }
            } while (reloadBASection);

        }//end BattleItemsSection()

        #endregion

        #region Player Menu Profile



        #endregion
    }
}
