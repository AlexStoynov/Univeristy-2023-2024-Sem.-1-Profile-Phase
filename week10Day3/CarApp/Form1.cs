namespace CarApp
{
    public partial class Form1 : Form
    {
        Car newCar = new Car();
        Car car2 = new Car();

        public Form1()
        {
            InitializeComponent();
            newCar.SetBrand("Porsche");
            newCar.SetMaxSpeed(250);
            car2.SetBrand("Opel");
            car2.SetMaxSpeed(150);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newCar.SpeedUp();
            car2.SpeedUp();
            label1.Text = newCar.GetInfo().ToString();
            label2.Text = car2.GetInfo().ToString();
        }

        private void BrakeButton_Click(object sender, EventArgs e)
        {
            newCar.SlowDown();
            car2.SlowDown();
            label1.Text = newCar.GetInfo().ToString();
            label2.Text = car2.GetInfo().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}