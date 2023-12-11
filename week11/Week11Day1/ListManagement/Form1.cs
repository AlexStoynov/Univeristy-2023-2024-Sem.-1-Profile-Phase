using System.Linq.Expressions;

namespace ListManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBananas.Checked)
            {
                listBox1.Items.Add(rbBananas.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddToListBtn_Click(object sender, EventArgs e)
        {
            ifListSelected();
        }

        private void ifListSelected()
        {
            string outputItem = comboBox1.Items[comboBox1.SelectedIndex].ToString();

            if (cbUppercase.Checked)
            {
                listBox1.Items.Add(outputItem.ToUpper());
            }
            else
            {
                listBox1.Items.Add(outputItem);
            }
        }

        private void listClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void rbApples_CheckedChanged(object sender, EventArgs e)
        {
            if (rbApples.Checked)
            {
                listBox1.Items.Add(rbApples.Text);
            }
        }

        private void rbOranges_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOranges.Checked)
            {
                listBox1.Items.Add(rbOranges.Text);
            }
        }
    }
}