using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委託與事件練習
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Tom");
            Mouse mouse1 = new Mouse("Jerry");
            Mouse mouse2 = new Mouse("Jack");

            cat.CatShout += new Cat.CatShoutEventHandler(mouse1.Run); //將Method透過delegate登記到event中
            cat.CatShout += new Cat.CatShoutEventHandler(mouse2.Run);

            cat.Shout();

            Console.Read();
        }
    }
}
