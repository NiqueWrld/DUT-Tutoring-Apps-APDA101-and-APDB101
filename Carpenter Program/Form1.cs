using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpenter_Program
{
    public partial class frmCarpenterProgram : Form
    {
        public frmCarpenterProgram()
        {
            InitializeComponent();
        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            // The minimum charge for all desks is R1200.Declare this as a constant.

            double quotePrice = 1200;

            // Calculate the surface (length * width). If the surface is over 700000 square millimeters, add R300.

            double length, width, surface , surfaceCharges = 0;

            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);
            surface = length * width;

            if(surface > 700000)
            {
                surfaceCharges = 300;
            }

            // For every drawer in the desk, there is an additional charge of R180.

            int numDrawers = int.Parse(txtNumDrawers.Text);
            double drawerCharges = numDrawers * 180;

            /* If the type of wood is “Cherry” or “Mahogany”, add R900; for “Oak”, add R750.No charge is added for “Pine”.
             Use a Nested..If statement to calculate this charge. */

            double additionalCharge = 0.0;

            if (radCherry.Checked)
            {
                additionalCharge = 900.0;
            }
            else if (radMohagany.Checked)
            {
                additionalCharge = 900.0;
            }
            else if (radOak.Checked)
            {
                additionalCharge = 750.0;
            }
            else if (radPine.Checked)
            {
                additionalCharge = 0.0;
            }

            // Calculate the price.

            quotePrice += surfaceCharges + drawerCharges + additionalCharge;

            // Display the price with the Rand symbol and two decimal places.
            lblQuote.Text = quotePrice.ToString("C");

        }
    }
}
