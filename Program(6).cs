using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            string s=" ";
            Console.WriteLine("Are you a student?yes/No");
            s=Console.ReadLine();
            if(s=="yes")
            {
               Console.WriteLine("Are you a computer student?yes/No");
               s = Console.ReadLine();
               if(s=="yes")
                {
                    Console.WriteLine("Do you like this?yes/No");
                    s = Console.ReadLine();
                    if (s == "yes")
                        Console.WriteLine("good luck");
                    else
                        Console.WriteLine("Go follow your passion");
                }
               else
                {
                    Console.WriteLine("good luck");
                }

            }
            else
            {
                Console.WriteLine("Do you like to study?yes/No");
                s=Console.ReadLine();
                if (s == "yes")
                    Console.WriteLine("GOOD");
                else
                    Console.WriteLine("This is Not Good");

            }

        }
    }
}
