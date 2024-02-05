using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTask
{
    public class Company
    {
        private string companyName;
        private List<Employee> employees;
        private List<Task> tasks;

        public Company(string companyName)
        {
            this.companyName = companyName;
            this.employees = new List<Employee>();
            this.tasks = new List<Task>();
        }

        public List<Task> Tasks { get { return this.tasks; } }
        public List<Employee>   Employees { get { return this.employees; } }

        public void AddEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentException("Employee cannot be null.");
            }
            this.employees.Add(employee);
        }

        public void AddTask(Task task)
        {
            if (task == null)
            {
                throw new ArgumentException("Task cannot be null.");
            }
            this.tasks.Add(task);
        }

        public string AssignEmployeeToTask(string taskName, int employeeID)
        {
            Task currTask = tasks.Find(x => x.TaskName == taskName);
            Employee employee = employees.Find(x => x.Id == employeeID);

            if (currTask == null || employee == null)
            {
                throw new ArgumentException("Task or employee cannot be null");
            }
            else if(currTask.TaskEmployee != employee && currTask.TaskEmployee != null)
            {
                throw new ArgumentException("Task already has another employee assigned to it.");
            }

            currTask.AssignEmployee(employee);
            return "Employee assigned to task";
        }

        public void ImportEmployees(string filePath)
        {
            try
            {
                foreach (string line in File.ReadAllLines(filePath))
                {
                    string[] values = line.Split(',');
                    string ssn = values[1];
                    string firstName = values[2];
                    string lastName = values[3];
                    string gender = values[4];
                    string streetName = values[5];
                    string streetNumber = values[6];
                    string zipCode = values[7];
                    string city = values[8];
                    string email = values[9];
                    Department department = Enum.Parse<Department>(values[10]);

                    employees.Add(new Employee(ssn, firstName, lastName, gender, streetName, streetNumber, zipCode, city, email, department));
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error reading CSV file: {ex.Message}");
            }
        }
    }
}
