/* Converter.sln
 * 
 * The program makes simple convertions of the number the user input.
 * F to C/ C to F
 * ft to m/m to ft
 * inch to cm/cm to inch
 * pounds to kg/kg to pounds
 * 
 * Daniela Onici 
 * Student ID# 8754297
 * 
 * 2022/06/09: created
 * 2022/06/09: Finished
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCelsiusFahrenheit_Click(object sender, EventArgs e)
        {
            Regex numberRegex = new Regex(@"^-?[0-9][0-9,\.]+$");

            if (numberRegex.IsMatch(txtBox.Text.Trim()))
            {
                double number = double.Parse(txtBox.Text);
                double result = (number * 1.8) + 32;
                lblResultMessage.Text = $"{Math.Round(result, 2)} Fahrenheit";
            }
            else
            {
                lblResultMessage.Text = "Invalid number. Please insert a valid number";
            }

        }

        private void btnFahrenheitCelsius_Click(object sender, EventArgs e)
        {
            Regex numberRegex = new Regex(@"^-?[0-9][0-9,\.]+$");

            if (numberRegex.IsMatch(txtBox.Text.Trim()))
            {
                double number = double.Parse(txtBox.Text);
                double result = (number - 32) * 0.5556;
                lblResultMessage.Text = $"{Math.Round(result, 2)} Celsius";
            }
            else
            {
                lblResultMessage.Text = "Invalid number. Please insert a valid number";
            }
        }

        private void btnFeetMeters_Click(object sender, EventArgs e)
        {
            Regex numberRegex = new Regex(@"^[0-9][0-9,\.]+$");

            if (numberRegex.IsMatch(txtBox.Text.Trim()) || !(txtBox.Text == "0"))
            {
                double number = double.Parse(txtBox.Text);
                double result = number / 3.2808;
                lblResultMessage.Text = $"{Math.Round(result, 2)} meters";
            }
            else
            {
                lblResultMessage.Text = "Invalid number. Please insert a valid number";
            }
        }

        private void btnMeterFeet_Click(object sender, EventArgs e)
        {
            Regex numberRegex = new Regex(@"^[0-9][0-9,\.]+$");

            if (numberRegex.IsMatch(txtBox.Text.Trim()) || !(txtBox.Text == "0"))
            {
                double number = double.Parse(txtBox.Text);
                double result = number * 3.2808;
                lblResultMessage.Text = $"{Math.Round(result, 2)} feet";
            }
            else
            {
                lblResultMessage.Text = "Invalid number. Please insert a valid number";
            }
        }

        private void btnInchesCentimeters_Click(object sender, EventArgs e)
        {
            Regex numberRegex = new Regex(@"^[0-9][0-9,\.]+$");

            if (numberRegex.IsMatch(txtBox.Text.Trim()) || !(txtBox.Text == "0"))
            {
                double number = double.Parse(txtBox.Text);
                double result = number * 2.54;
                lblResultMessage.Text = $"{Math.Round(result, 2)} centimeters";
            }
            else
            {
                lblResultMessage.Text = "Invalid number. Please insert a valid number";
            }
        }

        private void btnCentimeterInches_Click(object sender, EventArgs e)
        {
            Regex numberRegex = new Regex(@"^[0-9][0-9,\.]+$");

            if (numberRegex.IsMatch(txtBox.Text.Trim()) || !(txtBox.Text == "0"))
            {
                double number = double.Parse(txtBox.Text);
                double result = number / 2.54;
                lblResultMessage.Text = $"{Math.Round(result, 2)} inches";
            }
            else
            {
                lblResultMessage.Text = "Invalid number. Please insert a valid number";
            }
        }

        private void btnPoundsKilogram_Click(object sender, EventArgs e)
        {
            Regex numberRegex = new Regex(@"^[0-9][0-9,\.]+$");

            if (numberRegex.IsMatch(txtBox.Text.Trim()) || !(txtBox.Text == "0"))
            {
                double number = double.Parse(txtBox.Text);
                double result = number / 2.205;
                lblResultMessage.Text = $"{Math.Round(result, 2)} kilograms";
            }
            else
            {
                lblResultMessage.Text = "Invalid number. Please insert a valid number";
            }
        }

        private void btnKilogramPounds_Click(object sender, EventArgs e)
        {
            Regex numberRegex = new Regex(@"^[0-9][0-9,\.]+$");

            if (numberRegex.IsMatch(txtBox.Text.Trim()) || !(txtBox.Text == "0"))
            {
                double number = double.Parse(txtBox.Text);
                double result = number * 2.205;
                lblResultMessage.Text = $"{Math.Round(result, 2)} pounds";
            }
            else
            {
                lblResultMessage.Text = "Invalid number. Please insert a valid number";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox.Text = null;
            lblResultMessage.Text = null;
            txtBox.Focus();
        }
    }
}
