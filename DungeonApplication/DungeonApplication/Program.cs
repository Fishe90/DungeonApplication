using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainClasses;

namespace DungeonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(91, 47);
            ConsoleColor gbText = ConsoleColor.Gray;
            ConsoleColor gbBackground = ConsoleColor.Black;
            ConsoleColor GBColor = ConsoleColor.DarkGreen;
            ConsoleKey navPlayerMenu = Console.ReadKey().Key;

            ASCII.GameBoy(GBColor);

            Monster_Moves Empty = new Monster_Moves("EMPTY", Monster_Race.NONE, 0, 0, 0);

            Monster_Moves fireEmber = new Monster_Moves("Ember", Monster_Race.Fire, 40, 15, 15);
            Monster_Moves waterWaterGun = new Monster_Moves("Water Gun", Monster_Race.Water, 40, 15, 15);
            Monster_Moves electricThunder = new Monster_Moves("Thunder", Monster_Race.Electric, 40, 15, 15);
            Monster_Moves groundRockSmash = new Monster_Moves("Rock Smash", Monster_Race.Ground, 40, 15, 15);
            Monster_Moves psychicPsychic = new Monster_Moves("Psychic", Monster_Race.Psychic, 40, 15, 15);

            Monster_MovesEquipped pyraDefault = new Monster_MovesEquipped(fireEmber, waterWaterGun, Empty, Empty);
            Monster_MovesEquipped douseyDefault = new Monster_MovesEquipped(waterWaterGun, Empty, Empty, Empty);
            Monster_MovesEquipped electraDefault = new Monster_MovesEquipped(electricThunder, Empty, Empty, Empty);
            Monster_MovesEquipped cobbletDefault = new Monster_MovesEquipped(groundRockSmash, Empty, Empty, Empty);
            Monster_MovesEquipped neoDefault = new Monster_MovesEquipped(psychicPsychic, Empty, Empty, Empty);

            Monster firePyra = new Monster("Pyra", "Pyra", '♂', false, 25, 50, 25, 0, 5, 1, "004", false, Monster_Race.Fire, false, "", ASCII.pyraAttacker, ASCII.pyraDefender, ASCII.pyraPokedex, pyraDefault);
            Monster waterDousey = new Monster("Dousey", "Dousey", '♂', false, 25, 50, 25, 0, 5, 1, "004", false, Monster_Race.Water, false, "", ASCII.douseyAttacker, ASCII.douseyDefender, ASCII.douseyPokedex, douseyDefault);
            Monster electricElectra = new Monster("Electra", "Electra", '♂', false, 25, 50, 25, 0, 5, 1, "004", false, Monster_Race.Electric, false, "", ASCII.electraAttacker, ASCII.electraDefender, ASCII.electraPokedex, electraDefault);
            Monster groundCobblet = new Monster("Cobblet", "Cobblet", '♂', false, 25, 50, 25, 0, 5, 1, "004", false, Monster_Race.Ground, false, "", ASCII.cobbletAttacker, ASCII.cobbletDefender, ASCII.cobbletPokedex, cobbletDefault);
            Monster psychicNeo = new Monster("Neo", "Neo", '♂', false, 25, 50, 25, 0, 5, 1, "004", false, Monster_Race.Psychic, false, "", ASCII.neoAttacker, ASCII.neoDefender, ASCII.neoPokedex, neoDefault);

            Monster emptySlot = new Monster("Empty", "Empty", 'N', false, 0, 0, 0, 0, 0, 0, "", false, Monster_Race.NONE, false, "", ASCII.pyraAttacker, ASCII.pyraDefender, ASCII.pyraPokedex, pyraDefault);

            Monster playerPyra = new Monster("Pyra", "Pyra", '♂', false, 25, 50, 25, 0, 5, 0, "004", true, Monster_Race.Fire, true, "", ASCII.pyraAttacker, ASCII.pyraDefender, ASCII.pyraPokedex, Monster_MovesEquipped.playerStarter);

            

            Player player1 = new Player();                    
            player1.Party = new Player_Party();
            player1.Inventory = new Player_Inventory();
            player1.Party.MonsterEquipped = Monster.pyra;
            player1.Party.Slot2 = Monster.dousey;
            player1.Party.Slot3 = Monster.electra;
            player1.Party.Slot4 = Monster.cobblet;
            player1.Party.Slot5 = Monster.neo;
            player1.Party.Slot6 = Monster.default6;
            player1.Party.MonsterSwitch = Monster.monsterSwitch;
            player1.Name = "Dillon";

            player1.Money = 0;
            

            Player NPC = new Player();
            NPC.Name = "Bryan";
            NPC.Party = new Player_Party();
            NPC.Party.MonsterEquipped = Monster.rivalDousey;
            NPC.Party.Slot2 = Monster.rivalCobblet;
            NPC.Party.Slot3 = Monster.rivalElectra;
            NPC.Party.Slot4 = new Monster();
            NPC.Party.Slot4.Type = Monster_Race.NONE;
            NPC.Party.Slot4.Health = 0;
            NPC.Party.Slot5 = new Monster();
            NPC.Party.Slot5.Type = Monster_Race.NONE;
            NPC.Party.Slot5.Health = 0;
            NPC.Party.Slot6 = new Monster();
            NPC.Party.Slot6.Type = Monster_Race.NONE;
            NPC.Party.Slot6.Health = 0;
            NPC.Party.MonsterSwitch = new Monster();
            NPC.Party.MonsterSwitch.Type = Monster_Race.NONE;
            NPC.ASCIIDefender = ASCII.npcDefender;
            NPC.ASCIIProfile = ASCII.npcProfile;

            Monster[] monsters = new Monster[]
            {
                firePyra, firePyra, firePyra, firePyra, firePyra,
                waterDousey, waterDousey, waterDousey, waterDousey, waterDousey,
                electricElectra, electricElectra, electricElectra, electricElectra, electricElectra,
                groundCobblet, groundCobblet, groundCobblet, groundCobblet, groundCobblet,
                psychicNeo
            };

            //Player_Menus.PlayerMenu(player1, player1.Party.MonsterEquipped, navPlayerMenu, gbText, gbBackground);
            //navPlayerMenu = Console.ReadKey().Key;

            //ASCII.FullBattleWild(player1, Monster.starters, 5, 10, gbText, gbBackground, navPlayerMenu);

            int currentPosX = 167;
            int currentPosY = 56;

            SFX.Route1();
            Maps.DEMOMap(player1, NPC, currentPosX, currentPosY, navPlayerMenu, gbText, gbBackground);
            //ASCII.RegionNoEncounter(ASCII.DEMOMap, player1, currentPosX, currentPosY, navPlayerMenu, gbText, gbBackground);
            //ASCII.RegionEncounter(ASCII.TestMap, player1, monsters, currentPosX, currentPosY, 6, 10, navPlayerMenu, gbText, gbBackground);
        }
    }
}
