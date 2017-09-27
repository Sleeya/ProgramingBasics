using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var solved = false;
            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        if (a+b+c == n)
                        {
                            if (a < b && b < c)
                            {
                                solved = true;
                                Console.WriteLine($"{a} + {b} + {c} = {n}");
                            }
                        }

                        if (a*b*c == n)
                        {
                            if (a > b && b > c)
                            {
                                solved = true;
                                Console.WriteLine($"{a} * {b} * {c} = {n}");
                            }
                        }
                    }
                }
            }
            if (solved == false)
            {
                Console.WriteLine("No!");
            }
        }
    }
}
