using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    class Umpire
    {
        private BaseBallField fieldSize = null;
        public delegate void Message(string str);
        public Message message;

        public Umpire(BaseBallField field)
        {
            fieldSize = field;
        }
      
        public void HitOrOut(bool isCatched)
        {
            if (isCatched)
                message("主審:接殺出局!\r\n");
            else
                message("主審:安打\r\n");
        }

        public void RangeInOrOut(object sender, BallInPlayEventArgs e)
        {
            bool isOutDistance = e.distanceOfFly > fieldSize.Size;
            bool inFieldAngle  = fieldSize.Angle > e.angleOfFly;

            if(!inFieldAngle)
                message("主審:界外\r\n");
            else if ( isOutDistance && inFieldAngle)
                message("主審:全壘打\r\n");
                
        }
    }
}
