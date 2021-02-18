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
            string monsterFaint = $@"The wild {monster.Name} fainted!";
            string playerFaint = $@"{player.MonsterEquipped.Name} fainted!";

            DoAttackPlayer(player, monster, move, GBText, GBBackground);
            if (monster.Health > 0)
            {
                DoAttackMonster(monster, player, monster.EquippedMoves.Move1, GBText, GBBackground);
                if (player.MonsterEquipped.Health <= 0)
                {
                    //Console.SetCursorPosition(9, 22);
                    //Console.Write("                                                                ");
                    Console.SetCursorPosition(9, 22);
                    foreach (char c in playerFaint)
                    {
                        Console.Write(c);
                        System.Threading.Thread.Sleep(75);
                    }
                    System.Threading.Thread.Sleep(2000);
                }
            }//end if
            else
            {
                //Console.SetCursorPosition(0, 5);
                //Animation.BattleFaint(monster, GBText, GBBackground);
                //Console.SetCursorPosition(9, 22);
                //Console.Write("                                                                ");
                Console.SetCursorPosition(9, 22);
                foreach (char c in monsterFaint)
                {
                    Console.Write(c);
                    System.Threading.Thread.Sleep(75);
                }
                System.Threading.Thread.Sleep(2000);
            }
        }//end 
        #endregion

    }
}