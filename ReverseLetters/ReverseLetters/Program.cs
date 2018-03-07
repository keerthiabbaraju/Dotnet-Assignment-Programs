using System;

namespace ReverseLetters
{
	class Program
	{
		static void Main()
		{
			char a;
			char b;
			char c;

			Console.Write("Input letter: ");
			a = Convert.ToChar(Console.ReadLine());

			Console.Write("Input letter: ");
			b = Convert.ToChar(Console.ReadLine());

			Console.Write("Input letter: ");
			c = Convert.ToChar(Console.ReadLine());

			Console.WriteLine(c+", "+b + ", " + a);
			Console.Read();
		}
	}
}

