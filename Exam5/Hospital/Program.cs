using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var doctors = 7;
            var TotalTreated = 0;
            var TotalUntreated = 0;




            for (int i = 1; i <= days; i++)
            {
                if (i % 3 == 0 && TotalUntreated > TotalTreated)
                {
                    doctors += 1;
                }
                var patients = int.Parse(Console.ReadLine());

                
                var untreated = patients - doctors;
                var treated = patients - untreated;
                if (patients - doctors < 0)
                {
                    treated = patients;
                    untreated = 0;
                }
                TotalTreated += treated;
                TotalUntreated += untreated;
                
            }

            Console.WriteLine($"Treated patients: {TotalTreated}.");
            Console.WriteLine($"Untreated patients: {TotalUntreated}.");
        }
    }
}
