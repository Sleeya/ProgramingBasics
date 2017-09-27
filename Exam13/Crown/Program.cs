using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var wide = (2 * n) - 1;
            var height = (n / 2) + 4;

            Console.Write("@");
            Console.Write(new string(' ', (wide - 3) / 2));
            Console.Write("@");
            Console.Write(new string(' ', (wide - 3) / 2));
            Console.WriteLine("@");

            var dots = 0;
            var middleDots = 0; ;
            var space = (wide - 5) / 2;

            for (int i = 1; i <= n/2; i++)
            {
                if (i==n/2)
                {
                    space = 0;
                }
                if (i==2)
                {
                    middleDots = 1;
                }
                Console.Write("*");
                Console.Write(new string('.', dots));
                Console.Write("*");
                Console.Write(new string(' ', space));
                if (i != n / 2)
                {
                    Console.Write("*");
                }
                
                Console.Write(new string('.', middleDots));
                if (i>=2 && i!=n/2)
                {
                    Console.Write("*");
                }
                Console.Write(new string(' ', space));
                Console.Write("*");
                Console.Write(new string('.', dots));
                Console.WriteLine("*");

                middleDots += 2;
                dots++;
                space-=2;
            }

            Console.Write("*");
            Console.Write(new string('.', n / 2));
            Console.Write(new string('*',(middleDots-3)/2));
            Console.Write(".");
            Console.Write(new string('*', (middleDots - 3 )/ 2));
            Console.Write(new string('.', n / 2));
            Console.WriteLine("*");

            Console.WriteLine(new string('*', wide));
            Console.WriteLine(new string('*', wide));







        }
    }
}
