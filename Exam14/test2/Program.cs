using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourForExam = int.Parse(Console.ReadLine());
            int minutesForExam = int.Parse(Console.ReadLine());
            int hourForArrival = int.Parse(Console.ReadLine());
            int minutesForArrival = int.Parse(Console.ReadLine());

            int timeExam = hourForExam * 60 + minutesForExam;
            int timeArrival = hourForArrival * 60 + minutesForArrival;
            if (timeExam == timeArrival)
                Console.WriteLine("On time");

            else if (timeExam - timeArrival > 0 && timeExam - timeArrival <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", timeExam - timeArrival);
            }

            else if (timeArrival - timeExam > 0 && timeArrival - timeExam < 60)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0:00} minutes after the start", timeArrival - timeExam);
            }
            else if (timeArrival - timeExam >= 60)
            {
                Console.WriteLine("Late");
                int hoursLater = (timeArrival - timeExam) / 60;
                int minutesLater = (timeArrival - timeExam) % 60;
                Console.WriteLine("{0}:{1:00} hours after the start", hoursLater, minutesLater);
            }
            else if (timeExam - timeArrival > 30 && timeExam - timeArrival < 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0:00} minutes before the start", timeExam - timeArrival);
            }
            else if (timeExam - timeArrival >= 60)

            {
                Console.WriteLine("Early");
                int hoursEarlier = (timeExam - timeArrival) / 60;
                int minutesEarlier = (timeExam - timeArrival) % 60;
                Console.WriteLine("{0}:{1:00} hours before the start", hoursEarlier, minutesEarlier);
            }
        }
    }
}
