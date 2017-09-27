using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dailyIncome
{
    class Program
    {
        static void Main(string[] args)
        {

            var workDaysInMonth = int.Parse(Console.ReadLine());
            var earnedMoneyDaily = double.Parse(Console.ReadLine());
            var dollarRatio = double.Parse(Console.ReadLine());

            var monthlyPayment = workDaysInMonth * earnedMoneyDaily;
            var yearlyIncome = monthlyPayment * 12 + monthlyPayment * 2.5;
            var yearlyAfterTaxes = yearlyIncome * 0.75;
            var yearlyInLeva = yearlyAfterTaxes * dollarRatio;
            var averageIncomeDaily = yearlyInLeva / 365;

            Console.WriteLine($"{averageIncomeDaily:f2}");
        }
    }
}
