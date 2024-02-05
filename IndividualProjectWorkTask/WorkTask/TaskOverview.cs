using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTask
{
    public partial class TaskOverview : Form
    {
        Company company;
        public TaskOverview(Company company)
        {
            InitializeComponent();
            this.company = company;
        }

        private void TaskOverview_Load(object sender, EventArgs e)
        {
            foreach (var task in company.Tasks)
            {
                var myNewList = task.TaskDepartments.Select(t => t.ToString()).ToList();
                TasksOverviewLB.Items.Add($"Task name: {task.TaskName}, Status: {task.Status}, Department: {String.Join(", ", myNewList)}");
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(company);
            form1.Show();

            this.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            TasksOverviewLB.Items.Clear();
            List<Task> tasksFiltered = new List<Task>();

            foreach (var task in company.Tasks)
            {
                if (TaskNameTB.Text.Contains(task.TaskName, StringComparison.OrdinalIgnoreCase) ||
                TaskStatusSearchCB.Text.Contains(task.Status, StringComparison.OrdinalIgnoreCase) ||
                (!string.IsNullOrEmpty(TaskDepSearchCB.Text) && task.TaskDepartments.Contains(Enum.Parse<Department>(TaskDepSearchCB.Text))))
                {
                    tasksFiltered.Add(task);
                }
            }

            foreach (var task in tasksFiltered)
            {
                var myNewList = task.TaskDepartments.Select(t => t.ToString()).ToList();
                TasksOverviewLB.Items.Add($"Task named: {task.TaskName}, Status: {task.Status}, Department: {String.Join(", ", myNewList)}");
            }
        }

        private void MarkTaskBtn_Click(object sender, EventArgs e)
        {
            Task task = company.Tasks[TasksOverviewLB.SelectedIndex];

            if (task.TaskEmployee == null)
            {
                throw new ArgumentException("Task cannot be marked, because it does not have an employee assigned to it.");
            }

            task.MarkTask(TaskStatusCB.Text);

            TasksOverviewLB.Items.Clear();

            foreach (var item in company.Tasks)
            {
                var myNewList = item.TaskDepartments.Select(t => t.ToString()).ToList();
                TasksOverviewLB.Items.Add($"Task name: {item.TaskName}, Status: {item.Status}, Department: {String.Join(", ", myNewList)}");
            }
        }

        private void TaskDeleteBtn_Click(object sender, EventArgs e)
        {
            company.Tasks.RemoveAt(TasksOverviewLB.SelectedIndex);
            TasksOverviewLB.Items.Remove(TasksOverviewLB.SelectedItem);
        }

        private void TaskOverview_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Program.CloseApp();
            }
        }
    }
}
