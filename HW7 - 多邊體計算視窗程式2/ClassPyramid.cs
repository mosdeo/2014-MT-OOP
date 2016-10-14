using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7___多邊體計算視窗程式2
{
    class Pyramid : Shape
    {
        private static int _count = 0;
        new public static int Count { get { return _count; } }

        //長度參數
        private double _side = 0;
        private double _height = 0;

        //建構子
        public Pyramid(double side, double height, double density)
        {
            this.Density = density;
            this._side = side;
            this._height = height;
            _count++;
        }

        //解構子
        ~Pyramid()
        {
            _count--;
        }

        public override double Bulk()
        {
            double _dSide = _side/1000;
            double _dHeight = _height/1000;
            double _tempBulk=0;

            for (int i=0; i<1000 ; i++ )
            {//從最底下的那片體積往上加，邊長一直縮小
                double _currentSide = _side - (i * _dSide * 0.5); //0.5 使 side 修正到斜邊中點
                _tempBulk += _currentSide * _currentSide * _dHeight;
            }

            return _tempBulk;
        }
    }
}
