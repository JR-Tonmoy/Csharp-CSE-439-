
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Probler
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            number += 5; //number=number+8;
            Console.WriteLine($"{number}");


            number -= 5;//number=number-5;
            Console.WriteLine($"{number}");

            number *= 5; //number=number*5;
            Console.WriteLine($"{number}");

            number /= 5; //number=number/5;
            Console.WriteLine($"{number}");
        }
    }
}

