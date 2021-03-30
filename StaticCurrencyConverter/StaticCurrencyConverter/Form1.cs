using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticCurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(numInput.Text);
            if (convertFrom.SelectedItem == "JPY" && convertTo.SelectedItem == "USD")
            {
                Double conver = amount / 110;
                convertResult.Text = "Converted Amount : " + conver + "\t $";
            }
            if (convertFrom.SelectedItem == "JPY" && convertTo.SelectedItem == "IDR")
            {
                Double conver = amount * 138;
                convertResult.Text = "Converted Amount : " + conver + "\t Rupiah";
            }
            if (convertFrom.SelectedItem == "IDR" && convertTo.SelectedItem == "JPY")
            {
                Double conver = amount / 138;
                convertResult.Text = "Converted Amount : " + conver + "\t Yen";
            }
            if (convertFrom.SelectedItem == "IDR" && convertTo.SelectedItem == "USD")
            {
                Double conver = amount / 14440.05;
                convertResult.Text = "Converted Amount : " + conver + "\t $";
            }
            if (convertFrom.SelectedItem == "USD" && convertTo.SelectedItem == "IDR")
            {
                Double conver = amount * 14440.05;
                convertResult.Text = "Converted Amount : " + conver + "\t Rupiah";
            }
            if (convertFrom.SelectedItem == "USD" && convertTo.SelectedItem == "JPY")
            {
                Double conver = amount * 110;
                convertResult.Text = "Converted Amount : " + conver + "\t Yen";
            }
        }
    }
}
