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
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());

            var sides = a * (a / 2) * 2;
            var backSide = ((a / 2) * (a / 2)) + (((a / 2) * (b - (a / 2))) / 2);
            var frontSide = backSide - ((a / 5) * (a / 5));
            var roof = (a * (a / 2)) * 2;

            var greenPaint = (sides + backSide + frontSide) / 3;
            var redPaint = roof / 5;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");

        }
    }
}
