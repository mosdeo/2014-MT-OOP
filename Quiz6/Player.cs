using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz6
{
    abstract class Player
    {
        private int fieldingDistanceLow;
        private int fieldingDistanceHigh;
        private int fieldingAngleLeft;
        private int fieldingAngleRight;
        protected PlayerType.Type type;
        public delegate void Message(string str);
        public Message message;
        public Player(int distanceLow, int distanceHigh, int angleLeft, int angleRight)
        {
            FieldingDistanceLow = distanceLow;
            FieldingDistanceHigh = distanceHigh;
            FieldingAngleLeft = angleLeft;
            FieldingAngleRight = angleRight;
        }

        public int FieldingDistanceLow
        {
            get { return fieldingDistanceLow; }
            set
            {
                if (value < 0)
                    fieldingDistanceLow = 0;
                else
                    fieldingDistanceLow = value;
            }

        }
        public int FieldingDistanceHigh
        {
            get { return fieldingDistanceHigh; }
            set
            {
                if (value < 0)
                    fieldingDistanceHigh = 0;
                else
                    fieldingDistanceHigh = value;
            }

        }
        public int FieldingAngleLeft
        {
            get { return fieldingAngleLeft; }
            set
            {
                if ((value <= 180) && (value >= -180))
                    fieldingAngleLeft = value;
                else
                    fieldingAngleLeft = 0;
            }
        }
        public int FieldingAngleRight
        {
            get { return fieldingAngleRight; }
            set
            {
                if ((value <= 180) && (value >= -180))
                    fieldingAngleRight = value;
                else
                    fieldingAngleRight = 0;
            }
        }
        public abstract bool OnCatch(object sender,BallInPlayEventArgs e);
    }

    class PlayerType
    {
        public enum Type {Unknown=0,Pitcher,SecondBaseMan,CenterField};
    }
}
