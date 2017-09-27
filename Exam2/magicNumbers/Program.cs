using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int g = 1; g <= 9; g++)
                {
                    for (int f = 1; f <= 9; f++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            for (int s = 1; s <= 9; s++)
                            {
                                for (int a = 1; a <= 9; a++)
                                {
                                    if (i*g*f*d*s*a == n)
                                    {
                                        Console.Write($"{i}{g}{f}{d}{s}{a} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
                
            
        }
    }
}
