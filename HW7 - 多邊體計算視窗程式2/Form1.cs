using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7___多邊體計算視窗程式2
{
    public partial class Form1 : Form
    {
        private List<Shape> ListShape = new List<Shape>();

        public Form1()
        {
            InitializeComponent();
        }

        private double DensityTable(string material)
        {
            if (material == "鐵") return MetrialConst.Density_Fe;
            if (material == "冰") return MetrialConst.Density_Ice;
            if (material == "木材") return MetrialConst.Density_Wood;

            return -9999;
        }

        private void btnAddNewShape_Click(object sender, EventArgs e)
        {
            ///================ 使用者輸入檢查 開始 ================
            bool CheckPass = false; //標記使用者是否通過防呆檢查
            string Forget = "";     //存放使用者忘記輸入的項目
            int DummyInt;           //供int.TryParse()檢查用
            double DummyDouble;     //供double.TryParse()檢查用

            //逐條審查,不可用switch case
            if (null == cbBox_Material.SelectedItem)Forget += "　材質";
            if (null == cbBox_Shape.SelectedItem) Forget += "　形狀";
            if (!int.TryParse(txtBox_AddNewShapeNum.Text, out DummyInt)) Forget += "　數量";
            if (!double.TryParse(txtBox_ShapeParameter1.Text, out DummyDouble)) Forget += "　第1個形狀參數";
            if ((cbBox_Shape.SelectedItem.ToString() == "圓柱體") || (cbBox_Shape.SelectedItem.ToString() == "金字塔"))
            {
                if ("" == txtBox_ShapeParameter2.Text) Forget += "　第2個形狀參數";
            }

            //拋出檢查結果. 若無錯誤就Pass
            if ("" != Forget)
                MessageBox.Show("你忘記輸入" + Forget + " !\a");
            else
                CheckPass = true;//無錯誤
            ///================ 使用者輸入檢查 結束 ================

            //若是沒有通過防呆檢查,以下這個迴圈會被by pass
            for(int i=0; CheckPass && i<Convert.ToInt16(txtBox_AddNewShapeNum.Text);i++)
            {
                double _localDensity = DensityTable(cbBox_Material.Text);//取得選單所選之密度數值

                switch (cbBox_Shape.SelectedItem.ToString())
                {
                    case "球":
                        {
                            double _tempRadius = Convert.ToDouble(txtBox_ShapeParameter1.Text);
                            ListShape.Add(new Ball(_tempRadius, _localDensity));
                            txtBox_ShapeList1.AppendText("Ball \t"
                                + "半徑=" + Convert.ToString(_tempRadius) + " "
                                + "\n");
                        }
                        break;

                    case "正方體":
                        {
                            double _tempSide = Convert.ToDouble(txtBox_ShapeParameter1.Text);
                            ListShape.Add(new Cube(Convert.ToDouble(txtBox_ShapeParameter1.Text), _localDensity));
                            txtBox_ShapeList1.AppendText("Cube \t"
                                + "邊長=" + Convert.ToString(_tempSide) + " "
                                + "\n");
                        }
                        break;

                    case "圓柱體":
                        {
                            double _tempRadius = Convert.ToDouble(txtBox_ShapeParameter1.Text);
                            double _tempHeight = Convert.ToDouble(txtBox_ShapeParameter2.Text);
                            ListShape.Add(new Cylinder(_tempRadius, _tempHeight, _localDensity));
                            txtBox_ShapeList1.AppendText("Cylinder \t"
                                + "半徑=" + Convert.ToString(_tempRadius) + " "
                                + "高度=" + Convert.ToString(_tempHeight) + " "
                                + "\n");
                        }
                        break;

                    case "金字塔":
                        {
                            double _tempSide = Convert.ToDouble(txtBox_ShapeParameter1.Text);
                            double _tempHeight = Convert.ToDouble(txtBox_ShapeParameter2.Text);
                            ListShape.Add(new Pyramid(_tempSide, _tempHeight, _localDensity));
                            txtBox_ShapeList1.AppendText("Pyramid \t"
                                + "邊長=" + Convert.ToString(_tempSide) + " "
                                + "高度=" + Convert.ToString(_tempHeight) + " "
                                + "\n");
                        }
                        break;
                }
            }
        }

        private void cbBox_Shape_SelectedIndexChanged(object sender, EventArgs e)
        {//顯示介面控制, 當使用者改變 形狀 時, 動態更動UI

            switch (cbBox_Shape.SelectedItem.ToString())
            {
                case "球":
                    {
                        labelParameter1.Text = "直徑"; txtBox_ShapeParameter1.Visible = true;
                        labelParameter2.Text = ""; txtBox_ShapeParameter2.Visible = false;
                    }
                    break;

                case "正方體":
                    {
                        labelParameter1.Text = "邊長"; txtBox_ShapeParameter1.Visible = true;
                        labelParameter2.Text = ""; txtBox_ShapeParameter2.Visible = false;
                    }
                    break;

                case "圓柱體":
                    {
                        labelParameter1.Text = "直徑"; txtBox_ShapeParameter1.Visible = true;
                        labelParameter2.Text = "高"; txtBox_ShapeParameter2.Visible = true;
                    }
                    break;

                case "金字塔":
                    {
                        labelParameter1.Text = "邊長"; txtBox_ShapeParameter1.Visible = true;
                        labelParameter2.Text = "高"; txtBox_ShapeParameter2.Visible = true;
                    }
                    break;
            }
        }

        private void btnCalcShapeParameter_Click(object sender, EventArgs e)
        {
            txtBox_ShapeList2.Clear();

            for (int i = 0; i < ListShape.Count ; i++)
            {
                txtBox_ShapeList2.AppendText( ListShape[i].GetType().Name + "\t "
                                            + "密度:" + ListShape[i].Density.ToString("f2") + "\t "
                                            + "體積:" + ListShape[i].Bulk().ToString("f2") + "\t "
                                            + "重量:" + ListShape[i].Weight().ToString("f2") + "\t "
                                            + "\n");
            }
        }

        private void btnCalcRollDistance_Click(object sender, EventArgs e)
        {
            txtBox_ShapeListForRollDistance.Clear();//清除畫面
            List<IRollable> RollableList = new List<IRollable>();//宣告管理可滾動物件的陣列,每次重新配置

            for (int i = 0; i < ListShape.Count; i++)//檢查每一個由Shape refenece 管理的物件
            {
                //取得 ListShape[i] 的類別資訊
                bool _isBallObj = ListShape[i] is Ball;
                bool _isCylinderObj = ListShape[i] is Cylinder;
                
                if (_isBallObj || _isCylinderObj)
                {//如果是可以滾動的Shape衍生類,就進來
                    RollableList.Add((IRollable)ListShape[i]); //加入可滾動的List之中 
                    txtBox_ShapeListForRollDistance.AppendText(
                        ((Shape)RollableList[RollableList.Count-1]).GetType().Name + "\t " +
                        "滾動距離:" + RollableList[RollableList.Count-1].RollDistance().ToString("f2") + "\t " + 
                        "\n");
                }
            }//迴圈結束
        }

        private void txtBox_ShapeParameter1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
