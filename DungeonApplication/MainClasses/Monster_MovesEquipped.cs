using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClasses
{
    public class Monster_MovesEquipped
    {
        public Monster_Moves Move1 { get; set; }
        public Monster_Moves Move2 { get; set; }
        public Monster_Moves Move3 { get; set; }
        public Monster_Moves Move4 { get; set; }

        public Monster_MovesEquipped() { }

        public Monster_MovesEquipped(Monster_Moves move1, Monster_Moves move2, Monster_Moves move3, Monster_Moves move4)
        {
            Move1 = move1;
            Move2 = move2;
            Move3 = move3;
            Move4 = move4;
        }

        #region Starter Movesets
        public static Monster_MovesEquipped fireStarter = new Monster_MovesEquipped(Monster_Moves.fireEmber, Monster_Moves.Empty, Monster_Moves.Empty, Monster_Moves.Empty);
        public static Monster_MovesEquipped waterStarter = new Monster_MovesEquipped(Monster_Moves.waterWaterGun, Monster_Moves.Empty, Monster_Moves.Empty, Monster_Moves.Empty);
        public static Monster_MovesEquipped electricStarter = new Monster_MovesEquipped(Monster_Moves.electricThundershock, Monster_Moves.Empty, Monster_Moves.Empty, Monster_Moves.Empty);
        public static Monster_MovesEquipped psychicStarter = new Monster_MovesEquipped(Monster_Moves.psychicConfusion, Monster_Moves.Empty, Monster_Moves.Empty, Monster_Moves.Empty);
        #endregion

        #region Wild Monster Movesets
        public static Monster_MovesEquipped fireLow = new Monster_MovesEquipped(Monster_Moves.fireEmber, Monster_Moves.Empty, Monster_Moves.Empty, Monster_Moves.Empty);
        public static Monster_MovesEquipped waterLow = new Monster_MovesEquipped(Monster_Moves.waterWaterGun, Monster_Moves.Empty, Monster_Moves.Empty, Monster_Moves.Empty);
        public static Monster_MovesEquipped electricLow = new Monster_MovesEquipped(Monster_Moves.electricThundershock, Monster_Moves.Empty, Monster_Moves.Empty, Monster_Moves.Empty);
        public static Monster_MovesEquipped groundLow = new Monster_MovesEquipped(Monster_Moves.groundMudshot, Monster_Moves.Empty, Monster_Moves.Empty, Monster_Moves.Empty);
        public static Monster_MovesEquipped psychicLow = new Monster_MovesEquipped(Monster_Moves.psychicConfusion, Monster_Moves.Empty, Monster_Moves.Empty, Monster_Moves.Empty);
        #endregion

    }
}
