namespace Lottery
{
    public partial class Form1 : Form
    {
        Lottery lottery;
        int counter = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateLotteryObjBtn_Click(object sender, EventArgs e)
        {
            int max = int.Parse(MaxValue.Text);
            int wantedNums = int.Parse(WantedNums.Text);
            lottery = new Lottery(max, wantedNums);
            counter = 1;
            NumbersDrawnBox.Items.Clear();
        }

        private void DrawNumsAtOnceBtn_Click(object sender, EventArgs e)
        {
            List<int> numbersDrawn = new List<int>();

            if (NumbersDrawnBox.Items.Count == 0)
            {
                NumbersDrawnBox.Items.Clear();
                numbersDrawn = lottery.GenerateNumbers();
            }
            else if (NumbersDrawnBox.Items.Count > 0)
            {
                int max = int.Parse(MaxValue.Text);
                int wantedNums = int.Parse(WantedNums.Text);
                int numsLeftToGenerate = wantedNums - NumbersDrawnBox.Items.Count;
                Lottery smallLot = new Lottery(max, numsLeftToGenerate);
                numbersDrawn = smallLot.GenerateNumbers();
            }

            foreach (int number in numbersDrawn)
            {
                NumbersDrawnBox.Items.Add(number);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void DrawNextNumBtn_Click(object sender, EventArgs e)
        {
            int wantedNumsCount = int.Parse(WantedNums.Text);
            if(counter <= wantedNumsCount)
            {
                NumbersDrawnBox.Items.Add(lottery.DrawOneByOne());
            }
            counter++;
        }
    }
}