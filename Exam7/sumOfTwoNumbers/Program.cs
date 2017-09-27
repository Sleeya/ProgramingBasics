using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var intervalStart = int.Parse(Console.ReadLine());
            var intervalEnd = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            var combination = 0;
            

            for (int num1 = intervalStart; num1 <= intervalEnd; num1++)
            {
                for (int num2 = intervalStart; num2 <= intervalEnd; num2++)
                {
                    combination++;
                    if (num1+num2 == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combination} ({num1} + {num2} = {magicNumber})");
                        return;
                    }
                    else if (num1 == num2 && num2 == intervalEnd)
                    {
                        Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
                    }
                    
                }
            }
        }
    }
}
