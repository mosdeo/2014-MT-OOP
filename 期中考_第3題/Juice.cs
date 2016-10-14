using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期中考
{
    class Juice:Drink
    {
        private string kind = "果汁";
        private double PricePerCC;

        public Juice(double volume, double discount, double p_PricePerCC)
            : base(volume,discount)
        {
            PricePerCC = p_PricePerCC;
            kindNum = 3;
        }

        override public int OriginalPrice()
        {//等比例收費
            return (int)(Volume * PricePerCC);
        }

        override public string Kind() { return kind; }
    }
}
