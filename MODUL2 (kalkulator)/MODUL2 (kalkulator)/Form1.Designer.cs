namespace MODUL2__kalkulator_
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnSamaDengan = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.btnKali = new System.Windows.Forms.Button();
            this.txtDisplay2 = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.btnKoma = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(22, 42);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(553, 51);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(22, 115);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(95, 47);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(123, 115);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(95, 47);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(224, 115);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(95, 47);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(123, 168);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(95, 47);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(224, 168);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(95, 47);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(224, 221);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(95, 47);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(22, 221);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(95, 47);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(123, 221);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(95, 47);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(22, 274);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(95, 47);
            this.btnTambah.TabIndex = 9;
            this.btnTambah.Text = "+";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnSamaDengan
            // 
            this.btnSamaDengan.Location = new System.Drawing.Point(426, 168);
            this.btnSamaDengan.Name = "btnSamaDengan";
            this.btnSamaDengan.Size = new System.Drawing.Size(149, 153);
            this.btnSamaDengan.TabIndex = 10;
            this.btnSamaDengan.Text = "=";
            this.btnSamaDengan.UseVisualStyleBackColor = true;
            this.btnSamaDengan.Click += new System.EventHandler(this.btnSamaDengan_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(123, 274);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(95, 47);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnKurang
            // 
            this.btnKurang.Location = new System.Drawing.Point(224, 274);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(95, 47);
            this.btnKurang.TabIndex = 12;
            this.btnKurang.Text = "-";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
            // 
            // btnBagi
            // 
            this.btnBagi.Location = new System.Drawing.Point(325, 168);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(95, 47);
            this.btnBagi.TabIndex = 13;
            this.btnBagi.Text = "/";
            this.btnBagi.UseVisualStyleBackColor = true;
            this.btnBagi.Click += new System.EventHandler(this.btnBagi_Click);
            // 
            // btnKali
            // 
            this.btnKali.Location = new System.Drawing.Point(325, 221);
            this.btnKali.Name = "btnKali";
            this.btnKali.Size = new System.Drawing.Size(95, 47);
            this.btnKali.TabIndex = 14;
            this.btnKali.Text = "X";
            this.btnKali.UseVisualStyleBackColor = true;
            this.btnKali.Click += new System.EventHandler(this.btnKali_Click);
            // 
            // txtDisplay2
            // 
            this.txtDisplay2.AccessibleName = "";
            this.txtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay2.Location = new System.Drawing.Point(33, 55);
            this.txtDisplay2.Name = "txtDisplay2";
            this.txtDisplay2.Size = new System.Drawing.Size(33, 19);
            this.txtDisplay2.TabIndex = 15;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(325, 115);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(250, 47);
            this.btnC.TabIndex = 16;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnKoma
            // 
            this.btnKoma.Location = new System.Drawing.Point(325, 274);
            this.btnKoma.Name = "btnKoma";
            this.btnKoma.Size = new System.Drawing.Size(95, 47);
            this.btnKoma.TabIndex = 17;
            this.btnKoma.Text = ",";
            this.btnKoma.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(22, 168);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(95, 47);
            this.btn4.TabIndex = 18;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 356);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnKoma);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.txtDisplay2);
            this.Controls.Add(this.btnKali);
            this.Controls.Add(this.btnBagi);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSamaDengan);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnSamaDengan;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnBagi;
        private System.Windows.Forms.Button btnKali;
        private System.Windows.Forms.TextBox txtDisplay2;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnKoma;
        private System.Windows.Forms.Button btn4;
    }
}

