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
    public partial class TaskAssignment : Form
    {
        Company company;
        public TaskAssignment(Company company)
        {
            InitializeComponent();
            this.company = company;
        }

        private void TaskAssignment_Load(object sender, EventArgs e)
        {
            foreach (var task in company.Tasks)
            {
                TasksLB.Items.Add(task.TaskToString());
            }

            foreach (var item in company.Employees)
            {
                EmployeesLB.Items.Add(item);
            }
        }

        private void AssignBtn_Click(object sender, EventArgs e)
        {
            company.Tasks[TasksLB.SelectedIndex].AssignEmployee(company.Employees[EmployeesLB.SelectedIndex]);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(company);
            form1.Show();

            this.Close();
        }

        private void TaskAssignment_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Program.CloseApp();
            }
        }
    }
}
