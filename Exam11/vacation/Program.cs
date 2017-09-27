using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjet = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();

            if (budjet <= 1000)
            {
                if (season == "summer")
                {
                    Console.WriteLine($"Alaska - Camp - {(budjet * 0.65):f2}");
                }
                else
                {
                    Console.WriteLine($"Morocco - Camp - {(budjet * 0.45):f2}");
                }
            }
            else if (budjet > 1000 && budjet <= 3000)
            {
                if (season == "summer")
                {
                    Console.WriteLine($"Alaska - Hut - {(budjet * 0.80):f2}");
                }
                else
                {
                    Console.WriteLine($"Morocco - Hut - {(budjet * 0.60):f2}");
                }
            }
            else if (budjet > 3000)
            {
                if (season == "summer")
                {
                    Console.WriteLine($"Alaska - Hotel - {(budjet * 0.90):f2}");
                }
                else
                {
                    Console.WriteLine($"Morocco - Hotel - {(budjet * 0.90):F2}");
                }
            }
        }
    }
}
