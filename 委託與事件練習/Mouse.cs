using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委託與事件練習
{
    class Mouse
    {
        private string name;
        public Mouse(string name)
        {
            this.name = name;
        }

        public void Run()
        {
            Console.WriteLine("老貓來了,{0}快跑!",name);
        }

        public void Run(object sender,CatShoutEventArg args)
        {
            Console.WriteLine("老貓{0}來了,{1}快跑!",args.Name,name);
        }
    }
}
