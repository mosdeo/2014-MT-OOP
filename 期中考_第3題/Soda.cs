using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期中考
{
    class Soda : Drink
    {
        private string kind = "汽水";

        public Soda(double volume, double discount)
            : base(volume,discount)
        {
            kindNum = 2;
        }

        override public int OriginalPrice()
        {//三區間定價
            if (Volume <= 500)
                return 50;
            else if (500 < Volume && Volume <= 1000)
                return 100;
            else
                return 150;
        }

        override public string Kind() { return kind; }
    }
}
