using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class president : Worker
    {
        public president(string name, string surname, decimal salary) : base(name,surname,salary)
        {
            
        }
    }
    public class Security : Worker
    {
        public Security(string name, string surname, decimal salary) : base(name, surname, salary)
        {

        }
    }
    public class Manager : Worker
    {
        public Manager(string name, string surname, decimal salary) : base(name, surname, salary)
        {

        }
    }
    public class Engineer : Worker
    {
        public Engineer(string name, string surname, decimal salary) : base(name, surname, salary)
        {

        }
    }
}
