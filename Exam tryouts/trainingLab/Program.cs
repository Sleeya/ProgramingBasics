using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = double.Parse(Console.ReadLine());
            var wide = double.Parse(Console.ReadLine());
            wide = (wide * 100) -100;
            height = height * 100   ;
            var sumWide = 0.0;
            var sumHeight = 0.0;
            var total = 0.0;
            

            sumWide =wide / 70;
            sumHeight = height / 120; 
            total = (((int)sumWide * (int)sumHeight) - 3);

            Console.WriteLine(total);
        }
    }
}
