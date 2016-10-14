using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8___多邊體計算視窗程式3
{
    class Cylinder : Shape,IRollable
    {
        private static int _count = 0;
        new public static int Count { get { return _count; } }

        //長度參數
        private double _radius = 0;
        private double _height = 0;

        //建構子
        public Cylinder(double radius, double height, double density)
        {
            this.Density = density;
            this._radius = radius;
            this._height = height;
            _count++;
        }

        //解構子
        ~Cylinder()
        {
            _count--;
        }

        public override double Bulk()
        {
            return GeoConst.Pi * _radius * _radius * _height;
        }

        public double RollDistance()
        {//prototype at Interface
            return _radius * 5;
        }
    }
}
