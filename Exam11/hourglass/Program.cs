using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var wide = (2 * n) + 1;
            var topDots = 2;
            var topAts = wide - 6;
            var botDots = (wide - 3) / 2;
            var botSpace = 0;
            var botAts = 1;
            
                
            Console.WriteLine(new string('*', wide));

            Console.Write(".");
            Console.Write("*");
            Console.Write(new string(' ', wide - 4));
            Console.Write("*");
            Console.WriteLine(".");

            for (int i = 1; i <= n-2; i++)
            {
                Console.Write(new string('.', topDots));
                Console.Write("*");
                Console.Write(new string('@', topAts));
                Console.Write("*");
                Console.WriteLine(new string('.', topDots));

                topDots++;
                topAts -= 2;
            }

            Console.Write(new string('.', (wide - 1) / 2));
            Console.Write("*");
            Console.WriteLine(new string('.', (wide - 1) / 2));

            for (int i = 1; i < n-1; i++)
            {
                Console.Write(new string('.', botDots));
                Console.Write("*");
                Console.Write(new string(' ', botSpace));
                Console.Write(new string('@', botAts));
                Console.Write(new string(' ', botSpace));
                Console.Write("*");
                Console.WriteLine(new string('.', botDots));

                botDots--;
                botSpace++;
            }

            Console.Write(".");
            Console.Write("*");
            Console.Write(new string('@', wide - 4));
            Console.Write("*");
            Console.WriteLine(".");

            Console.WriteLine(new string('*', wide));



        }
    }
}
