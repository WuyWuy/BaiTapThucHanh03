using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace Bai08
{
    public partial class Bai08 : Form
    {

        private bool isUpdate = false;
        public Bai08()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            lbSum.Text = "0 VNĐ";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool isNumber(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        private bool isMoney(string str)
        {

            bool hasDecimalPoint = false;

            if (str[0] == '.' || str[str.Length - 1] == '.') return false; // Dấu chấm không thể ở đầu hoặc cuối chuỗi

            foreach (char c in str)
            {
                if (c == '.')
                {
                    if (hasDecimalPoint) return false;  // Chỉ cho phép một dấu chấm thập phân
                    else hasDecimalPoint = true;
                }
                else if (c < '0' || c > '9')
                {
                    return false; // Không phải chữ số
                }
            }

            return true;

        }

        private bool isChar(string s)
        {

            foreach(char c in s)
            {
                if ( !((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')) ) return false;
            }

            return true;
        }
        private double getSum()
        {

            string s = lbSum.Text;

            double sum = double.Parse(s.Substring(0, s.Length - 3));

            return sum;
        }

        private void AdjustSum(string newMoney, string oldMoney)
        {

            double res = getSum(), a = double.Parse(newMoney), b = double.Parse(oldMoney);

            res = res + a - b;

            lbSum.Text = res.ToString() + " VNĐ";

        }
        private void clearTextBox()
        {
            tbSTK.Text = "";
            tbTenKH.Text = "";
            tbDiaChi.Text = "";
            tbSoTien.Text = "";
        }

        private bool checkInput(string STK, string TenKH, string DiaChi, string SoTien)
        {


            if (STK == "" || TenKH == "" || DiaChi == "" || SoTien == ""
                || !isChar(TenKH) || !isNumber(STK) || !isMoney(SoTien)) return false;
            return true;

        }
        private bool existMaKH(string MaKH)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == MaKH)
                    return true;
            }
            return false;
        }
        private ListViewItem findItemOnSTK(string STK)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[1].Text == STK)
                    return item;
            }
            return null;
        }
        private void btnCU_Click(object sender, EventArgs e)
        {

            string STK = tbSTK.Text;
            string TenKH = tbTenKH.Text;
            string DiaChi = tbDiaChi.Text;
            string SoTien = tbSoTien.Text;

            if (!checkInput(STK, TenKH, DiaChi, SoTien))
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (existMaKH(STK))
            {

                ListViewItem selectedItem = findItemOnSTK(STK);

                AdjustSum(SoTien, selectedItem.SubItems[4].Text);
                selectedItem.SubItems[1].Text = STK;
                selectedItem.SubItems[2].Text = TenKH;
                selectedItem.SubItems[3].Text = DiaChi;
                selectedItem.SubItems[4].Text = SoTien;
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;

            }

            int STT = listView1.Items.Count + 1;

            ListViewItem item = new ListViewItem(STT.ToString());

            item.SubItems.Add(tbSTK.Text);
            item.SubItems.Add(tbTenKH.Text);
            item.SubItems.Add(tbDiaChi.Text);
            item.SubItems.Add(tbSoTien.Text);
            AdjustSum(SoTien, "0");

            listView1.Items.Add(item);

            clearTextBox();

            MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                tbSTK.Text = item.SubItems[1].Text;
                tbTenKH.Text = item.SubItems[2].Text;
                tbDiaChi.Text = item.SubItems[3].Text;
                tbSoTien.Text = item.SubItems[4].Text;
                isUpdate = true;
            }

        }

        private void btnD_Click(object sender, EventArgs e)
        {

            string STK = tbSTK.Text;
            string TenKH = tbTenKH.Text;
            string DiaChi = tbDiaChi.Text;
            string SoTien = tbSoTien.Text;

            if (existMaKH(STK))
            {

                DialogResult res = MessageBox.Show("Bạn có muốn xóa tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.No) return;

                ListViewItem selectedItem = findItemOnSTK(STK);
                listView1.Items.Remove(selectedItem);
                AdjustSum("0", SoTien);
                clearTextBox();

                MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
