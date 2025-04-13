using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class SearchScreen : UserControl
    {
        //strings used for location and default location
        public static string loco;
        public string city = "Stratford";
        public string country = "CA";

        //used for error message
        public static string error;
        string savedLocation = "";

        public SearchScreen()
        {
            InitializeComponent();

            //display the place by finding the xml file from form1
            cityOutput.Text = Form1.location;
        }

        private void addCity_Click(object sender, EventArgs e)
        {
            //save the previous location
            savedLocation = "";
            savedLocation += loco;

            //put the inputted city and country into the appropriate string
            city = searchCityBar.Text;
            country = searchCountryBar.Text;

            //display format
            loco = city + "," + country;

            //display on screen
            Form1.location = loco;
            cityOutput.Text = Form1.location;

            //update location on all screens
            Form1.days.Clear();
            Form1.ExtractForecast();
            Form1.ExtractCurrent();

            //display "changed" if a real place is entered
            if (error == "")
            {
                error = "Changed";
            }
            //if not, save the previous location
            else
            {
                loco = "";
                loco += savedLocation;
            }
            //don't show anything in error label if a real place is entered
            errorLabel.Text = error;
            error = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //change screen
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
