using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//user using
using System.Threading;

namespace 多執行緒
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th0 = new Thread(new ThreadStart(task0));
            Thread th1 = new Thread(new ThreadStart(task1));
            Thread th = new Thread(new ParameterizedThreadStart(task));

            th0.Start();
            th1.Start();
            th.Start(" test ");
        }

        private static void task(object obj)
        {
            while (true)
                Console.Write(obj.ToString());
        }

        static void task0()
        {
            while(true)
                Console.Write("0");
        }

        static void task1()
        {
            while(true)
                Console.Write("1");
        }
    }
}