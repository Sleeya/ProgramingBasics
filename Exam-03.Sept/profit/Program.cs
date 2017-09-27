using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profit
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfOneCoins = int.Parse(Console.ReadLine());
            var numberOfTwoCoins = int.Parse(Console.ReadLine());
            var numberOfFives = int.Parse(Console.ReadLine());
            var sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numberOfOneCoins; i++)
            {
                for (int g = 0; g <= numberOfTwoCoins; g++)
                {
                    for (int f = 0; f <= numberOfFives; f++)
                    {
                        if (i*1 + g*2 + f*5 == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {g} * 2 lv. + {f} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
