namespace DocumentApp
{
    public partial class Form1 : Form
    {
        FileStream fs;
        StreamWriter sw;
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveToTxtBtn_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream($"{DocumentTitle.Text}.txt", FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.Write(DocumentText.Text);
            }
            catch (IOException)
            {
                MessageBox.Show("Error opening file");
            }
            finally { sw.Close(); }
        }
    }
}