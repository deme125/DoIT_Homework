using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public abstract class Worker
    {
        
        private string name;
		private string surname;
		private decimal salary;

        protected Worker(string name, string surname, decimal salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }

        public decimal Salary
        {
			get { return salary; }
            set
            {
                if (value >= 0)
                {
                    salary = value;
                }
            }
        }


		public string Surname
        {
			get { return surname; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    surname = value.Trim();
                }
            }
        }


		public string Name
		{
			get { return name; }
			set
			{
				if (!string.IsNullOrWhiteSpace(value))
				{
					name = value.Trim();
				}
			}
		}

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} {Surname} has the salary of {Salary}");
        }

	}
}
