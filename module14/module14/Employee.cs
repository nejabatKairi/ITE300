using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module14
{
    class Employee:Person
    {

        public virtual void Designation()
        {
            Console.WriteLine("Designation: ");
        }
        public virtual void Salary()
        {
            Console.WriteLine("Salary: ");
        }

    }
}
