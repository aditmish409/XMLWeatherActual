using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public Image forecastPic;
        public int forecastNum;

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

            date3.Text = Form1.days[3].date;
            min3.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[3].tempLow), 0))}";
            max3.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[3].tempHigh), 0))}";

            int counter = 1;

            while (counter < 5)
            {
                //Day.ImageGenerator(Form1.days[counter]);
                //    counter++;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void ForecastScreen_Paint(object sender, PaintEventArgs e)
        {
            int y = 40;
            int counter = 1;

            while (counter < 5)
            {
                e.Graphics.DrawImage(Form1.days[counter].weatherPic, 50, y, 50, 50);
                y += 90;
                counter++;
            }
        }
    }
}
