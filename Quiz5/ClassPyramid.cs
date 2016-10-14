using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz5
{
    class Pyramid:Shape
    {
        private double side = 0;
        private double height = 0;

        public Pyramid(double p_side, double p_height, double p_density)
            : base(p_density)
        {
            side = p_side;
            height = p_height;
        }

        public override string ObjType() { return "Pyramid"; }

        public override double Bulk()
        {
            return side * side * height / 3.0;
        }
    }
}
