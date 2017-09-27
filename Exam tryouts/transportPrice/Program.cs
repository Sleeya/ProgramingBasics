using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var dayNight = Console.ReadLine().ToLower();
            var taxi = 0.70;
            var autobus = 0.0;
            var train = 0.0;
            var expense = 0.0;

            if (length >= 100)
            {
                expense = length * 0.06;

            }
            else if (length >= 20 && length <= 100)
            {
                expense = length * 0.09;
            }
            else
            {
                if (dayNight == "day")
                {
                    expense = (length * 0.79) + taxi;

                }
                else
                {
                    expense = (length * 0.90) + taxi;
                }
            }
            Console.WriteLine(expense);
        }
    }
}
