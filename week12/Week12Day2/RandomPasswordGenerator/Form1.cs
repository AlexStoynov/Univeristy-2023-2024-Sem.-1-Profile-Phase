namespace RandomPasswordGenerator
{
    public partial class Form1 : Form
    {
        PasswordGenerator passGen;
        List<string> passwordList;
        public Form1()
        {
            InitializeComponent();
            passGen = new PasswordGenerator();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void generatePassBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int length = int.Parse(passLength.Value.ToString());
            int amount = int.Parse(passAmount.Value.ToString());
            bool specialSymbols = false;
            if (specialSymbolsCB.Checked)
            {
                specialSymbols = true;
            }
            passwordList = PasswordGenerator.GeneratePasswords(length, amount, specialSymbols);

            foreach (string password in passwordList)
            {
                listBox1.Items.Add(password);
            }

        }
    }
}