using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 1; i++)
            {
                for (int i2 = 1; i2 <= 9; i2++)
                {
                    for (int i3 = 1; i3 <= 9; i3++)
                    {
                        for (int i4 = 1; i4 <= 9; i4++)
                        {
                            for (int i5 = 1; i5 <= 9; i5++)
                            {
                                if (n % i2 == 0 && n % i3 == 0 && n % i4 == 0 && n % i5 == 0)
                                {
                                    Console.Write($"{i2}{i3}{i4}{i5} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
