using System;

namespace ArrayElementsSum
{
    class Program
	{
		static void Main(string[] args)
		{
			int[] a = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
			int b = 0;
			string c = "Sum of array with elements: ";
			for (int i = 0; i < a.Length; i++)
			{
				c = c + a[i] + ", ";
				b = b+a[i];
			}
			Console.WriteLine(c + "is " + b);
			Console.Read();
		}
	}
}
