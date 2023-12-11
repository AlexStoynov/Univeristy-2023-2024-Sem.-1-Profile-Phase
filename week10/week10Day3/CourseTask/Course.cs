using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseTask
{
    public class Course
    {    
        private string name;
        private int ec;  
        public void SetName(string name)
        { 
            this.name = name;
        }

        public string GetName()
        { 
            return this.name;
        }

        public void SetEc(int ec)
        { 
            this.ec = ec;
        }

        public int GetEc()
        { 
            return this.ec;
        }

    }
}
