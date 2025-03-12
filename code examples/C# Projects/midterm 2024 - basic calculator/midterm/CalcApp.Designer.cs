namespace midterm
{
    partial class CalcApp
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
            txtNumberInput = new TextBox();
            btnClear = new Button();
            btnBack = new Button();
            btnSquareRoot = new Button();
            btnReciprocal = new Button();
            btnEquals = new Button();
            btnPlus = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnDecimal = new Button();
            btnPosOrNeg = new Button();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMemoryAddValue = new Button();
            btnMemorySave = new Button();
            btnMemoryRecall = new Button();
            btnMemoryClear = new Button();
            btnMemory = new Button();
            SuspendLayout();
            // 
            // txtNumberInput
            // 
            txtNumberInput.Location = new Point(20, 21);
            txtNumberInput.Name = "txtNumberInput";
            txtNumberInput.Size = new Size(301, 23);
            txtNumberInput.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.ForeColor = Color.Red;
            btnClear.Location = new Point(183, 60);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 34);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.ForeColor = Color.Red;
            btnBack.Location = new Point(87, 60);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 34);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSquareRoot
            // 
            btnSquareRoot.BackColor = SystemColors.ControlLightLight;
            btnSquareRoot.ForeColor = Color.Blue;
            btnSquareRoot.Location = new Point(279, 100);
            btnSquareRoot.Name = "btnSquareRoot";
            btnSquareRoot.Size = new Size(42, 42);
            btnSquareRoot.TabIndex = 3;
            btnSquareRoot.Text = "sqrt";
            btnSquareRoot.UseVisualStyleBackColor = false;
            btnSquareRoot.Click += btnSquareRoot_Click;
            // 
            // btnReciprocal
            // 
            btnReciprocal.BackColor = SystemColors.ControlLightLight;
            btnReciprocal.ForeColor = Color.Blue;
            btnReciprocal.Location = new Point(279, 148);
            btnReciprocal.Name = "btnReciprocal";
            btnReciprocal.Size = new Size(42, 42);
            btnReciprocal.TabIndex = 4;
            btnReciprocal.Text = "1/X";
            btnReciprocal.UseVisualStyleBackColor = false;
            btnReciprocal.Click += btnReciprocal_Click;
            // 
            // btnEquals
            // 
            btnEquals.ForeColor = Color.Red;
            btnEquals.Location = new Point(279, 196);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(42, 90);
            btnEquals.TabIndex = 5;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ControlLightLight;
            btnPlus.ForeColor = Color.Red;
            btnPlus.Location = new Point(231, 244);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(42, 42);
            btnPlus.TabIndex = 6;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnOperation_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = SystemColors.ControlLightLight;
            btnSubtract.ForeColor = Color.Red;
            btnSubtract.Location = new Point(231, 196);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(42, 42);
            btnSubtract.TabIndex = 7;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += btnOperation_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.ControlLightLight;
            btnMultiply.ForeColor = Color.Red;
            btnMultiply.Location = new Point(231, 148);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(42, 42);
            btnMultiply.TabIndex = 8;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnOperation_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.ControlLightLight;
            btnDivide.ForeColor = Color.Red;
            btnDivide.Location = new Point(231, 100);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(42, 42);
            btnDivide.TabIndex = 9;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnOperation_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = SystemColors.ControlLightLight;
            btnDecimal.ForeColor = Color.Blue;
            btnDecimal.Location = new Point(183, 244);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(42, 42);
            btnDecimal.TabIndex = 10;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += btnNum_Click;
            // 
            // btnPosOrNeg
            // 
            btnPosOrNeg.BackColor = SystemColors.ControlLightLight;
            btnPosOrNeg.ForeColor = Color.Blue;
            btnPosOrNeg.Location = new Point(135, 244);
            btnPosOrNeg.Name = "btnPosOrNeg";
            btnPosOrNeg.Size = new Size(42, 42);
            btnPosOrNeg.TabIndex = 11;
            btnPosOrNeg.Text = "+/-";
            btnPosOrNeg.UseVisualStyleBackColor = false;
            btnPosOrNeg.Click += btnPosOrNeg_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ControlLightLight;
            btn0.ForeColor = Color.Blue;
            btn0.Location = new Point(87, 244);
            btn0.Name = "btn0";
            btn0.Size = new Size(42, 42);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btnNum_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ControlLightLight;
            btn1.ForeColor = Color.Blue;
            btn1.Location = new Point(87, 196);
            btn1.Name = "btn1";
            btn1.Size = new Size(42, 42);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnNum_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ControlLightLight;
            btn2.ForeColor = Color.Blue;
            btn2.Location = new Point(135, 196);
            btn2.Name = "btn2";
            btn2.Size = new Size(42, 42);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnNum_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ControlLightLight;
            btn3.ForeColor = Color.Blue;
            btn3.Location = new Point(183, 196);
            btn3.Name = "btn3";
            btn3.Size = new Size(42, 42);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btnNum_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ControlLightLight;
            btn4.ForeColor = Color.Blue;
            btn4.Location = new Point(87, 148);
            btn4.Name = "btn4";
            btn4.Size = new Size(42, 42);
            btn4.TabIndex = 16;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btnNum_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ControlLightLight;
            btn5.ForeColor = Color.Blue;
            btn5.Location = new Point(135, 148);
            btn5.Name = "btn5";
            btn5.Size = new Size(42, 42);
            btn5.TabIndex = 17;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btnNum_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ControlLightLight;
            btn6.ForeColor = Color.Blue;
            btn6.Location = new Point(183, 148);
            btn6.Name = "btn6";
            btn6.Size = new Size(42, 42);
            btn6.TabIndex = 18;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btnNum_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ControlLightLight;
            btn7.ForeColor = Color.Blue;
            btn7.Location = new Point(87, 100);
            btn7.Name = "btn7";
            btn7.Size = new Size(42, 42);
            btn7.TabIndex = 19;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btnNum_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ControlLightLight;
            btn8.ForeColor = Color.Blue;
            btn8.Location = new Point(135, 100);
            btn8.Name = "btn8";
            btn8.Size = new Size(42, 42);
            btn8.TabIndex = 20;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btnNum_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ControlLightLight;
            btn9.ForeColor = Color.Blue;
            btn9.Location = new Point(183, 100);
            btn9.Name = "btn9";
            btn9.Size = new Size(42, 42);
            btn9.TabIndex = 21;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btnNum_Click;
            // 
            // btnMemoryAddValue
            // 
            btnMemoryAddValue.BackColor = SystemColors.ControlLightLight;
            btnMemoryAddValue.ForeColor = Color.Red;
            btnMemoryAddValue.Location = new Point(20, 244);
            btnMemoryAddValue.Name = "btnMemoryAddValue";
            btnMemoryAddValue.Size = new Size(61, 42);
            btnMemoryAddValue.TabIndex = 22;
            btnMemoryAddValue.Text = "M+";
            btnMemoryAddValue.UseVisualStyleBackColor = false;
            btnMemoryAddValue.Click += btnMemoryAddValue_Click;
            // 
            // btnMemorySave
            // 
            btnMemorySave.BackColor = SystemColors.ControlLightLight;
            btnMemorySave.ForeColor = Color.Red;
            btnMemorySave.Location = new Point(20, 196);
            btnMemorySave.Name = "btnMemorySave";
            btnMemorySave.Size = new Size(61, 42);
            btnMemorySave.TabIndex = 23;
            btnMemorySave.Text = "MS";
            btnMemorySave.UseVisualStyleBackColor = false;
            btnMemorySave.Click += btnMemorySave_Click;
            // 
            // btnMemoryRecall
            // 
            btnMemoryRecall.BackColor = SystemColors.ControlLightLight;
            btnMemoryRecall.ForeColor = Color.Red;
            btnMemoryRecall.Location = new Point(20, 148);
            btnMemoryRecall.Name = "btnMemoryRecall";
            btnMemoryRecall.Size = new Size(61, 42);
            btnMemoryRecall.TabIndex = 24;
            btnMemoryRecall.Text = "MR";
            btnMemoryRecall.UseVisualStyleBackColor = false;
            btnMemoryRecall.Click += btnMemoryRecall_Click;
            // 
            // btnMemoryClear
            // 
            btnMemoryClear.BackColor = SystemColors.ControlLightLight;
            btnMemoryClear.ForeColor = Color.Red;
            btnMemoryClear.Location = new Point(20, 100);
            btnMemoryClear.Name = "btnMemoryClear";
            btnMemoryClear.Size = new Size(61, 42);
            btnMemoryClear.TabIndex = 25;
            btnMemoryClear.Text = "MC";
            btnMemoryClear.UseVisualStyleBackColor = false;
            btnMemoryClear.Click += btnMemoryClear_Click;
            // 
            // btnMemory
            // 
            btnMemory.BackColor = SystemColors.ControlLightLight;
            btnMemory.ForeColor = Color.Black;
            btnMemory.Location = new Point(20, 60);
            btnMemory.Name = "btnMemory";
            btnMemory.Size = new Size(61, 38);
            btnMemory.TabIndex = 26;
            btnMemory.UseVisualStyleBackColor = false;
            // 
            // CalcApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 301);
            Controls.Add(btnMemory);
            Controls.Add(btnMemoryClear);
            Controls.Add(btnMemoryRecall);
            Controls.Add(btnMemorySave);
            Controls.Add(btnMemoryAddValue);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Controls.Add(btnPosOrNeg);
            Controls.Add(btnDecimal);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnPlus);
            Controls.Add(btnEquals);
            Controls.Add(btnReciprocal);
            Controls.Add(btnSquareRoot);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(txtNumberInput);
            Name = "CalcApp";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumberInput;
        private Button btnClear;
        private Button btnBack;
        private Button btnSquareRoot;
        private Button btnReciprocal;
        private Button btnEquals;
        private Button btnPlus;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnDecimal;
        private Button btnPosOrNeg;
        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMemoryAddValue;
        private Button btnMemorySave;
        private Button btnMemoryRecall;
        private Button btnMemoryClear;
        private Button btnMemory;
    }
}
