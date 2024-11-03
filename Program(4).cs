using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            char key = ' ';
            string s = " ";
            do
            {
                key = Console.ReadKey(true).KeyChar;
                s = s + key;
            }
            while (key == '0' || key == '1' || key == '2' || key == '3' || key == '4' || key == '5' || key == '6' || key == '7' || key == '8' || key == '9');
            Console.WriteLine(s);

        }
    }
}
