using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write(new string('.', n));
            Console.Write(new string('*', 3 * n));
            Console.WriteLine(new string('.', n));

            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write(new string('.', n - i));
                Console.Write("*");
                Console.Write(new string('.', (3 * n) - 2 + (i * 2)));
                Console.Write("*");
                Console.WriteLine(new string('.', n - i));
            }

            Console.WriteLine(new string('*', 5 * n));
            var numberOfDots = 1;
            var wide = n * 5;
            for (int i = 1; i <= 2 * n; i++)

            {
                Console.Write(new string('.', numberOfDots));
                Console.Write("*");
                Console.Write(new string('.', wide - (numberOfDots * 2) - 2));
                Console.Write("*");
                Console.WriteLine(new string('.', numberOfDots));
                numberOfDots += 1;
            }

            Console.Write(new string('.', (wide - (n - 2))/2));
            Console.Write(new string('*', n - 2));
            Console.WriteLine(new string('.', (wide - (n - 2)) / 2));


        }
    }
}
