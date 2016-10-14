using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDateTime date = new MyDateTime();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("HW2 60132057A 林高遠");
                Console.WriteLine("");
                Console.WriteLine("請輸入年分");
                date.Year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("請輸入月份");
                date.Month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("請輸入日份");
                date.Day = Convert.ToInt32(Console.ReadLine());

                if (!date.isLegal())
                {
                    Console.WriteLine("不合法的日期! 重新輸入\a");
                    Console.WriteLine("按任意鍵繼續...");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("**********************************");
                Console.WriteLine("{0} 是 {1}  ", date.Year, date.isLeap() ? "閏年" : "平年");
                Console.WriteLine("{0} 是 {1}天", date.Year, date.DaysOfYear());
                Console.WriteLine("{0}/{1} 是 {2}天", date.Year, date.Month, date.DaysOfMonth());
                Console.WriteLine("{0}/{1}/{2} 是 {3}", date.Year, date.Month, date.Day, date.WeekDay());
                Console.WriteLine("**********************************");
                Console.Write("\n繼續? (Y/N=other):");
                if ("Y" != Console.ReadLine().ToUpper(/*Anti-stupid*/)) break;
            }
        }
    }
}