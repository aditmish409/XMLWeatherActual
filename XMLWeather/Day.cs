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
using System.Net;
using System.Xml;
using Microsoft.SqlServer.Server;

namespace XMLWeather
{
    public class Day
    {
        //strings used to display various features on app
        public string date, currentTemp, condition, location, tempHigh, tempLow, 
        symbolNumber, symbolName, country;

        //used for xml forecast codes
        public int number;

        //used for forecast images
        public static Image weatherPic;

        //assigned values at start of the program
        public Day()
        {
            date = currentTemp = condition = location = tempHigh = tempLow
                = symbolNumber = symbolName = country = "";

            number = 0;

            weatherPic = null;
        }

        //display image based on xml code for the weather forecast
        public static void ImageGenerator(Day d)
        {
            if (d.number >= 200 && d.number < 300)
            {
                weatherPic = Properties.Resources.thunderstorm; 
            }
            else if (d.number >= 300 && d.number < 400)
            {
                weatherPic = Properties.Resources.drizzle; 
            }
            else if (d.number >= 500 && d.number < 600)
            {
                weatherPic = Properties.Resources.rain; 
            }
            else if (d.number >= 600 && d.number < 700)
            {
                weatherPic = Properties.Resources.snow; 
            }
            else if (d.number >= 700 && d.number < 800)
            {
                weatherPic = Properties.Resources.mist; 
            }
            else if (d.number == 800)
            {
                weatherPic = Properties.Resources.clear; 
            }
            else if (d.number >= 801)
            {
                weatherPic = Properties.Resources.broken_clouds; 
            }
        }
    }
}
