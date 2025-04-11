using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;
using System.Drawing;

namespace XMLWeather
{
    public class Day
    {
        public string date, currentTemp, currentTime, condition, location, tempHigh, tempLow, 
            windSpeed, windDirection, /*symbolNumber, symbolName*/ precipitation, visibility, country;

        public int code;

        public Image weatherPic;

        public Day()
        {
            date = currentTemp = currentTime = condition = location = tempHigh = tempLow
                = windSpeed = windDirection = precipitation = visibility = "";

            code = 0;
        }

        public static void ImageGenerator(Day d)
        {
            if (d.code >= 200 && d.code < 300)
            {
                //d.weatherPic = Properties.Resources.thunderstorm;
            }
            else if (d.code >= 300 && d.code < 400)
            {
                //d.weatherPic = Properties.Resources.drizzle;
            }
            else if (d.code >= 500 && d.code < 600)
            {
                //d.weatherPic = Properties.Resources.rain;
            }
            else if (d.code >= 600 && d.code < 700)
            {
                //d.weatherPic = Properties.Resources.snow;
            }
            else if (d.code >= 700 && d.code < 800)
            {
                //d.weatherPic = Properties.Resources.mist;
            }
            else if (d.code == 800)
            {
                //d.weatherPic = Properties.Resources.clear;
            }
            else if (d.code >= 801)
            {
                //d.weatherPic = Properties.Resources.broken_clouds;
            }
        }
    }
}
