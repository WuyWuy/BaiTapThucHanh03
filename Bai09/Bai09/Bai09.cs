namespace Bai09
{
    public partial class Bai09 : Form
    {

        private List<string> listLeft;
        private List<string> listRight;
        public Bai09()
        {

            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            listLeft = lbxLeft.Items.Cast<string>().ToList();
            listRight = lbxRight.Items.Cast<string>().ToList();

        }
        private bool isNumber(string s)
        {
            if (s == string.Empty) return false;
            foreach (char x in s)
            {
                if (x < '0' || x > '9') return false;
            }
            return true;
        }
        private bool isDigit(string s)
        {
            if (s == string.Empty) return false;
            foreach (char x in s)
            {
                if (!((x >= 'a' && x <= 'z') || (x >= 'A' && x <= 'Z'))) return false;
            }
            return true;
        }

        private void clearData()
        {
            cbFemale.Checked = cbMale.Checked = false;
            tbHoTen.Text = tbMSV.Text = "";

            cbMajor.SelectedIndex = -1;

            lbxLeft.Items.Clear(); lbxRight.Items.Clear();
            lbxLeft.Items.AddRange(listLeft.ToArray());
            lbxRight.Items.AddRange(listRight.ToArray());
        }

        private void cbMale_CheckedChanged(object sender, EventArgs e)
        {

            if (cbMale.Checked)
            {
                cbFemale.Checked = false;
            }

        }

        private void cbFemale_CheckedChanged(object sender, EventArgs e)
        {

            if (cbFemale.Checked)
            {
                cbMale.Checked = false;
            }

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (lbxLeft.SelectedItem != null)
            {
                lbxRight.Items.Add(lbxLeft.SelectedItem);
                lbxLeft.Items.Remove(lbxLeft.SelectedItem);
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (lbxRight.SelectedItem != null)
            {
                lbxLeft.Items.Add(lbxRight.SelectedItem);
                lbxRight.Items.Remove(lbxRight.SelectedItem);
            }
        }

        private void addData()
        {
            string sGenre = (cbMale.Checked ? "Nam" : "Nữ");

            object[] item = { tbMSV.Text, tbHoTen.Text, cbMajor.Text, sGenre, lbxRight.Items.Count };

            dtgv.Rows.Add(item);

            MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void updateData()
        {
            string sGenre = (cbMale.Checked ? "Nam" : "Nữ");

            object[] item = { tbMSV.Text, tbHoTen.Text, cbMajor.Text, sGenre, lbxRight.Items.Count };

            DataGridViewRow x = null;

            foreach (DataGridViewRow row in dtgv.Rows)
            {

                if (!row.IsNewRow && row.Cells[0].Value.ToString() == tbMSV.Text)
                {
                    x = row; break;
                }

            }

            if (x != null) x.SetValues(item);

            MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private bool existID(string s)
        {
            foreach (DataGridViewRow row in dtgv.Rows)
            {
                if (!row.IsNewRow && row.Cells[0].Value.ToString() == s) return true;
            }
            return false;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isNumber(tbMSV.Text) || !isDigit(tbHoTen.Text) ||
                 (cbMale.Checked == false && cbFemale.Checked == false
                 || cbMajor.SelectedIndex == -1)
                 || lbxRight.Items.Count == 0)
            {
                MessageBox.Show("Thông tin chưa đúng hoặc thiếu!");
                return;
            }

            if (!existID(tbMSV.Text)) addData();
            else updateData();

            clearData();

        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dtgv.Rows[e.RowIndex];

                tbMSV.Text = row.Cells[0].Value?.ToString();
                tbHoTen.Text = row.Cells[1].Value?.ToString();
                cbMajor.Text = row.Cells[2].Value?.ToString();

                if (row.Cells[3].Value?.ToString() == "Nam")
                    cbMale.Checked = true;
                else
                    cbFemale.Checked = true;

            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if ( dtgv.SelectedRows.Count > 0)
            {

                DataGridViewRow row = dtgv.SelectedRows[0];

                if (row.Cells[0].Value == null)
                {
                    MessageBox.Show("Vui lòng chọn ô để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dtgv.Rows.Remove(row);

            }

        }
    }
}
