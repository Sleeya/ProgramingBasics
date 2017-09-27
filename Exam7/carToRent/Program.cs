using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carToRent
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjet = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();




            if (budjet <= 100)
            {
                Console.WriteLine("Economy class");

                if (season == "summer")
                {
                    Console.WriteLine($"Cabrio - {budjet * 0.35:f2}");
                }
                else
                {
                    Console.WriteLine($"Jeep - {budjet * 0.65:f2}");
                }
            }

            else if (budjet > 100 && budjet <= 500)
            {
                Console.WriteLine("Compact class");

                if (season == "summer")
                {
                    Console.WriteLine($"Cabrio - {budjet *= 0.45:f2}");
                }
                else
                {
                    Console.WriteLine($"Jeep - {budjet *= 0.80:f2}");
                }
            }

            else if (budjet > 500)
            {
                Console.WriteLine("Luxury class");
                Console.WriteLine($"Jeep - {budjet *= 0.90:f2}");
            }
        }
    }
}
