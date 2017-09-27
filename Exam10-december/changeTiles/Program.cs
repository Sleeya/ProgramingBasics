using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changeTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjet = double.Parse(Console.ReadLine());
            var rectangleWide = double.Parse(Console.ReadLine());
            var rectangleLength = double.Parse(Console.ReadLine());
            var triangleSide = double.Parse(Console.ReadLine());
            var triangleHeight = double.Parse(Console.ReadLine());
            var tilePriceEach = double.Parse(Console.ReadLine());
            var workerPrice = double.Parse(Console.ReadLine());

            var rectangle = rectangleWide * rectangleLength;
            var tile = (triangleHeight * triangleSide) / 2;
            var totalTiles = Math.Ceiling(rectangle / tile) + 5;
            var totalPrice = (totalTiles * tilePriceEach) + workerPrice;

            if (totalPrice <= budjet)
            {
                Console.WriteLine($"{(budjet-totalPrice):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {(totalPrice - budjet):f2} lv more.");
            }

        }
    }
}
