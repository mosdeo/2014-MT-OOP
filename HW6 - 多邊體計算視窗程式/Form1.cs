using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW6___多邊體計算視窗程式
{
    public partial class Form1 : Form
    {
        //private Shape[] shapeArray;
        //private Shape FirstShape;
private List<Shape> ListShape = new List<Shape>();

public Form1()
{
    InitializeComponent();
}

private double DensityTable(string p_Material)
{
    if (p_Material == "鐵") return  13;
    if (p_Material == "冰") return  1;
    if (p_Material == "木材") return 0.8;

    return -9999;
}

        private void btnAddNewShape_Click(object sender, EventArgs e)
        {
            ///================ 使用者輸入檢查 開始 ================
          
            bool CheckPass = false; //標記使用者是否通過防呆檢查
            string Forget = "";     //存放使用者忘記輸入的項目
            int DummyInt;           //供int.TryParse()檢查用
            double DummyDouble;     //供double.TryParse()檢查用

            if (null == cbBox_Material.SelectedItem)Forget += "　材質";
            if (null == cbBox_Shape.SelectedItem) Forget += "　形狀";
            if (!int.TryParse(txtBox_AddNewShapeNum.Text, out DummyInt)) Forget += "　數量";
            if (!double.TryParse(txtBox_ShapeParameter1.Text, out DummyDouble)) Forget += "　第1個形狀參數";
            if ((cbBox_Shape.SelectedItem == "圓柱體") || (cbBox_Shape.SelectedItem == "金字塔"))
            {
                if ("" == txtBox_ShapeParameter2.Text) Forget += "　第2個形狀參數";
            }

            //拋出檢查結果. 若無錯誤就Pass
            if ("" != Forget)
                MessageBox.Show("你忘記輸入" + Forget + " !\a");
            else
                CheckPass = true;

            ///================ 使用者輸入檢查 結束 ================

            //若是沒有通過防呆檢查,以下這個迴圈會被by pass
            for(int i=0; CheckPass && i<Convert.ToInt16(txtBox_AddNewShapeNum.Text);i++)
            {
                if (cbBox_Shape.SelectedItem == "球")
                {
                    double tempRadius = Convert.ToDouble(txtBox_ShapeParameter1.Text);
                    ListShape.Add(new Ball(tempRadius, DensityTable(cbBox_Material.Text)));

                    //顯示在txtBox_ShapeList
                    txtBox_ShapeList1.AppendText("Ball "
                        + "半徑="+ Convert.ToString(tempRadius) +" "
                        + "\n");
                }

                if (cbBox_Shape.SelectedItem == "正方體")
                {
                    double tempSide = Convert.ToDouble(txtBox_ShapeParameter1.Text);
                    ListShape.Add(new Cube(Convert.ToDouble(txtBox_ShapeParameter1.Text), DensityTable(cbBox_Material.Text)));

                    //顯示在txtBox_ShapeList
                    txtBox_ShapeList1.AppendText("Cube "
                        + "邊長=" + Convert.ToString(tempSide) + " "
                        + "\n");
                }

                if (cbBox_Shape.SelectedItem == "圓柱體")
                {
                    double tempRadius = Convert.ToDouble(txtBox_ShapeParameter1.Text);
                    double tempHeight = Convert.ToDouble(txtBox_ShapeParameter2.Text);
                    ListShape.Add(new Cylinder(tempRadius, tempHeight, DensityTable(cbBox_Material.Text)));

                    //顯示在txtBox_ShapeList
                    txtBox_ShapeList1.AppendText("Cylinder "
                        + "半徑=" + Convert.ToString(tempRadius) + " "
                        + "高度=" + Convert.ToString(tempHeight) + " "
                        + "\n");
                }

                if (cbBox_Shape.SelectedItem == "金字塔")
                {
                    double tempSide = Convert.ToDouble(txtBox_ShapeParameter1.Text);
                    double tempHeight = Convert.ToDouble(txtBox_ShapeParameter2.Text);
                    ListShape.Add(new Pyramid(tempSide, tempHeight, DensityTable(cbBox_Material.Text)));

                    //顯示在txtBox_ShapeList
                    txtBox_ShapeList1.AppendText("Pyramid"
                        + "邊長=" + Convert.ToString(tempSide) + " "
                        + "高度=" + Convert.ToString(tempHeight) + " "
                        + "\n");
                }

            }
        }

        private void cbBox_Shape_SelectedIndexChanged(object sender, EventArgs e)
        {//顯示介面控制, 當使用者改變 形狀 時, 動態更動UI
            if (cbBox_Shape.SelectedItem == "球")
            {
                labelParameter1.Text = "直徑"; txtBox_ShapeParameter1.Visible = true;
                labelParameter2.Text = "";     txtBox_ShapeParameter2.Visible = false;
            }

            if (cbBox_Shape.SelectedItem == "正方體")
            {
                labelParameter1.Text = "邊長"; txtBox_ShapeParameter1.Visible = true;
                labelParameter2.Text = "";     txtBox_ShapeParameter2.Visible = false;
            }

            if (cbBox_Shape.SelectedItem == "圓柱體")
            {
                labelParameter1.Text = "直徑"; txtBox_ShapeParameter1.Visible = true;
                labelParameter2.Text = "高";   txtBox_ShapeParameter2.Visible = true;
            }

            if (cbBox_Shape.SelectedItem == "金字塔")
            {
                labelParameter1.Text = "邊長"; txtBox_ShapeParameter1.Visible = true;
                labelParameter2.Text = "高";   txtBox_ShapeParameter2.Visible = true;
            }
        }

        private void btnCalcShapeParameter_Click(object sender, EventArgs e)
        {
            txtBox_ShapeList2.Clear();

            for (int i = 0; i < ListShape.Count ; i++)
            {
                txtBox_ShapeList2.AppendText( ListShape[i].getObjName() + " "
                                            + "密度:" + ListShape[i].Density + " "
                                            + "體積:" + ListShape[i].getBulk() + " "
                                            + "重量:" + ListShape[i].getWeight() + " "
                                            + "\n");
            }
        }
    }
}
