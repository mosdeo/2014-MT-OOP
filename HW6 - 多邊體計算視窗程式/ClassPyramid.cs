using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6___多邊體計算視窗程式
{
    class Pyramid : Shape
    {
        public double side;
        public double height;
        private static int count = 0;

        public override string getObjName() { return "Pyramid"; }

        public Pyramid(double p_side, double p_height, double p_density)
        {
            this.density = p_density;
            this.side = p_side;
            this.height = p_height;
            count++;
        }

        ~Pyramid()
        {
            count--;
        }

        new public static int Count
        {//從物件外只能get, 不能set
            get { return count; }
        }

        public override double getBulk()
        {
            double Dside = side/1000;
            double Dheight = height/1000;
            double tempBulk=0;

            for (int i=0; i<1000 ; i++ )
            {//從最底下的那片體積往上加，邊長一直縮小
                double CurrentSide = side - (i * Dside * 0.5); //0.5 使 side 修正到斜邊中點
                tempBulk += CurrentSide * CurrentSide * Dheight;
            }

            return tempBulk;
        }
    }
}
