using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MainClasses
{
    public class Player_Menus
    {
        /****GENERAL MENUS****/

        #region General Menu

        public static void QueSwitch(Player player, Monster monster, int slot, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadBattleFAINT = false;
            int posY = 22;

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
                        reloadBattleFAINT = true;
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
                        reloadBattleFAINT = true;
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.K:
                        if (posY == 22)
                        {
                            if (slot == 0)
                            {
                                PlayerPartyMenuBattle(player, monster, navPlayerMenu, gbText, gbBackground);
                                reloadBattleFAINT = false;
                            }
                            else
                            {
                                ASCII.ANIPlayerSwitchSendTEST(player, slot, monster, gbText, gbBackground);
                                reloadBattleFAINT = false;
                            }
                        }
                        else if (posY == 23)
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

        public static void PlayerSwitchMenu(Player player, Monster monster, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadBattleFAINT = false;
            string message1 = $"Will you send out another PokeFraud?";
            int posY = 22;

            ASCII.InstantMessage(message1, gbText, gbBackground);
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
                        reloadBattleFAINT = true;
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
                        reloadBattleFAINT = true;
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.K:
                        if (posY == 22)
                        {
                            BattlePartySwitch(player, monster, navPlayerMenu, gbText, gbBackground);
                        }
                        if (posY == 23)
                        {
                            //SFX.RunAway();
                            string message2 = $"{player.Name.ToUpper()} fled to safety!";
                            ASCII.ScrollMessage(message2, 15, 2000, gbText, gbBackground);
                            reloadBattleFAINT = false;
                        }
                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        //SFX.RunAway();
                        string message = $"{player.Name.ToUpper()} fled to safety!";
                        ASCII.ScrollMessage(message, 15, 2000, gbText, gbBackground);
                        reloadBattleFAINT = false;
                        break;
                    default:
                        reloadBattleFAINT = true;
                        break;
                }
            } while (reloadBattleFAINT);
        }

        #endregion

        /****FIGHT MENU****/

        #region Fight Menu

        public static void FightMenu(Player player, Monster monster, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadBattleFIGHT = false;
            bool reloadBattleBAG = false;
            bool reloadBattlePOKeFRAUD = false;
            bool reloadBattleRUN = false;
            bool reloadBattleFAINT = false;
            string message1 = $"Will you send out another PokeFraud?";

            do
            {
                //Displays Select Fight
                ASCII.DISSelectFight(player.Party.MonsterEquipped, gbText, gbBackground);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.K:
                    case ConsoleKey.Enter:
                        FightMovesMenu(player, monster, navPlayerMenu, gbText, gbBackground);
                        if (monster.Health <= 0)
                        {
                            ASCII.ANIDefenderFaint(monster, gbText, gbBackground);
                            //TODO ADD CalcEXP() HERE!!!
                            Combat.CalcExp(player, monster, gbText, gbBackground);
                            reloadBattleFIGHT = false;
                            reloadBattleBAG = false;
                            reloadBattlePOKeFRAUD = false;
                            reloadBattleRUN = false;
                        }
                        else if (player.Party.MonsterEquipped.Health <= 0)
                        {
                            ASCII.ANIAttackerFaint(player, gbText, gbBackground);
                            ASCII.ScrollMessage(message1, 50, 25, gbText, gbBackground);
                            int posY = 22;

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
                                        reloadBattleFAINT = true;
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
                                        reloadBattleFAINT = true;
                                        break;
                                    case ConsoleKey.Enter:
                                    case ConsoleKey.K:
                                        if (posY == 22)
                                        {
                                            BattlePartySwitch(player, monster, navPlayerMenu, gbText, gbBackground);
                                            reloadBattleFAINT = false;
                                        }
                                        if (posY == 23)
                                        {
                                            //SFX.RunAway();
                                            string message2 = $"{player.Name.ToUpper()} fled to safety!";
                                            ASCII.ScrollMessage(message2, 15, 2000, gbText, gbBackground);
                                            reloadBattleFAINT = false;
                                        }
                                        break;
                                    case ConsoleKey.Backspace:
                                    case ConsoleKey.O:
                                        //SFX.RunAway();
                                        string message = $"{player.Name.ToUpper()} fled to safety!";
                                        ASCII.ScrollMessage(message, 15, 2000, gbText, gbBackground);
                                        reloadBattleFAINT = false;
                                        break;
                                    default:
                                        reloadBattleFAINT = true;
                                        break;
                                }
                            } while (reloadBattleFAINT);
                            reloadBattleFIGHT = true;
                            reloadBattleBAG = false;
                            reloadBattlePOKeFRAUD = false;
                            reloadBattleRUN = false;
                        }
                        else
                        {
                            ASCII.DISATTandDEF(player, monster, gbText, gbBackground);
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
                            //Displays Select Bag                            
                            ASCII.DISSelectBag(player.Party.MonsterEquipped, gbText, gbBackground);
                            navPlayerMenu = Console.ReadKey().Key;
                            switch (navPlayerMenu)
                            {
                                case ConsoleKey.K:
                                case ConsoleKey.Enter:
                                    ASCII.StaticMessageBox(gbText, gbBackground);
                                    BattleItemSection(player.Inventory.ItemSection, player.Inventory.MedSection, player, monster, navPlayerMenu, gbText, gbBackground);
                                    if (monster.IsCaught == true)
                                    {
                                        //monster.IsCaught = false;
                                        reloadBattleFIGHT = false;
                                        reloadBattleBAG = false;
                                        reloadBattlePOKeFRAUD = false;
                                        reloadBattleRUN = false;
                                    }
                                    else
                                    {
                                        ASCII.DISATTandDEF(player, monster, gbText, gbBackground);
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
                                        //Displays Select Run
                                        ASCII.DISSelectRun(player.Party.MonsterEquipped, gbText, gbBackground);
                                        navPlayerMenu = Console.ReadKey().Key;
                                        switch (navPlayerMenu)
                                        {
                                            case ConsoleKey.K:
                                            case ConsoleKey.Enter:
                                                //SFX.RunAway();
                                                string message = $"{player.Name.ToUpper()} fled to safety!";
                                                ASCII.ScrollMessage(message, 15, 2000, gbText, gbBackground);
                                                reloadBattleFIGHT = false;
                                                reloadBattleBAG = false;
                                                reloadBattlePOKeFRAUD = false;
                                                reloadBattleRUN = false;
                                                break;
                                            case ConsoleKey.A:
                                            case ConsoleKey.LeftArrow:
                                                do
                                                {
                                                    //Displays Select Party
                                                    ASCII.DISSelectParty(player.Party.MonsterEquipped, gbText, gbBackground);
                                                    navPlayerMenu = Console.ReadKey().Key;
                                                    switch (navPlayerMenu)
                                                    {
                                                        case ConsoleKey.K:
                                                        case ConsoleKey.Enter:
                                                            //BattlePartySwitch(player, monster, navPlayerMenu, gbText, gbBackground);
                                                            PlayerPartyMenuBattle(player, monster, navPlayerMenu, gbText, gbBackground);
                                                            ASCII.DISATTandDEF(player, monster, gbText, gbBackground);
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
                            //Displays Select Party                            
                            ASCII.DISSelectParty(player.Party.MonsterEquipped, gbText, gbBackground);
                            navPlayerMenu = Console.ReadKey().Key;
                            switch (navPlayerMenu)
                            {
                                case ConsoleKey.K:
                                case ConsoleKey.Enter:
                                    //BattlePartySwitch(player, monster, navPlayerMenu, gbText, gbBackground);
                                    PlayerPartyMenuBattle(player, monster, navPlayerMenu, gbText, gbBackground);
                                    ASCII.DISATTandDEF(player, monster, gbText, gbBackground);
                                    reloadBattleFIGHT = true;
                                    reloadBattleBAG = false;
                                    reloadBattlePOKeFRAUD = false;
                                    reloadBattleRUN = false;
                                    break;
                                case ConsoleKey.D:
                                case ConsoleKey.RightArrow:
                                    do
                                    {
                                        //Displays Select Run
                                        ASCII.DISSelectRun(player.Party.MonsterEquipped, gbText, gbBackground);
                                        navPlayerMenu = Console.ReadKey().Key;
                                        switch (navPlayerMenu)
                                        {
                                            case ConsoleKey.K:
                                            case ConsoleKey.Enter:
                                                //SFX.RunAway();
                                                string message = $"{player.Name.ToUpper()} fled to safety!";
                                                ASCII.ScrollMessage(message, 15, 2000, gbText, gbBackground);
                                                reloadBattleFIGHT = false;
                                                reloadBattleBAG = false;
                                                reloadBattlePOKeFRAUD = false;
                                                reloadBattleRUN = false;
                                                break;
                                            case ConsoleKey.W:
                                            case ConsoleKey.UpArrow:
                                                do
                                                {
                                                    //Displays Select Bag
                                                    ASCII.DISSelectBag(player.Party.MonsterEquipped, gbText, gbBackground);
                                                    navPlayerMenu = Console.ReadKey().Key;
                                                    switch (navPlayerMenu)
                                                    {
                                                        case ConsoleKey.K:
                                                        case ConsoleKey.Enter:
                                                            ASCII.StaticMessageBox(gbText, gbBackground);
                                                            BattleItemSection(player.Inventory.ItemSection, player.Inventory.MedSection, player, monster, navPlayerMenu, gbText, gbBackground);
                                                            if (monster.IsCaught == true)
                                                            {
                                                                reloadBattleFIGHT = false;
                                                                reloadBattleBAG = false;
                                                                reloadBattlePOKeFRAUD = false;
                                                                reloadBattleRUN = false;
                                                            }
                                                            else
                                                            {
                                                                ASCII.DISATTandDEF(player, monster, gbText, gbBackground);
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

        public static void NPCFightMenu(Player player, Player npc, int loserPays, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadBattleFIGHT = false;
            bool reloadBattleBAG = false;
            bool reloadBattlePOKeFRAUD = false;
            bool reloadBattleRUN = false;

            do
            {
                //Displays Select Fight
                ASCII.DISSelectFight(player.Party.MonsterEquipped, gbText, gbBackground);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.K:
                    case ConsoleKey.Enter:
                        FightMovesMenu(player, npc.Party.MonsterEquipped, navPlayerMenu, gbText, gbBackground);
                        if (npc.Party.MonsterEquipped.Health <= 0)
                        {
                            System.Threading.Thread.Sleep(1000);
                            ASCII.ANIDefenderFaint(npc.Party.MonsterEquipped, gbText, gbBackground);
                            Combat.CalcExp(player, npc.Party.MonsterEquipped, gbText, gbBackground);
                            if (npc.Party.Slot2.Health <= 0 && npc.Party.Slot3.Health <= 0 && npc.Party.Slot4.Health <= 0 && npc.Party.Slot5.Health <= 0 && npc.Party.Slot6.Health <= 0)
                            {
                                ASCII.ANINPCDefeat(player, npc, loserPays, gbText, gbBackground);
                                reloadBattleFIGHT = false;
                                reloadBattleBAG = false;
                                reloadBattlePOKeFRAUD = false;
                                reloadBattleRUN = false;
                            }
                            else if (npc.Party.Slot2.Health > 0)
                            {
                                ASCII.ANINPCNext(player, npc, 2, navPlayerMenu, gbText, gbBackground);
                            }
                            else if (npc.Party.Slot3.Health > 0)
                            {
                                ASCII.ANINPCNext(player, npc, 3, navPlayerMenu, gbText, gbBackground);
                            }
                            else if (npc.Party.Slot4.Health > 0)
                            {
                                ASCII.ANINPCNext(player, npc, 4, navPlayerMenu, gbText, gbBackground);
                            }
                            else if (npc.Party.Slot5.Health > 0)
                            {
                                ASCII.ANINPCNext(player, npc, 5, navPlayerMenu, gbText, gbBackground);
                            }
                            else if (npc.Party.Slot6.Health > 0)
                            {
                                ASCII.ANINPCNext(player, npc, 6, navPlayerMenu, gbText, gbBackground);
                            }
                        }
                        else if (player.Party.MonsterEquipped.Health <= 0)
                        {
                            System.Threading.Thread.Sleep(1000);
                            ASCII.ANIAttackerFaint(player, gbText, gbBackground);
                            if (player.Party.Slot2.Health <= 0 && player.Party.Slot3.Health <= 0 && player.Party.Slot4.Health <= 0 && player.Party.Slot5.Health <= 0 && player.Party.Slot6.Health <= 0)
                            {
                                string message = "You are all out of usable Pokefraud!";
                                string message2 = $"{player.Name.ToUpper()} paid {npc.Name.ToUpper()} ${loserPays}.";
                                ASCII.ScrollMessage(message, 50, 1500, gbText, gbBackground);
                                ASCII.ScrollMessage(message2, 50, 2500, gbText, gbBackground);
                                player.Money -= loserPays;
                                reloadBattleFIGHT = false;
                                reloadBattleBAG = false;
                                reloadBattlePOKeFRAUD = false;
                                reloadBattleRUN = false;
                            }
                            else
                            {
                                PlayerPartyMenuBattle(player, npc.Party.MonsterEquipped, navPlayerMenu, gbText, gbBackground);

                                reloadBattleFIGHT = true;
                                reloadBattleBAG = false;
                                reloadBattlePOKeFRAUD = false;
                                reloadBattleRUN = false;
                            }
                        }
                        else
                        {
                            ASCII.DISATTandDEF(player, npc.Party.MonsterEquipped, gbText, gbBackground);
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
                            //Displays Select Bag                            
                            ASCII.DISSelectBag(player.Party.MonsterEquipped, gbText, gbBackground);
                            navPlayerMenu = Console.ReadKey().Key;
                            switch (navPlayerMenu)
                            {
                                case ConsoleKey.K:
                                case ConsoleKey.Enter:
                                    ASCII.StaticMessageBox(gbText, gbBackground);
                                    BattleItemSection(player.Inventory.ItemSection, player.Inventory.MedSection, player, npc.Party.MonsterEquipped, navPlayerMenu, gbText, gbBackground);
                                    if (npc.Party.MonsterEquipped.IsCaught == true)
                                    {
                                        reloadBattleFIGHT = false;
                                        reloadBattleBAG = false;
                                        reloadBattlePOKeFRAUD = false;
                                        reloadBattleRUN = false;
                                    }
                                    else
                                    {
                                        ASCII.DISATTandDEF(player, npc.Party.MonsterEquipped, gbText, gbBackground);
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
                                        //Displays Select Run
                                        ASCII.DISSelectRun(player.Party.MonsterEquipped, gbText, gbBackground);
                                        navPlayerMenu = Console.ReadKey().Key;
                                        switch (navPlayerMenu)
                                        {
                                            case ConsoleKey.K:
                                            case ConsoleKey.Enter:
                                                string message = $"You cannot escape a player battle!";
                                                ASCII.ScrollMessage(message, 15, 2000, gbText, gbBackground);
                                                reloadBattleFIGHT = true;
                                                reloadBattleBAG = false;
                                                reloadBattlePOKeFRAUD = false;
                                                reloadBattleRUN = false;
                                                break;
                                            case ConsoleKey.A:
                                            case ConsoleKey.LeftArrow:
                                                do
                                                {
                                                    //Displays Select Party
                                                    ASCII.DISSelectParty(player.Party.MonsterEquipped, gbText, gbBackground);
                                                    navPlayerMenu = Console.ReadKey().Key;
                                                    switch (navPlayerMenu)
                                                    {
                                                        case ConsoleKey.K:
                                                        case ConsoleKey.Enter:
                                                            PlayerPartyMenuBattle(player, npc.Party.MonsterEquipped, navPlayerMenu, gbText, gbBackground);
                                                            ASCII.DISATTandDEF(player, npc.Party.MonsterEquipped, gbText, gbBackground);
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
                            //Displays Select Party
                            ASCII.DISSelectParty(player.Party.MonsterEquipped, gbText, gbBackground);
                            navPlayerMenu = Console.ReadKey().Key;
                            switch (navPlayerMenu)
                            {
                                case ConsoleKey.K:
                                case ConsoleKey.Enter:
                                    PlayerPartyMenuBattle(player, npc.Party.MonsterEquipped, navPlayerMenu, gbText, gbBackground);
                                    ASCII.DISATTandDEF(player, npc.Party.MonsterEquipped, gbText, gbBackground);
                                    //BattlePartySwitch(player, npc.Party.MonsterEquipped, navPlayerMenu, gbText, gbBackground);
                                    reloadBattleFIGHT = true;
                                    reloadBattleBAG = false;
                                    reloadBattlePOKeFRAUD = false;
                                    reloadBattleRUN = false;
                                    break;
                                case ConsoleKey.D:
                                case ConsoleKey.RightArrow:
                                    do
                                    {
                                        //Displays Select Run
                                        ASCII.DISSelectRun(player.Party.MonsterEquipped, gbText, gbBackground);
                                        navPlayerMenu = Console.ReadKey().Key;
                                        switch (navPlayerMenu)
                                        {
                                            case ConsoleKey.K:
                                            case ConsoleKey.Enter:
                                                string message = $"You cannot escape a player battle!";
                                                ASCII.ScrollMessage(message, 15, 2000, gbText, gbBackground);
                                                reloadBattleFIGHT = true;
                                                reloadBattleBAG = false;
                                                reloadBattlePOKeFRAUD = false;
                                                reloadBattleRUN = false;
                                                break;
                                            case ConsoleKey.W:
                                            case ConsoleKey.UpArrow:
                                                do
                                                {
                                                    //Displays Select Bag
                                                    ASCII.DISSelectBag(player.Party.MonsterEquipped, gbText, gbBackground);
                                                    navPlayerMenu = Console.ReadKey().Key;
                                                    switch (navPlayerMenu)
                                                    {
                                                        case ConsoleKey.K:
                                                        case ConsoleKey.Enter:
                                                            ASCII.StaticMessageBox(gbText, gbBackground);
                                                            BattleItemSection(player.Inventory.ItemSection, player.Inventory.MedSection, player, npc.Party.MonsterEquipped, navPlayerMenu, gbText, gbBackground);
                                                            if (npc.Party.MonsterEquipped.IsCaught == true)
                                                            {
                                                                reloadBattleFIGHT = false;
                                                                reloadBattleBAG = false;
                                                                reloadBattlePOKeFRAUD = false;
                                                                reloadBattleRUN = false;
                                                            }
                                                            else
                                                            {
                                                                ASCII.DISATTandDEF(player, npc.Party.MonsterEquipped, gbText, gbBackground);
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

        #region Fight Menu Select Moves 

        public static void SelectFightMoves(Monster monster, Monster_Moves move, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
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
            Console.ForegroundColor = gbText;
            Console.SetCursorPosition(90, 42);
        }

        public static void SelectFightMove1(Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetCursorPosition(5, 21);
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.WriteLine("▄▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▄");
            Console.SetCursorPosition(5, 22);
            Console.WriteLine("█  -->                                            █  PP                         █");
            Console.SetCursorPosition(5, 23);
            Console.WriteLine("█                                                 █  TYPE:                      █");
            Console.SetCursorPosition(5, 24);
            Console.WriteLine("█                                                 █                             █");
            Console.SetCursorPosition(5, 25);
            Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ");
            SelectFightMoves(monster, monster.EquippedMoves.Move1, gbText, gbBackground);
        }

        public static void SelectFightMove2(Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
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
            SelectFightMoves(monster, monster.EquippedMoves.Move2, gbText, gbBackground);
        }

        public static void SelectFightMove3(Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
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
            SelectFightMoves(monster, monster.EquippedMoves.Move3, gbText, gbBackground);
        }

        public static void SelectFightMove4(Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
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
            SelectFightMoves(monster, monster.EquippedMoves.Move4, gbText, gbBackground);
        }

        public static void FightMovesMenu(Player player, Monster monster, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadFightMove1 = false;
            bool reloadFightMove2 = false;
            bool reloadFightMove3 = false;
            bool reloadFightMove4 = false;

            do
            {
                //Displays FightMove1                
                SelectFightMove1(player.Party.MonsterEquipped, gbText, gbBackground);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.K:
                    case ConsoleKey.Enter:
                        Combat.DoBattle(player, monster, player.Party.MonsterEquipped.EquippedMoves.Move1, gbText, gbBackground);
                        reloadFightMove1 = false;
                        reloadFightMove2 = false;
                        reloadFightMove3 = false;
                        reloadFightMove4 = false;
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        if (player.Party.MonsterEquipped.EquippedMoves.Move2.Type != Monster_Race.NONE)
                        {
                            do
                            {
                                //Displays FightMove2
                                SelectFightMove2(player.Party.MonsterEquipped, gbText, gbBackground);
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.K:
                                    case ConsoleKey.Enter:
                                        Combat.DoBattle(player, monster, player.Party.MonsterEquipped.EquippedMoves.Move2, gbText, gbBackground);
                                        reloadFightMove1 = false;
                                        reloadFightMove2 = false;
                                        reloadFightMove3 = false;
                                        reloadFightMove4 = false;
                                        break;
                                    case ConsoleKey.S:
                                    case ConsoleKey.DownArrow:
                                        if (player.Party.MonsterEquipped.EquippedMoves.Move4.Type != Monster_Race.NONE)
                                        {
                                            do
                                            {
                                                //Displays FightMove4
                                                SelectFightMove4(player.Party.MonsterEquipped, gbText, gbBackground);
                                                navPlayerMenu = Console.ReadKey().Key;
                                                switch (navPlayerMenu)
                                                {
                                                    case ConsoleKey.K:
                                                    case ConsoleKey.Enter:
                                                        Combat.DoBattle(player, monster, player.Party.MonsterEquipped.EquippedMoves.Move4, gbText, gbBackground);
                                                        reloadFightMove1 = false;
                                                        reloadFightMove2 = false;
                                                        reloadFightMove3 = false;
                                                        reloadFightMove4 = false;
                                                        break;
                                                    case ConsoleKey.A:
                                                    case ConsoleKey.LeftArrow:
                                                        if (player.Party.MonsterEquipped.EquippedMoves.Move3.Type != Monster_Race.NONE)
                                                        {
                                                            do
                                                            {
                                                                //Displays FightMove3
                                                                SelectFightMove3(player.Party.MonsterEquipped, gbText, gbBackground);
                                                                navPlayerMenu = Console.ReadKey().Key;
                                                                switch (navPlayerMenu)
                                                                {
                                                                    case ConsoleKey.K:
                                                                    case ConsoleKey.Enter:
                                                                        Combat.DoBattle(player, monster, player.Party.MonsterEquipped.EquippedMoves.Move3, gbText, gbBackground);
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
                                                        }
                                                        else
                                                        {
                                                            reloadFightMove4 = true;
                                                        }
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
                                        }
                                        else
                                        {
                                            reloadFightMove2 = true;
                                        }
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
                        }
                        else
                        {
                            reloadFightMove1 = true;
                        }
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        if (player.Party.MonsterEquipped.EquippedMoves.Move3.Type != Monster_Race.NONE)
                        {
                            do
                            {
                                //Displays Move3
                                SelectFightMove3(player.Party.MonsterEquipped, gbText, gbBackground);
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.K:
                                    case ConsoleKey.Enter:
                                        Combat.DoBattle(player, monster, player.Party.MonsterEquipped.EquippedMoves.Move3, gbText, gbBackground);
                                        reloadFightMove1 = false;
                                        reloadFightMove2 = false;
                                        reloadFightMove3 = false;
                                        reloadFightMove4 = false;
                                        break;
                                    case ConsoleKey.D:
                                    case ConsoleKey.RightArrow:
                                        if (player.Party.MonsterEquipped.EquippedMoves.Move4.Type != Monster_Race.NONE)
                                        {
                                            do
                                            {
                                                //Displays Move4
                                                SelectFightMove4(player.Party.MonsterEquipped, gbText, gbBackground);
                                                navPlayerMenu = Console.ReadKey().Key;
                                                switch (navPlayerMenu)
                                                {
                                                    case ConsoleKey.K:
                                                    case ConsoleKey.Enter:
                                                        Combat.DoBattle(player, monster, player.Party.MonsterEquipped.EquippedMoves.Move4, gbText, gbBackground);
                                                        reloadFightMove1 = false;
                                                        reloadFightMove2 = false;
                                                        reloadFightMove3 = false;
                                                        reloadFightMove4 = false;
                                                        break;
                                                    case ConsoleKey.W:
                                                    case ConsoleKey.UpArrow:
                                                        if (player.Party.MonsterEquipped.EquippedMoves.Move2.Type != Monster_Race.NONE)
                                                        {
                                                            do
                                                            {
                                                                //Displays Move2
                                                                SelectFightMove2(player.Party.MonsterEquipped, gbText, gbBackground);
                                                                navPlayerMenu = Console.ReadKey().Key;
                                                                switch (navPlayerMenu)
                                                                {
                                                                    case ConsoleKey.K:
                                                                    case ConsoleKey.Enter:
                                                                        Combat.DoBattle(player, monster, player.Party.MonsterEquipped.EquippedMoves.Move2, gbText, gbBackground);
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
                                                        }
                                                        else
                                                        {
                                                            reloadFightMove4 = true;
                                                        }
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
                                        }
                                        else
                                        {
                                            reloadFightMove3 = true;
                                        }
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
                        }
                        else
                        {
                            reloadFightMove1 = true;
                        }
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

        public static void EmptyMenuRight(ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            Console.SetCursorPosition(49, 4);
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.SetCursorPosition(49, 5);
            Console.WriteLine("█ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█");
            Console.SetCursorPosition(49, 6);
            Console.WriteLine("█ █                                  ");
            Console.SetCursorPosition(49, 7);
            Console.WriteLine("█ █                                  ");
            Console.SetCursorPosition(49, 8);
            Console.WriteLine("█ █                                  ");
            Console.SetCursorPosition(49, 9);
            Console.WriteLine("█ █                                  ");
            Console.SetCursorPosition(49, 10);
            Console.WriteLine("█ █                                  ");
            Console.SetCursorPosition(49, 11);
            Console.WriteLine("█ █                                  ");
            Console.SetCursorPosition(49, 12);
            Console.WriteLine("█ █                                  ");
            Console.SetCursorPosition(49, 13);
            Console.WriteLine("█ █                                  ");
            Console.SetCursorPosition(49, 14);
            Console.WriteLine("█ █                                  ");
            Console.SetCursorPosition(49, 15);
            Console.WriteLine("█ █                                  ");
            Console.SetCursorPosition(49, 16);
            Console.WriteLine("█ █                                  ");
            Console.SetCursorPosition(49, 17);
            Console.WriteLine("█ █                                  ");
            Console.SetCursorPosition(49, 18);
            Console.WriteLine("█ █                                  ");
            Console.SetCursorPosition(49, 19);
            Console.WriteLine("█ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀█");
            Console.SetCursorPosition(49, 20);
            Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
        }

        public static void SelectItemSection(ConsoleColor gbText, ConsoleColor gbBackground)
        {
            EmptyMenuRight(gbText, gbBackground);

            Console.SetCursorPosition(5, 15);
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄                     ");
            Console.SetCursorPosition(5, 16);
            Console.WriteLine("█       ITEMS        █                     ");
            Console.SetCursorPosition(5, 17);
            Console.WriteLine("█                    █▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.SetCursorPosition(5, 18);
            Console.WriteLine("█                    █      MEDICINE      █");
            Console.SetCursorPosition(5, 19);
            Console.WriteLine("█                                         █");
            Console.SetCursorPosition(5, 20);
            Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");

        }

        public static void SelectMedSection(ConsoleColor gbText, ConsoleColor gbBackground)
        {
            EmptyMenuRight(gbText, gbBackground);

            Console.SetCursorPosition(5, 15);
            Console.WriteLine("                     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.SetCursorPosition(5, 16);
            Console.WriteLine("                     █      MEDICINE      █");
            Console.SetCursorPosition(5, 17);
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█                    █");
            Console.SetCursorPosition(5, 18);
            Console.WriteLine("█       ITEMS        █                    █");
            Console.SetCursorPosition(5, 19);
            Console.WriteLine("█                                         █");
            Console.SetCursorPosition(5, 20);
            Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
        }

        public static void BattleItemSection(Item[] section1, Item[] section2, Player player, Monster monster, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            player.Inventory.ItemSection[0].UseNow = true;
            player.Inventory.MedSection[0].UseNow = true;
            player.Inventory.MedSection[1].UseNow = true;
            player.Inventory.MedSection[2].UseNow = true;
            player.Inventory.MedSection[3].UseNow = true;
            bool reloadSelect = false;
            int positionY = 6;
            int posY = 6;

            SelectItemSection(gbText, gbBackground);
            foreach (Item item in section1)
            {
                //if (item.Amount > 0)
                //{
                for (int i = posY; i < 19; i++)
                {
                    Console.SetCursorPosition(57, posY);
                    Console.Write($"{item.Name}");
                    Console.SetCursorPosition(77, posY);
                    Console.Write($"x {item.Amount}");
                }
                posY += 1;
                //}
            }
            do
            {
                Console.SetCursorPosition(53, positionY);
                Console.Write("-->");
                Console.SetCursorPosition(90, 42);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Console.SetCursorPosition(53, positionY);
                        Console.Write("   ");
                        positionY -= 1;
                        if (positionY < 6)
                        {
                            positionY += 1;
                        }
                        reloadSelect = true;
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Console.SetCursorPosition(53, positionY);
                        Console.Write("   ");
                        positionY += 1;
                        if (positionY > posY - 1/*player.Inventory.ItemSection.Length + 5*/ || positionY > 18)
                        {
                            positionY -= 1;
                        }
                        reloadSelect = true;
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        if (section2 != player.Inventory.MedSection)
                        {
                            reloadSelect = true;
                        }
                        else
                        {
                            BattleMedSection(player.Inventory.MedSection, player.Inventory.ItemSection, player, monster, navPlayerMenu, gbText, gbBackground);
                            reloadSelect = false;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        if (section2 != player.Inventory.ItemSection)
                        {
                            reloadSelect = true;
                        }
                        else
                        {
                            BattleItemSection(player.Inventory.ItemSection, player.Inventory.MedSection, player, monster, navPlayerMenu, gbText, gbBackground);
                            reloadSelect = false;
                        }
                        break;
                    case ConsoleKey.Enter:
                        string message1 = $"You cannot use that here!";
                        string message2 = $"You are all out of {section1[positionY - 6].Name.ToUpper()}'s!";
                        string message3 = $"You cannot catch an owned PokeFraud!";
                        string message4 = $"Use {section1[positionY - 6].Name.ToUpper()}?";

                        if (section1[positionY - 6].UseNow != true)
                        {
                            ASCII.InstantMessage(message1, gbText, gbBackground);
                            System.Threading.Thread.Sleep(2000);
                            ASCII.StaticMessageBox(gbText, gbBackground);
                            reloadSelect = true;
                        }
                        else if (section1[positionY - 6].Amount == 0)
                        {
                            ASCII.InstantMessage(message2, gbText, gbBackground);
                            System.Threading.Thread.Sleep(2000);
                            ASCII.StaticMessageBox(gbText, gbBackground);
                            reloadSelect = true;
                        }
                        else if (section1[positionY - 6].Name == "Catcher" && monster.IsOwned == true)
                        {
                            ASCII.InstantMessage(message3, gbText, gbBackground);
                            System.Threading.Thread.Sleep(2000);
                            ASCII.StaticMessageBox(gbText, gbBackground);
                            reloadSelect = true;
                        }
                        else
                        {
                            ASCII.InstantMessage(message4, gbText, gbBackground);
                            navPlayerMenu = Console.ReadKey().Key;
                            switch (navPlayerMenu)
                            {
                                case ConsoleKey.Enter:
                                case ConsoleKey.K:
                                    if (section1[positionY - 6].Name == "Catcher")
                                    {
                                        ASCII.DISATTandDEF(player, monster, gbText, gbBackground);
                                        Combat.TryCatchANDSort(player, monster, gbText, gbBackground);
                                    }
                                    if (section1[positionY - 6].Name == "Health Potion" || section1[positionY - 6].Name == "Revive" || section1[positionY - 6].Name == "Full Heal" || section1[positionY - 6].Name == "Full Revive" || section1[positionY - 6].Name == "Attack-Up" || section1[positionY - 6].Name == "HP-UP")
                                    {
                                        BattlePartyUseItem(player, section1[positionY - 6], navPlayerMenu, gbText, gbBackground);
                                    }
                                    reloadSelect = false;
                                    break;
                                case ConsoleKey.Backspace:
                                case ConsoleKey.O:
                                    ASCII.StaticMessageBox(gbText, gbBackground);
                                    reloadSelect = true;
                                    break;
                                default:
                                    ASCII.StaticMessageBox(gbText, gbBackground);
                                    reloadSelect = true;
                                    break;
                            }
                        }
                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        reloadSelect = false;
                        break;
                    default:
                        reloadSelect = true;
                        break;
                }
            } while (reloadSelect);
        }

        public static void BattleMedSection(Item[] section1, Item[] section2, Player player, Monster monster, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            player.Inventory.ItemSection[0].UseNow = true;
            player.Inventory.MedSection[0].UseNow = true;
            player.Inventory.MedSection[1].UseNow = true;
            player.Inventory.MedSection[2].UseNow = true;
            player.Inventory.MedSection[3].UseNow = true;
            bool reloadSelect = false;
            int positionY = 6;
            int posY = 6;

            SelectMedSection(gbText, gbBackground);
            foreach (Item item in section1)
            {
                //if (item.Amount > 0)
                //{
                for (int i = posY; i < 19; i++)
                {
                    Console.SetCursorPosition(57, posY);
                    Console.Write($"{item.Name}");
                    Console.SetCursorPosition(77, posY);
                    Console.Write($"x {item.Amount}");
                }
                posY += 1;
                //}
            }
            do
            {
                Console.SetCursorPosition(53, positionY);
                Console.Write("-->");
                Console.SetCursorPosition(90, 42);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Console.SetCursorPosition(53, positionY);
                        Console.Write("   ");
                        positionY -= 1;
                        if (positionY < 6)
                        {
                            positionY += 1;
                        }
                        reloadSelect = true;
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Console.SetCursorPosition(53, positionY);
                        Console.Write("   ");
                        positionY += 1;
                        if (positionY > posY - 1/*player.Inventory.ItemSection.Length + 5*/ || positionY > 18)
                        {
                            positionY -= 1;
                        }
                        reloadSelect = true;
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        if (section2 != player.Inventory.MedSection)
                        {
                            reloadSelect = true;
                        }
                        else
                        {
                            BattleMedSection(player.Inventory.MedSection, player.Inventory.ItemSection, player, monster, navPlayerMenu, gbText, gbBackground);
                            reloadSelect = false;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        if (section2 != player.Inventory.ItemSection)
                        {
                            reloadSelect = true;
                        }
                        else
                        {
                            BattleItemSection(player.Inventory.ItemSection, player.Inventory.MedSection, player, monster, navPlayerMenu, gbText, gbBackground);
                            reloadSelect = false;
                        }
                        break;
                    case ConsoleKey.Enter:
                        //player.Inventory.ItemSection
                        string message1 = $"You cannot use that here!";
                        string message2 = $"You are all out of {section1[positionY - 6].Name.ToUpper()}'s!";
                        string message3 = $"You cannot catch an owned PokeFraud!";
                        string message4 = $"Use {section1[positionY - 6].Name.ToUpper()}?";

                        if (section1[positionY - 6].UseNow != true)
                        {
                            ASCII.InstantMessage(message1, gbText, gbBackground);
                            System.Threading.Thread.Sleep(2000);
                            ASCII.StaticMessageBox(gbText, gbBackground);
                            reloadSelect = true;
                        }
                        else if (section1[positionY - 6].Amount == 0)
                        {
                            ASCII.InstantMessage(message2, gbText, gbBackground);
                            System.Threading.Thread.Sleep(2000);
                            ASCII.StaticMessageBox(gbText, gbBackground);
                            reloadSelect = true;
                        }
                        else if (section1[positionY - 6].Name == "Catcher" && monster.IsOwned == true)
                        {
                            ASCII.InstantMessage(message3, gbText, gbBackground);
                            System.Threading.Thread.Sleep(2000);
                            ASCII.StaticMessageBox(gbText, gbBackground);
                            reloadSelect = true;
                        }
                        else
                        {
                            ASCII.InstantMessage(message4, gbText, gbBackground);
                            navPlayerMenu = Console.ReadKey().Key;
                            switch (navPlayerMenu)
                            {
                                case ConsoleKey.Enter:
                                case ConsoleKey.K:
                                    if (section1[positionY - 6].Name == "Catcher")
                                    {
                                        ASCII.DISATTandDEF(player, monster, gbText, gbBackground);
                                        Combat.TryCatchANDSort(player, monster, gbText, gbBackground);
                                    }
                                    else
                                    {
                                        BattlePartyUseItem(player, section1[positionY - 6], navPlayerMenu, gbText, gbBackground);

                                    }
                                    reloadSelect = false;
                                    break;
                                case ConsoleKey.Backspace:
                                case ConsoleKey.O:
                                    ASCII.StaticMessageBox(gbText, gbBackground);
                                    reloadSelect = true;
                                    break;
                                default:
                                    ASCII.StaticMessageBox(gbText, gbBackground);
                                    reloadSelect = true;
                                    break;
                            }
                        }
                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        reloadSelect = false;
                        break;
                    default:
                        reloadSelect = true;
                        break;
                }
            } while (reloadSelect);
        }

        #endregion

        #region Fight Menu Player Party 

        public static void ItemEffect(Player player, Monster monster, Item item, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            string message = $"{item.Name} won't have any effect on {monster.Name}!";
            string message2 = $"{player.Name.ToUpper()} used a {item.Name}!";

            if (item.Name == "Health Potion" && monster.Health > 0 && monster.Health < monster.MaxHealth)
            {
                ASCII.ScrollMessage(message2, 50, 2000, gbText, gbBackground);
                monster.Health += 20;
            }
            else if (item.Name == "Revive" && monster.Health <= 0)
            {
                ASCII.ScrollMessage(message2, 50, 2000, gbText, gbBackground);
                monster.Health += monster.MaxHealth / 2;
            }
            else
            {
                ASCII.InstantMessage(message, gbText, gbBackground);
                System.Threading.Thread.Sleep(2000);
            }

        }

        public static void BattlePartyUseItem(Player player, Item item, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadParty = false;
            int posX = 6;
            int posY = 3;

            ASCII.Party(player, gbText, gbBackground);
            do
            {
                ASCII.StaticMessageBox(gbText, gbBackground);
                Console.SetCursorPosition(posX, posY);
                Console.Write("███");
                Console.SetCursorPosition(posX, posY + 1);
                Console.Write("███");
                Console.SetCursorPosition(posX, posY + 2);
                Console.Write("███");
                Console.SetCursorPosition(90, 42);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posY += 6;
                        if (posY > 16 ||
                            posX == 6 && posY == 9 && player.Party.Slot3.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 10 && player.Party.Slot4.Type == Monster_Race.NONE ||
                            posX == 6 && posY == 15 && player.Party.Slot5.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 16 && player.Party.Slot6.Type == Monster_Race.NONE)
                        {
                            posY -= 6;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posY -= 6;
                        if (posY < 3)
                        {
                            posY += 6;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posX += 76;
                        posY += 1;
                        if (posX > 82 ||
                            posX == 82 && posY == 10 && player.Party.Slot4.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 16 && player.Party.Slot6.Type == Monster_Race.NONE)
                        {
                            posX -= 76;
                            posY -= 1;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posX -= 76;
                        posY -= 1;
                        if (posX < 6)
                        {
                            posX += 76;
                            posY += 1;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.Enter:
                        if (posX == 6 && posY == 3)
                        {
                            int startHealth = player.Party.MonsterEquipped.Health;
                            ItemEffect(player, player.Party.MonsterEquipped, item, gbText, gbBackground);
                            if (player.Party.MonsterEquipped.Health == startHealth)
                            {
                                reloadParty = true;
                            }
                        }
                        else if (posX == 6 && posY == 9)
                        {
                            ItemEffect(player, player.Party.Slot3, item, gbText, gbBackground);
                        }
                        else if (posX == 6 && posY == 15)
                        {
                            ItemEffect(player, player.Party.Slot5, item, gbText, gbBackground);
                        }
                        else if (posX == 82 && posY == 4)
                        {
                            ItemEffect(player, player.Party.Slot2, item, gbText, gbBackground);
                        }
                        else if (posX == 82 && posY == 10)
                        {
                            ItemEffect(player, player.Party.Slot4, item, gbText, gbBackground);
                        }
                        else if (posX == 82 && posY == 16)
                        {
                            ItemEffect(player, player.Party.Slot6, item, gbText, gbBackground);
                        }
                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        reloadParty = false;
                        break;
                    default:
                        reloadParty = true;
                        break;
                }
            } while (reloadParty);
        }

        public static void BattlePartySwitch(Player player, Monster monster, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadParty = false;
            int posX = 6;
            int posY = 3;

            ASCII.Party(player, gbText, gbBackground);
            do
            {
                ASCII.StaticMessageBox(gbText, gbBackground);
                Console.SetCursorPosition(posX, posY);
                Console.Write("███");
                Console.SetCursorPosition(posX, posY + 1);
                Console.Write("███");
                Console.SetCursorPosition(posX, posY + 2);
                Console.Write("███");
                Console.SetCursorPosition(90, 42);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posY += 6;
                        if (posY > 16 ||
                            posX == 6 && posY == 9 && player.Party.Slot3.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 10 && player.Party.Slot4.Type == Monster_Race.NONE ||
                            posX == 6 && posY == 15 && player.Party.Slot5.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 16 && player.Party.Slot6.Type == Monster_Race.NONE)
                        {
                            posY -= 6;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posY -= 6;
                        if (posY < 3)
                        {
                            posY += 6;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posX += 76;
                        posY += 1;
                        if (posX > 82 ||
                            posX == 82 && posY == 4 && player.Party.Slot2.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 10 && player.Party.Slot4.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 16 && player.Party.Slot6.Type == Monster_Race.NONE)
                        {
                            posX -= 76;
                            posY -= 1;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posX -= 76;
                        posY -= 1;
                        if (posX < 6)
                        {
                            posX += 76;
                            posY += 1;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.Enter:
                        string messageReturn = $"{player.Party.MonsterEquipped.Name.ToUpper()} return!";
                        //Monster Equipped
                        if (posX == 6 && posY == 3)
                        {
                            string message1 = $"{player.Party.MonsterEquipped.Name.ToUpper()} is unable to battle!";
                            string message2 = $"{player.Party.MonsterEquipped.Name.ToUpper()} is already in battle!";
                            if (player.Party.MonsterEquipped.Health <= 0)
                            {
                                ASCII.ScrollMessage(message1, 25, 2000, gbText, gbBackground);
                                reloadParty = true;
                            }
                            else
                            {
                                ASCII.ScrollMessage(message2, 25, 2000, gbText, gbBackground);
                                reloadParty = true;
                            }
                        }
                        //Slot 3
                        else if (posX == 6 && posY == 9)
                        {
                            string message1 = $"{player.Party.Slot3.Name.ToUpper()} is unable to battle!";
                            if (player.Party.Slot3.Health <= 0)
                            {
                                ASCII.InstantMessage(message1, gbText, gbBackground);
                                reloadParty = true;
                            }
                            else
                            {
                                string message = $"Send out {player.Party.Slot3.Name.ToUpper()}?";
                                ASCII.InstantMessage(message, gbText, gbBackground);
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.Enter:
                                        //if (player.Party.MonsterEquipped.Health >= 0)
                                        //{
                                        //    ASCII.DISATTandDEF(player, monster, gbText, gbBackground);
                                        //    ASCII.ScrollMessage(messageReturn, 50, 1000, gbText, gbBackground);
                                        //    ASCII.ANIReturn(6, 13, gbText, gbBackground);
                                        //}
                                        //ASCII.ResetHalfScreen(12, gbText, gbBackground);
                                        //System.Threading.Thread.Sleep(1000);
                                        //player.Party.MonsterSwitch = player.Party.MonsterEquipped;
                                        //player.Party.MonsterEquipped = player.Party.Slot3;
                                        //player.Party.Slot3 = player.Party.MonsterSwitch;
                                        //ASCII.ANIPlayerSend(player, gbText, gbBackground);
                                        //This Method utilizes the same code as the above but DOESN'T WORK

                                        ASCII.ANIPlayerSwitchSendTEST(player, 3, monster, gbText, gbBackground);
                                        reloadParty = false;
                                        break;
                                    case ConsoleKey.Backspace:
                                        reloadParty = true;
                                        break;
                                    default:
                                        reloadParty = true;
                                        break;
                                }
                            }
                        }
                        //Slot 5
                        else if (posX == 6 && posY == 15)
                        {
                            string message1 = $"{player.Party.Slot5.Name.ToUpper()} is unable to battle!";
                            string message2 = $"{player.Party.MonsterEquipped.Name.ToUpper()} return!";
                            if (player.Party.Slot5.Health <= 0)
                            {
                                ASCII.InstantMessage(message1, gbText, gbBackground);
                                reloadParty = true;
                            }
                            else
                            {
                                string message = $"Send out {player.Party.Slot5.Name.ToUpper()}?";
                                ASCII.InstantMessage(message, gbText, gbBackground);
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.Enter:
                                        //if (player.Party.MonsterEquipped.Health >= 0)
                                        //{
                                        //    ASCII.DISATTandDEF(player, monster, gbText, gbBackground);
                                        //    ASCII.ScrollMessage(messageReturn, 50, 1000, gbText, gbBackground);
                                        //    ASCII.ANIReturn(6, 13, gbText, gbBackground);
                                        //}
                                        //ASCII.ResetHalfScreen(12, gbText, gbBackground);
                                        //System.Threading.Thread.Sleep(1000);
                                        //player.Party.MonsterSwitch = player.Party.MonsterEquipped;
                                        //player.Party.MonsterEquipped = player.Party.Slot5;
                                        //player.Party.Slot5 = player.Party.MonsterSwitch;
                                        //ASCII.ANIPlayerSend(player, gbText, gbBackground);
                                        ASCII.ANIPlayerSwitchSendTEST(player, 5, monster, gbText, gbBackground);
                                        reloadParty = false;
                                        break;
                                    case ConsoleKey.Backspace:
                                        reloadParty = true;
                                        break;
                                    default:
                                        reloadParty = true;
                                        break;
                                }
                            }
                        }
                        //Slot 2
                        else if (posX == 82 && posY == 4)
                        {
                            string message1 = $"{player.Party.Slot2.Name.ToUpper()} is unable to battle!";
                            string message2 = $"{player.Party.MonsterEquipped.Name.ToUpper()} return!";
                            if (player.Party.Slot2.Health <= 0)
                            {
                                ASCII.InstantMessage(message1, gbText, gbBackground);
                                reloadParty = true;
                            }
                            else
                            {
                                string message = $"Send out {player.Party.Slot2.Name.ToUpper()}?";
                                ASCII.InstantMessage(message, gbText, gbBackground);
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.Enter:
                                        //if (player.Party.MonsterEquipped.Health >= 0)
                                        //{
                                        //    ASCII.DISATTandDEF(player, monster, gbText, gbBackground);
                                        //    ASCII.ScrollMessage(messageReturn, 50, 1000, gbText, gbBackground);
                                        //    ASCII.ANIReturn(6, 13, gbText, gbBackground);
                                        //}
                                        //ASCII.ResetHalfScreen(12, gbText, gbBackground);
                                        //System.Threading.Thread.Sleep(1000);
                                        //player.Party.MonsterSwitch = player.Party.MonsterEquipped;
                                        //player.Party.MonsterEquipped = player.Party.Slot2;
                                        //player.Party.Slot2 = player.Party.MonsterSwitch;
                                        //ASCII.ANIPlayerSend(player, gbText, gbBackground);
                                        ASCII.ANIPlayerSwitchSendTEST(player, 2, monster, gbText, gbBackground);
                                        reloadParty = false;
                                        break;
                                    case ConsoleKey.Backspace:
                                        reloadParty = true;
                                        break;
                                    default:
                                        reloadParty = true;
                                        break;
                                }
                            }
                        }
                        //Slot 4
                        else if (posX == 82 && posY == 10)
                        {
                            string message1 = $"{player.Party.Slot4.Name.ToUpper()} is unable to battle!";
                            string message2 = $"{player.Party.MonsterEquipped.Name.ToUpper()} return!";
                            if (player.Party.Slot4.Health <= 0)
                            {
                                ASCII.InstantMessage(message1, gbText, gbBackground);
                                reloadParty = true;
                            }
                            else
                            {
                                string message = $"Send out {player.Party.Slot4.Name.ToUpper()}?";
                                ASCII.InstantMessage(message, gbText, gbBackground);
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.Enter:
                                        //if (player.Party.MonsterEquipped.Health >= 0)
                                        //{
                                        //    ASCII.DISATTandDEF(player, monster, gbText, gbBackground);
                                        //    ASCII.ScrollMessage(messageReturn, 50, 1000, gbText, gbBackground);
                                        //    ASCII.ANIReturn(6, 13, gbText, gbBackground);
                                        //}
                                        //ASCII.ResetHalfScreen(12, gbText, gbBackground);
                                        //System.Threading.Thread.Sleep(1000);
                                        //player.Party.MonsterSwitch = player.Party.MonsterEquipped;
                                        //player.Party.MonsterEquipped = player.Party.Slot4;
                                        //player.Party.Slot4 = player.Party.MonsterSwitch;
                                        //ASCII.ANIPlayerSend(player, gbText, gbBackground);
                                        ASCII.ANIPlayerSwitchSendTEST(player, 4, monster, gbText, gbBackground);
                                        reloadParty = false;
                                        break;
                                    case ConsoleKey.Backspace:
                                        reloadParty = true;
                                        break;
                                    default:
                                        reloadParty = true;
                                        break;
                                }
                            }
                        }
                        //Slot 6
                        else if (posX == 82 && posY == 16)
                        {
                            string message1 = $"{player.Party.Slot6.Name.ToUpper()} is unable to battle!";
                            string message2 = $"{player.Party.MonsterEquipped.Name.ToUpper()} return!";
                            if (player.Party.Slot6.Health <= 0)
                            {
                                ASCII.InstantMessage(message1, gbText, gbBackground);
                                reloadParty = true;
                            }
                            else
                            {
                                string message = $"Send out {player.Party.Slot6.Name.ToUpper()}?";
                                ASCII.InstantMessage(message, gbText, gbBackground);
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.Enter:

                                        ASCII.ANIPlayerSwitchSendTEST(player, 6, monster, gbText, gbBackground);
                                        reloadParty = false;

                                        break;
                                    case ConsoleKey.Backspace:
                                        reloadParty = true;
                                        break;
                                    default:
                                        reloadParty = true;
                                        break;
                                }
                            }
                        }
                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        if (monster.IsOwned == true && player.Party.MonsterEquipped.Health <= 0)
                        {
                            string message = $"You cannot escape a PvP battle!";
                            ASCII.ScrollMessage(message, 50, 2000, gbText, gbBackground);
                            reloadParty = true;
                        }
                        else
                        {
                            //ASCII.DISATTandDEF(player, monster, gbText, gbBackground);
                            reloadParty = false;
                        }
                        break;
                    default:
                        reloadParty = true;
                        break;
                }
            } while (reloadParty);
        }

        public static void BattlePartySwitchNPCNEW(Player player, Monster monster, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadParty = false;
            int posX = 6;
            int posY = 3;

            ASCII.Party(player, gbText, gbBackground);
            do
            {
                ASCII.StaticMessageBox(gbText, gbBackground);
                Console.SetCursorPosition(posX, posY);
                Console.Write("███");
                Console.SetCursorPosition(posX, posY + 1);
                Console.Write("███");
                Console.SetCursorPosition(posX, posY + 2);
                Console.Write("███");
                Console.SetCursorPosition(90, 42);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posY += 6;
                        if (posY > 16 ||
                            posX == 6 && posY == 9 && player.Party.Slot3.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 10 && player.Party.Slot4.Type == Monster_Race.NONE ||
                            posX == 6 && posY == 15 && player.Party.Slot5.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 16 && player.Party.Slot6.Type == Monster_Race.NONE)
                        {
                            posY -= 6;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posY -= 6;
                        if (posY < 3)
                        {
                            posY += 6;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posX += 76;
                        posY += 1;
                        if (posX > 82 ||
                            posX == 82 && posY == 4 && player.Party.Slot2.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 10 && player.Party.Slot4.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 16 && player.Party.Slot6.Type == Monster_Race.NONE)
                        {
                            posX -= 76;
                            posY -= 1;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posX -= 76;
                        posY -= 1;
                        if (posX < 6)
                        {
                            posX += 76;
                            posY += 1;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.Enter:
                        string messageReturn = $"{player.Party.MonsterEquipped.Name.ToUpper()} return!";
                        //Monster Equipped
                        if (posX == 6 && posY == 3)
                        {
                            string message1 = $"{player.Party.MonsterEquipped.Name.ToUpper()} is unable to battle!";
                            string message2 = $"{player.Party.MonsterEquipped.Name.ToUpper()} is already in battle!";
                            if (player.Party.MonsterEquipped.Health <= 0)
                            {
                                ASCII.ScrollMessage(message1, 25, 2000, gbText, gbBackground);
                                reloadParty = true;
                            }
                            else
                            {
                                ASCII.ScrollMessage(message2, 25, 2000, gbText, gbBackground);
                                reloadParty = true;
                            }
                        }
                        //Slot 3
                        else if (posX == 6 && posY == 9)
                        {
                            string message1 = $"{player.Party.Slot3.Name.ToUpper()} is unable to battle!";
                            string message2 = $"{player.Party.MonsterEquipped.Name.ToUpper()} return!";
                            if (player.Party.Slot3.Health <= 0)
                            {
                                ASCII.InstantMessage(message1, gbText, gbBackground);
                                reloadParty = true;
                            }
                            else
                            {
                                string message = $"Send out {player.Party.Slot3.Name.ToUpper()}?";
                                ASCII.InstantMessage(message, gbText, gbBackground);
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.Enter:
                                        ASCII.ANIPlayerSwitchSendNPCFaint(player, 3, monster, gbText, gbBackground);
                                        reloadParty = false;
                                        break;
                                    case ConsoleKey.Backspace:
                                        reloadParty = true;
                                        break;
                                    default:
                                        reloadParty = true;
                                        break;
                                }
                            }
                        }
                        //Slot 5
                        else if (posX == 6 && posY == 15)
                        {
                            string message1 = $"{player.Party.Slot5.Name.ToUpper()} is unable to battle!";
                            string message2 = $"{player.Party.MonsterEquipped.Name.ToUpper()} return!";
                            if (player.Party.Slot5.Health <= 0)
                            {
                                ASCII.InstantMessage(message1, gbText, gbBackground);
                                reloadParty = true;
                            }
                            else
                            {
                                string message = $"Send out {player.Party.Slot5.Name.ToUpper()}?";
                                ASCII.InstantMessage(message, gbText, gbBackground);
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.Enter:
                                        ASCII.ANIPlayerSwitchSendNPCFaint(player, 5, monster, gbText, gbBackground);
                                        reloadParty = false;
                                        break;
                                    case ConsoleKey.Backspace:
                                        reloadParty = true;
                                        break;
                                    default:
                                        reloadParty = true;
                                        break;
                                }
                            }
                        }
                        //Slot 2
                        else if (posX == 82 && posY == 4)
                        {
                            string message1 = $"{player.Party.Slot2.Name.ToUpper()} is unable to battle!";
                            string message2 = $"{player.Party.MonsterEquipped.Name.ToUpper()} return!";
                            if (player.Party.Slot2.Health <= 0)
                            {
                                ASCII.InstantMessage(message1, gbText, gbBackground);
                                reloadParty = true;
                            }
                            else
                            {
                                string message = $"Send out {player.Party.Slot2.Name.ToUpper()}?";
                                ASCII.InstantMessage(message, gbText, gbBackground);
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.Enter:
                                        ASCII.ANIPlayerSwitchSendNPCFaint(player, 2, monster, gbText, gbBackground);
                                        reloadParty = false;
                                        break;
                                    case ConsoleKey.Backspace:
                                        reloadParty = true;
                                        break;
                                    default:
                                        reloadParty = true;
                                        break;
                                }
                            }
                        }
                        //Slot 4
                        else if (posX == 82 && posY == 10)
                        {
                            string message1 = $"{player.Party.Slot4.Name.ToUpper()} is unable to battle!";
                            string message2 = $"{player.Party.MonsterEquipped.Name.ToUpper()} return!";
                            if (player.Party.Slot4.Health <= 0)
                            {
                                ASCII.InstantMessage(message1, gbText, gbBackground);
                                reloadParty = true;
                            }
                            else
                            {
                                string message = $"Send out {player.Party.Slot4.Name.ToUpper()}?";
                                ASCII.InstantMessage(message, gbText, gbBackground);
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.Enter:
                                        ASCII.ANIPlayerSwitchSendNPCFaint(player, 4, monster, gbText, gbBackground);
                                        reloadParty = false;
                                        break;
                                    case ConsoleKey.Backspace:
                                        reloadParty = true;
                                        break;
                                    default:
                                        reloadParty = true;
                                        break;
                                }
                            }
                        }
                        //Slot 6
                        else if (posX == 82 && posY == 16)
                        {
                            string message1 = $"{player.Party.Slot6.Name.ToUpper()} is unable to battle!";
                            string message2 = $"{player.Party.MonsterEquipped.Name.ToUpper()} return!";
                            if (player.Party.Slot6.Health <= 0)
                            {
                                ASCII.InstantMessage(message1, gbText, gbBackground);
                                reloadParty = true;
                            }
                            else
                            {
                                string message = $"Send out {player.Party.Slot6.Name.ToUpper()}?";
                                ASCII.InstantMessage(message, gbText, gbBackground);
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.Enter:
                                        ASCII.ANIPlayerSwitchSendNPCFaint(player, 6, monster, gbText, gbBackground);
                                        reloadParty = false;
                                        break;
                                    case ConsoleKey.Backspace:
                                        reloadParty = true;
                                        break;
                                    default:
                                        reloadParty = true;
                                        break;
                                }
                            }
                        }
                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        if (monster.IsOwned == true && player.Party.MonsterEquipped.Health <= 0)
                        {
                            string message = $"You cannot escape a PvP battle!";
                            ASCII.ScrollMessage(message, 50, 2000, gbText, gbBackground);
                            reloadParty = true;
                        }
                        else
                        {
                            ASCII.DISJustAttacker(player, gbText, gbBackground);
                            reloadParty = false;
                        }
                        break;
                    default:
                        reloadParty = true;
                        break;
                }
            } while (reloadParty);
        }

        #endregion

        #endregion

        /****PLAYER MENU****/

        #region Player Menu

        //FOR FULLSCREEN SELECT
        public static void PlayerSelect(Player player, string[] MenuDisplay, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            int posY = 2;
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            foreach (string line in MenuDisplay)
            {
                Console.SetCursorPosition(4, posY);
                Console.Write(line);
                posY += 1;
            }
            Console.SetCursorPosition(67, 12);
            Console.Write(player.Name.ToUpper());
            Console.SetCursorPosition(90, 42);
        }

        //FOR TAB SELECT ONLY
        public static void PlayerSelectTAB(Player player, string[] MenuDisplay, ConsoleColor gbText, ConsoleColor gbBackground)
        {//(60,2)
            int posY = 2;
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            foreach (string line in MenuDisplay)
            {
                Console.SetCursorPosition(60, posY);
                Console.Write(line);
                posY += 1;
            }
            Console.SetCursorPosition(67, 12);
            Console.Write(player.Name.ToUpper());
            Console.SetCursorPosition(90, 42);
        }

        public static void PlayerMenu(Player player, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadPlayerMenu = false;
            bool reloadPlayerMonstersEquipped = false;
            bool reloadPlayerBag = false;
            bool reloadPlayerProfile = false;
            bool reloadPlayerEXIT = false;

            do
            {
                //Selects Pokedex
                PlayerSelect(player, ASCII.PMPokedexSelect, gbText, gbBackground);
                //PlayerSelectTAB(player, ASCII.PMPokedexSelectTAB, gbText, gbBackground);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {

                    //Opens and Displays PlayerMenuRolodex

                    case ConsoleKey.Enter: //TODO ADD POKEDEX SECTION
                        //SFX.Select();
                        //do
                        //{

                        //    reloadPlayerMenu = true;

                        //} while (reloadPlayerMenu);
                        break;
                    //Navigates Down to PlayerMonstersEquipped

                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        //SFX.Select();
                        do
                        {
                            //Selects Party
                            PlayerSelect(player, ASCII.PMPartySelect, gbText, gbBackground);
                            //PlayerSelectTAB(player, ASCII.PMPartySelectTAB, gbText, gbBackground);
                            navPlayerMenu = Console.ReadKey().Key;
                            switch (navPlayerMenu)
                            {

                                //Navigates DOWN to PlayerBag

                                case ConsoleKey.Enter:
                                    PlayerPartyMenu(player, navPlayerMenu, gbText, gbBackground);
                                    reloadPlayerMonstersEquipped = true;
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
                                        //Selects Bag
                                        PlayerSelect(player, ASCII.PMBagSelect, gbText, gbBackground);
                                        //PlayerSelectTAB(player, ASCII.PMBagSelectTAB, gbText, gbBackground);
                                        navPlayerMenu = Console.ReadKey().Key;
                                        switch (navPlayerMenu)
                                        {
                                            case ConsoleKey.Enter:
                                                //SFX.Select();
                                                PlayerBagMenu(player, false, false, navPlayerMenu, gbText, gbBackground);
                                                PlayerSelect(player, ASCII.PMBagSelect, gbText, gbBackground);
                                                reloadPlayerBag = true;
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
                                                    //Selects Player Profile
                                                    PlayerSelect(player, ASCII.PMProfileSelect, gbText, gbBackground);
                                                    //PlayerSelectTAB(player, ASCII.PMProfileSelectTAB, gbText, gbBackground);
                                                    navPlayerMenu = Console.ReadKey().Key;
                                                    switch (navPlayerMenu)
                                                    {
                                                        case ConsoleKey.Enter:
                                                            PlayerProfile(player, gbText, gbBackground);
                                                            navPlayerMenu = Console.ReadKey().Key;
                                                            reloadPlayerProfile = true;
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
                                                                //Selects EXIT
                                                                PlayerSelect(player, ASCII.PMExitSelect, gbText, gbBackground);
                                                                //PlayerSelectTAB(player, ASCII.PMExitSelectTAB, gbText, gbBackground);
                                                                navPlayerMenu = Console.ReadKey().Key;
                                                                switch (navPlayerMenu)
                                                                {
                                                                    case ConsoleKey.Enter:
                                                                        reloadPlayerBag = false;
                                                                        reloadPlayerEXIT = false;
                                                                        reloadPlayerMenu = false;
                                                                        reloadPlayerMonstersEquipped = false;
                                                                        reloadPlayerProfile = false;
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

        #region Player Menu Pokedex



        #endregion

        #region Player Menu Party        

        /****FOR OUTSIDE BATTLE****/

        public static void PartyPopUp(Player player, Monster monster, int chooseNum, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadPopUp = false;
            bool reloadEntry = false;

            int posY = 14;
            string message1 = $"Do what with {player.Party.MonsterEquipped.Name.ToUpper()}?";
            string message2 = $"Do what with {player.Party.Slot2.Name.ToUpper()}?";
            string message3 = $"Do what with {player.Party.Slot3.Name.ToUpper()}?";
            string message4 = $"Do what with {player.Party.Slot4.Name.ToUpper()}?";
            string message5 = $"Do what with {player.Party.Slot5.Name.ToUpper()}?";
            string message6 = $"Do what with {player.Party.Slot6.Name.ToUpper()}?";

            if (chooseNum == 1)
            {
                monster = player.Party.MonsterEquipped;
                ASCII.InstantMessage(message1, gbText, gbBackground);
            }
            if (chooseNum == 2)
            {
                monster = player.Party.Slot2;
                ASCII.InstantMessage(message2, gbText, gbBackground);
            }
            if (chooseNum == 3)
            {
                monster = player.Party.Slot3;
                ASCII.InstantMessage(message3, gbText, gbBackground);
            }
            if (chooseNum == 4)
            {
                monster = player.Party.Slot4;
                ASCII.InstantMessage(message4, gbText, gbBackground);
            }
            if (chooseNum == 5)
            {
                monster = player.Party.Slot5;
                ASCII.InstantMessage(message5, gbText, gbBackground);
            }
            if (chooseNum == 6)
            {
                monster = player.Party.Slot6;
                ASCII.InstantMessage(message6, gbText, gbBackground);
            }
            posY = 15;
            do
            {
                int popupY = 14;
                foreach (string line in ASCII.partyNoBattle)
                {
                    Console.SetCursorPosition(66, popupY);
                    Console.Write(line);
                    popupY += 1;
                }
                Console.SetCursorPosition(67, posY);
                Console.Write(">");
                Console.SetCursorPosition(90, 42);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Console.SetCursorPosition(67, posY);
                        Console.Write(" ");
                        posY -= 1;
                        if (posY == 14)
                        {
                            posY += 1;
                            reloadPopUp = true;
                        }
                        else
                        {
                            reloadPopUp = true;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Console.SetCursorPosition(67, posY);
                        Console.Write(" ");
                        posY += 1;
                        if (posY == 19)
                        {
                            posY -= 1;
                            reloadPopUp = true;
                        }
                        else
                        {
                            reloadPopUp = true;
                        }
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.K:
                        if (posY == 15)
                        {
                            posY = 2;
                            int navX = 1;
                            int navY = chooseNum;
                            do
                            {
                                posY = 2;
                                foreach (string line in ASCII.pokedexEntry)
                                {
                                    Console.SetCursorPosition(4, posY);
                                    Console.Write(line);
                                    posY += 1;
                                }
                                if (navX == 2)
                                {
                                    posY = 2;
                                    foreach (string line in ASCII.pokedexStats)
                                    {
                                        Console.SetCursorPosition(25, posY);
                                        Console.Write(line);
                                        posY += 1;
                                    }
                                }
                                if (navX == 3)
                                {
                                    posY = 2;
                                    foreach (string line in ASCII.pokedexMoves)
                                    {
                                        Console.SetCursorPosition(25, posY);
                                        Console.Write(line);
                                        posY += 1;
                                    }
                                }
                                if (navX == 4)
                                {
                                    posY = 2;
                                    foreach (string line in ASCII.pokedexExit)
                                    {
                                        Console.SetCursorPosition(25, posY);
                                        Console.Write(line);
                                        posY += 1;
                                    }
                                }

                                if (chooseNum == 1)
                                {
                                    monster = player.Party.MonsterEquipped;
                                }
                                if (chooseNum == 2)
                                {
                                    monster = player.Party.Slot2;
                                }
                                if (chooseNum == 3)
                                {
                                    monster = player.Party.Slot3;
                                }
                                if (chooseNum == 4)
                                {
                                    monster = player.Party.Slot4;
                                }
                                if (chooseNum == 5)
                                {
                                    monster = player.Party.Slot5;
                                }
                                if (chooseNum == 6)
                                {
                                    monster = player.Party.Slot6;
                                }
                                //Displays Monster Art
                                posY = 9;
                                foreach (string line in monster.ASCIIPokedex)
                                {
                                    Console.SetCursorPosition(6, posY);
                                    Console.Write(line);
                                    posY += 1;
                                }
                                if (navX == 1)
                                {
                                    #region Display Pokedex Entry
                                    ASCII.NameANDGender(monster, 7, 3, gbText, gbBackground);
                                    ASCII.Level(monster, 7, 4, gbText, gbBackground);
                                    Console.SetCursorPosition(60, 7);
                                    Console.Write(monster.PokeIndex);
                                    ASCII.Name(monster, 60, 9, gbText, gbBackground);
                                    ASCII.Type(monster.Type, 60, 11, gbText, gbBackground);
                                    Console.SetCursorPosition(60, 13);
                                    Console.Write(player.Name.ToUpper());
                                    Console.SetCursorPosition(60, 18);
                                    Console.Write(monster.MaxExp - monster.Exp);
                                    ASCII.ExpBar(monster, 58, 20);
                                    #endregion
                                }
                                if (navX == 2)
                                {
                                    #region Display Current Stats
                                    ASCII.Health(monster, 60, 7, gbText, gbBackground);
                                    //TODO ADD Attack stat to Monster Class
                                    //TODO ADD Defense stat to Monster Class

                                    Console.SetCursorPosition(60, 13);
                                    switch (monster.Type)
                                    {
                                        case Monster_Race.Normal:
                                            break;
                                        case Monster_Race.Fire:
                                            ASCII.Type(Monster_Race.Water, 60, 13, gbText, gbBackground);
                                            Console.Write(" ");
                                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                            Console.Write(" PSYCHIC ");
                                            break;
                                        case Monster_Race.Water:
                                            ASCII.Type(Monster_Race.Electric, 60, 13, gbText, gbBackground);
                                            Console.Write(" ");
                                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                            Console.Write(" PSYCHIC ");
                                            break;
                                        case Monster_Race.Electric:
                                            ASCII.Type(Monster_Race.Ground, 60, 13, gbText, gbBackground);
                                            Console.Write(" ");
                                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                            Console.Write(" PSYCHIC ");
                                            break;
                                        case Monster_Race.Ground:
                                            ASCII.Type(Monster_Race.Fire, 60, 13, gbText, gbBackground);
                                            break;
                                        case Monster_Race.Psychic:
                                            //TODO ADD More Race Types and Weaknesses
                                            break;
                                    }
                                    Console.ForegroundColor = gbText;
                                    Console.BackgroundColor = gbBackground;
                                    #endregion
                                }
                                if (navX == 3)
                                {
                                    #region Display Moves
                                    if (monster.EquippedMoves.Move1.Type != Monster_Race.NONE)
                                    {
                                        ASCII.Type(monster.EquippedMoves.Move1.Type, 40, 7, gbText, gbBackground);
                                        Console.SetCursorPosition(60, 7);
                                        Console.Write(monster.EquippedMoves.Move1.Name);
                                        Console.SetCursorPosition(60, 8);
                                        Console.Write($"PP          {monster.EquippedMoves.Move1.Uses}/{monster.EquippedMoves.Move1.MaxUses}");
                                    }
                                    if (monster.EquippedMoves.Move2.Type != Monster_Race.NONE)
                                    {
                                        ASCII.Type(monster.EquippedMoves.Move2.Type, 40, 11, gbText, gbBackground);
                                        Console.SetCursorPosition(60, 11);
                                        Console.Write(monster.EquippedMoves.Move2.Name);
                                        Console.SetCursorPosition(60, 12);
                                    }
                                    if (monster.EquippedMoves.Move3.Type != Monster_Race.NONE)
                                    {
                                        ASCII.Type(monster.EquippedMoves.Move3.Type, 40, 15, gbText, gbBackground);
                                        Console.SetCursorPosition(60, 15);
                                        Console.Write(monster.EquippedMoves.Move3.Name);
                                        Console.SetCursorPosition(60, 16);
                                    }
                                    if (monster.EquippedMoves.Move4.Type != Monster_Race.NONE)
                                    {
                                        ASCII.Type(monster.EquippedMoves.Move4.Type, 40, 19, gbText, gbBackground);
                                        Console.SetCursorPosition(60, 19);
                                        Console.Write(monster.EquippedMoves.Move4.Name);
                                        Console.SetCursorPosition(60, 20);
                                    }
                                    #endregion
                                }
                                Console.SetCursorPosition(90, 42);
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.UpArrow:
                                    case ConsoleKey.W:
                                        chooseNum -= 1;
                                        if (chooseNum == 1)
                                        {
                                            monster = player.Party.MonsterEquipped;
                                        }
                                        if (chooseNum == 2)
                                        {
                                            monster = player.Party.Slot2;
                                        }
                                        if (chooseNum == 3)
                                        {
                                            monster = player.Party.Slot3;
                                        }
                                        if (chooseNum == 4)
                                        {
                                            monster = player.Party.Slot4;
                                        }
                                        if (chooseNum == 5)
                                        {
                                            monster = player.Party.Slot5;
                                        }
                                        if (chooseNum == 6)
                                        {
                                            monster = player.Party.Slot6;
                                        }
                                        if (monster.Type == Monster_Race.NONE || chooseNum == 0)
                                        {
                                            chooseNum += 1;
                                        }
                                        reloadEntry = true;
                                        break;
                                    case ConsoleKey.DownArrow:
                                    case ConsoleKey.S:
                                        chooseNum += 1;
                                        if (chooseNum == 1)
                                        {
                                            monster = player.Party.MonsterEquipped;
                                        }
                                        if (chooseNum == 2)
                                        {
                                            monster = player.Party.Slot2;
                                        }
                                        if (chooseNum == 3)
                                        {
                                            monster = player.Party.Slot3;
                                        }
                                        if (chooseNum == 4)
                                        {
                                            monster = player.Party.Slot4;
                                        }
                                        if (chooseNum == 5)
                                        {
                                            monster = player.Party.Slot5;
                                        }
                                        if (chooseNum == 6)
                                        {
                                            monster = player.Party.Slot6;
                                        }
                                        if (monster.Type == Monster_Race.NONE || chooseNum == 7)
                                        {
                                            chooseNum -= 1;
                                        }
                                        reloadEntry = true;
                                        break;
                                    case ConsoleKey.LeftArrow:
                                    case ConsoleKey.A:
                                        navX -= 1;
                                        if (navX == 0)
                                        {
                                            navX += 1;
                                        }
                                        reloadEntry = true;
                                        break;
                                    case ConsoleKey.RightArrow:
                                    case ConsoleKey.D:
                                        navX += 1;
                                        if (navX == 5)
                                        {
                                            navX -= 1;
                                        }
                                        reloadEntry = true;
                                        break;
                                    case ConsoleKey.Enter:
                                    case ConsoleKey.K:
                                        reloadEntry = true;
                                        break;
                                    case ConsoleKey.Backspace:
                                    case ConsoleKey.O:
                                        ASCII.Party(player, gbText, gbBackground);
                                        reloadPopUp = true;
                                        reloadEntry = false;
                                        break;
                                    default:
                                        break;
                                }
                            } while (reloadEntry);
                            posY = 15;
                            chooseNum = navY;
                        }
                        if (posY == 16)
                        {
                            //TODO ADD Switch functionality OUTSIDE OF BATTLE

                            PartySwitch(player, new Monster(), chooseNum, navPlayerMenu, gbText, gbBackground);
                            ASCII.Party(player, gbText, gbBackground);
                            reloadPopUp = true;
                            posY = 16;
                        }
                        if (posY == 17)
                        {
                            //TODO ADD Give Item functionality OUTSIDE OF BATTLE
                            posY = 17;
                        }
                        if (posY == 18)
                        {
                            reloadPopUp = false;
                        }
                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        reloadPopUp = false;
                        break;
                    default:
                        reloadPopUp = true;
                        break;
                }
            } while (reloadPopUp);
        }

        public static void PlayerPartyMenu(Player player, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadParty = false;
            int posX = 6;
            int posY = 3;

            ASCII.Party(player, gbText, gbBackground);
            do
            {
                ASCII.StaticMessageBox(gbText, gbBackground);
                Console.SetCursorPosition(posX, posY);
                Console.Write("███");
                Console.SetCursorPosition(posX, posY + 1);
                Console.Write("███");
                Console.SetCursorPosition(posX, posY + 2);
                Console.Write("███");
                Console.SetCursorPosition(90, 42);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posY += 6;
                        if (posY > 16 ||
                            posX == 6 && posY == 9 && player.Party.Slot3.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 10 && player.Party.Slot4.Type == Monster_Race.NONE ||
                            posX == 6 && posY == 15 && player.Party.Slot5.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 16 && player.Party.Slot6.Type == Monster_Race.NONE)
                        {
                            posY -= 6;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posY -= 6;
                        if (posY < 3)
                        {
                            posY += 6;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posX += 76;
                        posY += 1;
                        if (posX > 82 ||
                            posX == 82 && posY == 4 && player.Party.Slot2.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 10 && player.Party.Slot4.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 16 && player.Party.Slot6.Type == Monster_Race.NONE)
                        {
                            posX -= 76;
                            posY -= 1;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posX -= 76;
                        posY -= 1;
                        if (posX < 6)
                        {
                            posX += 76;
                            posY += 1;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.Enter:
                        //Monster Equipped
                        if (posX == 6 && posY == 3)
                        {
                            PartyPopUp(player, new Monster(), 1, navPlayerMenu, gbText, gbBackground);
                            ASCII.Party(player, gbText, gbBackground);
                            reloadParty = true;
                        }
                        //Slot 3
                        else if (posX == 6 && posY == 9)
                        {
                            PartyPopUp(player, new Monster(), 3, navPlayerMenu, gbText, gbBackground);
                            ASCII.Party(player, gbText, gbBackground);
                            reloadParty = true;
                        }
                        //Slot 5
                        else if (posX == 6 && posY == 15)
                        {
                            PartyPopUp(player, new Monster(), 5, navPlayerMenu, gbText, gbBackground);
                            ASCII.Party(player, gbText, gbBackground);
                            reloadParty = true;
                        }
                        //Slot 2
                        else if (posX == 82 && posY == 4)
                        {
                            PartyPopUp(player, new Monster(), 2, navPlayerMenu, gbText, gbBackground);
                            ASCII.Party(player, gbText, gbBackground);
                            reloadParty = true;
                        }
                        //Slot 4
                        else if (posX == 82 && posY == 10)
                        {
                            PartyPopUp(player, new Monster(), 4, navPlayerMenu, gbText, gbBackground);
                            ASCII.Party(player, gbText, gbBackground);
                            reloadParty = true;
                        }
                        //Slot 6
                        else if (posX == 82 && posY == 16)
                        {
                            PartyPopUp(player, new Monster(), 6, navPlayerMenu, gbText, gbBackground);
                            ASCII.Party(player, gbText, gbBackground);
                            reloadParty = true;
                        }
                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        reloadParty = false;
                        break;
                    default:
                        reloadParty = true;
                        break;
                }
            } while (reloadParty);
        }

        public static void PartySwitch(Player player, Monster monsterChoose, int chooseNum, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadParty = false;
            int posX = 6;
            int posY = 3;

            if (chooseNum == 1)
            {
                monsterChoose = player.Party.MonsterEquipped;
            }
            if (chooseNum == 2)
            {
                monsterChoose = player.Party.Slot2;
            }
            if (chooseNum == 3)
            {
                monsterChoose = player.Party.Slot3;
            }
            if (chooseNum == 4)
            {
                monsterChoose = player.Party.Slot4;
            }
            if (chooseNum == 5)
            {
                monsterChoose = player.Party.Slot5;
            }
            if (chooseNum == 6)
            {
                monsterChoose = player.Party.Slot6;
            }


            ASCII.Party(player, gbText, gbBackground);
            do
            {
                if (posX == 6 && posY == 3)
                {
                    ASCII.InstantMessage($"Swap {monsterChoose.Name.ToUpper()} with {player.Party.MonsterEquipped.Name.ToUpper()}?", gbText, gbBackground);
                }
                if (posX == 6 && posY == 9)
                {
                    ASCII.InstantMessage($"Swap {monsterChoose.Name.ToUpper()} with {player.Party.Slot3.Name.ToUpper()}?", gbText, gbBackground);
                }
                if (posX == 6 && posY == 15)
                {
                    ASCII.InstantMessage($"Swap {monsterChoose.Name.ToUpper()} with {player.Party.Slot5.Name.ToUpper()}?", gbText, gbBackground);
                }
                if (posX == 82 && posY == 4)
                {
                    ASCII.InstantMessage($"Swap {monsterChoose.Name.ToUpper()} with {player.Party.Slot2.Name.ToUpper()}?", gbText, gbBackground);
                }
                if (posX == 82 && posY == 10)
                {
                    ASCII.InstantMessage($"Swap {monsterChoose.Name.ToUpper()} with {player.Party.Slot4.Name.ToUpper()}?", gbText, gbBackground);
                }
                if (posX == 82 && posY == 16)
                {
                    ASCII.InstantMessage($"Swap {monsterChoose.Name.ToUpper()} with {player.Party.Slot6.Name.ToUpper()}?", gbText, gbBackground);
                }
                Console.SetCursorPosition(posX, posY);
                Console.Write("███");
                Console.SetCursorPosition(posX, posY + 1);
                Console.Write("███");
                Console.SetCursorPosition(posX, posY + 2);
                Console.Write("███");
                Console.SetCursorPosition(90, 42);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posY += 6;
                        if (posY > 16 ||
                            posX == 6 && posY == 9 && player.Party.Slot3.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 10 && player.Party.Slot4.Type == Monster_Race.NONE ||
                            posX == 6 && posY == 15 && player.Party.Slot5.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 16 && player.Party.Slot6.Type == Monster_Race.NONE)
                        {
                            posY -= 6;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posY -= 6;
                        if (posY < 3)
                        {
                            posY += 6;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posX += 76;
                        posY += 1;
                        if (posX > 82 ||
                            posX == 82 && posY == 4 && player.Party.Slot2.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 10 && player.Party.Slot4.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 16 && player.Party.Slot6.Type == Monster_Race.NONE)
                        {
                            posX -= 76;
                            posY -= 1;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posX -= 76;
                        posY -= 1;
                        if (posX < 6)
                        {
                            posX += 76;
                            posY += 1;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.Enter:

                        //Monster Equipped
                        if (posX == 6 && posY == 3)
                        {
                            //player.Party.MonsterSwitch = monsterChoose;
                            //monsterChoose = player.Party.MonsterEquipped;
                            //player.Party.MonsterEquipped = player.Party.MonsterSwitch;
                            //reloadParty = false;
                            switch (chooseNum)
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

                        }
                        //Slot 3
                        else if (posX == 6 && posY == 9/* && monsterChoose != player.Party.Slot3*/)
                        {
                            //player.Party.MonsterSwitch = player.Party.Slot3;
                            //player.Party.Slot3 = monsterChoose;
                            //monsterChoose = player.Party.MonsterSwitch;
                            //reloadParty = false;
                            switch (chooseNum)
                            {
                                case 1:
                                    player.Party.MonsterSwitch = player.Party.Slot3;
                                    player.Party.Slot3 = player.Party.MonsterEquipped;
                                    player.Party.MonsterEquipped = player.Party.MonsterSwitch;
                                    break;
                                case 2:
                                    player.Party.MonsterSwitch = player.Party.Slot3;
                                    player.Party.Slot3 = player.Party.Slot2;
                                    player.Party.Slot2 = player.Party.MonsterSwitch;
                                    break;
                                case 4:
                                    player.Party.MonsterSwitch = player.Party.Slot3;
                                    player.Party.Slot3 = player.Party.Slot4;
                                    player.Party.Slot4 = player.Party.MonsterSwitch;
                                    break;
                                case 5:
                                    player.Party.MonsterSwitch = player.Party.Slot3;
                                    player.Party.Slot3 = player.Party.Slot5;
                                    player.Party.Slot5 = player.Party.MonsterSwitch;
                                    break;
                                case 6:
                                    player.Party.MonsterSwitch = player.Party.Slot3;
                                    player.Party.Slot3 = player.Party.Slot6;
                                    player.Party.Slot6 = player.Party.MonsterSwitch;
                                    break;
                                default:
                                    break;
                            }

                        }
                        //Slot 5
                        else if (posX == 6 && posY == 15/* && monsterChoose != player.Party.Slot5*/)
                        {
                            //player.Party.MonsterSwitch = monsterChoose;
                            //monsterChoose = player.Party.Slot5;
                            //player.Party.Slot5 = player.Party.MonsterSwitch;
                            //reloadParty = false;
                            switch (chooseNum)
                            {
                                case 1:
                                    player.Party.MonsterSwitch = player.Party.Slot5;
                                    player.Party.Slot5 = player.Party.MonsterEquipped;
                                    player.Party.MonsterEquipped = player.Party.MonsterSwitch;
                                    break;
                                case 2:
                                    player.Party.MonsterSwitch = player.Party.Slot5;
                                    player.Party.Slot5 = player.Party.Slot2;
                                    player.Party.Slot2 = player.Party.MonsterSwitch;
                                    break;
                                case 3:
                                    player.Party.MonsterSwitch = player.Party.Slot5;
                                    player.Party.Slot5 = player.Party.Slot3;
                                    player.Party.Slot3 = player.Party.MonsterSwitch;
                                    break;
                                case 4:
                                    player.Party.MonsterSwitch = player.Party.Slot5;
                                    player.Party.Slot5 = player.Party.Slot4;
                                    player.Party.Slot4 = player.Party.MonsterSwitch;
                                    break;
                                case 6:
                                    player.Party.MonsterSwitch = player.Party.Slot5;
                                    player.Party.Slot5 = player.Party.Slot6;
                                    player.Party.Slot6 = player.Party.MonsterSwitch;
                                    break;
                                default:
                                    break;
                            }

                        }
                        //Slot 2
                        else if (posX == 82 && posY == 4/* && monsterChoose != player.Party.Slot2*/)
                        {
                            switch (chooseNum)
                            {
                                case 1:
                                    player.Party.MonsterSwitch = player.Party.Slot2;
                                    player.Party.Slot2 = player.Party.MonsterEquipped;
                                    player.Party.MonsterEquipped = player.Party.MonsterSwitch;
                                    break;
                                case 3:
                                    player.Party.MonsterSwitch = player.Party.Slot2;
                                    player.Party.Slot2 = player.Party.Slot3;
                                    player.Party.Slot3 = player.Party.MonsterSwitch;
                                    break;
                                case 4:
                                    player.Party.MonsterSwitch = player.Party.Slot2;
                                    player.Party.Slot2 = player.Party.Slot4;
                                    player.Party.Slot4 = player.Party.MonsterSwitch;
                                    break;
                                case 5:
                                    player.Party.MonsterSwitch = player.Party.Slot2;
                                    player.Party.Slot2 = player.Party.Slot5;
                                    player.Party.Slot5 = player.Party.MonsterSwitch;
                                    break;
                                case 6:
                                    player.Party.MonsterSwitch = player.Party.Slot2;
                                    player.Party.Slot2 = player.Party.Slot6;
                                    player.Party.Slot6 = player.Party.MonsterSwitch;
                                    break;
                                default:
                                    break;
                            }

                        }
                        //Slot 4
                        else if (posX == 82 && posY == 10/* && monsterChoose != player.Party.Slot4*/)
                        {
                            //player.Party.MonsterSwitch = monsterChoose;
                            //monsterChoose = player.Party.Slot4;
                            //player.Party.Slot4 = player.Party.MonsterSwitch;
                            //reloadParty = false;
                            switch (chooseNum)
                            {
                                case 1:
                                    player.Party.MonsterSwitch = player.Party.Slot4;
                                    player.Party.Slot4 = player.Party.MonsterEquipped;
                                    player.Party.MonsterEquipped = player.Party.MonsterSwitch;
                                    break;
                                case 2:
                                    player.Party.MonsterSwitch = player.Party.Slot4;
                                    player.Party.Slot4 = player.Party.Slot2;
                                    player.Party.Slot2 = player.Party.MonsterSwitch;
                                    break;
                                case 3:
                                    player.Party.MonsterSwitch = player.Party.Slot4;
                                    player.Party.Slot4 = player.Party.Slot3;
                                    player.Party.Slot3 = player.Party.MonsterSwitch;
                                    break;
                                case 5:
                                    player.Party.MonsterSwitch = player.Party.Slot4;
                                    player.Party.Slot4 = player.Party.Slot5;
                                    player.Party.Slot5 = player.Party.MonsterSwitch;
                                    break;
                                case 6:
                                    player.Party.MonsterSwitch = player.Party.Slot4;
                                    player.Party.Slot4 = player.Party.Slot6;
                                    player.Party.Slot6 = player.Party.MonsterSwitch;
                                    break;
                                default:
                                    break;
                            }

                        }
                        //Slot 6
                        else if (posX == 82 && posY == 16/* && monsterChoose != player.Party.Slot6*/)
                        {
                            //player.Party.MonsterSwitch = monsterChoose;
                            //monsterChoose = player.Party.Slot6;
                            //player.Party.Slot6 = player.Party.MonsterSwitch;
                            //reloadParty = false;
                            switch (chooseNum)
                            {
                                case 1:
                                    player.Party.MonsterSwitch = player.Party.Slot6;
                                    player.Party.Slot6 = player.Party.MonsterEquipped;
                                    player.Party.MonsterEquipped = player.Party.MonsterSwitch;
                                    break;
                                case 2:
                                    player.Party.MonsterSwitch = player.Party.Slot6;
                                    player.Party.Slot6 = player.Party.Slot2;
                                    player.Party.Slot2 = player.Party.MonsterSwitch;
                                    break;
                                case 3:
                                    player.Party.MonsterSwitch = player.Party.Slot6;
                                    player.Party.Slot6 = player.Party.Slot3;
                                    player.Party.Slot3 = player.Party.MonsterSwitch;
                                    break;
                                case 4:
                                    player.Party.MonsterSwitch = player.Party.Slot6;
                                    player.Party.Slot6 = player.Party.Slot4;
                                    player.Party.Slot4 = player.Party.MonsterSwitch;
                                    break;
                                case 5:
                                    player.Party.MonsterSwitch = player.Party.Slot6;
                                    player.Party.Slot6 = player.Party.Slot5;
                                    player.Party.Slot5 = player.Party.MonsterSwitch;
                                    break;
                                default:
                                    break;
                            }

                        }
                        reloadParty = false;
                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        reloadParty = false;
                        break;
                    default:
                        reloadParty = true;
                        break;
                }
            } while (reloadParty);
        }

        /****FOR BATTLE****/

        public static void PartyPopUpBATTLE(Player player, Monster monster, Monster defender, int chooseNum, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadPopUp = false;
            bool reloadEntry = false;

            int posY = 15;
            int selectY = 16;
            string message1 = $"Do what with {player.Party.MonsterEquipped.Name.ToUpper()}?";
            string message2 = $"Do what with {player.Party.Slot2.Name.ToUpper()}?";
            string message3 = $"Do what with {player.Party.Slot3.Name.ToUpper()}?";
            string message4 = $"Do what with {player.Party.Slot4.Name.ToUpper()}?";
            string message5 = $"Do what with {player.Party.Slot5.Name.ToUpper()}?";
            string message6 = $"Do what with {player.Party.Slot6.Name.ToUpper()}?";

            if (chooseNum == 1)
            {
                monster = player.Party.MonsterEquipped;
                ASCII.InstantMessage(message1, gbText, gbBackground);
            }
            if (chooseNum == 2)
            {
                monster = player.Party.Slot2;
                ASCII.InstantMessage(message2, gbText, gbBackground);
            }
            if (chooseNum == 3)
            {
                monster = player.Party.Slot3;
                ASCII.InstantMessage(message3, gbText, gbBackground);
            }
            if (chooseNum == 4)
            {
                monster = player.Party.Slot4;
                ASCII.InstantMessage(message4, gbText, gbBackground);
            }
            if (chooseNum == 5)
            {
                monster = player.Party.Slot5;
                ASCII.InstantMessage(message5, gbText, gbBackground);
            }
            if (chooseNum == 6)
            {
                monster = player.Party.Slot6;
                ASCII.InstantMessage(message6, gbText, gbBackground);
            }
            posY = 16;
            do
            {
                int popupY = 15;
                foreach (string line in ASCII.partyBattle)
                {
                    Console.SetCursorPosition(66, popupY);
                    Console.Write(line);
                    popupY += 1;
                }
                Console.SetCursorPosition(67, selectY);
                Console.Write(">");
                Console.SetCursorPosition(90, 42);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Console.SetCursorPosition(67, selectY);
                        Console.Write(" ");
                        selectY -= 1;
                        if (selectY == 15)
                        {
                            selectY += 1;
                            reloadPopUp = true;
                        }
                        else
                        {
                            reloadPopUp = true;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Console.SetCursorPosition(67, selectY);
                        Console.Write(" ");
                        selectY += 1;
                        if (selectY == 19)
                        {
                            selectY -= 1;
                            reloadPopUp = true;
                        }
                        else
                        {
                            reloadPopUp = true;
                        }
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.K:
                        if (selectY == 16)
                        {
                            if (monster == player.Party.MonsterEquipped)
                            {
                                ASCII.Party(player, gbText, gbBackground);
                                ASCII.ScrollMessage($"{player.Party.MonsterEquipped.Name.ToUpper()} is already in battle!", 50, 1500, gbText, gbBackground);
                                reloadPopUp = false;
                            }
                            else
                            {
                                ASCII.InstantMessage($"Send out {monster.Name.ToUpper()}?", gbText, gbBackground);
                                QueSwitch(player, defender, chooseNum, navPlayerMenu, gbText, gbBackground);
                                reloadPopUp = false;
                            }
                        }
                        if (selectY == 17)
                        {
                            posY = 2;
                            int navX = 1;
                            int navY = chooseNum;
                            do
                            {
                                posY = 2;
                                foreach (string line in ASCII.pokedexEntry)
                                {
                                    Console.SetCursorPosition(4, posY);
                                    Console.Write(line);
                                    posY += 1;
                                }
                                if (navX == 2)
                                {
                                    posY = 2;
                                    foreach (string line in ASCII.pokedexStats)
                                    {
                                        Console.SetCursorPosition(25, posY);
                                        Console.Write(line);
                                        posY += 1;
                                    }
                                }
                                if (navX == 3)
                                {
                                    posY = 2;
                                    foreach (string line in ASCII.pokedexMoves)
                                    {
                                        Console.SetCursorPosition(25, posY);
                                        Console.Write(line);
                                        posY += 1;
                                    }
                                }
                                if (navX == 4)
                                {
                                    posY = 2;
                                    foreach (string line in ASCII.pokedexExit)
                                    {
                                        Console.SetCursorPosition(25, posY);
                                        Console.Write(line);
                                        posY += 1;
                                    }
                                }

                                if (chooseNum == 1)
                                {
                                    monster = player.Party.MonsterEquipped;
                                }
                                if (chooseNum == 2)
                                {
                                    monster = player.Party.Slot2;
                                }
                                if (chooseNum == 3)
                                {
                                    monster = player.Party.Slot3;
                                }
                                if (chooseNum == 4)
                                {
                                    monster = player.Party.Slot4;
                                }
                                if (chooseNum == 5)
                                {
                                    monster = player.Party.Slot5;
                                }
                                if (chooseNum == 6)
                                {
                                    monster = player.Party.Slot6;
                                }
                                //Displays Monster Art
                                posY = 9;
                                foreach (string line in monster.ASCIIPokedex)
                                {
                                    Console.SetCursorPosition(6, posY);
                                    Console.Write(line);
                                    posY += 1;
                                }
                                if (navX == 1)
                                {
                                    #region Display Pokedex Entry
                                    ASCII.NameANDGender(monster, 7, 3, gbText, gbBackground);
                                    ASCII.Level(monster, 7, 4, gbText, gbBackground);
                                    Console.SetCursorPosition(60, 7);
                                    Console.Write(monster.PokeIndex);
                                    ASCII.Name(monster, 60, 9, gbText, gbBackground);
                                    ASCII.Type(monster.Type, 60, 11, gbText, gbBackground);
                                    Console.SetCursorPosition(60, 13);
                                    Console.Write(player.Name.ToUpper());
                                    Console.SetCursorPosition(60, 18);
                                    Console.Write(monster.MaxExp - monster.Exp);
                                    ASCII.ExpBar(monster, 58, 20);
                                    #endregion
                                }
                                if (navX == 2)
                                {
                                    #region Display Current Stats
                                    ASCII.Health(monster, 60, 7, gbText, gbBackground);
                                    //TODO ADD Attack stat to Monster Class
                                    //TODO ADD Defense stat to Monster Class

                                    Console.SetCursorPosition(60, 13);
                                    switch (monster.Type)
                                    {
                                        case Monster_Race.Normal:
                                            break;
                                        case Monster_Race.Fire:
                                            ASCII.Type(Monster_Race.Water, 60, 13, gbText, gbBackground);
                                            Console.Write(" ");
                                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                            Console.Write(" PSYCHIC ");
                                            break;
                                        case Monster_Race.Water:
                                            ASCII.Type(Monster_Race.Electric, 60, 13, gbText, gbBackground);
                                            Console.Write(" ");
                                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                            Console.Write(" PSYCHIC ");
                                            break;
                                        case Monster_Race.Electric:
                                            ASCII.Type(Monster_Race.Ground, 60, 13, gbText, gbBackground);
                                            Console.Write(" ");
                                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                                            Console.Write(" PSYCHIC ");
                                            break;
                                        case Monster_Race.Ground:
                                            ASCII.Type(Monster_Race.Fire, 60, 13, gbText, gbBackground);
                                            break;
                                        case Monster_Race.Psychic:
                                            //TODO ADD More Race Types and Weaknesses
                                            break;
                                    }
                                    Console.ForegroundColor = gbText;
                                    Console.BackgroundColor = gbBackground;
                                    #endregion
                                }
                                if (navX == 3)
                                {
                                    #region Display Moves
                                    if (monster.EquippedMoves.Move1.Type != Monster_Race.NONE)
                                    {
                                        ASCII.Type(monster.EquippedMoves.Move1.Type, 40, 7, gbText, gbBackground);
                                        Console.SetCursorPosition(60, 7);
                                        Console.Write(monster.EquippedMoves.Move1.Name);
                                        Console.SetCursorPosition(60, 8);
                                        Console.Write($"PP          {monster.EquippedMoves.Move1.Uses}/{monster.EquippedMoves.Move1.MaxUses}");
                                    }
                                    if (monster.EquippedMoves.Move2.Type != Monster_Race.NONE)
                                    {
                                        ASCII.Type(monster.EquippedMoves.Move2.Type, 40, 11, gbText, gbBackground);
                                        Console.SetCursorPosition(60, 11);
                                        Console.Write(monster.EquippedMoves.Move2.Name);
                                        Console.SetCursorPosition(60, 12);
                                    }
                                    if (monster.EquippedMoves.Move3.Type != Monster_Race.NONE)
                                    {
                                        ASCII.Type(monster.EquippedMoves.Move3.Type, 40, 15, gbText, gbBackground);
                                        Console.SetCursorPosition(60, 15);
                                        Console.Write(monster.EquippedMoves.Move3.Name);
                                        Console.SetCursorPosition(60, 16);
                                    }
                                    if (monster.EquippedMoves.Move4.Type != Monster_Race.NONE)
                                    {
                                        ASCII.Type(monster.EquippedMoves.Move4.Type, 40, 19, gbText, gbBackground);
                                        Console.SetCursorPosition(60, 19);
                                        Console.Write(monster.EquippedMoves.Move4.Name);
                                        Console.SetCursorPosition(60, 20);
                                    }
                                    #endregion
                                }
                                Console.SetCursorPosition(90, 42);
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.UpArrow:
                                    case ConsoleKey.W:
                                        chooseNum -= 1;
                                        if (chooseNum == 1)
                                        {
                                            monster = player.Party.MonsterEquipped;
                                        }
                                        if (chooseNum == 2)
                                        {
                                            monster = player.Party.Slot2;
                                        }
                                        if (chooseNum == 3)
                                        {
                                            monster = player.Party.Slot3;
                                        }
                                        if (chooseNum == 4)
                                        {
                                            monster = player.Party.Slot4;
                                        }
                                        if (chooseNum == 5)
                                        {
                                            monster = player.Party.Slot5;
                                        }
                                        if (chooseNum == 6)
                                        {
                                            monster = player.Party.Slot6;
                                        }
                                        if (monster.Type == Monster_Race.NONE || chooseNum == 0)
                                        {
                                            chooseNum += 1;
                                        }
                                        reloadEntry = true;
                                        break;
                                    case ConsoleKey.DownArrow:
                                    case ConsoleKey.S:
                                        chooseNum += 1;
                                        if (chooseNum == 1)
                                        {
                                            monster = player.Party.MonsterEquipped;
                                        }
                                        if (chooseNum == 2)
                                        {
                                            monster = player.Party.Slot2;
                                        }
                                        if (chooseNum == 3)
                                        {
                                            monster = player.Party.Slot3;
                                        }
                                        if (chooseNum == 4)
                                        {
                                            monster = player.Party.Slot4;
                                        }
                                        if (chooseNum == 5)
                                        {
                                            monster = player.Party.Slot5;
                                        }
                                        if (chooseNum == 6)
                                        {
                                            monster = player.Party.Slot6;
                                        }
                                        if (monster.Type == Monster_Race.NONE || chooseNum == 7)
                                        {
                                            chooseNum -= 1;
                                        }
                                        reloadEntry = true;
                                        break;
                                    case ConsoleKey.LeftArrow:
                                    case ConsoleKey.A:
                                        navX -= 1;
                                        if (navX == 0)
                                        {
                                            navX += 1;
                                        }
                                        reloadEntry = true;
                                        break;
                                    case ConsoleKey.RightArrow:
                                    case ConsoleKey.D:
                                        navX += 1;
                                        if (navX == 5)
                                        {
                                            navX -= 1;
                                        }
                                        reloadEntry = true;
                                        break;
                                    case ConsoleKey.Enter:
                                    case ConsoleKey.K:
                                        reloadEntry = true;
                                        break;
                                    case ConsoleKey.Backspace:
                                    case ConsoleKey.O:
                                        ASCII.Party(player, gbText, gbBackground);
                                        reloadEntry = false;
                                        break;
                                    default:
                                        break;
                                }
                            } while (reloadEntry);
                            chooseNum = navY;
                        }
                        if (selectY == 18)
                        {
                            ASCII.Party(player, gbText, gbBackground);
                            reloadEntry = false;
                            reloadPopUp = false;
                        }
                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        reloadPopUp = false;
                        break;
                    default:
                        reloadPopUp = true;
                        break;
                }
            } while (reloadPopUp);
        }

        public static void PlayerPartyMenuBattle(Player player, Monster defender, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadParty = false;
            int posX = 6;
            int posY = 3;

            ASCII.Party(player, gbText, gbBackground);
            do
            {
                ASCII.StaticMessageBox(gbText, gbBackground);
                Console.SetCursorPosition(posX, posY);
                Console.Write("███");
                Console.SetCursorPosition(posX, posY + 1);
                Console.Write("███");
                Console.SetCursorPosition(posX, posY + 2);
                Console.Write("███");
                Console.SetCursorPosition(90, 42);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posY += 6;
                        if (posY > 16 ||
                            posX == 6 && posY == 9 && player.Party.Slot3.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 10 && player.Party.Slot4.Type == Monster_Race.NONE ||
                            posX == 6 && posY == 15 && player.Party.Slot5.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 16 && player.Party.Slot6.Type == Monster_Race.NONE)
                        {
                            posY -= 6;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posY -= 6;
                        if (posY < 3)
                        {
                            posY += 6;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posX += 76;
                        posY += 1;
                        if (posX > 82 ||
                            posX == 82 && posY == 4 && player.Party.Slot2.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 10 && player.Party.Slot4.Type == Monster_Race.NONE ||
                            posX == 82 && posY == 16 && player.Party.Slot6.Type == Monster_Race.NONE)
                        {
                            posX -= 76;
                            posY -= 1;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        Console.SetCursorPosition(posX, posY);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 1);
                        Console.Write("   ");
                        Console.SetCursorPosition(posX, posY + 2);
                        Console.Write("   ");
                        posX -= 76;
                        posY -= 1;
                        if (posX < 6)
                        {
                            posX += 76;
                            posY += 1;
                        }
                        reloadParty = true;
                        break;
                    case ConsoleKey.Enter:

                        #region Que Switch BEFORE ATTACK

                        Monster current1 = player.Party.MonsterEquipped;
                        Monster current2 = player.Party.Slot2;
                        Monster current3 = player.Party.Slot3;
                        Monster current4 = player.Party.Slot4;
                        Monster current5 = player.Party.Slot5;
                        Monster current6 = player.Party.Slot6;


                        //int currentHealth1 = player.Party.MonsterEquipped.Health;
                        //int currentHealth2 = player.Party.Slot2.Health;
                        //int currentHealth3 = player.Party.Slot3.Health;
                        //int currentHealth4 = player.Party.Slot4.Health;
                        //int currentHealth5 = player.Party.Slot5.Health;
                        //int currentHealth6 = player.Party.Slot6.Health;

                        //Monster Equipped
                        if (posX == 6 && posY == 3)
                        {
                            PartyPopUpBATTLE(player, new Monster(), defender, 1, navPlayerMenu, gbText, gbBackground);
                            if (player.Party.MonsterEquipped != current1)
                            {
                                reloadParty = false;
                            }
                            else
                            {
                                ASCII.Party(player, gbText, gbBackground);
                                reloadParty = true;
                            }
                        }
                        //Slot 3
                        else if (posX == 6 && posY == 9)
                        {
                            PartyPopUpBATTLE(player, new Monster(), defender, 3, navPlayerMenu, gbText, gbBackground);
                            if (player.Party.Slot3 != current3)
                            {
                                reloadParty = false;
                            }
                            else
                            {
                                ASCII.Party(player, gbText, gbBackground);
                                reloadParty = true;
                            }
                        }
                        //Slot 5
                        else if (posX == 6 && posY == 15)
                        {
                            PartyPopUpBATTLE(player, new Monster(), defender, 5, navPlayerMenu, gbText, gbBackground);
                            if (player.Party.Slot5 != current5)
                            {
                                reloadParty = false;
                            }
                            else
                            {
                                ASCII.Party(player, gbText, gbBackground);
                                reloadParty = true;
                            }
                        }
                        //Slot 2
                        else if (posX == 82 && posY == 4)
                        {
                            PartyPopUpBATTLE(player, new Monster(), defender, 2, navPlayerMenu, gbText, gbBackground);
                            if (player.Party.Slot2 != current2)
                            {
                                reloadParty = false;
                            }
                            else
                            {
                                ASCII.Party(player, gbText, gbBackground);
                                reloadParty = true;
                            }
                        }
                        //Slot 4
                        else if (posX == 82 && posY == 10)
                        {
                            PartyPopUpBATTLE(player, new Monster(), defender, 4, navPlayerMenu, gbText, gbBackground);
                            if (player.Party.Slot4 != current4)
                            {
                                reloadParty = false;
                            }
                            else
                            {
                                ASCII.Party(player, gbText, gbBackground);
                                reloadParty = true;
                            }
                        }
                        //Slot 6
                        else if (posX == 82 && posY == 16)
                        {
                            PartyPopUpBATTLE(player, new Monster(), defender, 6, navPlayerMenu, gbText, gbBackground);
                            if (player.Party.Slot6 != current6)
                            {
                                reloadParty = false;
                            }
                            else
                            {
                                ASCII.Party(player, gbText, gbBackground);
                                reloadParty = true;
                            }
                        }
                        //}
                        #endregion

                        //#region DURING NPC BATTLE
                        ////TODO ADD SWITCH MENU OLD DURING NPC BATTLES
                        //#endregion

                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        if (defender.IsOwned == true && player.Party.MonsterEquipped.Health <= 0)
                        {
                            ASCII.ScrollMessage("You cannot escape a PvP Battle!", 25, 2000, gbText, gbBackground);
                            reloadParty = true;
                        }
                        else
                        {
                            reloadParty = false;
                        }
                        break;
                    default:
                        reloadParty = true;
                        break;
                }
            } while (reloadParty);
        }

        #endregion

        #region Player Menu Inventory

        public static void BagMenu(Player player, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadMenu = true;
            int posX = 4;
            int posY = 2;
            int selectPosX = 53;
            int selectPosY = 4;
            int disItemX = 55;
            int disItemY = 4;
            int tabSelect = 1;
            Item itemSelected = new Item();
            int navMainX = 53;
            int navMainY = 4;
            int selectionMin = 0;
            int extra = 0;

            do
            {
                List<Item> playerItems = new List<Item>();
                List<Item> playerMeds = new List<Item>();
                List<Item> playerMoves = new List<Item>();
                List<Item> playerBattle = new List<Item>();
                int itemCount = 0;
                while (itemCount < player.Inventory.ItemSection.Length)
                {
                    if (player.Inventory.ItemSection[itemCount].Amount > 0)
                    {
                        playerItems.Add(player.Inventory.ItemSection[itemCount]);
                    }
                    itemCount += 1;
                }
                itemCount = 0;
                while (itemCount < player.Inventory.MedSection.Length)
                {
                    if (player.Inventory.MedSection[itemCount].Amount > 0)
                    {
                        playerMeds.Add(player.Inventory.MedSection[itemCount]);
                    }
                    itemCount += 1;
                }
                itemCount = 0;
                while (itemCount < player.Inventory.MoveSection.Length)
                {
                    if (player.Inventory.MoveSection[itemCount].Amount > 0)
                    {
                        playerMoves.Add(player.Inventory.MoveSection[itemCount]);
                    }
                    itemCount += 1;
                }
                itemCount = 0;
                while (itemCount < player.Inventory.BattleSection.Length)
                {
                    if (player.Inventory.BattleSection[itemCount].Amount > 0)
                    {
                        playerBattle.Add(player.Inventory.BattleSection[itemCount]);
                    }
                    itemCount += 1;
                }
                List<Item> currentTab = playerItems;

                ASCII.ResetScreen(gbText, gbBackground);
                ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
                ASCII.BagMenuRight(gbText, gbBackground);

                if (tabSelect == 1)
                {
                    if (playerItems.Count > 0)
                    {
                        currentTab = playerItems;
                        if (player.Inventory.ItemSection.Length != 0)
                        {
                            itemSelected = currentTab.ElementAt(navMainY - 4);
                        }
                    }
                    else
                    {
                        currentTab = playerItems;
                        currentTab.Add(Item.empty);

                        itemSelected = currentTab.ElementAt(navMainY - 4);
                    }
                    //currentTab = playerItems;
                    //if (player.Inventory.ItemSection.Length != 0)
                    //{
                    //    itemSelected = currentTab.ElementAt(navMainY - 4);
                    //}
                }
                if (tabSelect == 2)
                {
                    if (playerMeds.Count > 0)
                    {
                        currentTab = playerMeds;
                        if (player.Inventory.MedSection.Length != 0)
                        {
                            itemSelected = currentTab.ElementAt(navMainY - 4);
                        }
                    }
                    else
                    {
                        currentTab = playerMeds;
                        currentTab.Add(Item.empty);
                        itemSelected = currentTab.ElementAt(navMainY - 4);
                    }
                    //currentTab = playerMeds;
                    //if (player.Inventory.MedSection.Length != 0)
                    //{
                    //    itemSelected = currentTab.ElementAt(navMainY - 4);
                    //}
                }
                if (tabSelect == 3)
                {
                    if (playerMoves.Count > 0)
                    {
                        currentTab = playerMoves;
                        if (player.Inventory.MoveSection.Length != 0)
                        {
                            itemSelected = currentTab.ElementAt(navMainY - 4);
                        }
                    }
                    else
                    {
                        currentTab = playerMoves;
                        currentTab.Add(Item.empty);
                        itemSelected = currentTab.ElementAt(navMainY - 4);
                    }
                    //currentTab = playerMoves;
                    //if (player.Inventory.MoveSection.Length != 0)
                    //{
                    //    itemSelected = currentTab.ElementAt(navMainY - 4);
                    //}
                    //else
                    //{
                    //    itemSelected = Item.empty;
                    //}
                }
                if (tabSelect == 4)
                {
                    if (playerBattle.Count > 0)
                    {
                        currentTab = playerBattle;
                        if (player.Inventory.BattleSection.Length != 0)
                        {
                            itemSelected = currentTab.ElementAt(navMainY - 4 + extra);
                        }
                    }
                    else
                    {
                        currentTab = playerBattle;
                        currentTab.Add(Item.pokeCatcher);
                        currentTab.Add(Item.repel);
                        currentTab.Add(Item.pokeCatcher);
                        currentTab.Add(Item.pokeCatcher);
                        currentTab.Add(Item.pokeCatcher);
                        currentTab.Add(Item.pokeCatcher);
                        currentTab.Add(Item.pokeCatcher);
                        currentTab.Add(Item.pokeCatcher);
                        currentTab.Add(Item.pokeCatcher);
                        currentTab.Add(Item.pokeCatcher);
                        currentTab.Add(Item.pokeCatcher);
                        currentTab.Add(Item.pokeCatcher);
                        currentTab.Add(Item.attackUp);
                        currentTab.Add(Item.hpUp);
                        currentTab.Add(Item.fullHeal);
                        currentTab.Add(Item.revive);
                        currentTab.Add(Item.mindStone);
                        currentTab.Add(Item.earthStone);
                        currentTab.Add(Item.aquaStone);
                        currentTab.Add(Item.repel);
                        currentTab.Add(Item.blazeStone);
                        currentTab.Add(Item.attackUp);
                        currentTab.Add(Item.hpUp);
                        currentTab.Add(Item.fullHeal);
                        currentTab.Add(Item.revive);
                        currentTab.Add(Item.mindStone);
                        currentTab.Add(Item.earthStone);
                        currentTab.Add(Item.aquaStone);
                        currentTab.Add(Item.repel);
                        currentTab.Add(Item.blazeStone);

                        itemSelected = currentTab.ElementAt(navMainY - 4 + extra);
                    }
                }
                //Displays List of Items
                disItemY = 4;
                foreach (Item item in currentTab)
                {
                    if (item.Name != "empty" && disItemY < 19)
                    {
                        Console.SetCursorPosition(disItemX, disItemY);
                        Console.Write(currentTab.ElementAt(disItemY - 4 + selectionMin).Name);
                        Console.SetCursorPosition(disItemX + 23, disItemY);
                        Console.Write($"x  {currentTab.ElementAt(disItemY - 4 + selectionMin).Amount}");
                        int selectionMax = selectionMin;
                        disItemY += 1;
                    }
                }
                //Displays Item Description
                if (itemSelected.Description.Length <= 70 && itemSelected.Name != "empty")
                {
                    ASCII.InstantMessage(itemSelected.Description, gbText, gbBackground);
                }
                else if (itemSelected.Description.Length > 70 && itemSelected.Name != "empty")
                {
                    ASCII.InstantMessageMulti(itemSelected.Description.Substring(0, 70), itemSelected.Description.Substring(70), gbText, gbBackground);
                }
                else
                {
                    ASCII.InstantMessage("empty", gbText, gbBackground);
                }

                Console.SetCursorPosition(navMainX, navMainY);
                Console.Write(">");
                navPlayerMenu = Console.ReadKey().Key;

                switch (navPlayerMenu)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Console.SetCursorPosition(navMainX, navMainY);
                        Console.Write("  ");
                        navMainY -= 1;
                        if (currentTab.Count > 15 && navMainY == 8 && selectionMin > 0)
                        {
                            navMainY += 1;
                            selectionMin -= 1;
                            extra -= 1;
                        }
                        if (navMainY < 4)
                        {
                            navMainY = 4;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Console.SetCursorPosition(navMainX, navMainY);
                        Console.Write("  ");
                        navMainY += 1;
                        if (currentTab.Count > 15 && navMainY == 14 && currentTab.Count > disItemY - 4 + selectionMin)
                        {
                            navMainY -= 1;
                            selectionMin += 1;
                            extra += 1;
                        }
                        if (currentTab.Count <= 15)
                        {
                            if (navMainY > currentTab.Count + 3)
                            {
                                navMainY = currentTab.Count + 3;
                                if (navMainY == 3)
                                {
                                    navMainY = 4;
                                }
                            }
                        }
                        if (navMainY > 18)
                        {
                            navMainY = 18;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        int preTab = tabSelect;
                        Console.SetCursorPosition(navMainX, navMainY);
                        Console.Write("  ");
                        tabSelect -= 1;
                        if (tabSelect < 1)
                        {
                            tabSelect = 1;
                        }
                        if (tabSelect != preTab)
                        {
                            navMainY = 4;
                            selectionMin = 0;
                            extra = 0;
                            ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
                            ASCII.BagMenuRight(gbText, gbBackground);
                        }
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        preTab = tabSelect;
                        Console.SetCursorPosition(navMainX, navMainY);
                        Console.Write("  ");
                        tabSelect += 1;
                        if (tabSelect > 4)
                        {
                            tabSelect = 4;
                        }
                        if (tabSelect != preTab)
                        {
                            navMainY = 4;
                            selectionMin = 0;
                            extra = 0;
                            ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
                            ASCII.BagMenuRight(gbText, gbBackground);
                        }
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.K:
                        bool reloadOptions = true;
                        int optionsPosX = 61;
                        int optionsPosY = 20;
                        string[] optionsList1 = new string[]
                        {
                            "USE",
                            "GIVE",
                            "TOSS",
                            "CANCEL"
                        };
                        string[] optionsList2 = new string[]
                        {
                            "USE",
                            "GIVE",
                            "CANCEL"
                        };
                        string[] optionsList = optionsList1;
                        if (true/*currentTab.Count != 0*/)
                        {
                            ASCII.InstantMessage($"{itemSelected.Name} is selected.", gbText, gbBackground);
                            if (tabSelect == 1 || tabSelect == 2)
                            {
                                optionsList = optionsList1;
                                optionsPosY = 20;
                                ASCII.SmallMenu(60, 19, optionsList, gbText, gbBackground);
                            }
                            if (tabSelect == 3 || tabSelect == 4)
                            {
                                optionsList = optionsList2;
                                optionsPosY = 21;
                                ASCII.SmallMenu(60, 20, optionsList, gbText, gbBackground);
                            }

                            do
                            {
                                Console.SetCursorPosition(optionsPosX, optionsPosY);
                                Console.Write(">");
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.UpArrow:
                                    case ConsoleKey.W:
                                        Console.SetCursorPosition(optionsPosX, optionsPosY);
                                        Console.Write("  ");
                                        optionsPosY -= 1;
                                        if (optionsPosY < 20 && tabSelect == 1 ||
                                            optionsPosY < 20 && tabSelect == 2 ||
                                            optionsPosY < 21 && tabSelect == 3 ||
                                            optionsPosY < 21 && tabSelect == 4)
                                        {
                                            optionsPosY = 23;
                                        }
                                        break;
                                    case ConsoleKey.DownArrow:
                                    case ConsoleKey.S:
                                        Console.SetCursorPosition(optionsPosX, optionsPosY);
                                        Console.Write("  ");
                                        optionsPosY += 1;
                                        if (optionsPosY > 23)
                                        {
                                            if (tabSelect == 1 || tabSelect == 2)
                                            {
                                                optionsPosY = 20;
                                            }
                                            if (tabSelect == 3 || tabSelect == 4)
                                            {
                                                optionsPosY = 21;
                                            }
                                        }
                                        break;
                                    case ConsoleKey.Enter:
                                    case ConsoleKey.K:
                                        //USE Feature
                                        if (optionsPosY == 20 && tabSelect == 1 ||
                                            optionsPosY == 20 && tabSelect == 2 ||
                                            optionsPosY == 21 && tabSelect == 3 ||
                                            optionsPosY == 21 && tabSelect == 4)
                                        {
                                            ASCII.ResetScreen(gbText, gbBackground);
                                            ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
                                            ASCII.BagMenuRight(gbText, gbBackground);
                                            disItemY = 4;
                                            //Displays a list of items in the selected tab
                                            foreach (Item item in currentTab)
                                            {
                                                if (item.Name != "empty" && disItemY < 19)
                                                {
                                                    Console.SetCursorPosition(disItemX, disItemY);
                                                    Console.Write(currentTab.ElementAt(disItemY - 4 + selectionMin).Name);
                                                    Console.SetCursorPosition(disItemX + 23, disItemY);
                                                    Console.Write($"x  {currentTab.ElementAt(disItemY - 4 + selectionMin).Amount}");
                                                    int selectionMax = selectionMin;
                                                    disItemY += 1;
                                                }
                                            }
                                            if (itemSelected.Section == Type.Item)
                                            {

                                            }
                                            if (itemSelected.Section == Type.Med)
                                            {

                                            }
                                            if (itemSelected.Section == Type.Move)
                                            {

                                            }
                                            if (itemSelected.Section == Type.Battle)
                                            {

                                            }
                                            //if (inCave == true || inWater == true)
                                            //{

                                            //}
                                            else
                                            {
                                                ASCII.BagMenuRight(gbText, gbBackground);
                                                disItemY = 4;

                                                //Displays a list of items in the selected tab
                                                foreach (Item item in currentTab)
                                                {
                                                    if (item.Name != "empty" && disItemY < 19)
                                                    {
                                                        Console.SetCursorPosition(disItemX, disItemY);
                                                        Console.Write(currentTab.ElementAt(disItemY - 4 + selectionMin).Name);
                                                        Console.SetCursorPosition(disItemX + 23, disItemY);
                                                        Console.Write($"x  {currentTab.ElementAt(disItemY - 4 + selectionMin).Amount}");
                                                        int selectionMax = selectionMin;
                                                        disItemY += 1;
                                                    }
                                                }
                                                ASCII.ScrollMessageMulti("Salix's words echoed...", $"{player.Name.ToUpper()}! There's a time and place for everything!", 25, 1000, gbText, gbBackground);
                                                ASCII.ScrollMessage("But not now.", 25, 1000, gbText, gbBackground);
                                                reloadOptions = false;
                                            }
                                        }
                                        //GIVE Feature
                                        if (optionsPosY == 21 && tabSelect == 1 ||
                                            optionsPosY == 21 && tabSelect == 2 ||
                                            optionsPosY == 22 && tabSelect == 3 ||
                                            optionsPosY == 22 && tabSelect == 4)
                                        {
                                            ASCII.ResetScreen(gbText, gbBackground);
                                            ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
                                            ASCII.BagMenuRight(gbText, gbBackground);
                                            disItemY = 4;
                                            //Displays a list of items in the selected tab
                                            foreach (Item item in currentTab)
                                            {
                                                if (item.Name != "empty" && disItemY < 19)
                                                {
                                                    Console.SetCursorPosition(disItemX, disItemY);
                                                    Console.Write(currentTab.ElementAt(disItemY - 4 + selectionMin).Name);
                                                    Console.SetCursorPosition(disItemX + 23, disItemY);
                                                    Console.Write($"x  {currentTab.ElementAt(disItemY - 4 + selectionMin).Amount}");
                                                    int selectionMax = selectionMin;
                                                    disItemY += 1;
                                                }
                                            }
                                            ASCII.InstantMessage("Testing Testing Give feature", gbText, gbBackground);
                                        }
                                        //TOSS Feature
                                        if (optionsPosY == 22 && tabSelect == 1 ||
                                            optionsPosY == 22 && tabSelect == 2)
                                        {
                                            bool reloadToss = true;
                                            int tossX = 63;
                                            int tossY = 22;
                                            int tossCount = 1;
                                            ASCII.ResetScreen(gbText, gbBackground);
                                            ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
                                            ASCII.BagMenuRight(gbText, gbBackground);
                                            disItemY = 4;
                                            //Displays a list of items in the selected tab
                                            foreach (Item item in currentTab)
                                            {
                                                if (item.Name != "empty" && disItemY < 19)
                                                {
                                                    Console.SetCursorPosition(disItemX, disItemY);
                                                    Console.Write(currentTab.ElementAt(disItemY - 4 + selectionMin).Name);
                                                    Console.SetCursorPosition(disItemX + 23, disItemY);
                                                    Console.Write($"x  {currentTab.ElementAt(disItemY - 4 + selectionMin).Amount}");
                                                    int selectionMax = selectionMin;
                                                    disItemY += 1;
                                                }
                                            }
                                            ASCII.InstantMessageMulti("Toss out how many", $"{itemSelected.Name}(s)?", gbText, gbBackground);
                                            ASCII.SmallMenu(60, 20, new string[] { "^", "", "v" }, gbText, gbBackground);
                                            do
                                            {
                                                Console.SetCursorPosition(tossX, tossY);
                                                Console.Write("x" + tossCount);
                                                navPlayerMenu = Console.ReadKey().Key;
                                                switch (navPlayerMenu)
                                                {
                                                    case ConsoleKey.UpArrow:
                                                    case ConsoleKey.W:
                                                        Console.SetCursorPosition(tossX, tossY);
                                                        Console.Write("     ");
                                                        tossCount += 1;
                                                        if (tossCount > itemSelected.Amount)
                                                        {
                                                            tossCount = 1;
                                                        }
                                                        break;
                                                    case ConsoleKey.DownArrow:
                                                    case ConsoleKey.S:
                                                        Console.SetCursorPosition(tossX, tossY);
                                                        Console.Write("     ");
                                                        tossCount -= 1;
                                                        if (tossCount < 1)
                                                        {
                                                            tossCount = itemSelected.Amount;
                                                        }
                                                        break;
                                                    case ConsoleKey.Enter:
                                                    case ConsoleKey.K:
                                                        int confirmTossX = 61;
                                                        int confirmTossY = 18;
                                                        bool reloadConfirmToss = true;
                                                        if (tossCount == 1)
                                                        {
                                                            ASCII.ScrollMessageMulti("Is it OK to throw away", $"{tossCount} {itemSelected.Name}?", 10, 0, gbText, gbBackground);
                                                        }
                                                        else
                                                        {
                                                            ASCII.ScrollMessageMulti("Is it OK to throw away", $"{tossCount} {itemSelected.Name}s?", 10, 0, gbText, gbBackground);
                                                        }
                                                        ASCII.SmallMenu(60, 17, new string[] { "YES", "NO" }, gbText, gbBackground);
                                                        do
                                                        {
                                                            Console.SetCursorPosition(confirmTossX, confirmTossY);
                                                            Console.Write(">");
                                                            navPlayerMenu = Console.ReadKey().Key;
                                                            switch (navPlayerMenu)
                                                            {
                                                                case ConsoleKey.UpArrow:
                                                                case ConsoleKey.W:
                                                                    Console.SetCursorPosition(confirmTossX, confirmTossY);
                                                                    Console.Write("  ");
                                                                    confirmTossY -= 1;
                                                                    if (confirmTossY == 17)
                                                                    {
                                                                        confirmTossY = 19;
                                                                    }
                                                                    break;
                                                                case ConsoleKey.DownArrow:
                                                                case ConsoleKey.S:
                                                                    Console.SetCursorPosition(confirmTossX, confirmTossY);
                                                                    Console.Write("  ");
                                                                    confirmTossY += 1;
                                                                    if (confirmTossY == 20)
                                                                    {
                                                                        confirmTossY = 18;
                                                                    }
                                                                    break;
                                                                case ConsoleKey.Enter:
                                                                case ConsoleKey.K:
                                                                    if (confirmTossY == 18)
                                                                    {
                                                                        int count = 0;
                                                                        while (count < player.Inventory.ItemSection.Length)
                                                                        {
                                                                            if (itemSelected.Name == player.Inventory.ItemSection[count].Name)
                                                                            {
                                                                                player.Inventory.ItemSection[count].Amount -= tossCount;
                                                                            }
                                                                            count += 1;
                                                                        }
                                                                        count = 0;
                                                                        while (count < player.Inventory.MedSection.Length)
                                                                        {
                                                                            if (itemSelected.Name == player.Inventory.MedSection[count].Name)
                                                                            {
                                                                                player.Inventory.MedSection[count].Amount -= tossCount;
                                                                            }
                                                                            count += 1;
                                                                        }
                                                                        count = 0;
                                                                        while (count < player.Inventory.MoveSection.Length)
                                                                        {
                                                                            if (itemSelected.Name == player.Inventory.MoveSection[count].Name)
                                                                            {
                                                                                player.Inventory.MoveSection[count].Amount -= tossCount;
                                                                            }
                                                                            count += 1;
                                                                        }
                                                                        count = 0;
                                                                        while (count < player.Inventory.BattleSection.Length)
                                                                        {
                                                                            if (itemSelected.Name == player.Inventory.BattleSection[count].Name)
                                                                            {
                                                                                player.Inventory.BattleSection[count].Amount -= tossCount;
                                                                            }
                                                                            count += 1;
                                                                        }
                                                                        ASCII.ResetScreen(gbText, gbBackground);
                                                                        ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
                                                                        ASCII.BagMenuRight(gbText, gbBackground);
                                                                        disItemY = 4;
                                                                        //Displays a list of items in the selected tab
                                                                        foreach (Item item in currentTab)
                                                                        {
                                                                            if (item.Name != "empty" && disItemY < 19)
                                                                            {
                                                                                Console.SetCursorPosition(disItemX, disItemY);
                                                                                Console.Write(currentTab.ElementAt(disItemY - 4 + selectionMin).Name);
                                                                                Console.SetCursorPosition(disItemX + 23, disItemY);
                                                                                Console.Write($"x  {currentTab.ElementAt(disItemY - 4 + selectionMin).Amount}");
                                                                                int selectionMax = selectionMin;
                                                                                disItemY += 1;
                                                                            }
                                                                        }
                                                                        if (tossCount == 1)
                                                                        {
                                                                            ASCII.ScrollMessage($"Threw away {tossCount} {itemSelected.Name}.", 25, 0, gbText, gbBackground);
                                                                        }
                                                                        else
                                                                        {
                                                                            ASCII.ScrollMessage($"Threw away {tossCount} {itemSelected.Name}s.", 25, 0, gbText, gbBackground);
                                                                        }
                                                                        navPlayerMenu = Console.ReadKey().Key;
                                                                    }
                                                                    //if (confirmTossY == 19)
                                                                    //{
                                                                    //    reloadConfirmToss = false;
                                                                    //    reloadToss = false;
                                                                    //    reloadOptions = false;
                                                                    //    reloadMenu = true;
                                                                    //}
                                                                    ASCII.ResetScreen(gbText, gbBackground);
                                                                    ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
                                                                    ASCII.BagMenuRight(gbText, gbBackground);
                                                                    disItemY = 4;
                                                                    //Displays a list of items in the selected tab
                                                                    foreach (Item item in currentTab)
                                                                    {
                                                                        if (item.Name != "empty" && disItemY < 19)
                                                                        {
                                                                            Console.SetCursorPosition(disItemX, disItemY);
                                                                            Console.Write(currentTab.ElementAt(disItemY - 4 + selectionMin).Name);
                                                                            Console.SetCursorPosition(disItemX + 23, disItemY);
                                                                            Console.Write($"x  {currentTab.ElementAt(disItemY - 4 + selectionMin).Amount}");
                                                                            int selectionMax = selectionMin;
                                                                            disItemY += 1;
                                                                        }
                                                                    }

                                                                    //Displays Item Description
                                                                    if (itemSelected.Description.Length <= 70 && currentTab.Count != 0)
                                                                    {
                                                                        ASCII.InstantMessage(itemSelected.Description, gbText, gbBackground);
                                                                    }
                                                                    else if (itemSelected.Description.Length > 70 && currentTab.Count != 0)
                                                                    {
                                                                        ASCII.InstantMessageMulti(itemSelected.Description.Substring(0, 70), itemSelected.Description.Substring(70), gbText, gbBackground);
                                                                    }
                                                                    else
                                                                    {
                                                                        ASCII.InstantMessage("empty", gbText, gbBackground);
                                                                    }
                                                                    reloadConfirmToss = false;
                                                                    reloadToss = false;
                                                                    reloadOptions = false;
                                                                    reloadMenu = true;
                                                                    break;
                                                                case ConsoleKey.Backspace:
                                                                case ConsoleKey.O:
                                                                    ASCII.ResetScreen(gbText, gbBackground);
                                                                    ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
                                                                    ASCII.BagMenuRight(gbText, gbBackground);
                                                                    disItemY = 4;
                                                                    //Displays a list of items in the selected tab
                                                                    foreach (Item item in currentTab)
                                                                    {
                                                                        if (item.Name != "empty" && disItemY < 19)
                                                                        {
                                                                            Console.SetCursorPosition(disItemX, disItemY);
                                                                            Console.Write(currentTab.ElementAt(disItemY - 4 + selectionMin).Name);
                                                                            Console.SetCursorPosition(disItemX + 23, disItemY);
                                                                            Console.Write($"x  {currentTab.ElementAt(disItemY - 4 + selectionMin).Amount}");
                                                                            int selectionMax = selectionMin;
                                                                            disItemY += 1;
                                                                        }
                                                                    }

                                                                    //Displays Item Description
                                                                    if (itemSelected.Description.Length <= 70 && currentTab.Count != 0)
                                                                    {
                                                                        ASCII.InstantMessage(itemSelected.Description, gbText, gbBackground);
                                                                    }
                                                                    else if (itemSelected.Description.Length > 70 && currentTab.Count != 0)
                                                                    {
                                                                        ASCII.InstantMessageMulti(itemSelected.Description.Substring(0, 70), itemSelected.Description.Substring(70), gbText, gbBackground);
                                                                    }
                                                                    else
                                                                    {
                                                                        ASCII.InstantMessage("empty", gbText, gbBackground);
                                                                    }
                                                                    reloadConfirmToss = false;
                                                                    reloadToss = false;
                                                                    reloadOptions = false;
                                                                    reloadMenu = true;
                                                                    break;
                                                                default:
                                                                    Console.SetCursorPosition(confirmTossX, confirmTossY);
                                                                    Console.Write("  ");
                                                                    break;
                                                            }
                                                        } while (reloadConfirmToss);
                                                        break;
                                                    case ConsoleKey.Backspace:
                                                    case ConsoleKey.O:
                                                        ASCII.ResetScreen(gbText, gbBackground);
                                                        ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
                                                        ASCII.BagMenuRight(gbText, gbBackground);
                                                        disItemY = 4;
                                                        //Displays a list of items in the selected tab
                                                        foreach (Item item in currentTab)
                                                        {
                                                            if (item.Name != "empty" && disItemY < 19)
                                                            {
                                                                Console.SetCursorPosition(disItemX, disItemY);
                                                                Console.Write(currentTab.ElementAt(disItemY - 4 + selectionMin).Name);
                                                                Console.SetCursorPosition(disItemX + 23, disItemY);
                                                                Console.Write($"x  {currentTab.ElementAt(disItemY - 4 + selectionMin).Amount}");
                                                                int selectionMax = selectionMin;
                                                                disItemY += 1;
                                                            }
                                                        }

                                                        //Displays Item Description
                                                        if (itemSelected.Description.Length <= 70 && currentTab.Count != 0)
                                                        {
                                                            ASCII.InstantMessage(itemSelected.Description, gbText, gbBackground);
                                                        }
                                                        else if (itemSelected.Description.Length > 70 && currentTab.Count != 0)
                                                        {
                                                            ASCII.InstantMessageMulti(itemSelected.Description.Substring(0, 70), itemSelected.Description.Substring(70), gbText, gbBackground);
                                                        }
                                                        else
                                                        {
                                                            ASCII.InstantMessage("empty", gbText, gbBackground);
                                                        }
                                                        reloadToss = false;
                                                        reloadOptions = false;
                                                        reloadMenu = true;
                                                        break;
                                                    default:
                                                        break;
                                                }
                                            } while (reloadToss);
                                        }
                                        //CANCEL Feature
                                        if (optionsPosY == 23 && tabSelect == 1 ||
                                            optionsPosY == 23 && tabSelect == 2 ||
                                            optionsPosY == 23 && tabSelect == 3 ||
                                            optionsPosY == 23 && tabSelect == 4)
                                        {
                                            ASCII.BagMenuRight(gbText, gbBackground);
                                            disItemY = 4;
                                            //Displays a list of items in the selected tab
                                            foreach (Item item in currentTab)
                                            {
                                                if (item.Name != "empty" && disItemY < 19)
                                                {
                                                    Console.SetCursorPosition(disItemX, disItemY);
                                                    Console.Write(currentTab.ElementAt(disItemY - 4 + selectionMin).Name);
                                                    Console.SetCursorPosition(disItemX + 23, disItemY);
                                                    Console.Write($"x  {currentTab.ElementAt(disItemY - 4 + selectionMin).Amount}");
                                                    int selectionMax = selectionMin;
                                                    disItemY += 1;
                                                }
                                            }
                                            reloadOptions = false;
                                        }
                                        break;
                                    case ConsoleKey.Backspace:
                                    case ConsoleKey.O:
                                        ASCII.BagMenuRight(gbText, gbBackground);
                                        disItemY = 4;
                                        //Displays a list of items in the selected tab
                                        foreach (Item item in currentTab)
                                        {
                                            if (item.Name != "empty" && disItemY < 19)
                                            {
                                                Console.SetCursorPosition(disItemX, disItemY);
                                                Console.Write(currentTab.ElementAt(disItemY - 4 + selectionMin).Name);
                                                Console.SetCursorPosition(disItemX + 23, disItemY);
                                                Console.Write($"x  {currentTab.ElementAt(disItemY - 4 + selectionMin).Amount}");
                                                int selectionMax = selectionMin;
                                                disItemY += 1;
                                            }
                                        }
                                        reloadOptions = false;
                                        break;
                                    default:
                                        Console.SetCursorPosition(optionsPosX, optionsPosY);
                                        Console.Write("  ");
                                        break;
                                }
                            } while (reloadOptions);
                        }
                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        reloadMenu = false;
                        break;
                    default:
                        break;
                }
            } while (reloadMenu);
        }

        public static void PlayerBagMenu(Player player, bool inCave, bool inWater, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadMenu = true;
            int posX = 4;
            int posY = 2;
            int selectPosX = 53;
            int selectPosY = 4;
            int disItemX = 55;
            int disItemY = 4;
            int tabSelect = 1;
            Item itemSelected = new Item();
            Item[] currentTab = player.Inventory.ItemSection;

            ASCII.ResetScreen(gbText, gbBackground);
            ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
            ASCII.BagMenuRight(gbText, gbBackground);
            do
            {
                if (tabSelect == 1)
                {
                    currentTab = player.Inventory.ItemSection;
                    if (player.Inventory.ItemSection.Length != 0)
                    {
                        itemSelected = player.Inventory.ItemSection[selectPosY - 4];
                    }
                }
                if (tabSelect == 2)
                {
                    currentTab = player.Inventory.MedSection;
                    if (player.Inventory.MedSection.Length != 0)
                    {
                        itemSelected = player.Inventory.MedSection[selectPosY - 4];
                    }
                }
                if (tabSelect == 3)
                {
                    currentTab = player.Inventory.MoveSection;
                    if (player.Inventory.MoveSection.Length != 0)
                    {
                        itemSelected = player.Inventory.MoveSection[selectPosY - 4];
                    }
                }
                if (tabSelect == 4)
                {
                    currentTab = player.Inventory.BattleSection;
                    if (player.Inventory.BattleSection.Length != 0)
                    {
                        itemSelected = player.Inventory.BattleSection[selectPosY - 4];
                    }
                }
                disItemY = 4;

                //Displays a list of items in the selected tab
                foreach (Item item in currentTab)
                {
                    Console.SetCursorPosition(disItemX, disItemY);
                    Console.Write(item.Name);
                    Console.SetCursorPosition(disItemX + 23, disItemY);
                    Console.Write($"x  {item.Amount}");
                    disItemY += 1;
                }

                //Displays Item Description
                if (itemSelected.Description.Length <= 70 && currentTab.Length != 0)
                {
                    ASCII.InstantMessage(itemSelected.Description, gbText, gbBackground);
                }
                else if (itemSelected.Description.Length > 70 && currentTab.Length != 0)
                {
                    ASCII.InstantMessageMulti(itemSelected.Description.Substring(0, 70), itemSelected.Description.Substring(70), gbText, gbBackground);
                }
                else
                {
                    ASCII.InstantMessage("empty", gbText, gbBackground);
                }

                Console.SetCursorPosition(selectPosX, selectPosY);
                Console.Write(">");
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Console.SetCursorPosition(selectPosX, selectPosY);
                        Console.Write("  ");
                        selectPosY -= 1;
                        if (selectPosY < 4)
                        {
                            selectPosY = 4;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Console.SetCursorPosition(selectPosX, selectPosY);
                        Console.Write("  ");
                        selectPosY += 1;
                        if (tabSelect == 1 && selectPosY - 3 > player.Inventory.ItemSection.Length ||
                            tabSelect == 2 && selectPosY - 3 > player.Inventory.MedSection.Length ||
                            tabSelect == 3 && selectPosY - 3 > player.Inventory.MoveSection.Length ||
                            tabSelect == 4 && selectPosY - 3 > player.Inventory.BattleSection.Length)
                        {
                            selectPosY -= 1;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        int preTab = tabSelect;
                        Console.SetCursorPosition(selectPosX, selectPosY);
                        Console.Write("  ");
                        tabSelect -= 1;
                        if (tabSelect < 1)
                        {
                            tabSelect = 1;
                        }
                        if (tabSelect != preTab)
                        {
                            selectPosY = 4;
                            ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
                            ASCII.BagMenuRight(gbText, gbBackground);
                        }
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        preTab = tabSelect;
                        Console.SetCursorPosition(selectPosX, selectPosY);
                        Console.Write("  ");
                        tabSelect += 1;
                        if (tabSelect > 4)
                        {
                            tabSelect = 4;
                        }
                        if (tabSelect != preTab)
                        {
                            selectPosY = 4;
                            ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
                            ASCII.BagMenuRight(gbText, gbBackground);
                        }
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.K:
                        bool reloadOptions = true;
                        int optionsPosX = 61;
                        int optionsPosY = 20;
                        string[] optionsList1 = new string[]
                        {
                            "USE",
                            "GIVE",
                            "TOSS",
                            "CANCEL"
                        };
                        string[] optionsList2 = new string[]
                        {
                            "USE",
                            "GIVE",
                            "CANCEL"
                        };
                        string[] optionsList = optionsList1;
                        if (true/*currentTab.Length != 0*/)
                        {
                            ASCII.InstantMessage($"{itemSelected.Name} is selected.", gbText, gbBackground);
                            optionsList = optionsList1;
                            optionsPosY = 20;
                            ASCII.SmallMenu(60, 19, optionsList, gbText, gbBackground);
                            //if (tabSelect == 1 || tabSelect == 2)
                            //{
                            //    optionsList = optionsList1;
                            //    optionsPosY = 20;
                            //    ASCII.SmallMenu(60, 19, optionsList, gbText, gbBackground);
                            //}
                            //if (tabSelect == 3 || tabSelect == 4)
                            //{
                            //    optionsList = optionsList2;
                            //    optionsPosY = 21;
                            //    ASCII.SmallMenu(60, 20, optionsList, gbText, gbBackground);
                            //}

                            do
                            {
                                Console.SetCursorPosition(optionsPosX, optionsPosY);
                                Console.Write(">");
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.UpArrow:
                                    case ConsoleKey.W:
                                        Console.SetCursorPosition(optionsPosX, optionsPosY);
                                        Console.Write("  ");
                                        optionsPosY -= 1;
                                        //if (optionsPosY < 20 && tabSelect == 1 ||
                                        //    optionsPosY < 20 && tabSelect == 2 ||
                                        //    optionsPosY < 21 && tabSelect == 3 ||
                                        //    optionsPosY < 21 && tabSelect == 4)
                                        //{
                                        //    optionsPosY = 23;
                                        //}
                                        if (optionsPosY < 20)
                                        {
                                            optionsPosY = 23;
                                        }
                                        break;
                                    case ConsoleKey.DownArrow:
                                    case ConsoleKey.S:
                                        Console.SetCursorPosition(optionsPosX, optionsPosY);
                                        Console.Write("  ");
                                        optionsPosY += 1;
                                        if (optionsPosY > 23)
                                        {
                                            if (tabSelect == 1 || tabSelect == 2)
                                            {
                                                optionsPosY = 20;
                                            }
                                            if (tabSelect == 3 || tabSelect == 4)
                                            {
                                                optionsPosY = 21;
                                            }
                                        }
                                        break;
                                    case ConsoleKey.Enter:
                                    case ConsoleKey.K:
                                        //USE Feature
                                        if (optionsPosY == 20 && tabSelect == 1 ||
                                            optionsPosY == 20 && tabSelect == 2 ||
                                            optionsPosY == 21 && tabSelect == 3 ||
                                            optionsPosY == 21 && tabSelect == 4)
                                        {
                                            ASCII.ResetScreen(gbText, gbBackground);
                                            ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
                                            ASCII.BagMenuRight(gbText, gbBackground);
                                            disItemY = 4;
                                            //Displays a list of items in the selected tab
                                            foreach (Item item in currentTab)
                                            {
                                                Console.SetCursorPosition(disItemX, disItemY);
                                                Console.Write(item.Name);
                                                Console.SetCursorPosition(disItemX + 23, disItemY);
                                                Console.Write($"x  {item.Amount}");
                                                disItemY += 1;
                                            }
                                            if (itemSelected.Section == Type.Item)
                                            {

                                            }
                                            if (itemSelected.Section == Type.Med)
                                            {

                                            }
                                            if (itemSelected.Section == Type.Move)
                                            {

                                            }
                                            if (itemSelected.Section == Type.Battle)
                                            {

                                            }
                                            if (inCave == true || inWater == true)
                                            {

                                            }
                                            else
                                            {
                                                ASCII.BagMenuRight(gbText, gbBackground);
                                                disItemY = 4;

                                                //Displays a list of items in the selected tab
                                                foreach (Item item in currentTab)
                                                {
                                                    Console.SetCursorPosition(disItemX, disItemY);
                                                    Console.Write(item.Name);
                                                    Console.SetCursorPosition(disItemX + 23, disItemY);
                                                    Console.Write($"x  {item.Amount}");
                                                    disItemY += 1;
                                                }
                                                ASCII.ScrollMessageMulti("Salix's words echoed...", $"{player.Name.ToUpper()}! There's a time and place for everything!", 25, 1000, gbText, gbBackground);
                                                ASCII.ScrollMessage("But not now.", 25, 1000, gbText, gbBackground);
                                                reloadOptions = false;
                                            }
                                        }
                                        //GIVE Feature
                                        if (optionsPosY == 21 && tabSelect == 1 ||
                                            optionsPosY == 21 && tabSelect == 2 ||
                                            optionsPosY == 22 && tabSelect == 3 ||
                                            optionsPosY == 22 && tabSelect == 4)
                                        {
                                            ASCII.ResetScreen(gbText, gbBackground);
                                            ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
                                            ASCII.BagMenuRight(gbText, gbBackground);
                                            disItemY = 4;
                                            //Displays a list of items in the selected tab
                                            foreach (Item item in currentTab)
                                            {
                                                Console.SetCursorPosition(disItemX, disItemY);
                                                Console.Write(item.Name);
                                                Console.SetCursorPosition(disItemX + 23, disItemY);
                                                Console.Write($"x  {item.Amount}");
                                                disItemY += 1;
                                            }
                                            ASCII.InstantMessage("Testing Testing Give feature", gbText, gbBackground);
                                        }
                                        //TOSS Feature
                                        if (optionsPosY == 22 && tabSelect == 1 ||
                                            optionsPosY == 22 && tabSelect == 2)
                                        {
                                            bool reloadToss = true;
                                            int tossX = 63;
                                            int tossY = 22;
                                            int tossCount = 1;
                                            ASCII.ResetScreen(gbText, gbBackground);
                                            ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
                                            ASCII.BagMenuRight(gbText, gbBackground);
                                            disItemY = 4;
                                            //Displays a list of items in the selected tab
                                            foreach (Item item in currentTab)
                                            {
                                                Console.SetCursorPosition(disItemX, disItemY);
                                                Console.Write(item.Name);
                                                Console.SetCursorPosition(disItemX + 23, disItemY);
                                                Console.Write($"x  {item.Amount}");
                                                disItemY += 1;
                                            }
                                            ASCII.InstantMessageMulti("Toss out how many", $"{itemSelected.Name}(s)?", gbText, gbBackground);
                                            ASCII.SmallMenu(60, 20, new string[] { "^", "", "v" }, gbText, gbBackground);
                                            do
                                            {
                                                Console.SetCursorPosition(tossX, tossY);
                                                Console.Write("x" + tossCount);
                                                navPlayerMenu = Console.ReadKey().Key;
                                                switch (navPlayerMenu)
                                                {
                                                    case ConsoleKey.UpArrow:
                                                    case ConsoleKey.W:
                                                        Console.SetCursorPosition(tossX, tossY);
                                                        Console.Write("     ");
                                                        tossCount += 1;
                                                        if (tossCount > itemSelected.Amount)
                                                        {
                                                            tossCount = 1;
                                                        }
                                                        break;
                                                    case ConsoleKey.DownArrow:
                                                    case ConsoleKey.S:
                                                        Console.SetCursorPosition(tossX, tossY);
                                                        Console.Write("     ");
                                                        tossCount -= 1;
                                                        if (tossCount < 1)
                                                        {
                                                            tossCount = itemSelected.Amount;
                                                        }
                                                        break;
                                                    case ConsoleKey.Enter:
                                                    case ConsoleKey.K:
                                                        int confirmTossX = 61;
                                                        int confirmTossY = 18;
                                                        bool reloadConfirmToss = true;
                                                        if (tossCount == 1)
                                                        {
                                                            ASCII.ScrollMessageMulti("Is it OK to throw away", $"{tossCount} {itemSelected.Name}?", 10, 0, gbText, gbBackground);
                                                        }
                                                        else
                                                        {
                                                            ASCII.ScrollMessageMulti("Is it OK to throw away", $"{tossCount} {itemSelected.Name}s?", 10, 0, gbText, gbBackground);
                                                        }
                                                        ASCII.SmallMenu(60, 17, new string[] { "YES", "NO" }, gbText, gbBackground);
                                                        do
                                                        {
                                                            Console.SetCursorPosition(confirmTossX, confirmTossY);
                                                            Console.Write(">");
                                                            navPlayerMenu = Console.ReadKey().Key;
                                                            switch (navPlayerMenu)
                                                            {
                                                                case ConsoleKey.UpArrow:
                                                                case ConsoleKey.W:
                                                                    Console.SetCursorPosition(confirmTossX, confirmTossY);
                                                                    Console.Write("  ");
                                                                    confirmTossY -= 1;
                                                                    if (confirmTossY == 17)
                                                                    {
                                                                        confirmTossY = 19;
                                                                    }
                                                                    break;
                                                                case ConsoleKey.DownArrow:
                                                                case ConsoleKey.S:
                                                                    Console.SetCursorPosition(confirmTossX, confirmTossY);
                                                                    Console.Write("  ");
                                                                    confirmTossY += 1;
                                                                    if (confirmTossY == 20)
                                                                    {
                                                                        confirmTossY = 18;
                                                                    }
                                                                    break;
                                                                case ConsoleKey.Enter:
                                                                case ConsoleKey.K:
                                                                    if (confirmTossY == 18)
                                                                    {
                                                                        int count = 0;
                                                                        while (count < player.Inventory.ItemSection.Length)
                                                                        {
                                                                            if (itemSelected.Name == player.Inventory.ItemSection[count].Name)
                                                                            {
                                                                                player.Inventory.ItemSection[count].Amount -= tossCount;
                                                                            }
                                                                            count += 1;
                                                                        }
                                                                        count = 0;
                                                                        while (count < player.Inventory.MedSection.Length)
                                                                        {
                                                                            if (itemSelected.Name == player.Inventory.MedSection[count].Name)
                                                                            {
                                                                                player.Inventory.MedSection[count].Amount -= tossCount;
                                                                            }
                                                                            count += 1;
                                                                        }
                                                                        count = 0;
                                                                        while (count < player.Inventory.MoveSection.Length)
                                                                        {
                                                                            if (itemSelected.Name == player.Inventory.MoveSection[count].Name)
                                                                            {
                                                                                player.Inventory.MoveSection[count].Amount -= tossCount;
                                                                            }
                                                                            count += 1;
                                                                        }
                                                                        count = 0;
                                                                        while (count < player.Inventory.BattleSection.Length)
                                                                        {
                                                                            if (itemSelected.Name == player.Inventory.BattleSection[count].Name)
                                                                            {
                                                                                player.Inventory.BattleSection[count].Amount -= tossCount;
                                                                            }
                                                                            count += 1;
                                                                        }
                                                                        ASCII.ResetScreen(gbText, gbBackground);
                                                                        ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
                                                                        ASCII.BagMenuRight(gbText, gbBackground);
                                                                        disItemY = 4;
                                                                        //Displays a list of items in the selected tab
                                                                        foreach (Item item in currentTab)
                                                                        {
                                                                            Console.SetCursorPosition(disItemX, disItemY);
                                                                            Console.Write(item.Name);
                                                                            Console.SetCursorPosition(disItemX + 23, disItemY);
                                                                            Console.Write($"x  {item.Amount}");
                                                                            disItemY += 1;
                                                                        }
                                                                        if (tossCount == 1)
                                                                        {
                                                                            ASCII.ScrollMessage($"Threw away {tossCount} {itemSelected.Name}.", 25, 0, gbText, gbBackground);
                                                                        }
                                                                        else
                                                                        {
                                                                            ASCII.ScrollMessage($"Threw away {tossCount} {itemSelected.Name}s.", 25, 0, gbText, gbBackground);
                                                                        }
                                                                        navPlayerMenu = Console.ReadKey().Key;
                                                                    }
                                                                    //if (confirmTossY == 19)
                                                                    //{
                                                                    //    reloadConfirmToss = false;
                                                                    //    reloadToss = false;
                                                                    //    reloadOptions = false;
                                                                    //    reloadMenu = true;
                                                                    //}
                                                                    ASCII.ResetScreen(gbText, gbBackground);
                                                                    ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
                                                                    ASCII.BagMenuRight(gbText, gbBackground);
                                                                    disItemY = 4;
                                                                    //Displays a list of items in the selected tab
                                                                    foreach (Item item in currentTab)
                                                                    {
                                                                        Console.SetCursorPosition(disItemX, disItemY);
                                                                        Console.Write(item.Name);
                                                                        Console.SetCursorPosition(disItemX + 23, disItemY);
                                                                        Console.Write($"x  {item.Amount}");
                                                                        disItemY += 1;
                                                                    }

                                                                    //Displays Item Description
                                                                    if (itemSelected.Description.Length <= 70 && currentTab.Length != 0)
                                                                    {
                                                                        ASCII.InstantMessage(itemSelected.Description, gbText, gbBackground);
                                                                    }
                                                                    else if (itemSelected.Description.Length > 70 && currentTab.Length != 0)
                                                                    {
                                                                        ASCII.InstantMessageMulti(itemSelected.Description.Substring(0, 70), itemSelected.Description.Substring(70), gbText, gbBackground);
                                                                    }
                                                                    else
                                                                    {
                                                                        ASCII.InstantMessage("empty", gbText, gbBackground);
                                                                    }
                                                                    reloadConfirmToss = false;
                                                                    reloadToss = false;
                                                                    reloadOptions = false;
                                                                    reloadMenu = true;
                                                                    break;
                                                                case ConsoleKey.Backspace:
                                                                case ConsoleKey.O:
                                                                    ASCII.ResetScreen(gbText, gbBackground);
                                                                    ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
                                                                    ASCII.BagMenuRight(gbText, gbBackground);
                                                                    disItemY = 4;
                                                                    //Displays a list of items in the selected tab
                                                                    foreach (Item item in currentTab)
                                                                    {
                                                                        Console.SetCursorPosition(disItemX, disItemY);
                                                                        Console.Write(item.Name);
                                                                        Console.SetCursorPosition(disItemX + 23, disItemY);
                                                                        Console.Write($"x  {item.Amount}");
                                                                        disItemY += 1;
                                                                    }

                                                                    //Displays Item Description
                                                                    if (itemSelected.Description.Length <= 70 && currentTab.Length != 0)
                                                                    {
                                                                        ASCII.InstantMessage(itemSelected.Description, gbText, gbBackground);
                                                                    }
                                                                    else if (itemSelected.Description.Length > 70 && currentTab.Length != 0)
                                                                    {
                                                                        ASCII.InstantMessageMulti(itemSelected.Description.Substring(0, 70), itemSelected.Description.Substring(70), gbText, gbBackground);
                                                                    }
                                                                    else
                                                                    {
                                                                        ASCII.InstantMessage("empty", gbText, gbBackground);
                                                                    }
                                                                    reloadConfirmToss = false;
                                                                    reloadToss = false;
                                                                    reloadOptions = false;
                                                                    reloadMenu = true;
                                                                    break;
                                                                default:
                                                                    Console.SetCursorPosition(confirmTossX, confirmTossY);
                                                                    Console.Write("  ");
                                                                    break;
                                                            }
                                                        } while (reloadConfirmToss);
                                                        break;
                                                    case ConsoleKey.Backspace:
                                                    case ConsoleKey.O:
                                                        ASCII.ResetScreen(gbText, gbBackground);
                                                        ASCII.BagMenuSelect(tabSelect, gbText, gbBackground);
                                                        ASCII.BagMenuRight(gbText, gbBackground);
                                                        disItemY = 4;
                                                        //Displays a list of items in the selected tab
                                                        foreach (Item item in currentTab)
                                                        {
                                                            Console.SetCursorPosition(disItemX, disItemY);
                                                            Console.Write(item.Name);
                                                            Console.SetCursorPosition(disItemX + 23, disItemY);
                                                            Console.Write($"x  {item.Amount}");
                                                            disItemY += 1;
                                                        }

                                                        //Displays Item Description
                                                        if (itemSelected.Description.Length <= 70 && currentTab.Length != 0)
                                                        {
                                                            ASCII.InstantMessage(itemSelected.Description, gbText, gbBackground);
                                                        }
                                                        else if (itemSelected.Description.Length > 70 && currentTab.Length != 0)
                                                        {
                                                            ASCII.InstantMessageMulti(itemSelected.Description.Substring(0, 70), itemSelected.Description.Substring(70), gbText, gbBackground);
                                                        }
                                                        else
                                                        {
                                                            ASCII.InstantMessage("empty", gbText, gbBackground);
                                                        }
                                                        reloadToss = false;
                                                        reloadOptions = false;
                                                        reloadMenu = true;
                                                        break;
                                                    default:
                                                        break;
                                                }
                                            } while (reloadToss);
                                        }
                                        //CANCEL Feature
                                        if (optionsPosY == 23 && tabSelect == 1 ||
                                            optionsPosY == 23 && tabSelect == 2 ||
                                            optionsPosY == 23 && tabSelect == 3 ||
                                            optionsPosY == 23 && tabSelect == 4)
                                        {
                                            ASCII.BagMenuRight(gbText, gbBackground);
                                            disItemY = 4;
                                            //Displays a list of items in the selected tab
                                            foreach (Item item in currentTab)
                                            {
                                                Console.SetCursorPosition(disItemX, disItemY);
                                                Console.Write(item.Name);
                                                Console.SetCursorPosition(disItemX + 23, disItemY);
                                                Console.Write($"x  {item.Amount}");
                                                disItemY += 1;
                                            }
                                            reloadOptions = false;
                                        }
                                        break;
                                    case ConsoleKey.Backspace:
                                    case ConsoleKey.O:
                                        ASCII.BagMenuRight(gbText, gbBackground);
                                        disItemY = 4;
                                        //Displays a list of items in the selected tab
                                        foreach (Item item in currentTab)
                                        {
                                            Console.SetCursorPosition(disItemX, disItemY);
                                            Console.Write(item.Name);
                                            Console.SetCursorPosition(disItemX + 23, disItemY);
                                            Console.Write($"x  {item.Amount}");
                                            disItemY += 1;
                                        }
                                        reloadOptions = false;
                                        break;
                                    default:
                                        Console.SetCursorPosition(optionsPosX, optionsPosY);
                                        Console.Write("  ");
                                        break;
                                }
                            } while (reloadOptions);
                        }
                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        reloadMenu = false;
                        break;
                    default:
                        Console.SetCursorPosition(selectPosX, selectPosY);
                        Console.Write("  ");
                        break;
                }
            } while (reloadMenu);
        }

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

        public static void PlayerProfile(Player player, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            /* int totalDiscovered = 0;
             * foreach (Monster monster in player.Pokedex)
             * {
             *      if(monster.isDiscovered == true)
             *      {
             *          totalDiscovered += 1;
             *      }
             *      Console.SetCursorPosition(0,0);
             * }
             * 
             */
            int posY = 2;
            if (player.Gender == '♂')
            {
                foreach (string line in ASCII.playerProfileMale)
                {
                    Console.SetCursorPosition(4, posY);
                    Console.Write(line);
                    posY += 1;
                }
            }
            if (player.Gender == '♀')
            {
                foreach (string line in ASCII.playerProfileFemale)
                {
                    Console.SetCursorPosition(4, posY);
                    Console.Write(line);
                    posY += 1;
                }
            }
            Console.SetCursorPosition(35, 7);
            Console.Write(player.PlayerID);
            Console.SetCursorPosition(35, 9);
            Console.Write(player.Name.ToUpper());
            Console.SetCursorPosition(35, 11);
            Console.Write($"${player.Money}");
            Console.SetCursorPosition(35, 13);
            Console.Write($"# OF DISCOVERED");
            Console.SetCursorPosition(35, 15);
            Console.Write(ASCII.elapsedTime);
            Console.SetCursorPosition(35, 17);
            Console.Write(player.StartTime);
            Console.SetCursorPosition(90, 42);
        }

        #endregion

        #endregion

        #region PC Menu

        public static void PC(Player player, Monster monster, int monster1, bool isMove, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadPokedex = true;
            int pcX = 4;
            int pcY = 2;
            int navX = 42;
            int navY = 8;
            int entryX = 42;
            int entryY = 8;
            int pcSelect = 0;
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            do
            {
                #region Hover Selection
                if (navX == 42)
                {
                    if (navY == 8)
                    {
                        pcSelect = 0;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 11)
                    {
                        pcSelect = 5;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 14)
                    {
                        pcSelect = 10;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 17)
                    {
                        pcSelect = 15;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 20)
                    {
                        pcSelect = 20;
                        monster = player.PC[pcSelect];
                    }
                }
                if (navX == 50)
                {
                    if (navY == 8)
                    {
                        pcSelect = 1;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 11)
                    {
                        pcSelect = 6;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 14)
                    {
                        pcSelect = 11;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 17)
                    {
                        pcSelect = 16;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 20)
                    {
                        pcSelect = 21;
                        monster = player.PC[pcSelect];
                    }
                }
                if (navX == 58)
                {
                    if (navY == 8)
                    {
                        pcSelect = 2;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 11)
                    {
                        pcSelect = 7;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 14)
                    {
                        pcSelect = 12;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 17)
                    {
                        pcSelect = 17;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 20)
                    {
                        pcSelect = 22;
                        monster = player.PC[pcSelect];
                    }
                }
                if (navX == 66)
                {
                    if (navY == 8)
                    {
                        pcSelect = 3;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 11)
                    {
                        pcSelect = 8;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 14)
                    {
                        pcSelect = 13;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 17)
                    {
                        pcSelect = 18;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 20)
                    {
                        pcSelect = 23;
                        monster = player.PC[pcSelect];
                    }
                }
                if (navX == 74)
                {
                    if (navY == 8)
                    {
                        pcSelect = 4;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 11)
                    {
                        pcSelect = 9;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 14)
                    {
                        pcSelect = 14;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 17)
                    {
                        pcSelect = 19;
                        monster = player.PC[pcSelect];
                    }
                    if (navY == 20)
                    {
                        pcSelect = 24;
                        monster = player.PC[pcSelect];
                    }
                }
                #endregion

                #region Display Empty PC
                pcY = 2;
                foreach (string line in ASCII.emptyPC)
                {
                    Console.SetCursorPosition(pcX, pcY);
                    Console.Write(line);
                    pcY += 1;
                }
                #endregion

                #region Display Monster Entries
                entryX = 42;
                entryY = 8;
                foreach (Monster entry in player.PC)
                {
                    Console.SetCursorPosition(entryX, entryY);
                    if (entry.Type != Monster_Race.NONE)
                    {
                        Console.Write(" (o) ");
                    }
                    else
                    {
                        Console.Write("     ");
                    }
                    entryX += 8;
                    if (entryX == 82)
                    {
                        entryX = 42;
                        entryY += 3;
                    }
                }
                #endregion

                #region Display Monster Info Hover
                if (monster.Type != Monster_Race.NONE)
                {
                    pcY = 9;
                    foreach (string line in monster.ASCIIPokedex)
                    {
                        Console.SetCursorPosition(12, pcY);
                        Console.Write(line);
                        pcY += 1;
                    }
                    Console.SetCursorPosition(9, 4);
                    Console.Write(monster.Name.ToUpper());
                    Console.SetCursorPosition(26, 5);
                    Console.Write($"No.{monster.PokeIndex}");
                    ASCII.NameANDGender(monster, 9, 19, gbText, gbBackground);
                    ASCII.Level(monster, 9, 20, gbText, gbBackground);
                    ASCII.Type(monster.Type, 15, 23, gbText, gbBackground);
                    Console.SetCursorPosition(navX, navY);
                    Console.Write("( o )");
                }
                else
                {
                    Console.SetCursorPosition(navX, navY);
                    Console.Write("(   )");
                }
                #endregion

                #region PC Navigation
                Console.SetCursorPosition(90, 42);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        //Console.SetCursorPosition(navX, navY);
                        //Console.Write(" (o) ");
                        navY -= 3;
                        if (navY == 5)
                        {
                            navY += 3;
                        }
                        //reloadPokedex = true;
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        //Console.SetCursorPosition(navX, navY);
                        //Console.Write(" (o) ");
                        navY += 3;
                        if (navY == 23)
                        {
                            navY -= 3;
                        }
                        //reloadPokedex = true;
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        //Console.SetCursorPosition(navX, navY);
                        //Console.Write(" (o) ");
                        navX -= 8;
                        if (navX == 34)
                        {
                            navX += 8;
                        }
                        //reloadPokedex = true;
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        //Console.SetCursorPosition(navX, navY);
                        //Console.Write(" (o) ");
                        navX += 8;
                        if (navX == 82)
                        {
                            navX -= 8;
                        }
                        //reloadPokedex = true;
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.K:
                        if (player.PC[pcSelect].Type != Monster_Race.NONE && isMove == false)
                        {
                            PCInner(player, pcSelect, navPlayerMenu, gbText, gbBackground);
                            reloadPokedex = false;
                        }
                        else if (player.PC[pcSelect].Type != Monster_Race.NONE && isMove == true)
                        {
                            PCSwitch(player, monster1, pcSelect, navPlayerMenu, gbText, gbBackground);
                            reloadPokedex = false;
                        }
                        else
                        {
                            reloadPokedex = true;
                        }
                        //reloadPokedex = true;
                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        reloadPokedex = false;
                        break;
                    default:
                        reloadPokedex = false;
                        break;
                }
                #endregion

            } while (reloadPokedex);
        }

        public static void PlayerPC(Player player, Monster monster, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadPokedex = false;
            int posY = 2;
            int navX = 42;
            int navY = 8;
            int pcSelect = 0;
            Console.ForegroundColor = gbText;
            Console.BackgroundColor = gbBackground;
            do
            {
                if (navX == 42)
                {
                    if (navY == 8)
                    {
                        monster = player.PC[0];
                        pcSelect = 0;
                    }
                    if (navY == 11)
                    {
                        monster = player.PC[5];
                        pcSelect = 5;
                    }
                    if (navY == 14)
                    {
                        monster = player.PC[10];
                        pcSelect = 10;
                    }
                    if (navY == 17)
                    {
                        monster = player.PC[15];
                        pcSelect = 15;
                    }
                    if (navY == 20)
                    {
                        monster = player.PC[20];
                        pcSelect = 20;
                    }
                }
                if (navX == 50)
                {
                    if (navY == 8)
                    {
                        monster = player.PC[1];
                        pcSelect = 1;
                    }
                    if (navY == 11)
                    {
                        monster = player.PC[6];
                        pcSelect = 6;
                    }
                    if (navY == 14)
                    {
                        monster = player.PC[11];
                        pcSelect = 11;
                    }
                    if (navY == 17)
                    {
                        monster = player.PC[16];
                        pcSelect = 16;
                    }
                    if (navY == 20)
                    {
                        monster = player.PC[21];
                        pcSelect = 21;
                    }
                }
                if (navX == 58)
                {
                    if (navY == 8)
                    {
                        monster = player.PC[2];
                        pcSelect = 2;
                    }
                    if (navY == 11)
                    {
                        monster = player.PC[7];
                        pcSelect = 7;
                    }
                    if (navY == 14)
                    {
                        monster = player.PC[12];
                        pcSelect = 12;
                    }
                    if (navY == 17)
                    {
                        monster = player.PC[17];
                        pcSelect = 17;
                    }
                    if (navY == 20)
                    {
                        monster = player.PC[22];
                        pcSelect = 22;
                    }
                }
                if (navX == 66)
                {
                    if (navY == 8)
                    {
                        monster = player.PC[3];
                        pcSelect = 3;
                    }
                    if (navY == 11)
                    {
                        monster = player.PC[8];
                        pcSelect = 8;
                    }
                    if (navY == 14)
                    {
                        monster = player.PC[13];
                        pcSelect = 13;
                    }
                    if (navY == 17)
                    {
                        monster = player.PC[18];
                        pcSelect = 18;
                    }
                    if (navY == 20)
                    {
                        monster = player.PC[23];
                        pcSelect = 23;
                    }
                }
                if (navX == 74)
                {
                    if (navY == 8)
                    {
                        monster = player.PC[4];
                        pcSelect = 4;
                    }
                    if (navY == 11)
                    {
                        monster = player.PC[9];
                        pcSelect = 9;
                    }
                    if (navY == 14)
                    {
                        monster = player.PC[14];
                        pcSelect = 14;
                    }
                    if (navY == 17)
                    {
                        monster = player.PC[19];
                        pcSelect = 19;
                    }
                    if (navY == 20)
                    {
                        monster = player.PC[24];
                        pcSelect = 24;
                    }
                }

                posY = 2;
                foreach (string line in ASCII.emptyPC)
                {
                    Console.SetCursorPosition(4, posY);
                    Console.Write(line);
                    posY += 1;
                }
                int entryX = 42;
                int entryY = 8;
                foreach (Monster entry in player.PC)
                {
                    Console.SetCursorPosition(entryX, entryY);
                    if (entry.Type != Monster_Race.NONE)
                    {
                        Console.Write(" (o) ");
                    }
                    else
                    {
                        Console.Write("     ");
                    }
                    entryX += 8;
                    if (entryX == 82)
                    {
                        entryX = 42;
                        entryY += 3;
                    }
                }
                if (monster.Type != Monster_Race.NONE)
                {
                    posY = 9;
                    foreach (string line in monster.ASCIIPokedex)
                    {
                        Console.SetCursorPosition(12, posY);
                        Console.Write(line);
                        posY += 1;
                    }
                    Console.SetCursorPosition(9, 4);
                    Console.Write(monster.Name.ToUpper());
                    Console.SetCursorPosition(26, 5);
                    Console.Write($"No.{monster.PokeIndex}");
                    ASCII.NameANDGender(monster, 9, 19, gbText, gbBackground);
                    ASCII.Level(monster, 9, 20, gbText, gbBackground);
                    ASCII.Type(monster.Type, 15, 23, gbText, gbBackground);
                    Console.SetCursorPosition(navX, navY);
                    Console.Write("( o )");
                }
                else
                {
                    Console.SetCursorPosition(navX, navY);
                    Console.Write("(   )");
                }
                Console.SetCursorPosition(90, 42);
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        //Console.SetCursorPosition(navX, navY);
                        //Console.Write(" (o) ");
                        navY -= 3;
                        if (navY == 5)
                        {
                            navY += 3;
                        }
                        reloadPokedex = true;
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        //Console.SetCursorPosition(navX, navY);
                        //Console.Write(" (o) ");
                        navY += 3;
                        if (navY == 23)
                        {
                            navY -= 3;
                        }
                        reloadPokedex = true;
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        //Console.SetCursorPosition(navX, navY);
                        //Console.Write(" (o) ");
                        navX -= 8;
                        if (navX == 34)
                        {
                            navX += 8;
                        }
                        reloadPokedex = true;
                        break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        //Console.SetCursorPosition(navX, navY);
                        //Console.Write(" (o) ");
                        navX += 8;
                        if (navX == 82)
                        {
                            navX -= 8;
                        }
                        reloadPokedex = true;
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.K:

                        reloadPokedex = true;
                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        reloadPokedex = false;
                        break;
                    default:
                        reloadPokedex = false;
                        break;
                }
            } while (reloadPokedex);
        }

        public static void PCInner(Player player, int monster1, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadPopUp = true;
            int popUpX = 63;
            int popUpY = 12;
            int navX = 64;
            int navY = 13;

            do
            {
                /* MOVE
                 * SUMMARY
                 * ITEM
                 * WITHDRAW
                 * RELEASE
                 * CANCEL
                 */
                #region PopUp Display
                popUpY = 12;
                foreach (string line in ASCII.pcInner)
                {
                    Console.SetCursorPosition(popUpX, popUpY);
                    Console.Write(line);
                    popUpY += 1;
                }
                Console.SetCursorPosition(navX, navY);
                Console.Write(">");
                #endregion

                ASCII.InstantMessage($"{player.PC[monster1].Name.ToUpper()} is selected.", gbText, gbBackground);

                #region Menu
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Console.SetCursorPosition(navX, navY);
                        Console.Write(" ");
                        navY -= 1;
                        if (navY == 12)
                        {
                            navY = 18;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Console.SetCursorPosition(navX, navY);
                        Console.Write(" ");
                        navY += 1;
                        if (navY == 19)
                        {
                            navY = 13;
                        }
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.K:
                        //Move
                        if (navY == 13)
                        {
                            PC(player, new Monster(), monster1, true, navPlayerMenu, gbText, gbBackground);
                            reloadPopUp = false;
                        }
                        //Summary
                        if (navY == 14)
                        {

                        }
                        //Item
                        if (navY == 15)
                        {

                        }
                        //Withdraw
                        if (navY == 16)
                        {

                        }
                        //Release
                        if (navY == 17)
                        {

                        }
                        //Cancel
                        if (navY == 18)
                        {
                            reloadPopUp = false;
                        }
                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        reloadPopUp = false;
                        break;
                    default:
                        reloadPopUp = false;
                        break;
                }
                #endregion
            } while (reloadPopUp);
        }

        public static void PCSwitch(Player player, int monster1, int monster2, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadPopUp = true;
            int popUpX = 63;
            int popUpY = 16;
            int navX = 64;
            int navY = 17;

            do
            {
                /* Yes
                 * No
                 */
                #region PopUp Display
                popUpY = 16;
                foreach (string line in ASCII.pcSwitch)
                {
                    Console.SetCursorPosition(popUpX, popUpY);
                    Console.Write(line);
                    popUpY += 1;
                }
                Console.SetCursorPosition(navX, navY);
                Console.Write(">");
                #endregion

                ASCII.InstantMessage($"Swap {player.PC[monster1].Name.ToUpper()} with {player.PC[monster2].Name.ToUpper()}?", gbText, gbBackground);

                #region Menu
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Console.SetCursorPosition(navX, navY);
                        Console.Write(" ");
                        navY -= 1;
                        if (navY == 16)
                        {
                            navY = 18;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Console.SetCursorPosition(navX, navY);
                        Console.Write(" ");
                        navY += 1;
                        if (navY == 19)
                        {
                            navY = 17;
                        }
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.K:
                        //Yes
                        if (navY == 17)
                        {
                            Monster monsterSwitch = new Monster();
                            monsterSwitch = player.PC[monster1];
                            player.PC[monster1] = player.PC[monster2];
                            player.PC[monster2] = monsterSwitch;
                            PC(player, new Monster(), new int(), false, navPlayerMenu, gbText, gbBackground);
                            reloadPopUp = false;
                        }
                        //No
                        if (navY == 18)
                        {
                            PC(player, new Monster(), monster1, true, navPlayerMenu, gbText, gbBackground);
                            reloadPopUp = false;
                        }
                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        reloadPopUp = false;
                        break;
                    default:
                        reloadPopUp = false;
                        break;
                }
                #endregion
            } while (reloadPopUp);
        }

        #endregion

        #region PokeMart Purchase Menu

        public static void PokeMartVendor(Player player, int mapPosX, int mapPosY, int posX, int posY, int direction, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadMenu = true;
            bool reloadInnerMenu = true;
            bool reloadBuyMenu = true;
            bool reloadConfirmBuy = true;
            string[] menuOptions = new string[]
            {
                "Buy",
                "Sell",
                "See Ya!"
            };
            int menuPosY = 4;
            ASCII.ScrollMessageMulti("Welcome!", "What do you need?", 25, 1000, gbText, gbBackground);
            ASCII.SmallMenu(6, 3, menuOptions, gbText, gbBackground);
            do
            {
                Console.SetCursorPosition(7, menuPosY);
                Console.Write(">");
                navPlayerMenu = Console.ReadKey().Key;
                switch (navPlayerMenu)
                {
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        Console.SetCursorPosition(7, menuPosY);
                        Console.Write(" ");
                        menuPosY -= 1;
                        if (menuPosY < 4)
                        {
                            menuPosY = 4;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        Console.SetCursorPosition(7, menuPosY);
                        Console.Write(" ");
                        menuPosY += 1;
                        if (menuPosY > 3 + menuOptions.Length)
                        {
                            menuPosY = 3 + menuOptions.Length;
                        }
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.K:
                        Maps.DEMOPokeMartStatic(player, mapPosX, mapPosY, direction, posX, posY, gbText, gbBackground);
                        if (menuPosY == 4 || menuPosY == 5)
                        {
                            int innerMenuPosY = 4;
                            int itemPosX = 32;
                            int itemPosY = 4;
                            string[] PlayerDisplay = new string[]
                            {
                                "Money",
                                "        $ " + player.Money
                            };
                            string[] PokeMartItemDisplay = new string[]
        {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
        };
                            ASCII.SmallMenu(6, 3, PlayerDisplay, gbText, gbBackground);
                            ASCII.MediumMenu(29, 3, PokeMartItemDisplay, gbText, gbBackground);

                            if (menuPosY == 4)
                            {
                                foreach (Item item in Item.PokeMartItems)
                                {
                                    Console.SetCursorPosition(itemPosX, itemPosY);
                                    Console.Write(item.Name);
                                    Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                    Console.Write("$" + item.PriceBuy);
                                    itemPosY += 1;
                                }
                            }

                            if (menuPosY == 5)
                            {
                                #region Player Inventory
                                foreach (Item item in player.Inventory.ItemSection)
                                {
                                    Console.SetCursorPosition(itemPosX, itemPosY);
                                    Console.Write(item.Name);
                                    Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                    Console.Write("x" + item.Amount);
                                    itemPosY += 1;
                                }
                                foreach (Item item in player.Inventory.MedSection)
                                {
                                    Console.SetCursorPosition(itemPosX, itemPosY);
                                    Console.Write(item.Name);
                                    Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                    Console.Write("x" + item.Amount);
                                    itemPosY += 1;
                                }
                                foreach (Item item in player.Inventory.MoveSection)
                                {
                                    Console.SetCursorPosition(itemPosX, itemPosY);
                                    Console.Write(item.Name);
                                    Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                    Console.Write("x" + item.Amount);
                                    itemPosY += 1;
                                }
                                foreach (Item item in player.Inventory.BattleSection)
                                {
                                    Console.SetCursorPosition(itemPosX, itemPosY);
                                    Console.Write(item.Name);
                                    Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                    Console.Write("x" + item.Amount);
                                    itemPosY += 1;
                                }
                                #endregion
                            }
                            reloadInnerMenu = true;
                            do
                            {
                                Console.SetCursorPosition(30, innerMenuPosY);
                                Console.Write(">");
                                if (Item.PokeMartItems[innerMenuPosY - 4].Description.Length <= 70)
                                {
                                    ASCII.InstantMessage(Item.PokeMartItems[innerMenuPosY - 4].Description, gbText, gbBackground);
                                }
                                else
                                {
                                    ASCII.InstantMessageMulti(Item.PokeMartItems[innerMenuPosY - 4].Description.Substring(0, 70), Item.PokeMartItems[innerMenuPosY - 4].Description.Substring(70), gbText, gbBackground);
                                }
                                navPlayerMenu = Console.ReadKey().Key;
                                switch (navPlayerMenu)
                                {
                                    case ConsoleKey.UpArrow:
                                    case ConsoleKey.W:
                                        Console.SetCursorPosition(30, innerMenuPosY);
                                        Console.Write(" ");
                                        innerMenuPosY -= 1;
                                        if (innerMenuPosY < 4)
                                        {
                                            innerMenuPosY = 4;
                                        }
                                        break;
                                    case ConsoleKey.DownArrow:
                                    case ConsoleKey.S:
                                        Console.SetCursorPosition(30, innerMenuPosY);
                                        Console.Write(" ");
                                        innerMenuPosY += 1;
                                        if (innerMenuPosY > 3 + PokeMartItemDisplay.Length)
                                        {
                                            innerMenuPosY = 3 + PokeMartItemDisplay.Length;
                                        }
                                        break;
                                    case ConsoleKey.Enter:
                                    case ConsoleKey.K:
                                        if (menuPosY == 4)
                                        {
                                            if (Item.PokeMartItems[innerMenuPosY - 4].PriceBuy > player.Money)
                                            {
                                                ASCII.ScrollMessage("You don't have enough money to purchase this item!", 5, 1000, gbText, gbBackground);
                                                reloadBuyMenu = false;
                                            }
                                            else
                                            {
                                                ASCII.InstantMessageMulti(Item.PokeMartItems[innerMenuPosY - 4].Name + "? Certainly.", "How many would you like?", gbText, gbBackground);
                                                string[] PlayerItemCount = new string[]
                                                {
                                            "^",
                                            "x",
                                            "v"
                                                };
                                                ASCII.SmallMenu(60, 15, PlayerItemCount, gbText, gbBackground);
                                                int itemCount = 1;
                                                reloadBuyMenu = true;
                                                do
                                                {
                                                    Console.SetCursorPosition(64, 17);
                                                    Console.Write(itemCount);
                                                    Console.SetCursorPosition(74, 17);
                                                    Console.Write("$" + Item.PokeMartItems[innerMenuPosY - 4].PriceBuy * itemCount);
                                                    navPlayerMenu = Console.ReadKey().Key;

                                                    switch (navPlayerMenu)
                                                    {
                                                        case ConsoleKey.UpArrow:
                                                        case ConsoleKey.W:
                                                            Console.SetCursorPosition(64, 17);
                                                            Console.Write("      ");
                                                            Console.SetCursorPosition(74, 17);
                                                            Console.Write("      ");
                                                            itemCount += 1;
                                                            if (itemCount * Item.PokeMartItems[innerMenuPosY - 4].PriceBuy > player.Money)
                                                            {
                                                                itemCount = 1;
                                                            }
                                                            break;
                                                        case ConsoleKey.DownArrow:
                                                        case ConsoleKey.S:
                                                            Console.SetCursorPosition(64, 17);
                                                            Console.Write("      ");
                                                            Console.SetCursorPosition(74, 17);
                                                            Console.Write("      ");
                                                            itemCount -= 1;
                                                            if (itemCount == 0)
                                                            {
                                                                //itemCount = 1;
                                                                itemCount = player.Money / Item.PokeMartItems[innerMenuPosY - 4].PriceBuy;
                                                            }
                                                            break;
                                                        case ConsoleKey.Enter:
                                                        case ConsoleKey.K:
                                                            Maps.DEMOPokeMartStatic(player, mapPosX, mapPosY, direction, posX, posY, gbText, gbBackground);
                                                            ASCII.SmallMenu(6, 3, PlayerDisplay, gbText, gbBackground);
                                                            ASCII.MediumMenu(29, 3, PokeMartItemDisplay, gbText, gbBackground);
                                                            itemPosY = 4;
                                                            foreach (Item item in Item.PokeMartItems)
                                                            {
                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                Console.Write(item.Name);
                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                Console.Write("$" + item.PriceBuy);
                                                                itemPosY += 1;
                                                            }
                                                            ASCII.ScrollMessageMulti($"{Item.PokeMartItems[innerMenuPosY - 4].Name}, and you want {itemCount}?", $"That will be ${Item.PokeMartItems[innerMenuPosY - 4].PriceBuy * itemCount}, OK?", 5, 0, gbText, gbBackground);
                                                            ASCII.SmallMenu(60, 16, new string[] { "YES", "NO" }, gbText, gbBackground);
                                                            int confirmY = 17;
                                                            reloadConfirmBuy = true;
                                                            do
                                                            {
                                                                Console.SetCursorPosition(61, confirmY);
                                                                Console.Write(">");
                                                                navPlayerMenu = Console.ReadKey().Key;
                                                                switch (navPlayerMenu)
                                                                {
                                                                    case ConsoleKey.UpArrow:
                                                                    case ConsoleKey.W:
                                                                        Console.SetCursorPosition(61, confirmY);
                                                                        Console.Write(" ");
                                                                        confirmY -= 1;
                                                                        if (confirmY == 16)
                                                                        {
                                                                            confirmY = 18;
                                                                        }
                                                                        break;
                                                                    case ConsoleKey.DownArrow:
                                                                    case ConsoleKey.S:
                                                                        Console.SetCursorPosition(61, confirmY);
                                                                        Console.Write(" ");
                                                                        confirmY += 1;
                                                                        if (confirmY == 19)
                                                                        {
                                                                            confirmY = 17;
                                                                        }
                                                                        break;
                                                                    case ConsoleKey.Enter:
                                                                    case ConsoleKey.K:
                                                                        //YES
                                                                        if (confirmY == 17)
                                                                        {
                                                                            int count = 0;
                                                                            while (count < player.Inventory.ItemSection.Length)
                                                                            {
                                                                                if (Item.PokeMartItems[innerMenuPosY - 4].Name == player.Inventory.ItemSection[count].Name)
                                                                                {
                                                                                    player.Inventory.ItemSection[count].Amount += itemCount;
                                                                                    player.Money -= itemCount * Item.PokeMartItems[innerMenuPosY - 4].PriceBuy;
                                                                                }
                                                                                count += 1;
                                                                            }
                                                                            count = 0;
                                                                            while (count < player.Inventory.MedSection.Length)
                                                                            {
                                                                                if (Item.PokeMartItems[innerMenuPosY - 4].Name == player.Inventory.MedSection[count].Name)
                                                                                {
                                                                                    player.Inventory.MedSection[count].Amount += itemCount;
                                                                                    player.Money -= itemCount * Item.PokeMartItems[innerMenuPosY - 4].PriceBuy;
                                                                                }
                                                                                count += 1;
                                                                            }
                                                                            count = 0;
                                                                            while (count < player.Inventory.MoveSection.Length)
                                                                            {
                                                                                if (Item.PokeMartItems[innerMenuPosY - 4].Name == player.Inventory.MoveSection[count].Name)
                                                                                {
                                                                                    player.Inventory.MoveSection[count].Amount += itemCount;
                                                                                    player.Money -= itemCount * Item.PokeMartItems[innerMenuPosY - 4].PriceBuy;
                                                                                }
                                                                                count += 1;
                                                                            }
                                                                            count = 0;
                                                                            while (count < player.Inventory.BattleSection.Length)
                                                                            {
                                                                                if (Item.PokeMartItems[innerMenuPosY - 4].Name == player.Inventory.BattleSection[count].Name)
                                                                                {
                                                                                    player.Inventory.BattleSection[count].Amount += itemCount;
                                                                                    player.Money -= itemCount * Item.PokeMartItems[innerMenuPosY - 4].PriceBuy;
                                                                                }
                                                                                count += 1;
                                                                            }
                                                                            reloadConfirmBuy = false;
                                                                            reloadBuyMenu = false;
                                                                            Maps.DEMOPokeMartStatic(player, mapPosX, mapPosY, direction, posX, posY, gbText, gbBackground);
                                                                            PlayerDisplay = new string[]
                                    {
                                "Money",
                                "        $ " + player.Money
                                    };
                                                                            ASCII.SmallMenu(6, 3, PlayerDisplay, gbText, gbBackground);
                                                                            ASCII.MediumMenu(29, 3, PokeMartItemDisplay, gbText, gbBackground);
                                                                            itemPosY = 4;
                                                                            foreach (Item item in Item.PokeMartItems)
                                                                            {
                                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                                Console.Write(item.Name);
                                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                                Console.Write("$" + item.PriceBuy);
                                                                                itemPosY += 1;
                                                                            }
                                                                            ASCII.ScrollMessage("Thank you for your purchase!", 25, 1000, gbText, gbBackground);
                                                                        }
                                                                        //NO
                                                                        if (confirmY == 18)
                                                                        {
                                                                            reloadConfirmBuy = false;
                                                                            reloadBuyMenu = false;
                                                                            Maps.DEMOPokeMartStatic(player, mapPosX, mapPosY, direction, posX, posY, gbText, gbBackground);
                                                                            ASCII.SmallMenu(6, 3, PlayerDisplay, gbText, gbBackground);
                                                                            ASCII.MediumMenu(29, 3, PokeMartItemDisplay, gbText, gbBackground);
                                                                            itemPosY = 4;
                                                                            foreach (Item item in Item.PokeMartItems)
                                                                            {
                                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                                Console.Write(item.Name);
                                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                                Console.Write("$" + item.PriceBuy);
                                                                                itemPosY += 1;
                                                                            }
                                                                        }
                                                                        break;
                                                                    case ConsoleKey.Backspace:
                                                                    case ConsoleKey.O:
                                                                        reloadConfirmBuy = false;
                                                                        reloadBuyMenu = false;
                                                                        Maps.DEMOPokeMartStatic(player, mapPosX, mapPosY, direction, posX, posY, gbText, gbBackground);
                                                                        ASCII.SmallMenu(6, 3, PlayerDisplay, gbText, gbBackground);
                                                                        ASCII.MediumMenu(29, 3, PokeMartItemDisplay, gbText, gbBackground);
                                                                        itemPosY = 4;
                                                                        foreach (Item item in Item.PokeMartItems)
                                                                        {
                                                                            Console.SetCursorPosition(itemPosX, itemPosY);
                                                                            Console.Write(item.Name);
                                                                            Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                            Console.Write("$" + item.PriceBuy);
                                                                            itemPosY += 1;
                                                                        }
                                                                        break;
                                                                    default:
                                                                        break;
                                                                }
                                                            } while (reloadConfirmBuy);
                                                            break;
                                                        case ConsoleKey.Backspace:
                                                        case ConsoleKey.O:
                                                            Maps.DEMOPokeMartStatic(player, mapPosX, mapPosY, direction, posX, posY, gbText, gbBackground);
                                                            ASCII.SmallMenu(6, 3, PlayerDisplay, gbText, gbBackground);
                                                            ASCII.MediumMenu(29, 3, PokeMartItemDisplay, gbText, gbBackground);
                                                            itemPosY = 4;
                                                            foreach (Item item in Item.PokeMartItems)
                                                            {
                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                Console.Write(item.Name);
                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                Console.Write("$" + item.PriceBuy);
                                                                itemPosY += 1;
                                                            }
                                                            reloadBuyMenu = false;
                                                            break;
                                                        default:
                                                            break;
                                                    }
                                                } while (reloadBuyMenu);
                                            }
                                        }
                                        if (menuPosY == 5)
                                        {
                                            int count = 0;
                                            while (count < player.Inventory.ItemSection.Length)
                                            {
                                                if (Item.PokeMartItems[innerMenuPosY - 4].Name == player.Inventory.ItemSection[count].Name)
                                                {
                                                    Item.PokeMartItems[innerMenuPosY - 4].Amount = player.Inventory.ItemSection[count].Amount;
                                                }
                                                count += 1;
                                            }
                                            count = 0;
                                            while (count < player.Inventory.MedSection.Length)
                                            {
                                                if (Item.PokeMartItems[innerMenuPosY - 4].Name == player.Inventory.MedSection[count].Name)
                                                {
                                                    Item.PokeMartItems[innerMenuPosY - 4].Amount = player.Inventory.MedSection[count].Amount;
                                                }
                                                count += 1;
                                            }
                                            count = 0;
                                            while (count < player.Inventory.MoveSection.Length)
                                            {
                                                if (Item.PokeMartItems[innerMenuPosY - 4].Name == player.Inventory.MoveSection[count].Name)
                                                {
                                                    Item.PokeMartItems[innerMenuPosY - 4].Amount = player.Inventory.MoveSection[count].Amount;
                                                }
                                                count += 1;
                                            }
                                            count = 0;
                                            while (count < player.Inventory.BattleSection.Length)
                                            {
                                                if (Item.PokeMartItems[innerMenuPosY - 4].Name == player.Inventory.BattleSection[count].Name)
                                                {
                                                    Item.PokeMartItems[innerMenuPosY - 4].Amount = player.Inventory.BattleSection[count].Amount;
                                                }
                                                count += 1;
                                            }
                                            if (Item.PokeMartItems[innerMenuPosY - 4].Amount <= 0)
                                            {
                                                ASCII.ScrollMessage("You do not possess this item!", 5, 1000, gbText, gbBackground);
                                                reloadBuyMenu = false;
                                            }
                                            else
                                            {
                                                ASCII.InstantMessageMulti(Item.PokeMartItems[innerMenuPosY - 4].Name + "?", "How many would you like to sell?", gbText, gbBackground);
                                                string[] PlayerItemCount = new string[]
                                                {
                                            "^",
                                            "x",
                                            "v"
                                                };
                                                ASCII.SmallMenu(60, 15, PlayerItemCount, gbText, gbBackground);
                                                int itemCount = 1;
                                                reloadBuyMenu = true;
                                                do
                                                {
                                                    Console.SetCursorPosition(64, 17);
                                                    Console.Write(itemCount);
                                                    Console.SetCursorPosition(74, 17);
                                                    Console.Write("$" + Item.PokeMartItems[innerMenuPosY - 4].PriceSell * itemCount);
                                                    navPlayerMenu = Console.ReadKey().Key;

                                                    switch (navPlayerMenu)
                                                    {
                                                        case ConsoleKey.UpArrow:
                                                        case ConsoleKey.W:
                                                            Console.SetCursorPosition(64, 17);
                                                            Console.Write("      ");
                                                            Console.SetCursorPosition(74, 17);
                                                            Console.Write("      ");
                                                            itemCount += 1;
                                                            if (itemCount > Item.PokeMartItems[innerMenuPosY - 4].Amount)
                                                            {
                                                                itemCount = 1;
                                                            }
                                                            break;
                                                        case ConsoleKey.DownArrow:
                                                        case ConsoleKey.S:
                                                            Console.SetCursorPosition(64, 17);
                                                            Console.Write("      ");
                                                            Console.SetCursorPosition(74, 17);
                                                            Console.Write("      ");
                                                            itemCount -= 1;
                                                            if (itemCount == 0)
                                                            {
                                                                itemCount = Item.PokeMartItems[innerMenuPosY - 4].Amount;
                                                            }
                                                            break;
                                                        case ConsoleKey.Enter:
                                                        case ConsoleKey.K:
                                                            Maps.DEMOPokeMartStatic(player, mapPosX, mapPosY, direction, posX, posY, gbText, gbBackground);
                                                            ASCII.SmallMenu(6, 3, PlayerDisplay, gbText, gbBackground);
                                                            ASCII.MediumMenu(29, 3, PokeMartItemDisplay, gbText, gbBackground);
                                                            itemPosY = 4;
                                                            #region Player Inventory
                                                            foreach (Item item in player.Inventory.ItemSection)
                                                            {
                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                Console.Write(item.Name);
                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                Console.Write("x" + item.Amount);
                                                                itemPosY += 1;
                                                            }
                                                            foreach (Item item in player.Inventory.MedSection)
                                                            {
                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                Console.Write(item.Name);
                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                Console.Write("x" + item.Amount);
                                                                itemPosY += 1;
                                                            }
                                                            foreach (Item item in player.Inventory.MoveSection)
                                                            {
                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                Console.Write(item.Name);
                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                Console.Write("x" + item.Amount);
                                                                itemPosY += 1;
                                                            }
                                                            foreach (Item item in player.Inventory.BattleSection)
                                                            {
                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                Console.Write(item.Name);
                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                Console.Write("x" + item.Amount);
                                                                itemPosY += 1;
                                                            }
                                                            #endregion
                                                            ASCII.ScrollMessageMulti($"I can pay ${Item.PokeMartItems[innerMenuPosY - 4].PriceSell * itemCount}.", $"Would that be OK?", 5, 0, gbText, gbBackground);
                                                            ASCII.SmallMenu(60, 16, new string[] { "YES", "NO" }, gbText, gbBackground);
                                                            int confirmY = 17;
                                                            reloadConfirmBuy = true;
                                                            do
                                                            {
                                                                Console.SetCursorPosition(61, confirmY);
                                                                Console.Write(">");
                                                                navPlayerMenu = Console.ReadKey().Key;
                                                                switch (navPlayerMenu)
                                                                {
                                                                    case ConsoleKey.UpArrow:
                                                                    case ConsoleKey.W:
                                                                        Console.SetCursorPosition(61, confirmY);
                                                                        Console.Write(" ");
                                                                        confirmY -= 1;
                                                                        if (confirmY == 16)
                                                                        {
                                                                            confirmY = 18;
                                                                        }
                                                                        break;
                                                                    case ConsoleKey.DownArrow:
                                                                    case ConsoleKey.S:
                                                                        Console.SetCursorPosition(61, confirmY);
                                                                        Console.Write(" ");
                                                                        confirmY += 1;
                                                                        if (confirmY == 19)
                                                                        {
                                                                            confirmY = 17;
                                                                        }
                                                                        break;
                                                                    case ConsoleKey.Enter:
                                                                    case ConsoleKey.K:
                                                                        //YES
                                                                        if (confirmY == 17)
                                                                        {
                                                                            count = 0;
                                                                            while (count < player.Inventory.ItemSection.Length)
                                                                            {
                                                                                if (Item.PokeMartItems[innerMenuPosY - 4].Name == player.Inventory.ItemSection[count].Name)
                                                                                {
                                                                                    player.Inventory.ItemSection[count].Amount -= itemCount;
                                                                                    player.Money += itemCount * Item.PokeMartItems[innerMenuPosY - 4].PriceSell;
                                                                                }
                                                                                count += 1;
                                                                            }
                                                                            count = 0;
                                                                            while (count < player.Inventory.MedSection.Length)
                                                                            {
                                                                                if (Item.PokeMartItems[innerMenuPosY - 4].Name == player.Inventory.MedSection[count].Name)
                                                                                {
                                                                                    player.Inventory.MedSection[count].Amount -= itemCount;
                                                                                    player.Money += itemCount * Item.PokeMartItems[innerMenuPosY - 4].PriceSell;
                                                                                }
                                                                                count += 1;
                                                                            }
                                                                            count = 0;
                                                                            while (count < player.Inventory.MoveSection.Length)
                                                                            {
                                                                                if (Item.PokeMartItems[innerMenuPosY - 4].Name == player.Inventory.MoveSection[count].Name)
                                                                                {
                                                                                    player.Inventory.MoveSection[count].Amount -= itemCount;
                                                                                    player.Money += itemCount * Item.PokeMartItems[innerMenuPosY - 4].PriceSell;
                                                                                }
                                                                                count += 1;
                                                                            }
                                                                            count = 0;
                                                                            while (count < player.Inventory.BattleSection.Length)
                                                                            {
                                                                                if (Item.PokeMartItems[innerMenuPosY - 4].Name == player.Inventory.BattleSection[count].Name)
                                                                                {
                                                                                    player.Inventory.BattleSection[count].Amount -= itemCount;
                                                                                    player.Money += itemCount * Item.PokeMartItems[innerMenuPosY - 4].PriceSell;
                                                                                }
                                                                                count += 1;
                                                                            }
                                                                            reloadConfirmBuy = false;
                                                                            reloadBuyMenu = false;
                                                                            Maps.DEMOPokeMartStatic(player, mapPosX, mapPosY, direction, posX, posY, gbText, gbBackground);
                                                                            PlayerDisplay = new string[]
                                    {
                                "Money",
                                "        $ " + player.Money
                                    };
                                                                            ASCII.SmallMenu(6, 3, PlayerDisplay, gbText, gbBackground);
                                                                            ASCII.MediumMenu(29, 3, PokeMartItemDisplay, gbText, gbBackground);
                                                                            itemPosY = 4;
                                                                            #region Player Inventory
                                                                            foreach (Item item in player.Inventory.ItemSection)
                                                                            {
                                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                                Console.Write(item.Name);
                                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                                Console.Write("x" + item.Amount);
                                                                                itemPosY += 1;
                                                                            }
                                                                            foreach (Item item in player.Inventory.MedSection)
                                                                            {
                                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                                Console.Write(item.Name);
                                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                                Console.Write("x" + item.Amount);
                                                                                itemPosY += 1;
                                                                            }
                                                                            foreach (Item item in player.Inventory.MoveSection)
                                                                            {
                                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                                Console.Write(item.Name);
                                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                                Console.Write("x" + item.Amount);
                                                                                itemPosY += 1;
                                                                            }
                                                                            foreach (Item item in player.Inventory.BattleSection)
                                                                            {
                                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                                Console.Write(item.Name);
                                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                                Console.Write("x" + item.Amount);
                                                                                itemPosY += 1;
                                                                            }
                                                                            #endregion
                                                                            ASCII.ScrollMessageMulti($"Turned over the {Item.PokeMartItems[innerMenuPosY - 4].Name}", $"and received ${itemCount * Item.PokeMartItems[innerMenuPosY - 4].PriceSell}.", 25, 1000, gbText, gbBackground);
                                                                        }
                                                                        //NO
                                                                        if (confirmY == 18)
                                                                        {
                                                                            reloadConfirmBuy = false;
                                                                            reloadBuyMenu = false;
                                                                            Maps.DEMOPokeMartStatic(player, mapPosX, mapPosY, direction, posX, posY, gbText, gbBackground);
                                                                            ASCII.SmallMenu(6, 3, PlayerDisplay, gbText, gbBackground);
                                                                            ASCII.MediumMenu(29, 3, PokeMartItemDisplay, gbText, gbBackground);
                                                                            itemPosY = 4;
                                                                            #region Player Inventory
                                                                            foreach (Item item in player.Inventory.ItemSection)
                                                                            {
                                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                                Console.Write(item.Name);
                                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                                Console.Write("x" + item.Amount);
                                                                                itemPosY += 1;
                                                                            }
                                                                            foreach (Item item in player.Inventory.MedSection)
                                                                            {
                                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                                Console.Write(item.Name);
                                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                                Console.Write("x" + item.Amount);
                                                                                itemPosY += 1;
                                                                            }
                                                                            foreach (Item item in player.Inventory.MoveSection)
                                                                            {
                                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                                Console.Write(item.Name);
                                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                                Console.Write("x" + item.Amount);
                                                                                itemPosY += 1;
                                                                            }
                                                                            foreach (Item item in player.Inventory.BattleSection)
                                                                            {
                                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                                Console.Write(item.Name);
                                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                                Console.Write("x" + item.Amount);
                                                                                itemPosY += 1;
                                                                            }
                                                                            #endregion
                                                                        }
                                                                        break;
                                                                    case ConsoleKey.Backspace:
                                                                    case ConsoleKey.O:
                                                                        reloadConfirmBuy = false;
                                                                        reloadBuyMenu = false;
                                                                        Maps.DEMOPokeMartStatic(player, mapPosX, mapPosY, direction, posX, posY, gbText, gbBackground);
                                                                        ASCII.SmallMenu(6, 3, PlayerDisplay, gbText, gbBackground);
                                                                        ASCII.MediumMenu(29, 3, PokeMartItemDisplay, gbText, gbBackground);
                                                                        itemPosY = 4;
                                                                        #region Player Inventory
                                                                        foreach (Item item in player.Inventory.ItemSection)
                                                                        {
                                                                            Console.SetCursorPosition(itemPosX, itemPosY);
                                                                            Console.Write(item.Name);
                                                                            Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                            Console.Write("x" + item.Amount);
                                                                            itemPosY += 1;
                                                                        }
                                                                        foreach (Item item in player.Inventory.MedSection)
                                                                        {
                                                                            Console.SetCursorPosition(itemPosX, itemPosY);
                                                                            Console.Write(item.Name);
                                                                            Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                            Console.Write("x" + item.Amount);
                                                                            itemPosY += 1;
                                                                        }
                                                                        foreach (Item item in player.Inventory.MoveSection)
                                                                        {
                                                                            Console.SetCursorPosition(itemPosX, itemPosY);
                                                                            Console.Write(item.Name);
                                                                            Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                            Console.Write("x" + item.Amount);
                                                                            itemPosY += 1;
                                                                        }
                                                                        foreach (Item item in player.Inventory.BattleSection)
                                                                        {
                                                                            Console.SetCursorPosition(itemPosX, itemPosY);
                                                                            Console.Write(item.Name);
                                                                            Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                            Console.Write("x" + item.Amount);
                                                                            itemPosY += 1;
                                                                        }
                                                                        #endregion
                                                                        break;
                                                                    default:
                                                                        break;
                                                                }
                                                            } while (reloadConfirmBuy);
                                                            break;
                                                        case ConsoleKey.Backspace:
                                                        case ConsoleKey.O:
                                                            Maps.DEMOPokeMartStatic(player, mapPosX, mapPosY, direction, posX, posY, gbText, gbBackground);
                                                            ASCII.SmallMenu(6, 3, PlayerDisplay, gbText, gbBackground);
                                                            ASCII.MediumMenu(29, 3, PokeMartItemDisplay, gbText, gbBackground);
                                                            itemPosY = 4;
                                                            #region Player Inventory
                                                            foreach (Item item in player.Inventory.ItemSection)
                                                            {
                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                Console.Write(item.Name);
                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                Console.Write("x" + item.Amount);
                                                                itemPosY += 1;
                                                            }
                                                            foreach (Item item in player.Inventory.MedSection)
                                                            {
                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                Console.Write(item.Name);
                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                Console.Write("x" + item.Amount);
                                                                itemPosY += 1;
                                                            }
                                                            foreach (Item item in player.Inventory.MoveSection)
                                                            {
                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                Console.Write(item.Name);
                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                Console.Write("x" + item.Amount);
                                                                itemPosY += 1;
                                                            }
                                                            foreach (Item item in player.Inventory.BattleSection)
                                                            {
                                                                Console.SetCursorPosition(itemPosX, itemPosY);
                                                                Console.Write(item.Name);
                                                                Console.SetCursorPosition(itemPosX + 29, itemPosY);
                                                                Console.Write("x" + item.Amount);
                                                                itemPosY += 1;
                                                            }
                                                            #endregion
                                                            reloadBuyMenu = false;
                                                            break;
                                                        default:
                                                            break;
                                                    }
                                                } while (reloadBuyMenu);
                                            }
                                        }
                                        break;
                                    case ConsoleKey.Backspace:
                                    case ConsoleKey.O:
                                        reloadInnerMenu = false;
                                        break;
                                    default:
                                        break;
                                }
                            } while (reloadInnerMenu);
                        }
                        if (menuPosY == 6)
                        {
                            reloadMenu = false;
                        }
                        if (menuPosY != 6)
                        {
                            Maps.DEMOPokeMartStatic(player, mapPosX, mapPosY, direction, posX, posY, gbText, gbBackground);
                            ASCII.SmallMenu(6, 3, menuOptions, gbText, gbBackground);
                            ASCII.ScrollMessage("Is there anything else I may do for you?", 25, 0, gbText, gbBackground);
                        }
                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        reloadMenu = false;
                        break;
                    default:
                        break;
                }
            } while (reloadMenu);

        }

        #endregion
    }
}
