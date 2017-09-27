using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine().ToLower();
            var days = double.Parse(Console.ReadLine());
            var studioPrice = 0.0;
            var apartmentPrice = 0.0;

            if (month == "may" || month == "october")
            {
                studioPrice += 50;
                apartmentPrice += 65;

                if (days > 7 && days <= 14)
                {
                    studioPrice -= studioPrice * 0.05;
                }
                else if (days > 14)
                {
                    studioPrice -= studioPrice * 0.3;
                    apartmentPrice -= apartmentPrice * 0.1;
                }
            }

            else if (month == "june" || month == "september")
            {
                studioPrice += 75.20;
                apartmentPrice += 68.70;

                if (days > 14)
                {
                    studioPrice -= studioPrice * 0.2;
                    apartmentPrice -= apartmentPrice * 0.1;
                }
            }

            else if (month == "july" || month == "august")
            {
                studioPrice += 76;
                apartmentPrice += 77;

                if (days > 14)
                {
                    apartmentPrice -= apartmentPrice * 0.1;
                }
            }

            Console.WriteLine($"Apartment: {(apartmentPrice * days):f2} lv.");
            Console.WriteLine($"Studio: {(studioPrice * days):f2} lv.");


        }
    }
}
