using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test

    {
        class Program
        {
            static void Main(string[] args)
            {
                double budjet = int.Parse(Console.ReadLine());
                string sezon = Console.ReadLine();
                string clas = "";
                string car = "";
                double naemKola = 0;
                if (budjet <= 100)
                {
                    clas = "Economy class";
                    switch (sezon)
                    {
                        case "Summer":
                            car = "Cabrio";
                            naemKola = budjet * 0.35;
                            break;
                        case "Winter":
                            car = "Jeep";
                            naemKola = budjet * 0.65;
                            break;
                    }
                }
                if (budjet > 100 && budjet <= 500)
                {
                    clas = "Compact class";
                    switch (sezon)
                    {
                        case "Summer":
                            car = "Cabrio";
                            naemKola = budjet * 0.45;
                            break;
                        case "Winter":
                            car = "Jeep";
                            naemKola = budjet * 0.80;
                            break;
                    }

                }
                if (budjet > 500)
                {
                    clas = "Luxury class";
                    car = "Jeep";
                    naemKola = budjet * 0.90;
                }
                Console.WriteLine("{0}", clas);
                Console.Write("{0} ", car);
                Console.Write("- {0:f2}", naemKola);
                Console.WriteLine();
            }
        }
    }

    

