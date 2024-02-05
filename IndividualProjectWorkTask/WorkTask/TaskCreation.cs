using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTask
{
    public partial class TaskCreation : Form
    {
        Company company;
        public TaskCreation(Company company)
        {
            InitializeComponent();
            this.company = company;
        }

        private void TaskCreation_Load(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(company);
            form1.Show();
            this.Close();
        }

        private void CreateTaskBtn_Click(object sender, EventArgs e)
        {
            List<Department> departments = new List<Department>();
            Task task = null;

            foreach (var dep in DepartmentsCBList.CheckedItems)
            {
                departments.Add(Enum.Parse<Department>(dep.ToString()));
            }

            DateTime selectedDeadline = TaskDeadlineDTP.Value;

            if (selectedDeadline < DateTime.Now)
            {
                throw new ArgumentException("Task deadline cannot be in the past");
            }

            if (departments.Count == 0)
            {
                task = new Task(TaskNameTB.Text, selectedDeadline, TaskDescriptionTB.Text);
            }
            else
            {
                task = new Task(TaskNameTB.Text, departments, selectedDeadline, TaskDescriptionTB.Text);
            }

            company.Tasks.Add(task);
        }

        private void TaskCreation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Program.CloseApp();
            }
        }
    }
}
