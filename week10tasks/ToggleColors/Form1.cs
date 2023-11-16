namespace ToggleColors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Red)
            {
                this.BackColor = Color.Green;
            }
            else if (this.BackColor == Color.Green)
            {
                this.BackColor = Color.Blue;
            }
            else if (this.BackColor == Color.Blue)
            {
                this.BackColor = Color.Red;
            }
        }
    }
}