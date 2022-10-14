using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{                   //Kairi Tabajen
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle("Red");
            myCircle.SetRadius(12);
            Console.WriteLine($"Circle: {myCircle.GetColor()}");
            Console.WriteLine($"Radius: {myCircle.GetRadius()}");
            Console.WriteLine($"Area: {Math.Round(myCircle.GetArea(), 2)}");
            Console.WriteLine($"Circumference: {Math.Round(myCircle.GetPerimeter(), 2)}");
            Console.ReadLine();
        }
    }
    class Circle //Create the Circle class
    {
        private int radius; //a private field which holds the value of radius
        private string color; //a private field which holds the value of color

        public Circle(string colorName)//a constructor which set the color of instantiated circle
        {
            this.color = colorName;
        }

        public void SetRadius(int r)// a public method which sets the value of radius+
        {
            this.radius = r;
        }
        public int GetRadius()//a public method which return the value of Radius
        {
            return this.radius;
        }
        public string GetColor() //a public method which return the value of Color
        {
            return this.color;
        }
        public double GetArea()//a public method which return the value of Area
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }
        public double GetPerimeter()//a public method which return the value of Circumference +
        {
            return 2 * Math.PI * radius;
        }
    }

}