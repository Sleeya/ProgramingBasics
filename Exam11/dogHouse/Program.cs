using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = double.Parse(Console.ReadLine());
            var sideLength = double.Parse(Console.ReadLine());
            var roofHeight = double.Parse(Console.ReadLine());

            var front = (height * height) -(1.2 * 2);
            var back = height * height;
            var sides = ((height * sideLength) - (1.5 * 1.5)) * 2;
            var bottom = front + back + sides;

            var roofSides = (height * sideLength)*2;
            var roofTriangle = ((height * roofHeight) / 2) * 2;
            var roof = roofSides + roofTriangle;

            var bottomPaint = bottom / 3.4;
            var roofPaint = roof / 4.3;

            Console.WriteLine($"{bottomPaint:f2}");
            Console.WriteLine($"{roofPaint:f2}");


        }
    }
}
