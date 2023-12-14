namespace PlanetInfo
{
    public partial class Form1 : Form
    {
        Planets planets;
        public Form1()
        {
            InitializeComponent();
        }

        private void MercuryBtn_Click(object sender, EventArgs e)
        {
            planets = Planets.Mercury;
            GravityLbl.Text = $"The gravity on {planets.ToString()} is 3.7 m/s2'";
            DiameterLbl.Text = $"The diameter of {planets} is 4879.4 km.";
        }

        private void VenusBtn_Click(object sender, EventArgs e)
        {
            planets = Planets.Venus;
            GravityLbl.Text = $"The gravity on {planets.ToString()} is 8.87 m/s2'";
            DiameterLbl.Text = $"The diameter of {planets} is 12104 km.";
        }

        private void EarthBtn_Click(object sender, EventArgs e)
        {
            planets = Planets.Earth;
            GravityLbl.Text = $"The gravity on {planets.ToString()} is 9.807 m/s2'";
            DiameterLbl.Text = $"The diameter of {planets} is 12742 km.";
        }

        private void MarsBtn_Click(object sender, EventArgs e)
        {
            planets = Planets.Mars;
            GravityLbl.Text = $"The gravity on {planets.ToString()} is 3.71 m/s2'";
            DiameterLbl.Text = $"The diameter of {planets} is 6779 km.";
        }

        private void JupiterBtn_Click(object sender, EventArgs e)
        {
            planets = Planets.Jupiter;
            GravityLbl.Text = $"The gravity on {planets.ToString()} is 24.79 m/s2'";
            DiameterLbl.Text = $"The diameter of {planets} is 142800 km.";
        }
    }
}