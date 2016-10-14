using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8___多邊體計算視窗程式3
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
            if (material == "木材") return MetrialConst.Density_Wood;
            if (material == "冰") return MetrialConst.Density_Ice;
            if (material == "鋁") return MetrialConst.Density_Al;
            if (material == "鐵") return MetrialConst.Density_Fe;
            if (material == "鉛") return MetrialConst.Density_Pb;

            return -9999;
        }

        private void btnAddNewShape_Click(object sender, EventArgs e)
        {
            ///================ 使用者輸入檢查 開始 ================
            bool _checkPass = false; //標記使用者是否通過防呆檢查
            string _forget = "";     //存放使用者忘記輸入的項目
            int _dummyInt;           //供int.TryParse()檢查用
            double _dummyDouble;     //供double.TryParse()檢查用

            //逐條審查,不可用switch case
            if (null == cbBox_Material.SelectedItem)_forget += "　材質";
            if (null == cbBox_Shape.SelectedItem) _forget += "　形狀";
            if (!int.TryParse(txtBox_AddNewShapeNum.Text, out _dummyInt)) _forget += "　數量";
            if (!double.TryParse(txtBox_ShapeParameter1.Text, out _dummyDouble)) _forget += "　第1個形狀參數";
            if ((cbBox_Shape.SelectedItem.ToString() == "圓柱體") || (cbBox_Shape.SelectedItem.ToString() == "金字塔"))
            {
                if ("" == txtBox_ShapeParameter2.Text) _forget += "　第2個形狀參數";
            }

            //拋出檢查結果. 若無錯誤就Pass
            if ("" != _forget)
                MessageBox.Show("你忘記輸入" + _forget + " !\a");
            else
                _checkPass = true;//無錯誤
            ///================ 使用者輸入檢查 結束 ================

            //若是沒有通過防呆檢查,以下這個迴圈會被by pass
            for(int i=0; _checkPass && i<Convert.ToInt16(txtBox_AddNewShapeNum.Text);i++)
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
                                );
                        }
                        break;

                    case "正方體":
                        {
                            double _tempSide = Convert.ToDouble(txtBox_ShapeParameter1.Text);
                            ListShape.Add(new Cube(Convert.ToDouble(txtBox_ShapeParameter1.Text), _localDensity));
                            txtBox_ShapeList1.AppendText("Cube \t"
                                + "邊長=" + Convert.ToString(_tempSide) + " "
                                );
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
                                );
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
                                );
                        }
                        break;
                }

                txtBox_ShapeList1.AppendText("編號=" + ListShape.Last().SerialNumber + "\n");
                ReflashNumberOfEachClass();
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
            if (null == cbBox_SortAlgorithms.SelectedItem)
            {//使用者輸入檢查
                MessageBox.Show("未選擇排序法! 依預設順序列出");
            }
            else
            {
                switch (cbBox_SortAlgorithms.SelectedItem.ToString())
                {
                    case "順序":ListShape.Sort(Sort.BySerialNumber);break;
                    case "形狀":ListShape.Sort(Sort.ByShape);break;
                    case "材質":ListShape.Sort(Sort.ByMetrial);break;
                    case "體積":ListShape.Sort(Sort.ByBulk);break;
                    case "重量":ListShape.Sort(Sort.ByWeight);break;
                }
            }

            txtBox_ShapeList2.Clear();//清除畫面

            for (int i = 0; i < ListShape.Count ; i++)
            {//開始依序列出
                txtBox_ShapeList2.AppendText( ListShape[i].GetType().Name + "\t "
                                            + "密度:" + ListShape[i].Density.ToString("f2") + "\t "
                                            + "體積:" + ListShape[i].Bulk().ToString("f2") + "\t "
                                            + "重量:" + ListShape[i].Weight().ToString("f2") + "\t "
                                            + "編號=" + ListShape[i].SerialNumber
                                            + "\n");
            }
        }

        private void btnCalcRollDistance_Click(object sender, EventArgs e)
        {
            txtBox_ShapeListForRollDistance.Clear();//清除畫面

            for (int i = 0; i < ListShape.Count; i++)//檢查每一個由Shape refenece 管理的物件
            {
                //取得 ListShape[i] 的類別資訊
                bool _isIRollable = ListShape[i] is IRollable;

                if (_isIRollable)
                {//如果是可以滾動的Shape衍生類,就進來
                    IRollable _tempRollable = ListShape[i] as IRollable; //向下轉型
                    
                    txtBox_ShapeListForRollDistance.AppendText(
                        _tempRollable.GetType().Name + "\t " +
                        "滾動距離:" + _tempRollable.RollDistance().ToString("f2") + "\t " + 
                        "\n");
                }
            }//迴圈結束
        }

        private void ReflashNumberOfEachClass()
        {
            label_NumberOfEachClass.Text = "球體=" + Ball.Count + " "
                                            + "正方體=" + Cube.Count + " "
                                            + "圓柱體=" + Cylinder.Count + " "
                                            + "金字塔=" + Pyramid.Count + " "
                                            ;
        }

        private void btnDeleteSomeOneShape_Click(object sender, EventArgs e)
        {
            bool _find = false;

            for (int i = 0; i < ListShape.Count; i++)
            {
                if (ListShape[i].SerialNumber == Convert.ToInt32(txtBox_DeleteSomeOneShapeSerialNum.Text))
                {
                    //強迫回收
                    ListShape[i] = null;
                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    //清除空位置
                    ListShape.RemoveAt(i);

                    _find = true;
                    break;
                }
            }

            ReflashNumberOfEachClass();

            if (!_find)
                MessageBox.Show("這個編號的物件不存在!\a");
        }
    }
}
