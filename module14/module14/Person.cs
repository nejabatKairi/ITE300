using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module14
{
     class Person // Super Class
    {
        public virtual void Name() // Overwrite method Name() inherited value
        {
            Console.WriteLine("Name: Kairi");
        }
        public virtual void Address()
        {
            Console.WriteLine("Address: Dagupan City");
        }
        public virtual void Gender()
        {
            Console.WriteLine("Gender: Male");
        }
        public virtual void Phone()
        {
            Console.WriteLine("Phone: 090597***88");
        }
        public virtual void Email()
        {
            Console.WriteLine("Email: kairitabajen@gmail.com");
        }
        public virtual void BirthDate()
        {
            Console.WriteLine("BirthDate: 04/15/02");
        }
    }
}
