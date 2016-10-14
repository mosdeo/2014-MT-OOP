namespace 期中考
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBox_JuicePricePerCC = new System.Windows.Forms.TextBox();
            this.txtBox_JuiceDiscountRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBox_SodaDiscountRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBox_WaterUnifiedPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_WaterDiscountRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_AppendDrink = new System.Windows.Forms.Button();
            this.cbBox_KindOfDrink = new System.Windows.Forms.ComboBox();
            this.txtBox_AppendedDrinkNumber = new System.Windows.Forms.TextBox();
            this.txtBox_DirnkVolume = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtBox_Bill = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbBox_BillSortAlgorithms = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "定價參數";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtBox_JuicePricePerCC);
            this.groupBox4.Controls.Add(this.txtBox_JuiceDiscountRate);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(15, 162);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(401, 63);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "果汁";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "每cc價格";
            // 
            // txtBox_JuicePricePerCC
            // 
            this.txtBox_JuicePricePerCC.Location = new System.Drawing.Point(299, 28);
            this.txtBox_JuicePricePerCC.Name = "txtBox_JuicePricePerCC";
            this.txtBox_JuicePricePerCC.Size = new System.Drawing.Size(96, 22);
            this.txtBox_JuicePricePerCC.TabIndex = 5;
            this.txtBox_JuicePricePerCC.Text = "0.8";
            // 
            // txtBox_JuiceDiscountRate
            // 
            this.txtBox_JuiceDiscountRate.Location = new System.Drawing.Point(44, 28);
            this.txtBox_JuiceDiscountRate.Name = "txtBox_JuiceDiscountRate";
            this.txtBox_JuiceDiscountRate.Size = new System.Drawing.Size(96, 22);
            this.txtBox_JuiceDiscountRate.TabIndex = 3;
            this.txtBox_JuiceDiscountRate.Text = "0.9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "折扣";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBox_SodaDiscountRate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(15, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 63);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "汽水";
            // 
            // txtBox_SodaDiscountRate
            // 
            this.txtBox_SodaDiscountRate.Location = new System.Drawing.Point(44, 26);
            this.txtBox_SodaDiscountRate.Name = "txtBox_SodaDiscountRate";
            this.txtBox_SodaDiscountRate.Size = new System.Drawing.Size(96, 22);
            this.txtBox_SodaDiscountRate.TabIndex = 2;
            this.txtBox_SodaDiscountRate.Text = "0.8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "500cc以內50元，\r\n501cc~1000cc 100元，\r\n1001c以上150元";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "折扣";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBox_WaterUnifiedPrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBox_WaterDiscountRate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 63);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "水";
            // 
            // txtBox_WaterUnifiedPrice
            // 
            this.txtBox_WaterUnifiedPrice.Location = new System.Drawing.Point(299, 27);
            this.txtBox_WaterUnifiedPrice.Name = "txtBox_WaterUnifiedPrice";
            this.txtBox_WaterUnifiedPrice.Size = new System.Drawing.Size(96, 22);
            this.txtBox_WaterUnifiedPrice.TabIndex = 3;
            this.txtBox_WaterUnifiedPrice.Text = "120";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "喝到飽價格";
            // 
            // txtBox_WaterDiscountRate
            // 
            this.txtBox_WaterDiscountRate.Location = new System.Drawing.Point(43, 28);
            this.txtBox_WaterDiscountRate.Name = "txtBox_WaterDiscountRate";
            this.txtBox_WaterDiscountRate.Size = new System.Drawing.Size(96, 22);
            this.txtBox_WaterDiscountRate.TabIndex = 1;
            this.txtBox_WaterDiscountRate.Text = "0.7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "折扣";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_AppendDrink);
            this.groupBox5.Controls.Add(this.cbBox_KindOfDrink);
            this.groupBox5.Controls.Add(this.txtBox_AppendedDrinkNumber);
            this.groupBox5.Controls.Add(this.txtBox_DirnkVolume);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(20, 271);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(428, 105);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "點餐";
            // 
            // btn_AppendDrink
            // 
            this.btn_AppendDrink.Location = new System.Drawing.Point(312, 63);
            this.btn_AppendDrink.Name = "btn_AppendDrink";
            this.btn_AppendDrink.Size = new System.Drawing.Size(96, 30);
            this.btn_AppendDrink.TabIndex = 10;
            this.btn_AppendDrink.Text = "確定";
            this.btn_AppendDrink.UseVisualStyleBackColor = true;
            this.btn_AppendDrink.Click += new System.EventHandler(this.btn_AppendDrink_Click);
            // 
            // cbBox_KindOfDrink
            // 
            this.cbBox_KindOfDrink.FormattingEnabled = true;
            this.cbBox_KindOfDrink.Items.AddRange(new object[] {
            "水",
            "汽水",
            "果汁"});
            this.cbBox_KindOfDrink.Location = new System.Drawing.Point(80, 28);
            this.cbBox_KindOfDrink.Name = "cbBox_KindOfDrink";
            this.cbBox_KindOfDrink.Size = new System.Drawing.Size(94, 20);
            this.cbBox_KindOfDrink.TabIndex = 9;
            // 
            // txtBox_AppendedDrinkNumber
            // 
            this.txtBox_AppendedDrinkNumber.Location = new System.Drawing.Point(79, 67);
            this.txtBox_AppendedDrinkNumber.Name = "txtBox_AppendedDrinkNumber";
            this.txtBox_AppendedDrinkNumber.Size = new System.Drawing.Size(96, 22);
            this.txtBox_AppendedDrinkNumber.TabIndex = 8;
            // 
            // txtBox_DirnkVolume
            // 
            this.txtBox_DirnkVolume.Location = new System.Drawing.Point(312, 28);
            this.txtBox_DirnkVolume.Name = "txtBox_DirnkVolume";
            this.txtBox_DirnkVolume.Size = new System.Drawing.Size(96, 22);
            this.txtBox_DirnkVolume.TabIndex = 7;
            this.txtBox_DirnkVolume.TextChanged += new System.EventHandler(this.txtBox_DirnkVolume_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "容量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "點餐數目";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "飲料種類";
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.Location = new System.Drawing.Point(333, 399);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(96, 30);
            this.btn_CheckOut.TabIndex = 11;
            this.btn_CheckOut.Text = "結帳";
            this.btn_CheckOut.UseVisualStyleBackColor = true;
            this.btn_CheckOut.Click += new System.EventHandler(this.btn_CheckOut_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtBox_Bill);
            this.groupBox6.Location = new System.Drawing.Point(461, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(294, 411);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "帳單";
            // 
            // txtBox_Bill
            // 
            this.txtBox_Bill.Location = new System.Drawing.Point(18, 27);
            this.txtBox_Bill.Multiline = true;
            this.txtBox_Bill.Name = "txtBox_Bill";
            this.txtBox_Bill.Size = new System.Drawing.Size(257, 368);
            this.txtBox_Bill.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "帳單排序法";
            // 
            // cbBox_BillSortAlgorithms
            // 
            this.cbBox_BillSortAlgorithms.FormattingEnabled = true;
            this.cbBox_BillSortAlgorithms.Items.AddRange(new object[] {
            "飲料類別",
            "價錢"});
            this.cbBox_BillSortAlgorithms.Location = new System.Drawing.Point(111, 405);
            this.cbBox_BillSortAlgorithms.Name = "cbBox_BillSortAlgorithms";
            this.cbBox_BillSortAlgorithms.Size = new System.Drawing.Size(94, 20);
            this.cbBox_BillSortAlgorithms.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 455);
            this.Controls.Add(this.cbBox_BillSortAlgorithms);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btn_CheckOut);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "飲料價格 60132057A 林高遠";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_JuicePricePerCC;
        private System.Windows.Forms.TextBox txtBox_JuiceDiscountRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBox_SodaDiscountRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBox_WaterUnifiedPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_WaterDiscountRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtBox_AppendedDrinkNumber;
        private System.Windows.Forms.TextBox txtBox_DirnkVolume;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBox_KindOfDrink;
        private System.Windows.Forms.Button btn_AppendDrink;
        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtBox_Bill;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbBox_BillSortAlgorithms;
    }
}

