using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_3
{
    class Complex
    {
        private double real;
        private double imag;
        //建構子
        public Complex(double real, double imag)
        {
            this.real = real;
            this.imag = imag;
        }
        //Property
        public double Real
        {
            get { return real; }
            set { real = value; }
        }
        public double Imag
        {
            get { return imag; }
            set { imag = value; }
        }
        //複數相乘
        public static Complex operator *(Complex num1,Complex num2)
        {
            Complex result = new Complex(0, 0);
            result.Real = num1.Real*num2.Real-num1.Imag*num2.Imag;
            result.Imag = num1.Real*num2.Imag+num1.Imag*num2.Real;
            return result;
        } //複數相乘
        //改寫
        public override string ToString()
        {
            if (Imag == 0)
                return string.Format("{0:0.####}", Real);
            else if (Real == 0)
                return string.Format("{0:0.####}i", Imag);
            else
                return string.Format("{0:0.####}{1}{2:0.####}i", Real, (Imag > 0 ? '+' : '-'), Math.Abs(Imag));
        }  //列印複數

        //以下開始修改程式碼

        // 輸入實部與虛部字串, 
        //若real 或 imag 不是數字回傳 false, num 為 null
        //若 real 及 imag 均為數字回傳 true, 將建立複數物件 num 
        public static bool Create(string real, string imag, out Complex num)
        {
            double tempReal, tempImag;

            if (!double.TryParse(real, out tempReal))
            {
                num = null;
                return false;
            }

            if (!double.TryParse(imag, out tempImag))
            {
                num = null;
                return false;
            }

            num = new Complex(tempReal, tempImag);

            return true;
        }

        public double Abs()
        {
            return Math.Pow((this.real * this.real + this.imag * this.imag), 0.5);
        }


        // 比較運算子> 程式碼 
        // 若 num1 的絕對值 > num2 的絕對值 則回傳 true
        public static bool operator >(Complex num1, Complex num2)
        {
            if (num1.Abs() > num2.Abs())
                return true;
            else
                return false;
        }

        public static bool operator <(Complex num1, Complex num2)
        {
            if (num1.Abs() < num2.Abs())
                return true;
            else
                return false;
        }
        // 求輸入的複數中, 其絕對值最大者, 使用params 
        public static Complex AbsMax(params Complex[] num)
        {
            Complex MaxAbsComplex = num[0];

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] > MaxAbsComplex)
                    MaxAbsComplex = num[i];
            }

            return MaxAbsComplex;
        } //複數的次方 
    }
  
}
