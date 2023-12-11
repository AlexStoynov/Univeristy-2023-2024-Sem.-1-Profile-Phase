using System;

namespace DiceRolling
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void rollBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rollsNum.Value; i++)
            {
                Form2 dice = new Form2(rand.Next(1, 7));
                dice.Show();
            }
        }
    }
}