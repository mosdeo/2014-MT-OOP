using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8___多邊體計算視窗程式3
{
    //順序、依形狀、依材質、依體積、依重量

    static class Sort
    {//List 專用排序函式

        public static int BySerialNumber(Shape A, Shape B)
        {
            if (A.SerialNumber > B.SerialNumber)
                return 1;
            else
                return -1;
        }

        public static int ByShape(Shape A, Shape B)
        {
            for(int i = 0; i< Math.Min(A.GetType().Name.Length,B.GetType().Name.Length);i++)
            {
                if (A.GetType().Name[i] == B.GetType().Name[i])
                    continue; //對比下一個字

                if (A.GetType().Name[i] > B.GetType().Name[i])
                    return 1;
                else
                    return -1;
            }

            return 99999;
        }

        public static int ByMetrial(Shape A, Shape B)
        {
            if (A.Density > B.Density)
                return 1;
            else
                return -1;
        }

        public static int ByBulk(Shape A, Shape B)
        {
            if (A.Bulk() > B.Bulk())
                return 1;
            else
                return -1;
        }

        public static int ByWeight(Shape A, Shape B)
        {
            if (A.Weight() > B.Weight())
                return 1;
            else
                return -1;
        }


    }
}
