using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var pool = double.Parse(Console.ReadLine());
            var p1 = double.Parse(Console.ReadLine());
            var p2 = double.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());

            var pipe1 = hours * p1;
            var pipe2 = hours * p2;
            var totalPipes = pipe1 + pipe2;
            var poolFilled = (totalPipes / pool) * 100;
            var pipe1Fill = (pipe1 / totalPipes) * 100;
            var pipe2Fill = (pipe2 / totalPipes) * 100;

            double overFlow = totalPipes - pool;
            String.Format("{0:0.0}", overFlow);



            if (totalPipes <= pool)
            {
                Console.WriteLine($"The pool is {Math.Truncate(poolFilled)}% full. Pipe 1: {Math.Truncate(pipe1Fill)}%. Pipe 2: {Math.Truncate(pipe2Fill)}%." );
            }
            else
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {overFlow:f1} liters.");
            }
                


        }
    }
}
