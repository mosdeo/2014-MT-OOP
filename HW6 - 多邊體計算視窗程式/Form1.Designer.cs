﻿namespace HW6___多邊體計算視窗程式
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBox_Material
            // 
            this.cbBox_Material.FormattingEnabled = true;
            this.cbBox_Material.Items.AddRange(new object[] {
            "鐵",
            "冰",
            "木材"});
            this.cbBox_Material.Location = new System.Drawing.Point(104, 16);
            this.cbBox_Material.Name = "cbBox_Material";
            this.cbBox_Material.Size = new System.Drawing.Size(209, 20);
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
            this.cbBox_Shape.Location = new System.Drawing.Point(104, 16);
            this.cbBox_Shape.Name = "cbBox_Shape";
            this.cbBox_Shape.Size = new System.Drawing.Size(209, 20);
            this.cbBox_Shape.TabIndex = 1;
            this.cbBox_Shape.SelectedIndexChanged += new System.EventHandler(this.cbBox_Shape_SelectedIndexChanged);
            // 
            // btnAddNewShape
            // 
            this.btnAddNewShape.Location = new System.Drawing.Point(13, 21);
            this.btnAddNewShape.Name = "btnAddNewShape";
            this.btnAddNewShape.Size = new System.Drawing.Size(90, 54);
            this.btnAddNewShape.TabIndex = 2;
            this.btnAddNewShape.Text = "加入";
            this.btnAddNewShape.UseVisualStyleBackColor = true;
            this.btnAddNewShape.Click += new System.EventHandler(this.btnAddNewShape_Click);
            // 
            // txtBox_AddNewShapeNum
            // 
            this.txtBox_AddNewShapeNum.Location = new System.Drawing.Point(191, 42);
            this.txtBox_AddNewShapeNum.Name = "txtBox_AddNewShapeNum";
            this.txtBox_AddNewShapeNum.Size = new System.Drawing.Size(105, 22);
            this.txtBox_AddNewShapeNum.TabIndex = 3;
            // 
            // txtBox_ShapeParameter1
            // 
            this.txtBox_ShapeParameter1.Location = new System.Drawing.Point(93, 82);
            this.txtBox_ShapeParameter1.Name = "txtBox_ShapeParameter1";
            this.txtBox_ShapeParameter1.Size = new System.Drawing.Size(75, 22);
            this.txtBox_ShapeParameter1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "材質";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "形狀";
            // 
            // labelParameter1
            // 
            this.labelParameter1.AutoSize = true;
            this.labelParameter1.Location = new System.Drawing.Point(37, 85);
            this.labelParameter1.Name = "labelParameter1";
            this.labelParameter1.Size = new System.Drawing.Size(59, 12);
            this.labelParameter1.TabIndex = 7;
            this.labelParameter1.Text = "未定參數1";
            this.labelParameter1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "數量";
            // 
            // txtBox_ShapeList1
            // 
            this.txtBox_ShapeList1.Location = new System.Drawing.Point(45, 331);
            this.txtBox_ShapeList1.Multiline = true;
            this.txtBox_ShapeList1.Name = "txtBox_ShapeList1";
            this.txtBox_ShapeList1.Size = new System.Drawing.Size(370, 125);
            this.txtBox_ShapeList1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbBox_Material);
            this.groupBox1.Location = new System.Drawing.Point(41, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 56);
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
            this.groupBox2.Location = new System.Drawing.Point(41, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 134);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "形狀設定";
            // 
            // txtBox_ShapeParameter2
            // 
            this.txtBox_ShapeParameter2.Location = new System.Drawing.Point(256, 82);
            this.txtBox_ShapeParameter2.Name = "txtBox_ShapeParameter2";
            this.txtBox_ShapeParameter2.Size = new System.Drawing.Size(75, 22);
            this.txtBox_ShapeParameter2.TabIndex = 8;
            // 
            // labelParameter2
            // 
            this.labelParameter2.AutoSize = true;
            this.labelParameter2.Location = new System.Drawing.Point(200, 85);
            this.labelParameter2.Name = "labelParameter2";
            this.labelParameter2.Size = new System.Drawing.Size(59, 12);
            this.labelParameter2.TabIndex = 9;
            this.labelParameter2.Text = "未定參數2";
            this.labelParameter2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBox_ShapeList2
            // 
            this.txtBox_ShapeList2.Location = new System.Drawing.Point(440, 79);
            this.txtBox_ShapeList2.Multiline = true;
            this.txtBox_ShapeList2.Name = "txtBox_ShapeList2";
            this.txtBox_ShapeList2.Size = new System.Drawing.Size(273, 377);
            this.txtBox_ShapeList2.TabIndex = 12;
            // 
            // btnCalcShapeParameter
            // 
            this.btnCalcShapeParameter.Location = new System.Drawing.Point(440, 12);
            this.btnCalcShapeParameter.Name = "btnCalcShapeParameter";
            this.btnCalcShapeParameter.Size = new System.Drawing.Size(90, 53);
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
            this.groupBox3.Location = new System.Drawing.Point(45, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 90);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "增加Shape";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 484);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCalcShapeParameter);
            this.Controls.Add(this.txtBox_ShapeList2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBox_ShapeList1);
            this.Name = "Form1";
            this.Text = "60132057A 林高遠 機電系OOP HW6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
    }
}

