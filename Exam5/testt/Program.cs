using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testt
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 1.0;
            while (n <=100)
            {
                Console.WriteLine(n);
                n += 0.0000001;
            }
        }
    }
}
