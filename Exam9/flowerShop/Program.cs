using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnoliiCount = double.Parse(Console.ReadLine());
            var ziumbiulCount = double.Parse(Console.ReadLine());
            var roseCount = double.Parse(Console.ReadLine());
            var cactusCount = double.Parse(Console.ReadLine());
            var presentPrice = double.Parse(Console.ReadLine());

            var magnolii = magnoliiCount * 3.25;
            var ziumbiul = ziumbiulCount * 4.0;
            var roses = roseCount * 3.50;
            var cactus = cactusCount * 8.0;

            var totalOrder = (magnolii + ziumbiul + roses + cactus) * 0.95;
            

            if (presentPrice - totalOrder <= 0)
            {
                Console.WriteLine($"She is left with {Math.Floor(totalOrder-presentPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(presentPrice-totalOrder)} leva.");
            }

        }
    }
}
