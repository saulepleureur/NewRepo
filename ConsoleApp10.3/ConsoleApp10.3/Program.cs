using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a (1 < a < 2):");
            double a = double.Parse(Console.ReadLine());

            int N = 1;
            double currentNumber = 1 + 1.0 / N;

            while (currentNumber >= a)
            {
                N++;
                currentNumber = 1 + 1.0 / N;
            }

            Console.WriteLine($"1+1/{N}");

            Console.ReadKey();
        }
    }
    }
