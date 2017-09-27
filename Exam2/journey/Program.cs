using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace journey
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjet = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var expense = 0.0;
            

            if (budjet <= 100)
            {
                if (season == "summer")
                {
                    expense = budjet * 30 / 100;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {expense:f2}");
                }
                else
                {
                    expense = budjet * 70 / 100;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {expense:f2}");
                }
            }
            else if (budjet > 100 && budjet <= 1000)
            {
                if (season == "summer")
                {
                    expense = budjet * 40 / 100;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {expense:f2}");
                }
                else
                {
                    expense = budjet * 80 / 100;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {expense:f2}");
                }
            }
            else
            {
                expense = budjet * 90 / 100;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {expense:f2}");
            }
        }
    }
}
