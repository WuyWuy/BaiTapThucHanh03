namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void dialogToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ColorDialog colorDialog = new ColorDialog();

            if ( colorDialog.ShowDialog() == DialogResult.OK)
            {

                BackColor = colorDialog.Color;

            }

        }
    }
}
