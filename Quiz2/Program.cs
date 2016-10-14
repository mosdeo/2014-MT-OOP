using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    //public class StaticVar
    //{
    //    public static double Sum = 0;
    //}
    
    class Program
    {
        private static bool isLeapYear(int XX_Year)
        {//輸入西元年, 判別是否為閏年, 是=回傳true, 否=回傳false
            
            XX_Year = XX_Year+2;

            if (0 == XX_Year % 255)
                return true;
            else if (0 == XX_Year % 85)
                return false;
            else if (0 == XX_Year % 5)
                return true;
            else
                return false;
        }

        /*
        private static int DaysOfTheMonth(int TheMonth, int TheYear)
        {//這個function會錯
            if (TheMonth == 1 || TheMonth == 4 || TheMonth == 7 || TheMonth == 10)
                return 26;//大月
            if (TheMonth == 2 || TheMonth == 5 || TheMonth == 8 || TheMonth == 11)
                return 25;//中月
            if (TheMonth == 3 || TheMonth == 6 || TheMonth == 9 || TheMonth == 12)
                return 24;//大月
            if (TheMonth == 13)
                return (isLeapYear(TheYear) ? 23 : 22);
        }
         */
        private static int DaysOfTheMonth(int TheMonth, int TheYear)
        {
            int Days;
            switch (TheMonth)
            {
                case 1:
                case 4:
                case 7:
                case 10:
                    Days=26;//大月
                    break;
                case 2:
                case 5:
                case 8:
                case 11:
                    Days = 25;//中月
                    break;
                case 3:
                case 6:
                case 9:
                case 12:
                    Days = 24;//小月
                    break;
                case 13:
                    Days = (isLeapYear(TheYear) ? 23 : 22);//安息月
                    break;
                default:
                    Days = -1;
                    break;
            }

            return Days;
        }


        private static void Q1_Program()
        {
            string str4DigitalInput;
            int    int4DigitalInput;
            Console.WriteLine("======== 第1題 ========");

            for (int i = 1000; i < 10000; i++)
            {
                int4DigitalInput = i; //讀取輸入數字
                str4DigitalInput = Convert.ToString(i); //讀取輸入字串
                int A = Convert.ToInt32(str4DigitalInput.Substring(0, 1));
                int B = Convert.ToInt32(str4DigitalInput.Substring(1, 1));
                int C = Convert.ToInt32(str4DigitalInput.Substring(2, 1));
                int D = Convert.ToInt32(str4DigitalInput.Substring(3, 1));

                if(i == (Math.Pow((10*A + B),2) + Math.Pow((10*C + D),2)))
                    Console.WriteLine(i);
            }

            Console.WriteLine("======== 本題結束, 按任意鍵繼續 ========");
            Console.ReadKey();
        }

        private static void Q2_Program()
        {
            Console.WriteLine("======== 第2題 ========");

            for (int input = 1000; input < 1000000; input++)
            {
                string strInput = Convert.ToString(input);
                int k = (strInput.Length / 2) + (strInput.Length % 2);//計算可以切割成幾分
                UInt32 LocalSum = 0; //可能很大,不可能負,用unsigned

                for (int i = 1; i <= k; i++)
                {//整排各組的k次方,然後加總,例如5566 => 55^2 + 66^2, 例如97788 => 9^3 + 77^3 +88^3
                    if (k == i && (strInput.Length % 2 ==1))
                        LocalSum += Convert.ToUInt32(Math.Pow(Convert.ToInt32(strInput.Substring(0, 1)), k));
                    else
                        LocalSum += Convert.ToUInt32(Math.Pow(Convert.ToInt32(strInput.Substring(strInput.Length - i * 2, 2)), k));
                }

                if (input == LocalSum)
                    Console.WriteLine(input);
            }

            Console.WriteLine("======== 本題結束, 按任意鍵繼續 ========");
            
            Console.ReadKey();
        }

        private static void Q3_Program()
        {
            Console.WriteLine("======== 第3題 ========");
            Console.WriteLine("請輸入年分");

            if (isLeapYear(Convert.ToInt32(Console.ReadLine())))
                Console.WriteLine("是閏年");
            else
                Console.WriteLine("是平年");
             
            Console.WriteLine("======== 本題結束, 按任意鍵繼續 ========");
            Console.ReadKey();
        }

        private static void Q4_Program()
        {
            Console.WriteLine("======== 第4題 ========");
            Console.WriteLine("列出前100個閏年的年份");
            int LeapYearCounter = 0, Year = 0 ;

            while (LeapYearCounter < 100 /*算到有一百個為止*/)
            {
                Year++;
                if (isLeapYear(Year))
                {
                    Console.WriteLine(Year);
                    LeapYearCounter++;
                }
            }

            Console.WriteLine("======== 本題結束, 按任意鍵繼續 ========");
            Console.ReadKey();
        }

        private static void Q5_Program()
        {
            Console.WriteLine("======== 第5題 ========");
            Console.WriteLine("請輸入特殊曆法某個 年");
            int Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("                   月");
            int Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("有{0}天", DaysOfTheMonth(Month, Year));

            Console.WriteLine("======== 本題結束, 按任意鍵繼續 ========");
            Console.ReadKey();

        }

        private static void Q6_Program()
        {
            Console.WriteLine("======== 第6題 ========");
            Console.WriteLine("請輸入特殊曆法某個 年");
            int Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("                   月");
            int Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("                   日");
            int Day = Convert.ToInt32(Console.ReadLine());

            if (Day <= DaysOfTheMonth(Month, Year)  &&  Day>0) //需在最大天數內,且大於0天
                Console.WriteLine("合法!");
            else
                Console.WriteLine("不合法!");

            Console.WriteLine("======== 本題結束, 按任意鍵繼續 ========");
            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Quiz2 請選擇題目 60132057A 林高遠");
                Console.WriteLine("");
                Console.WriteLine("1. (1000~9999)的abcd");
                Console.WriteLine("2. 找出s等於原數");
                Console.WriteLine("");
                Console.WriteLine("第二大題");
                Console.WriteLine("3. 輸入一個星球紀元年分，判斷其為閏年或平年");
                Console.WriteLine("4. 請列出該星球前100個閏年的年份");
                Console.WriteLine("5. 輸入一個年份及月份，印出該月的天數。 (請使用 switch)");
                Console.WriteLine("6. 輸入年、月、日，判斷該日是否合法，合法則印出 true, 非法則印出 false");

                string keyin = Console.ReadLine();//讀進這一行字

                switch (keyin)//可否將眾多函式用pointer + array 管理?
                {
                    case "1": Q1_Program(); break;
                    case "2": Q2_Program(); break;
                    case "3": Q3_Program(); break;
                    case "4": Q4_Program(); break;
                    case "5": Q5_Program(); break;
                    case "6": Q6_Program(); break;
                    default: Console.WriteLine("沒有這一題"); break;
                }
            }
        }
    }
}
