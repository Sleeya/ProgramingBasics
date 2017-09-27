using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var washingMachine = double.Parse(Console.ReadLine());
            var toyPrice = double.Parse(Console.ReadLine());
            var money = 0.0;
            var toys = 0.0;



            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += (i / 0.2) - 1;
                }
                else
                {
                    toys++;
                }
            }
            var totalMoney = money + (toys * toyPrice);

            if (totalMoney >= washingMachine)
            {
                Console.WriteLine($"Yes! {(totalMoney-washingMachine):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washingMachine-totalMoney):f2}");
            }



        }
    }
}
