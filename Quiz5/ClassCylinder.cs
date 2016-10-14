using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz5
{
    class Cylinder:Shape
    {
        private double radius = 0;
        private double height = 0;

        public Cylinder(double p_radius, double p_height, double p_density)
            : base(p_density)
        {
            height = p_height;
            radius = p_radius;
        }

        public override string ObjType() { return "Cylinder"; }

        public override double Bulk()
        {
            return GeoConst.pi * radius * radius * height;
        }
    }
}
