namespace WeekOfNov6th
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTemperatureConverter = new System.Windows.Forms.Label();
            this.lblMoneyConvert = new System.Windows.Forms.Label();
            this.rdoTempConverter1 = new System.Windows.Forms.RadioButton();
            this.rdoTempConverter2 = new System.Windows.Forms.RadioButton();
            this.grpTempConverter = new System.Windows.Forms.GroupBox();
            this.cmbMoneyConverter = new System.Windows.Forms.ComboBox();
            this.btnTemp = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnMoney = new System.Windows.Forms.Button();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.lblInput2 = new System.Windows.Forms.Label();
            this.lblDistanceConverter = new System.Windows.Forms.Label();
            this.chkMeterToInch = new System.Windows.Forms.CheckBox();
            this.chkMileToKilo = new System.Windows.Forms.CheckBox();
            this.btnDistance1 = new System.Windows.Forms.Button();
            this.chkInchToMeter = new System.Windows.Forms.CheckBox();
            this.chkKiloToMiles = new System.Windows.Forms.CheckBox();
            this.btnDistance2 = new System.Windows.Forms.Button();
            this.grpTempConverter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTemperatureConverter
            // 
            this.lblTemperatureConverter.AutoSize = true;
            this.lblTemperatureConverter.BackColor = System.Drawing.Color.MediumPurple;
            this.lblTemperatureConverter.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatureConverter.Location = new System.Drawing.Point(65, 50);
            this.lblTemperatureConverter.Name = "lblTemperatureConverter";
            this.lblTemperatureConverter.Size = new System.Drawing.Size(252, 30);
            this.lblTemperatureConverter.TabIndex = 0;
            this.lblTemperatureConverter.Text = "Temperature Converter";
            this.lblTemperatureConverter.Click += new System.EventHandler(this.lblTemperatureConverter_Click);
            // 
            // lblMoneyConvert
            // 
            this.lblMoneyConvert.AutoSize = true;
            this.lblMoneyConvert.BackColor = System.Drawing.Color.MediumPurple;
            this.lblMoneyConvert.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyConvert.Location = new System.Drawing.Point(87, 160);
            this.lblMoneyConvert.Name = "lblMoneyConvert";
            this.lblMoneyConvert.Size = new System.Drawing.Size(186, 30);
            this.lblMoneyConvert.TabIndex = 1;
            this.lblMoneyConvert.Text = "Money Converter";
            this.lblMoneyConvert.Click += new System.EventHandler(this.lblMoneyConvert_Click);
            // 
            // rdoTempConverter1
            // 
            this.rdoTempConverter1.AutoSize = true;
            this.rdoTempConverter1.Location = new System.Drawing.Point(6, 35);
            this.rdoTempConverter1.Name = "rdoTempConverter1";
            this.rdoTempConverter1.Size = new System.Drawing.Size(219, 31);
            this.rdoTempConverter1.TabIndex = 2;
            this.rdoTempConverter1.TabStop = true;
            this.rdoTempConverter1.Text = "Celsuis - Fahrenheit";
            this.rdoTempConverter1.UseVisualStyleBackColor = true;
            this.rdoTempConverter1.CheckedChanged += new System.EventHandler(this.rdoTempConverter1_CheckedChanged);
            // 
            // rdoTempConverter2
            // 
            this.rdoTempConverter2.AutoSize = true;
            this.rdoTempConverter2.Location = new System.Drawing.Point(234, 33);
            this.rdoTempConverter2.Name = "rdoTempConverter2";
            this.rdoTempConverter2.Size = new System.Drawing.Size(219, 31);
            this.rdoTempConverter2.TabIndex = 3;
            this.rdoTempConverter2.TabStop = true;
            this.rdoTempConverter2.Text = "Fahrenheit - Celsius";
            this.rdoTempConverter2.UseVisualStyleBackColor = true;
            this.rdoTempConverter2.CheckedChanged += new System.EventHandler(this.rdoTempConverter2_CheckedChanged);
            // 
            // grpTempConverter
            // 
            this.grpTempConverter.BackColor = System.Drawing.Color.MediumPurple;
            this.grpTempConverter.Controls.Add(this.rdoTempConverter1);
            this.grpTempConverter.Controls.Add(this.rdoTempConverter2);
            this.grpTempConverter.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTempConverter.Location = new System.Drawing.Point(353, 35);
            this.grpTempConverter.Name = "grpTempConverter";
            this.grpTempConverter.Size = new System.Drawing.Size(459, 68);
            this.grpTempConverter.TabIndex = 4;
            this.grpTempConverter.TabStop = false;
            this.grpTempConverter.Tag = "";
            this.grpTempConverter.Text = "Convert";
            this.grpTempConverter.Enter += new System.EventHandler(this.grpTempConverter_Enter);
            // 
            // cmbMoneyConverter
            // 
            this.cmbMoneyConverter.BackColor = System.Drawing.Color.MediumPurple;
            this.cmbMoneyConverter.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoneyConverter.FormattingEnabled = true;
            this.cmbMoneyConverter.Location = new System.Drawing.Point(348, 160);
            this.cmbMoneyConverter.Name = "cmbMoneyConverter";
            this.cmbMoneyConverter.Size = new System.Drawing.Size(230, 35);
            this.cmbMoneyConverter.TabIndex = 5;
            this.cmbMoneyConverter.SelectedIndexChanged += new System.EventHandler(this.cmbMoneyConverter_SelectedIndexChanged);
            // 
            // btnTemp
            // 
            this.btnTemp.BackColor = System.Drawing.Color.MediumPurple;
            this.btnTemp.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemp.Location = new System.Drawing.Point(839, 50);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(188, 41);
            this.btnTemp.TabIndex = 6;
            this.btnTemp.Text = " Temp Button";
            this.btnTemp.UseVisualStyleBackColor = false;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.MediumPurple;
            this.rtbOutput.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.Location = new System.Drawing.Point(12, 507);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(1058, 202);
            this.rtbOutput.TabIndex = 7;
            this.rtbOutput.Text = "";
            this.rtbOutput.TextChanged += new System.EventHandler(this.rtbOutput_TextChanged);
            // 
            // btnMoney
            // 
            this.btnMoney.BackColor = System.Drawing.Color.MediumPurple;
            this.btnMoney.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMoney.Location = new System.Drawing.Point(589, 159);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(148, 35);
            this.btnMoney.TabIndex = 8;
            this.btnMoney.Text = "Money Button";
            this.btnMoney.UseVisualStyleBackColor = false;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // txtInput2
            // 
            this.txtInput2.BackColor = System.Drawing.Color.MediumPurple;
            this.txtInput2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput2.Location = new System.Drawing.Point(48, 442);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(169, 37);
            this.txtInput2.TabIndex = 9;
            this.txtInput2.TextChanged += new System.EventHandler(this.txtInput2_TextChanged);
            // 
            // txtInput1
            // 
            this.txtInput1.BackColor = System.Drawing.Color.MediumPurple;
            this.txtInput1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput1.Location = new System.Drawing.Point(313, 442);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(173, 37);
            this.txtInput1.TabIndex = 10;
            this.txtInput1.TextChanged += new System.EventHandler(this.txtInput1_TextChanged);
            // 
            // lblInput1
            // 
            this.lblInput1.AutoSize = true;
            this.lblInput1.BackColor = System.Drawing.Color.MediumPurple;
            this.lblInput1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput1.Location = new System.Drawing.Point(43, 398);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.Size = new System.Drawing.Size(73, 27);
            this.lblInput1.TabIndex = 11;
            this.lblInput1.Text = "Input1";
            this.lblInput1.Click += new System.EventHandler(this.lblInput1_Click);
            // 
            // lblInput2
            // 
            this.lblInput2.AutoSize = true;
            this.lblInput2.BackColor = System.Drawing.Color.MediumPurple;
            this.lblInput2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput2.Location = new System.Drawing.Point(308, 398);
            this.lblInput2.Name = "lblInput2";
            this.lblInput2.Size = new System.Drawing.Size(73, 27);
            this.lblInput2.TabIndex = 12;
            this.lblInput2.Text = "Input2";
            this.lblInput2.Click += new System.EventHandler(this.lblInput2_Click);
            // 
            // lblDistanceConverter
            // 
            this.lblDistanceConverter.AutoSize = true;
            this.lblDistanceConverter.BackColor = System.Drawing.Color.MediumPurple;
            this.lblDistanceConverter.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblDistanceConverter.Location = new System.Drawing.Point(87, 262);
            this.lblDistanceConverter.Name = "lblDistanceConverter";
            this.lblDistanceConverter.Size = new System.Drawing.Size(208, 30);
            this.lblDistanceConverter.TabIndex = 13;
            this.lblDistanceConverter.Tag = "";
            this.lblDistanceConverter.Text = "Distance Converter";
            this.lblDistanceConverter.Click += new System.EventHandler(this.lblDistanceConverter_Click);
            // 
            // chkMeterToInch
            // 
            this.chkMeterToInch.AutoSize = true;
            this.chkMeterToInch.BackColor = System.Drawing.Color.MediumPurple;
            this.chkMeterToInch.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.chkMeterToInch.Location = new System.Drawing.Point(601, 261);
            this.chkMeterToInch.Name = "chkMeterToInch";
            this.chkMeterToInch.Size = new System.Drawing.Size(211, 34);
            this.chkMeterToInch.TabIndex = 14;
            this.chkMeterToInch.Text = "Meters to Inches";
            this.chkMeterToInch.UseVisualStyleBackColor = false;
            this.chkMeterToInch.CheckedChanged += new System.EventHandler(this.chkMeterToInch_CheckedChanged);
            // 
            // chkMileToKilo
            // 
            this.chkMileToKilo.AutoSize = true;
            this.chkMileToKilo.BackColor = System.Drawing.Color.MediumPurple;
            this.chkMileToKilo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.chkMileToKilo.Location = new System.Drawing.Point(348, 261);
            this.chkMileToKilo.Name = "chkMileToKilo";
            this.chkMileToKilo.Size = new System.Drawing.Size(230, 34);
            this.chkMileToKilo.TabIndex = 15;
            this.chkMileToKilo.Tag = "";
            this.chkMileToKilo.Text = "Miles to Kilometers";
            this.chkMileToKilo.UseVisualStyleBackColor = false;
            this.chkMileToKilo.CheckedChanged += new System.EventHandler(this.chkMileToKilo_CheckedChanged);
            // 
            // btnDistance1
            // 
            this.btnDistance1.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDistance1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDistance1.Location = new System.Drawing.Point(839, 258);
            this.btnDistance1.Name = "btnDistance1";
            this.btnDistance1.Size = new System.Drawing.Size(188, 39);
            this.btnDistance1.TabIndex = 16;
            this.btnDistance1.Text = "Distance Button 1";
            this.btnDistance1.UseVisualStyleBackColor = false;
            this.btnDistance1.Click += new System.EventHandler(this.btnDistance1_Click);
            // 
            // chkInchToMeter
            // 
            this.chkInchToMeter.AutoSize = true;
            this.chkInchToMeter.BackColor = System.Drawing.Color.MediumPurple;
            this.chkInchToMeter.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.chkInchToMeter.Location = new System.Drawing.Point(601, 340);
            this.chkInchToMeter.Name = "chkInchToMeter";
            this.chkInchToMeter.Size = new System.Drawing.Size(211, 34);
            this.chkInchToMeter.TabIndex = 17;
            this.chkInchToMeter.Text = "Inches to Meters";
            this.chkInchToMeter.UseVisualStyleBackColor = false;
            this.chkInchToMeter.CheckedChanged += new System.EventHandler(this.chkInchToMeter_CheckedChanged);
            // 
            // chkKiloToMiles
            // 
            this.chkKiloToMiles.AutoSize = true;
            this.chkKiloToMiles.BackColor = System.Drawing.Color.MediumPurple;
            this.chkKiloToMiles.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold);
            this.chkKiloToMiles.Location = new System.Drawing.Point(348, 340);
            this.chkKiloToMiles.Name = "chkKiloToMiles";
            this.chkKiloToMiles.Size = new System.Drawing.Size(230, 34);
            this.chkKiloToMiles.TabIndex = 18;
            this.chkKiloToMiles.Text = "Kilometers to Miles";
            this.chkKiloToMiles.UseVisualStyleBackColor = false;
            this.chkKiloToMiles.CheckedChanged += new System.EventHandler(this.chkKiloToMiles_CheckedChanged);
            // 
            // btnDistance2
            // 
            this.btnDistance2.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDistance2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDistance2.Location = new System.Drawing.Point(839, 340);
            this.btnDistance2.Name = "btnDistance2";
            this.btnDistance2.Size = new System.Drawing.Size(188, 39);
            this.btnDistance2.TabIndex = 19;
            this.btnDistance2.Text = "Distance Button 2";
            this.btnDistance2.UseVisualStyleBackColor = false;
            this.btnDistance2.Click += new System.EventHandler(this.btnDistance2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 756);
            this.Controls.Add(this.btnDistance2);
            this.Controls.Add(this.chkKiloToMiles);
            this.Controls.Add(this.chkInchToMeter);
            this.Controls.Add(this.btnDistance1);
            this.Controls.Add(this.chkMileToKilo);
            this.Controls.Add(this.chkMeterToInch);
            this.Controls.Add(this.lblDistanceConverter);
            this.Controls.Add(this.lblInput2);
            this.Controls.Add(this.lblInput1);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.btnMoney);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.cmbMoneyConverter);
            this.Controls.Add(this.grpTempConverter);
            this.Controls.Add(this.lblMoneyConvert);
            this.Controls.Add(this.lblTemperatureConverter);
            this.Name = "Form1";
            this.Text = "Week of November 6th";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpTempConverter.ResumeLayout(false);
            this.grpTempConverter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperatureConverter;
        private System.Windows.Forms.Label lblMoneyConvert;
        private System.Windows.Forms.RadioButton rdoTempConverter1;
        private System.Windows.Forms.RadioButton rdoTempConverter2;
        private System.Windows.Forms.GroupBox grpTempConverter;
        private System.Windows.Forms.ComboBox cmbMoneyConverter;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.Label lblInput1;
        private System.Windows.Forms.Label lblInput2;
        private System.Windows.Forms.Label lblDistanceConverter;
        private System.Windows.Forms.CheckBox chkMeterToInch;
        private System.Windows.Forms.CheckBox chkMileToKilo;
        private System.Windows.Forms.Button btnDistance1;
        private System.Windows.Forms.CheckBox chkInchToMeter;
        private System.Windows.Forms.CheckBox chkKiloToMiles;
        private System.Windows.Forms.Button btnDistance2;
    }
}

