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
        public bool IsHomeRun(int distanceOfFly,int angleOfFly)
        {
            //撰寫程式碼
            return false;
        }
        public bool IsFoul(int distanceOfFly, int angleOfFly)
        {
            //撰寫程式碼
            return false;
        }
    }
}
