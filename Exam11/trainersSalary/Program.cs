using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainersSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfLectures = int.Parse(Console.ReadLine());
            var budjet = double.Parse(Console.ReadLine());

            var budjetCut = budjet / numberOfLectures;

            var Jelev = 0.0;
            var RoYaL = 0.0;
            var Roli = 0.0;
            var Trofon = 0.0;
            var Sino = 0.0;
            var others = 0.0;

            for (int i = 1; i <= numberOfLectures; i++)
            {
                var trainer = Console.ReadLine().ToLower();

                if (trainer == "jelev")
                {
                    Jelev += budjetCut;
                }
                else if (trainer == "royal")
                {
                    RoYaL += budjetCut;
                }
                else if (trainer == "roli")
                {
                    Roli += budjetCut;
                }
                else if (trainer == "trofon")
                {
                    Trofon += budjetCut;
                }
                else if (trainer == "sino")
                {
                    Sino += budjetCut;
                }
                else
                {
                    others += budjetCut;
                }

            }

            Console.WriteLine($"Jelev salary: {Jelev:f2} lv");
            Console.WriteLine($"RoYaL salary: {RoYaL:f2} lv");
            Console.WriteLine($"Roli salary: {Roli:f2} lv");
            Console.WriteLine($"Trofon salary: {Trofon:f2} lv");
            Console.WriteLine($"Sino salary: {Sino:f2} lv");
            Console.WriteLine($"Others salary: {others:f2} lv");

        }
    }
}
