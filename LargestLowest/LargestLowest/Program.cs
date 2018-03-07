using System;

namespace LargestLowest
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int a;
            int b;
            int c;
            Console.Write("Enter first integer: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second integer: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third integer: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("The largest number is: ");

            if (a > c && a > b)
            {
                Console.WriteLine(a);
            }
            else if (b > c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }

            Console.Write("The smallest number is: ");

            if (a < c && a < b)
            {
                Console.WriteLine(a);
            }
            else if (b < c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }

            Console.Read();
        
        }
    }
}
