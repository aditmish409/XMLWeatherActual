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
        public int code;

        //used for forecast images
        public Image weatherPic;

        //assigned values at start of the program
        public Day()
        {
            date = currentTemp = condition = location = tempHigh = tempLow
                = symbolNumber = symbolName = country = "";

            code = 0;

            weatherPic = null;
        }

        //display image based on xml code for the weather forecast
        public static void ImageGenerator(Day d)
        {
            if (d.code >= 200 && d.code < 300)
            {
                //d.weatherPic = Properties.Resources.thunderstorm; //not working
            }
            else if (d.code >= 300 && d.code < 400)
            {
                //d.weatherPic = Properties.Resources.drizzle; //not working
            }
            else if (d.code >= 500 && d.code < 600)
            {
                //d.weatherPic = Properties.Resources.rain; //not working
            }
            else if (d.code >= 600 && d.code < 700)
            {
                //d.weatherPic = Properties.Resources.snow; //not working
            }
            else if (d.code >= 700 && d.code < 800)
            {
                //d.weatherPic = Properties.Resources.mist; //not working
            }
            else if (d.code == 800)
            {
                //d.weatherPic = Properties.Resources.clear; //not working
            }
            else if (d.code >= 801)
            {
                //d.weatherPic = Properties.Resources.broken_clouds; //not working
            }
        }
    }
}
