namespace BMICalculatorAdvanced
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight = double.Parse(textBox1.Text);
            double height = double.Parse(textBox2.Text);
            double bmiScore = weight / Math.Pow(height, 2);

            label4.Text = $"Your BMI score is: {bmiScore:f2}";

            if (bmiScore < 18)
            {
                label6.Text = "You are regarded as: Underweight";
            }
            else if (bmiScore >= 18 && bmiScore < 25)
            {
                label6.Text = "You are regarded as: Normal weight";
            }
            else if (bmiScore >= 25 && bmiScore < 30)
            {
                label6.Text = "You are regarded as: Overweight";
            }
            else
            {
                label6.Text = "You are regarded as: Obese";
            }
        }
    }
}