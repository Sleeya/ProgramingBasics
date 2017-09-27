using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var examHour = double.Parse(Console.ReadLine());
            var examMinute = double.Parse(Console.ReadLine());
            var arrivedHour = double.Parse(Console.ReadLine());
            var arrivedMinute = double.Parse(Console.ReadLine());

            examHour = examHour * 60;
            arrivedHour = arrivedHour * 60;
            var arrivalTime = arrivedHour + arrivedMinute;
            var examTime = examHour + examMinute;
            var difference = examTime - arrivalTime;
            if (examTime < arrivalTime)
            {
                Console.WriteLine("Late");
            }
            else if ((examTime == arrivalTime) || (examTime - 30 <= arrivalTime))
            {
                Console.WriteLine("On time");
            }
            else if (arrivalTime < examTime - 30)
            {
                Console.WriteLine("Early");
            }



            if (difference >= 60)
            {
                Console.WriteLine($"{(difference / 60)}:{(difference % 60)} hours before the start");
            }
            if (difference < 60 && difference > 0)
            {
                Console.WriteLine($"{difference} minutes before the start");
            }
            if (difference < 0 && difference <= -60)
            {
                Console.WriteLine($"{(Math.Abs(difference / 60))}:{(Math.Abs(difference % 60))} hours after the start");
            }
            if (difference > -60)
            {
                Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
            }





        }
    }
}
