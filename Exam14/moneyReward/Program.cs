using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moneyReward
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfParts = int.Parse(Console.ReadLine());
            var pricePerPoint = double.Parse(Console.ReadLine());
            var sum = 0.0;

            for (int i = 1; i <= numberOfParts; i++)
            {
                var numberOfPoints = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    numberOfPoints *= 2;
                }
                sum += pricePerPoint * numberOfPoints;
            }

            Console.WriteLine($"The project prize was {sum:f2} lv.");
        }
    }
}
