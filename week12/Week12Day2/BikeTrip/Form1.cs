namespace BikeTrip
{
    public partial class Form1 : Form
    {
        private List<Trip> trips;
        TransportationType transportationType;
        public Form1()
        {
            InitializeComponent();
            this.trips = new List<Trip>();
        }

        private void AddTripBtn_Click(object sender, EventArgs e)
        {
            transportationType = (TransportationType)transportationTypeCBB.SelectedIndex;
            Trip trip = new Trip(TripDestinationTb.Text, (double)TripDistance.Value, (double)TripRating.Value, transportationType);
            trips.Add(trip);
        }

        private void ShowAllTripsBtn_Click(object sender, EventArgs e)
        {
            TripsListBox.Items.Clear();
            foreach (Trip trip in trips)
            {
                TripsListBox.Items.Add($"{trip.Destination} - {trip.Distance:f2} KM");
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            foreach (Trip trip in trips)
            {
                if (trip.Destination == DestinationSearch.Text)
                {
                    TripsListBox.Items.Clear();
                    TripsListBox.Items.Add(trip);
                }
            }
        }

        private void ShowInfoSelectedBtn_Click(object sender, EventArgs e)
        {
            int tripIndex = TripsListBox.SelectedIndex;
            TripsListBox.Items.Clear();
            TripsListBox.Items.Add(trips[tripIndex]);
        }

        private void DeleteSelectedTripBtn_Click(object sender, EventArgs e)
        {
            int tripIndex = TripsListBox.SelectedIndex;
            TripsListBox.Items.RemoveAt(tripIndex);
            trips.RemoveAt(tripIndex);
        }

        private void ShowAvgBtn_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm(trips);
            infoForm.Show();
        }

        private void FilterTrips_Click(object sender, EventArgs e)
        {
            TripsListBox.Items.Clear();
            foreach (Trip trip in trips)
            {
                if (trip.Rating > (double)FilterRatingMinVal.Value && trip.Rating < (double)FilterRatingMaxVal.Value)
                {
                    TripsListBox.Items.Add($"{trip.Destination} - {trip.Distance:f2} KM");
                }
            }
        }
    }
}