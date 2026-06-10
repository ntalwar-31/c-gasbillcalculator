using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace GasBillCalc
{
    public partial class Form1 : Form
    {
        private object txtGasPerGallon;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var culture = CultureInfo.CurrentCulture;
            decimal distance;
            decimal price;

            if (!decimal.TryParse(txtTotalDistance.Text?.Trim(),
                                  NumberStyles.Number,
                                  culture,
                                  out distance))
            {
                MessageBox.Show("Please enter a valid distance (numeric).");
                txtTotalDistance.Focus();
                return;
            }

            // Allow currency symbol and number formats for gas price
            if (!decimal.TryParse(txtGasPrice.Text?.Trim(),
                                  NumberStyles.Number | NumberStyles.AllowCurrencySymbol,
                                  culture,
                                  out price))
            {
                MessageBox.Show("Please enter a valid gas price (e.g. 2.99 or $2.99).");
                txtGasPrice.Focus();
                return;
            }

            string city = txtCity.Text ?? string.Empty;
            string state = (txtState.Text ?? string.Empty).ToLowerInvariant();

            decimal gasTax = state == "michigan" ? 0.26m
                              : state == "ohio"     ? 0.28m
                                                   : 0.48m;

            decimal total = (distance / 23.6m) * (price + gasTax);

            total = chkRound.Checked ? Math.Round(total, 0) : Math.Round(total, 2);

            lblResult.Text = $"The price of a gallon of gas in {city}, {txtState.Text} is {price:C} " +
                             $"(including {gasTax:C} gas tax per gallon). It costs {total:C} to drive {distance} miles.";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          
        }
    }
}
