using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workHours
{
    class Program
    {
        static void Main(string[] args)
        {
            var deadline = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());
            var workDays = double.Parse(Console.ReadLine());

            var workDone = workers * workDays * 8;

            if (workDone >= deadline)
            {
                Console.WriteLine($"{workDone-deadline} hours left");
            }
            else
            {
                Console.WriteLine($"{deadline-workDone} overtime");
                Console.WriteLine($"Penalties: {(deadline-workDone)*workDays}");
            }
        }
    }
}
