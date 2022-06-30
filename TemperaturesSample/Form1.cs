using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperaturesSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SampleData();
        }

        private void SampleData()
        {
            double sampleVal = -40;
            while (sampleVal < 50)
            {
                string sampleText = string.Format("{0} Celsius equates to {1} Fahrenheit{2}", sampleVal, TemperatureConversions.ToFahrenheit(sampleVal), Environment.NewLine);
                txtSamples.Text += sampleText;
                sampleVal = sampleVal + 10;
            }
        }

        private void btnFtoC_Click(object sender, EventArgs e)
        {
            double d;
            if (Double.TryParse(txtFahrenheit.Text, out d))
            {
                txtCelsius.Text = TemperatureConversions.ToCelsius(d).ToString();
            }
        }

        private void btnCtoF_Click(object sender, EventArgs e)
        {
            double d;
            if (Double.TryParse(txtCelsius.Text, out d))
            {
                txtFahrenheit.Text = TemperatureConversions.ToFahrenheit(d).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SampleClass sc = new SampleClass();
            sc.StartRange = 1;
            sc.EndRange = 20;
            sc.GetResult();
            txtSamples.Text = sc.Result;
            txtSamples.Text += Environment.NewLine + sc.countDragonFly;
            txtSamples.Text += Environment.NewLine + sc.countAI;
            txtSamples.Text += Environment.NewLine + sc.countDragonFlyAI;
            txtSamples.Text += Environment.NewLine + sc.countInteger;
        }
    }
}
