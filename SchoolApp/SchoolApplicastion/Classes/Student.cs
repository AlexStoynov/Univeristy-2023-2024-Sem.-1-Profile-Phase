using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApplicastion.Classes
{
    public class Student
    {
        int studentID;

        public string Name { get; private set; }

        public Student(string name, int studentID)
        {
            this.Name = name;
            this.studentID = studentID;
        }

        public void ChangeName(string newName)
        {
            this.Name = newName;
        }

        public override string ToString()
        {
            return $"{this.Name}, student number: {studentID}";
        }
    }
}
