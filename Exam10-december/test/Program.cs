using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.Read());
            int g = int.Parse(Console.Read());

            if (n > g)
            {
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine(g);
            }
        }

    }
}