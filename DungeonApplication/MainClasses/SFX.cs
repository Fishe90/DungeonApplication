using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media; //To use Sound Effects

namespace MainClasses
{
    public class SFX
    {
        #region Battle SFX

        public static void BallBounce()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\Battle_SFX\BallBounce.wav";
            select.Play();
        }

        public static void BallShake()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\Battle_SFX\BallShake.wav";
            select.Play();
        }

        public static void CaptureSuccess()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\Battle_SFX\CaptureSuccess.wav";
            select.Play();
        }

        public static void ExpGain()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\Battle_SFX\ExpGain.wav";
            select.Play();
        }

        public static void IsShiny()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\Battle_SFX\IsShiny.wav";
            select.Play();
        }

        public static void LevelUp()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\Battle_SFX\LevelUP.wav";
            select.Play();
        }

        public static void MonsterFled()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\Battle_SFX\MonsterFled.wav";
            select.Play();
        }

        public static void RunAway()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\Battle_SFX\RunAway(NEW).wav";
            select.Play();
        }

        public static void ThrowBall()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\Battle_SFX\ThrowBall.wav";
            select.Play();
        }

        #endregion
        //TODO Trim ALL Battle Music files so they loop evenly
        #region Battle Music

        //TODO Trim The Intro out of each battle .wav file, then create a looping version that plays after the intro

        //public static void LeagueIntro()
        //{
        //    SoundPlayer select = new SoundPlayer();
        //    //player.Stream = new MemoryStream(conte.Resources.gameMusic);
        //    select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\BattleMusic_SFX\LeagueBattleIntro.wav";
        //    select.Play();
        //}

        public static void LeagueBattle()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\BattleMusic_SFX\LeagueBattleMusic.wav";
            select.PlayLooping();
        } //Trim in the 

        //public static void RivalIntro()
        //{
        //    SoundPlayer select = new SoundPlayer();
        //    //player.Stream = new MemoryStream(conte.Resources.gameMusic);
        //    select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\BattleMusic_SFX\RivalBattleIntro.wav";
        //    select.Play();
        //}

        public static void RivalBattle()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\BattleMusic_SFX\RivalBattleMusic.wav";
            select.PlayLooping();
        }

        //public static void BattleIntro()
        //{
        //    SoundPlayer select = new SoundPlayer();
        //    //player.Stream = new MemoryStream(conte.Resources.gameMusic);
        //    select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\BattleMusic_SFX\WildBattleIntro.wav";
        //    select.Play();
        //}

        public static void Battle()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\BattleMusic_SFX\WildBattleMusic.wav";
            select.PlayLooping();
        }

        #endregion

        #region Game Music

        public static void IntroTheme()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Documents\Visual Studio 2017\Projects\03_CSF2\DungeonApplication\DungeonApplication\MainClasses\SFX\GameMusic_SFX\IntroTheme.wav";
            select.PlayLooping();
        }

        public static void OpeningTitle()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\GameMusic_SFX\GameOpeningTitle.wav";
            select.PlayLooping();
        }

        public static void ThemeMusic()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"";
            select.PlayLooping();
        }

        public static void PokeCenter()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Documents\Visual Studio 2017\Projects\03_CSF2\DungeonApplication\DungeonApplication\MainClasses\SFX\GameMusic_SFX\PokeCenter.wav";
            select.PlayLooping();
        }

        public static void Route2()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Documents\Visual Studio 2017\Projects\03_CSF2\DungeonApplication\DungeonApplication\MainClasses\SFX\GameMusic_SFX\Route2.wav";
            select.PlayLooping();
        }

        #endregion

        #region Menu SFX

        public static void OpenMenu()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\Menu_SFX\OpenMenu_01.wav";
            select.Play();
        }

        public static void Select()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\Menu_SFX\Select(NEW).wav";
            select.Play();
        }

        #endregion

        #region Move SFX

        public static void Cut()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\Move_SFX\Cut.wav";
            select.Play();
        }

        public static void RockSmash()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\Move_SFX\RockSmash.wav";
            select.Play();
        }

        #endregion

        #region PokeCenter SFX

        public static void HealingComplete()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\PokeCenter_SFX\Healing.wav";
            select.Play();
        }

        public static void OpenPC()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\PokeCenter_SFX\OpenPC.wav";
            select.Play();
        }

        public static void HealingIndividual()
        {
            BallShake();
        }

        #endregion

        #region Transition SFX

        public static void Boundary()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\Transition_SFX\Boundary.wav";
            select.Play();
        }

        public static void EnterBuilding()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\Transition_SFX\EnterBuilding.wav";
            select.Play();
        }

        public static void EnterCave()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\Transition_SFX\EnterCave_01.wav";
            select.Play();
        }

        public static void EnterStore()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\Transition_SFX\EnterStore.wav";
            select.Play();
        }

        #endregion
        //TODO Trim ALL Travel Music files so they loop evenly
        #region Travel SFX

        public static void Route1()
        {
            SoundPlayer select = new SoundPlayer();
            //player.Stream = new MemoryStream(conte.Resources.gameMusic);
            select.SoundLocation = @"C:\Users\Student\OneDrive\Desktop\PokeFraud(TEST)\PokeClassLibrary\SFX\Travel_SFX\Route1.wav";
            select.PlayLooping();
        }

        #endregion     
    }
}
