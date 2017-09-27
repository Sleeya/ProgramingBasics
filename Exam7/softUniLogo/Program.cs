using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softUniLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var wide = (12 * n) - 5;
            var top = (2 * n) - 1;
            var hashtagNum = 1;
            var dots = (wide - 1) / 2;
            var bottom = ((4 * n) - 2) - top-1;
            var bottomLeftDots = 2;
            var bottomRightDots = 3;
            var bottomHashtags = wide - 6;


            for (int i = 1; i <= top+1; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write(new string('#', hashtagNum));
                Console.WriteLine(new string('.', dots));
                hashtagNum += 6;
                dots -= 3;
            }

            

            for (int i = 1; i <= bottom; i++)
            {
                if (i == bottom)
                {
                    Console.Write("@");
                    Console.Write(new string('.', bottomLeftDots));
                    Console.Write(new string('#', bottomHashtags));
                    Console.WriteLine(new string('.', bottomRightDots));
                }

                else
                {
                    Console.Write("|");
                    Console.Write(new string('.', bottomLeftDots));
                    Console.Write(new string('#', bottomHashtags));
                    Console.WriteLine(new string('.', bottomRightDots));
                }

                if (i <= n-2)
                {
                    bottomLeftDots += 3;
                    bottomRightDots += 3;
                    bottomHashtags -= 6;
                }
                
                



            }
        }
    }
}
