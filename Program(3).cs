using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fib
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 0;
            int a2 = 1;
            int s = 0;
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            int b = n;
            Console.Write(a1 + " "+a2+" ");

            while (n>s && n!=0)
            {
                s = a1 + a2;
                if (n == a1 || n == a2 || n == s)
                    n = 0;
                a1 = a2;
                a2 = s;
                Console.Write(s + " ");

            }
            Console.WriteLine();
            Console.WriteLine(b+" is " + (n == 0 ? "" : "not"));
            Console.ReadKey();
        }
    }
}