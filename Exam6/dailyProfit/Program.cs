using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dailyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            var skumriqPrice = double.Parse(Console.ReadLine());
            var cacaPrice = double.Parse(Console.ReadLine());
            var palamudKg = double.Parse(Console.ReadLine());
            var safridKg = double.Parse(Console.ReadLine());
            var midiKg = double.Parse(Console.ReadLine());

            var palamudPrice = (skumriqPrice * 1.6) * palamudKg;
            var safridPrice = (cacaPrice * 1.8)*safridKg;
            var midiPrice = 7.50 * midiKg;

            var TotalPrice = palamudPrice + safridPrice + midiPrice;

            Console.WriteLine($"{TotalPrice:f2}");

        }
    }
}
