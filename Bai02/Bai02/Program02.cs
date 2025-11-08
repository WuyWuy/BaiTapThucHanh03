namespace Bai02
{
    internal static class Program02
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Bai02 f = new Bai02(); Button b = new Button();

            b.Text = "Paint";
            b.Location = new Point( (f.ClientSize.Width - b.Width) / 2 , 
                                    (f.ClientSize.Height - b.Height) / 2);

            b.Click += new EventHandler( b_Click );
            
            f.Controls.Add(b);  f.AcceptButton = b;

            Application.Run(f);

        }

        static void b_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            Form f = btn.FindForm();

            Graphics gx = f.CreateGraphics();

            Random random = new Random();

            int randX = random.Next(0, f.ClientSize.Width), randY = random.Next(0, f.ClientSize.Height);

            gx.DrawString("Paint Event", f.Font, Brushes.Black,  randX, randY);

        }

    }
}