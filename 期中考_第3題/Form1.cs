using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace 期中考
{
    public partial class Form1 : Form
    {
        List<Drink> DrinkList = new List<Drink>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_AppendDrink_Click(object sender, EventArgs e)
        {
            if (cbBox_KindOfDrink.SelectedItem == "水")
            {
                DrinkList.Add(new Water(Convert.ToDouble(txtBox_DirnkVolume.Text),
                                         Convert.ToDouble(txtBox_WaterDiscountRate.Text),
                                         Convert.ToInt32(txtBox_WaterUnifiedPrice.Text)
                                         ));

                txtBox_Bill.AppendText("水 "
                    + "折扣=" + DrinkList.Last().Discount + " "
                    + "容量=" + DrinkList.Last().Volume + " "
                    + "最後價格=" + DrinkList.Last().SpecialPrice() + " \n");
            }

            if (cbBox_KindOfDrink.SelectedItem == "汽水")
            {
                DrinkList.Add(new Soda(Convert.ToDouble(txtBox_DirnkVolume.Text),
                                         Convert.ToDouble(txtBox_SodaDiscountRate.Text)
                                         ));

                txtBox_Bill.AppendText("汽水 "
                    + "折扣=" + DrinkList.Last().Discount + " "
                    + "容量=" + DrinkList.Last().Volume + " "
                    + "最後價格=" + DrinkList.Last().SpecialPrice() + " \n");
            }

            if (cbBox_KindOfDrink.SelectedItem == "果汁")
            {
                DrinkList.Add(new Juice(Convert.ToDouble(txtBox_DirnkVolume.Text),
                                         Convert.ToDouble(txtBox_JuiceDiscountRate.Text),
                                         Convert.ToDouble(txtBox_JuicePricePerCC.Text)
                                         ));

                txtBox_Bill.AppendText("果汁 "
                    + "折扣=" + DrinkList.Last().Discount + " "
                    + "容量=" + DrinkList.Last().Volume + " "
                    + "最後價格=" + DrinkList.Last().SpecialPrice() + " \n");
            }

            txtBox_AppendedDrinkNumber.Text = Convert.ToString(Drink.ObjCount);
        }

        private void txtBox_DirnkVolume_TextChanged(object sender, EventArgs e)
        {

        }

        private void Swap(ref Drink A, ref Drink B)
        {
            Drink temp = A;
            A = B;
            B = A;
        }

        private int SortBySpecialPrice(Drink A, Drink B)
        {//List 專用排序函式
            if (A.SpecialPrice() > B.SpecialPrice())
                return 1;
            else
                return -1;
        }

        private int SortByKind(Drink A, Drink B)
        {//List 專用排序函式
            if (A.kindNum > B.kindNum)
                return 1;
            else
                return -1;
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            if(cbBox_BillSortAlgorithms.SelectedItem == "飲料類別")
            {
                DrinkList.Sort(SortByKind);
            }

            if (cbBox_BillSortAlgorithms.SelectedItem == "價錢")
            {
                DrinkList.Sort(SortBySpecialPrice);
            }
    
            //秀出帳單
            txtBox_Bill.Clear();//清除畫面
            int TotalPrice = 0;

            for (int i = 0; i < DrinkList.Count; i++)
            {
                TotalPrice += DrinkList[i].SpecialPrice();
                txtBox_Bill.AppendText(DrinkList[i].Kind() + "\t" + 
                                        DrinkList[i].Volume + "cc" + "\t"+
                                        DrinkList[i].Discount + "\t" +
                                        DrinkList[i].SpecialPrice() + "\n"
                                            );
            }

            txtBox_Bill.AppendText("總共\t" + TotalPrice +"元");
        }
    }
}
