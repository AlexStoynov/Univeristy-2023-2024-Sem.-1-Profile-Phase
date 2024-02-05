using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ExtendingStudentGroup
{
    public class Member
    {
        private int studentNumber;
        private string name;
        public Member(string name)
        {
            this.name = name;
            this.studentNumber = 0;
        }

        public Member(string name, int studentNumber)
        {
            this.name = name;
            this.studentNumber = studentNumber;
        }

        public int StudentNumber { get { return studentNumber; } }
        public string Name { get { return name; } }

        public string GetInfo()
        {
            if (studentNumber == 0)
            {
                return this.name;
            }
            else
            {
                return $"Student - {this.name}: student number - {this.studentNumber}";
            }
        }
    }
}
