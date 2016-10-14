using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz7
{
    class DateSpan
    {
        private int days;
        public DateSpan(int theDays)
        {
            Days = theDays;
        }
        public int Days
        {
            get { return days; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Days", value, "Days must be positive");
                else
                    days = value;
            }
        }
        public static DateSpan operator +(DateSpan date1, DateSpan date2)
        {
            DateSpan result = new DateSpan(1);
            result.Days = date1.Days + date2.Days;
            return result;
        }
    }
}
