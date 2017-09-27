using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            var inheritance = double.Parse(Console.ReadLine());
            var aimYear = double.Parse(Console.ReadLine());
            var expenses = 0.0;

            for (int i = 1800; i <= aimYear; i++)
            {
                if (i % 2 == 0)
                {
                    expenses += 12000;
                }
                else
                {
                    expenses += 12000 + (50 * (i - 1782));
                }
            }

            var result = inheritance - expenses;

            if (result >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {result:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(result):f2} dollars to survive.");
            }
        }
    }
}
