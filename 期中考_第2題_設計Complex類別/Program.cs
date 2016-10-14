using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期中考_第2題_設計Complex類別
{
    class Program
    {
        static void Main(string[] args)
        {
            double Real, Imag;

            Console.WriteLine("請輸入複數的實部");
            Real = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("請輸入複數的虛部");
            Imag = Convert.ToDouble(Console.ReadLine());

            Complex num1 = new Complex(Real,Imag);

            //絕對值
            Console.WriteLine("{0}的絕對值={1}\n",num1.ToString(),num1.Magitude());
            
            //倒數計算
            Complex num2 = Complex.Reciprocal(num1);
            Console.WriteLine("{0}的倒數  ={1}\n",num1.ToString(),num2.ToString());

            //次方
            for (int i = 0; i <= 5; i++)
            {
                Complex numExpResult = null;

                if(0==i)
                    numExpResult = new Complex(1,0);
                else if(1==i)
                    numExpResult = num1;
                else
                {
                    numExpResult = num1;

                    for(int j=2;j<=i;j++)
                        numExpResult = Complex.Multiply(numExpResult,num1);
                }

                Console.WriteLine("(" + num1.ToString() + ")^" + i + "=" + numExpResult.ToString());
            }

            Console.ReadKey();
        }
    }
}
