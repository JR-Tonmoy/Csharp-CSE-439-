using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relational_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            int number3 = 10;

            Console.WriteLine(number1 > number2);
            Console.WriteLine(number1 < number2);
            Console.WriteLine(number1 == number3);
            Console.WriteLine(number1 <= number2);
            Console.WriteLine(number2 != number3);

        }
    }
}
/*int number1, number2, number3;
Console.WriteLine("Enter the number:");
number1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Enter the number:");
number2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Enter the number:");
number3 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine(number1 > number2);
Console.WriteLine(number1 < number2);
Console.WriteLine(number1 == number3);
Console.WriteLine(number1 <= number2);
Console.WriteLine(number2 != number3);*/
