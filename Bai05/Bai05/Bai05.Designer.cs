namespace Bai05
{
    partial class Bai05
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
            lbNum1 = new Label();
            lbN2 = new Label();
            tbNum1 = new TextBox();
            tbNum2 = new TextBox();
            tbAnswer = new TextBox();
            label1 = new Label();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            SuspendLayout();
            // 
            // lbNum1
            // 
            lbNum1.AutoSize = true;
            lbNum1.Location = new Point(18, 124);
            lbNum1.Name = "lbNum1";
            lbNum1.Size = new Size(92, 25);
            lbNum1.TabIndex = 0;
            lbNum1.Text = "Number 1";
            lbNum1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbN2
            // 
            lbN2.AutoSize = true;
            lbN2.Location = new Point(18, 176);
            lbN2.Name = "lbN2";
            lbN2.Size = new Size(92, 25);
            lbN2.TabIndex = 1;
            lbN2.Text = "Number 2";
            lbN2.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbNum1
            // 
            tbNum1.Location = new Point(125, 124);
            tbNum1.Name = "tbNum1";
            tbNum1.Size = new Size(358, 31);
            tbNum1.TabIndex = 2;
            // 
            // tbNum2
            // 
            tbNum2.Location = new Point(125, 176);
            tbNum2.Name = "tbNum2";
            tbNum2.Size = new Size(358, 31);
            tbNum2.TabIndex = 3;
            // 
            // tbAnswer
            // 
            tbAnswer.Location = new Point(125, 306);
            tbAnswer.Name = "tbAnswer";
            tbAnswer.Size = new Size(359, 31);
            tbAnswer.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 306);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 4;
            label1.Text = "Answer";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(125, 235);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(85, 43);
            btnPlus.TabIndex = 6;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += button1_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(216, 235);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(85, 43);
            btnMinus.TabIndex = 7;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(307, 235);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(85, 43);
            btnMul.TabIndex = 8;
            btnMul.Text = "x";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(398, 235);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(85, 43);
            btnDiv.TabIndex = 9;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 450);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(tbAnswer);
            Controls.Add(label1);
            Controls.Add(tbNum2);
            Controls.Add(tbNum1);
            Controls.Add(lbN2);
            Controls.Add(lbNum1);
            Name = "Form1";
            Text = "Lab02 - Example";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNum1;
        private Label lbN2;
        private TextBox tbNum1;
        private TextBox tbNum2;
        private TextBox tbAnswer;
        private Label label1;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMul;
        private Button btnDiv;
    }
}
