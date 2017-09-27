using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grapeAndRakia
{
    class Program
    {
        static void Main(string[] args)
        {
            var grapeYard = double.Parse(Console.ReadLine());
            var grapesPerSquare = double.Parse(Console.ReadLine());
            var wastage = double.Parse(Console.ReadLine());

            var grapes = grapeYard * grapesPerSquare - wastage;

            var rakiaGrapes = grapes * 0.45;
            var forSaleGrapes = grapes * 0.55;

            var rakia = (rakiaGrapes / 7.5) * 9.80;
            var grapesTotal = forSaleGrapes * 1.5;

            Console.WriteLine($"{rakia:f2}");
            Console.WriteLine($"{grapesTotal:f2}");

        }
    }
}
