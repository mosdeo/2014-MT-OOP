using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3
{
    class Point
    {
        public double X, Y;
    }

    class Triangle
    {
        private Point[] P; //has a Point
        private double[] Side;

        public Triangle()
        {
            P = new Point[3];
            P[0] = new Point();
            P[1] = new Point();
            P[2] = new Point();
            Side = new double[3];
        }

        //以任意順序輸入三點, 輸入完最後一點時, 同時完成三邊長的計算, 但不檢驗是否合法
        //"觀察者模式"不適合用在此, 因為三角形平移時不一定要知道邊長, 但是持續更新邊長計算量會很大
        public void setPoint0(double X, double Y){ P[0].X = X; P[0].Y = Y; RenewDistance(); }
        public void setPoint1(double X, double Y){ P[1].X = X; P[1].Y = Y; RenewDistance(); }
        public void setPoint2(double X, double Y){ P[2].X = X; P[2].Y = Y; RenewDistance(); }

        //求兩點距離
        public static double Distance(Point P1, Point P2)
        {
            return Math.Sqrt(Math.Pow(P1.X - P2.X, 2) + Math.Pow(P1.Y - P2.Y, 2));
        }

        private void RenewDistance()
        {//更新3個邊長
            Side[0] = Math.Sqrt(Math.Pow(P[0].X - P[1].X, 2) + Math.Pow(P[0].Y - P[1].Y,2));
            Side[1] = Math.Sqrt(Math.Pow(P[1].X - P[2].X, 2) + Math.Pow(P[1].Y - P[2].Y,2));
            Side[2] = Math.Sqrt(Math.Pow(P[2].X - P[0].X, 2) + Math.Pow(P[2].Y - P[0].Y,2));
        }

        public bool isValid()// 檢查三角形是否合法
        {
            if (Side[0] >= (Side[1] + Side[2])) return false;
            if (Side[1] >= (Side[2] + Side[0])) return false;
            if (Side[2] >= (Side[0] + Side[1])) return false;
            else return true;
        }

        public double Perimeter()// 計算周長
        {
            return Side[0] + Side[1] + Side[2];
        }

        public double Area()// 計算面積
        {
            double S = (Side[0] + Side[1] + Side[2])/2;
            return Math.Sqrt(S * (S - Side[0]) * (S - Side[1]) * (S - Side[2]));
        }

        public double RadiusOfCircumcircle()// 計算外接圓半徑
        {
            return (Side[0] + Side[1] + Side[2]) / (4 * Area());
        }
        
        public bool isRight()// 檢查三角形是否為直角
        {
            if (Math.Pow(Side[0], 2) < Math.Pow(Side[1], 2) + Math.Pow(Side[2], 2)) return true;
            if (Math.Pow(Side[1], 2) < Math.Pow(Side[2], 2) + Math.Pow(Side[0], 2)) return true;
            if (Math.Pow(Side[2], 2) < Math.Pow(Side[0], 2) + Math.Pow(Side[1], 2)) return true;
            else return false;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle T = new Triangle();

            while (true)
            {
                double X,Y;

                Console.WriteLine("60132057A 林高遠");
                Console.WriteLine("");
                Console.WriteLine("請輸入P[0].X");
                X = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("請輸入P[0].Y");
                Y = Convert.ToDouble(Console.ReadLine());
                T.setPoint0(X,Y);

                Console.WriteLine("請輸入P[1].X");
                X = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("請輸入P[1].Y");
                Y = Convert.ToDouble(Console.ReadLine());
                T.setPoint1(X, Y);

                Console.WriteLine("請輸入P[2].X");
                X = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("請輸入P[2].Y");
                Y = Convert.ToDouble(Console.ReadLine());
                T.setPoint2(X, Y);

                if (!T.isValid())
                {
                    Console.WriteLine("這個三角形不合法! 重新輸入\n");
                    continue;
                }

                Console.WriteLine("周長={0}",T.Perimeter());
                Console.WriteLine("面積={0}",T.Area());
                Console.WriteLine("外接圓半徑={0}",T.RadiusOfCircumcircle());

                if(T.isRight())
                    Console.WriteLine("這是直角三角形\n");
                else
                    Console.WriteLine("這不是直角三角形\n");
            }
        }
    }
}
