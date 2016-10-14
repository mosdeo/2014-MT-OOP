using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Year,Month,Day;
            bool isStupid = false;
            int[] BarPosition = new int[3];

            rtxtBoxOutput.Clear();


            if (10 != txtBoxInput.Text.Length)
            {
                //保留
                isStupid = true;
            }

            
            int Count=0;
            for (int i = 0; i < txtBoxInput.Text.Length; i++)
            {
                if ("/" == txtBoxInput.Text[i].ToString())
                {
                    BarPosition[Count] = i;
                    Count++;
                }
            }
            BarPosition[2] = txtBoxInput.Text.Length - 1;

            if (2 != Count)
            {
                rtxtBoxOutput.AppendText("年月日分隔錯誤\n");
                isStupid = true;
            }
            else if (2 != BarPosition[0])
            {//檢查月格式
                rtxtBoxOutput.AppendText("長度格式錯誤\n");
                rtxtBoxOutput.AppendText("月\n");
                rtxtBoxOutput.AppendText(BarPosition[0] + "位數\n");
                isStupid = true;
            }
            else if (3 != BarPosition[1] - BarPosition[0])
            {//檢查日格式
                rtxtBoxOutput.AppendText("長度格式錯誤\n");
                rtxtBoxOutput.AppendText("日\n");
                // -1 是要減掉 / 本身的長度
                rtxtBoxOutput.AppendText(BarPosition[1] - BarPosition[0] -1 + "位數\n");
                isStupid = true;
            }
            else if (4 != BarPosition[2] - BarPosition[1])
            {//檢查日格式
                rtxtBoxOutput.AppendText("長度格式錯誤\n");
                rtxtBoxOutput.AppendText("年\n");
                rtxtBoxOutput.AppendText(BarPosition[2] - BarPosition[1] + "位數\n");
                isStupid = true;
            }

           
            if (!isStupid)
            {
                int.TryParse(txtBoxInput.Text.Substring(0, 2), out Month);
                int.TryParse(txtBoxInput.Text.Substring(3, 2), out Day);
                int.TryParse(txtBoxInput.Text.Substring(6, 4), out Year);
                String OutputDate = Year + "年" + Month + "月" + Day + "日";
                rtxtBoxOutput.AppendText(OutputDate);

                if (Year <= 0)
                {
                    rtxtBoxOutput.Clear();
                    rtxtBoxOutput.AppendText("Year must be Postitive!\n");
                    rtxtBoxOutput.AppendText("參數名稱:Year\n");
                    rtxtBoxOutput.AppendText("實際的值為:" + Year +"\n");
                }

                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = "06/092014";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = "6/09/2014";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = "06/9/2014";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtBoxInput.Text = "06/09/20140";
        }
    }
}
