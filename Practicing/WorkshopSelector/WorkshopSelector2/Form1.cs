using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkshopSelector2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double dblRegisPrice = -1;
            double dblLodgPrice = -1;
            double dblDays = -1;
            double dblTotal = -1;

            if (listBoxWorkshop.SelectedIndex >= 0)
            {
                switch (listBoxWorkshop.Text)
                {
                    case "Handling Stress":
                        dblRegisPrice = 100;
                        lblRegis.Text = dblRegisPrice.ToString("C");
                        dblDays = 4;
                        lblDays.Text = dblDays.ToString();
                        break;
                    case "Time Management":
                        dblRegisPrice = 200;
                        lblRegis.Text = dblRegisPrice.ToString("C");
                        dblDays = 7;
                        lblDays.Text = dblDays.ToString();
                        break;
                    case "Supervision Skills":
                        dblRegisPrice = 150;
                        lblRegis.Text = dblRegisPrice.ToString("C");
                        dblDays = 2;
                        lblDays.Text = dblDays.ToString();
                        break;
                    case "Negotiation":
                        dblRegisPrice = 300;
                        lblRegis.Text = dblRegisPrice.ToString("C");
                        dblDays = 3;
                        lblDays.Text = dblDays.ToString();
                        break;
                    case "How to Interview":
                        dblRegisPrice = 450;
                        lblRegis.Text = dblRegisPrice.ToString("C");
                        dblDays = 5;
                        lblDays.Text = dblDays.ToString();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Select one Workshop");
            }

            if (listBoxLocation.SelectedIndex >= 0) 
            {
                switch (listBoxLocation.Text) 
                {
                    case "Moncton":
                        dblLodgPrice = 250;
                        lblLodg.Text = dblLodgPrice.ToString("C");
                        break;
                    case "Saint John":
                        dblLodgPrice = 150;
                        lblLodg.Text = dblLodgPrice.ToString("C");
                        break;
                    case "Chicago":
                        dblLodgPrice = 350;
                        lblLodg.Text = dblLodgPrice.ToString("C");
                        break;
                    case "Orlando":
                        dblLodgPrice = 400;
                        lblLodg.Text = dblLodgPrice.ToString("C");
                        break;
                    case "New York":
                        dblLodgPrice = 650;
                        lblLodg.Text = dblLodgPrice.ToString("C");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Select one Location");
            }

            dblTotal = dblLodgPrice * dblDays + dblRegisPrice;
            lblTotal.Text = dblTotal.ToString("C");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDays.Text = "";
            lblLodg.Text = "";
            lblRegis.Text = "";
            lblTotal.Text = "";
            listBoxLocation.SelectedItems.Clear();
            listBoxWorkshop.SelectedItems.Clear();
        }
    }
}
