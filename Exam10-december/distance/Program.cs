using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var originalSpeedKmH = double.Parse(Console.ReadLine());
            var time1Min = double.Parse(Console.ReadLine());
            var time2Min = double.Parse(Console.ReadLine());
            var time3Min = double.Parse(Console.ReadLine());

            var time1 = time1Min / 60;
            var time2 = time2Min / 60;
            var time3 = time3Min / 60;

            var distance = (originalSpeedKmH * time1) + ((originalSpeedKmH * 1.10) * time2) + (((originalSpeedKmH * 1.10) * 0.95) * time3);

            Console.WriteLine($"{distance:f2}");




        }
    }
}
