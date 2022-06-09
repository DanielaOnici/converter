
namespace Converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnCelsiusFahrenheit = new System.Windows.Forms.Button();
            this.btnFahrenheitCelsius = new System.Windows.Forms.Button();
            this.btnFeetMeters = new System.Windows.Forms.Button();
            this.btnMeterFeet = new System.Windows.Forms.Button();
            this.btnKilogramPounds = new System.Windows.Forms.Button();
            this.btnPoundsKilogram = new System.Windows.Forms.Button();
            this.btnCentimeterInches = new System.Windows.Forms.Button();
            this.btnInchesCentimeters = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResultMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(73, 48);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(183, 27);
            this.txtBox.TabIndex = 0;
            // 
            // btnCelsiusFahrenheit
            // 
            this.btnCelsiusFahrenheit.Location = new System.Drawing.Point(73, 101);
            this.btnCelsiusFahrenheit.Name = "btnCelsiusFahrenheit";
            this.btnCelsiusFahrenheit.Size = new System.Drawing.Size(176, 33);
            this.btnCelsiusFahrenheit.TabIndex = 1;
            this.btnCelsiusFahrenheit.Text = "Celsius to Fahrenheit";
            this.btnCelsiusFahrenheit.UseVisualStyleBackColor = true;
            this.btnCelsiusFahrenheit.Click += new System.EventHandler(this.btnCelsiusFahrenheit_Click);
            // 
            // btnFahrenheitCelsius
            // 
            this.btnFahrenheitCelsius.Location = new System.Drawing.Point(73, 140);
            this.btnFahrenheitCelsius.Name = "btnFahrenheitCelsius";
            this.btnFahrenheitCelsius.Size = new System.Drawing.Size(176, 33);
            this.btnFahrenheitCelsius.TabIndex = 2;
            this.btnFahrenheitCelsius.Text = "Fahrenheit to Celsius";
            this.btnFahrenheitCelsius.UseVisualStyleBackColor = true;
            // 
            // btnFeetMeters
            // 
            this.btnFeetMeters.Location = new System.Drawing.Point(73, 179);
            this.btnFeetMeters.Name = "btnFeetMeters";
            this.btnFeetMeters.Size = new System.Drawing.Size(176, 33);
            this.btnFeetMeters.TabIndex = 3;
            this.btnFeetMeters.Text = "Feet to Meters";
            this.btnFeetMeters.UseVisualStyleBackColor = true;
            // 
            // btnMeterFeet
            // 
            this.btnMeterFeet.Location = new System.Drawing.Point(73, 218);
            this.btnMeterFeet.Name = "btnMeterFeet";
            this.btnMeterFeet.Size = new System.Drawing.Size(176, 33);
            this.btnMeterFeet.TabIndex = 4;
            this.btnMeterFeet.Text = "Meters to Feet";
            this.btnMeterFeet.UseVisualStyleBackColor = true;
            // 
            // btnKilogramPounds
            // 
            this.btnKilogramPounds.Location = new System.Drawing.Point(255, 218);
            this.btnKilogramPounds.Name = "btnKilogramPounds";
            this.btnKilogramPounds.Size = new System.Drawing.Size(176, 33);
            this.btnKilogramPounds.TabIndex = 8;
            this.btnKilogramPounds.Text = "Kilogram to Pounds";
            this.btnKilogramPounds.UseVisualStyleBackColor = true;
            // 
            // btnPoundsKilogram
            // 
            this.btnPoundsKilogram.Location = new System.Drawing.Point(255, 179);
            this.btnPoundsKilogram.Name = "btnPoundsKilogram";
            this.btnPoundsKilogram.Size = new System.Drawing.Size(176, 33);
            this.btnPoundsKilogram.TabIndex = 7;
            this.btnPoundsKilogram.Text = "Pounds to Kilogram";
            this.btnPoundsKilogram.UseVisualStyleBackColor = true;
            // 
            // btnCentimeterInches
            // 
            this.btnCentimeterInches.Location = new System.Drawing.Point(255, 140);
            this.btnCentimeterInches.Name = "btnCentimeterInches";
            this.btnCentimeterInches.Size = new System.Drawing.Size(176, 33);
            this.btnCentimeterInches.TabIndex = 6;
            this.btnCentimeterInches.Text = "Centimeters to Inches";
            this.btnCentimeterInches.UseVisualStyleBackColor = true;
            // 
            // btnInchesCentimeters
            // 
            this.btnInchesCentimeters.Location = new System.Drawing.Point(255, 101);
            this.btnInchesCentimeters.Name = "btnInchesCentimeters";
            this.btnInchesCentimeters.Size = new System.Drawing.Size(176, 33);
            this.btnInchesCentimeters.TabIndex = 5;
            this.btnInchesCentimeters.Text = "Inches to Centimeters";
            this.btnInchesCentimeters.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(277, 48);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(153, 26);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(80, 278);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(56, 20);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Result: ";
            // 
            // lblResultMessage
            // 
            this.lblResultMessage.AutoSize = true;
            this.lblResultMessage.Location = new System.Drawing.Point(142, 278);
            this.lblResultMessage.Name = "lblResultMessage";
            this.lblResultMessage.Size = new System.Drawing.Size(0, 20);
            this.lblResultMessage.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 340);
            this.Controls.Add(this.lblResultMessage);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnKilogramPounds);
            this.Controls.Add(this.btnPoundsKilogram);
            this.Controls.Add(this.btnCentimeterInches);
            this.Controls.Add(this.btnInchesCentimeters);
            this.Controls.Add(this.btnMeterFeet);
            this.Controls.Add(this.btnFeetMeters);
            this.Controls.Add(this.btnFahrenheitCelsius);
            this.Controls.Add(this.btnCelsiusFahrenheit);
            this.Controls.Add(this.txtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnCelsiusFahrenheit;
        private System.Windows.Forms.Button btnFahrenheitCelsius;
        private System.Windows.Forms.Button btnFeetMeters;
        private System.Windows.Forms.Button btnMeterFeet;
        private System.Windows.Forms.Button btnKilogramPounds;
        private System.Windows.Forms.Button btnPoundsKilogram;
        private System.Windows.Forms.Button btnCentimeterInches;
        private System.Windows.Forms.Button btnInchesCentimeters;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResultMessage;
    }
}

