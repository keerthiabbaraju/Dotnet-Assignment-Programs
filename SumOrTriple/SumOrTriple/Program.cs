using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOrTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Enter the first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            b = Convert.ToInt32(Console.ReadLine());
            if (a != b)
            {
                c = (a + b);
                
            }
            else
            {
                c = 3 * (a + b);
                
            }

            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
