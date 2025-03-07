using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 5 < 12 ? 1 : 2;//This is to true that's why output is 1
            int result1 = 5 > 55 ? 1 : 0;  //This is False that's why output is 0

            Console.WriteLine($"The First Ans is :{result}");
            Console.WriteLine($"The second number is :{result1}");
        }
    }
}
