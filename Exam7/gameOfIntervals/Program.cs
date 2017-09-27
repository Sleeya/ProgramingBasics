using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var moves = double.Parse(Console.ReadLine());
            var bonusScore = 0.0;
            var nullToNine = 0;
            var tenToNineteen = 0;
            var twentyToTwentyNine = 0;
            var thirtyToThirtyNine = 0;
            var fourtyToFourtyNine = 0;
            var invalid = 0;

            for (int i = 0; i < moves; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (number <= 9 && number >= 0)
                {
                    bonusScore += number * 0.2;
                    nullToNine++;
                }

                else if (number >= 10 && number <= 19)
                {
                    bonusScore += number * 0.3;
                    tenToNineteen++;
                }
                else if (number >= 20 && number <= 29)
                {
                    bonusScore += number * 0.4;
                    twentyToTwentyNine++;
                }
                else if (number >= 30 && number <= 39)
                {
                    bonusScore += 50;
                    thirtyToThirtyNine++;
                }
                else if (number >= 40 && number <= 50)
                {
                    bonusScore += 100;
                    fourtyToFourtyNine++;

                }
                else if (number < 0 || number > 50)
                {
                    bonusScore /= 2;
                    invalid++;
                }
            }

            Console.WriteLine($"{bonusScore:f2}");
            Console.WriteLine($"From 0 to 9: {(nullToNine / moves) * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {(tenToNineteen / moves) * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {(twentyToTwentyNine / moves) * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {(thirtyToThirtyNine / moves) * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {(fourtyToFourtyNine / moves) * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {(invalid / moves) * 100:f2}%");
        }
    }
}

