namespace Bai08
{
    partial class Bai08
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
            lbTitle = new Label();
            lbSTK = new Label();
            tbSTK = new TextBox();
            tbTenKH = new TextBox();
            lbTenKH = new Label();
            tbDiaChi = new TextBox();
            lbDiaChi = new Label();
            tbSoTien = new TextBox();
            lbSoTien = new Label();
            btnCU = new Button();
            btnD = new Button();
            btnExit = new Button();
            listView1 = new ListView();
            clnSTT = new ColumnHeader();
            clnMaTK = new ColumnHeader();
            clnTenKH = new ColumnHeader();
            clnDiaChi = new ColumnHeader();
            clnSoTien = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            lbSum = new Label();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 32F);
            lbTitle.ForeColor = SystemColors.HotTrack;
            lbTitle.Location = new Point(-2, 24);
            lbTitle.Margin = new Padding(2, 0, 2, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(834, 72);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // lbSTK
            // 
            lbSTK.AutoSize = true;
            lbSTK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSTK.Location = new Point(129, 110);
            lbSTK.Margin = new Padding(2, 0, 2, 0);
            lbSTK.Name = "lbSTK";
            lbSTK.Size = new Size(121, 28);
            lbSTK.TabIndex = 1;
            lbSTK.Text = "Số tài khoản";
            // 
            // tbSTK
            // 
            tbSTK.Location = new Point(250, 113);
            tbSTK.Margin = new Padding(2);
            tbSTK.Name = "tbSTK";
            tbSTK.Size = new Size(480, 27);
            tbSTK.TabIndex = 2;
            // 
            // tbTenKH
            // 
            tbTenKH.Location = new Point(250, 153);
            tbTenKH.Margin = new Padding(2);
            tbTenKH.Name = "tbTenKH";
            tbTenKH.Size = new Size(480, 27);
            tbTenKH.TabIndex = 4;
            // 
            // lbTenKH
            // 
            lbTenKH.AutoSize = true;
            lbTenKH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTenKH.Location = new Point(100, 150);
            lbTenKH.Margin = new Padding(2, 0, 2, 0);
            lbTenKH.Name = "lbTenKH";
            lbTenKH.Size = new Size(146, 28);
            lbTenKH.TabIndex = 3;
            lbTenKH.Text = "Tên khách hàng";
            // 
            // tbDiaChi
            // 
            tbDiaChi.Location = new Point(250, 196);
            tbDiaChi.Margin = new Padding(2);
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(480, 27);
            tbDiaChi.TabIndex = 6;
            // 
            // lbDiaChi
            // 
            lbDiaChi.AutoSize = true;
            lbDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDiaChi.Location = new Point(73, 194);
            lbDiaChi.Margin = new Padding(2, 0, 2, 0);
            lbDiaChi.Name = "lbDiaChi";
            lbDiaChi.Size = new Size(176, 28);
            lbDiaChi.TabIndex = 5;
            lbDiaChi.Text = "Địa chỉ khách hàng";
            // 
            // tbSoTien
            // 
            tbSoTien.Location = new Point(250, 241);
            tbSoTien.Margin = new Padding(2);
            tbSoTien.Name = "tbSoTien";
            tbSoTien.Size = new Size(480, 27);
            tbSoTien.TabIndex = 8;
            // 
            // lbSoTien
            // 
            lbSoTien.AutoSize = true;
            lbSoTien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSoTien.Location = new Point(40, 238);
            lbSoTien.Margin = new Padding(2, 0, 2, 0);
            lbSoTien.Name = "lbSoTien";
            lbSoTien.Size = new Size(213, 28);
            lbSoTien.TabIndex = 7;
            lbSoTien.Text = "Số tiền trong tài khoản";
            // 
            // btnCU
            // 
            btnCU.Location = new Point(406, 275);
            btnCU.Margin = new Padding(2);
            btnCU.Name = "btnCU";
            btnCU.Size = new Size(133, 27);
            btnCU.TabIndex = 9;
            btnCU.Text = "Thêm / Cập Nhật";
            btnCU.UseVisualStyleBackColor = true;
            btnCU.Click += btnCU_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(566, 275);
            btnD.Margin = new Padding(2);
            btnD.Name = "btnD";
            btnD.Size = new Size(52, 27);
            btnD.TabIndex = 10;
            btnD.Text = "Xóa";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(642, 275);
            btnExit.Margin = new Padding(2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(88, 27);
            btnExit.TabIndex = 11;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { clnSTT, clnMaTK, clnTenKH, clnDiaChi, clnSoTien });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(18, 312);
            listView1.Margin = new Padding(2);
            listView1.Name = "listView1";
            listView1.Size = new Size(796, 200);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // clnSTT
            // 
            clnSTT.Text = "STT";
            // 
            // clnMaTK
            // 
            clnMaTK.Text = "Mã tài khoản";
            clnMaTK.Width = 150;
            // 
            // clnTenKH
            // 
            clnTenKH.Text = "Tên khách hàng";
            clnTenKH.Width = 200;
            // 
            // clnDiaChi
            // 
            clnDiaChi.Text = "Địa chỉ";
            clnDiaChi.Width = 400;
            // 
            // clnSoTien
            // 
            clnSoTien.Text = "Số tiền";
            clnSoTien.Width = 180;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(596, 524);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 13;
            label1.Text = "Tổng tiền:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(678, 524);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 14;
            // 
            // lbSum
            // 
            lbSum.AutoSize = true;
            lbSum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSum.Location = new Point(674, 524);
            lbSum.Margin = new Padding(2, 0, 2, 0);
            lbSum.Name = "lbSum";
            lbSum.Size = new Size(0, 20);
            lbSum.TabIndex = 15;
            // 
            // Bai08
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 561);
            Controls.Add(lbSum);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(btnExit);
            Controls.Add(btnD);
            Controls.Add(btnCU);
            Controls.Add(tbSoTien);
            Controls.Add(lbSoTien);
            Controls.Add(tbDiaChi);
            Controls.Add(lbDiaChi);
            Controls.Add(tbTenKH);
            Controls.Add(lbTenKH);
            Controls.Add(tbSTK);
            Controls.Add(lbSTK);
            Controls.Add(lbTitle);
            Margin = new Padding(2);
            Name = "Bai08";
            Text = "Quản Lý Tài Khoản";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label lbSTK;
        private TextBox tbSTK;
        private TextBox tbTenKH;
        private Label lbTenKH;
        private TextBox tbDiaChi;
        private Label lbDiaChi;
        private TextBox tbSoTien;
        private Label lbSoTien;
        private Button btnCU;
        private Button btnD;
        private Button btnExit;
        private ListView listView1;
        private ColumnHeader clnSTT;
        private ColumnHeader clnMaTK;
        private ColumnHeader clnTenKH;
        private ColumnHeader clnDiaChi;
        private ColumnHeader clnSoTien;
        private Label label1;
        private Label label2;
        private Label lbSum;
    }
}
