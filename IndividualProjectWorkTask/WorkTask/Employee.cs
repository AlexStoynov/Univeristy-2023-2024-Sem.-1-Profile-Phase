using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WorkTask
{
    public class Employee
    {
        private static int increment = 0;
        private int id;
        private string ssn;
        private string firstName;
        private string lastName;
        private string gender;
        private string streetName;
        private string streetNumber;
        private string zipCode;
        private string city;
        private string email;
        private Department department;


        public Employee(string ssn, string firstName, string lastName, string gender, string streetName, string streetNumber, string zipCode, string city, string email, Department department)
        {
            this.id = ++increment;
            this.ssn = ssn;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.streetName = streetName;
            this.streetNumber = streetNumber;
            this.zipCode = zipCode;
            this.city = city;
            this.email = email;
            this.department = department;
        }


        public int Id { get { return this.id; } }
        public string SSN { get { return this.ssn; } }
        public string FirstName { get { return this.firstName; } }
        public string LastName { get { return this.lastName; } }
        public Department EmployeeDepartment { get { return this.department; } }
        public override string ToString()
        {
            return $"{this.id}, {this.ssn}, {this.firstName}, {this.lastName}, {this.gender}, {this.streetName}, {this.streetNumber}, {this.zipCode}, {this.city}, {this.email}, {this.department.ToString()}";
        }
    }
}
