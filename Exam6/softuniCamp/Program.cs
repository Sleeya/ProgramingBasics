using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softuniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());

            var automobile = 0.0;
            var microBus = 0.0;
            var smallBus = 0.0;
            var bigBus = 0.0;
            var train = 0.0;
            var totalCampers = 0.0;
            var groupSize = 0.0;
            for (int i = 1; i <= n; i++)
            {
                groupSize = double.Parse(Console.ReadLine());

                if (groupSize <= 5)
                {
                    automobile += groupSize;
                }
                else if (groupSize >= 6 && groupSize <= 12)
                {
                    microBus += groupSize;
                }
                else if (groupSize >= 13 && groupSize <= 25)
                {
                    smallBus += groupSize;
                }
                else if (groupSize >= 26 && groupSize <= 40)
                {
                    bigBus += groupSize;
                }
                else if (groupSize >= 41)
                {
                    train += groupSize;
                }

                totalCampers += groupSize;
            }

            Console.WriteLine($"{((automobile / totalCampers) * 100):f2}%");
            Console.WriteLine($"{((microBus / totalCampers) * 100):f2}%");
            Console.WriteLine($"{((smallBus / totalCampers) * 100):f2}%");
            Console.WriteLine($"{((bigBus / totalCampers) * 100):f2}%");
            Console.WriteLine($"{((train / totalCampers) * 100):f2}%");




        }
    }
}
