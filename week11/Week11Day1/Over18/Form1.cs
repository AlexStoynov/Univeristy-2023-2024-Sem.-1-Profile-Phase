namespace Over18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbLemonade_CheckedChanged(object sender, EventArgs e) { }

        private void rbBeer_CheckedChanged(object sender, EventArgs e) { }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            if (rbLemonade.Checked)
            {
                outputLbl.Text = "You ordered Lemonade.";
            }
            else if (rbBeer.Checked && cbOver18.Checked)
            {
                outputLbl.Text = "You ordered Beer.";
            }
            else
            {
                outputLbl.Text = "You have to be over 18 years old to order Beer.";
            }
        }
    }
}