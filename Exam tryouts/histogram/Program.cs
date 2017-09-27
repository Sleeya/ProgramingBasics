using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;



            for (int i = 0; i < n; i++)
            {
                var number = double.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1 += 1;
                }
                else if (number >= 200 && number <= 399)
                {
                    p2 += 1;
                }
                else if (number >= 400 && number <= 599)
                {
                    p3 += 1;
                }
                else if (number >= 600 && number <= 799)
                {
                    p4 += 1;
                }
                else
                {
                    p5 += 1;
                }


            }
            var p1sum = (p1 / n) * 100;
            var p2sum = (p2 / n) * 100;
            var p3sum = (p3 / n) * 100;
            var p4sum = (p4 / n) * 100;
            var p5sum = (p5 / n) * 100;

            Console.WriteLine($"{Math.Round(p1sum, 2)}%");
            Console.WriteLine($"{Math.Round(p2sum, 2)}%");
            Console.WriteLine($"{Math.Round(p3sum, 2)}%");
            Console.WriteLine($"{Math.Round(p4sum, 2)}%");
            Console.WriteLine($"{Math.Round(p5sum, 2)}%");
        }
    }
}
