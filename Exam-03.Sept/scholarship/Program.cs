using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            var incomeInLeva = double.Parse(Console.ReadLine());
            var averageGrade = double.Parse(Console.ReadLine());
            var minSalary = double.Parse(Console.ReadLine());

            var socialScholarship = minSalary * 0.35;
            var excellentScholarship = averageGrade * 25;

            if (averageGrade <= 4.50 || incomeInLeva >= minSalary && averageGrade < 5.50)
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }
            else if (incomeInLeva < minSalary && averageGrade > 4.50 && socialScholarship > excellentScholarship)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else if (averageGrade >= 5.50 && excellentScholarship >= socialScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
            }
            else if (averageGrade >= 5.50)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
            }
            else if (incomeInLeva < minSalary && averageGrade > 4.50)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }

        }
    }
}
