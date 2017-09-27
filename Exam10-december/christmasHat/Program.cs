using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace christmasHat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var wide = (4 * n) + 1;
            var height = (2 * n) + 5;
            var dashes = 0;
            var dots = (wide - 3) / 2;



            Console.Write(new string('.', (wide -3) /2));
            Console.Write("/");
            Console.Write("|");
            Console.Write("\\");
            Console.WriteLine(new string('.', (wide - 3) / 2));

            Console.Write(new string('.', (wide -3) /2));
            Console.Write("\\");
            Console.Write("|");
            Console.Write("/");
            Console.WriteLine(new string('.', (wide - 3) / 2));

            for (int i = 1; i <= height - 5; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write("*");
                Console.Write(new string('-', dashes / 2));
                Console.Write("*");
                Console.Write(new string('-', dashes / 2));
                Console.Write("*");
                Console.WriteLine(new string('.', dots));
                dashes += 2;
                dots--;
            }

            Console.WriteLine(new string('*', wide));

            for (int i = 1; i <= (wide/2)+1; i++)
            {
                Console.Write("*");
                for (int g = 0; g < 1; g++)
                {
                    if (i == (wide / 2) + 1)
                    {
                        break;
                    }
                    Console.Write(".");
                }

            }
            Console.WriteLine();

            Console.WriteLine(new string('*', wide));




        }
    }
}
