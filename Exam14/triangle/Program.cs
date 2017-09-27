using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var wide = (4 * n) + 1;
            var height = (2 * n) + 1;
            var dots = 1;
            var space = 1;
            var hashTags = (wide - dots - space) / 2;
            Console.WriteLine(new string('#', wide));

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.',dots));
                Console.Write(new string('#', hashTags));
                if (i == (n/2)+1)
                {
                    Console.Write(new string(' ', (space-3)/2));
                    Console.Write("(@)");
                    Console.Write(new string(' ', (space -3)/2));
                }
                else
                {
                    Console.Write(new string(' ', space));
                }
                
                Console.Write(new string('#', hashTags));
                Console.WriteLine(new string('.', dots));

                dots++;
                space+=2;
                hashTags -= 2;

            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write(new string('#',wide-(dots*2)));
                Console.WriteLine(new string('.', dots));
                dots++;

            }
            
        }
    }
}
