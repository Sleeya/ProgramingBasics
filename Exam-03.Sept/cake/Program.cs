using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cake
{
    class Program
    {
        static void Main(string[] args)
        {
            var cakeWidth = int.Parse(Console.ReadLine());
            var cakeLength = int.Parse(Console.ReadLine());
            var pieces = cakeLength * cakeWidth;

            do 
            {
                var number = Console.ReadLine();

                if (number != "STOP")
                {
                    int.TryParse(number, out int numberInt);
                    pieces -= numberInt;

                }
                else if (number == "STOP")
                {
                    break;
                }
                
            } while (pieces >= 0);

            if (pieces > 0)
            {
                Console.WriteLine($"{pieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
            }

        }
    }
}
