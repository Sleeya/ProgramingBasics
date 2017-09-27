using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace housePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallestRoom = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var squaredPrice = double.Parse(Console.ReadLine());

            var bathroom = smallestRoom / 2;
            var secondRoom = smallestRoom * 1.1;
            var thirdRoom = secondRoom * 1.1;

            var totalSquares = (smallestRoom + kitchen + bathroom + secondRoom  + thirdRoom )*1.05;
            var totalPrice = totalSquares * squaredPrice;

            Console.WriteLine($"{totalPrice:f2}");


        }
    }
}
