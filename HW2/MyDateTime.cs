using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class MyDateTime
    {
        public int Year, Month, Day;
        private readonly int[] DaysOfEachMonth;
        private readonly string[] ChineseWeekDay;

        public MyDateTime()
        {
            DaysOfEachMonth = new int[13] { -99999, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            ChineseWeekDay = new string[7] { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
        }

        public bool isLeap()
        {//預設引數不能是變數,只好用這個很奇怪的方法
            return isLeap(this.Year);
        }

        public bool isLeap(int inputYear)
        {
            if (0 == inputYear % 400)
                return true;
            else if (0 == inputYear % 100)
                return false;
            else if (0 == inputYear % 4)
                return true;
            else
                return false;
        }

        public void Print()
        {
            Console.WriteLine("{0}/{1}/{2}", Year, Month, Day);
        }

        public int DaysOfYear()
        {
            return isLeap() ? 366 : 365;
        }

        public int DaysOfMonth()
        {//預設引數不能是變數,只好用這個很奇怪的方法
            return DaysOfMonth(this.Month, this.Year);
        }

        public int DaysOfMonth(int TheMonth, int TheYear)
        {
            if (2 == TheMonth && isLeap(TheYear)) //此為閏月特徵
                return 29;
            else
                return DaysOfEachMonth[TheMonth];
        }

        public bool isLegal()
        {
            if (Month < 1 || Month > 12) return false; // 月數不在 [1,12] 的閉區間內
            else if (Day < 1 || Day > DaysOfMonth()) return false;  // 天數不在 [1,該月最後一天] 的閉區間內
            else return true; //合法
        }

        public string WeekDay()
        {
            int DayDistanceTo2000_1_2 = 0;

            for (int i = Math.Min(Year, 2000); i < Math.Max(Year, 2000); i++)
            {
                if (Year >= 2000) DayDistanceTo2000_1_2 += isLeap(i) ? 366 : 365;
                else DayDistanceTo2000_1_2 -= isLeap(i) ? 366 : 365;
            }

            for (int i = 1; i < Month; i++)
                DayDistanceTo2000_1_2 += DaysOfMonth(i, this.Year);

            DayDistanceTo2000_1_2 += Day;
            DayDistanceTo2000_1_2 -= 2; //shift

            if (0 > (DayDistanceTo2000_1_2 %= 7)) //若 %7 餘數為負
                DayDistanceTo2000_1_2 += 7; //以7天為一周, 相位角標準化 to 0~6 之間

            return ChineseWeekDay[DayDistanceTo2000_1_2];
        }
    }
}
