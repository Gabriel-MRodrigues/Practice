using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joe_s_Automotive
{
    public partial class Form1 : Form
    {
        int OilChangePRICE = 26;
        int LubeJobPRICE = 18;
        int RadiatorFlushPRICE = 30;
        int TransmissionFlushPRICE = 80;
        int InspectionPRICE = 15;
        int ReplaceMufflerPRICE = 100;
        int TireRotationPRICE = 20;

        const double Tax = 0.06;

        double partsCost = -1;
        double laborCost = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearOilLube()
        {
            chkOilChange.Checked = false;
            chkLube.Checked = false;
        }

        private void ClearFlushes()
        {
            chkRadiator.Checked = false;
            chkTransmission.Checked = false;
        }

        private void ClearMisc()
        {
            chkInspection.Checked = false;
            chkMuffler.Checked = false;
            chkTireRotation.Checked = false;
        }

        private void ClearPartsLabor()
        {
            txtLabor.Text = "";
            txtParts.Text = "";
        }

        private void ClearFees()
        {
            lblPartsOutput.Text = "";
            lblServiceLaborOutput.Text = "";
            lblTaxOutput.Text = "";
            lblTotalFeesOutput.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearPartsLabor();
            ClearFees();
        }

        private bool isValidInput(ref double partsCost, ref double laborCost)
        {
            bool isValid = false;

            if ((double.TryParse(txtParts.Text, out partsCost) && partsCost >= 0) || txtParts.Text == "")
            {
                if ((double.TryParse(txtLabor.Text, out laborCost) && laborCost >= 0) || txtLabor.Text == "")
                {
                    isValid = true;
                }
                else
                {
                    MessageBox.Show("Invalid enter for Labor.");
                    txtLabor.Text = "";
                    txtLabor.Focus();
                }
            }
            else
            {
                MessageBox.Show("Invalid enter for Parts.");
                txtParts.Text = "";
                txtParts.Focus();
            }

            return isValid;
        }

        private int oilAndLube()
        {
            int oilLube = 0;

            if (chkOilChange.Checked == true)
            {
                oilLube +=  OilChangePRICE;
            }
            if (chkLube.Checked == true)
            {
                oilLube += LubeJobPRICE;
            }

            return oilLube;
        }

        private int flushes()
        {
            int flushes = 0;

            if (chkRadiator.Checked == true)
            {
                flushes += RadiatorFlushPRICE;
            }
            if (chkTransmission.Checked == true)
            {
                flushes += TransmissionFlushPRICE;
            }

            return flushes;
        }

        private int misc()
        {
            int misc = 0;

            if (chkInspection.Checked == true)
            {
                misc += InspectionPRICE;
            }
            if (chkMuffler.Checked == true)
            {
                misc += ReplaceMufflerPRICE;
            }
            if(chkTireRotation.Checked == true)
            {
                misc += TireRotationPRICE;
            }

            return misc;
        }

        private double TaxCharges()
        {
            double totalTax = -1;
            totalTax = partsCost * Tax;
            
            return totalTax;
        }

        private double OtherCosts()
        {
            double PartsLabor = -1;
            PartsLabor = partsCost + laborCost;

            return PartsLabor;
        }

        private double TotalFees()
        {
            return oilAndLube() + flushes() + misc() + TaxCharges() + OtherCosts();
        }

        private double Services()
        {
            return oilAndLube() + flushes() + misc() + OtherCosts();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(isValidInput(ref partsCost, ref laborCost) == true)
            {
                lblServiceLaborOutput.Text = Services().ToString("c");

                lblPartsOutput.Text = partsCost.ToString("c");

                lblTaxOutput.Text = TaxCharges().ToString("c");

                lblTotalFeesOutput.Text = TotalFees().ToString("c");

                btnClear.Focus();
            }
        }
    }
}