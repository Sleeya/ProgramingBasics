using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());

            var counter = 0;
            for (int i = start; i >= end; i--)
            {
                for (int g = start; g >= end; g--)
                {
                    counter++;
                    if (i+g == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {g} = {magicNumber})");
                        return;
                    }
                    else if (i == g && g == end)
                    {
                        Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
                    }
                    
                }
            }
        }
    }
}
