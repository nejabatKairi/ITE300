using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using System;
//Prgrammer Kairi Tabajen
//Au-2BSIT-A
public class Person
{
    // Class members
    public string fname; // field
    public string lname; // field
    public int birthYear; // field
    public int Age; // field
    public void fullName() // method
    {
        //Console.WriteLine("**************************");
        Console.WriteLine("Hello " + fname + " " + lname);

        Console.WriteLine("Your age are " + " " + Age + " " + " years old.");

        Console.WriteLine("*********************");

        Console.WriteLine("Your first name is" + " " + fname);
        Console.WriteLine("Your last name is" + " " + lname);
        Console.WriteLine("Your birth year is " + " " + birthYear);

    }

    public class Name
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.fname = "Angel";
            person1.lname = "Locsin";
            person1.Age = 30;
            person1.birthYear = 1992;
            person1.fullName();

            Console.ReadKey();

        }
    }
}

