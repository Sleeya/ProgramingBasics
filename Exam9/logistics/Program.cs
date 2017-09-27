using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCargos = double.Parse(Console.ReadLine());
            var cargoCounter = 0.0;
            var busCargos = 0.0;
            var busCounter = 0.0;
            var truckCargos = 0.0;
            var truckCounter = 0.0;
            var trainCargos = 0.0;
            var trainCounter = 0.0;


            for (int i = 0; i < numberOfCargos; i++)
            {
                var cargoWeight = double.Parse(Console.ReadLine());
                cargoCounter += cargoWeight;

                if (cargoWeight <= 3)
                {
                    busCargos += cargoWeight * 200;
                    busCounter+=cargoWeight;
                }
                else if (cargoWeight >= 4 && cargoWeight <= 11)
                {
                    truckCargos += cargoWeight * 175;
                    truckCounter += cargoWeight;
                }
                else if (cargoWeight >= 12)
                {
                    trainCargos += cargoWeight * 120;
                    trainCounter += cargoWeight;
                }
            }

            var averagePrice = (busCargos + truckCargos + trainCargos) / cargoCounter;
            var busPercent = (busCounter / cargoCounter) * 100;
            var truckPercent = (truckCounter / cargoCounter) * 100;
            var trainPercent = (trainCounter / cargoCounter) * 100;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{busPercent:f2}%");
            Console.WriteLine($"{truckPercent:f2}%");
            Console.WriteLine($"{trainPercent:f2}%");
        }
    }
}
