using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekday_or_Weekend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a day of the Week:");
            String day = Console.ReadLine();
            switch (day)
            {
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    Console.WriteLine("This is Weekday");
                    break;
                case "Sunday":
                case "monday":
                    Console.WriteLine("This is Weekend");
                    break;
                default:
                    Console.WriteLine("Invalid day entered");
                    break;

            }
        }
    }
}