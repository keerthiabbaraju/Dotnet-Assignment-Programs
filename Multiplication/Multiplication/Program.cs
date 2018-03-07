using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
       
        {
            int a;
            int b;
            int c;
           Console.WriteLine("Enter the first number to multiply");
            a = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter the second number to multiply");
            b = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter the third number to multiply");
            c = Convert.ToInt32(Console.ReadLine());
            int d = a * b * c;
            Console.WriteLine(d);
            Console.ReadLine();
        
       
           
         }
    }
}
