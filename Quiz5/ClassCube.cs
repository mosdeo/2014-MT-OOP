using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz5
{
    class Cube:Shape
    {
        private double side = 0;

        public Cube(double p_side, double p_density)
            : base(p_density)
        {
            side = p_side;
        }

        public override string ObjType() { return "Cube"; }

        public override double Bulk()
        {
            return side * side * side;
        }
    }
}
