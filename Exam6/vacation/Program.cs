using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var oldCount = int.Parse(Console.ReadLine());
            var studentCount = int.Parse(Console.ReadLine());
            var daysCount = int.Parse(Console.ReadLine());
            var transportType = Console.ReadLine().ToLower();


            var transportExpense = 0.0;
            var hotelExpense = daysCount * 82.99;
            var expenseWithCommission = 0.0;


            if (transportType == "train")
            {

                transportExpense = ((oldCount * 24.99) + (studentCount * 14.99))*2;
                if (oldCount + studentCount >= 50)
                {
                    transportExpense *= 0.5;

                }
                expenseWithCommission = (hotelExpense + transportExpense) * 1.10;
            }
            else if (transportType == "bus")
            {

                transportExpense = ((oldCount * 32.50) + (studentCount * 28.50))*2;
                expenseWithCommission = (hotelExpense + transportExpense) * 1.10;
            }
            else if (transportType == "boat")
            {

                transportExpense = ((oldCount * 42.99) + (studentCount * 39.99))*2;
                expenseWithCommission = (hotelExpense + transportExpense) * 1.10;
            }

            else if (transportType == "airplane")
            {

                transportExpense = ((oldCount * 70.00) + (studentCount * 50.00))*2;
                expenseWithCommission = (hotelExpense + transportExpense) * 1.10;
            }

            Console.WriteLine($"{expenseWithCommission:f2}");
        }
    }
}
