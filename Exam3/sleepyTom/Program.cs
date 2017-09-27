using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sleepyTom
{
    class Program
    {
        static void Main(string[] args)
        {
            var vacation = int.Parse(Console.ReadLine());

            var workdays = 365 - vacation;
            var playtime = (workdays * 63) + (vacation * 127);
            var difference = Math.Abs(30000 - playtime);

            if (playtime <= 30000)
            {
                Console.WriteLine($"Tom sleeps well");
                Console.WriteLine($"{(difference / 60)} hours and {(difference % 60)} minutes less for play");
            }
            else
            {
                Console.WriteLine($"Tom will run away");
                Console.WriteLine($"{(difference / 60)} hours and {(difference % 60)} minutes more for play");
            }
        }
    }
}
