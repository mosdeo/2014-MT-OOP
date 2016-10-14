using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
{
    class Program
    {
        //宣告平年的月份陣列
        int[] MonthArray = new int[13] { -1, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private bool isLeapYear(int AC_Year)
        {//輸入西元年, 判別是否為閏年, 是=回傳true, 否=回傳false
            if (0 == AC_Year % 400)
                return true;
            else if (0 == AC_Year % 100)
                return false;
            else if (0 == AC_Year % 4)
                return true;
            else
                return false;
        }

        private void Q1_Program()
        {
            Console.WriteLine("======== 第1題 ========");
            for (int i = 100; i < 1000; i++)
            {
                /*百位*/
                int a = i / 100;
                /*十位*/
                int b = (i % 100) / 10;
                /*個位*/
                int c = i % 10;
                if (a * a * a + b * b * b + c * c * c == i)
                    Console.WriteLine(i);

            }
            Console.WriteLine("三位數阿姆斯壯數找查結束");
            Console.WriteLine("======== 本題結束 ========");
            Console.ReadKey();
        }

        private void Q2_Program()
        {
            Console.WriteLine("======== 第2題 ========");
            Console.WriteLine("請輸入一個西元年分");
            int AC_Year = Convert.ToInt32(Console.ReadLine());//讀進這一行字,轉換為整數
            
            if(this.isLeapYear(AC_Year))
                Console.WriteLine("是閏年");
            else
                Console.WriteLine("是平年");

            Console.WriteLine("======== 本題結束 ========");
            Console.ReadKey();
        }

        private void Q3_Program()
        {
            int AC_Year;
            int Month;
            bool bLeapYear;

            Console.WriteLine("======== 第3題 ========");
            Console.WriteLine("請輸入一個西元年分");
            AC_Year = Convert.ToInt32(Console.ReadLine());//讀進這一行字,轉換為整數
            bLeapYear = this.isLeapYear(AC_Year);
   
            while(true)
            {
                Console.WriteLine("請輸入一個月分");
                Month = Convert.ToInt32(Console.ReadLine());//讀進這一行字,轉換為整數
                if (Month > 12 || Month < 0)//不是正確的月份
                    Console.WriteLine("請勿亂打!!!");
                else//正確就跳出
                    break;
            }

            if(2==Month)
            {
                if(bLeapYear)
                    Console.WriteLine("28天");
            }
            else
            {
                Console.Write(this.MonthArray[Month]);
                Console.WriteLine("天");
            }

            Console.WriteLine("======== 本題結束 ========");
            Console.ReadKey();
        }

        private void Q4_Program() { }
        private void Q5_Program() { }
        private void Q6_Program() { }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("請選擇題目");
                Console.WriteLine("1. 印出三位數阿姆斯壯數");
                Console.WriteLine("2. 輸入一個西元年份，判斷其為閏年或平年");
                Console.WriteLine("3. 輸入一個西元年份及月份，印出該月的天數");
                Console.WriteLine("4. 輸入年、月、日，印出該日是星期幾");
                Console.WriteLine("5. 輸入年、月、日，判斷該日是否合法");
                Console.WriteLine("6. 輸入兩個日期，起始年、月、日以及結束年、月、日，印出這兩個日期之間(不包含起始日與結束日)有多少日");

                string keyin = Console.ReadLine();//讀進這一行字
                Program temp = new Program();//感覺多此一舉?

                switch (keyin)//可否將眾多函式用pointer + array 管理?
                {
                    case "1":temp.Q1_Program();break;
                    case "2":temp.Q2_Program();break;
                    case "3":temp.Q3_Program();break;
                    case "4":temp.Q4_Program();break;
                    case "5":temp.Q5_Program();break;
                    case "6":temp.Q6_Program();break;
                    default: Console.WriteLine("沒有這一題"); break;
                }
            }
        }

        
    }
}
