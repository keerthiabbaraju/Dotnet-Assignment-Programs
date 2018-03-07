using System;

namespace OddPositionString
{
    class Program
	{
		static void Main(string[] args)
		{
			string a;
			string b = "";
			Console.Write("Enter a string: ");
			a = Console.ReadLine();
			for (int i = 0; i < a.Length; i++)
			{
				if (i % 2 == 0) {
					b = b + a[i];
				}
			}
			Console.Write("String made with odd position characters is: " + b);
			Console.ReadLine();
		}
	}
}
