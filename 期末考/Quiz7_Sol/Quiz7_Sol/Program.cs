using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz7
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date;
           
            while (true)
            {
                Console.WriteLine("break?");
                if (Console.ReadLine() == "Y")
                    break;
                Console.WriteLine("Please input date:");
                try
                {
                    if (Date.tryParse(Console.ReadLine(), out date))
                    {
                        Console.WriteLine(date.ToString());
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Error: {0}", e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error: {0}", e.Message);
                }
            }
            Console.Read();
        }
    }
}
