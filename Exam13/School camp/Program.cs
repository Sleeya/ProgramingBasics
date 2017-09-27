using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine().ToLower();
            var groupType = Console.ReadLine().ToLower();
            var students = double.Parse(Console.ReadLine());
            var overnight = double.Parse(Console.ReadLine());
            string sportType = " ";

            if (season == "winter")
            {
                if (groupType == "boys")
                {
                    overnight *= 9.60 * students;
                    sportType = "Judo";
                }
                else if (groupType == "girls")
                {
                    overnight *= 9.60 * students;
                    sportType = "Gymnastics";
                }
                else  
                {
                    sportType = "Ski";
                    overnight *= 10 * students;
                }
            }

            else if (season == "spring")
            {
                if (groupType == "boys")
                {
                    overnight *= 7.20 * students;
                    sportType = "Tennis";
                }
                else if (groupType == "girls")
                {
                    overnight *= 7.20 * students;
                    sportType = "Athletics";
                }
                else
                {
                    sportType = "Cycling";
                    overnight *= 9.50 * students;
                }
            }

            else if (season == "summer")
            {
                if (groupType == "boys")
                {
                    overnight *= 15 * students;
                    sportType = "Football";
                }
                else if (groupType == "girls")
                {
                    overnight *= 15 * students;
                    sportType = "Volleyball";
                }
                else
                {
                    sportType = "Swimming";
                    overnight *= 20 * students;
                }
            }

            if (students >= 50)
            {
                overnight *= 0.5;
            }
            else if (students<50 && students >= 20)
            {
                overnight *= 0.85;
            }
            else if (students >= 10 && students < 20)
            {
                overnight *= 0.95;
            }

            Console.WriteLine($"{sportType} {overnight:f2} lv.");

        }
    }
}
