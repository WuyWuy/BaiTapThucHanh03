namespace Bai03
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
            button1.Location = new Point((this.ClientSize.Width - button1.Width) / 2,
                                          (this.ClientSize.Height - button1.Height) / 2);

            button1.Cursor = Cursors.Hand;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random rand = new Random();

            int r = rand.Next(0, 256), g = rand.Next(0, 256), b = rand.Next(0, 256);

            Color randColor = Color.FromArgb(r, g, b);

            this.BackColor = randColor;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
