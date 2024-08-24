namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTotal = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnDiv = new Button();
            btnClear = new Button();
            btnMul = new Button();
            btnMin = new Button();
            btnPlus = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btnEql = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(30, 12);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(675, 92);
            txtTotal.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.BackColor = Color.LightGray;
            btn1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(48, 149);
            btn1.Name = "btn1";
            btn1.Size = new Size(99, 75);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.LightGray;
            btn2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(176, 149);
            btn2.Name = "btn2";
            btn2.Size = new Size(99, 75);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.LightGray;
            btn3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(312, 149);
            btn3.Name = "btn3";
            btn3.Size = new Size(99, 75);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.LightGray;
            btn5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(577, 149);
            btn5.Name = "btn5";
            btn5.Size = new Size(99, 75);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.LightGray;
            btn4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(440, 149);
            btn4.Name = "btn4";
            btn4.Size = new Size(99, 75);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.LightGray;
            btnDiv.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiv.Location = new Point(438, 392);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(99, 75);
            btnDiv.TabIndex = 10;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightGray;
            btnClear.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(575, 392);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(99, 75);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnMul
            // 
            btnMul.BackColor = Color.LightGray;
            btnMul.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMul.Location = new Point(310, 392);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(99, 75);
            btnMul.TabIndex = 8;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = false;
            btnMul.Click += btnMul_Click;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.LightGray;
            btnMin.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMin.Location = new Point(174, 392);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(99, 75);
            btnMin.TabIndex = 7;
            btnMin.Text = "-";
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.LightGray;
            btnPlus.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(46, 392);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(99, 75);
            btnPlus.TabIndex = 6;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.LightGray;
            btn9.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(438, 265);
            btn9.Name = "btn9";
            btn9.Size = new Size(99, 75);
            btn9.TabIndex = 15;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.LightGray;
            btn0.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(575, 265);
            btn0.Name = "btn0";
            btn0.Size = new Size(99, 75);
            btn0.TabIndex = 14;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.LightGray;
            btn8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(310, 265);
            btn8.Name = "btn8";
            btn8.Size = new Size(99, 75);
            btn8.TabIndex = 13;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.LightGray;
            btn7.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(174, 265);
            btn7.Name = "btn7";
            btn7.Size = new Size(99, 75);
            btn7.TabIndex = 12;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.LightGray;
            btn6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(46, 265);
            btn6.Name = "btn6";
            btn6.Size = new Size(99, 75);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btnEql
            // 
            btnEql.BackColor = Color.LightGray;
            btnEql.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEql.Location = new Point(48, 487);
            btnEql.Name = "btnEql";
            btnEql.Size = new Size(626, 75);
            btnEql.TabIndex = 16;
            btnEql.Text = "=";
            btnEql.UseVisualStyleBackColor = false;
            btnEql.Click += btnEql_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 573);
            Controls.Add(btnEql);
            Controls.Add(btn9);
            Controls.Add(btn0);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btnDiv);
            Controls.Add(btnClear);
            Controls.Add(btnMul);
            Controls.Add(btnMin);
            Controls.Add(btnPlus);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtTotal);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn5;
        private Button btn4;
        private Button btnDiv;
        private Button btnClear;
        private Button btnMul;
        private Button btnMin;
        private Button btnPlus;
        private Button btn9;
        private Button btn0;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btnEql;
    }
}
