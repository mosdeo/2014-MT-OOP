using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    class Pitcher:Player
    {
        public Pitcher(int distanceLow, int distanceHigh, int angleLeft, int angleRight)
            : base(distanceLow, distanceHigh, angleLeft, angleRight)
        {
            type = PlayerType.Type.Pitcher;
        }
        public override bool OnCatch(object sender, BallInPlayEventArgs e)
        {
            if (e.distanceOfFly > FieldingDistanceLow && e.distanceOfFly < FieldingDistanceHigh)
            {
                if (e.angleOfFly > FieldingAngleLeft && e.angleOfFly < FieldingAngleRight)
                {
                    message("投手:我接住球了!\r\n");
                    return true;
                }
            }
            return false;
        }
    }
}
