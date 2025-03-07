using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitwise_Binary__Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 15;
            int num2 = 90;
            int result;

            result = num1 & num2;
            Console.WriteLine($"{num1} & {num2}={result}");

            result = num1 | num2;
            Console.WriteLine($"{num1} | {num2}={result}");

            result = num1 ^ num2;
            Console.WriteLine($"{num1} ^ {num2}={result}");

            result = 9 >> 1;
            Console.WriteLine($"{9} >> {1}={result}");

            result = 5 << 1;
            Console.WriteLine($"{5} << {1}={result}");

        
        }
    }
}
