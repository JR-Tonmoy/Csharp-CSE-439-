using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter the number:");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} in Even ");
            }
            else
            {
                Console.WriteLine($"{number} is Odd");
            }
        }
    }
}
