using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Student : Person , IPrintable
    {
        
        private string email;

        private string phone;

        private float gpa;
        

        public Faculty Faculty { get; set; }


        public float GPA
        {
            get { return gpa; }
            set
            {
                if (value < 0 || value > 4)
                    throw new ArgumentOutOfRangeException(nameof(GPA),
                        "GPA must be between 0 and 4.");

                gpa = value;
            }
        }


        public string Phone
        {
            get { return phone; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Phone cannot be empty.");

                phone = value.Trim();
            }
        }


        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains('@'))
                    throw new ArgumentException("Invalid email.");

                email = value.Trim();
            }
        }


        public Student(string Name, string LastName, int Age, string Email, string Phone, float GPA, Faculty Faculty)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Age = Age;
            this.Email = Email;
            this.Phone = Phone;
            this.GPA = GPA;
            this.Faculty = Faculty;
        }

        public override string ToString()
        {
            return $"{Name} {LastName} | {Age} | {Faculty} | {GPA}";
        }



        

        public static bool operator >(Student s1, Student s2)
        {
            return s1.GPA > s2.GPA;
        }
        public static bool operator <(Student s1, Student s2)
        {
            return s1.GPA < s2.GPA;
        }

        public void Print(Student[] students)
        {
            Console.WriteLine("\nAll Students:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        public void Print(Student student)
        {
            Console.WriteLine(student.ToString);
        }



    }

}
