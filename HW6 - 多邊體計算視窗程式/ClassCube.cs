using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6___多邊體計算視窗程式
{
    class Cube : Shape
    {
        public double side;
        private static int count = 0;

        public override string getObjName() { return "Cube"; }

        public Cube(double p_side, double p_density)
        {
            this.density = p_density;
            this.side = p_side;
            count++;
        }

        ~Cube()
        {
            count--;
        }

        new public static int Count
        {//從物件外只能get, 不能set
            get { return count; }
        }

        public override double getBulk()
        {
            return side*side*side;
        }
    }
}
