namespace DiceRolling
{
    public partial class Form2 : Form
    {
        public Form2(int index)
        {
            InitializeComponent();
            RandomNum rand = new RandomNum();

            switch (rand.GetNumber())
            {
                case 1:
                    pictureBox1.Image = Resource1.DiceFace1;
                    break;

                case 2:
                    pictureBox1.Image = Resource1.DiceFace2;
                    break;

                case 3:
                    pictureBox1.Image = Resource1.DiceFace3;
                    break;
                case 4:
                    pictureBox1.Image = Resource1.DiceFace4;
                    break;
                case 5:
                    pictureBox1.Image = Resource1.DiceFace5;
                    break;
                case 6:
                    pictureBox1.Image = Resource1.DiceFace6;
                    break;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}