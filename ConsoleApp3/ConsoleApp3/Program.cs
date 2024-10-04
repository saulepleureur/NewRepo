using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n (100<=n<=999): ");

            double n = int.Parse(Console.ReadLine());
            double a = n / 100;
            double b = n % 10;
            double c = (n / 10) % 10;
            double x = 100 * a + 10 * b + c;

            Console.WriteLine($"Число x: {x}");
            Console.ReadKey();
        }
    }
}
