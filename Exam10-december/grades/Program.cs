using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfStudents = double.Parse(Console.ReadLine());
            var betwen2and3 = 0.0;
            var betwen3and4 = 0.0;
            var betwen4and5 = 0.0;
            var overFive = 0.0;
            var counter = 0.0;
            var average = 0.0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                var grade = double.Parse(Console.ReadLine());
                average += grade;
                counter++;
                if (grade <= 2.99)
                {
                    betwen2and3++;
                    
                }
                else if (grade >= 3 && grade <=3.99)
                {
                    betwen3and4++;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    betwen4and5++;
                }
                else if (grade >= 5)
                {
                    overFive++;
                }
            }

            betwen2and3 = (betwen2and3 / numberOfStudents) * 100;
            betwen3and4 = (betwen3and4 / numberOfStudents) * 100;
            betwen4and5 = (betwen4and5 / numberOfStudents) * 100;
            overFive = (overFive / numberOfStudents) * 100;
            average /= numberOfStudents;

            Console.WriteLine($"Top students: {overFive:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {betwen4and5:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {betwen3and4:f2}%");
            Console.WriteLine($"Fail: {betwen2and3:f2}%");
            Console.WriteLine($"Average: {average:f2}");

        }
    }
}
