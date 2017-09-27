using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var rowlenght = (2 * n) + 3;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('*', i));
                Console.Write("\\");
                Console.Write(new string('-', rowlenght - (i * 2) - 2));
                Console.Write("/");
                Console.WriteLine(new string('*', i));
            }

            for (int i = 0; i < n / 3; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', (n / 2)+i));
                Console.Write("\\");
                Console.Write(new string('*', rowlenght - 4 - (2 * ((n / 2) + i))));
                Console.Write("/");
                Console.Write(new string('*', (n / 2) + i));
                Console.WriteLine("|");

            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', i));
                Console.Write("\\");
                Console.Write(new string('*', rowlenght - (i * 2) - 2));
                Console.Write("/");
                Console.WriteLine(new string('-', i));
            }
        }
    }
}
