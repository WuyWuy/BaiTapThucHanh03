namespace Bai07
{
    public partial class Bai07 : Form
    {

        private bool[] isSelected = new bool[15];
        private bool[] isPicked = new bool[15];

        private Button[] buttons;

        private int totalMoney = 0;
        public Bai07()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            buttons = new Button[15]
            {
                button1, button2, button3, button4, button5,
                button6, button7, button8, button9, button10,
                button11, button12, button13, button14, button15
            };

        }

        private void selectButton(int index, Button btn)
        {

            if (isPicked[index] == true)
            {
                MessageBox.Show("Ghế đã được chọn, vui lòng chọn ghế khác!", "Thông báo");
                return;
            }

            isSelected[index] = !isSelected[index];

            if (isSelected[index] == true)
            {
                btn.BackColor = Color.Blue;
            }
            else btn.BackColor = SystemColors.Control;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectButton(0, (Button)sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectButton(1, (Button)sender);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            selectButton(2, (Button)sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectButton(3, (Button)sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectButton(4, (Button)sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selectButton(5, (Button)sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            selectButton(6, (Button)sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            selectButton(7, (Button)sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            selectButton(8, (Button)sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            selectButton(9, (Button)sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            selectButton(10, (Button)sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            selectButton(11, (Button)sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            selectButton(12, (Button)sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            selectButton(13, (Button)sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            selectButton(14, (Button)sender);
        }

        private void buttonPick_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (isSelected[i] == true)
                {

                    isPicked[i] = true; isSelected[i] = false;

                    buttons[i].BackColor = Color.Yellow;

                    if (i < 5)
                    {
                        totalMoney += 5000;
                    }
                    else if (i < 10)
                    {
                        totalMoney += 6500;
                    }
                    else
                    {
                        totalMoney += 8000;
                    }

                }
            }

            label3.Text = totalMoney.ToString() + " VNĐ";

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (isSelected[i] == true)
                {

                    isSelected[i] = false;

                    buttons[i].BackColor = SystemColors.Control;

                    if (i < 5)
                    {
                        totalMoney -= 5000;
                    }
                    else if (i < 10)
                    {
                        totalMoney -= 6500;
                    }
                    else
                    {
                        totalMoney -= 8000;
                    }

                }
                totalMoney = 0;
                label3.Text = "0 VNĐ";
            }
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Tổng tiền thanh toán: " + totalMoney.ToString() + " VNĐ", "Kết thúc");

            for (int i = 0; i < buttons.Length; i++)
            {
                isSelected[i] = false; isPicked[i] = false;
                buttons[i].BackColor = SystemColors.Control;
            }
        }

    }
}
