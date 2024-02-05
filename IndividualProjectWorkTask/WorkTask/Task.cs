using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace WorkTask
{
    public class Task
    {
        private string taskName;
        private List<Department> departments;
        private string status;
        private DateTime deadline;
        private string description;
        private Employee employee = null;

        public Task(string taskName, DateTime deadline, string description) : this(taskName, new List<Department>(){ Department.HumanResources, Department.ResearchandDevelopment, Department.Support, Department.Marketing, Department.Sales }, deadline, description)
        {
        }

        public Task(string taskName, List<Department> departments, DateTime deadline, string description)
        {
            this.taskName = taskName;
            this.departments = departments;
            this.deadline = deadline;
            this.description = description;
            this.status = "Open";
        }

        public string TaskName { get { return this.taskName; } }
        public List<Department> TaskDepartments { get { return this.departments; } }
        public DateTime Deadline { get { return this.deadline; } }
        public string Status { get { return this.status; } }
        public Employee TaskEmployee { get { return this.employee; } private set { this.employee = value; } }
        public string Description { get { return this.description; } }

        public void AssignEmployee(Employee personAssigned)
        {
            Employee assignee;

            if (TaskDepartments.Contains(personAssigned.EmployeeDepartment))
            {
                assignee = personAssigned;
                this.employee = assignee;
            }
            else
            {
                throw new ArgumentException("Task departments does not match employee's department");
            }
        }

        public void MarkTask(string newStatus)
        {
            this.status = newStatus;
        }

        public string TaskToString()
        {
            StringBuilder sb = new StringBuilder();
            var myNewList = this.departments.Select(t => t.ToString()).ToList();
            sb.Append($"Task: {this.taskName} is {this.status}, Departments: {string.Join(", ", myNewList)}");

            return sb.ToString();
        }
    }
}
