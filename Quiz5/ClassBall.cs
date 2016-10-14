using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz5
{
    class Ball:Shape
    {
        private double radius = 0;

        public Ball(double p_radius, double p_density)
            : base(p_density)
        {
            radius = p_radius;
        }

        public override string ObjType() { return "Ball"; }

        //public override double Bulk()
        //{
        //    return GeoConst.pi * radius * radius * radius *(4.0 / 3.0);
        //}
    }
}
