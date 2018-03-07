using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap
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
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After Swapping");
            Console.WriteLine("First Number is : " + a);
            Console.WriteLine("Second Number is : " + b);
            Console.ReadLine();

           

            

        }
    }
}
