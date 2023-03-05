

using System.Diagnostics;
using System.Globalization;
using System.Linq.Expressions;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        string op;
        double var1 = 0;
        double var2 = 0;
        double res;
        public Calculadora()
        {
            InitializeComponent();
        }

        

        //  START NUMBER BUTTONS
        private void btn_0_Click(object sender, EventArgs e)
        {
            tb_result.Text += "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            tb_result.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            tb_result.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            tb_result.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            tb_result.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            tb_result.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            tb_result.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            tb_result.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            tb_result.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            tb_result.Text += "9";
        }

        private void btn_dot_Click(object sender, EventArgs e)
        {
            tb_result.Text += ".";
        }

        // END OF NUMBER BUTTONS
        // START OF OPERATION BUTTONS
        private void btn_sum_Click(object sender, EventArgs e)
        {
            var1 = double.Parse(tb_result.Text, CultureInfo.InvariantCulture);
            tb_result.Text = "";
            op = "+";
            tb_op.Text = "+";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            var1 = double.Parse(tb_result.Text, CultureInfo.InvariantCulture);
            tb_result.Text = "";
            op = "-";
            tb_op.Text = "-";
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            var1 = double.Parse(tb_result.Text, CultureInfo.InvariantCulture);
            tb_result.Text = "";
            op = "x";
            tb_op.Text = "x";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            var1 = double.Parse(tb_result.Text, CultureInfo.InvariantCulture);
            tb_result.Text = "";
            op = "/";
            tb_op.Text = "/";
        }

        // END OF OPERATIONS BUTTONS
        // START SWITCH CASES

        private void btn_igual_Click(object sender, EventArgs e)
        {
            var2 = double.Parse(tb_result.Text, CultureInfo.InvariantCulture);

            switch (op)
            {
                case "+":
                    res = var1 + var2;
                    tb_result.Text = Convert.ToString(res, CultureInfo.InvariantCulture);
                    break;
                case "-":
                    res = var1 - var2;
                    tb_result.Text = Convert.ToString(res, CultureInfo.InvariantCulture);
                    break;
                case "x":
                    res = var1 * var2;
                    tb_result.Text = Convert.ToString(res, CultureInfo.InvariantCulture);
                    break;
                case "/":
                    res = var1 / var2;
                    tb_result.Text = Convert.ToString(res, CultureInfo.InvariantCulture);
                    break;
            }

            

        }

        // END OF SWITCH CASES
        // START OF BUTTONS CLEAR

        private void btn_CE_Click(object sender, EventArgs e)
        {
            tb_result.Clear();
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            tb_result.Clear();
            tb_op.Clear();
            var1 = 0;
            var2 = 0;
        }
    }

    
}