using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vegetableStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegetPrice = double.Parse(Console.ReadLine());
            var fruitPrice = double.Parse(Console.ReadLine());
            var vegetKil = double.Parse(Console.ReadLine());
            var fruitKil = double.Parse(Console.ReadLine());

            var vegetTotal = (vegetPrice * vegetKil) / 1.94;
            var fruitTotal = (fruitPrice * fruitKil) / 1.94;
            var Total = vegetTotal + fruitTotal;

            Console.WriteLine(Total);


        }
    }
}
