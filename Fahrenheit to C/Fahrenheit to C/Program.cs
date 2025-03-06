using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrenheit_to_C
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, Celsius;
            Console.Write("Fahrenheit:");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            Celsius = (fahrenheit - 32) / 1.8;
             Console.WriteLine($"Celsius={ Celsius:F2}");
           // Console.WriteLine($"celsius={celsius.ToString("F2")}");
        }
    }
}
