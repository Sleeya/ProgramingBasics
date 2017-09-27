using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjet = double.Parse(Console.ReadLine());
            var houseSquares = double.Parse(Console.ReadLine());
            var numberOfWindows = double.Parse(Console.ReadLine());
            var styrofoamPerPackage = double.Parse(Console.ReadLine());
            var packagePrice = double.Parse(Console.ReadLine());

            var styrofoamRequired = (houseSquares - (numberOfWindows * 2.4)) * 1.1;
            var styrofoamPrice = Math.Ceiling(styrofoamRequired / styrofoamPerPackage) * packagePrice;

            if (budjet >= styrofoamPrice)
            {
                Console.WriteLine($"Spent: {styrofoamPrice:f2}");
                Console.WriteLine($"Left: {budjet-styrofoamPrice:f2}");
            }
            else
            {
                Console.WriteLine($"Need more: {styrofoamPrice-budjet:f2}");
            }

        }
    }
}
