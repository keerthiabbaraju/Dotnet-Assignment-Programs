using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int i;
            int b;
            Console.WriteLine("Enter the number");
            a = Convert.ToInt32(Console.ReadLine());
            for(i=0;i<=10;i++)
            {
                b = a * i;
            Console.WriteLine(a+"*"+i+" = "+b);
                
            }
            Console.ReadLine();
            
        }
    }
}
