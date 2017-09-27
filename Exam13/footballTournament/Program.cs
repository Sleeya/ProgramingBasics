using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace footballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            var stadiumCapacity = double.Parse(Console.ReadLine());
            var numberOfFans = double.Parse(Console.ReadLine());

            var firstTeam = 0.0;
            var secondTeam = 0.0;
            var sectorA = 0.0;
            var sectorB = 0.0;
            var sectorV = 0.0;
            var sectorG = 0.0;
            var fanbase = 0.0;

            for (int i = 1; i <= numberOfFans; i++)
            {
                var sector = Console.ReadLine().ToLower();
                if (sector == "a" )
                {
                    sectorA++;
                    firstTeam++;
                }
                else if (sector == "b")
                {
                    sectorB++;
                    firstTeam++;
                }
                else if (sector == "v")
                {
                    sectorV++;
                    secondTeam++;
                }
                else
                {
                    sectorG++;
                    secondTeam++;
                }
            }
            sectorA = (sectorA / numberOfFans) * 100;
            sectorB = (sectorB / numberOfFans) * 100;
            sectorV = (sectorV / numberOfFans) * 100;
            sectorG = (sectorG / numberOfFans) * 100;
            fanbase = (numberOfFans / stadiumCapacity) * 100;

            Console.WriteLine($"{sectorA:f2}%");
            Console.WriteLine($"{sectorB:f2}%");
            Console.WriteLine($"{sectorV:f2}%");
            Console.WriteLine($"{sectorG:f2}%");
            Console.WriteLine($"{fanbase:f2}%");
        }
    }
}
