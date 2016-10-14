using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Triangle
    {
        public Point[] P; //has a Point
        public double[] Side;

        public Triangle()
        {
            P = new Point[3];
            P[0] = new Point();
            P[1] = new Point();
            P[2] = new Point();
            Side = new double[3];
        }

        //"觀察者模式"不適合用在此, 因為三角形平移時不一定要知道邊長, 但是持續更新邊長計算量會很大
        public void setPoint0(double X, double Y) { P[0].X = X; P[0].Y = Y;}
        public void setPoint1(double X, double Y) { P[1].X = X; P[1].Y = Y;}
        public void setPoint2(double X, double Y) { P[2].X = X; P[2].Y = Y;}

        //求兩點距離
        public static double Distance(Point P1, Point P2)
        {
            return Math.Sqrt(Math.Pow(P1.X - P2.X, 2) + Math.Pow(P1.Y - P2.Y, 2));
        }

        private void ReNew3Side()
        {//更新3個邊長
            Side[0] = Math.Sqrt(Math.Pow(P[0].X - P[1].X, 2) + Math.Pow(P[0].Y - P[1].Y, 2));
            Side[1] = Math.Sqrt(Math.Pow(P[1].X - P[2].X, 2) + Math.Pow(P[1].Y - P[2].Y, 2));
            Side[2] = Math.Sqrt(Math.Pow(P[2].X - P[0].X, 2) + Math.Pow(P[2].Y - P[0].Y, 2));
        }

        public bool isValid()// 檢查三角形是否合法
        {
            ReNew3Side();
            if (Side[0] >= (Side[1] + Side[2])) return false;
            if (Side[1] >= (Side[2] + Side[0])) return false;
            if (Side[2] >= (Side[0] + Side[1])) return false;
            else return true;
        }

        public double Perimeter()// 計算周長
        {
            ReNew3Side();
            return Side[0] + Side[1] + Side[2];
        }

        public double Area()// 計算面積
        {
            ReNew3Side();
            double S = (Side[0] + Side[1] + Side[2]) / 2;
            return Math.Sqrt(S * (S - Side[0]) * (S - Side[1]) * (S - Side[2]));
        }

        public double RadiusOfCircumcircle()// 計算外接圓半徑
        {
            ReNew3Side();
            return (Side[0] + Side[1] + Side[2]) / (4 * Area());
        }

        public bool isRight()// 檢查三角形是否為直角
        {
            ReNew3Side();
            if (Math.Pow(Side[0], 2) < Math.Pow(Side[1], 2) + Math.Pow(Side[2], 2)) return true;
            if (Math.Pow(Side[1], 2) < Math.Pow(Side[2], 2) + Math.Pow(Side[0], 2)) return true;
            if (Math.Pow(Side[2], 2) < Math.Pow(Side[0], 2) + Math.Pow(Side[1], 2)) return true;
            else return false;
        }

    }
}
