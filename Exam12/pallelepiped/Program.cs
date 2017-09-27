using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var height = (4 * n) + 4;
            var wide = (3 * n) + 1;
            var topLeftDots = 0;
            var floats = n - 2;
            
            var botLeftDots = 0;
            

            Console.Write("+");
            Console.Write(new string('~', floats));
            Console.Write("+");
            Console.WriteLine(new string('.', (wide-floats-2)));

            for (int i = 1; i <= (2*n)+1; i++)
            {
                var topRightDots = wide - 3 - floats - topLeftDots;
                Console.Write("|");
                Console.Write(new string('.', topLeftDots));
                Console.Write("\\");
                Console.Write(new string('~', floats));
                Console.Write("\\");
                Console.WriteLine(new string('.', topRightDots));
                topLeftDots++;
            }

            for (int i = 1; i <= (2*n)+1; i++)
            {
                var botRightDots = wide - 3 - floats - botLeftDots;

                Console.Write(new string('.', botLeftDots));
                Console.Write("\\");
                Console.Write(new string('.', botRightDots));
                Console.Write("|");
                Console.Write(new string('~', floats));
                Console.WriteLine("|");
                botLeftDots++;
            }

            Console.Write(new string('.', (wide - floats - 2)));
            Console.Write("+");
            Console.Write(new string('~', floats));
            Console.WriteLine("+");
            

        }
    }
}
