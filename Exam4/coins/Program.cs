using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coins
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoins = int.Parse(Console.ReadLine());
            var yuana = double.Parse(Console.ReadLine());
            var commission = double.Parse(Console.ReadLine());

            var totalBitcoins = bitcoins * 1168;
            var totalYuana = (yuana * 0.15) * 1.76;
            var totalMoneyLv = totalBitcoins + totalYuana;
            var totalMoneyEuro = totalMoneyLv / 1.95;
            var commissionCost = (totalMoneyEuro * commission) / 100;
            var result = totalMoneyEuro - commissionCost;

            Console.WriteLine($"{result:f2}");
        }
    }
}
