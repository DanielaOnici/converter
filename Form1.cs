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
        
        //Method to calculate de temperatures
        private void CalculatingTemperature(out string txt, ref int formula)
        {
            //Setting up a regular expression to the input (accepting negative and decimal numbers)
            Regex numberRegex = new Regex(@"^-?[0-9][0-9,\.]+$");
            txt = txtBox.Text;

            if(txt == null || !(numberRegex.IsMatch(txt.Trim())))
            {
                lblResultMessage.Text = "Invalid number. Please insert a valid number";
            }
            else
            {
                switch (formula)
                {
                    case 1:
                        //Calculating C to F and rounding the number to two decimals
                        lblResultMessage.Text = $"{Math.Round(((double.Parse(txt) * 1.8) + 32), 2)} Fahrenheit";
                        break;
                    case 2:
                        //Calculating F to C and rounding the number to two decimals
                        lblResultMessage.Text = $"{Math.Round(((double.Parse(txt) - 32) * 0.556), 2)} Celsius";
                        break;
                }
            }
        }

        private void CalculatingMeasures(out string text, ref int formulaX)
        {
            //Setting up a regular expression to the input (accepting decimal numbers)
            Regex numberRegex = new Regex(@"^[0-9][0-9,\.]+$");
            text = txtBox.Text;

            if(txtBox.Text == null || !(numberRegex.IsMatch(text.Trim())) || txtBox.Text == "0")
            {
                lblResultMessage.Text = "Invalid number. Please insert a valid number";
            }
            else
            {
                switch(formulaX)
                {
                    case 1:
                        //Calculating ft to m and rounding the number to two decimal places
                        lblResultMessage.Text = $"{Math.Round(((double.Parse(txtBox.Text)) / 3.2808), 2)} meters";
                        break;
                    case 2:
                        //Calculating m to ft and rounding the number to two decimal places
                        lblResultMessage.Text = $"{Math.Round(((double.Parse(txtBox.Text)) * 3.2808), 2)} feet";
                        break;
                    case 3:
                        //Calculating inches to cm and rounding the number to two decimal places
                        lblResultMessage.Text = $"{Math.Round(((double.Parse(txtBox.Text)) * 2.54), 2)} centimeters";
                        break;
                    case 4:
                        //Calculating inches to cm and rounding the number to two decimal places
                        lblResultMessage.Text = $"{Math.Round(((double.Parse(txtBox.Text)) / 2.54), 2)} centimeters";
                        break;
                    case 5:
                        //Calculating pounds to kg and rounding the number to two decimal places
                        lblResultMessage.Text = $"{Math.Round(((double.Parse(txtBox.Text)) / 2.205), 2)} kilograms";
                        break;
                    case 6:
                        //Calculating kg to pounds and rounding the number to two decimal places
                        lblResultMessage.Text = $"{Math.Round(((double.Parse(txtBox.Text)) * 2.205), 2)} pounds";
                        break;
                }
            }
        }

        private void btnCelsiusFahrenheit_Click(object sender, EventArgs e)
        {
            string txt;
            int formula = 1;
            CalculatingTemperature(out txt, ref formula);
        }

        private void btnFahrenheitCelsius_Click(object sender, EventArgs e)
        {
            string txt;
            int formula = 2;
            CalculatingTemperature(out txt, ref formula);
        }

        private void btnFeetMeters_Click(object sender, EventArgs e)
        {
            string text;
            int formulaX = 1;
            CalculatingMeasures(out text, ref formulaX);
        }

        private void btnMeterFeet_Click(object sender, EventArgs e)
        {
            string text;
            int formulaX = 2;
            CalculatingMeasures(out text, ref formulaX);
        }

        private void btnInchesCentimeters_Click(object sender, EventArgs e)
        {
            string text;
            int formulaX = 3;
            CalculatingMeasures(out text, ref formulaX);
        }

        private void btnCentimeterInches_Click(object sender, EventArgs e)
        {
            string text;
            int formulaX = 4;
            CalculatingMeasures(out text, ref formulaX);
        }

        private void btnPoundsKilogram_Click(object sender, EventArgs e)
        {
            string text;
            int formulaX = 5;
            CalculatingMeasures(out text, ref formulaX);
        }

        private void btnKilogramPounds_Click(object sender, EventArgs e)
        {
            string text;
            int formulaX = 6;
            CalculatingMeasures(out text, ref formulaX);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Cleaning textbox and label and focusing to textbox
            txtBox.Text = null;
            lblResultMessage.Text = null;
            txtBox.Focus();
        }
    }
}
