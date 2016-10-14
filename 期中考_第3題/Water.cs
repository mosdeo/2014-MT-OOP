using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期中考
{
    class Water:Drink
    {
        private string kind = "水";
        private int UnifiedPrice;

        public Water(double volume, double discount, int p_UnifiedPrice)
            :base (volume,discount)
        {
            UnifiedPrice = p_UnifiedPrice;
            kindNum = 1;
        }

        override public int OriginalPrice()
        {
            return UnifiedPrice;
        }

        override public string Kind() { return kind; }
    }
}
