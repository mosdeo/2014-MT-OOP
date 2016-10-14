namespace Quiz5
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
            this.cbBox_Metrial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBox_Shape = new System.Windows.Forms.ComboBox();
            this.txtBox_Parameter1 = new System.Windows.Forms.TextBox();
            this.txtBox_Parameter2 = new System.Windows.Forms.TextBox();
            this.label_Parameter1 = new System.Windows.Forms.Label();
            this.label_Parameter2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_AddNewShapeNumber = new System.Windows.Forms.TextBox();
            this.btnNewShape = new System.Windows.Forms.Button();
            this.btnFindWeighestObj = new System.Windows.Forms.Button();
            this.txtBox_Message = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBox_Metrial
            // 
            this.cbBox_Metrial.FormattingEnabled = true;
            this.cbBox_Metrial.Items.AddRange(new object[] {
            "鋁",
            "鐵",
            "鉛"});
            this.cbBox_Metrial.Location = new System.Drawing.Point(49, 26);
            this.cbBox_Metrial.Name = "cbBox_Metrial";
            this.cbBox_Metrial.Size = new System.Drawing.Size(208, 20);
            this.cbBox_Metrial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "材質";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "形狀";
            // 
            // cbBox_Shape
            // 
            this.cbBox_Shape.FormattingEnabled = true;
            this.cbBox_Shape.Items.AddRange(new object[] {
            "球",
            "立方體",
            "圓柱體",
            "金字塔"});
            this.cbBox_Shape.Location = new System.Drawing.Point(46, 20);
            this.cbBox_Shape.Name = "cbBox_Shape";
            this.cbBox_Shape.Size = new System.Drawing.Size(208, 20);
            this.cbBox_Shape.TabIndex = 2;
            this.cbBox_Shape.SelectedIndexChanged += new System.EventHandler(this.cbBox_Shape_SelectedIndexChanged);
            // 
            // txtBox_Parameter1
            // 
            this.txtBox_Parameter1.Location = new System.Drawing.Point(46, 82);
            this.txtBox_Parameter1.Name = "txtBox_Parameter1";
            this.txtBox_Parameter1.Size = new System.Drawing.Size(66, 22);
            this.txtBox_Parameter1.TabIndex = 4;
            // 
            // txtBox_Parameter2
            // 
            this.txtBox_Parameter2.Location = new System.Drawing.Point(188, 82);
            this.txtBox_Parameter2.Name = "txtBox_Parameter2";
            this.txtBox_Parameter2.Size = new System.Drawing.Size(66, 22);
            this.txtBox_Parameter2.TabIndex = 5;
            // 
            // label_Parameter1
            // 
            this.label_Parameter1.AutoSize = true;
            this.label_Parameter1.Location = new System.Drawing.Point(11, 85);
            this.label_Parameter1.Name = "label_Parameter1";
            this.label_Parameter1.Size = new System.Drawing.Size(35, 12);
            this.label_Parameter1.TabIndex = 6;
            this.label_Parameter1.Text = "參數1";
            // 
            // label_Parameter2
            // 
            this.label_Parameter2.AutoSize = true;
            this.label_Parameter2.Location = new System.Drawing.Point(147, 85);
            this.label_Parameter2.Name = "label_Parameter2";
            this.label_Parameter2.Size = new System.Drawing.Size(35, 12);
            this.label_Parameter2.TabIndex = 7;
            this.label_Parameter2.Text = "參數2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbBox_Metrial);
            this.groupBox1.Location = new System.Drawing.Point(37, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 69);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "材質參數";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_Parameter2);
            this.groupBox2.Controls.Add(this.label_Parameter1);
            this.groupBox2.Controls.Add(this.txtBox_Parameter2);
            this.groupBox2.Controls.Add(this.txtBox_Parameter1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbBox_Shape);
            this.groupBox2.Location = new System.Drawing.Point(37, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 129);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "形狀參數";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "數量";
            // 
            // txtBox_AddNewShapeNumber
            // 
            this.txtBox_AddNewShapeNumber.Location = new System.Drawing.Point(225, 286);
            this.txtBox_AddNewShapeNumber.Name = "txtBox_AddNewShapeNumber";
            this.txtBox_AddNewShapeNumber.Size = new System.Drawing.Size(66, 22);
            this.txtBox_AddNewShapeNumber.TabIndex = 8;
            // 
            // btnNewShape
            // 
            this.btnNewShape.Location = new System.Drawing.Point(58, 273);
            this.btnNewShape.Name = "btnNewShape";
            this.btnNewShape.Size = new System.Drawing.Size(91, 45);
            this.btnNewShape.TabIndex = 10;
            this.btnNewShape.Text = "加入";
            this.btnNewShape.UseVisualStyleBackColor = true;
            this.btnNewShape.Click += new System.EventHandler(this.btnNewShape_Click);
            // 
            // btnFindWeighestObj
            // 
            this.btnFindWeighestObj.Location = new System.Drawing.Point(340, 38);
            this.btnFindWeighestObj.Name = "btnFindWeighestObj";
            this.btnFindWeighestObj.Size = new System.Drawing.Size(91, 45);
            this.btnFindWeighestObj.TabIndex = 11;
            this.btnFindWeighestObj.Text = "找出最重物件";
            this.btnFindWeighestObj.UseVisualStyleBackColor = true;
            this.btnFindWeighestObj.Click += new System.EventHandler(this.btnFindWeighestObj_Click);
            // 
            // txtBox_Message
            // 
            this.txtBox_Message.Location = new System.Drawing.Point(340, 108);
            this.txtBox_Message.Multiline = true;
            this.txtBox_Message.Name = "txtBox_Message";
            this.txtBox_Message.Size = new System.Drawing.Size(334, 211);
            this.txtBox_Message.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 366);
            this.Controls.Add(this.txtBox_Message);
            this.Controls.Add(this.btnFindWeighestObj);
            this.Controls.Add(this.btnNewShape);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtBox_AddNewShapeNumber);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBox_Metrial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBox_Shape;
        private System.Windows.Forms.TextBox txtBox_Parameter1;
        private System.Windows.Forms.TextBox txtBox_Parameter2;
        private System.Windows.Forms.Label label_Parameter1;
        private System.Windows.Forms.Label label_Parameter2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_AddNewShapeNumber;
        private System.Windows.Forms.Button btnNewShape;
        private System.Windows.Forms.Button btnFindWeighestObj;
        private System.Windows.Forms.TextBox txtBox_Message;
    }
}

