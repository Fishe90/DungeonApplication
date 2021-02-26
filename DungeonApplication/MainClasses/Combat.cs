using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses
{
    public class Combat
    {
        #region CalcExpGain

        public static void CalcExp(Player player, Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            int currentExp = player.Party.MonsterEquipped.Exp;
            int exp = (monster.Lv * monster.Lv) / 2;            

            ASCII.DISJustAttacker(player, gbText, gbBackground);
            if (monster.IsOwned == true)
            {
                string message = $"{player.Party.MonsterEquipped.Name.ToUpper()} gained {exp * 1.5} exp!";
                ASCII.ScrollMessage(message, 50, 1000, gbText, gbBackground);
                currentExp += Decimal.ToInt32(((monster.Lv * monster.Lv) / 2) * 1.5m);
            }
            else
            {
                string message = $"{player.Party.MonsterEquipped.Name.ToUpper()} gained {((monster.Lv * monster.Lv) / 2)} exp!";
                ASCII.ScrollMessage(message, 50, 2000, gbText, gbBackground);
                currentExp += Decimal.ToInt32((monster.Lv * monster.Lv) / 2);
            }
            System.Threading.Thread.Sleep(1000);
            //currentExp += exp;
            while (currentExp > player.Party.MonsterEquipped.Exp)
            {
                player.Party.MonsterEquipped.Exp += 1;
                ASCII.ExpBar(player.Party.MonsterEquipped, 43, 17);
                if (player.Party.MonsterEquipped.Exp == player.Party.MonsterEquipped.MaxExp)
                {
                    currentExp -= player.Party.MonsterEquipped.MaxExp;
                    System.Threading.Thread.Sleep(5);
                    player.Party.MonsterEquipped.Lv += 1;
                    player.Party.MonsterEquipped.MaxExp = player.Party.MonsterEquipped.Lv * player.Party.MonsterEquipped.Lv;
                    player.Party.MonsterEquipped.Exp = 0;
                    System.Threading.Thread.Sleep(500);
                    ASCII.DISAttackerInfoBar(player, gbText, gbBackground);
                    ASCII.ScrollMessage($"{player.Party.MonsterEquipped.Name.ToUpper()} grew to Lv.{player.Party.MonsterEquipped.Lv}!", 50, 1500, gbText, gbBackground);
                }
                System.Threading.Thread.Sleep(50);
            }
            System.Threading.Thread.Sleep(2000);
            ASCII.DISJustAttacker(player, gbText, gbBackground);
            //select.Stop();
            //ASCII.ScrollMessage()
        }

        #endregion

        #region CalcDamage PlayerVSMonster

        public static void PlayerVSMonsterHitZero(Player attacker, Monster defender, Monster_Moves move, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Random rand = new Random();
            string playerHit = $@"{attacker.Party.MonsterEquipped.Name} used {move.Name}!";
            string playerHitZero = $@"{move.Name} doesn't affect the wild {defender.Name}!";

            ASCII.StaticMessageBox(gbText, gbBackground);
            System.Threading.Thread.Sleep(1000);
            ASCII.ScrollMessage(playerHit, 50, 1000, gbText, gbBackground);
            CalcDamageMonster(defender, 0, gbText, gbBackground);
            ASCII.ScrollMessage(playerHitZero, 50, 2000, gbText, gbBackground);
            move.Uses -= 1;
        }

        public static void PlayerVSMonsterHitLow(Player attacker, Monster defender, Monster_Moves move, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Random rand = new Random();
            string playerHit = $@"{attacker.Party.MonsterEquipped.Name} used {move.Name}!";
            string playerHitLow = $@"It's not very effective!";
            int damageDealt = ((((((2 * attacker.Party.MonsterEquipped.Lv) / 5) + 2) * move.Damage) / 50) + 2) / 2;

            ASCII.StaticMessageBox(gbText, gbBackground);
            System.Threading.Thread.Sleep(1000);
            ASCII.ScrollMessage(playerHit, 50, 1000, gbText, gbBackground);
            CalcDamageMonster(defender, damageDealt, gbText, gbBackground);
            ASCII.ScrollMessage(playerHitLow, 50, 2000, gbText, gbBackground);
            move.Uses -= 1;
        }

        public static void PlayerVSMonsterHitStan(Player attacker, Monster defender, Monster_Moves move, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Random rand = new Random();
            string playerHit = $@"{attacker.Party.MonsterEquipped.Name} used {move.Name}!";
            int damageDealt = ((((((2 * attacker.Party.MonsterEquipped.Lv) / 5) + 2) * move.Damage) / 50) + 2);

            ASCII.StaticMessageBox(gbText, gbBackground);
            System.Threading.Thread.Sleep(1000);
            ASCII.ScrollMessage(playerHit, 50, 1000, gbText, gbBackground);
            CalcDamageMonster(defender, damageDealt, gbText, gbBackground);
            move.Uses -= 1;
        }

        public static void PlayerVSMonsterHitSuper(Player attacker, Monster defender, Monster_Moves move, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Random rand = new Random();
            string playerHit = $@"{attacker.Party.MonsterEquipped.Name} used {move.Name}!";
            string playerHitSuper = $@"It's super effective!";
            int damageDealt = ((((((2 * attacker.Party.MonsterEquipped.Lv) / 5) + 2) * move.Damage) / 50) + 2) * 2;

            ASCII.StaticMessageBox(gbText, gbBackground);
            System.Threading.Thread.Sleep(1000);
            ASCII.ScrollMessage(playerHit, 50, 1000, gbText, gbBackground);
            CalcDamageMonster(defender, damageDealt, gbText, gbBackground);
            ASCII.ScrollMessage(playerHitSuper, 50, 2000, gbText, gbBackground);
            move.Uses -= 1;
        }
        #endregion

        #region CalcDamage MonsterVSPlayer
        public static void MonsterVSPlayerHitZero(Monster attacker, Player defender, Monster_Moves move, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Random rand = new Random();
            string playerHit = $@"{attacker.Name} used {move.Name}!";
            string playerHitZero = $@"{move.Name} doesn't affect {defender.Party.MonsterEquipped.Name}!";

            ASCII.StaticMessageBox(gbText, gbBackground);
            System.Threading.Thread.Sleep(1000);
            ASCII.ScrollMessage(playerHit, 50, 1000, gbText, gbBackground);
            CalcDamageAttacker(defender, 0, gbText, gbBackground);
            ASCII.ScrollMessage(playerHitZero, 50, 1000, gbText, gbBackground);            
            move.Uses -= 1;
        }

        public static void MonsterVSPlayerHitLow(Monster attacker, Player defender, Monster_Moves move, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Random rand = new Random();
            string playerHit = $@"{attacker.Name} used {move.Name}!";
            string playerHitLow = $@"It's not very effective!";
            int damageDealt = ((((((2 * attacker.Lv) / 5) + 2) * move.Damage) / 50) + 2) / 2;

            ASCII.StaticMessageBox(gbText, gbBackground);
            System.Threading.Thread.Sleep(1000);
            ASCII.ScrollMessage(playerHit, 50, 1000, gbText, gbBackground);
            CalcDamageAttacker(defender, damageDealt, gbText, gbBackground);
            ASCII.ScrollMessage(playerHitLow, 50, 2000, gbText, gbBackground);
            move.Uses -= 1;
        }

        public static void MonsterVSPlayerHitStan(Monster attacker, Player defender, Monster_Moves move, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Random rand = new Random();
            string playerHit = $@"{attacker.Name} used {move.Name}!";
            int damageDealt = ((((((2 * attacker.Lv) / 5) + 2) * move.Damage) / 50) + 2);

            ASCII.StaticMessageBox(gbText, gbBackground);
            System.Threading.Thread.Sleep(1000);
            ASCII.ScrollMessage(playerHit, 50, 1000, gbText, gbBackground);
            CalcDamageAttacker(defender, damageDealt, gbText, gbBackground);
            move.Uses -= 1;
        }

        public static void MonsterVSPlayerHitSuper(Monster attacker, Player defender, Monster_Moves move, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Random rand = new Random();
            string playerHit = $@"{attacker.Name} used {move.Name}!";
            string playerHitSuper = $@"It's super effective!";
            int damageDealt = ((((((2 * attacker.Lv) / 5) + 2) * move.Damage) / 50) + 2) * 2;

            ASCII.StaticMessageBox(gbText, gbBackground);
            System.Threading.Thread.Sleep(1000);
            ASCII.ScrollMessage(playerHit, 50, 1000, gbText, gbBackground);
            CalcDamageAttacker(defender, damageDealt, gbText, gbBackground);
            ASCII.ScrollMessage(playerHitSuper, 50, 2000, gbText, gbBackground);
            move.Uses -= 1;
        }

        #endregion

        #region CalcDamage Display Player VS Monster

        public static void CalcDamageMonster(Monster monster, int damage, ConsoleColor gbText, ConsoleColor gbBackground)
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

        public static void CalcDamageAttacker(Player attacker, int damage, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            int currentHealth = attacker.Party.MonsterEquipped.Health;
            System.Threading.Thread.Sleep(1000);
            currentHealth -= damage;
            while (currentHealth < attacker.Party.MonsterEquipped.Health)
            {
                attacker.Party.MonsterEquipped.Health -= 1;
                ASCII.HealthBar(attacker.Party.MonsterEquipped, 43, 15);
                if (attacker.Party.MonsterEquipped.Health <= 0 && currentHealth <= 0)
                {
                    attacker.Party.MonsterEquipped.Health = 0;
                    currentHealth = 0;
                }
                System.Threading.Thread.Sleep(200);
            }
        }

        #endregion

        #region Combat Functionality Player VS Monster 

        public static void CatchSort(Player player, Monster monsterCaught, ConsoleColor gbText, ConsoleColor gbBackground)
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
                        ASCII.ScrollMessage(message, 50, 2000, gbText, gbBackground);                       
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

        public static void TryCatchANDSort(Player player, Monster monster, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Random rand = new Random();
            int catchChance1 = rand.Next(0, 100);
            int catchChance2 = rand.Next(0, 200);
            int catchChance3 = rand.Next(0, 1000);
            string messageTryCatch = $"{player.Name.ToUpper()} used a PokeCatcher!";
            string messageFreed = $"Oh no! {monster.Name.ToUpper()} broke free!";
            string messageCaught = $"{player.Name.ToUpper()} caught the wild {monster.Name.ToUpper()}!";

            ASCII.ScrollMessage(messageTryCatch, 50, 1000, gbText, gbBackground);
            ASCII.ThrowBall(player, gbText, gbBackground);
            if (monster.Health < (.25 * monster.MaxHealth) && catchChance1 > 25 || catchChance1 > 50)
            {
                ASCII.BallShakeLeft(gbBackground);
                if (monster.Health < (.25 * monster.MaxHealth) && catchChance2 > 25 || catchChance2 > 50)
                {
                    ASCII.BallShakeRight(gbBackground);
                    if (monster.Health < (.25 * monster.MaxHealth) && catchChance2 > 25 || catchChance3 > 50)
                    {
                        ASCII.BallShakeLeft(gbBackground);
                        SFX.CaptureSuccess();
                        ASCII.ScrollMessage(messageCaught, 50, 5000, gbText, gbBackground); 
                        CatchSort(player, monster, gbText, gbBackground);
                        monster.IsCaught = true;
                    }
                    else
                    {
                        ASCII.BallBreak(63, 8, 50, gbText, gbBackground);
                        ASCII.DISATTandDEF(player, monster, gbText, gbBackground);
                        ASCII.ScrollMessage(messageFreed, 50, 2000, gbText, gbBackground);
                        DoAttackMonster(monster, player, monster.EquippedMoves.Move1, gbText, gbBackground);
                    }
                }
                else
                {
                    ASCII.BallBreak(63, 8, 50, gbText, gbBackground);
                    ASCII.DISATTandDEF(player, monster, gbText, gbBackground);
                    ASCII.ScrollMessage(messageFreed, 50, 2000, gbText, gbBackground);
                    DoAttackMonster(monster, player, monster.EquippedMoves.Move1, gbText, gbBackground);
                }
            }
            else
            {
                ASCII.BallBreak(63, 8, 50, gbText, gbBackground);
                ASCII.DISATTandDEF(player, monster, gbText, gbBackground);
                ASCII.ScrollMessage(messageFreed, 50, 2000, gbText, gbBackground);
                DoAttackMonster(monster, player, monster.EquippedMoves.Move1, gbText, gbBackground);
            }
            player.Inventory.ItemSection[0].Amount -= 1;
        }

        public static void DoAttackPlayer(Player player, Monster monster, Monster_Moves move, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Monster_Race currentType = player.Party.MonsterEquipped.Type;
            switch (move.Type)
            {
                case Monster_Race.Fire:
                    player.Party.MonsterEquipped.Type = Monster_Race.Fire;
                    break;
                case Monster_Race.Water:
                    player.Party.MonsterEquipped.Type = Monster_Race.Water;
                    break;
                case Monster_Race.Electric:
                    player.Party.MonsterEquipped.Type = Monster_Race.Electric;
                    break;
                case Monster_Race.Ground:
                    player.Party.MonsterEquipped.Type = Monster_Race.Ground;
                    break;
                case Monster_Race.Psychic:
                    player.Party.MonsterEquipped.Type = Monster_Race.Psychic;
                    break;
            }

            #region Monster Weakness Calculator

            /*//////////Fire Monster//////////*/

            if (player.Party.MonsterEquipped.Type == Monster_Race.Fire)
            {
                /**********Fire-Type VS Ground-Type*********/

                if (monster.Type == Monster_Race.Ground)
                {
                    PlayerVSMonsterHitSuper(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Fire-Type VS Water-Type*********/

                else if (monster.Type == Monster_Race.Water)
                {
                    PlayerVSMonsterHitLow(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Fire-Type VS Fire-Type*********/

                if (monster.Type == Monster_Race.Fire)
                {
                    PlayerVSMonsterHitStan(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Fire-Type VS Electric-Type*********/

                else if (monster.Type == Monster_Race.Electric)
                {
                    PlayerVSMonsterHitStan(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Fire-Type VS Psychic-Type*********/

                else if (monster.Type == Monster_Race.Psychic)
                {
                    PlayerVSMonsterHitStan(player, monster, move, gbText, gbBackground);
                }//end else if                
            }//end if

            /*//////////Water Monster//////////*/

            if (player.Party.MonsterEquipped.Type == Monster_Race.Water)
            {
                /**********Water-Type VS Fire-Type*********/

                if (monster.Type == Monster_Race.Fire)
                {
                    PlayerVSMonsterHitSuper(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Water-Type VS Electric-Type*********/

                else if (monster.Type == Monster_Race.Electric)
                {
                    PlayerVSMonsterHitLow(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Water-Type VS Water-Type*********/

                else if (monster.Type == Monster_Race.Water)
                {
                    PlayerVSMonsterHitStan(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Water-Type VS Ground-Type*********/

                else if (monster.Type == Monster_Race.Ground)
                {
                    PlayerVSMonsterHitStan(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Water-Type VS Psychic-Type*********/

                else if (monster.Type == Monster_Race.Psychic)
                {
                    PlayerVSMonsterHitStan(player, monster, move, gbText, gbBackground);
                }//end else if                
            }//end if

            /*//////////Electric Monster//////////*/

            if (player.Party.MonsterEquipped.Type == Monster_Race.Electric)
            {
                /**********Electric-Type VS Water-Type*********/

                if (monster.Type == Monster_Race.Water)
                {
                    PlayerVSMonsterHitSuper(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Electric-Type VS Ground-Type*********/

                else if (monster.Type == Monster_Race.Ground)
                {
                    PlayerVSMonsterHitZero(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Electric-Type VS Rock-Type*********/

                else if (monster.Type == Monster_Race.Electric)
                {
                    PlayerVSMonsterHitStan(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Electric-Type VS Fire-Type*********/

                else if (monster.Type == Monster_Race.Fire)
                {
                    PlayerVSMonsterHitStan(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Electric-Type VS Psychic-Type*********/

                else if (monster.Type == Monster_Race.Psychic)
                {
                    PlayerVSMonsterHitStan(player, monster, move, gbText, gbBackground);
                }//end else if                
            }//end if

            /*//////////Ground Monster//////////*/

            if (player.Party.MonsterEquipped.Type == Monster_Race.Ground)
            {
                /**********Ground-Type VS Rock-Type*********/

                if (monster.Type == Monster_Race.Electric)
                {
                    PlayerVSMonsterHitSuper(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Ground-Type VS Fire-Type*********/

                else if (monster.Type == Monster_Race.Fire)
                {
                    PlayerVSMonsterHitLow(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Ground-Type VS Ground-Type*********/

                else if (monster.Type == Monster_Race.Ground)
                {
                    PlayerVSMonsterHitStan(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Ground-Type VS Water-Type*********/

                else if (monster.Type == Monster_Race.Water)
                {
                    PlayerVSMonsterHitStan(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Ground-Type VS Psychic-Type*********/

                else if (monster.Type == Monster_Race.Psychic)
                {
                    PlayerVSMonsterHitStan(player, monster, move, gbText, gbBackground);
                }//end else if                
            }//end if

            /*//////////Psychic Monster//////////*/

            if (player.Party.MonsterEquipped.Type == Monster_Race.Psychic)
            {
                /**********Psychic-Type VS Fire-Type*********/

                if (monster.Type == Monster_Race.Fire)
                {
                    PlayerVSMonsterHitSuper(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Psychic-Type VS Water-Type*********/

                else if (monster.Type == Monster_Race.Water)
                {
                    PlayerVSMonsterHitSuper(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Psychic-Type VS Electric-Type*********/

                else if (monster.Type == Monster_Race.Electric)
                {
                    PlayerVSMonsterHitSuper(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Psychic-Type VS Air-Type*********/

                else if (monster.Type == Monster_Race.Ground)
                {
                    PlayerVSMonsterHitStan(player, monster, move, gbText, gbBackground);
                }//end else if

                /**********Psychic-Type VS Psychic-Type*********/

                else if (monster.Type == Monster_Race.Psychic)
                {
                    PlayerVSMonsterHitLow(player, monster, move, gbText, gbBackground);
                }//end else if                
            }//end if             

            #endregion             

            player.Party.MonsterEquipped.Type = currentType;
        }

        public static void DoAttackMonster(Monster monster, Player player, Monster_Moves move, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            Monster_Race currentType = monster.Type;
            switch (move.Type)
            {
                case Monster_Race.Fire:
                    monster.Type = Monster_Race.Fire;
                    break;
                case Monster_Race.Water:
                    monster.Type = Monster_Race.Water;
                    break;
                case Monster_Race.Electric:
                    monster.Type = Monster_Race.Electric;
                    break;
                case Monster_Race.Ground:
                    monster.Type = Monster_Race.Ground;
                    break;
                case Monster_Race.Psychic:
                    monster.Type = Monster_Race.Psychic;
                    break;
            }

            #region Monster Weakness Calculator

            /*//////////Fire Monster//////////*/

            if (monster.Type == Monster_Race.Fire)
            {
                /**********Fire-Type VS Ground-Type*********/

                if (player.Party.MonsterEquipped.Type == Monster_Race.Ground)
                {
                    MonsterVSPlayerHitSuper(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Fire-Type VS Water-Type*********/

                else if (player.Party.MonsterEquipped.Type == Monster_Race.Water)
                {
                    MonsterVSPlayerHitLow(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Fire-Type VS Fire-Type*********/

                if (player.Party.MonsterEquipped.Type == Monster_Race.Fire)
                {
                    MonsterVSPlayerHitStan(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Fire-Type VS Electric-Type*********/

                else if (player.Party.MonsterEquipped.Type == Monster_Race.Electric)
                {
                    MonsterVSPlayerHitStan(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Fire-Type VS Psychic-Type*********/

                else if (player.Party.MonsterEquipped.Type == Monster_Race.Psychic)
                {
                    MonsterVSPlayerHitStan(monster, player, move, gbText, gbBackground);
                }//end else if                
            }//end if

            /*//////////Water Monster//////////*/

            if (monster.Type == Monster_Race.Water)
            {
                /**********Water-Type VS Fire-Type*********/

                if (player.Party.MonsterEquipped.Type == Monster_Race.Fire)
                {
                    MonsterVSPlayerHitSuper(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Water-Type VS Electric-Type*********/

                else if (player.Party.MonsterEquipped.Type == Monster_Race.Electric)
                {
                    MonsterVSPlayerHitLow(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Water-Type VS Water-Type*********/

                else if (player.Party.MonsterEquipped.Type == Monster_Race.Water)
                {
                    MonsterVSPlayerHitStan(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Water-Type VS Ground-Type*********/

                else if (player.Party.MonsterEquipped.Type == Monster_Race.Ground)
                {
                    MonsterVSPlayerHitStan(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Water-Type VS Psychic-Type*********/

                else if (player.Party.MonsterEquipped.Type == Monster_Race.Psychic)
                {
                    MonsterVSPlayerHitStan(monster, player, move, gbText, gbBackground);
                }//end else if                
            }//end if

            /*//////////Electric Monster//////////*/

            if (monster.Type == Monster_Race.Electric)
            {
                /**********Electric-Type VS Water-Type*********/

                if (player.Party.MonsterEquipped.Type == Monster_Race.Water)
                {
                    MonsterVSPlayerHitSuper(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Electric-Type VS Ground-Type*********/

                else if (player.Party.MonsterEquipped.Type == Monster_Race.Ground)
                {
                    MonsterVSPlayerHitZero(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Electric-Type VS Rock-Type*********/

                else if (player.Party.MonsterEquipped.Type == Monster_Race.Electric)
                {
                    MonsterVSPlayerHitStan(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Electric-Type VS Fire-Type*********/

                else if (player.Party.MonsterEquipped.Type == Monster_Race.Fire)
                {
                    MonsterVSPlayerHitStan(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Electric-Type VS Psychic-Type*********/

                else if (player.Party.MonsterEquipped.Type == Monster_Race.Psychic)
                {
                    MonsterVSPlayerHitStan(monster, player, move, gbText, gbBackground);
                }//end else if                
            }//end if

            /*//////////Ground Monster//////////*/

            if (monster.Type == Monster_Race.Ground)
            {
                /**********Ground-Type VS Rock-Type*********/

                if (player.Party.MonsterEquipped.Type == Monster_Race.Electric)
                {
                    MonsterVSPlayerHitSuper(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Ground-Type VS Fire-Type*********/

                else if (player.Party.MonsterEquipped.Type == Monster_Race.Fire)
                {
                    MonsterVSPlayerHitLow(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Ground-Type VS Ground-Type*********/

                else if (player.Party.MonsterEquipped.Type == Monster_Race.Ground)
                {
                    MonsterVSPlayerHitStan(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Ground-Type VS Water-Type*********/

                else if (player.Party.MonsterEquipped.Type == Monster_Race.Water)
                {
                    MonsterVSPlayerHitStan(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Ground-Type VS Psychic-Type*********/

                else if (player.Party.MonsterEquipped.Type == Monster_Race.Psychic)
                {
                    MonsterVSPlayerHitStan(monster, player, move, gbText, gbBackground);
                }//end else if                
            }//end if

            /*//////////Psychic Monster//////////*/

            if (monster.Type == Monster_Race.Psychic)
            {
                /**********Psychic-Type VS Fire-Type*********/

                if (player.Party.MonsterEquipped.Type == Monster_Race.Fire)
                {
                    MonsterVSPlayerHitSuper(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Psychic-Type VS Water-Type*********/

                else if (player.Party.MonsterEquipped.Type == Monster_Race.Water)
                {
                    MonsterVSPlayerHitSuper(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Psychic-Type VS Electric-Type*********/

                else if (player.Party.MonsterEquipped.Type == Monster_Race.Electric)
                {
                    MonsterVSPlayerHitSuper(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Psychic-Type VS Air-Type*********/

                else if (player.Party.MonsterEquipped.Type == Monster_Race.Ground)
                {
                    MonsterVSPlayerHitStan(monster, player, move, gbText, gbBackground);
                }//end else if

                /**********Psychic-Type VS Psychic-Type*********/

                else if (player.Party.MonsterEquipped.Type == Monster_Race.Psychic)
                {
                    MonsterVSPlayerHitLow(monster, player, move, gbText, gbBackground);
                }//end else if                
            }//end if             

            #endregion             

            monster.Type = currentType;
        }

        public static void DoBattle(Player player, Monster monster, Monster_Moves move, ConsoleColor gbText, ConsoleColor gbBackground)
        {
            DoAttackPlayer(player, monster, move, gbText, gbBackground);
            if (monster.Health > 0)
            {
                DoAttackMonster(monster, player, monster.EquippedMoves.Move1, gbText, gbBackground);                
            }//end if
        }//end 

        #endregion
    }
}