using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LKY;
namespace 期末考第四題DLL載入測試
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("咪咪");
            Mouse mouse1 = new Mouse("米奇");
            Mouse mouse2 = new Mouse("米妮");
            cat.shoutDelegate += new Cat.EventDelegate(mouse1.Run);
            cat.shoutDelegate += new Cat.EventDelegate(mouse2.Help); cat.shoutDelegate += new Cat.EventDelegate(mouse2.Run); mouse1.runDelegate += new Mouse.EventDelegate(cat.Catch);
            mouse2.runDelegate += new Mouse.EventDelegate(cat.Catch);
            cat.Shout();
            Console.Read();
        }

    }
}
