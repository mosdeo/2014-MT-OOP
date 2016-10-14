using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class MyPoint_C
    {
        public double X;
        public double Y;
        public double DistanceTo(MyPoint_C p)
        {
            return Math.Sqrt( Math.Pow(p.X - X,2) +  Math.Pow(p.Y - Y,2) );
        }
    }
}
