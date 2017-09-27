using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lettersCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = Console.ReadLine()[0];
            var end = Console.ReadLine()[0];
            var magicString = Console.ReadLine()[0];
            var counter = 0;

            for (int i = start; i <= end; i++)
            {
                for (int g = start; g <= end; g++)
                {
                    for (int f = start; f <= end; f++)
                    {
                        if (i != magicString && g != magicString && f != magicString)
                        {
                            counter++;
                            Console.Write($"{(char)i}{(char)g}{(char)f} ");
                        }
                    }
                }
            }
            Console.WriteLine($"{counter}");
        }
    }
}
