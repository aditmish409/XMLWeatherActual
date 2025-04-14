using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        //create list to hold day objects
        public static List<Day> days = new List<Day>();
        //used to display date
        public static int currentMonth = DateTime.Now.Month;
        public static int currentDayOfYear = DateTime.Now.DayOfYear;
        //used for location and weather
        public static int weatherValue;
        public static string location;

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public static void ExtractForecast()
        {
            //catch error if a real location isn't entered
            try
            {
                //default location set to Stratford
                if (SearchScreen.loco == null)
                {
                    location = "Stratford, CA";
                }
                //show the searched location 
                else
                {
                    location = SearchScreen.loco;
                }

                //use the xml file to find the forecast for the next 3 days
                XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/forecast/daily?q={location}&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");


                while (reader.Read())
                {
                    //TODO: create a day object

                    Day d = new Day();

                    //TODO: fill day object with required data

                    reader.ReadToFollowing("time");
                    d.date = reader.GetAttribute("day");

                    reader.ReadToFollowing("symbol");
                    d.symbolName = reader.GetAttribute("name");
                    d.number = Convert.ToInt16(reader.GetAttribute("number"));

                    reader.ReadToFollowing("temperature");
                    d.tempLow = reader.GetAttribute("min");
                    d.tempHigh = reader.GetAttribute("max");

                    //add day to list of days
                    days.Add(d);
                }

            }
            catch
            {
                //if a fake place is entered, display message
                SearchScreen.error = "Place doesn't exist";
            }
        }

        public static void ExtractCurrent()
        {
            try
            {
                //set default location as Stratford
                if (SearchScreen.loco == null)
                {
                    location = "Stratford, CA";
                }
                else
                {
                    location = SearchScreen.loco;
                }
                //use xml file to find info for Stratford
                XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/weather?q={location}&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

                //TODO: find the city and current temperature and add to appropriate item in days list
                days[0].location = location;

                reader.ReadToFollowing("temperature");
                days[0].currentTemp = reader.GetAttribute("value");

                reader.ReadToFollowing("weather");
                days[0].number = Convert.ToInt16(reader.GetAttribute("number"));
                days[0].symbolName = reader.GetAttribute("value");
            }
            catch
            {
                //if fake place is entered, display message
                SearchScreen.error = "This place doesn't exist";
            }
        }


    }
}
