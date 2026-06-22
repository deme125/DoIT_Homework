using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task1
{
    public abstract class Person
    {
        private string name;
        private string lastName;
        private int age;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");

                name = value.Trim();
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Last name cannot be empty.");

                lastName = value.Trim();
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 16 || value > 100)
                    throw new ArgumentOutOfRangeException(nameof(Age),
                        "Age must be between 16 and 100.");

                age = value;
            }
        }
    }
}
