using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var glassesNeeded = int.Parse(Console.ReadLine());
            var numberOfWorkers = int.Parse(Console.ReadLine());
            var workDays = int.Parse(Console.ReadLine());

     
            var workersCapacity  = (numberOfWorkers * 8 * workDays)/5;

            if (workersCapacity >= glassesNeeded)
            {
                Console.WriteLine($"{((workersCapacity-glassesNeeded)*4.2):f2} extra money");
            }
            else
            {
                Console.WriteLine($"Losses: {((glassesNeeded-workersCapacity)*4.2):f2}");
            }


        }
    }
}
