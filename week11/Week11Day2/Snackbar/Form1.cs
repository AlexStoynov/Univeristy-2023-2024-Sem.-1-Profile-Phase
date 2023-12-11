using Microsoft.Win32.SafeHandles;

namespace Snackbar
{
    public partial class Form1 : Form
    {
        SnackBar snackBar;
        List<int> amounts;
        public Form1()
        {
            InitializeComponent();
            snackBar = new SnackBar();
            amounts = new List<int>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            amounts.Add(int.Parse(ChipsAmount.Value.ToString()));
            amounts.Add(int.Parse(SodaAmount.Value.ToString()));
            amounts.Add(int.Parse(CandyAmount.Value.ToString()));
            double priceOfOrder = snackBar.ProcessOrder(amounts);
            label4.Text = $"{priceOfOrder.ToString():f2}€";

            List<Snack> snacks = snackBar.GetSnacks();
            for (int i = 0; i < snacks.Count; i++)
            {
                listBox1.Items.Add($"{snacks[i].GetName()} - {amounts[i]}");
            }

            double totalAllOrders = snackBar.GetTotalPriceAllOrders();
            TotalPriceAllOrders.Text = $"{totalAllOrders:f2}€";
            amounts.Clear();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {


        }

        private void changeItemPriceButton_Click(object sender, EventArgs e)
        {
            if (rbChips.Checked)
            {
                snackBar.GetSnacks()[0].ChangePrice(double.Parse(ItemNewPrice.Value.ToString()));
                ChipsPrice.Text = $"{snackBar.GetSnacks()[0].GetPrice():f2}€";
            }
            else if (rbSoda.Checked)
            {
                snackBar.GetSnacks()[1].ChangePrice(double.Parse(ItemNewPrice.Value.ToString()));
                SodaPrice.Text = $"{snackBar.GetSnacks()[1].GetPrice():f2}€";
            }
            else if (rbCandy.Checked)
            {
                snackBar.GetSnacks()[2].ChangePrice(double.Parse(ItemNewPrice.Value.ToString()));
                CandyPrice.Text = $"{snackBar.GetSnacks()[2].GetPrice():f2}€";
            }
        }
    }
}