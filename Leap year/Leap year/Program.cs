using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_year
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter year:");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine($"{year} is Leap year");
            }
            else if (year % 4==0 && year %100 != 0)
            {
                Console.WriteLine($"{year} is Leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not Leap year");
            }
        }
    }
}
