using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            var specialNumber = int.Parse(Console.ReadLine());
            var controlnumber = int.Parse(Console.ReadLine());
            
            

            for (int m1 = m; m1 >= 1; m1--)
            {
                for (int n1 = n; n1 >= 1; n1--)
                {
                    for (int l1 = l; l1 >= 1; l1--)
                    {
                        var number = (m1 * 100) + (n1 * 10) + l1;
                        if (number % 3 == 0)
                        {
                            specialNumber += 5;
                        }
                        else if (number % 5 == 0)
                        {
                            specialNumber -= 2;
                        }
                        else if (number % 2 == 0)
                        {
                            specialNumber *= 2;
                        }


                        if (specialNumber >= controlnumber)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");
                            return;
                        }
                        if (number == 111)
                        {
                            Console.WriteLine($"No! {specialNumber} is the last reached special number.");
                            return;
                        }
                    }
                }
                
           
                    
            }



        }
    }
}
