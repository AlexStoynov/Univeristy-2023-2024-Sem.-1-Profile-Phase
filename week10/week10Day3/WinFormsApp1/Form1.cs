namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Course course;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void courseObjectCreate_Click(object sender, EventArgs e)
        {
            course = new Course(textBox1.Text.ToString());

            if(textBox2.Text != "")
            {
                course.SetEc(int.Parse(textBox2.Text));
            }
        }

        private void showInfo_Click(object sender, EventArgs e)
        {
            string courseName = course.GetName();
            int courseEC = course.GetEc();
            courseInfo.Text = $"Course name: {courseName} Course EC: {courseEC}";
        }
    }
}