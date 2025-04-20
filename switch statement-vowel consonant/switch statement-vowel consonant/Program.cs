using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statement_vowel_consonant
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            Console.Write("Enter a sihgle character:");
            letter = Convert.ToChar(Console.ReadLine());

            switch(char.ToLower(letter))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine($"{letter} is vowel.");
                    break;
                default:
                    Console.WriteLine("Not a valid character");
                    break;
                
            }

        }
    }
}
