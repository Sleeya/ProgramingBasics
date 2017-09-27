using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var n = (number / 100) + ((number / 10) % 10);
            var m = (number / 100) + (number % 10);
            var finalNumber = number;
            for (int i = 0; i < n; i++)
            {
                for (int i2 = 0; i2 < m; i2++)
                {
                    if (finalNumber % 5 == 0)
                    {
                        finalNumber -= (number / 100);
                    }
                    else if (finalNumber % 3 == 0)
                    {
                        finalNumber -= ((number / 10) % 10);
                    }
                    else
                    {
                        finalNumber += (number % 10);
                    }
                    Console.Write($"{finalNumber} ");
                }
                Console.WriteLine();
            }



        }
    }
}
