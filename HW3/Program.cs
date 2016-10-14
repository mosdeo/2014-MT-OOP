using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Point
    {
        public double X, Y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            PinBoard board = new PinBoard();
            Triangle tri = new Triangle();
            Random rand = new Random();
            Console.WriteLine("60132057A 林高遠");

            while (true)
            {
                do{
                    Console.WriteLine("請輸入board的Rows:");
                    board.Rows = Convert.ToInt32(Console.ReadLine());
                    if (board.Rows <= 0) Console.WriteLine("必須大於0\a");
                } while (board.Rows <= 0);

                do
                {
                    Console.WriteLine("請輸入board的Cols:");
                    board.Cols = Convert.ToInt32(Console.ReadLine());
                    if (board.Cols <= 0) Console.WriteLine("必須大於0\a");
                } while (board.Cols <= 0);

                do
                {
                    Console.WriteLine("請輸入board的xInterval:");
                    board.xInterval = Convert.ToDouble(Console.ReadLine());
                    if (board.xInterval <= 0) Console.WriteLine("必須大於0\a");
                } while (board.xInterval <= 0);

                do
                {
                    Console.WriteLine("請輸入board的yInterval:");
                    board.yInterval = Convert.ToDouble(Console.ReadLine());
                    if (board.yInterval <= 0) Console.WriteLine("必須大於0\a");
                } while (board.yInterval <= 0);

                board.CreatePins();
                board.SetPinPositions();

                //以亂數設定tri的三個點
                do
                {   //產生的亂數小於 board.Rows 或 board.Cols
                    tri.setPoint0(rand.Next(board.Rows), rand.Next(board.Cols));
                    tri.setPoint1(rand.Next(board.Rows), rand.Next(board.Cols));
                    tri.setPoint2(rand.Next(board.Rows), rand.Next(board.Cols));

                    if (!tri.isValid())
                    {
                        Console.Write("這次隨機產生的三個點是 ");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write("({0},{1}) ", tri.P[i].X, tri.P[i].Y);
                        }
                        Console.WriteLine("\n不合法! 自動再來一次");
                    }
                } while (!tri.isValid());

                Console.Write("構成三角形的三個座標是 ");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("({0},{1}) ", tri.P[i].X, tri.P[i].Y);
                } Console.WriteLine("");

                Console.WriteLine("周長={0}",tri.Perimeter());
                Console.WriteLine("面積={0}",tri.Area());
                Console.WriteLine("外接圓半徑={0}",tri.RadiusOfCircumcircle());

                Console.Write("\n繼續? (Y/N=other):");
                if ("Y" != Console.ReadLine().ToUpper(/*Anti-stupid*/)) break;
            }
        }
    }
}
