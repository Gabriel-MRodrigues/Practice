using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();

            double organisms = -1;
            double days = -1;
            double increase = -1;

            if (double.TryParse(txtStartingNumber.Text, out organisms) && organisms >= 0)
            {
                if (double.TryParse(txtDailyIncrease.Text, out increase) && increase >= 0)
                {
                    if (double.TryParse(txtDays.Text, out days) && days >= 1)
                    {
                        lstOutput.Items.Add("Starting Number: " + organisms.ToString());
                        lstOutput.Items.Add("Daily Increase (%): " + increase.ToString() + "%");
                        lstOutput.Items.Add("Number of Days: " + days.ToString());
                        lstOutput.Items.Add("---------------------------------------");

                        txtDailyIncrease.Text = "";
                        txtStartingNumber.Text = "";
                        txtDays.Text = "";

                        for (int i = 1; i <= days; i++)
                        {
                            lstOutput.Items.Add("Day " + i.ToString() + " | Population: " + organisms.ToString("n2"));
                            organisms = organisms + (organisms * (increase / 100));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid enter for Days.");
                        txtDays.Text = "";
                        txtDays.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid enter for Daily Increase.");
                    txtDailyIncrease.Text = "";
                    txtDailyIncrease.Focus();
                }
            }
            else
            {
                MessageBox.Show("Invalid enter for Starting Number.");
                txtStartingNumber.Text = "";
                txtStartingNumber.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
