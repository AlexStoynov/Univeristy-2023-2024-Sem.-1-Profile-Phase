using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeTrip
{
    public partial class InfoForm : Form
    {
        private List<Trip> infoFormTrips;
        public InfoForm(List<Trip> trips)
        {
            InitializeComponent();
            infoFormTrips = trips;

        }

        private void ShowInfoBtn_Click(object sender, EventArgs e)
        {
            TripsInfo.Items.Clear();
            double tripRating = 0;

            foreach (Trip trip in infoFormTrips)
            {
                TripsInfo.Items.Add($"{trip.Destination} - {trip.Distance:f2} KM");
                tripRating += trip.Rating;
            }

            double tripAvg = tripRating / infoFormTrips.Count;

            showAvgTb.Text = $"The average rating of all the trips is {tripAvg:f1}";
        }

        private void ShowRatingAvg_Click(object sender, EventArgs e)
        {

        }
    }
}
