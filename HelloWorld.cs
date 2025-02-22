using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello, User");
			Console.WriteLine("what's you'r name");
			string name = Console.ReadLine();
			
			Console.WriteLine("Welcome Back " + name);
			
			Console.WriteLine("You'r Account is active Mr.{0}"; name);
	    
			
		}
	}
}