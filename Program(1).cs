using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_aval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number1:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number2:");
            int m = int.Parse(Console.ReadLine());
            bool check;

            for (int i = n + 1; i < m; i++)
            {
                check = true;
                for (int j = 2; (check && j < i); j++)
                    if (i % j == 0)
                        check = false;

                if (check)
                    Console.Write("{0} ", i);
            }

        }
    }
}
