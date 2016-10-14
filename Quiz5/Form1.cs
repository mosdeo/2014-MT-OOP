using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz5
{
    public partial class Form1 : Form
    {
        List<Shape> ListShape = new List<Shape>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNewShape_Click(object sender, EventArgs e)
        {
            //============= 使用者輸入檢查 =============
            //bool CheckPass = false;
            //============= 使用者輸入檢查 =============

            //============= 密度抓取 =============
            double LocalDensity = -99999;
            if (cbBox_Metrial.SelectedItem == "鋁") LocalDensity = MetrialConst.Density_Al;
            if (cbBox_Metrial.SelectedItem == "鐵") LocalDensity = MetrialConst.Density_Fe;
            if (cbBox_Metrial.SelectedItem == "鉛") LocalDensity = MetrialConst.Density_Pb;
            //============= 密度抓取 =============

            for (int i = 0; i < Convert.ToInt16(txtBox_AddNewShapeNumber.Text); i++)
            {
                double DummyDouble = 0;

                //============= Anti stupid =============
                if (!double.TryParse(txtBox_Parameter1.Text, out DummyDouble)) txtBox_Parameter1.Text = "0";
                if (!double.TryParse(txtBox_Parameter2.Text, out DummyDouble)) txtBox_Parameter2.Text = "0";
                //============= Anti stupid =============

                double Parameter1 = Convert.ToDouble(txtBox_Parameter1.Text);
                double Parameter2 = Convert.ToDouble(txtBox_Parameter2.Text);

                if (cbBox_Shape.SelectedItem == "球")
                {
                    double radius = Parameter1;
                    ListShape.Add(new Ball(radius, LocalDensity));
                    txtBox_Message.AppendText(ListShape[ListShape.Count-1].ObjType() + " "
                                    + "體積:" + ListShape[ListShape.Count-1].Bulk() + " "
                                    + "重量:" + ListShape[ListShape.Count-1].Weight() + " "
                                    + "密度:" + ListShape[ListShape.Count-1].Density + " "
                                    + "\n");
                }
                if (cbBox_Shape.SelectedItem == "立方體")
                {
                    double side = Parameter1;
                    ListShape.Add(new Cube(side, LocalDensity));
                    txtBox_Message.AppendText(ListShape[ListShape.Count-1].ObjType() + " "
                                    + "體積:" + ListShape[ListShape.Count-1].Bulk() + " "
                                    + "重量:" + ListShape[ListShape.Count-1].Weight() + " "
                                    + "密度:" + ListShape[ListShape.Count-1].Density + " "
                                    + "\n");

                }
                if (cbBox_Shape.SelectedItem == "圓柱體")
                {
                    double radius = Parameter1;
                    double height = Parameter2;
                    ListShape.Add(new Cylinder(radius,height,LocalDensity));
                    txtBox_Message.AppendText(ListShape[ListShape.Count-1].ObjType() + " "
                                    + "體積:" + ListShape[ListShape.Count-1].Bulk() + " "
                                    + "重量:" + ListShape[ListShape.Count-1].Weight() + " "
                                    + "密度:" + ListShape[ListShape.Count-1].Density + " "
                                    + "\n");
                }
                if (cbBox_Shape.SelectedItem == "金字塔")
                {
                    double side = Parameter1;
                    double height = Parameter2;
                    ListShape.Add(new Pyramid(side, height, LocalDensity));
                    txtBox_Message.AppendText(ListShape[ListShape.Count-1].ObjType() + " "
                                    + "體積:" + ListShape[ListShape.Count-1].Bulk() + " "
                                    + "重量:" + ListShape[ListShape.Count-1].Weight() + " "
                                    + "密度:" + ListShape[ListShape.Count-1].Density + " "
                                    + "\n");
                }
            }
        }

        private void btnFindWeighestObj_Click(object sender, EventArgs e)
        {
            Shape WeighestObj = ListShape[0]; //放第0個物件進去，比較重就換掉

            for (int i = 0; i < ListShape.Count; i++)
            {
                if (ListShape[i].Weight() > WeighestObj.Weight())
                {
                    WeighestObj = ListShape[i];
                }
            }

            string strMessage = "最重的是:\n"
                                + WeighestObj.ObjType() + " "
                                + "體積:" + WeighestObj.Bulk() + " "
                                + "重量:" + WeighestObj.Weight() + " "
                                + "密度:" + WeighestObj.Density + " "
                                + "\n";

            MessageBox.Show(strMessage);

        }

        private void cbBox_Shape_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBox_Shape.SelectedItem == "球")
            {
                /*Parameter1*/
                label_Parameter1.Text = "半徑"; txtBox_Parameter1.Visible = true;

                /*Parameter2*/
                label_Parameter2.Text = ""; txtBox_Parameter2.Visible = false;
            }
            if (cbBox_Shape.SelectedItem == "立方體")
            {
                /*Parameter1*/
                label_Parameter1.Text = "邊長"; txtBox_Parameter1.Visible = true;

                /*Parameter2*/
                label_Parameter2.Text = ""; txtBox_Parameter2.Visible = false;
            }
            if (cbBox_Shape.SelectedItem == "圓柱體")
            {
                /*Parameter1*/
                label_Parameter1.Text = "半徑"; txtBox_Parameter1.Visible = true;

                /*Parameter2*/
                label_Parameter2.Text = "高度"; txtBox_Parameter2.Visible = true;
            }
            if (cbBox_Shape.SelectedItem == "金字塔")
            {
                /*Parameter1*/
                label_Parameter1.Text = "邊長"; txtBox_Parameter1.Visible = true;

                /*Parameter2*/
                label_Parameter2.Text = "高度"; txtBox_Parameter2.Visible = true;
            }
        }
    }
}
