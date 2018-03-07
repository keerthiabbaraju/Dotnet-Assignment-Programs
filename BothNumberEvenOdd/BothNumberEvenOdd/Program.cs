using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BothNumberEvenOdd
{
	class Program
	{
		static void Main()
		{
			int a;
			int b;

			Console.Write("Enter First number: ");
			a = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter Second number: ");
			b = Convert.ToInt32(Console.ReadLine());

			if ((a % 2 == 0)
				&& (b % 2 == 0))
			{
				Console.WriteLine("Both numbers are even");
			}
			else
			{
				Console.WriteLine("One or both of the numbers are odd");
			}
			Console.Read();
		}
	}
}
