using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var vineYard = double.Parse(Console.ReadLine());
            var grapesKg = double.Parse(Console.ReadLine());
            var wineLiters = double.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var grapes = vineYard * grapesKg;
            var wine = (grapes * 0.4) / 2.5;
            var wineDiff = Math.Abs(wine - wineLiters);

            if (wine < wineLiters)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineDiff)} liters wine needed.");
            }
            else if (wine >= wineLiters)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineDiff)} liters left -> {Math.Ceiling(wineDiff / workers)} liters per person.");
            }


        }
    }
}
