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
    public partial class CurrentScreen : UserControl
    {
        //used for weather images
        public Image weatherPic;
        public int weatherNum;

        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {

            Day.ImageGenerator(Form1.days[0]);
            
            //display location, date, max temp, min temp, current temp and weather conditions
            currentCityOutput.Text = $"{Form1.location}";
            minOutput.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[0].tempLow), 0))}  C";
            maxOutput.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[0].tempHigh), 0))} C";
            currentTempOutput.Text = $"{Convert.ToString(decimal.Round(Convert.ToDecimal(Form1.days[0].currentTemp), 0))} C";
            symbolNameOutput.Text = Form1.days[0].symbolName;

            todayDateLabel.Text = $"{Convert.ToString(DateTime.Now.DayOfWeek)}, {Convert.ToDateTime(DateTime.Now.Date).ToString("MMMM M")}"; 

            //refresh to maintain correct info
            Refresh();
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            //change screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
        private void CurrentScreen_Paint(object sender, PaintEventArgs e)
        {
            //draw appropriate image based on weather conditions

            //e.Graphics.DrawImage(Form1.days[0].weatherPic, 80, 80, 100, 100); //not working
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            //change screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen ss = new SearchScreen();
            f.Controls.Add(ss);
        }
    }
}
