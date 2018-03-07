using System;

namespace Triangle
{
	class Program
	{
		static void Main()
		{
			Console.Write("Enter a number: ");
			int a = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter width: ");
			int b = Convert.ToInt32(Console.ReadLine());

			int c = b;
			for (int i = 0; i < c; i++)
			{
				for (int j = 0; j < b; j++)
				{
					Console.Write(a);
				}

				Console.WriteLine();
				b--;
			}
			Console.Read();
		}
	}
}
