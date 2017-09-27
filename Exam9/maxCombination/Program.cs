using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var maxCounter = int.Parse(Console.ReadLine());
            var counter = 0;
            for (int i = start; i <= end; i++)
            {
                for (int g = start; g <= end; g++)
                {
                    counter++;
                    
                    Console.Write($"<{i}-{g}>");
                    if (counter == maxCounter)
                    {
                        return;
                    }

                }
            }
        }
    }
}
