using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var ctrlNumber = int.Parse(Console.ReadLine());

            var sum = 0.0;
            var counter = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int g = m; g >= 1; g--)
                {
                    counter++;
                    sum += (i * 2) + (g * 3);
                    if (sum >= ctrlNumber)
                    {
                        
                        Console.WriteLine($"{counter} moves");
                        Console.WriteLine($"Score: {sum} >= {ctrlNumber}");
                        return;
                    }
                    else if (i == n && g == 1)
                    {
                        Console.WriteLine($"{counter} moves");
                    }
                    
                }
            }
        }
    }
}
