using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            var hoursNeeded = int.Parse(Console.ReadLine());
            var deadLine = int.Parse(Console.ReadLine());
            var workersDoingOvertime = int.Parse(Console.ReadLine());


            var workdays = (deadLine * 0.9) * 8;
            var totalOvertime = workersDoingOvertime * (2 * deadLine);
            var totalHours = workdays + totalOvertime;

            if (totalHours >= hoursNeeded)
            {
                Console.WriteLine($"Yes!{Math.Floor(totalHours - hoursNeeded)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Ceiling(hoursNeeded - totalHours)} hours needed.");
            }



        }
    }
}
