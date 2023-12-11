using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Course
    { 
        private string name;
        private int ec;

        public Course(string name, int ec)
        {
            this.name = name;
            this.ec = ec;
        }

        public Course(string name)
        {
            this.name = name;
            this.ec = 3;
        }

        public void SetName(string name)
        { this.name = name; }

        public string GetName()
        { return this.name; }

        public void SetEc(int ec)
        { this.ec = ec; }

        public int GetEc()
        { return this.ec; }
    }

}
