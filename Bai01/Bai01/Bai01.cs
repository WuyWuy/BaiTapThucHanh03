namespace Bai01
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
            MessageBox.Show("Construction");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Load Form");
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("Activated Form");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Show Form");
        }

        private void Form1_Deactivated(object sender, EventArgs e)
        {
            MessageBox.Show("Deactivated Form");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Closing Form");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Closed Form");
        }
    }
}
