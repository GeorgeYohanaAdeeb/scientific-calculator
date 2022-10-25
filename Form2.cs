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
    

    public partial class Form2 : Form
    {
        float iCelsius, iFahrenheit, iKelvin;
        char iOperation;
        public Form2()
        {
            InitializeComponent();
        }

        private void rbCelToFah_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void rbFahToCel_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void rbKeliv_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }

        

        private void button41_Click(object sender, EventArgs e)
        {
            switch (iOperation)
            {
                case 'C':
                    iCelsius = float.Parse(txtConvert.Text);
                    lblConvert.Text = ((((9 * iCelsius) / 5) + 32).ToString());
                    break;
                case 'F':
                    iFahrenheit = float.Parse(txtConvert.Text);
                    lblConvert.Text = ((((iFahrenheit - 32) * 5) / 9).ToString());
                    break;
                case 'K':
                    iKelvin = float.Parse(txtConvert.Text);
                    lblConvert.Text = (((((9 * iKelvin) / 5) + 32) + 273.15).ToString());
                    break;
            }
        }
        private void button42_Click(object sender, EventArgs e)
        {
            txtConvert.Clear();
            lblConvert.Text = "";
            rbCelToFah.Checked = false;
            rbFahToCel.Checked = false;
            rbKeliv.Checked = false;
        }
    }
}
