using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7___多邊體計算視窗程式2
{
    class Cube : Shape
    {
        private static int _count = 0;
        new public static int Count { get { return _count; } }

        //長度參數
        private double _side = 0;

        //建構子
        public Cube(double side, double density)
        {
            this.Density = density;
            this._side = side;
            _count++;
        }

        //解構子
        ~Cube()
        {
            _count--;
        }

        public override double Bulk()
        {
            return _side*_side*_side;
        }
    }
}
