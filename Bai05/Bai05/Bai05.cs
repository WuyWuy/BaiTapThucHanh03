using System.Security.Cryptography.Xml;

namespace Bai05
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
        private bool isNumber(string s)
        {

            if (s.Length == 0) return false; bool haveNumber = false;

            if (s.Length == 1 && (s[0] < '0' || s[0] > '9')) return false;

            int i = 0; if (s[i] == '-') i++;    int cnt = 0;

            for (int k = 0; k < s.Length; k++) if (s[k] == '.') cnt++;

            if (cnt > 1) return false;

            for (int x = i; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9') haveNumber = true;
                else
                {

                    if (s[i] == '.' && haveNumber) continue; return false;

                }
            }

            return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string a = tbNum1.Text, b = tbNum2.Text;

            if (!isNumber(a) || !isNumber(b))
            {
                MessageBox.Show("Cần nhập số chính xác!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double x = double.Parse(a), y = double.Parse(b);

            tbAnswer.Text = (x + y).ToString();

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            string a = tbNum1.Text, b = tbNum2.Text;

            if (!isNumber(a) || !isNumber(b))
            {
                MessageBox.Show("Cần nhập số chính xác!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double x = double.Parse(a), y = double.Parse(b);

            tbAnswer.Text = (x - y).ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            string a = tbNum1.Text, b = tbNum2.Text;

            if (!isNumber(a) || !isNumber(b))
            {
                MessageBox.Show("Cần nhập số chính xác!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double x = double.Parse(a), y = double.Parse(b);

            tbAnswer.Text = (x * y).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            string a = tbNum1.Text, b = tbNum2.Text;

            if (!isNumber(a) || !isNumber(b))
            {
                MessageBox.Show("Cần nhập số chính xác!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double x = double.Parse(a), y = double.Parse(b);

            if (y == 0)
            {
                MessageBox.Show("Mẫu số phải khác 0", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tbAnswer.Text = (x / y).ToString();
        }
    }

}
