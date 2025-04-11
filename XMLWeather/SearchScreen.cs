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
        public static string loco;
        public string city = "";
        public string country = "";

        public static string error;
        string savedLocation = "";

        public SearchScreen()
        {
            InitializeComponent();
            //cityOutput.Text = Form1.Location;
        }

        private void addCity_Click(object sender, EventArgs e)
        {
            savedLocation = "";
            savedLocation += loco;

            city = searchCityBar.Text;
            country = searchCountryBar.Text;

            loco = city + "," + country;

            //Form1.location = loco;
            //cityOutput.Text = Form1.location;

            Form1.days.Clear();
            Form1.ExtractForecast();
            Form1.ExtractCurrent();

            if (error == "")
            {
                error = "Error";
            }
            else
            {
                loco = "";
                loco += savedLocation;
            }

            errorLabel.Text = error;
            error = "";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
