using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfHrizantemis = double.Parse(Console.ReadLine());
            var numberOfRoses = double.Parse(Console.ReadLine());
            var numberOfLaletas = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var holiday = Console.ReadLine().ToLower();

            var hrizPrice = 0.0;
            var rosesPrice = 0.0;
            var lalePrice = 0.0;
            var price = 0.0;

            if (season == "spring" || season == "summer")
            {
                hrizPrice = numberOfHrizantemis * 2;
                rosesPrice = numberOfRoses * 4.10;
                lalePrice = numberOfLaletas * 2.50;
                price = hrizPrice + rosesPrice + lalePrice;
                if (holiday == "y")
                {
                    price *= 1.15;
                }
                if (season == "spring" && numberOfLaletas >= 7)
                {
                    price *= 0.95;
                }

            }
            else if (season == "autumn" || season == "winter")
            {
                hrizPrice = numberOfHrizantemis * 3.75;
                rosesPrice = numberOfRoses * 4.50;
                lalePrice = numberOfLaletas * 4.15;
                price = hrizPrice + rosesPrice + lalePrice;
                if (holiday == "y")
                {
                    price *= 1.15;
                }
                if (season == "winter" && numberOfRoses >= 10)
                {
                    price *= 0.90;
                }
            }

            if (numberOfLaletas+numberOfHrizantemis+numberOfRoses >= 20)
            {
                price *= 0.80;
            }

            Console.WriteLine($"{(price+2):f2}");


        }
    }
}
