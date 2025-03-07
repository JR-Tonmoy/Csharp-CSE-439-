using System;

namespace Letter_grade_nested_if
{
    class Program
    {
        static void Main(string[] args)
        {
            double marks;
            Console.Write("Enter the Mark: ");
            marks = Convert.ToDouble(Console.ReadLine());

            if (marks >= 0 && marks <= 100)
            {
                if (marks >= 90)
                {
                    Console.WriteLine("A");
                }
                else if (marks >= 80)
                {
                    Console.WriteLine("B");
                }
                else if (marks >= 70)
                {
                    Console.WriteLine("C");
                }
                else if (marks >= 60)
                {
                    Console.WriteLine("D");
                }
                else
                {
                    Console.WriteLine("F");
                }
            }
            else
            {
                Console.WriteLine($"{marks} is an Invalid input. Please enter a value between 0 and 100.");
            }
        }
    }
}
