using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mirror
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            int b = n;
            int m=0;
            string s = "";
            if (n >= 0)
            {
                while (n >= 10)
                {
                    m = n % 10;
                    s = s + m.ToString();
                    n = n / 10;
                }
                s = s + n.ToString();
                Console.WriteLine(s);
                int x = int.Parse(s);
                if (x == b)
                    Console.WriteLine("Mirror");
                else
                    Console.WriteLine("Not mirror");
             }
            else
                Console.WriteLine("enter number Positive!!!!");

        }
    }
}
