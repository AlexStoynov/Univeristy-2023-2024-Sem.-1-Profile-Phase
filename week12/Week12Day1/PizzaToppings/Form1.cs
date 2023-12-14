namespace PizzaToppings
{
    public partial class Form1 : Form
    {
        Toppings toppings;
        List<string> finalToppings = new List<string>();
        double price = 7;
        public Form1()
        {
            InitializeComponent();
        }

        private void addToppingBtn_Click(object sender, EventArgs e)
        {
            finalToppings.Add(toppingsCb.Text);
            label3.Text = " ";
            foreach (string topping in finalToppings)
            {
                label3.Text += $"{topping}, ";
            }
            price += 0.5;
            label4.Text = price.ToString();
        }

        private void RemoveToppingBtn_Click(object sender, EventArgs e)
        {
            finalToppings.Remove(toppingsCb.Text);
            label3.Text = " ";
            foreach (string topping in finalToppings)
            {
                label3.Text += $"{topping}, ";
            }
            price -= 0.5;
            label4.Text = price.ToString();
        }
    }
}