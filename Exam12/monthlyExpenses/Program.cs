using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthlyExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfMonths = int.Parse(Console.ReadLine());
            var water = 0.0;
            var internet = 0.0;
            var others = 0.0;
            var electricity = 0.0;

            for (int i = 1; i <= numberOfMonths; i++)
            {
                var currentElectricity = double.Parse(Console.ReadLine());

                electricity += currentElectricity;
                water += 20;
                internet += 15;
                others += (20 + 15 + currentElectricity) * 1.20;
            }

            var average = (electricity + water + internet + others) / numberOfMonths;

            Console.WriteLine($"Electricity: {electricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
