namespace CrazyRounding
{
    public partial class Form1 : Form
    {
        CrazyMath result;
        List<double> results;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RoundBtn_Click(object sender, EventArgs e)
        {
            ListBoxNums.Items.Clear();
            result = new CrazyMath(double.Parse(NumTextBox.Text));
            if (ToWholeRb.Checked)
            {
                results = result.RoundToWhole();

                foreach (var item in results)
                {
                    ListBoxNums.Items.Add($"{item:f0}");
                }
            }
            else if (ToTenthRb.Checked)
            {
                results = result.RoundToTenth();

                foreach (var item in results)
                {
                    ListBoxNums.Items.Add($"{item:f1}");
                }
            }
            else if (ToOneHundredRb.Checked)
            {
                results = result.RoundToHundreth();

                foreach (var item in results)
                {
                    ListBoxNums.Items.Add($"{item:f2}");
                }

            }
        }
    }
}