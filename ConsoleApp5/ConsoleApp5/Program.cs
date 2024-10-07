using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = F(2, 3) + F(5, 7) + F(11, 13);
            Console.WriteLine($"x = {x}");

            Console.ReadKey();
        }
        static double F(double a, double b) 
        { 
            return (Math.Sin(a) + Math.Sin(b)) / (a+b);
        }
    }
}
