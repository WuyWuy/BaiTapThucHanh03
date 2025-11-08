namespace Bai06
{
    public partial class Bai06 : Form
    {

        private bool isSecondPanelEmpty = true;
        private bool isFirstPanelEmpty = true;

        private bool haveDot = false;

        private double dFirstNum = 0;
        private double dSecondNum = 0;

        private char curOp = ' ';
        private char preOp = ' ';

        private double dMemory = 0;
        private bool haveMemory = false;

        public Bai06()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

        }
        private void enableOps(bool x)
        {

            btnOpPlus.Enabled = x;
            btnOpMinus.Enabled = x;
            btnOpMul.Enabled = x;
            btnOpDiv.Enabled = x;

            btnOpMR.Enabled = haveMemory;
            if (tbCal1.Text == "Cannot divided by zero!") btnOpMR.Enabled = false;

            btnOpMAdd.Enabled = x;
            btnOpMS.Enabled = x;
            btnOpMC.Enabled = x;

            btnNumDot.Enabled = x;
            btnNum1DivX.Enabled = x;
            btnNumNegate.Enabled = x;
            btnNumSqrt.Enabled = x;
            btnNumPercent.Enabled = x;

        }
        private bool haveDigit(string s)
        {
            int n = s.Length; if (n == 0) return true;

            for (int i = 0; i < n; i++)
            {

                if (s[i] == '+' || s[i] == '-' || s[i] == '*' || s[i] == '/' || s[i] == '(' || s[i] == ')') return true;

            }

            return false;
        }
        private bool checkSpecial(string s)
        {

            if (s.Length > 0)
            {

                if (s[0] == 'n') return true;

                if (s.Length > 1 && s[1] == '(') return true;

                if (s.Length > 2 && s[2] == '(') return true;

            }

            return false;

        }
        private bool checkEqualDigit(string s)
        {
            if (s.Length > 1)
            {

                int k = s.Length;

                if (s[k - 2] == '=') return true;

            }

            return false;
        }
        private void addNumToCal(int x)
        {

            enableOps(true);

            if (checkEqualDigit(tbCal2.Text))
            {
                tbCal2.Text = ""; doReset();
            }

            if (isFirstPanelEmpty)
            {

                isFirstPanelEmpty = false;
                tbCal1.Text = string.Empty;

            }

            tbCal1.Text += x.ToString();
            btnOpMR.Enabled = haveMemory;

        }
        private void doReset()
        {
            dFirstNum = 0; dSecondNum = 0;
            curOp = ' '; preOp = ' ';
            isSecondPanelEmpty = true; isFirstPanelEmpty = true;
            
        }
        private void doOperation(char x)
        {

            dFirstNum = double.Parse(tbCal1.Text); haveDot = false;

            if (x == '+' || x == '-' || x == '*' || x == '/') curOp = x;

            if (isSecondPanelEmpty == true)
            {

                tbCal2.Text = tbCal1.Text + " " + x + " ";

                dSecondNum = dFirstNum;

            }
            else
            {

                bool isDivideZero = false;
                double res = 0;

                switch (preOp)
                {
                    case '+': res = dSecondNum + dFirstNum; break;
                    case '-': res = dSecondNum - dFirstNum; break;
                    case '*': res = dSecondNum * dFirstNum; break;
                    case '/':
                        {

                            if (dFirstNum == 0)
                            {
                                isDivideZero = true;
                                tbCal1.Text = "Cannot divided by zero!";
                                enableOps(false);

                                break;
                            }

                            res = dSecondNum / dFirstNum; break;
                        }

                    default: break;

                }

                if (isDivideZero == true)
                {
                    tbCal2.Text = ""; doReset();

                    return;

                }

                if (x == '=')
                {

                    tbCal2.Text = dSecondNum.ToString() + " " + preOp + " "
                                + dFirstNum.ToString() + " = ";
                    doReset();

                    tbCal1.Text = res.ToString();
                    return;

                }
                else tbCal2.Text = res.ToString() + " " + curOp + " ";

                tbCal1.Text = res.ToString();

                dSecondNum = res;
            }

            isSecondPanelEmpty = false; isFirstPanelEmpty = true;

            preOp = curOp;

        }
        private void btnNum0_Click(object sender, EventArgs e)
        {
            addNumToCal(0);
        }
        private void btnNum1_Click(object sender, EventArgs e)
        {
            addNumToCal(1);
        }
        private void btnNum2_Click(object sender, EventArgs e)
        {
            addNumToCal(2);
        }
        private void btnNum3_Click(object sender, EventArgs e)
        {
            addNumToCal(3);
        }
        private void btnNum4_Click(object sender, EventArgs e)
        {
            addNumToCal(4);
        }
        private void btnNum5_Click(object sender, EventArgs e)
        {
            addNumToCal(5);
        }
        private void btnNum6_Click(object sender, EventArgs e)
        {
            addNumToCal(6);
        }
        private void btnNum7_Click(object sender, EventArgs e)
        {
            addNumToCal(7);
        }
        private void btnNum8_Click(object sender, EventArgs e)
        {
            addNumToCal(8);
        }
        private void btnNum9_Click(object sender, EventArgs e)
        {
            addNumToCal(9);
        }
        private void btnOpPlus_Click(object sender, EventArgs e)
        {
            doOperation('+');
        }
        private void btnOpMinus_Click(object sender, EventArgs e)
        {
            doOperation('-');
        }
        private void btnOpMul_Click(object sender, EventArgs e)
        {
            doOperation('*');
        }
        private void btnOpDiv_Click(object sender, EventArgs e)
        {
            doOperation('/');
        }
        private void btnOpEqual_Click(object sender, EventArgs e)
        {

            if (checkEqualDigit(tbCal2.Text) || (curOp == ' ' && tbCal2.Text != string.Empty)) return;

            if (tbCal1.Text == "Cannot divided by zero!")
            {

                doReset(); tbCal1.Text = "0"; tbCal2.Text = ""; enableOps(true);

                return;
            }

            doOperation('=');   
        }
        private void btnNumDot_Click(object sender, EventArgs e)
        {

            string s = tbCal1.Text;

            foreach (char x in s) if (x == '.') return;

            if (haveDot == false)
            {
                tbCal1.Text += "."; haveDot = true;
            }

            if (checkEqualDigit(tbCal2.Text))
            {
                doReset(); isFirstPanelEmpty = false;
                tbCal1.Text = "0.";
                tbCal2.Text = "";
            }

        }
        private void btnNumNegate_Click(object sender, EventArgs e)
        {

            string s = tbCal1.Text; string ss = tbCal2.Text;

            if (s[0] == '-') s = s.Substring(1);
            else s = '-' + s;

            if (checkEqualDigit(ss))
            {
                tbCal2.Text = "negate( " + tbCal1.Text + " )";
            }

            tbCal1.Text = s;

            if (checkSpecial(ss))
            {
                tbCal2.Text = "negate( " + tbCal2.Text + " )";
            }

        }
        private void btnNumPercent_Click(object sender, EventArgs e)
        {

            string s = tbCal1.Text; string ss = tbCal2.Text;
            double x = double.Parse(s);

            x /= 100; tbCal1.Text = x.ToString();

            if (checkEqualDigit(ss) || (!haveDigit(ss) && (x == double.Parse(ss) / 100)) || checkSpecial(ss))
            {
                tbCal2.Text = x.ToString();
            }

        }
        private void btnNum1DivX_Click(object sender, EventArgs e)
        {
            string s = tbCal1.Text; string ss = tbCal2.Text;

            double x = double.Parse(s);

            x = 1 / x;

            if (checkEqualDigit(ss) || ss.Length == 0)
            {
                tbCal2.Text = "1/( " + tbCal1.Text + " )";
            }

            tbCal1.Text = x.ToString();

            if (checkSpecial(ss))
            {
                tbCal2.Text = "1/( " + tbCal2.Text + " )";
            }
        }
        private void btnNumSqrt_Click(object sender, EventArgs e)
        {
            string s = tbCal1.Text; string ss = tbCal2.Text;

            double x = double.Parse(s);

            x = Math.Sqrt(x);

            if (checkEqualDigit(ss) || ss.Length == 0)
            {
                tbCal2.Text = "√( " + tbCal1.Text + " )";
            }

            tbCal1.Text = x.ToString();

            if (checkSpecial(ss))
            {
                tbCal2.Text = "√( " + tbCal2.Text + " )";
            }
        }
        private void btnOpBackSpace_Click(object sender, EventArgs e)
        {

            if (tbCal1.Text == "Cannot divided by zero!")
            {

                doReset(); tbCal1.Text = "0"; tbCal2.Text = ""; enableOps(true);

                return;
            }

            if (checkEqualDigit(tbCal2.Text))
            {
                tbCal2.Text = "";
            }
            else
            {
                string s = tbCal1.Text;

                if (s.Length == 1)
                {
                    tbCal1.Text = "0"; isFirstPanelEmpty = true;
                }
                else
                {
                    tbCal1.Text = s.Substring(0, s.Length - 1);
                }

            }

        }
        private void btnOpClearEntry_Click(object sender, EventArgs e)
        {
            tbCal1.Text = "0"; isFirstPanelEmpty = true; 
        }
        private void btnOpClear_Click(object sender, EventArgs e)
        {
            doReset(); tbCal1.Text = "0"; tbCal2.Text = "";
        }
        private void btnOpMR_Click(object sender, EventArgs e)
        {
            tbCal1.Text = dMemory.ToString();
            if (dMemory == 0) isFirstPanelEmpty = true;

            if (checkEqualDigit(tbCal2.Text))
            {
                tbCal2.Text = "";
            }

        }
        private void btnOpMS_Click(object sender, EventArgs e)
        {
            dMemory = double.Parse(tbCal1.Text);
            btnOpMR.Enabled = true;
            haveMemory = true;
        }
        private void btnOpMAdd_Click(object sender, EventArgs e)
        {
            dMemory += double.Parse(tbCal1.Text);
            btnOpMR.Enabled = true;
            haveMemory = true;
        }
        private void btnOpMC_Click(object sender, EventArgs e)
        {
            dMemory = 0;
            btnOpMR.Enabled = false; haveMemory = false;
            if (checkEqualDigit(tbCal2.Text))
            {
                tbCal2.Text = "";
            }
        }
    }
}
