﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_F
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, celsius;
            Console.Write("Celsius is:");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (1.8 * celsius) + 32;
            Console.WriteLine($"Fahrenheit={fahrenheit:F2}");
        }
    }
}
