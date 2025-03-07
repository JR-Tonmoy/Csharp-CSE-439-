using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capital__Small_Letter_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            Console.Write("Enter the letter:");
            letter = Convert.ToChar(Console.ReadLine());

            if (letter >= 'A' && letter <= 'Z')
            {
                Console.WriteLine($"{letter} is Capital");
            }
            else
            {
                Console.WriteLine($"{letter} is Small");
            }
        }
    }
}
