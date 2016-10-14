using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8___多邊體計算視窗程式3
{
    abstract class Shape
    {//此為抽象類別，不可以實體化，因為形狀不是任何一種形狀
        private static int _count = 0;
        public static int Count { get { return _count; } }

        private double _density = 0;
        public double Density 
        { 
            get { return _density; }
            set { _density = value; }
        }

        static private int _serialNumber; //報名流水號(目前最後的,只增不減)
        public readonly int SerialNumber; //報名流水號(每個物件自己的,new 後不可改)

        //建構子
        public Shape()
        {
            _count++;
            SerialNumber = _serialNumber++;
        }

        //解構子
        ~Shape()
        {
            _count--;
        }
        
        public double Weight()
        {//重量=體積*密度, 不須另外宣告變數存放
            return Bulk() * _density;
        }

        public abstract double Bulk();//體積演算法每種形狀都不同, 留給衍生類實作
    }
}
