using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var width = 2 * n + 3;
            var height = 2 * n + 1;

            var topSideDots = 0;
            var topDots = n;

            for (int i = 1; i <= n; i++)
            {

                Console.Write(new string('.', topSideDots));
                Console.Write("*");
                if (i == n)
                {
                    Console.Write("*");
                    Console.Write("*");
                    Console.Write("*");
                }
                else
                {
                    Console.Write(new string('.', topDots));
                    Console.Write("*");
                    Console.Write(new string('.', topDots));
                }
                Console.Write("*");
                Console.WriteLine(new string('.', topSideDots));
                topSideDots++;
                topDots--;

            }
            Console.WriteLine(new string('*',width));

           
            for (int i = n; i >= 1; i--)
            {
                topSideDots--;
                topDots++;

                Console.Write(new string('.', topSideDots));
                Console.Write("*");
                if (i == n)
                {
                    Console.Write("*");
                    Console.Write("*");
                    Console.Write("*");
                }
                else
                {
                    Console.Write(new string('.', topDots));
                    Console.Write("*");
                    Console.Write(new string('.', topDots));
                }
                Console.Write("*");
                Console.WriteLine(new string('.', topSideDots));

                
            }


        }
    }
}
