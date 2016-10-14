using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期中考_第2題_設計Complex類別
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

        public double Real { get{return real;}}
        public double Imag { get{return imag;}}

        //物件方法
        public double Magitude()
        {
            return Math.Sqrt(real * real + imag * imag);
        }
        public static Complex Reciprocal(Complex num) //倒數
        {
            double LocalReal = num.Real / (num.Real * num.Real + num.Imag * num.Imag);
            double LocalImag = -(num.Imag / (num.Real * num.Real + num.Imag * num.Imag));
            return new Complex(LocalReal, LocalImag);
        }
        public static Complex Multiply(Complex num1, Complex num2) //相乘
        {
            double LocalReal = (num1.Real*num2.Real)-(num1.Imag*num2.Imag);
            double LocalImag = (num1.Real*num2.Imag)+(num1.Imag*num2.Real);
            return new Complex(LocalReal, LocalImag);
        }
        //public static Complex Power(Complex num, int exp) //複數次方
        //{
        //    return;
        //}

        //改寫
        public override string ToString()//列印複數
        {
            string ReturnStr = "";
            ReturnStr += (this.real == 0)? ""  : this.real.ToString("f4"); //產生實部字串,4捨5入到小數點後第4位

            if (this.imag != 0)//產生虛部字串
            {
                ReturnStr += (this.real!=0 && this.imag > 0) ? "+":"";//若Real不為0,且Imag為正,給Imag加上"+"
                ReturnStr += this.imag.ToString("f4") + "i"; //產生虛部字串,4捨5入到小數點後第4位
            }
            return ReturnStr;
        }
    }
}
