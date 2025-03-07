using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Large_number_Small_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.Write("Enter the number1:");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number2:");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1>number2)
            {
                Console.WriteLine($"{number1} is Larhe number. ");
            }
            else if(number1<number2)
            {
                Console.WriteLine($"{number1} is Small number.");
            }
            else 
            {
                Console.WriteLine($"numbers are equal.");
            }
        }
    }
}
