using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var wide = 3 * n;
            var halfWide = wide / 2;
            var empty = 0;
            var halfTopDots = halfWide - 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', halfTopDots));
                Console.Write("/");
                Console.Write(new string(' ', empty));
                Console.Write("\\");
                Console.WriteLine(new string('.', halfTopDots));
                halfTopDots -= 1;
                empty += 2;
            }

            Console.Write(new string('.', n / 2));
            Console.Write(new string('*', wide -n));
            Console.WriteLine(new string('.', n / 2));

            for (int i = 0; i < n*2; i++)
            {
                Console.Write(new string('.', n / 2));
                Console.Write("|");
                Console.Write(new string('\\', wide - n - 2));
                Console.Write("|");
                Console.WriteLine(new string('.', n / 2));
            }
            var bottomDots = n / 2;
            var stars = wide - n - 2;

            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('.', bottomDots));
                Console.Write("/");
                Console.Write(new string('*', stars));
                Console.Write("\\");
                Console.WriteLine(new string('.', bottomDots));

                bottomDots -= 1;
                stars += 2;

            }


        }
    }
}
