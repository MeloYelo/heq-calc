using System;

namespace UIConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			var calculator = new Calculator();
			Console.WriteLine("Calculating the sum of two values");
			Console.WriteLine("=================================");
			Console.Write("enter value 1: ");
			string value1 = Console.ReadLine();
			Console.Write("enter value 2: ");
			string value2 = Console.ReadLine();

			while (!string.Equals(value1, "q", StringComparison.InvariantCultureIgnoreCase))
			{
				try
				{
					Console.WriteLine("{0} + {1} = {2}", value1, value2, calculator.Sum(value1, value2));
				}
				catch (ArgumentException argumentException)
				{
					Console.WriteLine("At least one of the values is not a valid number");
				}
				Console.Write("\nenter value 1: ");
				value1 = Console.ReadLine();
				Console.Write("enter value 2: ");
				value2 = Console.ReadLine();
			}

		}
	}
}
