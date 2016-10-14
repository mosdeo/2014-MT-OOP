using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    class Ball
    {
        private int distanceOfFly;
        private int angleOfFly;
        //事件
        public delegate bool CatchEventHandler(object sender, BallInPlayEventArgs e);
        public event CatchEventHandler inField;

        public delegate void RangeEventHandler(object sender,BallInPlayEventArgs e);
        public event RangeEventHandler isInRange;

        //委託
        public delegate void HitOrOutEventHandler(bool isCatched);
        public HitOrOutEventHandler hitOrOut;
        public delegate void Message(string str);
        public Message message;


        public Ball(int distance, int angle)
        {
            DistanceOfFly = distance;
            AngleOfFly = angle;
        }
        public int DistanceOfFly
        {
            get {return distanceOfFly;}
            set
            {
                if (value < 0)
                    distanceOfFly = 0;
                else
                    distanceOfFly = value;
            }

        }
        public int AngleOfFly
        {
            get { return angleOfFly; }
            set
            {
                if ((value <= 180) && (value >= -180))
                    angleOfFly = value;
                else
                    angleOfFly = 0;
            }
        }
        public void OnBallInPlay()
        {
            message("打擊出去!\r\n");
            message(ToString());
            BallInPlayEventArgs e = new BallInPlayEventArgs(DistanceOfFly,AngleOfFly); //傳入球的資訊

            if (isInRange != null)
            {
                isInRange(this,e);
            }

            if (inField != null)
            {
                bool catchFlag = false;
                foreach (CatchEventHandler single in inField.GetInvocationList())
                {
                    catchFlag = single(this, e);
                    if (catchFlag)
                        break;
                }

                hitOrOut(catchFlag);
            }


        }
        public override string ToString()
        {
            string str = ("飛行距離"+ string.Format("{0}", DistanceOfFly));
            str += ("\t角度" + string.Format("{0}", AngleOfFly)+"\r\n");
            return str;
        }
    }

    class BallInPlayEventArgs : EventArgs
    {
        public int distanceOfFly;
        public int angleOfFly;
        public BallInPlayEventArgs(int distance, int angle)
        {
            distanceOfFly = distance;
            angleOfFly = angle;
        }
    }
}
