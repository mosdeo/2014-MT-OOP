using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    class BaseBallField
    {
        private int size;
        private int angle;
        public BaseBallField(int size,int angle)
        {
            Size = size;
            Angle = angle;
        }
        public int Size
        {
            get { return size; }
            set
            {
                if (value < 0)
                    size = 0;
                else
                    size = value;
            }
        }
        public int Angle
        {
            get { return angle; }
            set
            {
                if (value < 0)
                    angle = 0;
                else
                    angle = value;
            }
        }
        public string Info(int distanceOfFly, int angleOfFly)
        {
            if (IsHomeRun(distanceOfFly, angleOfFly))
                return "全壘打";
            if (IsFoul(distanceOfFly, angleOfFly))
                return "界外球";
            return "界內";

        }
        private bool IsHomeRun(int distanceOfFly,int angleOfFly)
        {
            if (distanceOfFly > Size && Math.Abs(angleOfFly) < angle)
                return true;
            return false;
        }
        private bool IsFoul(int distanceOfFly, int angleOfFly)
        {
            if (Math.Abs(angleOfFly) > angle)
                return true;
            return false;
        }
    }
}
