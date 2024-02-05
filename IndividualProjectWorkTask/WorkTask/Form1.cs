namespace WorkTask
{
    public partial class Form1 : Form
    {
        Company company;
        public Form1(Company company)
        {
            InitializeComponent();
            this.company = company;
        }

        private void TaskCreationFormBtn_Click(object sender, EventArgs e)
        {
            TaskCreation taskCreation = new TaskCreation(company);
            taskCreation.Show();
            this.Close();
        }

        private void EmployeeCreationFormButtn_Click(object sender, EventArgs e)
        {
            EmployeeCreation employeeCreation = new EmployeeCreation(company);
            employeeCreation.Show();
            this.Close();
        }

        private void TaskOverviewFormBtn_Click(object sender, EventArgs e)
        {

            TaskOverview taskOverview = new TaskOverview(company);
            taskOverview.Show();
            this.Close();
        }

        private void AssignTaskFormBtn_Click(object sender, EventArgs e)
        {
            TaskAssignment taskAssignment = new TaskAssignment(company);
            taskAssignment.Show();
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Program.CloseApp();
            }
        }
    }
}