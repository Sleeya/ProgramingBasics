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
            var hourOfExam = int.Parse(Console.ReadLine());
            var minuteOfExam = int.Parse(Console.ReadLine());
            var arrivalHour = int.Parse(Console.ReadLine());
            var arrivalMinute = int.Parse(Console.ReadLine());

            var examTime = (hourOfExam * 60) + minuteOfExam;
            var arrivalTime = (arrivalHour * 60) + arrivalMinute;

            var time = examTime - arrivalTime;
            var lateTime = arrivalTime - examTime;
            if (arrivalTime > examTime)
            {
                Console.WriteLine("Late");
            }
            else if (time <=30 && time > 0)
            {
                Console.WriteLine("On time");
                
            }
            else if (examTime == arrivalTime)
            {
                Console.WriteLine("On time");
                return;
            }
            else
            {
                Console.WriteLine("Early");

            }

            if (time < 60 && time > 0)
            {
                Console.WriteLine($"{time} minutes before the start");
            }
            else if (time >= 60)
            {
                if (time % 60 > 9)
                {
                    Console.WriteLine($"{time / 60}:{time % 60} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{time / 60}:0{time % 60} hours before the start");
                }
               
            }
            else if (lateTime < 60 && lateTime > 0)
            {
                Console.WriteLine($"{lateTime} minutes after the start");
            }
            else if  (lateTime >= 60)
            {
                if (lateTime % 60 > 9)
                {
                    Console.WriteLine($"{lateTime / 60}:{lateTime % 60} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{lateTime / 60}:0{lateTime % 60} hours after the start");
                }
                
            }
        }
    }
}
