namespace SeasonApp
{
    public partial class Form1 : Form
    {
        Seasons allSeasons =  Seasons.Winter;
        public Form1()
        {
            InitializeComponent();
        }

        private void nextSeasonBtn_Click(object sender, EventArgs e)
        {
            if(allSeasons == Seasons.Winter)
            {
                allSeasons = Seasons.Spring;
            }
            else
            {
                allSeasons++;
            }

            SeasonLbl.Text = allSeasons.ToString();
        }
    }
}