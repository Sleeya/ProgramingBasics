using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dumbPasswords
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int i2 = 1; i2 <= n; i2++)
                {
                    for (char char1 = 'a'; char1 < 'a' + l; char1++)
                    {
                        for (char char2 = 'a'; char2 < 'a' + l; char2++)
                        {
                            for (int i3 = 1; i3 <= n; i3++)
                            {
                                if (i3 > i2 && i3 >i)
                                {
                                    Console.Write($"{i}{i2}{char1}{char2}{i3} ");
                                }
                            }
                        }
                    }
                }
            }





        }
    }
}
