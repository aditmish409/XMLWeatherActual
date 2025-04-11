using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;
            min1.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[1].tempLow), 0))}";
            max1.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[1].tempHigh), 0))}";

            date2.Text = Form1.days[2].date;
            min2.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[2].tempLow), 0))}";
            max2.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[2].tempHigh), 0))}";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
