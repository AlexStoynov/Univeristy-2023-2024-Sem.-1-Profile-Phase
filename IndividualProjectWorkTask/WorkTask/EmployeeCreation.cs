using System.Xml.Serialization;

using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace WorkTask

{
    public partial class EmployeeCreation : Form
    {
        private Company company;

        public EmployeeCreation(Company company)
        {
            InitializeComponent();
            this.company = company;
        }

        private void EmployeeCreation_Load(object sender, EventArgs e)
        {
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(company);
            form1.Show();

            this.Close();
        }

        private void CreateEmployeeBtn_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(EmployeeSSN.Text, FirstNameTB.Text, LastNameTB.Text, GenderTB.Text, StreetNameTB.Text, StreetNumTB.Text, ZipCodeTB.Text, CityTB.Text, EmailTB.Text, Enum.Parse<Department>(DepartmentComboBox.Text));
            company.AddEmployee(employee);
            employeesTable.Rows.Add(employee.Id, employee.SSN, employee.FirstName, employee.LastName, employee.EmployeeDepartment.ToString());
        }

        private void SaveEmployeesBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV Files (.csv)|.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SaveEmployeesToCsv(sfd.FileName);
            }
        }

        private void LoadEmployeesBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "CSV Files (*.csv)|*.csv";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                LoadEmployeesFromCsv(opf.FileName);
            }
        }

        private void SaveEmployeesToCsv(string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("id,ssn,first_name,last_name,gender,street_name,street_number,zipcode,city,email,Department");
                    foreach (Employee currEmployee in company.Employees)
                    {
                        sw.WriteLine(currEmployee.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void LoadEmployeesFromCsv(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sr.ReadLine();

                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] values = line.Split(',');

                        string departmentName = values[10].Replace(" ", string.Empty);

                        if (Enum.TryParse<Department>(departmentName, out var department))
                        {
                            try
                            {
                                Employee employee = new Employee(values[1], values[2], values[3],
                                values[4], values[5], values[6],
                                values[7], values[8], values[9],
                                (Department)Enum.Parse(typeof(Department), values[10].Replace(" ", string.Empty), ignoreCase: true));

                                company.AddEmployee(employee);
                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine($"Error creating employee: {ex.Message}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void RefreshTableBtn_Click(object sender, EventArgs e)
        {
            employeesTable.Rows.Clear();

            foreach (Employee employee in company.Employees)
            {
                string employeeDep = employee.EmployeeDepartment.ToString();
                employeesTable.Rows.Add(employee.Id, employee.SSN, employee.FirstName, employee.LastName, employeeDep);
            }
        }

        private void EmployeeCreation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Program.CloseApp();
            }
        }
    }
}