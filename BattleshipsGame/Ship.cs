using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsGame
{
    class Ship
    {
        private bool sunken = false;
        //private int currentHits = 0;
        //private int maximumHits = 20;

        public enum ShipType {
            ONE_SHIP=1,
            TWO_SHIP=2,
            THREE_SHIP=3,
            FOUR_SHIP=4,
            SEA_SIZE=10,
            EMPTY_SEA=0
        }
    }
}
