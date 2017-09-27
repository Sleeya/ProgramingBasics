using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charity
{
    class Program
    {
        static void Main(string[] args)
        {
            var campaignDays = double.Parse(Console.ReadLine());
            var numberOfPastrys = double.Parse(Console.ReadLine());
            var numberOfCakes = double.Parse(Console.ReadLine());
            var numberOfWafers = double.Parse(Console.ReadLine());
            var numberOfPancakes = double.Parse(Console.ReadLine());

            var cakes = numberOfPastrys * numberOfCakes * 45 * campaignDays;
            var wafers = numberOfPastrys * numberOfWafers * 5.80 * campaignDays;
            var pancakes = numberOfPastrys * numberOfPancakes * 3.20 * campaignDays;

            var totalMoney = cakes + wafers + pancakes;
            totalMoney -= totalMoney * 0.125;

            Console.WriteLine($"{totalMoney:f2}");



        }
    }
}
