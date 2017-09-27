using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tailoringCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfTables = int.Parse(Console.ReadLine());
            var lengthOfTables = double.Parse(Console.ReadLine());
            var widthOfTables = double.Parse(Console.ReadLine());

            var cover = numberOfTables * (lengthOfTables + (2 * 0.30)) * (widthOfTables + (2 * 0.30));
            var square = numberOfTables * ((lengthOfTables / 2) * (lengthOfTables / 2));

            var dollarPrice = (cover * 7) + (square * 9);
            var levaPrice = dollarPrice * 1.85;

            Console.WriteLine($"{dollarPrice:f2} USD");
            Console.WriteLine($"{levaPrice:f2} BGN");
        }
    }
}
