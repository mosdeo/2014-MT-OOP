using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_2
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

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
