using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shamara
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            var monthlyKm = double.Parse(Console.ReadLine());
            var payCheck = 0.0;

            if (monthlyKm <= 5000)
            {
                if (season == "spring" || season == "autumn")
                {
                    payCheck = monthlyKm * 0.75;
                }
                else if (season == "summer")
                {
                    payCheck = monthlyKm * 0.90;
                }
                else
                {
                    payCheck = monthlyKm * 1.05;
                }
            }

            else if (monthlyKm > 5000 && monthlyKm <= 10000)
            {
                if (season == "spring" || season == "autumn")
                {
                    payCheck = monthlyKm * 0.95;
                }
                else if (season == "summer")
                {
                    payCheck = monthlyKm * 1.10;
                }
                else
                {
                    payCheck = monthlyKm * 1.25;
                }
            }

            else if (monthlyKm > 10000 && monthlyKm <= 20000)
            {
                
                    payCheck = monthlyKm * 1.45;
            }

            var totalPayment = (payCheck * 4) * 0.90;

            Console.WriteLine($"{totalPayment:f2}");
        }
    }
}
