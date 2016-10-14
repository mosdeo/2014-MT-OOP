using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6___多邊體計算視窗程式
{
    class Ball : Shape
    {
        public double radius=0;
        private static int count = 0;

        public override string getObjName() { return "Ball"; }

        public Ball(double p_radius, double p_density)
        {
            this.density = p_density;
            this.radius = p_radius;
            count++;
        }

        ~Ball()
        {
            count--;
        }

        new public static int Count
        {//從物件外只能get, 不能set
            get { return count; }
        }

        public override double getBulk()
        {
            return (4.0 / 3.0) * Pi * radius * radius * radius;
        }
    }
}
