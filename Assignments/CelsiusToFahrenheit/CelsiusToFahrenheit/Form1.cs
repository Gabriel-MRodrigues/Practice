using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CelsiusToFahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double dblCelsius = -1; //input
            double dblMath = -1; 

            try
            {
                dblCelsius = double.Parse(txtInput.Text);
                dblMath = (dblCelsius * 9 / 5) + 32;

                lblOutput.Text = dblMath.ToString("n2") + " °F";
            }
            catch
            {
                MessageBox.Show("The property value you entered is invalid. Try only numbers.");
                txtInput.Text = "";
                txtInput.Focus();
                lblOutput.Text = "";
            }

        }
    }
}
