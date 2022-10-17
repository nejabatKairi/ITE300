using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module14
{
    class Staff:Employee
    {
        public override void Name() 
        { 
           Console.WriteLine("Name: Steve");
}
        public override void Address()
        {
        Console.WriteLine("Address: Davao City");
        }
        public override void Gender()
        {
        Console.WriteLine("Gender: Male");
        }
        public override void Phone()
        {
        Console.WriteLine("Phone: ");
        }
        public override void Email()
        {
        Console.WriteLine("Email: Steve@gmail.com");
        }
        public override void BirthDate()
        {
        Console.WriteLine("BirthDate: 09/5/99");
        }
        public override void Designation()
        {
            Console.WriteLine("Designation: Davao City ");
        }
        public override void Salary()
        {
            Console.WriteLine("Salary: 30000");
        }
        public void ServiceDepartment()
        {
            Console.WriteLine("ServiceDepartment: ");
        }
    }
}
