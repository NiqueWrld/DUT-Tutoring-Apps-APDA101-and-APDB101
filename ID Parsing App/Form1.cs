using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID_Parsing_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            /*
            First we have to ensure that the user enters a valid South African ID number by checking that it is exactly 13 
            digits long and consists entirely of numeric characters.If the validation fails,
            an error message is shown, and further execution is halted.
            */

            string idNumber = txtIDNumber.Text.Trim();
            if (idNumber.Length != 13 || !long.TryParse(idNumber, out _))
            {
                MessageBox.Show("Please enter a valid 13-digit South African ID number.");
                return;
            }

            //The full format of a South African Id Number is YYMMDDSSSSCAV.

            // YYMMDD - The first 6 digits are based on your date of birth.
            // SSSS - The next 4 digits are used to define you gender.
            // C - The next degit is used to classify citizenship.
            // A - The next digit was used until 1980s to classify race.
            // Z - The last digit is a checksum digit to verify the number.

            // Now let get the YY using substring .. In programming the first index of a variable is equals to 0.

            string yy = idNumber.Substring(0, 2);
            string mm = idNumber.Substring(2, 2);
            string dd = idNumber.Substring(4, 2);

            //Let get the date of birth from these variables above

            string day = dd , month = mm ,year;

            /* YY is the last 2 digits of your Year of birth
            We can assume that t If the YY is above 24 means the user was born on 19yy if below it 20yy. */

            if (int.Parse(yy) < 24)
            {
                year = "20" + yy;
            }
            else
            {
                year = "19" + yy;
            }

            lblDateOfBirth.Text = day + "/" + month + "/" + year;


            //Let get the age .... We take the current year minus the year of birth

            lblAge.Text = (2024 - int.Parse(year)).ToString();

            // We are done with the first 6 digits of the id number let move to the next 4 were we get the gender.

            string ssss = idNumber.Substring(6 , 4);

            // It safe to say if the ssss is below or equals to 4999 the gender is Female if false then male.

            string gender;

            if(int.Parse(ssss) <= 4999)
            {
                gender = "Female";
            }
            else
            {
                gender = "Male";
            }

            lblGender.Text = gender;


            //Now let us get the citenzinship.

            string c = idNumber.Substring(10 , 1);
            string citizenship;

            if (int.Parse(c) == 0)
            {
                citizenship = "SA Citizen";
            }
            else
            {
                citizenship = "Permanent Citizen";
            }

            lblCitizenship.Text = citizenship;

        }

        // We should not allow the user to input alphabets as the Id Number does not have alphabets.

        // We do that using the KeyPress method
        private void txtIDNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the entered character is a digit or a control key
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // If it's not, suppress the keypress event
                e.Handled = true;
            }
        }


        // You guys are the real heroes.

    }
}
