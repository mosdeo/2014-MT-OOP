using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    class Batter : Player
    {
        int upper = 0;

        public Batter(int upper,int distanceLow, int distanceHigh, int angleLeft, int angleRight)
            : base(distanceLow, distanceHigh, angleLeft, angleRight)
        {
            this.upper = upper;
        }

        public int Upper
        {
            get { return upper; }
        }

        public override bool OnCatch(object sender, BallInPlayEventArgs e)
        {
            if (e.distanceOfFly > FieldingDistanceLow && e.distanceOfFly < FieldingDistanceHigh)
            {
                if (e.angleOfFly > FieldingAngleLeft && e.angleOfFly < FieldingAngleRight)
                {
                    message("打擊者:我被接殺了!\r\n");
                    return true;
                }
            }
            return false;
        }
    }
}
