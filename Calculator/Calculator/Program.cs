using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	class Program
	{
		static void Main()
		{
			int a, b,result=0;
			char c;

			Console.Write("Enter first number: ");
			a = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Enter second number: ");
			b = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter operation: ");
			c = Convert.ToChar(Console.ReadLine());

            if (c == '+')
            {
                result = a + b;
                Console.WriteLine(result);
            }

            else if (c == '-')
            {
                result = a - b;
                Console.WriteLine(result);
            }

            else if ((c == 'x') || (c == '*'))
            {
                result = a * b;
                Console.WriteLine(result);
            }


            else if (c == '/')
            {
                result = a / b;
                Console.WriteLine(result);
            }


            else
                Console.WriteLine("Wrong Character");
			Console.Read();
		}
	}
}
