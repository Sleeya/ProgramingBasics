using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            var wiskeyPrice = double.Parse(Console.ReadLine());
            var beer = double.Parse(Console.ReadLine());
            var wine = double.Parse(Console.ReadLine());
            var rakia = double.Parse(Console.ReadLine());
            var wiskey = double.Parse(Console.ReadLine());

            var rakiaPrice = wiskeyPrice / 2;
            var winePrice = rakiaPrice * 0.6;
            var beerPrice = rakiaPrice * 0.2;

            
            var sum =  wiskey* wiskeyPrice + rakia *  rakiaPrice +  wine *  winePrice + beer *  beerPrice;

            Console.WriteLine($"{sum:f2}");

        }
    }
}
