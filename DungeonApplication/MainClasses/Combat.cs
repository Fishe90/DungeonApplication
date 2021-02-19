using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses
{
    public class Combat
    {
        #region CalcDamage PlayerVSMonster

        public static void PlayerVSMonsterHitZero(Player attacker, Monster defender, Monster_Moves move, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Random rand = new Random();
            string playerHit = $@"{attacker.MonsterEquipped.Name} used {move.Name}!";
            string playerHitZero = $@"{move.Name} doesn't affect the wild {defender.Name}!";

            //Console.ForegroundColor = GBText;
            //Console.BackgroundColor = GBBackground;
            System.Threading.Thread.Sleep(1000);
            ASCII.ScrollMessage(playerHit, 50, 1000, GBText, GBBackground);
            CalcDamageMonster(defender, 0, GBText, GBBackground);
            ASCII.ScrollMessage(playerHitZero, 50, 2000, GBText, GBBackground);
            move.Uses -= 1;
        }

        public static void PlayerVSMonsterHitLow(Player attacker, Monster defender, Monster_Moves move, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Random rand = new Random();
            string playerHit = $@"{attacker.MonsterEquipped.Name} used {move.Name}!";
            string playerHitLow = $@"It's not very effective!";
            int damageDealt = ((((((2 * attacker.MonsterEquipped.Lv) / 5) + 2) * move.Damage) / 50) + 2) / 2;

            //Console.ForegroundColor = GBText;
            //Console.BackgroundColor = GBBackground;
            System.Threading.Thread.Sleep(1000);
            ASCII.ScrollMessage(playerHit, 50, 1000, GBText, GBBackground);
            CalcDamageMonster(defender, damageDealt, GBText, GBBackground);
            ASCII.ScrollMessage(playerHitLow, 50, 2000, GBText, GBBackground);
            move.Uses -= 1;
        }

        public static void PlayerVSMonsterHitStan(Player attacker, Monster defender, Monster_Moves move, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Random rand = new Random();
            string playerHit = $@"{attacker.MonsterEquipped.Name} used {move.Name}!";
            int damageDealt = ((((((2 * attacker.MonsterEquipped.Lv) / 5) + 2) * move.Damage) / 50) + 2);
                        
            //Console.ForegroundColor = GBText;
            //Console.BackgroundColor = GBBackground;
            System.Threading.Thread.Sleep(1000);
            ASCII.ScrollMessage(playerHit, 50, 1000, GBText, GBBackground);
            CalcDamageMonster(defender, damageDealt, GBText, GBBackground);
            move.Uses -= 1;
        }

        public static void PlayerVSMonsterHitSuper(Player attacker, Monster defender, Monster_Moves move, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Random rand = new Random();
            string playerHit = $@"{attacker.MonsterEquipped.Name} used {move.Name}!";
            string playerHitSuper = $@"It's super effective!";
            int damageDealt = ((((((2 * attacker.MonsterEquipped.Lv) / 5) + 2) * move.Damage) / 50) + 2) * 2;

            //Console.ForegroundColor = GBText;
            //Console.BackgroundColor = GBBackground;
            System.Threading.Thread.Sleep(1000);
            ASCII.ScrollMessage(playerHit, 50, 1000, GBText, GBBackground);
            CalcDamageMonster(defender, damageDealt, GBText, GBBackground);
            ASCII.ScrollMessage(playerHitSuper, 50, 2000, GBText, GBBackground);
            move.Uses -= 1;
        }
        #endregion

        #region CalcDamage MonsterVSPlayer
        public static void MonsterVSPlayerHitZero(Monster attacker, Player defender, Monster_Moves move, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Random rand = new Random();
            string playerHit = $@"{attacker.Name} used {move.Name}!";
            string playerHitZero = $@"{move.Name} doesn't affect {defender.MonsterEquipped.Name}!";

            //Console.ForegroundColor = GBText;
            //Console.BackgroundColor = GBBackground;
            System.Threading.Thread.Sleep(1000);
            ASCII.ScrollMessage(playerHit, 50, 1000, GBText, GBBackground);
            CalcDamageAttacker(defender, 0, GBText, GBBackground);
            ASCII.ScrollMessage(playerHitZero, 50, 1000, GBText, GBBackground);            
            move.Uses -= 1;
        }

        public static void MonsterVSPlayerHitLow(Monster attacker, Player defender, Monster_Moves move, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Random rand = new Random();
            string playerHit = $@"{attacker.Name} used {move.Name}!";
            string playerHitLow = $@"It's not very effective!";
            int damageDealt = ((((((2 * attacker.Lv) / 5) + 2) * move.Damage) / 50) + 2) / 2;

            //Console.ForegroundColor = GBText;
            //Console.BackgroundColor = GBBackground;
            System.Threading.Thread.Sleep(1000);
            ASCII.ScrollMessage(playerHit, 50, 1000, GBText, GBBackground);
            CalcDamageAttacker(defender, damageDealt, GBText, GBBackground);
            ASCII.ScrollMessage(playerHitLow, 50, 2000, GBText, GBBackground);
            move.Uses -= 1;
        }

        public static void MonsterVSPlayerHitStan(Monster attacker, Player defender, Monster_Moves move, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Random rand = new Random();
            string playerHit = $@"{attacker.Name} used {move.Name}!";
            int damageDealt = ((((((2 * attacker.Lv) / 5) + 2) * move.Damage) / 50) + 2);

            //Console.ForegroundColor = GBText;
            //Console.BackgroundColor = GBBackground;
            System.Threading.Thread.Sleep(1000);
            ASCII.ScrollMessage(playerHit, 50, 1000, GBText, GBBackground);
            CalcDamageAttacker(defender, damageDealt, GBText, GBBackground);
            move.Uses -= 1;
        }

        public static void MonsterVSPlayerHitSuper(Monster attacker, Player defender, Monster_Moves move, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Random rand = new Random();
            string playerHit = $@"{attacker.Name} used {move.Name}!";
            string playerHitSuper = $@"It's super effective!";
            int damageDealt = ((((((2 * attacker.Lv) / 5) + 2) * move.Damage) / 50) + 2) * 2;

            //Console.ForegroundColor = GBText;
            //Console.BackgroundColor = GBBackground;
            System.Threading.Thread.Sleep(1000);
            ASCII.ScrollMessage(playerHit, 50, 1000, GBText, GBBackground);
            CalcDamageAttacker(defender, damageDealt, GBText, GBBackground);
            ASCII.ScrollMessage(playerHitSuper, 50, 2000, GBText, GBBackground);
            move.Uses -= 1;
        }

        #endregion

        #region CalcDamage Display Player VS Monster

        public static void CalcDamageMonster(Monster monster, int damage, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            int currentHealth = monster.Health;
            System.Threading.Thread.Sleep(1000);
            currentHealth -= damage;
            while (currentHealth < monster.Health)
            {
                monster.Health -= 1;
                ASCII.HealthBar(monster, 17, 4);
                if (monster.Health <= 0 && currentHealth <= 0)
                {
                    monster.Health = 0;
                    currentHealth = 0;
                }
                System.Threading.Thread.Sleep(200);
            }
        }

        public static void CalcDamageAttacker(Player attacker, int damage, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            int currentHealth = attacker.MonsterEquipped.Health;
            System.Threading.Thread.Sleep(1000);
            currentHealth -= damage;
            while (currentHealth < attacker.MonsterEquipped.Health)
            {
                attacker.MonsterEquipped.Health -= 1;
                ASCII.HealthBar(attacker.MonsterEquipped, 43, 15);
                if (attacker.MonsterEquipped.Health <= 0 && currentHealth <= 0)
                {
                    attacker.MonsterEquipped.Health = 0;
                    currentHealth = 0;
                }
                System.Threading.Thread.Sleep(200);
            }
        }

        #endregion

        #region Combat Functionality Player VS Monster 

        public static void FUNCatchSort(Player player, Monster monsterCaught, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            int currentID = 1;
            bool reloadCatchSortPC = false;

            monsterCaught.IsCaught = true;
            if (player.Party.Slot2.Type == Monster_Race.NONE)
            {
                player.Party.Slot2.MaxHealth = monsterCaught.MaxHealth;
                player.Party.Slot2.Health = monsterCaught.Health;
                player.Party.Slot2.MaxExp = monsterCaught.MaxExp;
                player.Party.Slot2.Exp = monsterCaught.Exp;
                player.Party.Slot2.Lv = monsterCaught.Lv;
                player.Party.Slot2.SlotNum = currentID;
                player.Party.Slot2.PokeIndex = monsterCaught.PokeIndex;
                player.Party.Slot2.IsCaught = true;
                player.Party.Slot2.Type = monsterCaught.Type;
                player.Party.Slot2.Description = monsterCaught.Description;
                player.Party.Slot2.ASCIIAttacker = monsterCaught.ASCIIAttacker;
                player.Party.Slot2.ASCIIDefender = monsterCaught.ASCIIDefender;
                player.Party.Slot2.ASCIIPokedex = monsterCaught.ASCIIPokedex;
                player.Party.Slot2.EquippedMoves = monsterCaught.EquippedMoves;
                player.Party.Slot2.Name = monsterCaught.Name;
                player.Party.Slot2.DefaultName = monsterCaught.DefaultName;
                player.Party.Slot2.IsBoosted = false;
                player.Party.Slot2.Gender = monsterCaught.Gender;
            }
            else if (player.Party.Slot3.Type == Monster_Race.NONE)
            {
                player.Party.Slot3.MaxHealth = monsterCaught.MaxHealth;
                player.Party.Slot3.Health = monsterCaught.Health;
                player.Party.Slot3.MaxExp = monsterCaught.MaxExp;
                player.Party.Slot3.Exp = monsterCaught.Exp;
                player.Party.Slot3.Lv = monsterCaught.Lv;
                player.Party.Slot3.SlotNum = currentID;
                player.Party.Slot3.PokeIndex = monsterCaught.PokeIndex;
                player.Party.Slot3.IsCaught = true;
                player.Party.Slot3.Type = monsterCaught.Type;
                player.Party.Slot3.Description = monsterCaught.Description;
                player.Party.Slot3.ASCIIAttacker = monsterCaught.ASCIIAttacker;
                player.Party.Slot3.ASCIIDefender = monsterCaught.ASCIIDefender;
                player.Party.Slot3.ASCIIPokedex = monsterCaught.ASCIIPokedex;
                player.Party.Slot3.EquippedMoves = monsterCaught.EquippedMoves;
                player.Party.Slot3.Name = monsterCaught.Name;
                player.Party.Slot3.DefaultName = monsterCaught.DefaultName;
                player.Party.Slot3.IsBoosted = false;
                player.Party.Slot3.Gender = monsterCaught.Gender;
            }
            else if (player.Party.Slot4.Type == Monster_Race.NONE)
            {
                player.Party.Slot4.MaxHealth = monsterCaught.MaxHealth;
                player.Party.Slot4.Health = monsterCaught.Health;
                player.Party.Slot4.MaxExp = monsterCaught.MaxExp;
                player.Party.Slot4.Exp = monsterCaught.Exp;
                player.Party.Slot4.Lv = monsterCaught.Lv;
                player.Party.Slot4.SlotNum = currentID;
                player.Party.Slot4.PokeIndex = monsterCaught.PokeIndex;
                player.Party.Slot4.IsCaught = true;
                player.Party.Slot4.Type = monsterCaught.Type;
                player.Party.Slot4.Description = monsterCaught.Description;
                player.Party.Slot4.ASCIIAttacker = monsterCaught.ASCIIAttacker;
                player.Party.Slot4.ASCIIDefender = monsterCaught.ASCIIDefender;
                player.Party.Slot4.ASCIIPokedex = monsterCaught.ASCIIPokedex;
                player.Party.Slot4.EquippedMoves = monsterCaught.EquippedMoves;
                player.Party.Slot4.Name = monsterCaught.Name;
                player.Party.Slot4.DefaultName = monsterCaught.DefaultName;
                player.Party.Slot4.IsBoosted = false;
                player.Party.Slot4.Gender = monsterCaught.Gender;
            }
            else if (player.Party.Slot5.Type == Monster_Race.NONE)
            {
                player.Party.Slot5.MaxHealth = monsterCaught.MaxHealth;
                player.Party.Slot5.Health = monsterCaught.Health;
                player.Party.Slot5.MaxExp = monsterCaught.MaxExp;
                player.Party.Slot5.Exp = monsterCaught.Exp;
                player.Party.Slot5.Lv = monsterCaught.Lv;
                player.Party.Slot5.SlotNum = currentID;
                player.Party.Slot5.PokeIndex = monsterCaught.PokeIndex;
                player.Party.Slot5.IsCaught = true;
                player.Party.Slot5.Type = monsterCaught.Type;
                player.Party.Slot5.Description = monsterCaught.Description;
                player.Party.Slot5.ASCIIAttacker = monsterCaught.ASCIIAttacker;
                player.Party.Slot5.ASCIIDefender = monsterCaught.ASCIIDefender;
                player.Party.Slot5.ASCIIPokedex = monsterCaught.ASCIIPokedex;
                player.Party.Slot5.EquippedMoves = monsterCaught.EquippedMoves;
                player.Party.Slot5.Name = monsterCaught.Name;
                player.Party.Slot5.DefaultName = monsterCaught.DefaultName;
                player.Party.Slot5.IsBoosted = false;
                player.Party.Slot5.Gender = monsterCaught.Gender;
            }
            else if (player.Party.Slot6.Type == Monster_Race.NONE)
            {
                player.Party.Slot6.MaxHealth = monsterCaught.MaxHealth;
                player.Party.Slot6.Health = monsterCaught.Health;
                player.Party.Slot6.MaxExp = monsterCaught.MaxExp;
                player.Party.Slot6.Exp = monsterCaught.Exp;
                player.Party.Slot6.Lv = monsterCaught.Lv;
                player.Party.Slot6.SlotNum = currentID;
                player.Party.Slot6.PokeIndex = monsterCaught.PokeIndex;
                player.Party.Slot6.IsCaught = true;
                player.Party.Slot6.Type = monsterCaught.Type;
                player.Party.Slot6.Description = monsterCaught.Description;
                player.Party.Slot6.ASCIIAttacker = monsterCaught.ASCIIAttacker;
                player.Party.Slot6.ASCIIDefender = monsterCaught.ASCIIDefender;
                player.Party.Slot6.ASCIIPokedex = monsterCaught.ASCIIPokedex;
                player.Party.Slot6.EquippedMoves = monsterCaught.EquippedMoves;
                player.Party.Slot6.Name = monsterCaught.Name;
                player.Party.Slot6.DefaultName = monsterCaught.DefaultName;
                player.Party.Slot6.IsBoosted = false;
                player.Party.Slot6.Gender = monsterCaught.Gender;
            }
            else
            {
                do
                {
                    if (player.PC[currentID].Type == Monster_Race.NONE)
                    {
                        player.PC[currentID].MaxHealth = monsterCaught.MaxHealth;
                        player.PC[currentID].Health = monsterCaught.Health;
                        player.PC[currentID].MaxExp = monsterCaught.MaxExp;
                        player.PC[currentID].Exp = monsterCaught.Exp;
                        player.PC[currentID].Lv = monsterCaught.Lv;
                        player.PC[currentID].SlotNum = currentID;
                        player.PC[currentID].PokeIndex = monsterCaught.PokeIndex;
                        player.PC[currentID].IsCaught = true;
                        player.PC[currentID].Type = monsterCaught.Type;
                        player.PC[currentID].Description = monsterCaught.Description;
                        player.PC[currentID].ASCIIAttacker = monsterCaught.ASCIIAttacker;
                        player.PC[currentID].ASCIIDefender = monsterCaught.ASCIIDefender;
                        player.PC[currentID].ASCIIPokedex = monsterCaught.ASCIIPokedex;
                        player.PC[currentID].EquippedMoves = monsterCaught.EquippedMoves;
                        player.PC[currentID].Name = monsterCaught.Name;
                        player.PC[currentID].DefaultName = monsterCaught.DefaultName;
                        player.PC[currentID].IsBoosted = false;
                        player.PC[currentID].Gender = monsterCaught.Gender;

                        string message = $"{monsterCaught.Name} was sent to Slot {currentID} in {player.Name}'s PC.";
                        ASCII.ScrollMessage(message, 50, 2000, GBText, GBBackground);                       
                        reloadCatchSortPC = false;
                    }
                    else
                    {
                        currentID += 1;
                        reloadCatchSortPC = true;
                    }
                } while (reloadCatchSortPC);
            }
        }

        public static void FUNTryCatchANDSort(Player attacker, Monster defender, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Random rand = new Random();
            int catchChance1 = rand.Next(0, 100);
            int catchChance2 = rand.Next(0, 200);
            int catchChance3 = rand.Next(0, 1000);
            string messageTryCatch = $"{attacker.Name.ToUpper()} used a PokeCatcher!";
            string messageFreed = $"Oh no! {defender.Name.ToUpper()} broke free!";
            string messageCaught = $"{attacker.Name.ToUpper()} caught the wild {defender.Name.ToUpper()}!";

            ASCII.DISATTandDEF(attacker, defender, GBText, GBBackground);
            ASCII.ScrollMessage(messageTryCatch, 50, 1000, GBText, GBBackground);
            ASCII.ThrowBall(GBBackground);
            //ASCII.DISAttacker(attacker, GBText, GBBackground);
            //ASCII.DISDefenderInfoBar(defender, GBText, GBBackground);
            if (defender.Health < (.25 * defender.MaxHealth) && catchChance1 > 25 || catchChance1 > 50)
            {
                ASCII.BallShakeLeft(GBBackground);
                if (defender.Health < (.25 * defender.MaxHealth) && catchChance2 > 25 || catchChance2 > 50)
                {
                    ASCII.BallShakeRight(GBBackground);
                    if (defender.Health < (.25 * defender.MaxHealth) && catchChance2 > 25 || catchChance3 > 50)
                    {
                        ASCII.BallShakeLeft(GBBackground);
                        //SFX.CaptureSuccess();
                        ASCII.ScrollMessage(messageCaught, 50, 5000, GBText, GBBackground); 
                        FUNCatchSort(attacker, defender, GBText, GBBackground);
                        defender.IsCaught = true;
                    }
                    else
                    {
                        ASCII.BallBreak(56, 8, 50, GBBackground);
                        ASCII.DISATTandDEF(attacker, defender, GBText, GBBackground);
                        ASCII.ScrollMessage(messageFreed, 50, 2000, GBText, GBBackground);
                    }
                }
                else
                {
                    ASCII.BallBreak(56, 8, 50, GBBackground);
                    ASCII.DISATTandDEF(attacker, defender, GBText, GBBackground);
                    ASCII.ScrollMessage(messageFreed, 50, 2000, GBText, GBBackground);
                }
            }
            else
            {
                ASCII.BallBreak(56, 8, 50, GBBackground);
                ASCII.DISATTandDEF(attacker, defender, GBText, GBBackground);
                ASCII.ScrollMessage(messageFreed, 50, 2000, GBText, GBBackground);
            }
            //attacker.Inventory.BagSlot1.PokeCatcher -= 1;
        }

        public static void DoAttackPlayer(Player attacker, Monster defender, Monster_Moves move, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Monster_Race currentType = attacker.MonsterEquipped.Type;
            switch (move.Type)
            {
                case Monster_Race.Fire:
                    attacker.MonsterEquipped.Type = Monster_Race.Fire;
                    break;
                case Monster_Race.Water:
                    attacker.MonsterEquipped.Type = Monster_Race.Water;
                    break;
                case Monster_Race.Electric:
                    attacker.MonsterEquipped.Type = Monster_Race.Electric;
                    break;
                case Monster_Race.Ground:
                    attacker.MonsterEquipped.Type = Monster_Race.Ground;
                    break;
                case Monster_Race.Psychic:
                    attacker.MonsterEquipped.Type = Monster_Race.Psychic;
                    break;
            }

            #region Monster Weakness Calculator

            /*//////////Fire Monster//////////*/

            if (attacker.MonsterEquipped.Type == Monster_Race.Fire)
            {
                /**********Fire-Type VS Ground-Type*********/

                if (defender.Type == Monster_Race.Ground)
                {
                    PlayerVSMonsterHitSuper(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Fire-Type VS Water-Type*********/

                else if (defender.Type == Monster_Race.Water)
                {
                    PlayerVSMonsterHitLow(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Fire-Type VS Fire-Type*********/

                if (defender.Type == Monster_Race.Fire)
                {
                    PlayerVSMonsterHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Fire-Type VS Electric-Type*********/

                else if (defender.Type == Monster_Race.Electric)
                {
                    PlayerVSMonsterHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Fire-Type VS Psychic-Type*********/

                else if (defender.Type == Monster_Race.Psychic)
                {
                    PlayerVSMonsterHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if                
            }//end if

            /*//////////Water Monster//////////*/

            if (attacker.MonsterEquipped.Type == Monster_Race.Water)
            {
                /**********Water-Type VS Fire-Type*********/

                if (defender.Type == Monster_Race.Fire)
                {
                    PlayerVSMonsterHitSuper(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Water-Type VS Electric-Type*********/

                else if (defender.Type == Monster_Race.Electric)
                {
                    PlayerVSMonsterHitLow(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Water-Type VS Water-Type*********/

                else if (defender.Type == Monster_Race.Water)
                {
                    PlayerVSMonsterHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Water-Type VS Ground-Type*********/

                else if (defender.Type == Monster_Race.Ground)
                {
                    PlayerVSMonsterHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Water-Type VS Psychic-Type*********/

                else if (defender.Type == Monster_Race.Psychic)
                {
                    PlayerVSMonsterHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if                
            }//end if

            /*//////////Electric Monster//////////*/

            if (attacker.MonsterEquipped.Type == Monster_Race.Electric)
            {
                /**********Electric-Type VS Water-Type*********/

                if (defender.Type == Monster_Race.Water)
                {
                    PlayerVSMonsterHitSuper(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Electric-Type VS Ground-Type*********/

                else if (defender.Type == Monster_Race.Ground)
                {
                    PlayerVSMonsterHitZero(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Electric-Type VS Rock-Type*********/

                else if (defender.Type == Monster_Race.Electric)
                {
                    PlayerVSMonsterHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Electric-Type VS Fire-Type*********/

                else if (defender.Type == Monster_Race.Fire)
                {
                    PlayerVSMonsterHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Electric-Type VS Psychic-Type*********/

                else if (defender.Type == Monster_Race.Psychic)
                {
                    PlayerVSMonsterHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if                
            }//end if

            /*//////////Ground Monster//////////*/

            if (attacker.MonsterEquipped.Type == Monster_Race.Ground)
            {
                /**********Ground-Type VS Rock-Type*********/

                if (defender.Type == Monster_Race.Electric)
                {
                    PlayerVSMonsterHitSuper(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Ground-Type VS Fire-Type*********/

                else if (defender.Type == Monster_Race.Fire)
                {
                    PlayerVSMonsterHitLow(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Ground-Type VS Ground-Type*********/

                else if (defender.Type == Monster_Race.Ground)
                {
                    PlayerVSMonsterHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Ground-Type VS Water-Type*********/

                else if (defender.Type == Monster_Race.Water)
                {
                    PlayerVSMonsterHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Ground-Type VS Psychic-Type*********/

                else if (defender.Type == Monster_Race.Psychic)
                {
                    PlayerVSMonsterHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if                
            }//end if

            /*//////////Psychic Monster//////////*/

            if (attacker.MonsterEquipped.Type == Monster_Race.Psychic)
            {
                /**********Psychic-Type VS Fire-Type*********/

                if (defender.Type == Monster_Race.Fire)
                {
                    PlayerVSMonsterHitSuper(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Psychic-Type VS Water-Type*********/

                else if (defender.Type == Monster_Race.Water)
                {
                    PlayerVSMonsterHitSuper(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Psychic-Type VS Electric-Type*********/

                else if (defender.Type == Monster_Race.Electric)
                {
                    PlayerVSMonsterHitSuper(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Psychic-Type VS Air-Type*********/

                else if (defender.Type == Monster_Race.Ground)
                {
                    PlayerVSMonsterHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Psychic-Type VS Psychic-Type*********/

                else if (defender.Type == Monster_Race.Psychic)
                {
                    PlayerVSMonsterHitLow(attacker, defender, move, GBText, GBBackground);
                }//end else if                
            }//end if             

            #endregion             

            attacker.MonsterEquipped.Type = currentType;
        }

        public static void DoAttackMonster(Monster attacker, Player defender, Monster_Moves move, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            Monster_Race currentType = attacker.Type;
            switch (move.Type)
            {
                case Monster_Race.Fire:
                    attacker.Type = Monster_Race.Fire;
                    break;
                case Monster_Race.Water:
                    attacker.Type = Monster_Race.Water;
                    break;
                case Monster_Race.Electric:
                    attacker.Type = Monster_Race.Electric;
                    break;
                case Monster_Race.Ground:
                    attacker.Type = Monster_Race.Ground;
                    break;
                case Monster_Race.Psychic:
                    attacker.Type = Monster_Race.Psychic;
                    break;
            }

            #region Monster Weakness Calculator

            /*//////////Fire Monster//////////*/

            if (attacker.Type == Monster_Race.Fire)
            {
                /**********Fire-Type VS Ground-Type*********/

                if (defender.MonsterEquipped.Type == Monster_Race.Ground)
                {
                    MonsterVSPlayerHitSuper(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Fire-Type VS Water-Type*********/

                else if (defender.MonsterEquipped.Type == Monster_Race.Water)
                {
                    MonsterVSPlayerHitLow(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Fire-Type VS Fire-Type*********/

                if (defender.MonsterEquipped.Type == Monster_Race.Fire)
                {
                    MonsterVSPlayerHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Fire-Type VS Electric-Type*********/

                else if (defender.MonsterEquipped.Type == Monster_Race.Electric)
                {
                    MonsterVSPlayerHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Fire-Type VS Psychic-Type*********/

                else if (defender.MonsterEquipped.Type == Monster_Race.Psychic)
                {
                    MonsterVSPlayerHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if                
            }//end if

            /*//////////Water Monster//////////*/

            if (attacker.Type == Monster_Race.Water)
            {
                /**********Water-Type VS Fire-Type*********/

                if (defender.MonsterEquipped.Type == Monster_Race.Fire)
                {
                    MonsterVSPlayerHitSuper(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Water-Type VS Electric-Type*********/

                else if (defender.MonsterEquipped.Type == Monster_Race.Electric)
                {
                    MonsterVSPlayerHitLow(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Water-Type VS Water-Type*********/

                else if (defender.MonsterEquipped.Type == Monster_Race.Water)
                {
                    MonsterVSPlayerHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Water-Type VS Ground-Type*********/

                else if (defender.MonsterEquipped.Type == Monster_Race.Ground)
                {
                    MonsterVSPlayerHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Water-Type VS Psychic-Type*********/

                else if (defender.MonsterEquipped.Type == Monster_Race.Psychic)
                {
                    MonsterVSPlayerHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if                
            }//end if

            /*//////////Electric Monster//////////*/

            if (attacker.Type == Monster_Race.Electric)
            {
                /**********Electric-Type VS Water-Type*********/

                if (defender.MonsterEquipped.Type == Monster_Race.Water)
                {
                    MonsterVSPlayerHitSuper(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Electric-Type VS Ground-Type*********/

                else if (defender.MonsterEquipped.Type == Monster_Race.Ground)
                {
                    MonsterVSPlayerHitZero(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Electric-Type VS Rock-Type*********/

                else if (defender.MonsterEquipped.Type == Monster_Race.Electric)
                {
                    MonsterVSPlayerHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Electric-Type VS Fire-Type*********/

                else if (defender.MonsterEquipped.Type == Monster_Race.Fire)
                {
                    MonsterVSPlayerHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Electric-Type VS Psychic-Type*********/

                else if (defender.MonsterEquipped.Type == Monster_Race.Psychic)
                {
                    MonsterVSPlayerHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if                
            }//end if

            /*//////////Ground Monster//////////*/

            if (attacker.Type == Monster_Race.Ground)
            {
                /**********Ground-Type VS Rock-Type*********/

                if (defender.MonsterEquipped.Type == Monster_Race.Electric)
                {
                    MonsterVSPlayerHitSuper(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Ground-Type VS Fire-Type*********/

                else if (defender.MonsterEquipped.Type == Monster_Race.Fire)
                {
                    MonsterVSPlayerHitLow(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Ground-Type VS Ground-Type*********/

                else if (defender.MonsterEquipped.Type == Monster_Race.Ground)
                {
                    MonsterVSPlayerHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Ground-Type VS Water-Type*********/

                else if (defender.MonsterEquipped.Type == Monster_Race.Water)
                {
                    MonsterVSPlayerHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Ground-Type VS Psychic-Type*********/

                else if (defender.MonsterEquipped.Type == Monster_Race.Psychic)
                {
                    MonsterVSPlayerHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if                
            }//end if

            /*//////////Psychic Monster//////////*/

            if (attacker.Type == Monster_Race.Psychic)
            {
                /**********Psychic-Type VS Fire-Type*********/

                if (defender.MonsterEquipped.Type == Monster_Race.Fire)
                {
                    MonsterVSPlayerHitSuper(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Psychic-Type VS Water-Type*********/

                else if (defender.MonsterEquipped.Type == Monster_Race.Water)
                {
                    MonsterVSPlayerHitSuper(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Psychic-Type VS Electric-Type*********/

                else if (defender.MonsterEquipped.Type == Monster_Race.Electric)
                {
                    MonsterVSPlayerHitSuper(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Psychic-Type VS Air-Type*********/

                else if (defender.MonsterEquipped.Type == Monster_Race.Ground)
                {
                    MonsterVSPlayerHitStan(attacker, defender, move, GBText, GBBackground);
                }//end else if

                /**********Psychic-Type VS Psychic-Type*********/

                else if (defender.MonsterEquipped.Type == Monster_Race.Psychic)
                {
                    MonsterVSPlayerHitLow(attacker, defender, move, GBText, GBBackground);
                }//end else if                
            }//end if             

            #endregion             

            attacker.Type = currentType;
        }

        public static void DoBattle(Player player, Monster monster, Monster_Moves move, ConsoleColor GBText, ConsoleColor GBBackground)
        {
            DoAttackPlayer(player, monster, move, GBText, GBBackground);
            if (monster.Health > 0)
            {
                DoAttackMonster(monster, player, monster.EquippedMoves.Move1, GBText, GBBackground);                
            }//end if
        }//end 
        #endregion
    }
}