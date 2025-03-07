using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_consonant_Program
{
    class Program
    {
        static void Main(string[] args)
       
            {
                char letter;
                Console.Write("Enter the letter:");
                letter = Convert.ToChar(Console.ReadLine());

            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' ) 
                {
                    Console.WriteLine($"{letter} is Vowel");
                }
                else
                {
                    Console.WriteLine($"{letter} is consonant");
                }
            }
     
    }
}
