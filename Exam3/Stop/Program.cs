using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            Console.Write(new string('.', (n + 2) - 1));
            Console.Write(new string('_', ((n * 2) + 1)));
            Console.WriteLine(new string('.', (n + 2) - 1));

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', (n + 1) - i));
                Console.Write("//");
                Console.Write(new string('_', (n + n-3) +(i * 2)));
                Console.Write("\\\\");
                Console.WriteLine(new string('.', (n + 1) - i));

            }

            Console.Write("//");
            Console.Write(new string('_', (((n*4)-6))/2));
            Console.Write("STOP!");
            Console.Write(new string('_', (((n * 4) - 6)) / 2));
            Console.WriteLine("\\\\");

            Console.Write("\\\\");
            Console.Write(new string('_', ((n * 4) - 1)) );
            Console.WriteLine("//");

            for (int i = n; i > 1; i--)
            {
                Console.Write(new string('.', (n + 1) - i));
                Console.Write("\\\\");
                Console.Write(new string('_', (n + n - 3) + (i * 2)));
                Console.Write("//");
                Console.WriteLine(new string('.', (n + 1) - i));

            }












        }
    }
}
