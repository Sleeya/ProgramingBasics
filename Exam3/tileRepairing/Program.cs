using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tileRepairing
{
    class Program
    {
        static void Main(string[] args)
        {
            var yardSide = double.Parse(Console.ReadLine());
            var tileSide1 = double.Parse(Console.ReadLine());
            var tileSide2 = double.Parse(Console.ReadLine());
            var benchSide1 = double.Parse(Console.ReadLine());
            var benchSide2 = double.Parse(Console.ReadLine());

            var yard = yardSide * yardSide;
            var tile = tileSide1 * tileSide2;
            var bench = benchSide1 * benchSide2;
            var goal = (yard - bench) / tile;
            Console.WriteLine($"{goal:f2}");
            Console.WriteLine($"{(goal * 0.2):f2}");

        }
    }
}
