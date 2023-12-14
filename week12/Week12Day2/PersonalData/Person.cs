using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalData
{
    public class Person
    {
        public string FirstName { get {return this.FirstName; }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.FirstName = value;
                }
                else { throw new ArgumentException("First name should not be empty."); } 
            }
        }

        public string LastName
        {
            get { return this.LastName; }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.LastName = value;
                }
                else { throw new ArgumentException("Last name should not be empty."); }
            }
        }

        public string Gender
        {
            get { return this.Gender; }
            private set
            {
                if (value == "male" || value == "female" || value == "other")
                {
                    this.Gender = value;
                }
                else { throw new ArgumentException("This gender is not valid."); }
            }
        }

        public int Birthyear
        {
            get { return this.Birthyear; }
            private set
            {
                if (value >= 0)
                {
                    this.Birthyear = value;
                }
                else { throw new ArgumentException("Birthyear should not be negative."); }
            }
        }
    }
}
