using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unary_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 15;
            Console.WriteLine(++number);//16
           Console.WriteLine(++number);//17
            Console.WriteLine(number++);//17
            Console.WriteLine(number);//18
            Console.WriteLine(--number);//17
            Console.WriteLine(number--);//17
            Console.WriteLine(number--);//16
            Console.WriteLine(number);
        }
    }
}
