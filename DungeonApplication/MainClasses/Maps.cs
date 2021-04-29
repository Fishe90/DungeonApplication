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

        #region DEMO Map

        public static void DEMOMapActive(Player player, Player npc, int currentPosX, int currentPosY, int direction, int posX, int posY, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            int centerX = currentPosX - posX;
            int centerY = currentPosY - posY;
            Console.SetBufferSize(2000, 2000);
            ASCII.GameMap(ASCII.DEMOMap, currentPosX, currentPosY, gbText, gbBackground);
            ASCII.DisplayNPC("trainerFemale", 3, centerX - 30, centerY, gbText, gbBackground);
            //ASCII.DisplayNPC("trainerMale", 3, centerX + 30, centerY, gbText, gbBackground);
            ASCII.PlayerMovement(player, direction, gbText, gbBackground);
        }

        public static void DEMOMapStatic(Player player, Player npc, int currentPosX, int currentPosY, int direction, int posX, int posY, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            int centerX = currentPosX - posX;
            int centerY = currentPosY - posY;
            Console.SetBufferSize(2000, 2000);
            ASCII.GameMap(ASCII.DEMOMap, currentPosX, currentPosY, gbText, gbBackground);
            ASCII.DisplayNPC("trainerFemale", 3, centerX - 30, centerY, gbText, gbBackground);
            //ASCII.DisplayNPC("trainerMale", 3, centerX + 30, centerY, gbText, gbBackground);
            ASCII.PlayerMovementStatic(player, direction, gbText, gbBackground);
        }

        public static void DEMOMap(Player player, Player npc, int currentPosX, int currentPosY, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;
            //Coordinates Relative to the Center of the Player Field
            //int posX = 142;
            //int posY = 68;
            //OG Coordinates:
            int posX = 150;
            int posY = 34;            
            int direction = 6;
            Random rand = new Random();
            int encounterChance = rand.Next(0, 100);
            //(167,56) **Player Position   
            DEMOMapStatic(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
            do
            {

                navPlayerMenu = Console.ReadKey().Key;

                switch (navPlayerMenu)
                {

                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (direction == 3 || direction == 4)
                        {
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
                            //Boundaries
                            #region Boundaries

                            #region Player House & Rival House Bottom
                            if (currentPosX >= 172 && currentPosX <= 187 && currentPosY == 54 || currentPosX == 162 && currentPosY == 54 ||
                                currentPosX >= 107 && currentPosX <= 122 && currentPosY == 54 || currentPosX == 97 && currentPosY == 54)
                            {
                                currentPosY += 2;
                                posY += 4;
                                direction = 3;
                            }
                            #endregion

                            #region PokeCenter & PokeMart Bottom
                            if (currentPosX >= 162 && currentPosX <= 167 && currentPosY == 34 || currentPosX >= 177 && currentPosX <= 182 && currentPosY == 34 ||
                                currentPosX >= 112 && currentPosX <= 122 && currentPosY == 34 || currentPosX == 102 && currentPosY == 34)
                            {
                                currentPosY += 2;
                                posY += 4;
                                direction = 3;
                            }
                            #endregion

                            #endregion
                            //Rival Up
                            if (currentPosX == 112 && currentPosY == 68)
                            {
                                currentPosY += 2;
                                posY += 4;
                                direction = 3;
                            }
                            //Border Top
                            if (currentPosY < 16)
                            {
                                currentPosY += 2;
                                posY += 4;
                                direction = 3;
                            }
                            DEMOMapActive(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                            //Catching Field    
                            encounterChance = rand.Next(0, 100);
                            if (currentPosX <= 177 && currentPosX >= 107 && currentPosY >= 88 && currentPosY <= 98 && encounterChance > 98)
                            {
                                //currentPosY += 2;
                                //posY += 4;
                                DEMOMapActive(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                                SFX.Battle();
                                ASCII.BattleIntroFLASH(player, direction, currentPosX, currentPosY, ASCII.DEMOMap);
                                ASCII.FullBattleWild(player, Monster.monsters, 3, 5, gbText, gbBackground, navPlayerMenu);
                                DEMOMapStatic(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                                SFX.Route2();
                            }
                            //Rival House
                            if (currentPosX == 102 && currentPosY == 54)
                            {
                                DEMORivalHouse(player, 30, 17, navPlayerMenu, gbText, gbBackground);
                                currentPosY += 2;
                                posY += 4;
                                direction = 6;
                                DEMOMapActive(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
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
                                DEMOMapActive(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
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
                                DEMOMapActive(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                            }
                            //Player's House
                            if (currentPosX == 167 && currentPosY == 54)
                            {
                                DEMOPlayerHouse(player, 30, 17, navPlayerMenu, gbText, gbBackground);
                                currentPosY += 2;
                                posY += 4;
                                direction = 6;
                                DEMOMapActive(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                            }                            
                        }
                        else
                        {
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
                            DEMOMapStatic(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if (direction == 5 || direction == 6)
                        {
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
                            //Boundaries
                            #region Boundaries

                            #region Player House & Rival House Top
                            if (currentPosX >= 162 && currentPosX <= 187 && currentPosY == 46 || currentPosX >= 167 && currentPosX <= 182 && currentPosY == 44 || currentPosX >= 172 && currentPosX <= 177 && currentPosY == 42 ||
                                currentPosX >= 97 && currentPosX <= 122 && currentPosY == 46 || currentPosX >= 102 && currentPosX <= 117 && currentPosY == 44 || currentPosX >= 107 && currentPosX <= 112 && currentPosY == 42)
                            {
                                currentPosY -= 2;
                                posY -= 4;
                            }
                            #endregion

                            #region PokeCenter & PokeMart Top
                            if (currentPosX >= 162 && currentPosX <= 182 && currentPosY == 24 || currentPosX >= 102 && currentPosX <= 122 && currentPosY == 24)
                            {
                                currentPosY -= 2;
                                posY -= 4;
                            }
                            #endregion

                            #endregion
                            //Rival Bottom
                            if (currentPosX == 112 && currentPosY == 66)
                            {
                                currentPosY -= 2;
                                posY -= 4;
                            }
                            //Border Bottom
                            if (currentPosY > 106)
                            {
                                currentPosY -= 2;
                                posY -= 4;
                            }
                            DEMOMapActive(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                            //Catching Field    
                            encounterChance = rand.Next(0, 100);
                            if (currentPosX <= 177 && currentPosX >= 107 && currentPosY >= 88 && currentPosY <= 98 && encounterChance > 98)
                            {
                                //currentPosY -= 2;
                                //posY -= 4;
                                SFX.Battle();
                                ASCII.BattleIntroFLASH(player, direction, currentPosX, currentPosY, ASCII.DEMOMap);
                                ASCII.FullBattleWild(player, Monster.monsters, 3, 5, gbText, gbBackground, navPlayerMenu);
                                DEMOMapStatic(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                                SFX.Route2();
                            }                            
                        }
                        else
                        {
                            direction += 1;
                            if (direction < 5)
                            {
                                direction = 5;
                            }
                            if (direction == 7)
                            {
                                direction -= 2;
                            }
                            DEMOMapStatic(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        if (direction == 1)
                        {
                            currentPosX -= 5;
                            posX -= 10;
                            //Boundaries
                            #region Boundaries
                            //167,56
                            //+3,-11-16
                            //+4,-1-5
                            //Player House & PokeCenter Right
                            if (currentPosX == 187 && currentPosY >= 46 && currentPosY <= 54 || currentPosX == 182 && currentPosY == 44 || currentPosX == 177 && currentPosY == 42 || currentPosX == 182 && currentPosY >= 24 && currentPosY <= 34)
                            {
                                currentPosX += 5;
                                posX += 10;
                            }
                            //Rival House & PokeMart Right
                            if (currentPosX == 122 && currentPosY >= 46 && currentPosY <= 54 || currentPosX == 117 && currentPosY == 44 || currentPosX == 112 && currentPosY == 42 || currentPosX == 122 && currentPosY >= 24 && currentPosY <= 34)
                            {
                                currentPosX += 5;
                                posX += 10;
                            }
                            //Rival Left
                            if (currentPosX == 112 && currentPosY >= 66 && currentPosY <= 68)
                            {
                                currentPosX += 5;
                                posX += 10;
                            }
                            #endregion
                            //Border Left
                            if (currentPosX < 60)
                            {
                                currentPosX += 5;
                                posX += 10;
                            }
                            DEMOMapActive(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                            //Catching Field    
                            encounterChance = rand.Next(0, 100);
                            if (currentPosX <= 177 && currentPosX >= 107 && currentPosY >= 88 && currentPosY <= 98 && encounterChance > 98)
                            {
                                //currentPosX += 5;
                                //posX += 10;
                                SFX.Battle();
                                ASCII.BattleIntroFLASH(player, direction, currentPosX, currentPosY, ASCII.DEMOMap);
                                ASCII.FullBattleWild(player, Monster.monsters, 3, 5, gbText, gbBackground, navPlayerMenu);
                                DEMOMapStatic(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                                SFX.Route2();
                            }
                        }
                        else
                        {
                            direction = 1;
                            DEMOMapStatic(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        if (direction == 2)
                        {
                            currentPosX += 5;
                            posX += 10;
                            //Boundaries
                            #region Boundaries
                            //167,56
                            //-1,-11-16
                            //-14,-1-5
                            //Player House & PokeCenter Left
                            if (currentPosX == 162 && currentPosY >= 46 && currentPosY <= 54 || currentPosX == 167 && currentPosY == 44 || currentPosX == 172 && currentPosY == 42 || currentPosX == 162 && currentPosY >= 24 && currentPosY <= 34)
                            {
                                currentPosX -= 5;
                                posX -= 10;
                            }
                            //Rival House & PokeMart Left
                            if (currentPosX == 97 && currentPosY >= 46 && currentPosY <= 54 || currentPosX == 102 && currentPosY == 44 || currentPosX == 107 && currentPosY == 42 || currentPosX == 102 && currentPosY >= 24 && currentPosY <= 34)
                            {
                                currentPosX -= 5;
                                posX -= 10;
                            }
                            #endregion
                            //Rival Right
                            if (currentPosX == 112 && currentPosY >= 66 && currentPosY <= 68)
                            {
                                currentPosX -= 5;
                                posX -= 10;
                            }
                            //Border Right
                            if (currentPosX > 225)
                            {
                                currentPosX -= 5;
                                posX -= 10;
                            }
                            DEMOMapActive(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                            //Catching Field    
                            encounterChance = rand.Next(0, 100);
                            if (currentPosX <= 177 && currentPosX >= 107 && currentPosY >= 88 && currentPosY <= 98 && encounterChance > 95)
                            {
                                //currentPosX -= 5;
                                //posX -= 10;
                                SFX.Battle();
                                ASCII.BattleIntroFLASH(player, direction, currentPosX, currentPosY, ASCII.DEMOMap);
                                ASCII.FullBattleWild(player, Monster.monsters, 3, 5, gbText, gbBackground, navPlayerMenu);
                                DEMOMapStatic(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                                SFX.Route2();
                            }                            
                        }
                        else
                        {
                            direction = 2;
                            DEMOMapStatic(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.M:
                        Player_Menus.PlayerMenu(player, navPlayerMenu, gbText, gbBackground);
                        DEMOMapStatic(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        reloadTestMap = true;
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.K:

                        string battle = "Do you want to battle?";
                        if (currentPosX == 117 && currentPosY == 68 && direction == 1 || 
                            currentPosX == 107 && currentPosY == 68 && direction == 2 ||
                            currentPosX == 112 && currentPosY == 70 && direction == 3 ||
                            currentPosX == 112 && currentPosY == 70 && direction == 4 ||
                            currentPosX == 112 && currentPosY == 64 && direction == 5 ||
                            currentPosX == 112 && currentPosY == 64 && direction == 6)
                        {
                            bool reloadBattleFAINT = false;
                            int menuPosY = 22;
                            int centerX = currentPosX - posX;
                            int centerY = currentPosY - posY;
                            ASCII.DisplayNPC("trainerFemale", direction, centerX - 30, centerY, gbText, gbBackground);
                            ASCII.PlayerMovementStatic(player, direction, gbText, gbBackground);

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
                                            //SFX.RivalBattle();
                                            SFX.LeagueBattleRE();
                                            //SFX.LeagueBattle();
                                            ASCII.ScrollMessage($"Mysterious Man: At last! We finally meet!", 25, 1500, gbText, gbBackground);
                                            ASCII.ScrollMessage($"Mysterious Man: I am {npc.Name.ToUpper()}! The PokeFraud League Champion!", 25, 1500, gbText, gbBackground);
                                            ASCII.ScrollMessage($"{npc.Name.ToUpper()}: I've been hearing stories about you..", 25, 1500, gbText, gbBackground);
                                            ASCII.ScrollMessage($"{npc.Name.ToUpper()}: The rutheless trainer wreaking havoc across the region.", 25, 1500, gbText, gbBackground);
                                            ASCII.ScrollMessage($"{npc.Name.ToUpper()}: I was looking forward to the day I'd meet such a worthy opponent.", 25, 1500, gbText, gbBackground);
                                            ASCII.ScrollMessage($"{npc.Name.ToUpper()}: One that would reignite the dying flame of my spirit to battle.", 25, 1500, gbText, gbBackground);
                                            ASCII.ScrollMessage($"{npc.Name.ToUpper()}: But now is not the time for small talk.", 25, 1000, gbText, gbBackground);
                                            ASCII.ScrollMessage($"{npc.Name.ToUpper()}: Let us have a battle to be remembered!", 25, 1500, gbText, gbBackground);
                                            ASCII.BattleIntroFLASH(player, direction, currentPosX, currentPosY, ASCII.DEMOMap);
                                            System.Threading.Thread.Sleep(3000);
                                            ASCII.FullBattleNPC(player, npc, gbText, gbBackground, navPlayerMenu);
                                            SFX.sp.Stop();
                                            SFX.Route2();
                                            reloadBattleFAINT = false;
                                        }
                                        else if (menuPosY == 23)
                                        {
                                            DEMOMapStatic(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                                            reloadBattleFAINT = false;
                                        }
                                        break;
                                    case ConsoleKey.Backspace:
                                    case ConsoleKey.O:
                                        DEMOMapStatic(player, npc, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
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

        #endregion

        #region DEMO Player House

        public static void DEMOPlayerHouseActive(Player player, int currentPosX, int currentPosY, int direction, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetBufferSize(2000, 2000);
            ASCII.GameMap(ASCII.playerHouse, currentPosX, currentPosY, gbText, gbBackground);
            ASCII.PlayerMovement(player, direction, gbText, gbBackground);
        }

        public static void DEMOPlayerHouseStatic(Player player, int currentPosX, int currentPosY, int direction, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetBufferSize(2000, 2000);
            ASCII.GameMap(ASCII.playerHouse, currentPosX, currentPosY, gbText, gbBackground);
            ASCII.PlayerMovementStatic(player, direction, gbText, gbBackground);
        }

        public static void DEMOPlayerHouse(Player player, int currentPosX, int currentPosY, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;
            int direction = 4;
            //(30,17)
            DEMOPlayerHouseStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
            do
            {
                
                navPlayerMenu = Console.ReadKey().Key;

                switch (navPlayerMenu)
                {

                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (direction == 3 || direction == 4)
                        {
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
                            DEMOPlayerHouseActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        else
                        {
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
                            DEMOPlayerHouseStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if (direction == 5 || direction == 6)
                        {
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
                            DEMOPlayerHouseActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                            if (currentPosX == 30 && currentPosY == 19)
                            {
                                currentPosY -= 2;
                                reloadTestMap = false;
                            }
                            if (currentPosX != 30 && currentPosY == 19)
                            {
                                currentPosY -= 2;                                
                                reloadTestMap = true;
                            }
                        }
                        else
                        {
                            direction += 1;
                            if (direction < 5)
                            {
                                direction = 5;
                            }
                            if (direction == 7)
                            {
                                direction -= 2;
                            }
                            DEMOPlayerHouseStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                            reloadTestMap = true;
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        if (direction == 1)
                        {
                            direction = 1;
                            currentPosX -= 5;
                            if (currentPosX == 45 && currentPosY == 3)
                            {
                                DEMOPlayerHouseActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
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
                            DEMOPlayerHouseActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        else
                        {
                            direction = 1;
                            DEMOPlayerHouseStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                            reloadTestMap = true;
                        }
                        break;

                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        if (direction == 2)
                        {
                            currentPosX += 5;
                            if (currentPosX > 55)
                            {
                                currentPosX -= 5;
                            }
                            DEMOPlayerHouseActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        else
                        {
                            direction = 2;
                            DEMOPlayerHouseStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                            reloadTestMap = true;
                        }
                        reloadTestMap = true;
                        break;
                    case ConsoleKey.M:
                        Player_Menus.PlayerMenu(player, navPlayerMenu, gbText, gbBackground);
                        DEMOPlayerHouseStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        reloadTestMap = true;
                        break;
                    default:
                        reloadTestMap = true;
                        break;
                }
            } while (reloadTestMap);
        }

        #endregion

        #region DEMO Player Room

        public static void DEMOPlayerRoomActive(Player player, int currentPosX, int currentPosY, int direction, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetBufferSize(2000, 2000);
            ASCII.GameMap(ASCII.playerRoom, currentPosX, currentPosY, gbText, gbBackground);
            ASCII.PlayerMovement(player, direction, gbText, gbBackground);
        }

        public static void DEMOPlayerRoomStatic(Player player, int currentPosX, int currentPosY, int direction, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetBufferSize(2000, 2000);
            ASCII.GameMap(ASCII.playerRoom, currentPosX, currentPosY, gbText, gbBackground);
            ASCII.PlayerMovementStatic(player, direction, gbText, gbBackground);
        }

        public static void DEMOPlayerRoom(Player player, int currentPosX, int currentPosY, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;
            int direction = 1;
            //(45,3)
            DEMOPlayerRoomActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
            do
            {                
                //ASCII.PlayerForward(gbText, gbBackground);
                navPlayerMenu = Console.ReadKey().Key;

                switch (navPlayerMenu)
                {

                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (direction == 3 || direction == 4)
                        {
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
                            DEMOPlayerRoomActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        else
                        {
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
                            DEMOPlayerRoomStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if (direction == 5 || direction == 6)
                        {
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
                                //reloadTestMap = true;
                            }
                            DEMOPlayerRoomActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        else
                        {
                            direction += 1;
                            if (direction < 5)
                            {
                                direction = 5;
                            }
                            if (direction == 7)
                            {
                                direction -= 2;
                            }
                            DEMOPlayerRoomStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        if (direction == 1)
                        {
                            currentPosX -= 5;
                            if (currentPosX < 5)
                            {
                                currentPosX += 5;
                            }
                            DEMOPlayerRoomActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        else
                        {
                            direction = 1;
                            DEMOPlayerRoomStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        if (direction == 2)
                        {
                            currentPosX += 5;
                            if (currentPosX > 55)
                            {
                                currentPosX -= 5;

                                reloadTestMap = true;
                            }
                            DEMOPlayerRoomActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                            if (currentPosX == 50 && currentPosY == 3)
                            {
                                currentPosX -= 5;
                                reloadTestMap = false;
                            }                                                        
                        }
                        else
                        {
                            direction = 2;
                            reloadTestMap = true;
                            DEMOPlayerRoomStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        break;
                    case ConsoleKey.M:
                        Player_Menus.PlayerMenu(player, navPlayerMenu, gbText, gbBackground);
                        DEMOPlayerRoomStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        reloadTestMap = true;
                        break;
                    default:
                        reloadTestMap = true;
                        break;
                }
            } while (reloadTestMap);
        }

        #endregion

        #region DEMO Rival House

        public static void DEMORivalHouseActive(Player player, int currentPosX, int currentPosY, int direction, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetBufferSize(2000, 2000);
            ASCII.GameMap(ASCII.rivalHouse, currentPosX, currentPosY, gbText, gbBackground);
            ASCII.PlayerMovement(player, direction, gbText, gbBackground);
        }

        public static void DEMORivalHouseStatic(Player player, int currentPosX, int currentPosY, int direction, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetBufferSize(2000, 2000);
            ASCII.GameMap(ASCII.rivalHouse, currentPosX, currentPosY, gbText, gbBackground);
            ASCII.PlayerMovementStatic(player, direction, gbText, gbBackground);
        }

        public static void DEMORivalHouse(Player player, int currentPosX, int currentPosY, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;
            int direction = 4;
            //(30,17)
            DEMORivalHouseActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
            do
            {
                
                navPlayerMenu = Console.ReadKey().Key;

                switch (navPlayerMenu)
                {

                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (direction == 3 || direction == 4)
                        {
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
                            DEMORivalHouseActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        else
                        {
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
                            DEMORivalHouseStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if (direction == 5 || direction == 6)
                        {
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
                            if (currentPosX != 30 && currentPosY > 17)
                            {
                                currentPosY -= 2;
                                reloadTestMap = true;
                            }
                            DEMORivalHouseActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                            if (currentPosX == 30 && currentPosY > 17)
                            {
                                currentPosY -= 2;
                                reloadTestMap = false;
                            }                            
                        }
                        else
                        {
                            direction += 1;
                            if (direction < 5)
                            {
                                direction = 5;
                            }
                            if (direction == 7)
                            {
                                direction -= 2;
                            }
                            reloadTestMap = true;
                            DEMORivalHouseStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        if (direction == 1)
                        {
                            currentPosX -= 5;
                            if (currentPosX < 5)
                            {
                                currentPosX += 5;
                            }
                            DEMORivalHouseActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        else
                        {
                            direction = 1;
                            DEMORivalHouseStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        if (direction == 2)
                        {
                            currentPosX += 5;
                            if (currentPosX > 55)
                            {
                                currentPosX -= 5;
                                reloadTestMap = true;
                            }
                            DEMORivalHouseActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                            if (currentPosX == 15 && currentPosY == 3)
                            {
                                DEMORivalRoom(player, 15, 3, navPlayerMenu, gbText, gbBackground);
                                currentPosX -= 5;
                                direction = 1;
                                reloadTestMap = true;
                                DEMORivalHouseActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                            }                            
                        }
                        else
                        {
                            direction = 2;
                            DEMORivalHouseStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        reloadTestMap = true;
                        break;
                    case ConsoleKey.M:
                        Player_Menus.PlayerMenu(player, navPlayerMenu, gbText, gbBackground);
                        DEMORivalHouseStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        reloadTestMap = true;
                        break;
                    default:
                        reloadTestMap = true;
                        break;
                }
            } while (reloadTestMap);
        }

        #endregion

        #region DEMO Rival Room

        public static void DEMORivalRoomActive(Player player, int currentPosX, int currentPosY, int direction, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetBufferSize(2000, 2000);
            ASCII.GameMap(ASCII.rivalRoom, currentPosX, currentPosY, gbText, gbBackground);
            ASCII.PlayerMovement(player, direction, gbText, gbBackground);
        }

        public static void DEMORivalRoomStatic(Player player, int currentPosX, int currentPosY, int direction, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetBufferSize(2000, 2000);
            ASCII.GameMap(ASCII.rivalRoom, currentPosX, currentPosY, gbText, gbBackground);
            ASCII.PlayerMovementStatic(player, direction, gbText, gbBackground);
        }

        public static void DEMORivalRoom(Player player, int currentPosX, int currentPosY, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;
            int direction = 2;
            //(15,3)
            DEMORivalRoomActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
            do
            {

                navPlayerMenu = Console.ReadKey().Key;

                switch (navPlayerMenu)
                {

                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (direction == 3 || direction == 4)
                        {
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
                            DEMORivalRoomActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        else
                        {
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
                            DEMORivalRoomStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if (direction == 5 || direction == 6)
                        {
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
                            DEMORivalRoomActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        else
                        {
                            direction += 1;
                            if (direction < 5)
                            {
                                direction = 5;
                            }
                            if (direction == 7)
                            {
                                direction -= 2;
                            }
                            DEMORivalRoomStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        if (direction == 1)
                        {
                            currentPosX -= 5;
                            if (currentPosX < 5)
                            {
                                currentPosX += 5;
                                reloadTestMap = true;
                            }
                            DEMORivalRoomActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                            if (currentPosX == 10 && currentPosY == 3)
                            {
                                currentPosX += 5;
                                reloadTestMap = false;
                            }                            
                        }
                        else
                        {
                            direction = 1;
                            reloadTestMap = true;
                            DEMORivalRoomStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        break;

                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        if (direction == 2)
                        {
                            currentPosX += 5;
                            if (currentPosX > 55)
                            {
                                currentPosX -= 5;
                                reloadTestMap = true;
                            }
                            DEMORivalRoomActive(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        else
                        {
                            direction = 2;
                            DEMORivalRoomStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        }
                        reloadTestMap = true;
                        break;
                    case ConsoleKey.M:
                        Player_Menus.PlayerMenu(player, navPlayerMenu, gbText, gbBackground);
                        DEMORivalRoomStatic(player, currentPosX, currentPosY, direction, gbText, gbBackground);
                        reloadTestMap = true;
                        break;
                    default:
                        reloadTestMap = true;
                        break;
                }
            } while (reloadTestMap);
        }

        #endregion

        #region DEMO PokeCenter

        public static void DEMOPokeCenterActive(Player player, int currentPosX, int currentPosY, int direction, int posX, int posY, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetBufferSize(2000, 2000);
            //switch back to playerHouse
            ASCII.GameMap(ASCII.pokeCenter, currentPosX, currentPosY, gbText, gbBackground);
            ASCII.CharacterPokeCenter((currentPosX - posX), (currentPosY - posY), gbText, gbBackground);
            ASCII.PlayerMovement(player, direction, gbText, gbBackground);
        }

        public static void DEMOPokeCenterStatic(Player player, int currentPosX, int currentPosY, int direction, int posX, int posY, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetBufferSize(2000, 2000);
            //switch back to playerHouse
            ASCII.GameMap(ASCII.pokeCenter, currentPosX, currentPosY, gbText, gbBackground);
            ASCII.CharacterPokeCenter((currentPosX - posX), (currentPosY - posY), gbText, gbBackground);
            ASCII.PlayerMovementStatic(player, direction, gbText, gbBackground);
        }

        public static void DEMOPokeCenter(Player player, int currentPosX, int currentPosY, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;
            int posX = -12;
            int posY = 21;
            int direction = 4;
            //(30,17)
            DEMOPokeCenterActive(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
            do
            {
                
                navPlayerMenu = Console.ReadKey().Key;

                switch (navPlayerMenu)
                {

                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (direction == 3 || direction == 4)
                        {
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
                            if (currentPosY == 5 && currentPosX >= 20 && currentPosX <= 40)
                            {
                                currentPosY += 2;
                                posY += 4;
                            }
                            if (currentPosY == 3 && currentPosX >= 45 && currentPosX <= 55)
                            {
                                currentPosY += 2;
                                posY += 4;
                            }
                            if (currentPosY < 3)
                            {
                                currentPosY += 2;
                                posY += 4;
                            }
                            DEMOPokeCenterActive(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        }
                        else
                        {
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
                            DEMOPokeCenterStatic(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if (direction == 5 || direction == 6)
                        {
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
                            if (currentPosX != 30 && currentPosY > 17)
                            {
                                currentPosY -= 2;
                                posY -= 4;
                                reloadTestMap = true;
                            }
                            DEMOPokeCenterActive(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                            if (currentPosX == 30 && currentPosY > 17)
                            {
                                currentPosY -= 2;
                                posY -= 4;
                                reloadTestMap = false;
                            }                            
                        }
                        else
                        {
                            direction += 1;
                            if (direction < 5)
                            {
                                direction = 5;
                            }
                            if (direction == 7)
                            {
                                direction -= 2;
                            }
                            reloadTestMap = true;
                            DEMOPokeCenterStatic(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        if (direction == 1)
                        {
                            currentPosX -= 5;
                            posX -= 10;
                            if (currentPosY == 5 && currentPosX == 40)
                            {
                                currentPosX += 5;
                                posX += 10;
                            }
                            if (currentPosX < 5)
                            {
                                currentPosX += 5;
                                posX += 10;
                            }
                            DEMOPokeCenterActive(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        }
                        else
                        {
                            direction = 1;
                            DEMOPokeCenterStatic(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        if (direction == 2)
                        {
                            currentPosX += 5;
                            posX += 10;
                            if (currentPosY >= 3 && currentPosY <= 5 && currentPosX == 20)
                            {
                                currentPosX -= 5;
                                posX -= 10;
                            }
                            if (currentPosX > 55)
                            {
                                currentPosX -= 5;
                                posX -= 10;
                            }
                            DEMOPokeCenterActive(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        }
                        else
                        {
                            direction = 2;
                            DEMOPokeCenterStatic(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        }
                        reloadTestMap = true;
                        break;
                    case ConsoleKey.M:
                        Player_Menus.PlayerMenu(player, navPlayerMenu, gbText, gbBackground);
                        DEMOPokeCenterStatic(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        reloadTestMap = true;
                        break;
                    case ConsoleKey.Enter:
                    case ConsoleKey.K:

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
                                    case ConsoleKey.UpArrow:
                                    case ConsoleKey.W:

                                        Console.SetCursorPosition(61, chooseY);
                                        Console.Write("   ");
                                        chooseY -= 1;
                                        if (chooseY < 22)
                                        {
                                            chooseY += 1;
                                        }
                                        reloadBattleFAINT = true;
                                        break;
                                    case ConsoleKey.DownArrow:
                                    case ConsoleKey.S:

                                        Console.SetCursorPosition(61, chooseY);
                                        Console.Write("   ");
                                        chooseY += 1;
                                        if (chooseY > 23)
                                        {
                                            chooseY -= 1;
                                        }
                                        reloadBattleFAINT = true;
                                        break;
                                    case ConsoleKey.Enter:
                                    case ConsoleKey.K:

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
                                    case ConsoleKey.Backspace:
                                    case ConsoleKey.O:

                                        ASCII.ScrollMessage(message2, 50, 1500, gbText, gbBackground);
                                        reloadBattleFAINT = false;
                                        break;
                                    default:
                                        reloadBattleFAINT = true;
                                        break;
                                }
                            } while (reloadBattleFAINT);
                        }
                        DEMOPokeCenterStatic(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        reloadTestMap = true;
                        break;
                    default:
                        reloadTestMap = true;
                        break;
                }
            } while (reloadTestMap);
        }

        #endregion

        //TODO Create A Session Based Shopping Cart For the PokeMart that allows the user to browse items and add them to their cart while keeping track of the like item total.
        //Then once the user has finished browsing, they can walk up to the clerk and proceed to checkout.

        #region DEMO PokeMart

        public static void DEMOPokeMartActive(Player player, int currentPosX, int currentPosY, int direction, int posX, int posY, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetBufferSize(2000, 2000);
            //switch back to playerHouse
            ASCII.GameMap(ASCII.pokeMart, currentPosX, currentPosY, gbText, gbBackground);
            ASCII.CharacterMerchant((currentPosX - posX), (currentPosY - posY), gbText, gbBackground);
            ASCII.PlayerMovement(player, direction, gbText, gbBackground);
        }

        public static void DEMOPokeMartStatic(Player player, int currentPosX, int currentPosY, int direction, int posX, int posY, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Console.SetBufferSize(2000, 2000);
            //switch back to playerHouse
            ASCII.GameMap(ASCII.pokeMart, currentPosX, currentPosY, gbText, gbBackground);
            ASCII.CharacterMerchant((currentPosX - posX), (currentPosY - posY), gbText, gbBackground);
            ASCII.PlayerMovementStatic(player, direction, gbText, gbBackground);
        }

        public static void DEMOPokeMart(Player player, int currentPosX, int currentPosY, ConsoleKey navPlayerMenu, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            bool reloadTestMap = false;
            int posX = -27;
            int posY = 21;
            int direction = 4;
            //Start Coordinates: (15,17)
            DEMOPokeMartStatic(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
            do
            {
                
                navPlayerMenu = Console.ReadKey().Key;

                switch (navPlayerMenu)
                {

                    case ConsoleKey.UpArrow:
                    case ConsoleKey.W:
                        if (direction == 3 || direction == 4)
                        {
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
                            //Boundaries
                            #region Boundaries
                            if (currentPosY == 5)
                            {
                                if (currentPosX >= 5 && currentPosX <= 20 || currentPosX == 40 || currentPosX == 45 || currentPosX == 55)
                                {
                                    currentPosY += 2;
                                    posY += 4;
                                }
                            }
                            if (currentPosY == 13)
                            {
                                if (currentPosX == 40 || currentPosX == 45 || currentPosX == 55)
                                {
                                    currentPosY += 2;
                                    posY += 4;
                                }
                            }
                            #endregion
                            //Border Top
                            if (currentPosY < 3)
                            {
                                currentPosY += 2;
                                posY += 4;
                            }
                            DEMOPokeMartActive(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        }
                        else
                        {
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
                            DEMOPokeMartStatic(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S:
                        if (direction == 5 || direction == 6)
                        {
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
                            //Boundaries
                            #region Boundaries
                            if (currentPosY == 11)
                            {
                                if (currentPosX == 40 || currentPosX == 45 || currentPosX == 55)
                                {
                                    currentPosY -= 2;
                                    posY -= 4;
                                }
                            }
                            #endregion
                            //Border Bottom
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
                            DEMOPokeMartActive(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        }
                        else
                        {
                            direction += 1;
                            if (direction < 5)
                            {
                                direction = 5;
                            }
                            if (direction == 7)
                            {
                                direction -= 2;
                            }
                            reloadTestMap = true;
                            DEMOPokeMartStatic(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A:
                        if (direction == 1)
                        {
                            currentPosX -= 5;
                            posX -= 10;
                            //Boundaries
                            #region Boundaries
                            if (currentPosX == 20 || currentPosX == 45)
                            {
                                if (currentPosY >= 3 && currentPosY <= 5 || currentPosY >= 11 && currentPosY <= 13 && currentPosX != 20)
                                {
                                    currentPosX += 5;
                                    posX += 10;
                                }
                            }
                            #endregion
                            //Border Left
                            if (currentPosX < 5)
                            {
                                currentPosX += 5;
                                posX += 10;
                            }
                            DEMOPokeMartActive(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        }
                        else
                        {
                            direction = 1;
                            DEMOPokeMartStatic(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        }
                        reloadTestMap = true;
                        break;

                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D:
                        if (direction == 2)
                        {
                            currentPosX += 5;
                            posX += 10;
                            //Boundaries
                            #region Boundaries
                            if (currentPosX == 40 || currentPosX == 55)
                            {
                                if (currentPosY >= 3 && currentPosY <= 5 || currentPosY >= 11 && currentPosY <= 13)
                                {
                                    currentPosX -= 5;
                                    posX -= 10;
                                }
                            }
                            #endregion
                            //Border Right
                            if (currentPosX > 55)
                            {
                                currentPosX -= 5;
                                posX -= 10;
                            }
                            DEMOPokeMartActive(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        }
                        else
                        {
                            direction = 2;
                            DEMOPokeMartStatic(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        }
                        reloadTestMap = true;
                        break;
                    case ConsoleKey.M:
                        Player_Menus.PlayerMenu(player, navPlayerMenu, gbText, gbBackground);
                        DEMOPokeMartStatic(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        reloadTestMap = true;
                        break;
                    case ConsoleKey.Enter:
                        Player_Menus.PokeMartVendor(player, currentPosX, currentPosY, posX, posY, direction, navPlayerMenu, gbText, gbBackground);
                        DEMOPokeMartStatic(player, currentPosX, currentPosY, direction, posX, posY, gbText, gbBackground);
                        reloadTestMap = true;
                        break;
                    default:
                        reloadTestMap = true;
                        break;
                }
            } while (reloadTestMap);
        }

        #endregion

        #endregion
    }
}
