using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            Complex[] InputNum = new Complex[4];

            try
            {
                Complex.Create(txt_Num1Real.Text, txt_Num1Imag.Text, out InputNum[0]);
                Complex.Create(txt_Num2Real.Text, txt_Num2Imag.Text, out InputNum[1]);
                Complex.Create(txt_Num3Real.Text, txt_Num3Imag.Text, out InputNum[2]);
                Complex.Create(txt_Num4Real.Text, txt_Num4Imag.Text, out InputNum[3]);
                txt_Result.AppendText(Complex.AbsMax(InputNum).ToString());
            }
            catch
            {
                MessageBox.Show("有輸入不是數字！");
            }

            
        }

    }
   
}
