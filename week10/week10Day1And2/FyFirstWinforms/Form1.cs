namespace FyFirstWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Hello, " + textBox1.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}