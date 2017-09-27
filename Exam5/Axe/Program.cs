using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var leftDash = 3 * n;
            var midDash = 0;
            var rightDash = (5 * n) - midDash - leftDash - 2;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', leftDash));
                Console.Write("*");
                Console.Write(new string('-', midDash));
                Console.Write("*");
                Console.WriteLine(new string('-', rightDash));
                midDash += 1;
                rightDash -= 1;

            }

            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write(new string('*', (3 * n) + 1));
                Console.Write(new string('-', n - 1));
                Console.Write("*");
                Console.WriteLine(new string('-', n - 1));

            }

            midDash = n - 1;
            rightDash = n - 1;
            for (int i = 1; i <= n / 2; i++)
                
            {
                
                Console.Write(new string('-', leftDash));
                Console.Write("*");
                if (i == n / 2)
                {
                    Console.Write(new string('*', midDash));
                }
                else
                {
                    Console.Write(new string('-', midDash));
                }
                
                Console.Write("*");
                Console.WriteLine(new string('-', rightDash));
                leftDash -= 1;
                midDash += 2;
                rightDash -= 1;


            }
        }
    }
}
