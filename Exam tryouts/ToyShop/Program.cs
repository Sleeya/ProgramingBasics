using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var tripPrice = double.Parse(Console.ReadLine());
            var puzzleCount = int.Parse(Console.ReadLine());
            var dollCount = int.Parse(Console.ReadLine());
            var bearCount = int.Parse(Console.ReadLine());
            var minionCount = int.Parse(Console.ReadLine());
            var truckCount = int.Parse(Console.ReadLine());

            var puzzlePrice = puzzleCount * 2.60;
            var dollPrice = dollCount * 3.00;
            var bearPrice = bearCount * 4.10;
            var minionPrice = minionCount * 8.20;
            var truckPrice = truckCount * 2.00;

            var totalPrice = puzzlePrice + dollPrice + bearPrice + minionPrice + truckPrice;
            var totalToyCount = puzzleCount + dollCount + bearCount + minionCount + truckCount;
            if (totalToyCount >= 50)
            {
                totalPrice = totalPrice * 0.75;
            }
            var totalPriceAfterTax = totalPrice * 0.9;

            


            if (totalPriceAfterTax >= tripPrice)
            {
                totalPriceAfterTax -= tripPrice;
                Console.WriteLine($"Yes! {totalPriceAfterTax:f2} lv left.");
            }
            else
            {
                totalPriceAfterTax = tripPrice - totalPriceAfterTax;
                Console.WriteLine($"Not enough money! {totalPriceAfterTax:f2} lv needed."); 
            }




        }
    }
}
