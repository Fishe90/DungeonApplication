using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses
{
    public class Player_Menus
    {
        /****GENERAL MENUS****/

        //WHY DOESN'T THIS WORK???
        public static void YesOrNo(string message, int chooseNum, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            chooseNum = 0;
            bool reloadBattleFAINT = false;
            int posY = 22;

            ASCII.InstantMessage(message, gbText, gbBackground);
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
                            chooseNum += 1;
                            reloadBattleFAINT = false;
                        }
                        else if (posY == 23)
                        {
                            chooseNum += 2;
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
                            SFX.RunAway();
                            string message2 = $"{player.Name.ToUpper()} fled to safety!";
                            ASCII.ScrollMessage(message2, 15, 2000, gbText, gbBackground);
                            reloadBattleFAINT = false;
                        }
                        break;
                    case ConsoleKey.Backspace:
                    case ConsoleKey.O:
                        SFX.RunAway();
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

        /****FIGHT MENU****/
        
        #region Fight Menu

        public static void WildFightMenu(Player player, Monster monster, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
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
                                            SFX.RunAway();
                                            string message2 = $"{player.Name.ToUpper()} fled to safety!";
                                            ASCII.ScrollMessage(message2, 15, 2000, gbText, gbBackground);
                                            reloadBattleFAINT = false;
                                        }
                                        break;
                                    case ConsoleKey.Backspace:
                                    case ConsoleKey.O:
                                        SFX.RunAway();
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
                                                SFX.RunAway();
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
                                                            BattlePartySwitch(player, monster, navPlayerMenu, gbText, gbBackground);
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
                                    BattlePartySwitch(player, monster, navPlayerMenu, gbText, gbBackground);
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
                                                SFX.RunAway();
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
                        FightMovesMenu(player, npc.Party.MonsterEquipped, navPlayerMenu, gbText, gbBackground);
                        if (npc.Party.MonsterEquipped.Health <= 0)
                        {
                            int posY = 22;
                            System.Threading.Thread.Sleep(1000);
                            ASCII.ANIDefenderFaint(npc.Party.MonsterEquipped, gbText, gbBackground);
                            //TODO ADD CalcEXP() HERE!!!
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
                                ASCII.ANINPCNext(player, npc, 2, gbText, gbBackground);                                
                                bool reloadNext2 = false;                                

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
                                            reloadNext2 = true;
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
                                            reloadNext2 = true;
                                            break;
                                        case ConsoleKey.Enter:
                                        case ConsoleKey.K:
                                            if (posY == 22)
                                            {
                                                BattlePartySwitchNPCNEW(player, npc.Party.MonsterEquipped, navPlayerMenu, gbText, gbBackground);
                                                reloadNext2 = false;
                                            }
                                            else if (posY == 23)
                                            {
                                                reloadNext2 = false;
                                            }
                                            break;
                                        case ConsoleKey.Backspace:
                                        case ConsoleKey.O:
                                            reloadNext2 = false;
                                            break;
                                        default:
                                            reloadNext2 = true;
                                            break;
                                    }
                                } while (reloadNext2);
                                ASCII.ANINPCSend(npc, gbText, gbBackground);
                            }
                            else if (npc.Party.Slot3.Health > 0)
                            {
                                ASCII.ANINPCNext(player, npc, 3, gbText, gbBackground);
                                bool reloadNext2 = false;

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
                                            reloadNext2 = true;
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
                                            reloadNext2 = true;
                                            break;
                                        case ConsoleKey.Enter:
                                        case ConsoleKey.K:
                                            if (posY == 22)
                                            {
                                                BattlePartySwitchNPCNEW(player, npc.Party.MonsterEquipped, navPlayerMenu, gbText, gbBackground);
                                                reloadNext2 = false;
                                            }
                                            else if (posY == 23)
                                            {
                                                reloadNext2 = false;
                                            }
                                            break;
                                        case ConsoleKey.Backspace:
                                        case ConsoleKey.O:
                                            reloadNext2 = false;
                                            break;
                                        default:
                                            reloadNext2 = true;
                                            break;
                                    }
                                } while (reloadNext2);
                                ASCII.ANINPCSend(npc, gbText, gbBackground);
                            }
                            else if (npc.Party.Slot4.Health > 0)
                            {
                                ASCII.ANINPCNext(player, npc, 4, gbText, gbBackground);
                                bool reloadNext2 = false;

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
                                            reloadNext2 = true;
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
                                            reloadNext2 = true;
                                            break;
                                        case ConsoleKey.Enter:
                                        case ConsoleKey.K:
                                            if (posY == 22)
                                            {
                                                BattlePartySwitchNPCNEW(player, npc.Party.MonsterEquipped, navPlayerMenu, gbText, gbBackground);
                                                reloadNext2 = false;
                                            }
                                            else if (posY == 23)
                                            {
                                                reloadNext2 = false;
                                            }
                                            break;
                                        case ConsoleKey.Backspace:
                                        case ConsoleKey.O:
                                            reloadNext2 = false;
                                            break;
                                        default:
                                            reloadNext2 = true;
                                            break;
                                    }
                                } while (reloadNext2);
                                ASCII.ANINPCSend(npc, gbText, gbBackground);
                            }
                            else if (npc.Party.Slot5.Health > 0)
                            {
                                ASCII.ANINPCNext(player, npc, 5, gbText, gbBackground);
                                bool reloadNext2 = false;

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
                                            reloadNext2 = true;
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
                                            reloadNext2 = true;
                                            break;
                                        case ConsoleKey.Enter:
                                        case ConsoleKey.K:
                                            if (posY == 22)
                                            {
                                                BattlePartySwitchNPCNEW(player, npc.Party.MonsterEquipped, navPlayerMenu, gbText, gbBackground);
                                                reloadNext2 = false;
                                            }
                                            else if (posY == 23)
                                            {
                                                reloadNext2 = false;
                                            }
                                            break;
                                        case ConsoleKey.Backspace:
                                        case ConsoleKey.O:
                                            reloadNext2 = false;
                                            break;
                                        default:
                                            reloadNext2 = true;
                                            break;
                                    }
                                } while (reloadNext2);
                                ASCII.ANINPCSend(npc, gbText, gbBackground);
                            }
                            else if (npc.Party.Slot6.Health > 0)
                            {
                                ASCII.ANINPCNext(player, npc, 6, gbText, gbBackground);
                                bool reloadNext2 = false;

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
                                            reloadNext2 = true;
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
                                            reloadNext2 = true;
                                            break;
                                        case ConsoleKey.Enter:
                                        case ConsoleKey.K:
                                            if (posY == 22)
                                            {
                                                BattlePartySwitchNPCNEW(player, npc.Party.MonsterEquipped, navPlayerMenu, gbText, gbBackground);
                                                reloadNext2 = false;
                                            }
                                            else if (posY == 23)
                                            {
                                                reloadNext2 = false;
                                            }
                                            break;
                                        case ConsoleKey.Backspace:
                                        case ConsoleKey.O:
                                            reloadNext2 = false;
                                            break;
                                        default:
                                            reloadNext2 = true;
                                            break;
                                    }
                                } while (reloadNext2);
                                ASCII.ANINPCSend(npc, gbText, gbBackground);
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
                                BattlePartySwitch(player, npc.Party.MonsterEquipped, navPlayerMenu, gbText, gbBackground);

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
                                                            BattlePartySwitch(player, npc.Party.MonsterEquipped, navPlayerMenu, gbText, gbBackground);
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
                                    BattlePartySwitch(player, npc.Party.MonsterEquipped, navPlayerMenu, gbText, gbBackground);
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
                monster.Health += monster.MaxHealth/2;
            }
            //else if (item.Name == "Health Potion" && monster.Health > 0 && monster.Health <= monster.MaxHealth)
            //{
            //    monster.Health += 20;
            //}
            //else if (item.Name == "Health Potion" && monster.Health > 0 && monster.Health <= monster.MaxHealth)
            //{
            //    monster.Health += 20;
            //}
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
                                        
                                        ASCII.ANIPlayerSwitchSend(player, 3, monster, gbText, gbBackground);
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
                                        ASCII.ANIPlayerSwitchSend(player, 5, monster, gbText, gbBackground);
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
                                        ASCII.ANIPlayerSwitchSend(player, 2, monster, gbText, gbBackground);
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
                                        ASCII.ANIPlayerSwitchSend(player, 4, monster, gbText, gbBackground);
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
                                        //if (player.Party.MonsterEquipped.Health >= 0)
                                        //{
                                        //    ASCII.DISATTandDEF(player, monster, gbText, gbBackground);
                                        //    ASCII.ScrollMessage(messageReturn, 50, 1000, gbText, gbBackground);
                                        //    ASCII.ANIReturn(6, 13, gbText, gbBackground);
                                        //}
                                        //ASCII.ResetHalfScreen(12, gbText, gbBackground);
                                        //System.Threading.Thread.Sleep(1000);
                                        //player.Party.MonsterSwitch = player.Party.MonsterEquipped;
                                        //player.Party.MonsterEquipped = player.Party.Slot6;
                                        //player.Party.Slot6 = player.Party.MonsterSwitch;
                                        //ASCII.ANIPlayerSend(player, gbText, gbBackground);
                                        ASCII.ANIPlayerSwitchSend(player, 6, monster, gbText, gbBackground);
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
                            ASCII.DISATTandDEF(player, monster, gbText, gbBackground);
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

        public static void PlayerMenu(Player player, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadPlayerMenu = false;
            bool reloadPlayerMonstersEquipped = false;
            bool reloadPlayerBag = false;
            bool reloadPlayerProfile = false;
            bool reloadPlayerEXIT = false;

            do
            {
                Player_Menus.PlayerSelect(player, ASCII.PMPokedexSelect, gbText, gbBackground);
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
                            Player_Menus.PlayerSelect(player, ASCII.PMPartySelect, gbText, gbBackground);
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
                                        Player_Menus.PlayerSelect(player, ASCII.PMBagSelect, gbText, gbBackground);
                                        navPlayerMenu = Console.ReadKey().Key;
                                        switch (navPlayerMenu)
                                        {
                                            case ConsoleKey.Enter:
                                                //SFX.Select();
                                                //PlayerItemSectionOutsideBattle(player, monster, navPlayerMenu, gbText, gbBackground);
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
                                                    Player_Menus.PlayerSelect(player, ASCII.PMProfileSelect, gbText, gbBackground);
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
                                                                Player_Menus.PlayerSelect(player, ASCII.PMExitSelect, gbText, gbBackground);
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
