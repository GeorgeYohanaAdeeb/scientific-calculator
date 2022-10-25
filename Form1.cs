using Equl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace scientific_calculator
{

    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 260;
            txtDisply.Width = 215;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 260;
            txtDisply.Width = 215;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 575;
            txtDisply.Width = 525;

        }

        private void temputureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 temp = new Form2();
            temp.Show();
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 mult = new Form3();
            mult.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisply.Text == "0") || (enter_value))
                txtDisply.Text = "";
            enter_value = false;
            Button num1 = (Button)sender;
            if (num1.Text == ".")
            {
                if (!txtDisply.Text.Contains("."))
                    txtDisply.Text = txtDisply.Text + num1.Text;
            }
            else
                txtDisply.Text = txtDisply.Text + num1.Text;
        }

        private void arithmetic_operator(object sender, EventArgs e)
        {
            Button op = (Button)sender;
            operation = op.Text.ToString();
            results = Double.Parse(txtDisply.Text);
            txtDisply.Text = "";
            lblShowOp.Text = lblShowOp.Text.ToString() + System.Convert.ToString(results + " " + operation);
        }
        private void bt_Equls_Click(object sender, EventArgs e)
        {
            lblShowOp.Text += txtDisply.Text;
            EQUL equal = new EQUL();
            txtDisply.Text = Convert.ToString(EQUL.Arithmetic(lblShowOp.Text.ToString()));
            lblShowOp.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisply.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisply.Text = "0";
            lblShowOp.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisply.Text.Length > 0)
            {
                txtDisply.Text = txtDisply.Text.Remove(txtDisply.Text.Length - 1, 1);
            }
            if (txtDisply.Text == "")
            {
                txtDisply.Text = "0";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            txtDisply.Text = "3.14159265359";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtDisply.Text);
            lblShowOp.Text= System.Convert.ToString("log"+"( "+(txtDisply.Text)+" )");
            ilog = Math.Log10(ilog);
            txtDisply.Text = System.Convert.ToString(ilog);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(txtDisply.Text);
            lblShowOp.Text = System.Convert.ToString("Sqrt" + "( " + (txtDisply.Text) + " )");
            sq = Math.Sqrt(sq);
            txtDisply.Text = System.Convert.ToString(sq);
        }
        private void button28_Click(object sender, EventArgs e)
        {
            double cu = Double.Parse(txtDisply.Text);
            lblShowOp.Text = System.Convert.ToString("Cube" + "( " + (txtDisply.Text) + " )");
            cu = Math.Ceiling(Math.Pow(cu, (double)1 / 3));
            txtDisply.Text = System.Convert.ToString(cu);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double qshinh = Double.Parse(txtDisply.Text);
            lblShowOp.Text = System.Convert.ToString("Sinh" + "( " + (txtDisply.Text) + " )");
            qshinh = Math.Sinh(qshinh);
            txtDisply.Text = System.Convert.ToString(qshinh);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double qshin = Double.Parse(txtDisply.Text);
            lblShowOp.Text = System.Convert.ToString("Sin" + "( " + (txtDisply.Text) + " )");
            qshin = Math.Sin(qshin);
            txtDisply.Text = System.Convert.ToString(qshin);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double qcosh = Double.Parse(txtDisply.Text);
            lblShowOp.Text = System.Convert.ToString("Cosh" + "( " + (txtDisply.Text) + " )");
            qcosh = Math.Cosh(qcosh);
            txtDisply.Text = System.Convert.ToString(qcosh);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double qcos = Double.Parse(txtDisply.Text);
            lblShowOp.Text = System.Convert.ToString("Cos" + "( " + (txtDisply.Text) + " )");
            qcos = Math.Cos(qcos);
            txtDisply.Text = System.Convert.ToString(qcos);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double qtanh = Double.Parse(txtDisply.Text);
            lblShowOp.Text = System.Convert.ToString("Tanh" + "( " + (txtDisply.Text) + " )");
            qtanh = Math.Tanh(qtanh);
            txtDisply.Text = System.Convert.ToString(qtanh);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            double qtan = Double.Parse(txtDisply.Text);
            lblShowOp.Text = System.Convert.ToString("Tan" + "( " + (txtDisply.Text) + " )");
            qtan = Math.Tan(qtan);
            txtDisply.Text = System.Convert.ToString(qtan);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisply.Text);
            txtDisply.Text = System.Convert.ToString(a, 2);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisply.Text);
            txtDisply.Text = System.Convert.ToString(a,10);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisply.Text);
            txtDisply.Text = System.Convert.ToString(a, 8);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisply.Text);
            txtDisply.Text = System.Convert.ToString(a, 16);
        }
        private void button30_Click(object sender, EventArgs e)
        {
            double i = Double.Parse(txtDisply.Text);
            i = Math.Exp(i);
            txtDisply.Text = System.Convert.ToString(i);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisply.Text));
            txtDisply.Text = System.Convert.ToString(a);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisply.Text) * Convert.ToDouble(txtDisply.Text);
            txtDisply.Text = System.Convert.ToString(a);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisply.Text) * Convert.ToDouble(txtDisply.Text) * Convert.ToDouble(txtDisply.Text);
            txtDisply.Text = System.Convert.ToString(a);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtDisply.Text);
            lblShowOp.Text = System.Convert.ToString("ln" + "( " + (txtDisply.Text) + " )");
            ilog = Math.Log(ilog);
            txtDisply.Text = System.Convert.ToString(ilog);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisply.Text) / Convert.ToDouble(100);
            txtDisply.Text = System.Convert.ToString(a);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisply.Text);
            if (a < 0)
                txtDisply.Text = System.Convert.ToString(Math.Abs(a));
            else
                txtDisply.Text = System.Convert.ToString(Math.Abs(a) * -1);
        }

    }
}
