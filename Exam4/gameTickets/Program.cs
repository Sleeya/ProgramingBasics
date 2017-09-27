using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budjet = double.Parse(Console.ReadLine());
            var category = Console.ReadLine().ToLower();
            var people = double.Parse(Console.ReadLine());
            var tickets = 0.0;
            if (people >= 1 && people <= 4)
            {
                budjet -= (budjet * 75) / 100;
            }
            else if (people >= 5 && people <= 9)
            {
                budjet -= (budjet * 60) / 100;
            }
            else if (people >= 10 && people <= 24)
            {
                budjet -= (budjet * 50) / 100;
            }
            else if (people >= 25 && people <= 49)
            {
                budjet -= (budjet * 40) / 100;
            }
            else if (people >= 50 )
            {
                budjet -= (budjet * 25) / 100;
            }

            if (category == "vip")
            {
                tickets = 499.99 * people;
            }
            else
            {
                tickets = 249.99 * people;
            }

            var difference = Math.Abs(budjet - tickets);

            if (budjet - tickets >= 0)
            {
                Console.WriteLine($"Yes! You have {difference:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {difference:f2} leva.");
            }
        }
    }
}
