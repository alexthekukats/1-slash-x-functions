using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1;
            double i = 1;
            double x1 = x / i;
            double x2 = x / (i * i);
            double x25 = Math.Sqrt((x2 + x / (i * i) * 6.0));

            double x3 = i / i * i;
            double x4 = i * i / i * i;

            for (i = 2; ; i++)
            {
                
                 x1 = x1 + x / i;
                 x2 = x2 + x / (i * i);
                 x25 = Math.Sqrt((x2 + x / (i * i)) * 6.0);

                 x3 = x3 + (2 * Math.Sqrt(i)) / (i * i);
                 x4 = x4 + (i * i) / (2 * i);


                 Console.WriteLine("Ciklusszámláló: " + i);
                 Console.WriteLine();
                 Console.WriteLine();

                Console.WriteLine("f(1/x) = " + x1);
                Console.WriteLine("f(1/x^2) = " + x2);

                Console.WriteLine("f'(1/x) = " + x3);
                Console.WriteLine("f'(1/x^2) = " + x4);
                Console.WriteLine();
                Console.WriteLine("(f(1/x^2) * 6)ˇ2 = " + x25);

                Thread.Sleep(4);
                Console.Clear();
            }
        }
    }
}
