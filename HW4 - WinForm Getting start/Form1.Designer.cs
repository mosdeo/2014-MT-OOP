namespace HW4___WinForm_Getting_start
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ComboBox_Test = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_SortBy_Rand = new System.Windows.Forms.CheckBox();
            this.chk_SortBy_Rank = new System.Windows.Forms.CheckBox();
            this.chk_SortBy_Suit = new System.Windows.Forms.CheckBox();
            this.btn_CheckBox_Test = new System.Windows.Forms.Button();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "按花色排列",
            "按大小排列",
            "亂數洗牌"});
            this.comboBox1.Location = new System.Drawing.Point(24, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ComboBox_Test);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(17, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComboBox測試";
            // 
            // btn_ComboBox_Test
            // 
            this.btn_ComboBox_Test.Location = new System.Drawing.Point(225, 30);
            this.btn_ComboBox_Test.Name = "btn_ComboBox_Test";
            this.btn_ComboBox_Test.Size = new System.Drawing.Size(88, 30);
            this.btn_ComboBox_Test.TabIndex = 1;
            this.btn_ComboBox_Test.Text = "確定";
            this.btn_ComboBox_Test.UseVisualStyleBackColor = true;
            this.btn_ComboBox_Test.Click += new System.EventHandler(this.btn_ComboBox_Test_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_SortBy_Rand);
            this.groupBox2.Controls.Add(this.chk_SortBy_Rank);
            this.groupBox2.Controls.Add(this.chk_SortBy_Suit);
            this.groupBox2.Controls.Add(this.btn_CheckBox_Test);
            this.groupBox2.Location = new System.Drawing.Point(17, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 112);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CheckBox測試";
            // 
            // chk_SortBy_Rand
            // 
            this.chk_SortBy_Rand.AutoSize = true;
            this.chk_SortBy_Rand.Location = new System.Drawing.Point(24, 74);
            this.chk_SortBy_Rand.Name = "chk_SortBy_Rand";
            this.chk_SortBy_Rand.Size = new System.Drawing.Size(72, 16);
            this.chk_SortBy_Rand.TabIndex = 4;
            this.chk_SortBy_Rand.Text = "亂數洗牌";
            this.chk_SortBy_Rand.UseVisualStyleBackColor = true;
            this.chk_SortBy_Rand.CheckedChanged += new System.EventHandler(this.chk_SortBy_Rand_CheckedChanged);
            // 
            // chk_SortBy_Rank
            // 
            this.chk_SortBy_Rank.AutoSize = true;
            this.chk_SortBy_Rank.Location = new System.Drawing.Point(24, 52);
            this.chk_SortBy_Rank.Name = "chk_SortBy_Rank";
            this.chk_SortBy_Rank.Size = new System.Drawing.Size(84, 16);
            this.chk_SortBy_Rank.TabIndex = 3;
            this.chk_SortBy_Rank.Text = "按點數排列";
            this.chk_SortBy_Rank.UseVisualStyleBackColor = true;
            this.chk_SortBy_Rank.CheckedChanged += new System.EventHandler(this.chk_SortBy_Rank_CheckedChanged);
            // 
            // chk_SortBy_Suit
            // 
            this.chk_SortBy_Suit.AutoSize = true;
            this.chk_SortBy_Suit.Location = new System.Drawing.Point(24, 30);
            this.chk_SortBy_Suit.Name = "chk_SortBy_Suit";
            this.chk_SortBy_Suit.Size = new System.Drawing.Size(84, 16);
            this.chk_SortBy_Suit.TabIndex = 2;
            this.chk_SortBy_Suit.Text = "按花色排列";
            this.chk_SortBy_Suit.UseVisualStyleBackColor = true;
            this.chk_SortBy_Suit.CheckedChanged += new System.EventHandler(this.chk_SortBy_Suit_CheckedChanged);
            // 
            // btn_CheckBox_Test
            // 
            this.btn_CheckBox_Test.Location = new System.Drawing.Point(225, 30);
            this.btn_CheckBox_Test.Name = "btn_CheckBox_Test";
            this.btn_CheckBox_Test.Size = new System.Drawing.Size(88, 30);
            this.btn_CheckBox_Test.TabIndex = 1;
            this.btn_CheckBox_Test.Text = "確定";
            this.btn_CheckBox_Test.UseVisualStyleBackColor = true;
            this.btn_CheckBox_Test.Click += new System.EventHandler(this.btn_CheckBox_Test_Click);
            // 
            // txt_Message
            // 
            this.txt_Message.Location = new System.Drawing.Point(17, 220);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(324, 194);
            this.txt_Message.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 440);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ComboBox_Test;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_SortBy_Rand;
        private System.Windows.Forms.CheckBox chk_SortBy_Rank;
        private System.Windows.Forms.CheckBox chk_SortBy_Suit;
        private System.Windows.Forms.Button btn_CheckBox_Test;
        private System.Windows.Forms.TextBox txt_Message;
    }
}

