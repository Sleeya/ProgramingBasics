using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            var junior = double.Parse(Console.ReadLine());
            var seniors = double.Parse(Console.ReadLine());
            var track = Console.ReadLine().ToLower();
            var taxes = 0.0;
            

            if (track == "trail")
            {
                junior *= 5.50;
                seniors *= 7;
            }
            else if (track == "cross-country")
            {
                if (junior+seniors >= 50)
                {
                    junior *= 6;
                    seniors *= 7.125;
                }
                else
                {
                    junior *= 8;
                    seniors *= 9.50;
                }
            }
            else if (track == "downhill")
            {
                junior *= 12.25;
                seniors *= 13.75;
            }
            else if (track == "road")
            {
                junior *= 20;
                seniors *= 21.50;
            }
            var sum = (junior + seniors)*0.95;

            Console.WriteLine($"{sum:f2}");

        }
    }
}
