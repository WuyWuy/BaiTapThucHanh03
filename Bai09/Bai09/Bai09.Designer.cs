namespace Bai09
{
    partial class Bai09
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
            gbxTitle = new GroupBox();
            btnDelete = new Button();
            btnSave = new Button();
            btnLeft = new Button();
            btnRight = new Button();
            lbxRight = new ListBox();
            lbxLeft = new ListBox();
            cbFemale = new CheckBox();
            cbMale = new CheckBox();
            cbMajor = new ComboBox();
            tbMSV = new TextBox();
            tbHoTen = new TextBox();
            lbPick = new Label();
            lbGender = new Label();
            lbMajor = new Label();
            lbHoTen = new Label();
            lbMSV = new Label();
            dtgv = new DataGridView();
            clmID = new DataGridViewTextBoxColumn();
            clmName = new DataGridViewTextBoxColumn();
            clmMajor = new DataGridViewTextBoxColumn();
            clmGenre = new DataGridViewTextBoxColumn();
            idAmmount = new DataGridViewTextBoxColumn();
            gbxTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv).BeginInit();
            SuspendLayout();
            // 
            // gbxTitle
            // 
            gbxTitle.Controls.Add(btnDelete);
            gbxTitle.Controls.Add(btnSave);
            gbxTitle.Controls.Add(btnLeft);
            gbxTitle.Controls.Add(btnRight);
            gbxTitle.Controls.Add(lbxRight);
            gbxTitle.Controls.Add(lbxLeft);
            gbxTitle.Controls.Add(cbFemale);
            gbxTitle.Controls.Add(cbMale);
            gbxTitle.Controls.Add(cbMajor);
            gbxTitle.Controls.Add(tbMSV);
            gbxTitle.Controls.Add(tbHoTen);
            gbxTitle.Controls.Add(lbPick);
            gbxTitle.Controls.Add(lbGender);
            gbxTitle.Controls.Add(lbMajor);
            gbxTitle.Controls.Add(lbHoTen);
            gbxTitle.Controls.Add(lbMSV);
            gbxTitle.Location = new Point(10, 10);
            gbxTitle.Margin = new Padding(2, 2, 2, 2);
            gbxTitle.Name = "gbxTitle";
            gbxTitle.Padding = new Padding(2, 2, 2, 2);
            gbxTitle.Size = new Size(785, 350);
            gbxTitle.TabIndex = 0;
            gbxTitle.TabStop = false;
            gbxTitle.Text = "Thông Tin Sinh Viên";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(416, 311);
            btnDelete.Margin = new Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 27);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Xóa chọn";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(272, 311);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 27);
            btnSave.TabIndex = 14;
            btnSave.Text = "Lưu thông tin";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(388, 258);
            btnLeft.Margin = new Padding(2, 2, 2, 2);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(37, 27);
            btnLeft.TabIndex = 13;
            btnLeft.Text = "<";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(388, 213);
            btnRight.Margin = new Padding(2, 2, 2, 2);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(37, 27);
            btnRight.TabIndex = 12;
            btnRight.Text = ">";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // lbxRight
            // 
            lbxRight.FormattingEnabled = true;
            lbxRight.Location = new Point(438, 198);
            lbxRight.Margin = new Padding(2, 2, 2, 2);
            lbxRight.Name = "lbxRight";
            lbxRight.Size = new Size(211, 104);
            lbxRight.TabIndex = 11;
            // 
            // lbxLeft
            // 
            lbxLeft.FormattingEnabled = true;
            lbxLeft.Items.AddRange(new object[] { "Cơ sở dữ liệu", "Cơ sở DL nâng cao", "PTTK Hệ Thống thông tin" });
            lbxLeft.Location = new Point(163, 198);
            lbxLeft.Margin = new Padding(2, 2, 2, 2);
            lbxLeft.Name = "lbxLeft";
            lbxLeft.Size = new Size(211, 104);
            lbxLeft.TabIndex = 10;
            // 
            // cbFemale
            // 
            cbFemale.AutoSize = true;
            cbFemale.Location = new Point(454, 139);
            cbFemale.Margin = new Padding(2, 2, 2, 2);
            cbFemale.Name = "cbFemale";
            cbFemale.Size = new Size(51, 24);
            cbFemale.TabIndex = 9;
            cbFemale.Text = "Nữ";
            cbFemale.UseVisualStyleBackColor = true;
            cbFemale.CheckedChanged += cbFemale_CheckedChanged;
            // 
            // cbMale
            // 
            cbMale.AutoSize = true;
            cbMale.Location = new Point(370, 139);
            cbMale.Margin = new Padding(2, 2, 2, 2);
            cbMale.Name = "cbMale";
            cbMale.Size = new Size(63, 24);
            cbMale.TabIndex = 8;
            cbMale.Text = "Nam";
            cbMale.UseVisualStyleBackColor = true;
            cbMale.CheckedChanged += cbMale_CheckedChanged;
            // 
            // cbMajor
            // 
            cbMajor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMajor.FormattingEnabled = true;
            cbMajor.Items.AddRange(new object[] { "Hệ Thống Thông Tin", "Công Nghệ Thông Tin", "Khoa Học Máy Tính", "Kỹ Thuật Phần Mềm", "Kỹ Thuật Máy Tính", "Mạng Máy Tính & Truyền Thông Dữ Liệu", "An Toàn Thông Tin", "Khoa Học Dữ Liệu", "Trí Tuệ Nhân Tạo", "Thiết Kế Vi Mạch", "Truyền Thông Đa Phương Tiện" });
            cbMajor.Location = new Point(370, 95);
            cbMajor.Margin = new Padding(2, 2, 2, 2);
            cbMajor.Name = "cbMajor";
            cbMajor.Size = new Size(270, 28);
            cbMajor.TabIndex = 7;
            // 
            // tbMSV
            // 
            tbMSV.Location = new Point(370, 26);
            tbMSV.Margin = new Padding(2, 2, 2, 2);
            tbMSV.Name = "tbMSV";
            tbMSV.Size = new Size(164, 27);
            tbMSV.TabIndex = 6;
            // 
            // tbHoTen
            // 
            tbHoTen.Location = new Point(370, 60);
            tbHoTen.Margin = new Padding(2, 2, 2, 2);
            tbHoTen.Name = "tbHoTen";
            tbHoTen.Size = new Size(270, 27);
            tbHoTen.TabIndex = 5;
            // 
            // lbPick
            // 
            lbPick.AutoSize = true;
            lbPick.Location = new Point(168, 166);
            lbPick.Margin = new Padding(2, 0, 2, 0);
            lbPick.Name = "lbPick";
            lbPick.Size = new Size(194, 20);
            lbPick.TabIndex = 4;
            lbPick.Text = "Chọn các môn học tham gia";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(168, 132);
            lbGender.Margin = new Padding(2, 0, 2, 0);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(65, 20);
            lbGender.TabIndex = 3;
            lbGender.Text = "Giới tính";
            // 
            // lbMajor
            // 
            lbMajor.AutoSize = true;
            lbMajor.Location = new Point(168, 95);
            lbMajor.Margin = new Padding(2, 0, 2, 0);
            lbMajor.Name = "lbMajor";
            lbMajor.Size = new Size(105, 20);
            lbMajor.TabIndex = 2;
            lbMajor.Text = "Chuyên Ngành";
            // 
            // lbHoTen
            // 
            lbHoTen.AutoSize = true;
            lbHoTen.Location = new Point(168, 60);
            lbHoTen.Margin = new Padding(2, 0, 2, 0);
            lbHoTen.Name = "lbHoTen";
            lbHoTen.Size = new Size(56, 20);
            lbHoTen.TabIndex = 1;
            lbHoTen.Text = "Họ Tên";
            // 
            // lbMSV
            // 
            lbMSV.AutoSize = true;
            lbMSV.Location = new Point(168, 26);
            lbMSV.Margin = new Padding(2, 0, 2, 0);
            lbMSV.Name = "lbMSV";
            lbMSV.Size = new Size(95, 20);
            lbMSV.TabIndex = 0;
            lbMSV.Text = "Mã Sinh Viên";
            // 
            // dtgv
            // 
            dtgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv.Columns.AddRange(new DataGridViewColumn[] { clmID, clmName, clmMajor, clmGenre, idAmmount });
            dtgv.Location = new Point(10, 365);
            dtgv.Margin = new Padding(2, 2, 2, 2);
            dtgv.MultiSelect = false;
            dtgv.Name = "dtgv";
            dtgv.ReadOnly = true;
            dtgv.RowHeadersWidth = 62;
            dtgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv.Size = new Size(785, 204);
            dtgv.TabIndex = 1;
            dtgv.CellContentClick += dtgv_CellContentClick;
            // 
            // clmID
            // 
            clmID.HeaderText = "MSSV";
            clmID.MinimumWidth = 8;
            clmID.Name = "clmID";
            clmID.ReadOnly = true;
            clmID.Width = 150;
            // 
            // clmName
            // 
            clmName.HeaderText = "Họ Tên";
            clmName.MinimumWidth = 8;
            clmName.Name = "clmName";
            clmName.ReadOnly = true;
            clmName.Width = 300;
            // 
            // clmMajor
            // 
            clmMajor.HeaderText = "Chuyên Ngành";
            clmMajor.MinimumWidth = 8;
            clmMajor.Name = "clmMajor";
            clmMajor.ReadOnly = true;
            clmMajor.Width = 250;
            // 
            // clmGenre
            // 
            clmGenre.HeaderText = "Giới Tính";
            clmGenre.MinimumWidth = 8;
            clmGenre.Name = "clmGenre";
            clmGenre.ReadOnly = true;
            clmGenre.Width = 150;
            // 
            // idAmmount
            // 
            idAmmount.HeaderText = "Số Môn";
            idAmmount.MinimumWidth = 8;
            idAmmount.Name = "idAmmount";
            idAmmount.ReadOnly = true;
            idAmmount.Width = 80;
            // 
            // Bai09
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 578);
            Controls.Add(dtgv);
            Controls.Add(gbxTitle);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Bai09";
            Text = "Nhập Liệu Sinh Viên";
            gbxTitle.ResumeLayout(false);
            gbxTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxTitle;
        private Label lbHoTen;
        private Label lbMSV;
        private Label lbGender;
        private Label lbMajor;
        private Label lbPick;
        private CheckBox cbFemale;
        private CheckBox cbMale;
        private ComboBox cbMajor;
        private TextBox tbMSV;
        private TextBox tbHoTen;
        private ListBox lbxRight;
        private ListBox lbxLeft;
        private Button btnDelete;
        private Button btnSave;
        private Button btnLeft;
        private Button btnRight;
        private DataGridView dtgv;
        private DataGridViewTextBoxColumn clmID;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmMajor;
        private DataGridViewTextBoxColumn clmGenre;
        private DataGridViewTextBoxColumn idAmmount;
    }
}
