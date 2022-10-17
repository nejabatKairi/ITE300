using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module14
{
    class Faculty:Employee //subclass
    {
        public override void Name()
        { 
            Console.WriteLine("Name: Clea");
        }
        public override void Address()
        {
            Console.WriteLine("Address: Manila City");
        }
        public override void Gender()
        {
            Console.WriteLine("Gender: Female");
        }
        public override void Phone()
        {
            Console.WriteLine("Phone: 09059677753");
        }
        public override void Email()
        {
            Console.WriteLine("Email: clea@gmail.com");
        }
        public override void BirthDate()
        {
            Console.WriteLine("BirthDate: 01/28/01");
        }
        public override void Designation()// Override to change this Desination() method value from the super class
        {
            Console.WriteLine("Designation: Manila City ");
        }
        public override void Salary()
        {
            Console.WriteLine("Salary: 30000");
        }
        public void CollegeDepartment()
        {
            Console.WriteLine("CollegeDepartment: ");
        }
        public void SubjectLoad()
        {
            Console.WriteLine("SubjectLoad: ");
        }
    }
}
