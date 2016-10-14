using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6___多邊體計算視窗程式
{
    abstract class Shape
    {//此為抽象類別，不可以實體化，因為形狀不是任何一種形狀
        private static int count = 0;
        protected static double Pi = 3.14159;
        protected double density=0;
        public Shape Next = null;

        abstract public string getObjName();//每個形狀名字不一樣, 留給衍生類實作

        public Shape()
        {
            count++;
        }

        ~Shape()
        {
            count--;
        }

        public static int Count
        {//從物件外只能get, 不能set
            get { return count; }
        }

        public double Density
        {//這是屬性
            get {return density; }
        }
        

        public double getWeight()
        {//重量=體積*密度, 不須另外宣告變數存放
            return getBulk() * density;
        }

        public abstract double getBulk();//體積演算法每種形狀都不同, 留給衍生類實作
    }
}
