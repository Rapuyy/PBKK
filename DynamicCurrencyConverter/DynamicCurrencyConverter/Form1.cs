using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DynamicCurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Double getRate(string rateFrom, string rateTo)
        {
            var json = "";
            Double rate;
            try
            {
                string url = string.Format("https://free.currconv.com/api/v7/convert?q={0}_{1}&compact=ultra&apiKey=bceb3e313f7d7b12e0f8", rateFrom, rateTo);
                string key = string.Format("{0}_{1}", rateFrom, rateTo);

                json = new WebClient().DownloadString(url);
                dynamic stuff = JsonConvert.DeserializeObject(json);
                rate = Convert.ToDouble(stuff[key]);
            }
            catch
            {
                rate = 0;
            }

            return rate;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            Double rate = getRate(convertFrom.Text, convertTo.Text);
            Double output = Double.Parse(numInput.Text) * rate;
            convertResult.Text = "Converted Amount: " + output.ToString();
        }
    }
}
