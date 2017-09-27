using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var daysAway = int.Parse(Console.ReadLine());
            var foodKg = double.Parse(Console.ReadLine());
            var dogFood = double.Parse(Console.ReadLine());
            var catFood = double.Parse(Console.ReadLine());
            var turtleFood = double.Parse(Console.ReadLine());

            var totalDogFood = daysAway * dogFood;
            var totalCatFood = daysAway * catFood;
            var totalTurtleFood = daysAway * (turtleFood/1000) ;
            var totalFoodNeeded = totalCatFood + totalDogFood + totalTurtleFood;

            var foodBalance = foodKg - totalFoodNeeded ;

            if (foodBalance >= 0)
            {
                Console.WriteLine($"{Math.Floor(foodBalance)} kilos of food left.");
            }
            else
            {
                foodBalance = Math.Abs(foodBalance);
                Console.WriteLine($"{Math.Ceiling(foodBalance)} more kilos of food are needed.");
            }
        }
    }
}
