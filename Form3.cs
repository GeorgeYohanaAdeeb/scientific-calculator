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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnmty_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(txtMult.Text);
            for(int i = 1; i < 13; i++)
            {
                multplyList.Items.Add(i + "x" + a + "=" + a * i);
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txtMult.Clear();
            multplyList.Items.Clear();
        }

        
    }
}
