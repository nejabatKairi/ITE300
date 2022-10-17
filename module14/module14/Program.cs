using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module14
{
    //Programmer: Kairi Tabajen
    //Inheritance
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name();
            person.Address();
            person.Gender();
            person.Phone();
            person.Email();
            person.BirthDate();
            Console.WriteLine("*************************************");
            Console.WriteLine("Student");
            Student student = new Student();
            student.Name();
            student.Address();
            student.Gender();
            student.Phone();
            student.Email();
            student.BirthDate();
            student.SchoolLastGraduated();
            student.Course();
            Console.WriteLine("*************************************");
            Console.WriteLine("Faculty");
            Faculty faculty = new Faculty();
            faculty.Name();
            faculty.Address();
            faculty.Gender();
            faculty.Phone();
            faculty.Email();
            faculty.BirthDate();
            faculty.Designation();
            faculty.Salary();
            faculty.CollegeDepartment();
            faculty.SubjectLoad();
            Console.WriteLine("*************************************");
            Console.WriteLine("Staff");
            Staff staff = new Staff();
            staff.Name();
            staff.Address();
            staff.Gender();
            staff.Phone();
            staff.Email();
            staff.BirthDate();
            staff.Designation();
            staff.Salary();
            staff.ServiceDepartment();
            Console.WriteLine("*************************************");
           
            Console.ReadLine();
        }
    }
}
