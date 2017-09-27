using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace photoPicture
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfPhotos = int.Parse(Console.ReadLine());
            var typeOfPhotos = Console.ReadLine().ToUpper();
            var orderMethod = Console.ReadLine().ToLower();
            var price = 0.0;

            if (typeOfPhotos == "9X13")
            {
                price = numberOfPhotos * 0.16;

                if (numberOfPhotos >= 50)
                {
                    price *= 0.95;
                }
            }
            else if (typeOfPhotos == "10X15")
            {
                price = numberOfPhotos * 0.16;

                if (numberOfPhotos >= 80)
                {
                    price *= 0.97;
                }
            }
            else if (typeOfPhotos == "13X18")
            {
                price = numberOfPhotos * 0.38;

                if (numberOfPhotos >= 50 && numberOfPhotos <= 100)
                {
                    price *= 0.97;
                }
                else if (numberOfPhotos > 100)
                {
                    price *= 0.95;
                }
            }
            else if (typeOfPhotos == "20X30")
            {
                price = numberOfPhotos * 2.90;

                if (numberOfPhotos >= 10 && numberOfPhotos <= 50)
                {
                    price *= 0.93;
                }
                else if (numberOfPhotos > 50)
                {
                    price *= 0.91;
                }
            }

            if (orderMethod == "online")
            {
                price *= 0.98;
            }
            Console.WriteLine($"{price:f2}BGN");
        }
    }
}
