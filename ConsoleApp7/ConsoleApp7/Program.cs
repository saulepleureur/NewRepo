using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var k = GetNumber("k");
            var m = GetNumber("m");
            var n = GetNumber("n");

            if (IsStatementTrue(k, m, n))
                Console.WriteLine("Утверждение истинно");
            else Console.WriteLine("Утверждение ложно");

            Console.ReadKey();
        }

        static bool IsStatementTrue(int k, int m, int n)
        {
            bool K = k % 11 == 0;
            bool M = m % 11 == 0;
            bool N = n % 11 == 0;

            return (K && !M && !N) ||
                   (!K && M && !N) ||
                   (!K && !M && N);
        }

        static int GetNumber(string numberName)
        {
            Console.WriteLine($"Введите число {numberName}");
            return int.Parse(Console.ReadLine());
        }
    }
}

