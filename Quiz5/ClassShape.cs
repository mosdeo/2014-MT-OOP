using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz5
{
    abstract class Shape
    {
        private double density = 0;

        public Shape(double p_density)
        {
            density = p_density;
        }

        abstract public string ObjType();//回傳物件類型
        abstract public double Bulk(){return -9999;}//算體積
        public double Density
        {
            get { return density; }
        }

        public double Weight()//算重量
        {
            return Bulk() * density;
        }

    }
}
