using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfNov6th
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        //from line 25 to 46 is the Temp converter or 1
      
        }  private void lblTemperatureConverter_Click(object sender, EventArgs e)
        {

        }

        private void grpTempConverter_Enter(object sender, EventArgs e)
        {

        }

        private void rdoTempConverter1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rdoTempConverter2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnTemp_Click(object sender, EventArgs e) //Button
        {
            if (rdoTempConverter1.Checked)
            {
                double celsius = double.Parse(txtInput1.Text);
                double fahrenheit = (celsius * 9 / 5) + 32;
                rtbOutput.Text = fahrenheit.ToString() + "°F";
            }
            else if (rdoTempConverter2.Checked)
            {
                double fahrenheit = double.Parse(txtInput1.Text);
                double celsius = (fahrenheit -32) * 5 / 9;
                rtbOutput.Text = celsius.ToString() + "°C";
            }
        }
        //from line 48 to 61 is the Money converter or 2
        private void lblMoneyConvert_Click(object sender, EventArgs e)
        {

        }
        //Line 53 to 56 is the dropdown menu for the Money convertor 
        private void cmbMoneyConverter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMoney_Click(object sender, EventArgs e) //Button
        {

        }
        //from line 63 to 96 is the Distance converter or 3
        private void lblDistanceConverter_Click(object sender, EventArgs e)
        {

        }

        private void chkMileToKilo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkMeterToInch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDistance1_Click(object sender, EventArgs e) //Button
        {

        }

        private void chkKiloToMiles_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkInchToMeter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDistance2_Click(object sender, EventArgs e) //Button
        {

        }

        private void lblInput1_Click(object sender, EventArgs e)
        {

        }

        private void txtInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblInput2_Click(object sender, EventArgs e)
        {

        }

        private void txtInput2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbOutput_TextChanged(object sender, EventArgs e) //This is the output box where everthing that I code goes into
        {

        }
    }
}
