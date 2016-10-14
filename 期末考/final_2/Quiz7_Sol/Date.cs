using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_2
{
    class Date
    {

        private int month;
        private int day;
        private static int[] daysPerMonth = { 0,31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        //auto implemented property year
        public int Year
        {
            get;
            private set;
        }

        public Date(int theYear, int theMonth, int theDay)
        {
            Year = theYear;
            Month = theMonth;
            Day = theDay;
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value > 0 && value <= 12)
                    month = value;
                else
                    //Exception Handling
                    throw new ArgumentOutOfRangeException("Month", value, "Month must be 1-12!");
            }
        }
        public int Day
        {
            get{return day;}
            set
            {
                if (value > 0 && value <= daysPerMonth[Month])
                    day = value;
                else if (IsLeap(Year) && (Month == 2) && value == 29)
                    day = value;
                else
                    throw new ArgumentOutOfRangeException("Day", value, "Day is invalid");
                }

        }
        private bool IsLeap(int theYear)
        {
            if ((theYear % 400 == 0) || (theYear % 4 == 0) && (theYear % 100 != 0))
                return true;
            else
                return false;

        }
        public override string ToString()
        {
            string str = "";
            str=string.Format("{0}年{1}月{2}日",Year,Month,Day);
            return str;
        }
        private static bool InternalParse(string[] dateStr,out Date date)
        {
            string [] name={"Year","Month","Day"};
            date = new Date(-1, 1, 1);
            int [] tmp={0,0,0}; 
            if (dateStr.Length != 3)
            {
                date = null;
                return false;
            }
            for (int i = 0; i < 3; i++)
            {
                if (!(int.TryParse(dateStr[i], out tmp[i])))
                {
                    throw new FormatException(name[i]+"\t error format!");
                }
            }

            date.Year = tmp[0];
            date.Month = tmp[1];
            date.Day = tmp[2];
            return true;
        }
        //將字串轉為 Date
        public static Date Parse(string formatter, string str)
        {
            Date date = null;
            string[] tmp=new string[3];
            char[] separators={'.','/'};
            switch(formatter)
            {
                case "00000000":
                    if (str.Length != 8)
                        return null;
                    else
                    {
                        tmp[2] = str.Substring(6, 2);
                        tmp[1] = str.Substring(4, 2);
                        tmp[0] = str.Substring(0, 4);
                    }
                    break;
                case "0000.00.00":
                case "0000/00/00":
                    tmp = str.Split(separators); //分割字串
                    break;
                case "00/00/0000":
                    tmp = str.Split(separators); //分割字串
                    string temp;
                    temp = tmp[2]; //year
                    tmp[2] = tmp[1];
                    tmp[1] = tmp[0];
                    tmp[0] = temp;
                    //撰寫程式碼
                    break;
                default:
                    break;

            }
            if (InternalParse(tmp, out date))
                return date;
            else
                return null;
        }


        public static bool tryParse(string str, out Date date)
        {
           
            char[] separators = { '.', '/' };
            string[] tmp = str.Split(separators);
            string formatter="";

            if (tmp.Count()==1)
            {
                formatter = "00000000";
            }
            else
            {
                if (tmp[0].Length == 4)
                {
                    formatter = "0000/00/00";
                }
                else
                {
                    formatter = "00/00/0000";
                }
            }
            date = Parse(formatter, str);
            if (date != null)
                return true;
            else
                return false;
        }
    }
}
