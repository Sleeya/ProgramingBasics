using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = double.Parse(Console.ReadLine());
            var n2 = double.Parse(Console.ReadLine());
            var action = Console.ReadLine().ToLower();

            if (n1 == 0)
            {
                Console.WriteLine($"Cannot divide {n2} by zero");
            }

            else if (n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else if (action == "+")
            {
                var result = n1 + n2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} + {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} + {n2} = {result} - odd");
                }
            }
            else if (action == "-")
            {
                var result = n1 - n2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} - {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} - {n2} = {result} - odd");
                }
            }
            else if (action == "*")
            {
                var result = n1 * n2;

                if (result % 2 == 0)
                {
                    Console.WriteLine($"{n1} * {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} * {n2} = {result} - odd");
                }
            }
            else if (action == "/")
            {
                var result = n1 / n2;
                Console.WriteLine($"{n1} / {n2} = {result:f2}");
            }
            else if (action == "%")
            {
                var result = n1 % n2;

                Console.WriteLine($"{n1} % {n2} = {result}");
            }

        }
    }
}
