using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委託與事件練習
{
    class Cat
    {
        private string name;

        public Cat(string name)
        {
            this.name = name;
        }

        public delegate void CatShoutEventHandler(object Sender,CatShoutEventArg args); //function為什麼會變成一個類型?

        public event CatShoutEventHandler CatShout;

        public void Shout()
        {
            Console.WriteLine("喵,我是{0}",name);

            if (CatShout != null)
            {
                CatShoutEventArg e = new CatShoutEventArg();
                e.Name = this.name;
                CatShout(this,e); //如果CatShout中有登記事件,就執行
            }
        }
    }

    class CatShoutEventArg : EventArgs
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
