using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7___多邊體計算視窗程式2
{
    class Ball : Shape, IRollable
    {
        private static int _count = 0;
        new public static int Count { get { return _count; } }

        //長度參數
        private double _radius = 0;
        
        //建構子
        public Ball(double radius, double density)
        {
            this.Density = density;
            this._radius = radius;
            _count++;
        }

        //解構子
        ~Ball()
        {
            _count--;
        }

        public override double Bulk()
        {
            return (4.0 / 3.0) * GeoConst.Pi * _radius * _radius * _radius;
        }

        public double RollDistance()
        {//prototype at Interface
            return _radius * _radius;
        }
    }
}
