using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Users user = new Users();
			user.GetUserDetails();
			Console.WriteLine("Press Enter Key to Exit..");
		
		Console.ReadKey();
		}
}
}
public class Users
{
	public string name = "Julia";
public int age = 25;
	public void GetUserDetails()
	{
		Console.WriteLine("Name: {0}, Age: {1}", name, age);
	}
}
