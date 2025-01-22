using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExam
{
    internal class Program
    {
        static int C(int n)
        {
            int c = 0;

            for (int m = 2; m < n; m++)
            {
                if ((long)m * m * m % n == 1)
                {
                    c++;
                }
            }
            return c;
        }
        static void Main(string[] args)
        {
            long sum = 0;

            for (int n = 2; n < 100000; n++)
            {
                if (C(n) == 8)
                {
                    sum += n;
                }

            }
            Console.WriteLine($"Сумма всех n, где C(n)=8:" + sum);
            Console.ReadKey();
            // занимает примерно минуту
        }
    }
}
