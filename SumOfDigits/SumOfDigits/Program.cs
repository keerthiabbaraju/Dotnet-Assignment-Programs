using System;

namespace SumOfDigits
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter Number to sum up the digits: ");
			string a = Console.ReadLine();
			int b = Convert.ToInt32(a);
			int c;
			int d = 0;
			while (b > 0)
			{
				c = b % 10;
				d = d + c;
				b = b / 10;
			}
			Console.Write("Sum of the digits of the said integer: " + d);
			Console.ReadLine();
		}
	}
}
