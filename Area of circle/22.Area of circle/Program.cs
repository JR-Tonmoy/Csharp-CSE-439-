﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Area_of_circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, circleArea;
            Console.WriteLine("Circle Area Calculator");

            Console.WriteLine("radius=");
            radius = Convert.ToInt16(Console.ReadLine());

            circleArea = 3.1416 * radius * radius;
            Console.WriteLine($"CircleArea is:{circleArea.ToString("F2")}");

        }
    }
}
