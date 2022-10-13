using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
	//Kairi Tabajen
	// The class
	public class Car
	{
		// Class members
		public string model; // field
		public string color; // field
		public int maxSpeed; // field
		public int year; // field
		public void fullThrottle() // method
		{
			Console.WriteLine("**************************");
			Console.WriteLine(model + " is going as fast as it can!");
			Console.WriteLine(color + " is the color of  " + model);
			Console.WriteLine(maxSpeed + " is the max speed of  " + model);
			Console.WriteLine(year + " is the model year of  " + model);
			Console.WriteLine("**************************");
			Console.WriteLine("sorry sir late ko na pass");
		}
	}
	public class Cars
	{
		public static void Main(string[] args)
		{
			Car ford = new Car();
			ford.model = "Mustang";
			ford.color = "red";
			ford.year = 1969;
			ford.maxSpeed = 250;
			Car honda = new Car();
			honda.model = "Brio";
			honda.color = "orange";
			honda.year = 2019;
			honda.maxSpeed = 300;
			Car ferrari = new Car();
			ferrari.model = "Ferrari 812 GTS";
			ferrari.color = "black";
			ferrari.year = 2020;
			ferrari.maxSpeed = 400;
			Console.WriteLine(ford.model);
			Console.WriteLine(honda.model);
			Console.WriteLine(ferrari.model);
			honda.fullThrottle();
			Console.WriteLine("*************");
			ford.fullThrottle();
			Console.WriteLine("*************");
			ferrari.fullThrottle();

			Console.ReadKey();
		}
	}
}
