namespace Final_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Num1Real = new System.Windows.Forms.TextBox();
            this.txt_Num1Imag = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Num2Real = new System.Windows.Forms.TextBox();
            this.txt_Num2Imag = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Num3Real = new System.Windows.Forms.TextBox();
            this.txt_Num3Imag = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Num4Real = new System.Windows.Forms.TextBox();
            this.txt_Num4Imag = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "實部";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "虛部";
            // 
            // txt_Num1Real
            // 
            this.txt_Num1Real.Location = new System.Drawing.Point(131, 33);
            this.txt_Num1Real.Name = "txt_Num1Real";
            this.txt_Num1Real.Size = new System.Drawing.Size(84, 22);
            this.txt_Num1Real.TabIndex = 2;
            this.txt_Num1Real.Text = "0";
            // 
            // txt_Num1Imag
            // 
            this.txt_Num1Imag.Location = new System.Drawing.Point(295, 33);
            this.txt_Num1Imag.Name = "txt_Num1Imag";
            this.txt_Num1Imag.Size = new System.Drawing.Size(100, 22);
            this.txt_Num1Imag.TabIndex = 3;
            this.txt_Num1Imag.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_Num4Real);
            this.groupBox1.Controls.Add(this.txt_Num4Imag);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_Num3Real);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_Num3Imag);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Num2Real);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_Num2Imag);
            this.groupBox1.Controls.Add(this.txt_Num1Real);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Num1Imag);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 160);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "複數的參數";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(12, 190);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 5;
            this.btn_Calculate.Text = "計算";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Result);
            this.groupBox2.Location = new System.Drawing.Point(12, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 192);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "計算結果";
            // 
            // txt_Result
            // 
            this.txt_Result.Location = new System.Drawing.Point(17, 21);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Result.Size = new System.Drawing.Size(378, 145);
            this.txt_Result.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "第一個數";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "第二個數";
            // 
            // txt_Num2Real
            // 
            this.txt_Num2Real.Location = new System.Drawing.Point(131, 61);
            this.txt_Num2Real.Name = "txt_Num2Real";
            this.txt_Num2Real.Size = new System.Drawing.Size(84, 22);
            this.txt_Num2Real.TabIndex = 10;
            this.txt_Num2Real.Text = "0";
            // 
            // txt_Num2Imag
            // 
            this.txt_Num2Imag.Location = new System.Drawing.Point(295, 61);
            this.txt_Num2Imag.Name = "txt_Num2Imag";
            this.txt_Num2Imag.Size = new System.Drawing.Size(100, 22);
            this.txt_Num2Imag.TabIndex = 11;
            this.txt_Num2Imag.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "實部";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "虛部";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "第三個數";
            // 
            // txt_Num3Real
            // 
            this.txt_Num3Real.Location = new System.Drawing.Point(131, 89);
            this.txt_Num3Real.Name = "txt_Num3Real";
            this.txt_Num3Real.Size = new System.Drawing.Size(84, 22);
            this.txt_Num3Real.TabIndex = 15;
            this.txt_Num3Real.Text = "0";
            // 
            // txt_Num3Imag
            // 
            this.txt_Num3Imag.Location = new System.Drawing.Point(295, 89);
            this.txt_Num3Imag.Name = "txt_Num3Imag";
            this.txt_Num3Imag.Size = new System.Drawing.Size(100, 22);
            this.txt_Num3Imag.TabIndex = 16;
            this.txt_Num3Imag.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "實部";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "虛部";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "第四個數";
            // 
            // txt_Num4Real
            // 
            this.txt_Num4Real.Location = new System.Drawing.Point(131, 120);
            this.txt_Num4Real.Name = "txt_Num4Real";
            this.txt_Num4Real.Size = new System.Drawing.Size(84, 22);
            this.txt_Num4Real.TabIndex = 20;
            this.txt_Num4Real.Text = "0";
            // 
            // txt_Num4Imag
            // 
            this.txt_Num4Imag.Location = new System.Drawing.Point(295, 120);
            this.txt_Num4Imag.Name = "txt_Num4Imag";
            this.txt_Num4Imag.Size = new System.Drawing.Size(100, 22);
            this.txt_Num4Imag.TabIndex = 21;
            this.txt_Num4Imag.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "實部";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(249, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "虛部";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "計算複數的次方";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Num1Real;
        private System.Windows.Forms.TextBox txt_Num1Imag;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Num4Real;
        private System.Windows.Forms.TextBox txt_Num4Imag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Num3Real;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Num3Imag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Num2Real;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Num2Imag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

