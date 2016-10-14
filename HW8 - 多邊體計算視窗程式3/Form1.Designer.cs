namespace HW8___多邊體計算視窗程式3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cbBox_Material = new System.Windows.Forms.ComboBox();
            this.cbBox_Shape = new System.Windows.Forms.ComboBox();
            this.btnAddNewShape = new System.Windows.Forms.Button();
            this.txtBox_AddNewShapeNum = new System.Windows.Forms.TextBox();
            this.txtBox_ShapeParameter1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelParameter1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_ShapeList1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBox_ShapeParameter2 = new System.Windows.Forms.TextBox();
            this.labelParameter2 = new System.Windows.Forms.Label();
            this.txtBox_ShapeList2 = new System.Windows.Forms.TextBox();
            this.btnCalcShapeParameter = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCalcRollDistance = new System.Windows.Forms.Button();
            this.txtBox_ShapeListForRollDistance = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_DeleteSomeOneShapeSerialNum = new System.Windows.Forms.TextBox();
            this.btnDeleteSomeOneShape = new System.Windows.Forms.Button();
            this.label_NumberOfEachClass = new System.Windows.Forms.Label();
            this.cbBox_SortAlgorithms = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBox_Material
            // 
            this.cbBox_Material.FormattingEnabled = true;
            this.cbBox_Material.Items.AddRange(new object[] {
            "木材",
            "冰",
            "鋁",
            "鐵",
            "鉛"});
            this.cbBox_Material.Location = new System.Drawing.Point(63, 20);
            this.cbBox_Material.Name = "cbBox_Material";
            this.cbBox_Material.Size = new System.Drawing.Size(88, 20);
            this.cbBox_Material.TabIndex = 0;
            // 
            // cbBox_Shape
            // 
            this.cbBox_Shape.FormattingEnabled = true;
            this.cbBox_Shape.Items.AddRange(new object[] {
            "球",
            "正方體",
            "圓柱體",
            "金字塔"});
            this.cbBox_Shape.Location = new System.Drawing.Point(62, 20);
            this.cbBox_Shape.Name = "cbBox_Shape";
            this.cbBox_Shape.Size = new System.Drawing.Size(88, 20);
            this.cbBox_Shape.TabIndex = 1;
            this.cbBox_Shape.SelectedIndexChanged += new System.EventHandler(this.cbBox_Shape_SelectedIndexChanged);
            // 
            // btnAddNewShape
            // 
            this.btnAddNewShape.Location = new System.Drawing.Point(13, 21);
            this.btnAddNewShape.Name = "btnAddNewShape";
            this.btnAddNewShape.Size = new System.Drawing.Size(90, 39);
            this.btnAddNewShape.TabIndex = 2;
            this.btnAddNewShape.Text = "加入";
            this.btnAddNewShape.UseVisualStyleBackColor = true;
            this.btnAddNewShape.Click += new System.EventHandler(this.btnAddNewShape_Click);
            // 
            // txtBox_AddNewShapeNum
            // 
            this.txtBox_AddNewShapeNum.Location = new System.Drawing.Point(157, 31);
            this.txtBox_AddNewShapeNum.Name = "txtBox_AddNewShapeNum";
            this.txtBox_AddNewShapeNum.Size = new System.Drawing.Size(41, 22);
            this.txtBox_AddNewShapeNum.TabIndex = 3;
            this.txtBox_AddNewShapeNum.Text = "1";
            // 
            // txtBox_ShapeParameter1
            // 
            this.txtBox_ShapeParameter1.Location = new System.Drawing.Point(173, 47);
            this.txtBox_ShapeParameter1.Name = "txtBox_ShapeParameter1";
            this.txtBox_ShapeParameter1.Size = new System.Drawing.Size(57, 22);
            this.txtBox_ShapeParameter1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "材質";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "形狀";
            // 
            // labelParameter1
            // 
            this.labelParameter1.AutoSize = true;
            this.labelParameter1.Location = new System.Drawing.Point(22, 53);
            this.labelParameter1.Name = "labelParameter1";
            this.labelParameter1.Size = new System.Drawing.Size(35, 12);
            this.labelParameter1.TabIndex = 7;
            this.labelParameter1.Text = "參數1";
            this.labelParameter1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "數量";
            // 
            // txtBox_ShapeList1
            // 
            this.txtBox_ShapeList1.Location = new System.Drawing.Point(41, 329);
            this.txtBox_ShapeList1.Multiline = true;
            this.txtBox_ShapeList1.Name = "txtBox_ShapeList1";
            this.txtBox_ShapeList1.Size = new System.Drawing.Size(243, 127);
            this.txtBox_ShapeList1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbBox_Material);
            this.groupBox1.Location = new System.Drawing.Point(41, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 48);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "材質設定";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBox_ShapeParameter2);
            this.groupBox2.Controls.Add(this.labelParameter2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbBox_Shape);
            this.groupBox2.Controls.Add(this.txtBox_ShapeParameter1);
            this.groupBox2.Controls.Add(this.labelParameter1);
            this.groupBox2.Location = new System.Drawing.Point(41, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 79);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "形狀設定";
            // 
            // txtBox_ShapeParameter2
            // 
            this.txtBox_ShapeParameter2.Location = new System.Drawing.Point(56, 47);
            this.txtBox_ShapeParameter2.Name = "txtBox_ShapeParameter2";
            this.txtBox_ShapeParameter2.Size = new System.Drawing.Size(57, 22);
            this.txtBox_ShapeParameter2.TabIndex = 8;
            // 
            // labelParameter2
            // 
            this.labelParameter2.AutoSize = true;
            this.labelParameter2.Location = new System.Drawing.Point(137, 53);
            this.labelParameter2.Name = "labelParameter2";
            this.labelParameter2.Size = new System.Drawing.Size(35, 12);
            this.labelParameter2.TabIndex = 9;
            this.labelParameter2.Text = "參數2";
            this.labelParameter2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBox_ShapeList2
            // 
            this.txtBox_ShapeList2.Location = new System.Drawing.Point(298, 51);
            this.txtBox_ShapeList2.Multiline = true;
            this.txtBox_ShapeList2.Name = "txtBox_ShapeList2";
            this.txtBox_ShapeList2.Size = new System.Drawing.Size(463, 182);
            this.txtBox_ShapeList2.TabIndex = 12;
            // 
            // btnCalcShapeParameter
            // 
            this.btnCalcShapeParameter.Location = new System.Drawing.Point(298, 12);
            this.btnCalcShapeParameter.Name = "btnCalcShapeParameter";
            this.btnCalcShapeParameter.Size = new System.Drawing.Size(90, 33);
            this.btnCalcShapeParameter.TabIndex = 13;
            this.btnCalcShapeParameter.Text = "計算";
            this.btnCalcShapeParameter.UseVisualStyleBackColor = true;
            this.btnCalcShapeParameter.Click += new System.EventHandler(this.btnCalcShapeParameter_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtBox_AddNewShapeNum);
            this.groupBox3.Controls.Add(this.btnAddNewShape);
            this.groupBox3.Location = new System.Drawing.Point(41, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 66);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "增加Shape";
            // 
            // btnCalcRollDistance
            // 
            this.btnCalcRollDistance.Location = new System.Drawing.Point(298, 248);
            this.btnCalcRollDistance.Name = "btnCalcRollDistance";
            this.btnCalcRollDistance.Size = new System.Drawing.Size(90, 33);
            this.btnCalcRollDistance.TabIndex = 15;
            this.btnCalcRollDistance.Text = "計算滾動";
            this.btnCalcRollDistance.UseVisualStyleBackColor = true;
            this.btnCalcRollDistance.Click += new System.EventHandler(this.btnCalcRollDistance_Click);
            // 
            // txtBox_ShapeListForRollDistance
            // 
            this.txtBox_ShapeListForRollDistance.Location = new System.Drawing.Point(298, 287);
            this.txtBox_ShapeListForRollDistance.Multiline = true;
            this.txtBox_ShapeListForRollDistance.Name = "txtBox_ShapeListForRollDistance";
            this.txtBox_ShapeListForRollDistance.Size = new System.Drawing.Size(463, 169);
            this.txtBox_ShapeListForRollDistance.TabIndex = 16;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtBox_DeleteSomeOneShapeSerialNum);
            this.groupBox4.Controls.Add(this.btnDeleteSomeOneShape);
            this.groupBox4.Location = new System.Drawing.Point(41, 225);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 69);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "刪除Shape";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "編號";
            // 
            // txtBox_DeleteSomeOneShapeSerialNum
            // 
            this.txtBox_DeleteSomeOneShapeSerialNum.Location = new System.Drawing.Point(157, 30);
            this.txtBox_DeleteSomeOneShapeSerialNum.Name = "txtBox_DeleteSomeOneShapeSerialNum";
            this.txtBox_DeleteSomeOneShapeSerialNum.Size = new System.Drawing.Size(41, 22);
            this.txtBox_DeleteSomeOneShapeSerialNum.TabIndex = 3;
            // 
            // btnDeleteSomeOneShape
            // 
            this.btnDeleteSomeOneShape.Location = new System.Drawing.Point(13, 21);
            this.btnDeleteSomeOneShape.Name = "btnDeleteSomeOneShape";
            this.btnDeleteSomeOneShape.Size = new System.Drawing.Size(90, 39);
            this.btnDeleteSomeOneShape.TabIndex = 2;
            this.btnDeleteSomeOneShape.Text = "刪除";
            this.btnDeleteSomeOneShape.UseVisualStyleBackColor = true;
            this.btnDeleteSomeOneShape.Click += new System.EventHandler(this.btnDeleteSomeOneShape_Click);
            // 
            // label_NumberOfEachClass
            // 
            this.label_NumberOfEachClass.AutoSize = true;
            this.label_NumberOfEachClass.Location = new System.Drawing.Point(44, 304);
            this.label_NumberOfEachClass.Name = "label_NumberOfEachClass";
            this.label_NumberOfEachClass.Size = new System.Drawing.Size(77, 12);
            this.label_NumberOfEachClass.TabIndex = 17;
            this.label_NumberOfEachClass.Text = "物件數量統計";
            // 
            // cbBox_SortAlgorithms
            // 
            this.cbBox_SortAlgorithms.FormattingEnabled = true;
            this.cbBox_SortAlgorithms.Items.AddRange(new object[] {
            "順序",
            "形狀",
            "材質",
            "體積",
            "重量"});
            this.cbBox_SortAlgorithms.Location = new System.Drawing.Point(457, 19);
            this.cbBox_SortAlgorithms.Name = "cbBox_SortAlgorithms";
            this.cbBox_SortAlgorithms.Size = new System.Drawing.Size(78, 20);
            this.cbBox_SortAlgorithms.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(410, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "排序法";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 484);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbBox_SortAlgorithms);
            this.Controls.Add(this.label_NumberOfEachClass);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtBox_ShapeListForRollDistance);
            this.Controls.Add(this.btnCalcRollDistance);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCalcShapeParameter);
            this.Controls.Add(this.txtBox_ShapeList2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBox_ShapeList1);
            this.Name = "Form1";
            this.Text = "60132057A 林高遠 機電系OOP HW8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBox_Material;
        private System.Windows.Forms.ComboBox cbBox_Shape;
        private System.Windows.Forms.Button btnAddNewShape;
        private System.Windows.Forms.TextBox txtBox_AddNewShapeNum;
        private System.Windows.Forms.TextBox txtBox_ShapeParameter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelParameter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_ShapeList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBox_ShapeList2;
        private System.Windows.Forms.Button btnCalcShapeParameter;
        private System.Windows.Forms.TextBox txtBox_ShapeParameter2;
        private System.Windows.Forms.Label labelParameter2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCalcRollDistance;
        private System.Windows.Forms.TextBox txtBox_ShapeListForRollDistance;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_DeleteSomeOneShapeSerialNum;
        private System.Windows.Forms.Button btnDeleteSomeOneShape;
        private System.Windows.Forms.Label label_NumberOfEachClass;
        private System.Windows.Forms.ComboBox cbBox_SortAlgorithms;
        private System.Windows.Forms.Label label10;
    }
}

