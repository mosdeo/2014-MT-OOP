using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期中考
{
    abstract class Drink
    {
        static private int objCount = 0;
        //private string kind = "Drink";
        public int kindNum;
        private double volume; //建構時傳入, 之後不能修改
        private double disconut = 1;

        public Drink(double p_volume, double p_discount)
        {
            objCount++;
            volume = p_volume;
            disconut = p_discount;
        }

        static public int ObjCount { get { return objCount;}}
        abstract public string Kind();
        public double Discount { get {return disconut;}}
        public double Volume { get { return volume; } }
       

        public int SpecialPrice()
        {//折扣為價錢演算法共同部分，獨立於基礎類別
            return (int)(disconut * OriginalPrice());//折扣一定要浮點數，故必須強制轉型
        }

        abstract public int OriginalPrice(); //留給子類別實現, 因為每種飲料計價方式不同
    }
}
