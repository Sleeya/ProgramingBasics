using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruitCoctails
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var type = Console.ReadLine().ToLower();
            var numberOfCocktails = double.Parse(Console.ReadLine());
            var price = 0.0;

            if (type == "small")
            {
                if (fruit == "watermelon")
                {
                    price = numberOfCocktails * (56*2);
                }
                else if (fruit == "mango")
                {
                    price = numberOfCocktails * (36.66 *2);
                }
                else if (fruit == "pineapple")
                {
                    price = numberOfCocktails * (42.10 * 2);
                }
                else if (fruit == "raspberry")
                {
                    price = numberOfCocktails * (20 * 2);
                }
            }

            else if (type == "big")
            {
                if (fruit == "watermelon")
                {
                    price = numberOfCocktails * (28.70 * 5);
                }
                else if (fruit == "mango")
                {
                    price = numberOfCocktails * (19.60 * 5);
                }
                else if (fruit == "pineapple")
                {
                    price = numberOfCocktails * (24.80 * 5);
                }
                else if (fruit == "raspberry")
                {
                    price = numberOfCocktails * (15.20 * 5);
                }
            }

            if (price >= 400 && price <= 1000)
            {
                price *= 0.85;
            }
            else if (price > 1000)
            {
                price *= 0.5;
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
