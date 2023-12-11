namespace RandomMovingCar
{
    public partial class Form1 : Form
    {
        RandomNum rand = new RandomNum();
        public Form1()
        {
            InitializeComponent();
        }

        private void startCarBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int width = this.Width;
            rand = new RandomNum();
            if (rand.GetNumber() == 1)
            {
                picBox.Location = new Point(picBox.Location.X + 20, picBox.Location.Y);

            }
            else if (rand.GetNumber() == 2)
            {
                picBox.Location = new Point(picBox.Location.X - 20, picBox.Location.Y);
            }
            timer1.Interval = 100;
        }

        private void picBox_Click(object sender, EventArgs e)
        {
            picBox.Location = new Point(50, 0);
        }
    }
}