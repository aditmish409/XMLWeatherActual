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
        //used for changing picture based on weather condition
        public Image forecastPic;
        public int forecastNum;

        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            ChangeLabel();

            //refresh so weather stays correct
            Refresh();
        }

        private void ChangeLabel()
        {
            //display date and proper weather for the next 3 days
            date1.Text = $"{Convert.ToDateTime(Form1.days[1].date).DayOfWeek}";
            min1.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[1].tempLow), 0))} C";
            max1.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[1].tempHigh), 0))} C";

            date2.Text = $"{Convert.ToDateTime(Form1.days[2].date).DayOfWeek}";
            min2.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[2].tempLow), 0))} C";
            max2.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[2].tempHigh), 0))}  C";

            date3.Text = $"{Convert.ToDateTime(Form1.days[3].date).DayOfWeek}";
            min3.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[3].tempLow), 0))}  C";
            max3.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[3].tempHigh), 0))}  C";

            //used for images for weather conditions
            int counter = 1;

            while (counter < 4)
            {
                Day.ImageGenerator(Form1.days[counter]);
                counter++;
            }
        }
        

        private void label3_Click(object sender, EventArgs e)
        {
            //change screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void ForecastScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw images
            int y = 40;
            int counter = 1;

            while (counter < 4)
            {
                //e.Graphics.DrawImage(Form1.days[counter].weatherPic, 50, y, 50, 50); //not working
                y += 90;
                counter++;
            }
        }

        private void searchLabel2_Click(object sender, EventArgs e)
        {
            //change screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen ss = new SearchScreen();
            f.Controls.Add(ss);
        }
    }
}
