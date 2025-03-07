using System;

namespace Simple_If_else_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 0;
            int number;
            Console.Write("Enter the number:");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Positive Number");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative Number");
            }
            else
            {
                Console.WriteLine($"The ans is :{number}");
            }
        }
    }
}
