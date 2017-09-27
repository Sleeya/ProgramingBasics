using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var games = int.Parse(Console.ReadLine());
            var gamesCounter = 0;
            while (true)
            {

                for (int pok1 = 1; pok1 <= p1; pok1++)
                {

                    for (int pok2 = 1; pok2 <= p2; pok2++)
                    {
                        if (gamesCounter == games)
                        {
                            return;
                        }
                        Console.Write($"({pok1} <-> {pok2}) ");
                        gamesCounter++;
                        if (pok1 == p1 && pok2 == p2)
                        {
                            return;
                        }

                    }

                }
                break;
            }

        }
    }
}
