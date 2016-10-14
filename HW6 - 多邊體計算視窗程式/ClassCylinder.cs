using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6___多邊體計算視窗程式
{
    class Cylinder : Shape
    {
        public double radius;
        public double height;
        private static int count = 0;

        public override string getObjName() { return "Cylinder"; }

        public Cylinder(double p_radius, double p_height, double p_density)
        {
            this.density = p_density;
            this.radius = p_radius;
            this.height = p_height;
            count++;
        }

        ~Cylinder()
        {
            count--;
        }

        new public static int Count
        {//從物件外只能get, 不能set
            get { return count; }
        }

        public override double getBulk()
        {
            return Pi * radius * radius * height;
        }
    }
}
