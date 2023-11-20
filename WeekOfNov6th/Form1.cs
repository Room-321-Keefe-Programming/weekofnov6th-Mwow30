using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WeekOfNov6th
{
    public partial class Form1 : Form //DO NOT TOUCH from line 1 to 23!!!!
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMoneyConverter.Items.Add("Dollar - Yen");   //Stuff for Money the stuff that goes into the dropdown menu thing
            cmbMoneyConverter.Items.Add("Yen - Dollar");
            cmbMoneyConverter.Items.Add("Dollar - Euro");
            cmbMoneyConverter.Items.Add("Euro - Dollar");
            cmbMoneyConverter.Items.Add("Dollar - Rupee");
            cmbMoneyConverter.Items.Add("Rupee - Dollar");
            cmbMoneyConverter.Items.Add("Dollar - Real");
            cmbMoneyConverter.Items.Add("Real - Dollar");
        }



        private void btnTemp_Click(object sender, EventArgs e)  // Temp Button
        {
            double inputValue1, inputValue2;

            if (double.TryParse(txtInput1.Text, out inputValue1) || double.TryParse(txtInput2.Text, out inputValue2))
            {
                if (!string.IsNullOrEmpty(txtInput1.Text))
                {
                    double convertedValue1;

                    if (rdoTempConverter1.Checked)
                    {
                        convertedValue1 = (inputValue1 * 9 / 5) + 32;
                        rtbOutput.Text += $"Input 1: Celsius to Fahrenheit is {convertedValue1}\n";
                    }
                    else if (rdoTempConverter2.Checked)
                    {
                        convertedValue1 = (inputValue1 - 32) * 5 / 9;
                        rtbOutput.Text += $"Input 1: Fahrenheit to Celsius is {convertedValue1}\n";
                    }
                }

                if (!string.IsNullOrEmpty(txtInput2.Text))
                {
                    double convertedValue2 = 0;

                    if (rdoTempConverter1.Checked)
                    {
                        convertedValue2 = (inputValue1 * 9 / 5) + 32;
                        rtbOutput.Text += $"Input 2: Celsius to Fahrenheit is {convertedValue2}\n";
                    }
                    else if (rdoTempConverter2.Checked)
                    {
                        convertedValue2 = (inputValue1 - 32) * 5 / 9;
                        rtbOutput.Text += $"Input 2: Fahrenheit to Celsius is {convertedValue2}\n";
                    }
                }
            }
            else
            {
                rtbOutput.Text += "Please input a convertible number!\n\n";
            }
        }
        private void btnMoney_Click(object sender, EventArgs e) //Money Button
        {
            double input1, input2;
            bool isInput1Valid = double.TryParse(txtInput1.Text, out input1);
            bool isInput2Valid = double.TryParse(txtInput2.Text, out input2);

            if (isInput1Valid && isInput2Valid)
            {
                string conversionType = cmbMoneyConverter.Text;

                switch (conversionType)
                {
                    case "Dollar - Yen":
                        rtbOutput.Text += $"Input 1: {input1} dollars is {input1 * 149.77} in yen\n";
                        rtbOutput.Text += $"Input 2: {input2} dollars is {input2 * 149.77} in yen\n";
                        break;
                    case "Yen - Dollar":
                        rtbOutput.Text += $"Input 1: {input1} yen is {input1 * 0.0067} in dollars\n";
                        rtbOutput.Text += $"Input 2: {input2} yen is {input2 * 0.0067} in dollars\n";
                        break;
                    case "Dollar - Euro":
                        rtbOutput.Text += $"Input 1: {input1} dollars is {input1 * 0.85} in euro\n";
                        rtbOutput.Text += $"Input 2: {input2} dollars is {input2 * 0.85} in euro\n";
                        break;
                    case "Euro - Dollar":
                        rtbOutput.Text += $"Input 1: {input1} euro is {input1 * 1.18} in dollars\n";
                        rtbOutput.Text += $"Input 2: {input2} euro is {input2 * 1.18} in dollars\n";
                        break;
                    case "Dollar - Rupee":
                        rtbOutput.Text += $"Input 1: {input1} dollars is {input1 * 74.95} in rupees\n";
                        rtbOutput.Text += $"Input 2: {input2} dollars is {input2 * 74.95} in rupees\n";
                        break;
                    case "Rupee - Dollar":
                        rtbOutput.Text += $"Input 1: {input1} rupees is {input1 * 0.013} in dollars\n";
                        rtbOutput.Text += $"Input 2: {input2} rupees is {input2 * 0.013} in dollars\n";
                        break;
                    case "Dollar - Real":
                        rtbOutput.Text += $"Input 1: {input1} dollars is {input1 * 5.24} in reals\n";
                        rtbOutput.Text += $"Input 2: {input2} dollars is {input2 * 5.24} in reals\n";
                        break;
                    case "Real - Dollar":
                        rtbOutput.Text += $"Input 1: {input1} reals is {input1 * 0.19} in dollars\n";
                        rtbOutput.Text += $"Input 2: {input2} reals is {input2 * 0.19} in dollars\n";
                        break;
                    default:
                        rtbOutput.Text += "Invalid conversion type!\n";
                        break;
                }
            }
            else
            {
                rtbOutput.Text += "Please input valid numbers for both inputs!\n";
            }
        }

        private void btnDistance1_Click(object sender, EventArgs e) //Distance Button 1
        {
            double inputValue1, inputValue2;

            if (double.TryParse(txtInput1.Text, out inputValue1) || double.TryParse(txtInput2.Text, out inputValue2))
            {
                if (!string.IsNullOrEmpty(txtInput1.Text))
                {
                    double convertedValue1 = 0;

                    if (chkMileToKilo.Checked)
                    {
                        convertedValue1 = inputValue1 * 1.60934;
                        rtbOutput.Text += $"Input 1: Converting {txtInput1.Text} from Miles to Kilometers is {convertedValue1}\n";
                    }
                    
                }

                if (!string.IsNullOrEmpty(txtInput2.Text))
                {
                    double convertedValue2 = 0;

                    if (chkMileToKilo.Checked)
                    {
                        convertedValue2 = inputValue1 * 1.60934;
                        rtbOutput.Text += $"Input 2: Converting {txtInput2.Text} from Miles to Kilometers is {convertedValue2}\n";
                    }
                    
                }
            }
            else
            {
                rtbOutput.Text += "Please input a convertible number!\n";
            }
        }



        private void btnDistance2_Click(object sender, EventArgs e) //Distance Button 2
        {
            double inputValue1, inputValue2;

            if (double.TryParse(txtInput1.Text, out inputValue1) || double.TryParse(txtInput2.Text, out inputValue2))
            {
                if (!string.IsNullOrEmpty(txtInput1.Text))
                {
                    double convertedValue1 = 0;

                    if (chkKiloToMiles.Checked)
                    {
                        convertedValue1 = inputValue1 * 0.621371;
                        rtbOutput.Text += $"Input 1: Converting {txtInput1.Text} from Kilometers to Miles is {convertedValue1}\n";
                    }
                    
                }

                if (!string.IsNullOrEmpty(txtInput2.Text)) //txtInput2/1 = Input 1 + Input 2 text box
                {
                    double convertedValue2 = 0;

                    if (chkKiloToMiles.Checked)
                    {
                        convertedValue2 = inputValue1 * 0.621371;
                        rtbOutput.Text += $"Input 2: Converting {txtInput2.Text} from Kilometers to Miles is {convertedValue2}\n";
                    }
                   
                }
            }
            else
            { //rtbOutput = Rich Text box where everything goes into
                rtbOutput.Text += "Please put a input above \n";
            }
        }

      
        private void LoadFilebtn_Click_1(object sender, EventArgs e)
        {
            string filePathTest = @"./test.txt";
            using (StreamReader reader = new StreamReader(filePathTest))
            {
                rtbOutput.Text = reader.ReadToEnd();
            }
        }
        private void CountWordbtn_Click_1(object sender, EventArgs e)
        {
            string filePath = @"./test.txt";
            int n = int.Parse(txtInput1.Text);
            string fileContent = "";
            using (StreamReader reader = new StreamReader(filePath))
            {
                fileContent = reader.ReadToEnd();
            }
            string[] words = fileContent.Split(' ');
            for (int i = n - 1; i < words.Length; i += n)
            {
                rtbOutput.Text += (words[i] + "\n");
            }
        }
    }
}
